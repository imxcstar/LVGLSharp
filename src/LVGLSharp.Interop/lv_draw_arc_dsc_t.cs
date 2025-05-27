using System.Runtime.CompilerServices;

namespace LVGLSharp.Interop
{
    public unsafe partial struct lv_draw_arc_dsc_t
    {
        public lv_draw_dsc_base_t @base;

        public lv_color_t color;

        [NativeTypeName("int32_t")]
        public int width;

        [NativeTypeName("lv_value_precise_t")]
        public int start_angle;

        [NativeTypeName("lv_value_precise_t")]
        public int end_angle;

        public lv_point_t center;

        [NativeTypeName("uint16_t")]
        public ushort radius;

        [NativeTypeName("const void *")]
        public void* img_src;

        [NativeTypeName("lv_opa_t")]
        public byte opa;

        [NativeBitfield("rounded", offset: 0, length: 1)]
        public byte _bitfield;

        [NativeTypeName("uint8_t : 1")]
        public byte rounded
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return (byte)(_bitfield & 0x1u);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (byte)((_bitfield & ~0x1u) | (value & 0x1u));
            }
        }
    }
}
