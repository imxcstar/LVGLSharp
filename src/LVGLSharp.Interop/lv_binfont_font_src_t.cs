namespace LVGLSharp.Interop
{
    public unsafe partial struct lv_binfont_font_src_t
    {
        [NativeTypeName("uint32_t")]
        public c_uint32 font_size;

        [NativeTypeName("const char *")]
        public c_int8* path;

        [NativeTypeName("const void *")]
        public void* buffer;

        [NativeTypeName("uint32_t")]
        public c_uint32 buffer_size;
    }
}
