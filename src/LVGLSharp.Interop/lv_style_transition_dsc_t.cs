namespace LVGLSharp.Interop
{
    public unsafe partial struct lv_style_transition_dsc_t
    {
        [NativeTypeName("const lv_style_prop_t *")]
        public byte* props;

        public void* user_data;

        [NativeTypeName("lv_anim_path_cb_t")]
        public delegate* unmanaged[Cdecl]<_lv_anim_t*, int> path_xcb;

        [NativeTypeName("uint32_t")]
        public uint time;

        [NativeTypeName("uint32_t")]
        public uint delay;
    }
}
