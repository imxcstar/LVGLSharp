namespace LVGLSharp.Interop
{
    public partial struct lv_draw_line_dsc_t
    {
        public lv_draw_dsc_base_t @base;

        public lv_point_precise_t p1;

        public lv_point_precise_t p2;

        public lv_color_t color;

        [NativeTypeName("int32_t")]
        public c_int32 width;

        [NativeTypeName("int32_t")]
        public c_int32 dash_width;

        [NativeTypeName("int32_t")]
        public c_int32 dash_gap;

        [NativeTypeName("lv_opa_t")]
        public c_uint8 opa;

        public c_uint8 _bitfield;

        [NativeTypeName("uint8_t : 1")]
        public c_uint8 round_start
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

        [NativeTypeName("uint8_t : 1")]
        public c_uint8 round_end
        {
            readonly get
            {
                return (c_uint8)((_bitfield >> 1) & 0x1u);
            }

            set
            {
                _bitfield = (c_uint8)((_bitfield & ~(0x1u << 1)) | ((value & 0x1u) << 1));
            }
        }

        [NativeTypeName("uint8_t : 1")]
        public c_uint8 raw_end
        {
            readonly get
            {
                return (c_uint8)((_bitfield >> 2) & 0x1u);
            }

            set
            {
                _bitfield = (c_uint8)((_bitfield & ~(0x1u << 2)) | ((value & 0x1u) << 2));
            }
        }
    }
}
