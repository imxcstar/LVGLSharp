namespace LVGLSharp.Interop
{
    public unsafe partial struct lv_font_fmt_txt_cmap_t
    {
        [NativeTypeName("uint32_t")]
        public uint range_start;

        [NativeTypeName("uint16_t")]
        public ushort range_length;

        [NativeTypeName("uint16_t")]
        public ushort glyph_id_start;

        [NativeTypeName("const uint16_t *")]
        public ushort* unicode_list;

        [NativeTypeName("const void *")]
        public void* glyph_id_ofs_list;

        [NativeTypeName("uint16_t")]
        public ushort list_length;

        public lv_font_fmt_txt_cmap_type_t type;
    }
}
