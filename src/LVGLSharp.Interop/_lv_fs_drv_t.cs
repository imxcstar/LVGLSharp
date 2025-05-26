namespace LVGLSharp.Interop
{
    public unsafe partial struct _lv_fs_drv_t
    {
        [NativeTypeName("char")]
        public c_int8 letter;

        [NativeTypeName("uint32_t")]
        public c_uint32 cache_size;

        [NativeTypeName("bool (*)(lv_fs_drv_t *)")]
        public delegate* unmanaged[Cdecl]<_lv_fs_drv_t*, c_bool1> ready_cb;

        [NativeTypeName("void *(*)(lv_fs_drv_t *, const char *, lv_fs_mode_t)")]
        public delegate* unmanaged[Cdecl]<_lv_fs_drv_t*, c_int8*, lv_fs_mode_t, void*> open_cb;

        [NativeTypeName("lv_fs_res_t (*)(lv_fs_drv_t *, void *)")]
        public delegate* unmanaged[Cdecl]<_lv_fs_drv_t*, void*, lv_fs_res_t> close_cb;

        [NativeTypeName("lv_fs_res_t (*)(lv_fs_drv_t *, void *, void *, uint32_t, uint32_t *)")]
        public delegate* unmanaged[Cdecl]<_lv_fs_drv_t*, void*, void*, c_uint32, c_uint32*, lv_fs_res_t> read_cb;

        [NativeTypeName("lv_fs_res_t (*)(lv_fs_drv_t *, void *, const void *, uint32_t, uint32_t *)")]
        public delegate* unmanaged[Cdecl]<_lv_fs_drv_t*, void*, void*, c_uint32, c_uint32*, lv_fs_res_t> write_cb;

        [NativeTypeName("lv_fs_res_t (*)(lv_fs_drv_t *, void *, uint32_t, lv_fs_whence_t)")]
        public delegate* unmanaged[Cdecl]<_lv_fs_drv_t*, void*, c_uint32, lv_fs_whence_t, lv_fs_res_t> seek_cb;

        [NativeTypeName("lv_fs_res_t (*)(lv_fs_drv_t *, void *, uint32_t *)")]
        public delegate* unmanaged[Cdecl]<_lv_fs_drv_t*, void*, c_uint32*, lv_fs_res_t> tell_cb;

        [NativeTypeName("void *(*)(lv_fs_drv_t *, const char *)")]
        public delegate* unmanaged[Cdecl]<_lv_fs_drv_t*, c_int8*, void*> dir_open_cb;

        [NativeTypeName("lv_fs_res_t (*)(lv_fs_drv_t *, void *, char *, uint32_t)")]
        public delegate* unmanaged[Cdecl]<_lv_fs_drv_t*, void*, c_int8*, c_uint32, lv_fs_res_t> dir_read_cb;

        [NativeTypeName("lv_fs_res_t (*)(lv_fs_drv_t *, void *)")]
        public delegate* unmanaged[Cdecl]<_lv_fs_drv_t*, void*, lv_fs_res_t> dir_close_cb;

        public void* user_data;
    }
}
