namespace LVGLSharp.Interop
{
    public unsafe partial struct lv_style_transition_dsc_t
    {
        [NativeTypeName("const lv_style_prop_t *")]
        public c_uint8* props;

        public void* user_data;

        [NativeTypeName("lv_anim_path_cb_t")]
        public delegate* unmanaged[Cdecl]<_lv_anim_t*, c_int32> path_xcb;

        [NativeTypeName("uint32_t")]
        public c_uint32 time;

        [NativeTypeName("uint32_t")]
        public c_uint32 delay;
    }
}
