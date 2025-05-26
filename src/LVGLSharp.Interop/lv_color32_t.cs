namespace LVGLSharp.Interop
{
    public partial struct lv_color32_t
    {
        [NativeTypeName("uint8_t")]
        public c_uint8 blue;

        [NativeTypeName("uint8_t")]
        public c_uint8 green;

        [NativeTypeName("uint8_t")]
        public c_uint8 red;

        [NativeTypeName("uint8_t")]
        public c_uint8 alpha;
    }
}
