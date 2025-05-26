namespace LVGLSharp.Interop
{
    public unsafe partial struct lv_draw_rect_dsc_t
    {
        public lv_draw_dsc_base_t @base;

        [NativeTypeName("int32_t")]
        public c_int32 radius;

        [NativeTypeName("lv_opa_t")]
        public c_uint8 bg_opa;

        public lv_color_t bg_color;

        public lv_grad_dsc_t bg_grad;

        [NativeTypeName("const void *")]
        public void* bg_image_src;

        [NativeTypeName("const void *")]
        public void* bg_image_symbol_font;

        public lv_color_t bg_image_recolor;

        [NativeTypeName("lv_opa_t")]
        public c_uint8 bg_image_opa;

        [NativeTypeName("lv_opa_t")]
        public c_uint8 bg_image_recolor_opa;

        [NativeTypeName("uint8_t")]
        public c_uint8 bg_image_tiled;

        public lv_color_t border_color;

        [NativeTypeName("int32_t")]
        public c_int32 border_width;

        [NativeTypeName("lv_opa_t")]
        public c_uint8 border_opa;

        public int _bitfield1;

        [NativeTypeName("lv_border_side_t : 5")]
        public lv_border_side_t border_side
        {
            readonly get
            {
                return (lv_border_side_t)((_bitfield1 << 27) >> 27);
            }

            set
            {
                _bitfield1 = (_bitfield1 & ~0x1F) | ((int)(value) & 0x1F);
            }
        }

        public c_uint8 _bitfield2;

        [NativeTypeName("uint8_t : 1")]
        public c_uint8 border_post
        {
            readonly get
            {
                return (c_uint8)(_bitfield2 & 0x1u);
            }

            set
            {
                _bitfield2 = (c_uint8)((_bitfield2 & ~0x1u) | (value & 0x1u));
            }
        }

        public lv_color_t outline_color;

        [NativeTypeName("int32_t")]
        public c_int32 outline_width;

        [NativeTypeName("int32_t")]
        public c_int32 outline_pad;

        [NativeTypeName("lv_opa_t")]
        public c_uint8 outline_opa;

        public lv_color_t shadow_color;

        [NativeTypeName("int32_t")]
        public c_int32 shadow_width;

        [NativeTypeName("int32_t")]
        public c_int32 shadow_offset_x;

        [NativeTypeName("int32_t")]
        public c_int32 shadow_offset_y;

        [NativeTypeName("int32_t")]
        public c_int32 shadow_spread;

        [NativeTypeName("lv_opa_t")]
        public c_uint8 shadow_opa;
    }
}
