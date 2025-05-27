using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace LVGLSharp.Interop
{
    public partial struct lv_indev_data_t
    {
        public lv_point_t point;

        [NativeTypeName("uint32_t")]
        public uint key;

        [NativeTypeName("uint32_t")]
        public uint btn_id;

        [NativeTypeName("int16_t")]
        public short enc_diff;

        public lv_indev_state_t state;

        [NativeTypeName("bool")]
        public c_bool1 continue_reading;

        [NativeTypeName("lv_indev_gesture_type_t[6]")]
        public _gesture_type_e__FixedBuffer gesture_type;

        [NativeTypeName("void *[6]")]
        public _gesture_data_e__FixedBuffer gesture_data;

        public partial struct _gesture_type_e__FixedBuffer
        {
            public lv_indev_gesture_type_t e0;
            public lv_indev_gesture_type_t e1;
            public lv_indev_gesture_type_t e2;
            public lv_indev_gesture_type_t e3;
            public lv_indev_gesture_type_t e4;
            public lv_indev_gesture_type_t e5;

            public ref lv_indev_gesture_type_t this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan()[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Span<lv_indev_gesture_type_t> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 6);
        }

        public unsafe partial struct _gesture_data_e__FixedBuffer
        {
            public void* e0;
            public void* e1;
            public void* e2;
            public void* e3;
            public void* e4;
            public void* e5;

            public ref void* this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    fixed (void** pThis = &e0)
                    {
                        return ref pThis[index];
                    }
                }
            }
        }
    }
}
