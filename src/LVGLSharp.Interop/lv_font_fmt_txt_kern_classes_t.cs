namespace LVGLSharp.Interop
{
    public unsafe partial struct lv_font_fmt_txt_kern_classes_t
    {
        [NativeTypeName("const int8_t *")]
        public c_int8* class_pair_values;

        [NativeTypeName("const uint8_t *")]
        public c_uint8* left_class_mapping;

        [NativeTypeName("const uint8_t *")]
        public c_uint8* right_class_mapping;

        [NativeTypeName("uint8_t")]
        public c_uint8 left_class_cnt;

        [NativeTypeName("uint8_t")]
        public c_uint8 right_class_cnt;
    }
}
