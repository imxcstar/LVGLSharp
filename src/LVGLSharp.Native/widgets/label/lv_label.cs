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
        /// Create a label object
        /// </summary>
        /// <param name="obj">pointer to an object, it will be the parent of the new label.</param>
        /// <returns>pointer to the created button</returns>
        [DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr lv_label_create(IntPtr obj);

        /// <summary>
        /// Set a new text for a label. Memory will be allocated to store the text by the label.
        /// </summary>
        /// <param name="obj">pointer to a label object</param>
        /// <param name="txt">'\0' terminated character string. NULL to refresh with the current text.</param>
        [DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void lv_label_set_text(IntPtr obj, string txt);
    }
}
