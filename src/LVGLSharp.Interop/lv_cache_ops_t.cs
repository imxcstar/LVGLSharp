namespace LVGLSharp.Interop
{
    public unsafe partial struct lv_cache_ops_t
    {
        [NativeTypeName("lv_cache_compare_cb_t")]
        public delegate* unmanaged[Cdecl]<void*, void*, sbyte> compare_cb;

        [NativeTypeName("lv_cache_create_cb_t")]
        public delegate* unmanaged[Cdecl]<void*, void*, c_bool1> create_cb;

        [NativeTypeName("lv_cache_free_cb_t")]
        public delegate* unmanaged[Cdecl]<void*, void*, void> free_cb;
    }
}
