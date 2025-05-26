namespace LVGLSharp.Interop
{
    public partial struct lv_color_t
    {
        [NativeTypeName("uint8_t")]
        public c_uint8 blue;

        [NativeTypeName("uint8_t")]
        public c_uint8 green;

        [NativeTypeName("uint8_t")]
        public c_uint8 red;
    }
}
