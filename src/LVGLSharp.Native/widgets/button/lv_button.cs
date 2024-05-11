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
        /// Create a button object
        /// </summary>
        /// <param name="obj">pointer to an object, it will be the parent of the new button</param>
        /// <returns>pointer to the created button</returns>
        [DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr lv_button_create(IntPtr obj);
    }
}
