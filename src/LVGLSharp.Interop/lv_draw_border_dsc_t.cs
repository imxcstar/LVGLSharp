namespace LVGLSharp.Interop
{
    public partial struct lv_draw_border_dsc_t
    {
        public lv_draw_dsc_base_t @base;

        [NativeTypeName("int32_t")]
        public c_int32 radius;

        public lv_color_t color;

        [NativeTypeName("int32_t")]
        public c_int32 width;

        [NativeTypeName("lv_opa_t")]
        public c_uint8 opa;

        public int _bitfield;

        [NativeTypeName("lv_border_side_t : 5")]
        public lv_border_side_t side
        {
            readonly get
            {
                return (lv_border_side_t)((_bitfield << 27) >> 27);
            }

            set
            {
                _bitfield = (_bitfield & ~0x1F) | ((int)(value) & 0x1F);
            }
        }
    }
}
