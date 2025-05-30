global using static LVGLSharp.Interop.lv_align_t;
global using static LVGLSharp.Interop.lv_animimg_part_t;
global using static LVGLSharp.Interop.lv_arc_mode_t;
global using static LVGLSharp.Interop.lv_bar_mode_t;
global using static LVGLSharp.Interop.lv_bar_orientation_t;
global using static LVGLSharp.Interop.lv_base_dir_t;
global using static LVGLSharp.Interop.lv_blend_mode_t;
global using static LVGLSharp.Interop.lv_border_side_t;
global using static LVGLSharp.Interop.lv_buttonmatrix_ctrl_t;
global using static LVGLSharp.Interop.lv_cache_reserve_cond_res_t;
global using static LVGLSharp.Interop.lv_chart_axis_t;
global using static LVGLSharp.Interop.lv_chart_type_t;
global using static LVGLSharp.Interop.lv_chart_update_mode_t;
global using static LVGLSharp.Interop.lv_color_format_t;
global using static LVGLSharp.Interop.lv_cover_res_t;
global using static LVGLSharp.Interop.lv_dir_t;
global using static LVGLSharp.Interop.lv_display_render_mode_t;
global using static LVGLSharp.Interop.lv_display_rotation_t;
global using static LVGLSharp.Interop.lv_event_code_t;
global using static LVGLSharp.Interop.lv_flex_align_t;
global using static LVGLSharp.Interop.lv_flex_flow_t;
global using static LVGLSharp.Interop.lv_font_fmt_txt_bitmap_format_t;
global using static LVGLSharp.Interop.lv_font_fmt_txt_cmap_type_t;
global using static LVGLSharp.Interop.lv_font_glyph_format_t;
global using static LVGLSharp.Interop.lv_font_kerning_t;
global using static LVGLSharp.Interop.lv_font_subpx_t;
global using static LVGLSharp.Interop.lv_fs_mode_t;
global using static LVGLSharp.Interop.lv_fs_res_t;
global using static LVGLSharp.Interop.lv_fs_whence_t;
global using static LVGLSharp.Interop.lv_grad_dir_t;
global using static LVGLSharp.Interop.lv_grad_extend_t;
global using static LVGLSharp.Interop.lv_grid_align_t;
global using static LVGLSharp.Interop.lv_group_refocus_policy_t;
global using static LVGLSharp.Interop.lv_imagebutton_state_t;
global using static LVGLSharp.Interop.lv_image_align_t;
global using static LVGLSharp.Interop.lv_image_compress_t;
global using static LVGLSharp.Interop.lv_image_src_t;
global using static LVGLSharp.Interop.lv_indev_gesture_type_t;
global using static LVGLSharp.Interop.lv_indev_mode_t;
global using static LVGLSharp.Interop.lv_indev_state_t;
global using static LVGLSharp.Interop.lv_indev_type_t;
global using static LVGLSharp.Interop.lv_keyboard_mode_t;
global using static LVGLSharp.Interop.lv_key_t;
global using static LVGLSharp.Interop.lv_label_long_mode_t;
global using static LVGLSharp.Interop.lv_layer_type_t;
global using static LVGLSharp.Interop.lv_layout_t;
global using static LVGLSharp.Interop.lv_menu_mode_header_t;
global using static LVGLSharp.Interop.lv_menu_mode_root_back_button_t;
global using static LVGLSharp.Interop.lv_obj_class_editable_t;
global using static LVGLSharp.Interop.lv_obj_class_group_def_t;
global using static LVGLSharp.Interop.lv_obj_class_theme_inheritable_t;
global using static LVGLSharp.Interop.lv_obj_flag_t;
global using static LVGLSharp.Interop.lv_obj_point_transform_flag_t;
global using static LVGLSharp.Interop.lv_obj_tree_walk_res_t;
global using static LVGLSharp.Interop.lv_palette_t;
global using static LVGLSharp.Interop.lv_rb_color_t;
global using static LVGLSharp.Interop.lv_result_t;
global using static LVGLSharp.Interop.lv_roller_mode_t;
global using static LVGLSharp.Interop.lv_screen_load_anim_t;
global using static LVGLSharp.Interop.lv_scrollbar_mode_t;
global using static LVGLSharp.Interop.lv_scroll_snap_t;
global using static LVGLSharp.Interop.lv_slider_mode_t;
global using static LVGLSharp.Interop.lv_slider_orientation_t;
global using static LVGLSharp.Interop.lv_span_mode_t;
global using static LVGLSharp.Interop.lv_span_overflow_t;
global using static LVGLSharp.Interop.lv_style_res_t;
global using static LVGLSharp.Interop.lv_style_state_cmp_t;
global using static LVGLSharp.Interop.lv_subject_type_t;
global using static LVGLSharp.Interop.lv_switch_orientation_t;
global using static LVGLSharp.Interop.lv_table_cell_ctrl_t;
global using static LVGLSharp.Interop.lv_text_align_t;
global using static LVGLSharp.Interop.lv_text_cmd_state_t;
global using static LVGLSharp.Interop.lv_text_decor_t;
global using static LVGLSharp.Interop.lv_text_flag_t;
global using static LVGLSharp.Interop.lv_thread_prio_t;
global using static LVGLSharp.Interop.LVGL;
global using lv_style_prop_t = byte;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LVGLSharp.Interop
{
    public static unsafe partial class LVGL
    {
        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public struct c_bool1
        {
            public byte Value;
            public c_bool1(bool v) => Value = (byte)(v ? 1 : 0);
            public c_bool1(byte v) => Value = (byte)(v != 0 ? 1 : 0);

            public static implicit operator c_bool1(sbyte v) => new c_bool1((byte)(v != 0 ? 1 : 0));
            public static implicit operator c_bool1(short v) => new c_bool1((byte)(v != 0 ? 1 : 0));
            public static implicit operator c_bool1(int v) => new c_bool1((byte)(v != 0 ? 1 : 0));
            public static implicit operator c_bool1(long v) => new c_bool1((byte)(v != 0 ? 1 : 0));
            public static implicit operator c_bool1(byte v) => new c_bool1((byte)(v != 0 ? 1 : 0));
            public static implicit operator c_bool1(ushort v) => new c_bool1((byte)(v != 0 ? 1 : 0));
            public static implicit operator c_bool1(uint v) => new c_bool1((byte)(v != 0 ? 1 : 0));
            public static implicit operator c_bool1(ulong v) => new c_bool1((byte)(v != 0 ? 1 : 0));
            public static implicit operator c_bool1(float v) => new c_bool1((byte)(v != 0 ? 1 : 0));
            public static implicit operator c_bool1(double v) => new c_bool1((byte)(v != 0 ? 1 : 0));

            public static implicit operator bool(c_bool1 v) => v.Value != 0;
            public static implicit operator c_bool1(bool v) => v ? 1 : 0;
            public static implicit operator byte(c_bool1 v) => v.Value;

            public override string ToString() => (Value != 0).ToString();
        }

        [return: NativeTypeName("uint16_t")]
        public static ushort lv_color_swap_16([NativeTypeName("uint16_t")] ushort c)
        {
            return (ushort)((c >> 8) | (c << 8));
        }

        [return: NativeTypeName("uint16_t")]
        public static ushort lv_swap_bytes_16([NativeTypeName("uint16_t")] ushort x)
        {
            return (ushort)((x << 8) | (x >> 8));
        }


        [return: NativeTypeName("uint32_t")]
        public static uint lv_style_get_prop_group([NativeTypeName("lv_style_prop_t")] byte prop)
        {
            uint group = (uint)(prop >> 2);

            if (group > 30)
            {
                group = 31;
            }

            return group;
        }

        [return: NativeTypeName("lv_state_t")]
        public static ushort lv_obj_style_get_selector_state([NativeTypeName("lv_style_selector_t")] uint selector)
        {
            return (ushort)(selector & 0xFFFF);
        }

        public static void lv_obj_move_foreground([NativeTypeName("lv_obj_t *")] lv_obj_t* obj)
        {
            lv_obj_t* parent = lv_obj_get_parent(obj);

            if (parent == null)
            {
                do
                {
                    ;
                }
                while ((0) != 0);

                return;
            }

            lv_obj_move_to_index(obj, (int)(lv_obj_get_child_count(parent) - 1));
        }

        [return: NativeTypeName("int32_t")]
        public static int lv_obj_get_style_space_left([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part)
        {
            int padding = lv_obj_get_style_pad_left(obj, part);
            int border_width = lv_obj_get_style_border_width(obj, part);
            lv_border_side_t border_side = lv_obj_get_style_border_side(obj, part);

            return (border_side & lv_border_side_t.LV_BORDER_SIDE_LEFT) != 0 ? padding + border_width : padding;
        }

        [return: NativeTypeName("int32_t")]
        public static int lv_obj_get_style_space_right([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part)
        {
            int padding = lv_obj_get_style_pad_right(obj, part);
            int border_width = lv_obj_get_style_border_width(obj, part);
            lv_border_side_t border_side = lv_obj_get_style_border_side(obj, part);

            return (border_side & lv_border_side_t.LV_BORDER_SIDE_RIGHT) != 0 ? padding + border_width : padding;
        }

        [return: NativeTypeName("int32_t")]
        public static int lv_obj_get_style_space_top([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part)
        {
            int padding = lv_obj_get_style_pad_top(obj, part);
            int border_width = lv_obj_get_style_border_width(obj, part);
            lv_border_side_t border_side = lv_obj_get_style_border_side(obj, part);

            return (border_side & lv_border_side_t.LV_BORDER_SIDE_TOP) != 0 ? padding + border_width : padding;
        }

        [return: NativeTypeName("int32_t")]
        public static int lv_obj_get_style_space_bottom([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part)
        {
            int padding = lv_obj_get_style_pad_bottom(obj, part);
            int border_width = lv_obj_get_style_border_width(obj, part);
            lv_border_side_t border_side = lv_obj_get_style_border_side(obj, part);

            return (border_side & lv_border_side_t.LV_BORDER_SIDE_BOTTOM) != 0 ? padding + border_width : padding;
        }

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_span_set_text_static([NativeTypeName("lv_span_t *")] lv_span_t* span, [NativeTypeName("const char *")] sbyte* text);


        [NativeTypeName("#define LV_ANIM_OFF false")]
        public const bool LV_ANIM_OFF = false;

        [NativeTypeName("#define LV_ANIM_ON true")]
        public const bool LV_ANIM_ON = true;


        [NativeTypeName("#define LV_COORD_TYPE_MASK (3 << LV_COORD_TYPE_SHIFT)")]
        public const int LV_COORD_TYPE_MASK = (3 << (29));

        [NativeTypeName("#define LV_COORD_TYPE_PX (0 << LV_COORD_TYPE_SHIFT)")]
        public const int LV_COORD_TYPE_PX = (0 << (29));

        [NativeTypeName("#define LV_COORD_TYPE_SPEC (1 << LV_COORD_TYPE_SHIFT)")]
        public const int LV_COORD_TYPE_SPEC = (1 << (29));

        [NativeTypeName("#define LV_COORD_TYPE_PX_NEG (3 << LV_COORD_TYPE_SHIFT)")]
        public const int LV_COORD_TYPE_PX_NEG = (3 << (29));

        [NativeTypeName("#define LV_COORD_MAX ((1 << LV_COORD_TYPE_SHIFT) - 1)")]
        public const int LV_COORD_MAX = ((1 << (29)) - 1);

        [NativeTypeName("#define LV_COORD_MIN (-LV_COORD_MAX)")]
        public const int LV_COORD_MIN = (-((1 << (29)) - 1));

        [NativeTypeName("#define LV_SIZE_CONTENT LV_COORD_SET_SPEC(LV_COORD_MAX)")]
        public const int LV_SIZE_CONTENT = ((((1 << (29)) - 1)) | (1 << (29)));

        [NativeTypeName("#define LV_PCT_STORED_MAX (LV_COORD_MAX - 1)")]
        public const int LV_PCT_STORED_MAX = (((1 << (29)) - 1) - 1);

        [NativeTypeName("#define LV_PCT_POS_MAX (LV_PCT_STORED_MAX / 2)")]
        public const int LV_PCT_POS_MAX = ((((1 << (29)) - 1) - 1) / 2);

        [NativeTypeName("#define LV_GRID_CONTENT (LV_COORD_MAX - 101)")]
        public const int LV_GRID_CONTENT = (((1 << (29)) - 1) - 101);

        [NativeTypeName("#define LV_GRID_TEMPLATE_LAST (LV_COORD_MAX)")]
        public const int LV_GRID_TEMPLATE_LAST = (((1 << (29)) - 1));

        [NativeTypeName("#define LV_GRAD_LEFT LV_PCT(0)")]
        public const int LV_GRAD_LEFT = (((((0) < 0 ? (((((1 << (29)) - 1) - 1) / 2) - (((0)) > (-((((1 << (29)) - 1) - 1) / 2)) ? ((0)) : (-((((1 << (29)) - 1) - 1) / 2)))) : (((0)) < (((((1 << (29)) - 1) - 1) / 2)) ? ((0)) : (((((1 << (29)) - 1) - 1) / 2))))) | (1 << (29))));

        [NativeTypeName("#define LV_GRAD_RIGHT LV_PCT(100)")]
        public const int LV_GRAD_RIGHT = (((((100) < 0 ? (((((1 << (29)) - 1) - 1) / 2) - (((100)) > (-((((1 << (29)) - 1) - 1) / 2)) ? ((100)) : (-((((1 << (29)) - 1) - 1) / 2)))) : (((100)) < (((((1 << (29)) - 1) - 1) / 2)) ? ((100)) : (((((1 << (29)) - 1) - 1) / 2))))) | (1 << (29))));

        [NativeTypeName("#define LV_GRAD_TOP LV_PCT(0)")]
        public const int LV_GRAD_TOP = (((((0) < 0 ? (((((1 << (29)) - 1) - 1) / 2) - (((0)) > (-((((1 << (29)) - 1) - 1) / 2)) ? ((0)) : (-((((1 << (29)) - 1) - 1) / 2)))) : (((0)) < (((((1 << (29)) - 1) - 1) / 2)) ? ((0)) : (((((1 << (29)) - 1) - 1) / 2))))) | (1 << (29))));

        [NativeTypeName("#define LV_GRAD_BOTTOM LV_PCT(100)")]
        public const int LV_GRAD_BOTTOM = (((((100) < 0 ? (((((1 << (29)) - 1) - 1) / 2) - (((100)) > (-((((1 << (29)) - 1) - 1) / 2)) ? ((100)) : (-((((1 << (29)) - 1) - 1) / 2)))) : (((100)) < (((((1 << (29)) - 1) - 1) / 2)) ? ((100)) : (((((1 << (29)) - 1) - 1) / 2))))) | (1 << (29))));

        [NativeTypeName("#define LV_GRAD_CENTER LV_PCT(50)")]
        public const int LV_GRAD_CENTER = (((((50) < 0 ? (((((1 << (29)) - 1) - 1) / 2) - (((50)) > (-((((1 << (29)) - 1) - 1) / 2)) ? ((50)) : (-((((1 << (29)) - 1) - 1) / 2)))) : (((50)) < (((((1 << (29)) - 1) - 1) / 2)) ? ((50)) : (((((1 << (29)) - 1) - 1) / 2))))) | (1 << (29))));

        public enum lv_scale_mode_t : uint
        {
            LV_SCALE_MODE_HORIZONTAL_TOP = 0x00U,
            LV_SCALE_MODE_HORIZONTAL_BOTTOM = 0x01U,
            LV_SCALE_MODE_VERTICAL_LEFT = 0x02U,
            LV_SCALE_MODE_VERTICAL_RIGHT = 0x04U,
            LV_SCALE_MODE_ROUND_INNER = 0x08U,
            LV_SCALE_MODE_ROUND_OUTER = 0x10U,
            LV_SCALE_MODE_LAST,
        }
    }
}
