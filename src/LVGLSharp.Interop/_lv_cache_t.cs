namespace LVGLSharp.Interop
{
    public unsafe partial struct _lv_cache_t
    {
        [NativeTypeName("const lv_cache_class_t *")]
        public _lv_cache_class_t* clz;

        [NativeTypeName("uint32_t")]
        public uint node_size;

        [NativeTypeName("uint32_t")]
        public uint max_size;

        [NativeTypeName("uint32_t")]
        public uint size;

        [NativeTypeName("lv_cache_ops_t")]
        public _lv_cache_ops_t ops;

        [NativeTypeName("lv_mutex_t")]
        public int @lock;

        [NativeTypeName("const char *")]
        public sbyte* name;
    }
}
