namespace LVGLSharp.Interop
{
    public unsafe partial struct lv_font_info_t
    {
        [NativeTypeName("const char *")]
        public byte[] name;

        [NativeTypeName("const lv_font_class_t *")]
        public lv_font_class_t* class_p;

        [NativeTypeName("uint32_t")]
        public uint size;

        [NativeTypeName("uint32_t")]
        public uint render_mode;

        [NativeTypeName("uint32_t")]
        public uint style;

        public lv_font_kerning_t kerning;
    }
}
