using System.Runtime.CompilerServices;

namespace LVGLSharp.Interop
{
    public unsafe partial struct lv_font_fmt_txt_dsc_t
    {
        [NativeTypeName("const uint8_t *")]
        public byte* glyph_bitmap;

        [NativeTypeName("const lv_font_fmt_txt_glyph_dsc_t *")]
        public lv_font_fmt_txt_glyph_dsc_t* glyph_dsc;

        [NativeTypeName("const lv_font_fmt_txt_cmap_t *")]
        public lv_font_fmt_txt_cmap_t* cmaps;

        [NativeTypeName("const void *")]
        public void* kern_dsc;

        [NativeTypeName("uint16_t")]
        public ushort kern_scale;

        [NativeBitfield("cmap_num", offset: 0, length: 9)]
        [NativeBitfield("bpp", offset: 9, length: 4)]
        [NativeBitfield("kern_classes", offset: 13, length: 1)]
        [NativeBitfield("bitmap_format", offset: 14, length: 2)]
        public ushort _bitfield;

        [NativeTypeName("uint16_t : 9")]
        public ushort cmap_num
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return (ushort)(_bitfield & 0x1FFu);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (ushort)((_bitfield & ~0x1FFu) | (value & 0x1FFu));
            }
        }

        [NativeTypeName("uint16_t : 4")]
        public ushort bpp
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return (ushort)((_bitfield >> 9) & 0xFu);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (ushort)((_bitfield & ~(0xFu << 9)) | ((value & 0xFu) << 9));
            }
        }

        [NativeTypeName("uint16_t : 1")]
        public ushort kern_classes
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return (ushort)((_bitfield >> 13) & 0x1u);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (ushort)((_bitfield & ~(0x1u << 13)) | ((value & 0x1u) << 13));
            }
        }

        [NativeTypeName("uint16_t : 2")]
        public ushort bitmap_format
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return (ushort)((_bitfield >> 14) & 0x3u);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (ushort)((_bitfield & ~(0x3u << 14)) | ((value & 0x3u) << 14));
            }
        }

        [NativeTypeName("uint8_t")]
        public byte stride;
    }
}
