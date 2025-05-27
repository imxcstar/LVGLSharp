using System.Runtime.CompilerServices;

namespace LVGLSharp.Interop
{
    public partial struct lv_color16_t
    {
        [NativeBitfield("blue", offset: 0, length: 5)]
        [NativeBitfield("green", offset: 5, length: 6)]
        [NativeBitfield("red", offset: 11, length: 5)]
        public ushort _bitfield;

        [NativeTypeName("uint16_t : 5")]
        public ushort blue
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return (ushort)(_bitfield & 0x1Fu);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (ushort)((_bitfield & ~0x1Fu) | (value & 0x1Fu));
            }
        }

        [NativeTypeName("uint16_t : 6")]
        public ushort green
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return (ushort)((_bitfield >> 5) & 0x3Fu);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (ushort)((_bitfield & ~(0x3Fu << 5)) | ((value & 0x3Fu) << 5));
            }
        }

        [NativeTypeName("uint16_t : 5")]
        public ushort red
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return (ushort)((_bitfield >> 11) & 0x1Fu);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (ushort)((_bitfield & ~(0x1Fu << 11)) | ((value & 0x1Fu) << 11));
            }
        }
    }
}
