namespace LVGLSharp.Interop
{
    public unsafe partial struct _lv_draw_buf_t
    {
        public lv_image_header_t header;

        [NativeTypeName("uint32_t")]
        public c_uint32 data_size;

        [NativeTypeName("uint8_t *")]
        public c_uint8* data;

        public void* unaligned_data;

        [NativeTypeName("const lv_draw_buf_handlers_t *")]
        public _lv_draw_buf_handlers_t* handlers;
    }
}
