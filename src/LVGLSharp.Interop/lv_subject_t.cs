using System.Runtime.CompilerServices;

namespace LVGLSharp.Interop
{
    public unsafe partial struct lv_subject_t
    {
        public lv_ll_t subs_ll;

        public lv_subject_value_t value;

        public lv_subject_value_t prev_value;

        public void* user_data;

        [NativeBitfield("type", offset: 0, length: 4)]
        [NativeBitfield("size", offset: 4, length: 24)]
        [NativeBitfield("notify_restart_query", offset: 28, length: 1)]
        public uint _bitfield;

        [NativeTypeName("uint32_t : 4")]
        public uint type
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return _bitfield & 0xFu;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (_bitfield & ~0xFu) | (value & 0xFu);
            }
        }

        [NativeTypeName("uint32_t : 24")]
        public uint size
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return (_bitfield >> 4) & 0xFFFFFFu;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (_bitfield & ~(0xFFFFFFu << 4)) | ((value & 0xFFFFFFu) << 4);
            }
        }

        [NativeTypeName("uint32_t : 1")]
        public uint notify_restart_query
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return (_bitfield >> 28) & 0x1u;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (_bitfield & ~(0x1u << 28)) | ((value & 0x1u) << 28);
            }
        }
    }
}
