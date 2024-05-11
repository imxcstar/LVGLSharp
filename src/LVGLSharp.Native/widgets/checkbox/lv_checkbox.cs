using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LVGLSharp
{
    public static partial class Native
    {
#if LV_USE_CHECKBOX
        /// <summary>
        /// Create a check box object
        /// </summary>
        /// <param name="obj">pointer to an object, it will be the parent of the new button</param>
        /// <returns>pointer to the created check box</returns>
        [DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr lv_checkbox_create(IntPtr obj);

        /// <summary>
        /// Set the text of a check box. `txt` will be copied and may be deallocated
        /// after this function returns.
        /// </summary>
        /// <param name="obj">pointer to a check box</param>
        /// <param name="txt">the text of the check box. NULL to refresh with the current text.</param>
        [DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void lv_checkbox_set_text(IntPtr obj, string txt);

        /// <summary>
        /// Set the text of a check box. `txt` must not be deallocated during the life
        /// of this checkbox.
        /// </summary>
        /// <param name="obj">pointer to a check box</param>
        /// <param name="txt">the text of the check box.</param>
        [DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void lv_checkbox_set_text_static(IntPtr obj, string txt);

        /// <summary>
        /// Get the text of a check box
        /// </summary>
        /// <param name="obj">pointer to check box object</param>
        /// <returns>pointer to the text of the check box</returns>
        [DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
        public static extern string lv_checkbox_get_text(IntPtr obj);
#endif
    }
}
