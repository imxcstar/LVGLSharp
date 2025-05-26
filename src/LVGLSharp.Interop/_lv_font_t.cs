namespace LVGLSharp.Interop
{
    public unsafe partial struct _lv_font_t
    {
        [NativeTypeName("bool (*)(const lv_font_t *, lv_font_glyph_dsc_t *, uint32_t, uint32_t)")]
        public delegate* unmanaged[Cdecl]<_lv_font_t*, lv_font_glyph_dsc_t*, c_uint32, c_uint32, c_bool1> get_glyph_dsc;

        [NativeTypeName("const void *(*)(lv_font_glyph_dsc_t *, lv_draw_buf_t *)")]
        public delegate* unmanaged[Cdecl]<lv_font_glyph_dsc_t*, _lv_draw_buf_t*, void*> get_glyph_bitmap;

        [NativeTypeName("void (*)(const lv_font_t *, lv_font_glyph_dsc_t *)")]
        public delegate* unmanaged[Cdecl]<_lv_font_t*, lv_font_glyph_dsc_t*, void> release_glyph;

        [NativeTypeName("int32_t")]
        public c_int32 line_height;

        [NativeTypeName("int32_t")]
        public c_int32 base_line;

        public c_uint8 _bitfield;

        [NativeTypeName("uint8_t : 2")]
        public c_uint8 subpx
        {
            readonly get
            {
                return (c_uint8)(_bitfield & 0x3u);
            }

            set
            {
                _bitfield = (c_uint8)((_bitfield & ~0x3u) | (value & 0x3u));
            }
        }

        [NativeTypeName("uint8_t : 1")]
        public c_uint8 kerning
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

        [NativeTypeName("uint8_t : 1")]
        public c_uint8 static_bitmap
        {
            readonly get
            {
                return (c_uint8)((_bitfield >> 3) & 0x1u);
            }

            set
            {
                _bitfield = (c_uint8)((_bitfield & ~(0x1u << 3)) | ((value & 0x1u) << 3));
            }
        }

        [NativeTypeName("int8_t")]
        public c_int8 underline_position;

        [NativeTypeName("int8_t")]
        public c_int8 underline_thickness;

        [NativeTypeName("const void *")]
        public void* dsc;

        [NativeTypeName("const lv_font_t *")]
        public _lv_font_t* fallback;

        public void* user_data;
    }
}
