using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LVGLSharp
{
    public static partial class Native
    {
        private const string nativeLibName = "Lvgl";

        /// <summary>
        /// Initialize LVGL library.
        /// Should be called before any other LVGL related function.
        /// </summary>
        [DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void lv_init();

        /// <summary>
        /// Deinit the 'lv' library
        /// </summary>
        [DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void lv_deinit();

        /// <summary>
        /// Returns whether the 'lv' library is currently initialized
        /// </summary>
        [DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void lv_is_initialized();
    }
}
