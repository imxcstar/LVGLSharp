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
        public const int _LV_FLEX_COLUMN = (1 << 0);
        public const int _LV_FLEX_WRAP = (1 << 2);
        public const int _LV_FLEX_REVERSE = (1 << 3);

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

        public enum lv_flex_align_t
        {
            LV_FLEX_ALIGN_START,
            LV_FLEX_ALIGN_END,
            LV_FLEX_ALIGN_CENTER,
            LV_FLEX_ALIGN_SPACE_EVENLY,
            LV_FLEX_ALIGN_SPACE_AROUND,
            LV_FLEX_ALIGN_SPACE_BETWEEN,
        }

        public enum lv_align_t
        {
            LV_ALIGN_DEFAULT = 0,
            LV_ALIGN_TOP_LEFT,
            LV_ALIGN_TOP_MID,
            LV_ALIGN_TOP_RIGHT,
            LV_ALIGN_BOTTOM_LEFT,
            LV_ALIGN_BOTTOM_MID,
            LV_ALIGN_BOTTOM_RIGHT,
            LV_ALIGN_LEFT_MID,
            LV_ALIGN_RIGHT_MID,
            LV_ALIGN_CENTER,

            LV_ALIGN_OUT_TOP_LEFT,
            LV_ALIGN_OUT_TOP_MID,
            LV_ALIGN_OUT_TOP_RIGHT,
            LV_ALIGN_OUT_BOTTOM_LEFT,
            LV_ALIGN_OUT_BOTTOM_MID,
            LV_ALIGN_OUT_BOTTOM_RIGHT,
            LV_ALIGN_OUT_LEFT_TOP,
            LV_ALIGN_OUT_LEFT_MID,
            LV_ALIGN_OUT_LEFT_BOTTOM,
            LV_ALIGN_OUT_RIGHT_TOP,
            LV_ALIGN_OUT_RIGHT_MID,
            LV_ALIGN_OUT_RIGHT_BOTTOM,
        }

        private const string nativeLibName = "Lvgl";

        [DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void lv_init();

        [DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
        public static extern int lv_timer_handler();

        [DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr lv_display_get_screen_active(IntPtr disp);

        [DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void lv_obj_set_flex_flow(IntPtr obj, lv_flex_flow_t flow);

        [DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void lv_obj_set_flex_align(IntPtr obj, lv_flex_align_t main_place, lv_flex_align_t cross_place, lv_flex_align_t track_cross_place);

        [DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr lv_checkbox_create(IntPtr obj);

        [DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void lv_checkbox_set_text(IntPtr obj, string txt);

        [DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr lv_button_create(IntPtr obj);

        [DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void lv_obj_set_size(IntPtr obj, int width, int height);

        [DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr lv_label_create(IntPtr obj);

        [DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void lv_label_set_text(IntPtr obj, string txt);

        [DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void lv_obj_align(IntPtr obj, lv_align_t align, int x_ofs, int y_ofs);

        [DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern IntPtr lv_display_get_default();

        public static void lv_obj_center(IntPtr obj)
        {
            lv_obj_align(obj, lv_align_t.LV_ALIGN_CENTER, 0, 0);
        }

        public static IntPtr lv_screen_active()
        {
            return lv_display_get_screen_active(lv_display_get_default());
        }
    }
}
