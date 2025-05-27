using System.Runtime.CompilerServices;

namespace LVGLSharp.Interop
{
    public unsafe partial struct _lv_draw_image_dsc_t
    {
        public lv_draw_dsc_base_t @base;

        [NativeTypeName("const void *")]
        public void* src;

        public lv_image_header_t header;

        [NativeTypeName("int32_t")]
        public int clip_radius;

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

        public lv_color_t recolor;

        [NativeTypeName("lv_opa_t")]
        public byte recolor_opa;

        [NativeTypeName("lv_opa_t")]
        public byte opa;

        [NativeBitfield("blend_mode", offset: 0, length: 4)]
        [NativeBitfield("antialias", offset: 4, length: 1)]
        [NativeBitfield("tile", offset: 5, length: 1)]
        public int _bitfield;

        [NativeTypeName("lv_blend_mode_t : 4")]
        public lv_blend_mode_t blend_mode
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return (lv_blend_mode_t)((_bitfield << 28) >> 28);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (_bitfield & ~0xF) | ((int)(value) & 0xF);
            }
        }

        [NativeTypeName("uint16_t : 1")]
        public ushort antialias
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return (ushort)((_bitfield >> 4) & 0x1);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (_bitfield & ~(0x1 << 4)) | (int)((value & 0x1u) << 4);
            }
        }

        [NativeTypeName("uint16_t : 1")]
        public ushort tile
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return (ushort)((_bitfield >> 5) & 0x1);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (_bitfield & ~(0x1 << 5)) | (int)((value & 0x1u) << 5);
            }
        }

        [NativeTypeName("lv_draw_image_sup_t *")]
        public _lv_draw_image_sup_t* sup;

        public lv_area_t image_area;

        [NativeTypeName("const lv_image_dsc_t *")]
        public lv_image_dsc_t* bitmap_mask_src;
    }
}
