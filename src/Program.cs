using LVGLSharp;
using LVGLSharp.Interop;
using SixLabors.Fonts;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Memory;
using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Runtime;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

unsafe class Program
{
    static int Width = 640;
    static int Height = 470;
    static IntPtr g_hwnd;
    static lv_display_t* g_display;
    static IntPtr g_lvbuf;

    static uint g_bufSize = 1024 * 1024 * 4;
    static bool g_running = true;
    static lv_obj_t* label;
    static int startTick;
    static int mouseX = 0, mouseY = 0;
    static bool mousePressed = false;
    static byte[] bgraBuf = new byte[g_bufSize];
    static byte[] _timeBuf = new byte[32];
    static readonly object renderLock = new object();
    static uint last_key_processed;
    static lv_indev_state_t last_key_state_processed = LV_INDEV_STATE_REL;
    static string ime_content = "";
    static bool ignore_next_wmchar = false;
    static volatile int mouseWheelDelta = 0;
    static ConcurrentQueue<uint> key_queue = new ConcurrentQueue<uint>();

    static Win32.BITMAPINFO _bmi = new Win32.BITMAPINFO
    {
        bmiHeader = new Win32.BITMAPINFOHEADER
        {
            biSize = (uint)Marshal.SizeOf(typeof(Win32.BITMAPINFOHEADER)),
            biPlanes = 1,
            biBitCount = 32,
            biCompression = 0 // BI_RGB
        },
        bmiColors = new uint[256]
    };

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
    static unsafe void FlushCb(lv_display_t* disp_drv, lv_area_t* area, byte* color_p)
    {
        lock (renderLock)
        {
            int width = area->x2 - area->x1 + 1;
            int height = area->y2 - area->y1 + 1;
            int pixelCount = width * height;

            fixed (byte* pBGRA = bgraBuf)
            {
                ConvertRGB565ToBGRA((byte*)color_p, pBGRA, pixelCount);

                _bmi.bmiHeader.biWidth = width;
                _bmi.bmiHeader.biHeight = -height;
                _bmi.bmiHeader.biSizeImage = (uint)(width * height * 4);

                IntPtr hdc = Win32.GetDC(g_hwnd);
                Win32.SetDIBitsToDevice(
                    hdc, area->x1, area->y1, (uint)width, (uint)height,
                    0, 0, 0, (uint)height,
                    (IntPtr)pBGRA, ref _bmi, 0);
                Win32.ReleaseDC(g_hwnd, hdc);
            }

            lv_display_flush_ready(disp_drv);
        }
    }

    [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl) })]
    static unsafe void buttonClick(lv_event_t* obj)
    {
        lv_event_code_t code = lv_event_get_code(obj);
        if (code == lv_event_code_t.LV_EVENT_CLICKED)
        {
            string now = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            int len = Encoding.ASCII.GetBytes(now, 0, now.Length, _timeBuf, 0);
            _timeBuf[len] = 0;
            lv_label_set_text(label, _timeBuf);
        }
    }

    [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl) })]
    static unsafe uint my_tick()
    {
        return (uint)(Environment.TickCount - startTick);
    }

    [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl) })]
    static unsafe void MouseReadCb(lv_indev_t* indev_drv, lv_indev_data_t* data)
    {
        data->point.x = mouseX;
        data->point.y = mouseY;
        data->state = mousePressed ? LV_INDEV_STATE_PR : LV_INDEV_STATE_REL;
        data->enc_diff = (short)mouseWheelDelta;
        mouseWheelDelta = 0;
    }

    [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl) })]
    static void KeyboardReadCb(lv_indev_t* indev, lv_indev_data_t* data)
    {
        if (ignore_next_wmchar)
            return;

        if (last_key_state_processed == LV_INDEV_STATE_PR)
        {
            data->key = last_key_processed;
            data->state = LV_INDEV_STATE_REL;
            last_key_state_processed = LV_INDEV_STATE_REL;
            return;
        }

        uint new_key;
        if (key_queue.TryDequeue(out new_key))
        {
            data->key = new_key;
            data->state = LV_INDEV_STATE_PR;

            last_key_processed = new_key;
            last_key_state_processed = LV_INDEV_STATE_PR;
        }
        else
        {
            data->key = 0;
            data->state = LV_INDEV_STATE_REL;
        }
    }

    [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl) })]
    static unsafe void SendTextAreaFocusCb(lv_event_t* e)
    {
        lv_obj_t* target = (lv_obj_t*)lv_event_get_target(e);

        // 获取 TextArea 坐标
        lv_area_t area;
        lv_obj_get_coords(target, &area);

        // TextArea 屏幕坐标
        int ime_x = area.x1;
        int ime_y = area.y2;

        // 设置 IME 候选框位置
        IntPtr hIMC = Win32.ImmGetContext(g_hwnd);
        if (hIMC != IntPtr.Zero)
        {
            Win32.COMPOSITIONFORM compForm = new Win32.COMPOSITIONFORM();
            compForm.dwStyle = Win32.CFS_POINT;
            compForm.ptCurrentPos.x = ime_x;
            compForm.ptCurrentPos.y = ime_y;

            Win32.ImmSetCompositionWindow(hIMC, ref compForm);
            Win32.ImmReleaseContext(g_hwnd, hIMC);
        }
    }


    static IntPtr MyWndProc(IntPtr hWnd, uint msg, UIntPtr wParam, IntPtr lParam)
    {
        switch (msg)
        {
            case Win32.WM_DESTROY:
                g_running = false;
                Win32.PostQuitMessage(0);
                break;
            case 0x0005: // WM_SIZE
                lock (renderLock)
                {
                    int newWidth = lParam.ToInt32() & 0xFFFF;
                    int newHeight = (lParam.ToInt32() >> 16) & 0xFFFF;
                    Width = newWidth;
                    Height = newHeight;
                    // 更新分辨率
                    lv_display_set_resolution(g_display, Width, Height);
                }
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
            case Win32.WM_IME_STARTCOMPOSITION:
                ignore_next_wmchar = true;
                break;
            case 0x0102: // WM_CHAR
                if (ignore_next_wmchar)
                    break;

                key_queue.Enqueue((uint)wParam);
                break;
            case 0x0101: // WM_KEYUP
                if (ignore_next_wmchar)
                {
                    ignore_next_wmchar = false;
                    break;
                }

                break;
            case Win32.WM_IME_COMPOSITION:
                {
                    if (((int)lParam & Win32.GCS_RESULTSTR) != 0)
                    {
                        IntPtr hIMC = Win32.ImmGetContext(hWnd);
                        if (hIMC != IntPtr.Zero)
                        {
                            int size = Win32.ImmGetCompositionStringW(hIMC, Win32.GCS_RESULTSTR, null, 0);
                            if (size > 0)
                            {
                                byte[] buffer = new byte[size];
                                Win32.ImmGetCompositionStringW(hIMC, Win32.GCS_RESULTSTR, buffer, size);
                                string result = Encoding.Unicode.GetString(buffer);
                                ime_content = result;
                                unsafe
                                {
                                    byte[] utf8 = Encoding.UTF8.GetBytes(result + "\0");
                                    var inputObj = lv_group_get_focused(key_inputGroup);
                                    lv_textarea_add_text(inputObj, utf8);
                                }
                                ignore_next_wmchar = true;
                            }
                            Win32.ImmReleaseContext(hWnd, hIMC);
                        }
                    }
                    break;
                }
            case Win32.WM_MOUSEWHEEL:
                {
                    int delta = (short)((wParam.ToUInt64() >> 16) & 0xFFFF);
                    mouseWheelDelta += delta / Win32.WHEEL_DELTA;
                    break;
                }
        }
        return Win32.DefWindowProc(hWnd, msg, wParam, lParam);
    }

    static lv_obj_t* port_dropdown;
    static lv_obj_t* baud_dropdown;
    static lv_obj_t* open_btn;
    static lv_obj_t* recv_textarea;
    static lv_obj_t* send_textarea;
    static lv_obj_t* send_btn;
    static lv_obj_t* clear_btn;
    static lv_obj_t* hex_switch;
    static lv_group_t* key_inputGroup;

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
            hCursor = Win32.LoadCursor(IntPtr.Zero, (IntPtr)32512),
            hbrBackground = IntPtr.Zero,
            lpszMenuName = null,
            lpszClassName = "LVGLSharpWin",
            hIconSm = IntPtr.Zero
        };
        Win32.RegisterClassEx(ref wc);

        g_hwnd = Win32.CreateWindowExW(
            0, "LVGLSharpWin", "LVGLSharp",
            Win32.WS_OVERLAPPEDWINDOW,
            100, 100, Width, Height,
            IntPtr.Zero, IntPtr.Zero, Win32.GetModuleHandle(null), IntPtr.Zero
        );

        Win32.ShowWindow(g_hwnd, 5);
        Win32.UpdateWindow(g_hwnd);

        lv_init();

        lv_tick_set_cb(&my_tick);

        g_display = lv_display_create(Width, Height);

        // Mouse
        lv_indev_t* indev = lv_indev_create();
        lv_indev_set_type(indev, lv_indev_type_t.LV_INDEV_TYPE_POINTER);
        lv_indev_set_read_cb(indev, &MouseReadCb);

        // Keyboard
        lv_indev_t* kbd_indev = lv_indev_create();
        lv_indev_set_type(kbd_indev, lv_indev_type_t.LV_INDEV_TYPE_KEYPAD);
        lv_indev_set_read_cb(kbd_indev, &KeyboardReadCb);
        key_inputGroup = lv_group_create();
        lv_indev_set_group(kbd_indev, key_inputGroup);

        g_lvbuf = Marshal.AllocHGlobal((int)g_bufSize);
        lv_display_set_buffers(g_display, g_lvbuf.ToPointer(), null, g_bufSize, LV_DISPLAY_RENDER_MODE_FULL);
        lv_display_set_flush_cb(g_display, &FlushCb);

        var parent = lv_scr_act();
        lv_obj_set_flex_flow(parent, LV_FLEX_FLOW_COLUMN);
        lv_obj_set_style_pad_all(parent, 10, 0);

        var fallbackFont = lv_obj_get_style_text_font(parent, LV_PART_MAIN);

        var fontManager = new SixLaborsFontManager(SystemFonts.Get("Microsoft YaHei"), 12, Win32.GetDPI(), fallbackFont, [
            61441, 61448, 61451, 61452, 61453, 61457, 61459, 61461, 61465, 61468,
            61473, 61478, 61479, 61480, 61502, 61507, 61512, 61515, 61516, 61517,
            61521, 61522, 61523, 61524, 61543, 61544, 61550, 61552, 61553, 61556,
            61559, 61560, 61561, 61563, 61587, 61589, 61636, 61637, 61639, 61641,
            61664, 61671, 61674, 61683, 61724, 61732, 61787, 61931, 62016, 62017,
            62018, 62019, 62020, 62087, 62099, 62189, 62212, 62810, 63426, 63650
        ]);
        lv_font_t* myFont = fontManager.GetLvFontPtr();

        lv_style_t style;
        lv_style_init(&style);
        lv_style_set_text_font(&style, myFont);

        lv_obj_add_style(parent, &style, 0);

        // 顶部工具行容器
        var toolbar = lv_obj_create(parent);
        lv_obj_set_height(toolbar, 100);
        lv_obj_set_width(toolbar, 600);
        lv_obj_set_flex_flow(toolbar, LV_FLEX_FLOW_ROW);
        lv_obj_set_style_pad_gap(toolbar, 10, 0);

        // 串口号
        var port_label = lv_label_create(toolbar);
        lv_label_set_text(port_label, Encoding.UTF8.GetBytes("串口:"));
        lv_obj_set_height(port_label, 50);

        // 串口下拉
        port_dropdown = lv_dropdown_create(toolbar);
        lv_dropdown_set_options(port_dropdown, Encoding.UTF8.GetBytes("COM1\nCOM2\nCOM3\nCOM4"));
        lv_obj_set_width(port_dropdown, 150);
        lv_obj_set_height(port_dropdown, 50);

        // 波特率
        var baud_label = lv_label_create(toolbar);
        lv_label_set_text(baud_label, Encoding.UTF8.GetBytes("波特率:"));
        lv_obj_set_height(baud_label, 50);

        // 波特率下拉
        baud_dropdown = lv_dropdown_create(toolbar);
        lv_dropdown_set_options(baud_dropdown, Encoding.UTF8.GetBytes("9600\n19200\n38400\n57600\n115200"));
        lv_obj_set_width(baud_dropdown, 150);
        lv_obj_set_height(baud_dropdown, 50);

        // 打开串口按钮
        open_btn = lv_btn_create(toolbar);
        var btn_label = lv_label_create(open_btn);
        lv_label_set_text(btn_label, Encoding.UTF8.GetBytes("打开串口"));
        lv_obj_set_height(btn_label, 30);

        // 接收区容器
        var recv_container = lv_obj_create(parent);
        lv_obj_set_height(recv_container, 190);
        lv_obj_set_width(recv_container, 600);
        lv_obj_set_flex_flow(recv_container, LV_FLEX_FLOW_ROW);
        lv_obj_set_style_pad_gap(recv_container, 10, 0);

        // 接收区
        recv_textarea = lv_textarea_create(recv_container);
        lv_group_add_obj(key_inputGroup, recv_textarea);
        lv_obj_set_flex_grow(recv_textarea, 1);
        lv_obj_set_height(recv_textarea, 150);
        lv_textarea_set_placeholder_text(recv_textarea, Encoding.UTF8.GetBytes("接收的数据..."));

        // 清空按钮
        clear_btn = lv_btn_create(recv_container);
        var clear_label = lv_label_create(clear_btn);
        lv_label_set_text(clear_label, Encoding.UTF8.GetBytes("清空"));
        lv_obj_set_height(clear_label, 30);

        // HEX显示
        hex_switch = lv_switch_create(recv_container);
        var switch_label = lv_label_create(recv_container);
        lv_label_set_text(switch_label, Encoding.UTF8.GetBytes("HEX模式"));
        lv_obj_set_height(switch_label, 50);

        // 发送区容器
        var send_container = lv_obj_create(parent);
        lv_obj_set_height(send_container, 90);
        lv_obj_set_width(send_container, 600);
        lv_obj_set_flex_flow(send_container, LV_FLEX_FLOW_ROW);
        lv_obj_set_style_pad_gap(send_container, 10, 0);

        // 发送区
        send_textarea = lv_textarea_create(send_container);
        lv_obj_set_flex_grow(send_textarea, 1);
        lv_textarea_set_placeholder_text(send_textarea, Encoding.UTF8.GetBytes("输入的数据..."));
        lv_obj_add_event_cb(send_textarea, &SendTextAreaFocusCb, lv_event_code_t.LV_EVENT_FOCUSED, null);
        lv_group_add_obj(key_inputGroup, send_textarea);
        lv_obj_set_height(send_textarea, 50);

        // 发送按钮
        send_btn = lv_btn_create(send_container);
        var send_label = lv_label_create(send_btn);
        lv_label_set_text(send_label, Encoding.UTF8.GetBytes("发送"));
        lv_obj_set_height(send_label, 30);

        Win32.MSG msg;
        while (g_running)
        {
            lv_timer_handler();
            if (Win32.PeekMessage(out msg, IntPtr.Zero, 0, 0, 1))
            {
                if (msg.message == 0x0012)
                    break;
                Win32.TranslateMessage(ref msg);
                Win32.DispatchMessage(ref msg);
            }

            Thread.Sleep(5);
        }

        g_running = false;
        Marshal.FreeHGlobal(g_lvbuf);
    }
}


class Win32
{
    public const int WM_MOUSEWHEEL = 0x020A;
    public const int WHEEL_DELTA = 120;


    public const int WS_OVERLAPPEDWINDOW = 0xcf0000;
    public const int WM_DESTROY = 0x0002;

    [DllImport("user32.dll", CharSet = CharSet.Unicode)]
    public static extern IntPtr LoadCursor(IntPtr hInstance, IntPtr lpCursorName);

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

    public const int WM_IME_STARTCOMPOSITION = 0x010D;
    public const int WM_IME_ENDCOMPOSITION = 0x010E;
    public const int WM_IME_COMPOSITION = 0x010F;
    public const int GCS_RESULTSTR = 0x0800;

    [DllImport("imm32.dll")]
    public static extern IntPtr ImmGetContext(IntPtr hWnd);

    [DllImport("imm32.dll")]
    public static extern int ImmGetCompositionStringW(IntPtr hIMC, int dwIndex, byte[] lpBuf, int dwBufLen);

    [DllImport("imm32.dll")]
    public static extern bool ImmReleaseContext(IntPtr hWnd, IntPtr hIMC);


    [DllImport("imm32.dll")]
    public static extern bool ImmSetCompositionWindow(IntPtr hIMC, ref COMPOSITIONFORM lpCompForm);

    [StructLayout(LayoutKind.Sequential)]
    public struct POINT
    {
        public int x;
        public int y;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct COMPOSITIONFORM
    {
        public int dwStyle;
        public POINT ptCurrentPos;
        public RECT rcArea;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct RECT
    {
        public int left;
        public int top;
        public int right;
        public int bottom;
    }

    public const int CFS_POINT = 0x0002;

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

    [DllImport("gdi32.dll")]
    private static extern int GetDeviceCaps(IntPtr hdc, int nIndex);

    const int LOGPIXELSX = 88;
    const int LOGPIXELSY = 90;

    public static float GetDPI()
    {
        IntPtr hdc = GetDC(IntPtr.Zero);
        int dpiX = GetDeviceCaps(hdc, LOGPIXELSX);
        int dpiY = GetDeviceCaps(hdc, LOGPIXELSY);
        ReleaseDC(IntPtr.Zero, hdc);

        return dpiX;
    }
}