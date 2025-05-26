namespace LVGLSharp.Interop
{
    public partial struct lv_grad_stop_t
    {
        public lv_color_t color;

        [NativeTypeName("lv_opa_t")]
        public c_uint8 opa;

        [NativeTypeName("uint8_t")]
        public c_uint8 frac;
    }
}
