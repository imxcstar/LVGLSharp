namespace LVGLSharp.Interop
{
    public unsafe partial struct _lv_cache_t
    {
        [NativeTypeName("const lv_cache_class_t *")]
        public _lv_cache_class_t* clz;

        [NativeTypeName("uint32_t")]
        public c_uint32 node_size;

        [NativeTypeName("uint32_t")]
        public c_uint32 max_size;

        [NativeTypeName("uint32_t")]
        public c_uint32 size;

        [NativeTypeName("lv_cache_ops_t")]
        public _lv_cache_ops_t ops;

        [NativeTypeName("lv_mutex_t")]
        public int @lock;

        [NativeTypeName("const char *")]
        public c_int8* name;
    }
}
