namespace LVGLSharp.Interop
{
    public partial struct lv_font_fmt_txt_glyph_dsc_t
    {
        public c_uint32 _bitfield;

        [NativeTypeName("uint32_t : 20")]
        public c_uint32 bitmap_index
        {
            readonly get
            {
                return _bitfield & 0xFFFFFu;
            }

            set
            {
                _bitfield = (_bitfield & ~0xFFFFFu) | (value & 0xFFFFFu);
            }
        }

        [NativeTypeName("uint32_t : 12")]
        public c_uint32 adv_w
        {
            readonly get
            {
                return (_bitfield >> 20) & 0xFFFu;
            }

            set
            {
                _bitfield = (_bitfield & ~(0xFFFu << 20)) | ((value & 0xFFFu) << 20);
            }
        }

        [NativeTypeName("uint8_t")]
        public c_uint8 box_w;

        [NativeTypeName("uint8_t")]
        public c_uint8 box_h;

        [NativeTypeName("int8_t")]
        public c_int8 ofs_x;

        [NativeTypeName("int8_t")]
        public c_int8 ofs_y;
    }
}
