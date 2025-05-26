namespace LVGLSharp.Interop
{
    public partial struct lv_draw_box_shadow_dsc_t
    {
        public lv_draw_dsc_base_t @base;

        [NativeTypeName("int32_t")]
        public c_int32 radius;

        public lv_color_t color;

        [NativeTypeName("int32_t")]
        public c_int32 width;

        [NativeTypeName("int32_t")]
        public c_int32 spread;

        [NativeTypeName("int32_t")]
        public c_int32 ofs_x;

        [NativeTypeName("int32_t")]
        public c_int32 ofs_y;

        [NativeTypeName("lv_opa_t")]
        public c_uint8 opa;

        public c_uint8 _bitfield;

        [NativeTypeName("uint8_t : 1")]
        public c_uint8 bg_cover
        {
            readonly get
            {
                return (c_uint8)(_bitfield & 0x1u);
            }

            set
            {
                _bitfield = (c_uint8)((_bitfield & ~0x1u) | (value & 0x1u));
            }
        }
    }
}
