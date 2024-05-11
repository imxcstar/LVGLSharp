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
        /// <summary>
        /// Return a pointer to the active screen on a display
        /// </summary>
        /// <param name="disp">pointer to display which active screen should be get.
        ///                  (NULL to use the default screen)</param>
        /// <returns>pointer to the active screen object (loaded by 'lv_screen_load()')</returns>
        [DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr lv_display_get_screen_active(IntPtr disp);

        /// <summary>
        /// Get the default display
        /// </summary>
        /// <returns>pointer to the default display</returns>
        [DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern IntPtr lv_display_get_default();

        /// <summary>
        /// Get the active screen of the default display
        /// </summary>
        /// <returns>pointer to the active screen</returns>
        public static IntPtr lv_screen_active()
        {
            return lv_display_get_screen_active(lv_display_get_default());
        }
    }
}
