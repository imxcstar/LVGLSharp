global using static LVGLSharp.Interop.lv_buttonmatrix_ctrl_t;
global using static LVGLSharp.Interop.lv_display_render_mode_t;
global using static LVGLSharp.Interop.lv_display_rotation_t;
global using static LVGLSharp.Interop.lv_event_code_t;
global using static LVGLSharp.Interop.lv_imagebutton_state_t;
global using static LVGLSharp.Interop.lv_indev_state_t;
global using static LVGLSharp.Interop.lv_label_long_mode_t;
global using static LVGLSharp.Interop.lv_result_t;
global using static LVGLSharp.Interop.lv_style_res_t;
global using static LVGLSharp.Interop.LVGL;

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
        public unsafe struct BufferWrapper : IDisposable
        {
            public sbyte* Ptr;

            private byte[] _buffer;
            private GCHandle _handle;

            public BufferWrapper(byte[] buffer)
            {
                _buffer = buffer ?? throw new ArgumentNullException(nameof(buffer));
                _handle = GCHandle.Alloc(_buffer, GCHandleType.Pinned);
                Ptr = (sbyte*)_handle.AddrOfPinnedObject();
            }

            // 隐式转换 BufferWrapper -> byte[]
            public static implicit operator byte[](BufferWrapper wrapper)
            {
                return wrapper._buffer;
            }

            // 隐式转换 BufferWrapper -> sbyte*
            public static implicit operator sbyte*(BufferWrapper wrapper)
            {
                return wrapper.Ptr;
            }

            // 新增：隐式转换 byte[] -> BufferWrapper
            public static implicit operator BufferWrapper(byte[] buffer)
            {
                return new BufferWrapper(buffer);
            }

            public void Dispose()
            {
                if (_handle.IsAllocated)
                    _handle.Free();
                Ptr = null;
            }
        }

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public struct c_bool1
        {
            public byte Value;
            public c_bool1(bool v) => Value = (byte)(v ? 1 : 0);
            public c_bool1(byte v) => Value = (byte)(v != 0 ? 1 : 0);

            // C风格的从数值类型隐式转换
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

            // 转回基础类型
            public static implicit operator bool(c_bool1 v) => v.Value != 0;
            public static implicit operator c_bool1(bool v) => v ? 1 : 0;
            public static implicit operator byte(c_bool1 v) => v.Value;

            public override string ToString() => (Value != 0).ToString();
        }

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public struct c_int8
        {
            public sbyte Value;
            public c_int8(sbyte v) => Value = v;

            public static implicit operator c_int16(c_int8 v) => new c_int16(v.Value);
            public static implicit operator c_int32(c_int8 v) => new c_int32(v.Value);
            public static implicit operator c_int64(c_int8 v) => new c_int64(v.Value);
            public static implicit operator c_float32(c_int8 v) => new c_float32(v.Value);
            public static implicit operator c_float64(c_int8 v) => new c_float64(v.Value);

            public static implicit operator sbyte(c_int8 v) => v.Value;
            public static implicit operator c_int8(sbyte v) => new c_int8(v);

            // C风格：隐式转布尔
            public static implicit operator c_bool1(c_int8 v) => new c_bool1(v.Value != 0);

            public override string ToString() => Value.ToString();
        }

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public struct c_uint8
        {
            public byte Value;
            public c_uint8(byte v) => Value = v;

            public static implicit operator c_uint16(c_uint8 v) => new c_uint16(v.Value);
            public static implicit operator c_uint32(c_uint8 v) => new c_uint32(v.Value);
            public static implicit operator c_uint64(c_uint8 v) => new c_uint64(v.Value);
            public static implicit operator c_float32(c_uint8 v) => new c_float32(v.Value);
            public static implicit operator c_float64(c_uint8 v) => new c_float64(v.Value);

            public static implicit operator byte(c_uint8 v) => v.Value;
            public static implicit operator c_uint8(byte v) => new c_uint8(v);
            public static implicit operator c_uint8(c_int32 v) => new c_uint8((byte)v.Value);
            public static implicit operator c_uint8(c_uint32 v) => new c_uint8((byte)v.Value);

            public static implicit operator c_bool1(c_uint8 v) => new c_bool1(v.Value != 0);

            public override string ToString() => Value.ToString();
        }

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public struct c_int16
        {
            public short Value;
            public c_int16(short v) => Value = v;

            public static implicit operator c_int32(c_int16 v) => new c_int32(v.Value);
            public static implicit operator c_int64(c_int16 v) => new c_int64(v.Value);
            public static implicit operator c_float32(c_int16 v) => new c_float32(v.Value);
            public static implicit operator c_float64(c_int16 v) => new c_float64(v.Value);

            public static implicit operator short(c_int16 v) => v.Value;
            public static implicit operator c_int16(short v) => new c_int16(v);

            public static implicit operator c_bool1(c_int16 v) => new c_bool1(v.Value != 0);

            public override string ToString() => Value.ToString();
        }

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public struct c_uint16
        {
            public ushort Value;
            public c_uint16(ushort v) => Value = v;

            public static implicit operator c_uint32(c_uint16 v) => new c_uint32(v.Value);
            public static implicit operator c_uint64(c_uint16 v) => new c_uint64(v.Value);
            public static implicit operator c_float32(c_uint16 v) => new c_float32(v.Value);
            public static implicit operator c_float64(c_uint16 v) => new c_float64(v.Value);

            public static implicit operator ushort(c_uint16 v) => v.Value;
            public static implicit operator c_uint16(ushort v) => new c_uint16(v);
            public static implicit operator c_uint16(int v) => new c_uint16((ushort)v);

            public static implicit operator c_bool1(c_uint16 v) => new c_bool1(v.Value != 0);

            public override string ToString() => Value.ToString();
        }

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public struct c_int32
        {
            public int Value;
            public c_int32(int v) => Value = v;

            public static implicit operator c_int64(c_int32 v) => new c_int64(v.Value);
            public static implicit operator c_float32(c_int32 v) => new c_float32(v.Value);
            public static implicit operator c_float64(c_int32 v) => new c_float64(v.Value);

            public static implicit operator int(c_int32 v) => v.Value;
            public static implicit operator c_int32(int v) => new c_int32(v);

            public static implicit operator c_uint16(c_int32 v) => new c_uint16((ushort)v.Value);
            public static implicit operator c_uint32(c_int32 v) => new c_uint32((uint)v.Value);

            public static implicit operator lv_grad_dir_t(c_int32 v) => (lv_grad_dir_t)v.Value;
            public static implicit operator lv_align_t(c_int32 v) => (lv_align_t)v.Value;
            public static implicit operator lv_border_side_t(c_int32 v) => (lv_border_side_t)v.Value;
            public static implicit operator lv_text_decor_t(c_int32 v) => (lv_text_decor_t)v.Value;
            public static implicit operator lv_text_align_t(c_int32 v) => (lv_text_align_t)v.Value;
            public static implicit operator lv_blend_mode_t(c_int32 v) => (lv_blend_mode_t)v.Value;
            public static implicit operator lv_base_dir_t(c_int32 v) => (lv_base_dir_t)v.Value;
            public static implicit operator lv_flex_flow_t(c_int32 v) => (lv_flex_flow_t)v.Value;
            public static implicit operator lv_flex_align_t(c_int32 v) => (lv_flex_align_t)v.Value;
            public static implicit operator lv_grid_align_t(c_int32 v) => (lv_grid_align_t)v.Value;

            public static implicit operator c_bool1(c_int32 v) => new c_bool1(v.Value != 0);

            public override string ToString() => Value.ToString();
        }

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public struct c_uint32
        {
            public uint Value;
            public c_uint32(uint v) => Value = v;

            public static implicit operator c_uint64(c_uint32 v) => new c_uint64(v.Value);
            public static implicit operator c_float32(c_uint32 v) => new c_float32(v.Value);
            public static implicit operator c_float64(c_uint32 v) => new c_float64(v.Value);

            public static implicit operator uint(c_uint32 v) => v.Value;
            public static implicit operator int(c_uint32 v) => (int)v.Value;
            public static implicit operator c_uint32(int v) => new c_uint32((uint)v);
            public static implicit operator c_uint32(uint v) => new c_uint32(v);
            public static implicit operator c_uint32(long v) => new c_uint32((uint)v);

            public static implicit operator c_bool1(c_uint32 v) => new c_bool1(v.Value != 0);

            public override string ToString() => Value.ToString();
        }

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public struct c_int64
        {
            public long Value;
            public c_int64(long v) => Value = v;

            public static implicit operator c_float32(c_int64 v) => new c_float32(v.Value);
            public static implicit operator c_float64(c_int64 v) => new c_float64(v.Value);

            public static implicit operator long(c_int64 v) => v.Value;
            public static implicit operator c_int64(long v) => new c_int64(v);

            public static implicit operator c_bool1(c_int64 v) => new c_bool1(v.Value != 0);

            public override string ToString() => Value.ToString();
        }

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public struct c_uint64
        {
            public ulong Value;
            public c_uint64(ulong v) => Value = v;

            public static implicit operator c_float32(c_uint64 v) => new c_float32(v.Value);
            public static implicit operator c_float64(c_uint64 v) => new c_float64(v.Value);

            public static implicit operator ulong(c_uint64 v) => v.Value;
            public static implicit operator c_uint64(ulong v) => new c_uint64(v);

            public static implicit operator c_bool1(c_uint64 v) => new c_bool1(v.Value != 0);

            public override string ToString() => Value.ToString();
        }

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public struct c_float32
        {
            public float Value;
            public c_float32(float v) => Value = v;

            public static implicit operator c_float64(c_float32 v) => new c_float64(v.Value);

            public static implicit operator float(c_float32 v) => v.Value;
            public static implicit operator c_float32(float v) => new c_float32(v);

            public static implicit operator c_bool1(c_float32 v) => new c_bool1(v.Value != 0);

            public override string ToString() => Value.ToString();
        }

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public struct c_float64
        {
            public double Value;
            public c_float64(double v) => Value = v;

            public static implicit operator double(c_float64 v) => v.Value;
            public static implicit operator c_float64(double v) => new c_float64(v);

            public static implicit operator c_bool1(c_float64 v) => new c_bool1(v.Value != 0);

            public override string ToString() => Value.ToString();
        }


        [return: NativeTypeName("lv_state_t")]
        public static ushort lv_obj_style_get_selector_state([NativeTypeName("lv_style_selector_t")] uint selector)
        {
            return (ushort)(selector & 0xFFFF);
        }


        [return: NativeTypeName("int32_t")]
        public static int lv_obj_get_style_space_left([NativeTypeName("const lv_obj_t *")] _lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part)
        {
            int padding = lv_obj_get_style_pad_left(obj, part);
            int border_width = lv_obj_get_style_border_width(obj, part);
            lv_border_side_t border_side = lv_obj_get_style_border_side(obj, part);

            return (border_side & lv_border_side_t.LV_BORDER_SIDE_LEFT) != 0 ? padding + border_width : padding;
        }

        [return: NativeTypeName("int32_t")]
        public static int lv_obj_get_style_space_right([NativeTypeName("const lv_obj_t *")] _lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part)
        {
            int padding = lv_obj_get_style_pad_right(obj, part);
            int border_width = lv_obj_get_style_border_width(obj, part);
            lv_border_side_t border_side = lv_obj_get_style_border_side(obj, part);

            return (border_side & lv_border_side_t.LV_BORDER_SIDE_RIGHT) != 0 ? padding + border_width : padding;
        }

        [return: NativeTypeName("int32_t")]
        public static int lv_obj_get_style_space_top([NativeTypeName("const lv_obj_t *")] _lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part)
        {
            int padding = lv_obj_get_style_pad_top(obj, part);
            int border_width = lv_obj_get_style_border_width(obj, part);
            lv_border_side_t border_side = lv_obj_get_style_border_side(obj, part);

            return (border_side & lv_border_side_t.LV_BORDER_SIDE_TOP) != 0 ? padding + border_width : padding;
        }

        [return: NativeTypeName("int32_t")]
        public static int lv_obj_get_style_space_bottom([NativeTypeName("const lv_obj_t *")] _lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part)
        {
            int padding = lv_obj_get_style_pad_bottom(obj, part);
            int border_width = lv_obj_get_style_border_width(obj, part);
            lv_border_side_t border_side = lv_obj_get_style_border_side(obj, part);

            return (border_side & lv_border_side_t.LV_BORDER_SIDE_BOTTOM) != 0 ? padding + border_width : padding;
        }

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_span_set_text_static([NativeTypeName("lv_span_t *")] _lv_span_t* span, [NativeTypeName("const char *")] sbyte* text);


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
