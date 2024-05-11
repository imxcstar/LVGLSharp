using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LVGLSharp
{
    public static partial class NativeWindows
    {
        private const string nativeLibName = "Lvgl";

        [DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Auto)]
        public static extern IntPtr lv_windows_create_display(string title, int hor_res, int ver_res, int zoom_level, bool allow_dpi_override, bool simulator_mode);

        [DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr lv_windows_get_display_window_handle(IntPtr display);

        [DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr lv_windows_acquire_pointer_indev(IntPtr display);

        [DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr lv_windows_acquire_keypad_indev(IntPtr display);

        [DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr lv_windows_acquire_encoder_indev(IntPtr display);
    }
}
