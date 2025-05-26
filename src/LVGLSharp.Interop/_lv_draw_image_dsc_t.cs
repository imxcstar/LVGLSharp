namespace LVGLSharp.Interop
{
    public unsafe partial struct _lv_draw_image_dsc_t
    {
        public lv_draw_dsc_base_t @base;

        [NativeTypeName("const void *")]
        public void* src;

        public lv_image_header_t header;

        [NativeTypeName("int32_t")]
        public c_int32 clip_radius;

        [NativeTypeName("int32_t")]
        public c_int32 rotation;

        [NativeTypeName("int32_t")]
        public c_int32 scale_x;

        [NativeTypeName("int32_t")]
        public c_int32 scale_y;

        [NativeTypeName("int32_t")]
        public c_int32 skew_x;

        [NativeTypeName("int32_t")]
        public c_int32 skew_y;

        public lv_point_t pivot;

        public lv_color_t recolor;

        [NativeTypeName("lv_opa_t")]
        public c_uint8 recolor_opa;

        [NativeTypeName("lv_opa_t")]
        public c_uint8 opa;

        public int _bitfield1;

        [NativeTypeName("lv_blend_mode_t : 4")]
        public lv_blend_mode_t blend_mode
        {
            readonly get
            {
                return (lv_blend_mode_t)((_bitfield1 << 28) >> 28);
            }

            set
            {
                _bitfield1 = (_bitfield1 & ~0xF) | ((int)(value) & 0xF);
            }
        }

        public c_uint16 _bitfield2;

        [NativeTypeName("uint16_t : 1")]
        public c_uint16 antialias
        {
            readonly get
            {
                return (c_uint16)(_bitfield2 & 0x1u);
            }

            set
            {
                _bitfield2 = (c_uint16)((_bitfield2 & ~0x1u) | (value & 0x1u));
            }
        }

        [NativeTypeName("uint16_t : 1")]
        public c_uint16 tile
        {
            readonly get
            {
                return (c_uint16)((_bitfield2 >> 1) & 0x1u);
            }

            set
            {
                _bitfield2 = (c_uint16)((_bitfield2 & ~(0x1u << 1)) | ((value & 0x1u) << 1));
            }
        }

        [NativeTypeName("lv_draw_image_sup_t *")]
        public _lv_draw_image_sup_t* sup;

        public lv_area_t image_area;

        [NativeTypeName("const lv_image_dsc_t *")]
        public lv_image_dsc_t* bitmap_mask_src;
    }
}
