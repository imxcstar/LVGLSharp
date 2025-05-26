namespace LVGLSharp.Interop
{
    public unsafe partial struct lv_draw_label_dsc_t
    {
        public lv_draw_dsc_base_t @base;

        [NativeTypeName("const char *")]
        public c_int8* text;

        public lv_point_t text_size;

        [NativeTypeName("const lv_font_t *")]
        public _lv_font_t* font;

        public lv_color_t color;

        [NativeTypeName("int32_t")]
        public c_int32 line_space;

        [NativeTypeName("int32_t")]
        public c_int32 letter_space;

        [NativeTypeName("int32_t")]
        public c_int32 ofs_x;

        [NativeTypeName("int32_t")]
        public c_int32 ofs_y;

        [NativeTypeName("int32_t")]
        public c_int32 rotation;

        [NativeTypeName("uint32_t")]
        public c_uint32 sel_start;

        [NativeTypeName("uint32_t")]
        public c_uint32 sel_end;

        public lv_color_t sel_color;

        public lv_color_t sel_bg_color;

        [NativeTypeName("uint32_t")]
        public c_uint32 text_length;

        [NativeTypeName("lv_opa_t")]
        public c_uint8 opa;

        public lv_text_align_t align;

        public lv_base_dir_t bidi_dir;

        public int _bitfield1;

        [NativeTypeName("lv_text_decor_t : 3")]
        public lv_text_decor_t decor
        {
            readonly get
            {
                return (lv_text_decor_t)((_bitfield1 << 29) >> 29);
            }

            set
            {
                _bitfield1 = (_bitfield1 & ~0x7) | ((int)(value) & 0x7);
            }
        }

        [NativeTypeName("lv_text_flag_t : 5")]
        public lv_text_flag_t flag
        {
            readonly get
            {
                return (lv_text_flag_t)((_bitfield1 << 24) >> 27);
            }

            set
            {
                _bitfield1 = (_bitfield1 & ~(0x1F << 3)) | (((int)(value) & 0x1F) << 3);
            }
        }

        public c_uint8 _bitfield2;

        [NativeTypeName("uint8_t : 1")]
        public c_uint8 text_local
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

        [NativeTypeName("uint8_t : 1")]
        public c_uint8 text_static
        {
            readonly get
            {
                return (c_uint8)((_bitfield2 >> 1) & 0x1u);
            }

            set
            {
                _bitfield2 = (c_uint8)((_bitfield2 & ~(0x1u << 1)) | ((value & 0x1u) << 1));
            }
        }

        [NativeTypeName("uint8_t : 1")]
        public c_uint8 has_bided
        {
            readonly get
            {
                return (c_uint8)((_bitfield2 >> 2) & 0x1u);
            }

            set
            {
                _bitfield2 = (c_uint8)((_bitfield2 & ~(0x1u << 2)) | ((value & 0x1u) << 2));
            }
        }

        [NativeTypeName("lv_draw_label_hint_t *")]
        public _lv_draw_label_hint_t* hint;

        [NativeTypeName("lv_opa_t")]
        public c_uint8 outline_stroke_opa;

        public lv_color_t outline_stroke_color;

        [NativeTypeName("int32_t")]
        public c_int32 outline_stroke_width;
    }
}
