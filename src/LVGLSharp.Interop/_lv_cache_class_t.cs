namespace LVGLSharp.Interop
{
    public unsafe partial struct _lv_cache_class_t
    {
        [NativeTypeName("lv_cache_alloc_cb_t")]
        public delegate* unmanaged[Cdecl]<void*> alloc_cb;

        [NativeTypeName("lv_cache_init_cb_t")]
        public delegate* unmanaged[Cdecl]<_lv_cache_t*, c_bool1> init_cb;

        [NativeTypeName("lv_cache_destroy_cb_t")]
        public delegate* unmanaged[Cdecl]<_lv_cache_t*, void*, void> destroy_cb;

        [NativeTypeName("lv_cache_get_cb_t")]
        public delegate* unmanaged[Cdecl]<_lv_cache_t*, void*, void*, _lv_cache_entry_t*> get_cb;

        [NativeTypeName("lv_cache_add_cb_t")]
        public delegate* unmanaged[Cdecl]<_lv_cache_t*, void*, void*, _lv_cache_entry_t*> add_cb;

        [NativeTypeName("lv_cache_remove_cb_t")]
        public delegate* unmanaged[Cdecl]<_lv_cache_t*, _lv_cache_entry_t*, void*, void> remove_cb;

        [NativeTypeName("lv_cache_drop_cb_t")]
        public delegate* unmanaged[Cdecl]<_lv_cache_t*, void*, void*, void> drop_cb;

        [NativeTypeName("lv_cache_drop_all_cb_t")]
        public delegate* unmanaged[Cdecl]<_lv_cache_t*, void*, void> drop_all_cb;

        [NativeTypeName("lv_cache_get_victim_cb")]
        public delegate* unmanaged[Cdecl]<_lv_cache_t*, void*, _lv_cache_entry_t*> get_victim_cb;

        [NativeTypeName("lv_cache_reserve_cond_cb")]
        public delegate* unmanaged[Cdecl]<_lv_cache_t*, void*, nuint, void*, lv_cache_reserve_cond_res_t> reserve_cond_cb;

        [NativeTypeName("lv_cache_iter_create_cb")]
        public delegate* unmanaged[Cdecl]<_lv_cache_t*, _lv_iter_t*> iter_create_cb;
    }
}
