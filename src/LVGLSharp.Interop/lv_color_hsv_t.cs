namespace LVGLSharp.Interop
{
    public partial struct lv_color_hsv_t
    {
        [NativeTypeName("uint16_t")]
        public ushort h;

        [NativeTypeName("uint8_t")]
        public byte s;

        [NativeTypeName("uint8_t")]
        public byte v;
    }
}
