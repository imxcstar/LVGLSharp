using System;
using System.Runtime.InteropServices;

namespace LVGLSharp.Interop
{
    public partial struct lv_grad_dsc_t
    {
        [NativeTypeName("lv_grad_stop_t[2]")]
        public _stops_e__FixedBuffer stops;

        [NativeTypeName("uint8_t")]
        public c_uint8 stops_count;

        public int _bitfield;

        [NativeTypeName("lv_grad_dir_t : 4")]
        public lv_grad_dir_t dir
        {
            readonly get
            {
                return (lv_grad_dir_t)((_bitfield << 28) >> 28);
            }

            set
            {
                _bitfield = (_bitfield & ~0xF) | ((int)(value) & 0xF);
            }
        }

        [NativeTypeName("lv_grad_extend_t : 3")]
        public lv_grad_extend_t extend
        {
            readonly get
            {
                return (lv_grad_extend_t)((_bitfield << 25) >> 29);
            }

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
                get
                {
                    return ref AsSpan()[index];
                }
            }

            public Span<lv_grad_stop_t> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 2);
        }
    }
}
