using System.Runtime.CompilerServices;

namespace LVGLSharp.Interop
{
    public partial struct lv_image_header_t
    {
        [NativeBitfield("magic", offset: 0, length: 8)]
        [NativeBitfield("cf", offset: 8, length: 8)]
        [NativeBitfield("flags", offset: 16, length: 16)]
        public uint _bitfield1;

        [NativeTypeName("uint32_t : 8")]
        public uint magic
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return _bitfield1 & 0xFFu;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield1 = (_bitfield1 & ~0xFFu) | (value & 0xFFu);
            }
        }

        [NativeTypeName("uint32_t : 8")]
        public uint cf
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return (_bitfield1 >> 8) & 0xFFu;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield1 = (_bitfield1 & ~(0xFFu << 8)) | ((value & 0xFFu) << 8);
            }
        }

        [NativeTypeName("uint32_t : 16")]
        public uint flags
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return (_bitfield1 >> 16) & 0xFFFFu;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield1 = (_bitfield1 & ~(0xFFFFu << 16)) | ((value & 0xFFFFu) << 16);
            }
        }

        [NativeBitfield("w", offset: 0, length: 16)]
        [NativeBitfield("h", offset: 16, length: 16)]
        public uint _bitfield2;

        [NativeTypeName("uint32_t : 16")]
        public uint w
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return _bitfield2 & 0xFFFFu;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield2 = (_bitfield2 & ~0xFFFFu) | (value & 0xFFFFu);
            }
        }

        [NativeTypeName("uint32_t : 16")]
        public uint h
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return (_bitfield2 >> 16) & 0xFFFFu;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield2 = (_bitfield2 & ~(0xFFFFu << 16)) | ((value & 0xFFFFu) << 16);
            }
        }

        [NativeBitfield("stride", offset: 0, length: 16)]
        [NativeBitfield("reserved_2", offset: 16, length: 16)]
        public uint _bitfield3;

        [NativeTypeName("uint32_t : 16")]
        public uint stride
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return _bitfield3 & 0xFFFFu;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield3 = (_bitfield3 & ~0xFFFFu) | (value & 0xFFFFu);
            }
        }

        [NativeTypeName("uint32_t : 16")]
        public uint reserved_2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return (_bitfield3 >> 16) & 0xFFFFu;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield3 = (_bitfield3 & ~(0xFFFFu << 16)) | ((value & 0xFFFFu) << 16);
            }
        }
    }
}
