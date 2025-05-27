namespace LVGLSharp.Interop
{
    public unsafe partial struct lv_binfont_font_src_t
    {
        [NativeTypeName("uint32_t")]
        public uint font_size;

        [NativeTypeName("const char *")]
        public sbyte* path;

        [NativeTypeName("const void *")]
        public void* buffer;

        [NativeTypeName("uint32_t")]
        public uint buffer_size;
    }
}
