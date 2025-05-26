using LVGLSharp.Interop;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

unsafe class Program
{
    const int Width = 480;
    const int Height = 320;
    static IntPtr g_hwnd;
    static _lv_display_t* g_display;
    static IntPtr g_lvbuf;
    static int g_bufSize = Width * Height * 4;
    static bool g_running = true;
    static _lv_obj_t* label;
    static int startTick;
    static int mouseX = 0, mouseY = 0;
    static bool mousePressed = false;

    static void ConvertRGB565ToBGRA(byte* src, byte* dst, int pixelCount)
    {
        for (int i = 0; i < pixelCount; i++)
        {
            ushort rgb565 = ((ushort*)src)[i];
            byte r = (byte)(((rgb565 >> 11) & 0x1F) << 3);
            byte g = (byte)(((rgb565 >> 5) & 0x3F) << 2);
            byte b = (byte)((rgb565 & 0x1F) << 3);
            dst[i * 4 + 0] = b; // BGRA
            dst[i * 4 + 1] = g;
            dst[i * 4 + 2] = r;
            dst[i * 4 + 3] = 0xFF;
        }
    }

    [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl) })]
    static unsafe void FlushCb(_lv_display_t* disp_drv, lv_area_t* area, c_uint8* color_p)
    {
        int width = area->x2 - area->x1 + 1;
        int height = area->y2 - area->y1 + 1;
        int pixelCount = width * height;

        byte[] bgraBuf = new byte[pixelCount * 4];
        fixed (byte* pBGRA = bgraBuf)
        {
            ConvertRGB565ToBGRA((byte*)color_p, pBGRA, pixelCount);

            Win32.BITMAPINFO bmi = new Win32.BITMAPINFO();
            bmi.bmiHeader.biSize = (uint)Marshal.SizeOf(typeof(Win32.BITMAPINFOHEADER));
            bmi.bmiHeader.biWidth = width;
            bmi.bmiHeader.biHeight = -height; // top-down DIB
            bmi.bmiHeader.biPlanes = 1;
            bmi.bmiHeader.biBitCount = 32;
            bmi.bmiHeader.biCompression = 0; // BI_RGB
            bmi.bmiHeader.biSizeImage = (uint)(width * height * 4);
            bmi.bmiColors = new uint[256];

            IntPtr hdc = Win32.GetDC(g_hwnd);
            Win32.SetDIBitsToDevice(
                hdc, area->x1, area->y1, (uint)width, (uint)height,
                0, 0, 0, (uint)height,
                (IntPtr)pBGRA, ref bmi, 0);
            Win32.ReleaseDC(g_hwnd, hdc);
        }

        lv_display_flush_ready(disp_drv);
    }

    [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl) })]
    static unsafe void buttonClick(_lv_event_t* obj)
    {
        lv_label_set_text(label, (c_int8*)Marshal.StringToCoTaskMemAnsi(DateTime.Now.ToString()).ToPointer());
    }

    [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl) })]
    static unsafe c_uint32 my_tick()
    {
        return Environment.TickCount - startTick;
    }

    [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl) })]
    static unsafe void MouseReadCb(_lv_indev_t* indev_drv, lv_indev_data_t* data)
    {
        data->point.x = mouseX;
        data->point.y = mouseY;
        data->state = mousePressed ? LV_INDEV_STATE_PR : LV_INDEV_STATE_REL;
    }

    static IntPtr MyWndProc(IntPtr hWnd, uint msg, UIntPtr wParam, IntPtr lParam)
    {
        switch (msg)
        {
            case Win32.WM_DESTROY:
                Win32.PostQuitMessage(0);
                break;
            case 0x0201: // WM_LBUTTONDOWN
                mousePressed = true;
                mouseX = (short)(lParam.ToInt32() & 0xFFFF);
                mouseY = (short)((lParam.ToInt32() >> 16) & 0xFFFF);
                break;
            case 0x0202: // WM_LBUTTONUP
                mousePressed = false;
                mouseX = (short)(lParam.ToInt32() & 0xFFFF);
                mouseY = (short)((lParam.ToInt32() >> 16) & 0xFFFF);
                break;
            case 0x0200: // WM_MOUSEMOVE
                mouseX = (short)(lParam.ToInt32() & 0xFFFF);
                mouseY = (short)((lParam.ToInt32() >> 16) & 0xFFFF);
                break;

        }
        return Win32.DefWindowProc(hWnd, msg, wParam, lParam);
    }


    static void Main(string[] args)
    {
        startTick = Environment.TickCount;

        Win32.WndProcDelegate wndProcDelegate = MyWndProc;
        IntPtr wndProcPtr = Marshal.GetFunctionPointerForDelegate(wndProcDelegate);

        Win32.WNDCLASSEX wc = new Win32.WNDCLASSEX
        {
            cbSize = (uint)Marshal.SizeOf(typeof(Win32.WNDCLASSEX)),
            style = 0,
            lpfnWndProc = wndProcPtr,
            cbClsExtra = 0,
            cbWndExtra = 0,
            hInstance = Win32.GetModuleHandle(null),
            hIcon = IntPtr.Zero,
            hCursor = IntPtr.Zero,
            hbrBackground = IntPtr.Zero,
            lpszMenuName = null,
            lpszClassName = "LVGLSharpWin",
            hIconSm = IntPtr.Zero
        };
        Win32.RegisterClassEx(ref wc);

        g_hwnd = Win32.CreateWindowExW(
            0, "LVGLSharpWin", "LVGL",
            Win32.WS_OVERLAPPEDWINDOW,
            100, 100, Width, Height,
            IntPtr.Zero, IntPtr.Zero, Win32.GetModuleHandle(null), IntPtr.Zero
        );
        Win32.ShowWindow(g_hwnd, 5);
        Win32.UpdateWindow(g_hwnd);

        lv_init();

        lv_tick_set_cb(&my_tick);

        g_display = lv_display_create(Width, Height);

        _lv_indev_t* indev = lv_indev_create();
        lv_indev_set_type(indev, lv_indev_type_t.LV_INDEV_TYPE_POINTER);
        lv_indev_set_read_cb(indev, &MouseReadCb);

        g_lvbuf = Marshal.AllocHGlobal(g_bufSize);
        lv_display_set_buffers(g_display, g_lvbuf.ToPointer(), null, g_bufSize, LV_DISPLAY_RENDER_MODE_FULL);
        lv_display_set_flush_cb(g_display, &FlushCb);

        var scr = lv_scr_act();
        label = lv_label_create(scr);
        lv_label_set_text(label, (c_int8*)Marshal.StringToCoTaskMemAnsi("Hello LVGL!").ToPointer());

        var button = lv_button_create(scr);
        lv_obj_set_pos(button, 50, 30);
        lv_obj_set_size(button, 120, 50);
        var buttonLabel = lv_label_create(button);
        lv_label_set_text(buttonLabel, (c_int8*)Marshal.StringToCoTaskMemAnsi("Click").ToPointer());
        lv_obj_center(buttonLabel);

        lv_obj_add_event_cb(button, &buttonClick, lv_event_code_t.LV_EVENT_CLICKED, null);

        Win32.MSG msg;
        while (g_running)
        {
            if (Win32.PeekMessage(out msg, IntPtr.Zero, 0, 0, 1))
            {
                if (msg.message == 0x0012)
                    break;
                Win32.TranslateMessage(ref msg);
                Win32.DispatchMessage(ref msg);
            }

            lv_timer_handler();
            Thread.Sleep(5);
        }

        g_running = false;
        Marshal.FreeHGlobal(g_lvbuf);
    }
}

class Win32
{
    public const int WS_OVERLAPPEDWINDOW = 0xcf0000;
    public const int WM_DESTROY = 0x0002;

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate IntPtr WndProcDelegate(IntPtr hWnd, uint msg, UIntPtr wParam, IntPtr lParam);

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct WNDCLASSEX
    {
        public uint cbSize;
        public uint style;
        public IntPtr lpfnWndProc;
        public int cbClsExtra;
        public int cbWndExtra;
        public IntPtr hInstance;
        public IntPtr hIcon;
        public IntPtr hCursor;
        public IntPtr hbrBackground;
        public string lpszMenuName;
        public string lpszClassName;
        public IntPtr hIconSm;
    }

    [DllImport("user32.dll", CharSet = CharSet.Unicode)]
    public static extern ushort RegisterClassEx([In] ref WNDCLASSEX lpwcx);

    [DllImport("kernel32.dll")]
    public static extern IntPtr GetModuleHandle(string lpModuleName);

    [DllImport("user32.dll", EntryPoint = "CreateWindowExW", CharSet = CharSet.Unicode)]
    public static extern IntPtr CreateWindowExW(
        int dwExStyle,
        string lpClassName,
        string lpWindowName,
        int dwStyle,
        int x, int y, int nWidth, int nHeight,
        IntPtr hWndParent, IntPtr hMenu, IntPtr hInstance, IntPtr lpParam);

    [DllImport("user32.dll")]
    public static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

    [DllImport("user32.dll")]
    public static extern bool UpdateWindow(IntPtr hWnd);

    [DllImport("user32.dll")]
    public static extern IntPtr GetDC(IntPtr hWnd);
    [DllImport("user32.dll")]
    public static extern int ReleaseDC(IntPtr hWnd, IntPtr hDC);
    [DllImport("gdi32.dll")]
    public static extern int SetDIBitsToDevice(
        IntPtr hdc,
        int x, int y,
        uint dwWidth, uint dwHeight,
        int XSrc, int YSrc,
        uint uStartScan, uint cScanLines,
        IntPtr lpvBits,
        [In] ref BITMAPINFO lpbmi,
        uint fuColorUse
    );

    [DllImport("user32.dll")]
    public static extern bool PeekMessage(out MSG lpMsg, IntPtr hWnd, uint wMsgFilterMin, uint wMsgFilterMax, uint wRemoveMsg);
    [DllImport("user32.dll")]
    public static extern bool TranslateMessage([In] ref MSG lpMsg);
    [DllImport("user32.dll")]
    public static extern IntPtr DispatchMessage([In] ref MSG lpmsg);
    [DllImport("user32.dll")]
    public static extern void PostQuitMessage(int nExitCode);

    [DllImport("user32.dll", EntryPoint = "DefWindowProcW", CharSet = CharSet.Unicode)]
    public static extern int DefWindowProc(IntPtr hWnd, uint msg, UIntPtr wParam, IntPtr lParam);

    [StructLayout(LayoutKind.Sequential)]
    public struct MSG
    {
        public IntPtr hwnd;
        public uint message;
        public UIntPtr wParam;
        public IntPtr lParam;
        public uint time;
        public int pt_x;
        public int pt_y;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct BITMAPINFOHEADER
    {
        public uint biSize;
        public int biWidth;
        public int biHeight;
        public ushort biPlanes;
        public ushort biBitCount;
        public uint biCompression;
        public uint biSizeImage;
        public int biXPelsPerMeter;
        public int biYPelsPerMeter;
        public uint biClrUsed;
        public uint biClrImportant;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct BITMAPINFO
    {
        public BITMAPINFOHEADER bmiHeader;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
        public uint[] bmiColors;
    }
}