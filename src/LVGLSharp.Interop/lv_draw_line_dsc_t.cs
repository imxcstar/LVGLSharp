using System.Runtime.CompilerServices;

namespace LVGLSharp.Interop
{
    public partial struct lv_draw_line_dsc_t
    {
        public lv_draw_dsc_base_t @base;

        public lv_point_precise_t p1;

        public lv_point_precise_t p2;

        public lv_color_t color;

        [NativeTypeName("int32_t")]
        public int width;

        [NativeTypeName("int32_t")]
        public int dash_width;

        [NativeTypeName("int32_t")]
        public int dash_gap;

        [NativeTypeName("lv_opa_t")]
        public byte opa;

        [NativeBitfield("round_start", offset: 0, length: 1)]
        [NativeBitfield("round_end", offset: 1, length: 1)]
        [NativeBitfield("raw_end", offset: 2, length: 1)]
        public byte _bitfield;

        [NativeTypeName("uint8_t : 1")]
        public byte round_start
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return (byte)(_bitfield & 0x1u);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (byte)((_bitfield & ~0x1u) | (value & 0x1u));
            }
        }

        [NativeTypeName("uint8_t : 1")]
        public byte round_end
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return (byte)((_bitfield >> 1) & 0x1u);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (byte)((_bitfield & ~(0x1u << 1)) | ((value & 0x1u) << 1));
            }
        }

        [NativeTypeName("uint8_t : 1")]
        public byte raw_end
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return (byte)((_bitfield >> 2) & 0x1u);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (byte)((_bitfield & ~(0x1u << 2)) | ((value & 0x1u) << 2));
            }
        }
    }
}
