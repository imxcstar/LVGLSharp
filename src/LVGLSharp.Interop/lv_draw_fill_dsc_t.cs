namespace LVGLSharp.Interop
{
    public partial struct lv_draw_fill_dsc_t
    {
        public lv_draw_dsc_base_t @base;

        [NativeTypeName("int32_t")]
        public int radius;

        [NativeTypeName("lv_opa_t")]
        public byte opa;

        public lv_color_t color;

        public lv_grad_dsc_t grad;
    }
}
