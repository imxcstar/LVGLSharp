namespace LVGLSharp.Interop
{
    public partial struct lv_color_t
    {
        [NativeTypeName("uint8_t")]
        public byte blue;

        [NativeTypeName("uint8_t")]
        public byte green;

        [NativeTypeName("uint8_t")]
        public byte red;
    }
}
