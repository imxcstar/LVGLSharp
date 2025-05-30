namespace LVGLSharp.Interop
{
    public unsafe partial struct lv_fs_file_t
    {
        public void* file_d;

        public lv_fs_drv_t* drv;

        public lv_fs_file_cache_t* cache;
    }
}
