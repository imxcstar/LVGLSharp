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
#if LV_USE_FLEX
        public const int _LV_FLEX_COLUMN = (1 << 0);
        public const int _LV_FLEX_WRAP = (1 << 2);
        public const int _LV_FLEX_REVERSE = (1 << 3);

        public enum lv_flex_align_t
        {
            LV_FLEX_ALIGN_START,
            LV_FLEX_ALIGN_END,
            LV_FLEX_ALIGN_CENTER,
            LV_FLEX_ALIGN_SPACE_EVENLY,
            LV_FLEX_ALIGN_SPACE_AROUND,
            LV_FLEX_ALIGN_SPACE_BETWEEN,
        }

        public enum lv_flex_flow_t
        {
            LV_FLEX_FLOW_ROW = 0x00,
            LV_FLEX_FLOW_COLUMN = _LV_FLEX_COLUMN,
            LV_FLEX_FLOW_ROW_WRAP = LV_FLEX_FLOW_ROW | _LV_FLEX_WRAP,
            LV_FLEX_FLOW_ROW_REVERSE = LV_FLEX_FLOW_ROW | _LV_FLEX_REVERSE,
            LV_FLEX_FLOW_ROW_WRAP_REVERSE = LV_FLEX_FLOW_ROW | _LV_FLEX_WRAP | _LV_FLEX_REVERSE,
            LV_FLEX_FLOW_COLUMN_WRAP = LV_FLEX_FLOW_COLUMN | _LV_FLEX_WRAP,
            LV_FLEX_FLOW_COLUMN_REVERSE = LV_FLEX_FLOW_COLUMN | _LV_FLEX_REVERSE,
            LV_FLEX_FLOW_COLUMN_WRAP_REVERSE = LV_FLEX_FLOW_COLUMN | _LV_FLEX_WRAP | _LV_FLEX_REVERSE
        }

        /// <summary>
        /// Initialize a flex layout the default values
        /// </summary>
        [DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void lv_flex_init();

        /// <summary>
        /// Set how the item should flow
        /// </summary>
        /// <param name="obj">pointer to an object. The parent must have flex layout else nothing will happen.</param>
        /// <param name="flow">an element of `lv_flex_flow_t`.</param>
        [DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void lv_obj_set_flex_flow(IntPtr obj, lv_flex_flow_t flow);

        /// <summary>
        /// Set how to place (where to align) the items and tracks
        /// </summary>
        /// <param name="obj">pointer to an object. The parent must have flex layout else nothing will happen.</param>
        /// <param name="main_place">where to place the items on main axis (in their track). Any value of `lv_flex_align_t`.</param>
        /// <param name="cross_place">where to place the item in their track on the cross axis. `LV_FLEX_ALIGN_START/END/CENTER`</param>
        /// <param name="track_cross_place">where to place the tracks in the cross direction. Any value of `lv_flex_align_t`.</param>
        [DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void lv_obj_set_flex_align(IntPtr obj, lv_flex_align_t main_place, lv_flex_align_t cross_place, lv_flex_align_t track_cross_place);

        /// <summary>
        /// Sets the width or height (on main axis) to grow the object in order fill the free space
        /// </summary>
        /// <param name="obj">pointer to an object. The parent must have flex layout else nothing will happen.</param>
        /// <param name="grow">a value to set how much free space to take proportionally to other growing items.</param>
        [DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void lv_obj_set_flex_grow(IntPtr obj, int grow);
#endif
    }
}
