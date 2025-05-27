using System.Runtime.CompilerServices;

namespace LVGLSharp.Interop
{
    public unsafe partial struct lv_draw_label_dsc_t
    {
        public lv_draw_dsc_base_t @base;

        [NativeTypeName("const char *")]
        public sbyte* text;

        public lv_point_t text_size;

        [NativeTypeName("const lv_font_t *")]
        public _lv_font_t* font;

        public lv_color_t color;

        [NativeTypeName("int32_t")]
        public int line_space;

        [NativeTypeName("int32_t")]
        public int letter_space;

        [NativeTypeName("int32_t")]
        public int ofs_x;

        [NativeTypeName("int32_t")]
        public int ofs_y;

        [NativeTypeName("int32_t")]
        public int rotation;

        [NativeTypeName("uint32_t")]
        public uint sel_start;

        [NativeTypeName("uint32_t")]
        public uint sel_end;

        public lv_color_t sel_color;

        public lv_color_t sel_bg_color;

        [NativeTypeName("uint32_t")]
        public uint text_length;

        [NativeTypeName("lv_opa_t")]
        public byte opa;

        public lv_text_align_t align;

        public lv_base_dir_t bidi_dir;

        [NativeBitfield("decor", offset: 0, length: 3)]
        [NativeBitfield("flag", offset: 3, length: 5)]
        [NativeBitfield("text_local", offset: 8, length: 1)]
        [NativeBitfield("text_static", offset: 9, length: 1)]
        [NativeBitfield("has_bided", offset: 10, length: 1)]
        public int _bitfield;

        [NativeTypeName("lv_text_decor_t : 3")]
        public lv_text_decor_t decor
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return (lv_text_decor_t)((_bitfield << 29) >> 29);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (_bitfield & ~0x7) | ((int)(value) & 0x7);
            }
        }

        [NativeTypeName("lv_text_flag_t : 5")]
        public lv_text_flag_t flag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return (lv_text_flag_t)((_bitfield << 24) >> 27);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (_bitfield & ~(0x1F << 3)) | (((int)(value) & 0x1F) << 3);
            }
        }

        [NativeTypeName("uint8_t : 1")]
        public byte text_local
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return (byte)((_bitfield >> 8) & 0x1);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (_bitfield & ~(0x1 << 8)) | (int)((value & 0x1u) << 8);
            }
        }

        [NativeTypeName("uint8_t : 1")]
        public byte text_static
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return (byte)((_bitfield >> 9) & 0x1);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (_bitfield & ~(0x1 << 9)) | (int)((value & 0x1u) << 9);
            }
        }

        [NativeTypeName("uint8_t : 1")]
        public byte has_bided
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return (byte)((_bitfield >> 10) & 0x1);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (_bitfield & ~(0x1 << 10)) | (int)((value & 0x1u) << 10);
            }
        }

        [NativeTypeName("lv_draw_label_hint_t *")]
        public _lv_draw_label_hint_t* hint;

        [NativeTypeName("lv_opa_t")]
        public byte outline_stroke_opa;

        public lv_color_t outline_stroke_color;

        [NativeTypeName("int32_t")]
        public int outline_stroke_width;
    }
}
