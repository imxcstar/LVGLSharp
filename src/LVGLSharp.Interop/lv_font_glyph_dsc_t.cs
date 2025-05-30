using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace LVGLSharp.Interop
{
    public unsafe partial struct lv_font_glyph_dsc_t
    {
        [NativeTypeName("const lv_font_t *")]
        public lv_font_t* resolved_font;

        [NativeTypeName("uint16_t")]
        public ushort adv_w;

        [NativeTypeName("uint16_t")]
        public ushort box_w;

        [NativeTypeName("uint16_t")]
        public ushort box_h;

        [NativeTypeName("int16_t")]
        public short ofs_x;

        [NativeTypeName("int16_t")]
        public short ofs_y;

        [NativeTypeName("uint16_t")]
        public ushort stride;

        public lv_font_glyph_format_t format;

        [NativeBitfield("is_placeholder", offset: 0, length: 1)]
        [NativeBitfield("req_raw_bitmap", offset: 1, length: 1)]
        public byte _bitfield;

        [NativeTypeName("uint8_t : 1")]
        public byte is_placeholder
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

        [NativeTypeName("uint8_t : 1")]
        public byte req_raw_bitmap
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return (byte)((_bitfield >> 1) & 0x1u);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (byte)((_bitfield & ~(0x1u << 1)) | ((value & 0x1u) << 1));
            }
        }

        [NativeTypeName("int32_t")]
        public int outline_stroke_width;

        [NativeTypeName("__AnonymousRecord_lv_font_L73_C5")]
        public _gid_e__Union gid;

        public lv_cache_entry_t* entry;

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _gid_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("uint32_t")]
            public uint index;

            [FieldOffset(0)]
            [NativeTypeName("const void *")]
            public void* src;
        }
    }
}
