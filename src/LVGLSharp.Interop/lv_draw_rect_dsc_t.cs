using System.Runtime.CompilerServices;

namespace LVGLSharp.Interop
{
    public unsafe partial struct lv_draw_rect_dsc_t
    {
        public lv_draw_dsc_base_t @base;

        [NativeTypeName("int32_t")]
        public int radius;

        [NativeTypeName("lv_opa_t")]
        public byte bg_opa;

        public lv_color_t bg_color;

        public lv_grad_dsc_t bg_grad;

        [NativeTypeName("const void *")]
        public void* bg_image_src;

        [NativeTypeName("const void *")]
        public void* bg_image_symbol_font;

        public lv_color_t bg_image_recolor;

        [NativeTypeName("lv_opa_t")]
        public byte bg_image_opa;

        [NativeTypeName("lv_opa_t")]
        public byte bg_image_recolor_opa;

        [NativeTypeName("uint8_t")]
        public byte bg_image_tiled;

        public lv_color_t border_color;

        [NativeTypeName("int32_t")]
        public int border_width;

        [NativeTypeName("lv_opa_t")]
        public byte border_opa;

        [NativeBitfield("border_side", offset: 0, length: 5)]
        [NativeBitfield("border_post", offset: 5, length: 1)]
        public int _bitfield;

        [NativeTypeName("lv_border_side_t : 5")]
        public lv_border_side_t border_side
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return (lv_border_side_t)((_bitfield << 27) >> 27);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (_bitfield & ~0x1F) | ((int)(value) & 0x1F);
            }
        }

        [NativeTypeName("uint8_t : 1")]
        public byte border_post
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return (byte)((_bitfield >> 5) & 0x1);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (_bitfield & ~(0x1 << 5)) | (int)((value & 0x1u) << 5);
            }
        }

        public lv_color_t outline_color;

        [NativeTypeName("int32_t")]
        public int outline_width;

        [NativeTypeName("int32_t")]
        public int outline_pad;

        [NativeTypeName("lv_opa_t")]
        public byte outline_opa;

        public lv_color_t shadow_color;

        [NativeTypeName("int32_t")]
        public int shadow_width;

        [NativeTypeName("int32_t")]
        public int shadow_offset_x;

        [NativeTypeName("int32_t")]
        public int shadow_offset_y;

        [NativeTypeName("int32_t")]
        public int shadow_spread;

        [NativeTypeName("lv_opa_t")]
        public byte shadow_opa;
    }
}
