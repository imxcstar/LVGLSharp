using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace LVGLSharp.Interop
{
    public partial struct lv_grad_dsc_t
    {
        [NativeTypeName("lv_grad_stop_t[2]")]
        public _stops_e__FixedBuffer stops;

        [NativeTypeName("uint8_t")]
        public byte stops_count;

        [NativeBitfield("dir", offset: 0, length: 4)]
        [NativeBitfield("extend", offset: 4, length: 3)]
        public int _bitfield;

        [NativeTypeName("lv_grad_dir_t : 4")]
        public lv_grad_dir_t dir
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return (lv_grad_dir_t)((_bitfield << 28) >> 28);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (_bitfield & ~0xF) | ((int)(value) & 0xF);
            }
        }

        [NativeTypeName("lv_grad_extend_t : 3")]
        public lv_grad_extend_t extend
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return (lv_grad_extend_t)((_bitfield << 25) >> 29);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (_bitfield & ~(0x7 << 4)) | (((int)(value) & 0x7) << 4);
            }
        }

        public partial struct _stops_e__FixedBuffer
        {
            public lv_grad_stop_t e0;
            public lv_grad_stop_t e1;

            public ref lv_grad_stop_t this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan()[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Span<lv_grad_stop_t> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 2);
        }
    }
}
