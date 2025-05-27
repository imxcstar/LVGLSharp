using System.Runtime.CompilerServices;

namespace LVGLSharp.Interop
{
    public unsafe partial struct lv_draw_letter_dsc_t
    {
        public lv_draw_dsc_base_t @base;

        [NativeTypeName("uint32_t")]
        public uint unicode;

        [NativeTypeName("const lv_font_t *")]
        public _lv_font_t* font;

        public lv_color_t color;

        [NativeTypeName("int32_t")]
        public int rotation;

        [NativeTypeName("int32_t")]
        public int scale_x;

        [NativeTypeName("int32_t")]
        public int scale_y;

        [NativeTypeName("int32_t")]
        public int skew_x;

        [NativeTypeName("int32_t")]
        public int skew_y;

        public lv_point_t pivot;

        [NativeTypeName("lv_opa_t")]
        public byte opa;

        [NativeBitfield("decor", offset: 0, length: 3)]
        [NativeBitfield("blend_mode", offset: 3, length: 3)]
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

        [NativeTypeName("lv_blend_mode_t : 3")]
        public lv_blend_mode_t blend_mode
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return (lv_blend_mode_t)((_bitfield << 26) >> 29);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (_bitfield & ~(0x7 << 3)) | (((int)(value) & 0x7) << 3);
            }
        }

        [NativeTypeName("lv_opa_t")]
        public byte outline_stroke_opa;

        [NativeTypeName("int32_t")]
        public int outline_stroke_width;

        public lv_color_t outline_stroke_color;
    }
}
