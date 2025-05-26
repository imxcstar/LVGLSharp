namespace LVGLSharp.Interop
{
    public unsafe partial struct lv_draw_letter_dsc_t
    {
        public lv_draw_dsc_base_t @base;

        [NativeTypeName("uint32_t")]
        public c_uint32 unicode;

        [NativeTypeName("const lv_font_t *")]
        public _lv_font_t* font;

        public lv_color_t color;

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

        [NativeTypeName("lv_opa_t")]
        public c_uint8 opa;

        public int _bitfield;

        [NativeTypeName("lv_text_decor_t : 3")]
        public lv_text_decor_t decor
        {
            readonly get
            {
                return (lv_text_decor_t)((_bitfield << 29) >> 29);
            }

            set
            {
                _bitfield = (_bitfield & ~0x7) | ((int)(value) & 0x7);
            }
        }

        [NativeTypeName("lv_blend_mode_t : 3")]
        public lv_blend_mode_t blend_mode
        {
            readonly get
            {
                return (lv_blend_mode_t)((_bitfield << 26) >> 29);
            }

            set
            {
                _bitfield = (_bitfield & ~(0x7 << 3)) | (((int)(value) & 0x7) << 3);
            }
        }

        [NativeTypeName("lv_opa_t")]
        public c_uint8 outline_stroke_opa;

        [NativeTypeName("int32_t")]
        public c_int32 outline_stroke_width;

        public lv_color_t outline_stroke_color;
    }
}
