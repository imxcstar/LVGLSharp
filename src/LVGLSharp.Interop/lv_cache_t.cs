namespace LVGLSharp.Interop
{
    public unsafe partial struct lv_cache_t
    {
        [NativeTypeName("const lv_cache_class_t *")]
        public lv_cache_class_t* clz;

        [NativeTypeName("uint32_t")]
        public uint node_size;

        [NativeTypeName("uint32_t")]
        public uint max_size;

        [NativeTypeName("uint32_t")]
        public uint size;

        public lv_cache_ops_t ops;

        [NativeTypeName("lv_mutex_t")]
        public int @lock;

        [NativeTypeName("const char *")]
        public byte[] name;
    }
}
