namespace LVGLSharp.Interop
{
    public partial struct lv_color16a_t
    {
        [NativeTypeName("uint8_t")]
        public c_uint8 lumi;

        [NativeTypeName("uint8_t")]
        public c_uint8 alpha;
    }
}
