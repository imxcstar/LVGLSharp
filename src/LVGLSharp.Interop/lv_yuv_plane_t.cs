namespace LVGLSharp.Interop
{
    public unsafe partial struct lv_yuv_plane_t
    {
        public void* buf;

        [NativeTypeName("uint32_t")]
        public c_uint32 stride;
    }
}
