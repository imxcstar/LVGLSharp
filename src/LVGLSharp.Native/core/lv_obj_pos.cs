using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LVGLSharp
{
    public static partial class Native
    {
        /// <summary>
        /// Set the size of an object.
        /// </summary>
        /// <param name="obj">pointer to an object</param>
        /// <param name="width">the new width</param>
        /// <param name="height">the new height</param>
        /// <remarks>
        /// possible values are:
        /// pixel               simple set the size accordingly
        /// LV_SIZE_CONTENT     set the size to involve all children in the given direction
        /// lv_pct(x)           to set size in percentage of the parent's content area size (the size without paddings).
        ///                     x should be in [0..1000]% range
        /// </remarks>
        [DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void lv_obj_set_size(IntPtr obj, int width, int height);

        /// <summary>
        /// Change the alignment of an object and set new coordinates.
        /// Equivalent to:
        /// lv_obj_set_align(obj, align);
        /// lv_obj_set_pos(obj, x_ofs, y_ofs);
        /// </summary>
        /// <param name="obj">pointer to an object to align</param>
        /// <param name="align">type of alignment (see 'lv_align_t' enum) `LV_ALIGN_OUT_...` can't be used.</param>
        /// <param name="x_ofs">x coordinate offset after alignment</param>
        /// <param name="y_ofs">y coordinate offset after alignment</param>
        [DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void lv_obj_align(IntPtr obj, lv_align_t align, int x_ofs, int y_ofs);

        /// <summary>
        /// Align an object to the center on its parent.
        /// </summary>
        /// <param name="obj">pointer to an object to align</param>
        /// <remarks>
        /// if the parent size changes `obj` needs to be aligned manually again
        /// </remarks>
        public static void lv_obj_center(IntPtr obj)
        {
            lv_obj_align(obj, lv_align_t.LV_ALIGN_CENTER, 0, 0);
        }
    }
}
