namespace LVGLSharp.Interop
{
    public unsafe partial struct _lv_array_t
    {
        [NativeTypeName("uint8_t *")]
        public c_uint8* data;

        [NativeTypeName("uint32_t")]
        public c_uint32 size;

        [NativeTypeName("uint32_t")]
        public c_uint32 capacity;

        [NativeTypeName("uint32_t")]
        public c_uint32 element_size;

        [NativeTypeName("bool")]
        public c_bool1 inner_alloc;
    }
}
