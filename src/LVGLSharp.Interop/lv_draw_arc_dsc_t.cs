namespace LVGLSharp.Interop
{
    public unsafe partial struct lv_draw_arc_dsc_t
    {
        public lv_draw_dsc_base_t @base;

        public lv_color_t color;

        [NativeTypeName("int32_t")]
        public c_int32 width;

        [NativeTypeName("lv_value_precise_t")]
        public c_int32 start_angle;

        [NativeTypeName("lv_value_precise_t")]
        public c_int32 end_angle;

        public lv_point_t center;

        [NativeTypeName("uint16_t")]
        public c_uint16 radius;

        [NativeTypeName("const void *")]
        public void* img_src;

        [NativeTypeName("lv_opa_t")]
        public c_uint8 opa;

        public c_uint8 _bitfield;

        [NativeTypeName("uint8_t : 1")]
        public c_uint8 rounded
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
