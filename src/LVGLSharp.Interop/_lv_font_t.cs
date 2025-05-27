using System.Runtime.CompilerServices;

namespace LVGLSharp.Interop
{
    public unsafe partial struct _lv_font_t
    {
        [NativeTypeName("bool (*)(const lv_font_t *, lv_font_glyph_dsc_t *, uint32_t, uint32_t)")]
        public delegate* unmanaged[Cdecl]<_lv_font_t*, lv_font_glyph_dsc_t*, uint, uint, c_bool1> get_glyph_dsc;

        [NativeTypeName("const void *(*)(lv_font_glyph_dsc_t *, lv_draw_buf_t *)")]
        public delegate* unmanaged[Cdecl]<lv_font_glyph_dsc_t*, _lv_draw_buf_t*, void*> get_glyph_bitmap;

        [NativeTypeName("void (*)(const lv_font_t *, lv_font_glyph_dsc_t *)")]
        public delegate* unmanaged[Cdecl]<_lv_font_t*, lv_font_glyph_dsc_t*, void> release_glyph;

        [NativeTypeName("int32_t")]
        public int line_height;

        [NativeTypeName("int32_t")]
        public int base_line;

        [NativeBitfield("subpx", offset: 0, length: 2)]
        [NativeBitfield("kerning", offset: 2, length: 1)]
        [NativeBitfield("static_bitmap", offset: 3, length: 1)]
        public byte _bitfield;

        [NativeTypeName("uint8_t : 2")]
        public byte subpx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return (byte)(_bitfield & 0x3u);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (byte)((_bitfield & ~0x3u) | (value & 0x3u));
            }
        }

        [NativeTypeName("uint8_t : 1")]
        public byte kerning
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return (byte)((_bitfield >> 2) & 0x1u);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (byte)((_bitfield & ~(0x1u << 2)) | ((value & 0x1u) << 2));
            }
        }

        [NativeTypeName("uint8_t : 1")]
        public byte static_bitmap
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return (byte)((_bitfield >> 3) & 0x1u);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (byte)((_bitfield & ~(0x1u << 3)) | ((value & 0x1u) << 3));
            }
        }

        [NativeTypeName("int8_t")]
        public sbyte underline_position;

        [NativeTypeName("int8_t")]
        public sbyte underline_thickness;

        [NativeTypeName("const void *")]
        public void* dsc;

        [NativeTypeName("const lv_font_t *")]
        public _lv_font_t* fallback;

        public void* user_data;
    }
}
