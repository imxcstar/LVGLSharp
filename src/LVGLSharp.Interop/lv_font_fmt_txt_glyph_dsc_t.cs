using System.Runtime.CompilerServices;

namespace LVGLSharp.Interop
{
    public partial struct lv_font_fmt_txt_glyph_dsc_t
    {
        [NativeBitfield("bitmap_index", offset: 0, length: 20)]
        [NativeBitfield("adv_w", offset: 20, length: 12)]
        public uint _bitfield;

        [NativeTypeName("uint32_t : 20")]
        public uint bitmap_index
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return _bitfield & 0xFFFFFu;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (_bitfield & ~0xFFFFFu) | (value & 0xFFFFFu);
            }
        }

        [NativeTypeName("uint32_t : 12")]
        public uint adv_w
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return (_bitfield >> 20) & 0xFFFu;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (_bitfield & ~(0xFFFu << 20)) | ((value & 0xFFFu) << 20);
            }
        }

        [NativeTypeName("uint8_t")]
        public byte box_w;

        [NativeTypeName("uint8_t")]
        public byte box_h;

        [NativeTypeName("int8_t")]
        public sbyte ofs_x;

        [NativeTypeName("int8_t")]
        public sbyte ofs_y;
    }
}
