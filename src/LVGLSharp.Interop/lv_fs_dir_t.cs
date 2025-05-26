namespace LVGLSharp.Interop
{
    public unsafe partial struct lv_fs_dir_t
    {
        public void* dir_d;

        [NativeTypeName("lv_fs_drv_t *")]
        public _lv_fs_drv_t* drv;
    }
}
