namespace LVGLSharp.Interop
{
    public partial struct lv_grad_stop_t
    {
        public lv_color_t color;

        [NativeTypeName("lv_opa_t")]
        public byte opa;

        [NativeTypeName("uint8_t")]
        public byte frac;
    }
}
