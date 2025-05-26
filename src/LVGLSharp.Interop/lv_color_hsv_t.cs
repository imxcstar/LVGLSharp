namespace LVGLSharp.Interop
{
    public partial struct lv_color_hsv_t
    {
        [NativeTypeName("uint16_t")]
        public c_uint16 h;

        [NativeTypeName("uint8_t")]
        public c_uint8 s;

        [NativeTypeName("uint8_t")]
        public c_uint8 v;
    }
}
