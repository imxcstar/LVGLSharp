using System.Runtime.InteropServices;

namespace LVGLSharp.Interop
{
    public unsafe partial struct lv_font_glyph_dsc_t
    {
        [NativeTypeName("const lv_font_t *")]
        public _lv_font_t* resolved_font;

        [NativeTypeName("uint16_t")]
        public c_uint16 adv_w;

        [NativeTypeName("uint16_t")]
        public c_uint16 box_w;

        [NativeTypeName("uint16_t")]
        public c_uint16 box_h;

        [NativeTypeName("int16_t")]
        public c_int16 ofs_x;

        [NativeTypeName("int16_t")]
        public c_int16 ofs_y;

        [NativeTypeName("uint16_t")]
        public c_uint16 stride;

        public lv_font_glyph_format_t format;

        public c_uint8 _bitfield;

        [NativeTypeName("uint8_t : 1")]
        public c_uint8 is_placeholder
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
        public c_uint8 req_raw_bitmap
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

        [NativeTypeName("int32_t")]
        public c_int32 outline_stroke_width;

        [NativeTypeName("__AnonymousRecord_lv_font_L73_C5")]
        public _gid_e__Union gid;

        [NativeTypeName("lv_cache_entry_t *")]
        public _lv_cache_entry_t* entry;

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _gid_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("uint32_t")]
            public c_uint32 index;

            [FieldOffset(0)]
            [NativeTypeName("const void *")]
            public void* src;
        }
    }
}
