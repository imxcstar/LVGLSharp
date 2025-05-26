namespace LVGLSharp.Interop
{
    public unsafe partial struct lv_font_fmt_txt_kern_pair_t
    {
        [NativeTypeName("const void *")]
        public void* glyph_ids;

        [NativeTypeName("const int8_t *")]
        public c_int8* values;

        public c_uint32 _bitfield;

        [NativeTypeName("uint32_t : 30")]
        public c_uint32 pair_cnt
        {
            readonly get
            {
                return _bitfield & 0x3FFFFFFFu;
            }

            set
            {
                _bitfield = (_bitfield & ~0x3FFFFFFFu) | (value & 0x3FFFFFFFu);
            }
        }

        [NativeTypeName("uint32_t : 2")]
        public c_uint32 glyph_ids_size
        {
            readonly get
            {
                return (_bitfield >> 30) & 0x3u;
            }

            set
            {
                _bitfield = (_bitfield & ~(0x3u << 30)) | ((value & 0x3u) << 30);
            }
        }
    }
}
