namespace LVGLSharp.Interop
{
    public unsafe partial struct _lv_color_filter_dsc_t
    {
        [NativeTypeName("lv_color_filter_cb_t")]
        public delegate* unmanaged[Cdecl]<_lv_color_filter_dsc_t*, lv_color_t, byte, lv_color_t> filter_cb;

        public void* user_data;
    }
}
