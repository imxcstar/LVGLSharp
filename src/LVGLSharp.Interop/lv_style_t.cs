namespace LVGLSharp.Interop
{
    public unsafe partial struct lv_style_t
    {
        public void* values_and_props;

        [NativeTypeName("uint32_t")]
        public uint has_group;

        [NativeTypeName("uint8_t")]
        public byte prop_cnt;
    }
}
