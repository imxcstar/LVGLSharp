namespace LVGLSharp.Interop
{
    public unsafe partial struct _lv_array_t
    {
        [NativeTypeName("uint8_t *")]
        public byte* data;

        [NativeTypeName("uint32_t")]
        public uint size;

        [NativeTypeName("uint32_t")]
        public uint capacity;

        [NativeTypeName("uint32_t")]
        public uint element_size;

        [NativeTypeName("bool")]
        public c_bool1 inner_alloc;
    }
}
