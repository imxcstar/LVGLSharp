using System.Runtime.CompilerServices;

namespace LVGLSharp.Interop
{
    public partial struct lv_draw_box_shadow_dsc_t
    {
        public lv_draw_dsc_base_t @base;

        [NativeTypeName("int32_t")]
        public int radius;

        public lv_color_t color;

        [NativeTypeName("int32_t")]
        public int width;

        [NativeTypeName("int32_t")]
        public int spread;

        [NativeTypeName("int32_t")]
        public int ofs_x;

        [NativeTypeName("int32_t")]
        public int ofs_y;

        [NativeTypeName("lv_opa_t")]
        public byte opa;

        [NativeBitfield("bg_cover", offset: 0, length: 1)]
        public byte _bitfield;

        [NativeTypeName("uint8_t : 1")]
        public byte bg_cover
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
    }
}
