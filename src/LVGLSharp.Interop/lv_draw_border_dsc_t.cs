using System.Runtime.CompilerServices;

namespace LVGLSharp.Interop
{
    public partial struct lv_draw_border_dsc_t
    {
        public lv_draw_dsc_base_t @base;

        [NativeTypeName("int32_t")]
        public int radius;

        public lv_color_t color;

        [NativeTypeName("int32_t")]
        public int width;

        [NativeTypeName("lv_opa_t")]
        public byte opa;

        [NativeBitfield("side", offset: 0, length: 5)]
        public int _bitfield;

        [NativeTypeName("lv_border_side_t : 5")]
        public lv_border_side_t side
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return (lv_border_side_t)((_bitfield << 27) >> 27);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (_bitfield & ~0x1F) | ((int)(value) & 0x1F);
            }
        }
    }
}
