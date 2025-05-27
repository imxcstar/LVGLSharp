namespace LVGLSharp.Interop
{
    public unsafe partial struct lv_image_dsc_t
    {
        public lv_image_header_t header;

        [NativeTypeName("uint32_t")]
        public uint data_size;

        [NativeTypeName("const uint8_t *")]
        public byte* data;

        [NativeTypeName("const void *")]
        public void* reserved;

        [NativeTypeName("const void *")]
        public void* reserved_2;
    }
}
