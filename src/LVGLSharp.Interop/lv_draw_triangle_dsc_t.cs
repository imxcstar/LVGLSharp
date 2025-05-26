using System;
using System.Runtime.InteropServices;

namespace LVGLSharp.Interop
{
    public partial struct lv_draw_triangle_dsc_t
    {
        public lv_draw_dsc_base_t @base;

        [NativeTypeName("lv_point_precise_t[3]")]
        public _p_e__FixedBuffer p;

        public lv_color_t color;

        [NativeTypeName("lv_opa_t")]
        public c_uint8 opa;

        public lv_grad_dsc_t grad;

        public partial struct _p_e__FixedBuffer
        {
            public lv_point_precise_t e0;
            public lv_point_precise_t e1;
            public lv_point_precise_t e2;

            public ref lv_point_precise_t this[int index]
            {
                get
                {
                    return ref AsSpan()[index];
                }
            }

            public Span<lv_point_precise_t> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 3);
        }
    }
}
