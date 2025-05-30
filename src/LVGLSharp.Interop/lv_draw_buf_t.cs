namespace LVGLSharp.Interop
{
    public unsafe partial struct lv_draw_buf_t
    {
        public lv_image_header_t header;

        [NativeTypeName("uint32_t")]
        public uint data_size;

        [NativeTypeName("uint8_t *")]
        public byte* data;

        public void* unaligned_data;

        [NativeTypeName("const lv_draw_buf_handlers_t *")]
        public lv_draw_buf_handlers_t* handlers;
    }
}
