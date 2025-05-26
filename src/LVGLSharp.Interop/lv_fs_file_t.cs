namespace LVGLSharp.Interop
{
    public unsafe partial struct lv_fs_file_t
    {
        public void* file_d;

        [NativeTypeName("lv_fs_drv_t *")]
        public _lv_fs_drv_t* drv;

        [NativeTypeName("lv_fs_file_cache_t *")]
        public _lv_fs_file_cache_t* cache;
    }
}
