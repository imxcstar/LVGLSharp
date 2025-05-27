using System.Runtime.CompilerServices;

namespace LVGLSharp.Interop
{
    public partial struct lv_event_list_t
    {
        [NativeTypeName("lv_array_t")]
        public _lv_array_t array;

        [NativeBitfield("is_traversing", offset: 0, length: 1)]
        [NativeBitfield("has_marked_deleting", offset: 1, length: 1)]
        public byte _bitfield;

        [NativeTypeName("uint8_t : 1")]
        public byte is_traversing
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
        public byte has_marked_deleting
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
    }
}
