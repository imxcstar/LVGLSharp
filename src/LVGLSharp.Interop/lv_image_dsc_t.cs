namespace LVGLSharp.Interop
{
    public unsafe partial struct lv_image_dsc_t
    {
        public lv_image_header_t header;

        [NativeTypeName("uint32_t")]
        public c_uint32 data_size;

        [NativeTypeName("const uint8_t *")]
        public c_uint8* data;

        [NativeTypeName("const void *")]
        public void* reserved;

        [NativeTypeName("const void *")]
        public void* reserved_2;
    }
}
