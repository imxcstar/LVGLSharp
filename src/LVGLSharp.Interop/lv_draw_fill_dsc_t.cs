namespace LVGLSharp.Interop
{
    public partial struct lv_draw_fill_dsc_t
    {
        public lv_draw_dsc_base_t @base;

        [NativeTypeName("int32_t")]
        public c_int32 radius;

        [NativeTypeName("lv_opa_t")]
        public c_uint8 opa;

        public lv_color_t color;

        public lv_grad_dsc_t grad;
    }
}
