namespace LVGLSharp.Interop
{
    public unsafe partial struct lv_font_fmt_txt_dsc_t
    {
        [NativeTypeName("const uint8_t *")]
        public c_uint8* glyph_bitmap;

        [NativeTypeName("const lv_font_fmt_txt_glyph_dsc_t *")]
        public lv_font_fmt_txt_glyph_dsc_t* glyph_dsc;

        [NativeTypeName("const lv_font_fmt_txt_cmap_t *")]
        public lv_font_fmt_txt_cmap_t* cmaps;

        [NativeTypeName("const void *")]
        public void* kern_dsc;

        [NativeTypeName("uint16_t")]
        public c_uint16 kern_scale;

        public c_uint16 _bitfield;

        [NativeTypeName("uint16_t : 9")]
        public c_uint16 cmap_num
        {
            readonly get
            {
                return (c_uint16)(_bitfield & 0x1FFu);
            }

            set
            {
                _bitfield = (c_uint16)((_bitfield & ~0x1FFu) | (value & 0x1FFu));
            }
        }

        [NativeTypeName("uint16_t : 4")]
        public c_uint16 bpp
        {
            readonly get
            {
                return (c_uint16)((_bitfield >> 9) & 0xFu);
            }

            set
            {
                _bitfield = (c_uint16)((_bitfield & ~(0xFu << 9)) | ((value & 0xFu) << 9));
            }
        }

        [NativeTypeName("uint16_t : 1")]
        public c_uint16 kern_classes
        {
            readonly get
            {
                return (c_uint16)((_bitfield >> 13) & 0x1u);
            }

            set
            {
                _bitfield = (c_uint16)((_bitfield & ~(0x1u << 13)) | ((value & 0x1u) << 13));
            }
        }

        [NativeTypeName("uint16_t : 2")]
        public c_uint16 bitmap_format
        {
            readonly get
            {
                return (c_uint16)((_bitfield >> 14) & 0x3u);
            }

            set
            {
                _bitfield = (c_uint16)((_bitfield & ~(0x3u << 14)) | ((value & 0x3u) << 14));
            }
        }

        [NativeTypeName("uint8_t")]
        public c_uint8 stride;
    }
}
