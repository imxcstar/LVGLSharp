namespace LVGLSharp.Interop
{
    public unsafe partial struct lv_font_fmt_txt_cmap_t
    {
        [NativeTypeName("uint32_t")]
        public c_uint32 range_start;

        [NativeTypeName("uint16_t")]
        public c_uint16 range_length;

        [NativeTypeName("uint16_t")]
        public c_uint16 glyph_id_start;

        [NativeTypeName("const uint16_t *")]
        public c_uint16* unicode_list;

        [NativeTypeName("const void *")]
        public void* glyph_id_ofs_list;

        [NativeTypeName("uint16_t")]
        public c_uint16 list_length;

        public lv_font_fmt_txt_cmap_type_t type;
    }
}
