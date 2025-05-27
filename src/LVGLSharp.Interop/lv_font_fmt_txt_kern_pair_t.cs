using System.Runtime.CompilerServices;

namespace LVGLSharp.Interop
{
    public unsafe partial struct lv_font_fmt_txt_kern_pair_t
    {
        [NativeTypeName("const void *")]
        public void* glyph_ids;

        [NativeTypeName("const int8_t *")]
        public sbyte* values;

        [NativeBitfield("pair_cnt", offset: 0, length: 30)]
        [NativeBitfield("glyph_ids_size", offset: 30, length: 2)]
        public uint _bitfield;

        [NativeTypeName("uint32_t : 30")]
        public uint pair_cnt
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return _bitfield & 0x3FFFFFFFu;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (_bitfield & ~0x3FFFFFFFu) | (value & 0x3FFFFFFFu);
            }
        }

        [NativeTypeName("uint32_t : 2")]
        public uint glyph_ids_size
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return (_bitfield >> 30) & 0x3u;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (_bitfield & ~(0x3u << 30)) | ((value & 0x3u) << 30);
            }
        }
    }
}
