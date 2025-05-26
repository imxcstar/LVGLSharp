using System.Runtime.InteropServices;

namespace LVGLSharp.Interop
{
    [StructLayout(LayoutKind.Explicit)]
    public partial struct lv_yuv_buf_t
    {
        [FieldOffset(0)]
        public lv_yuv_plane_t yuv;

        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_lv_image_dsc_L112_C5")]
        public _planar_e__Struct planar;

        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_lv_image_dsc_L117_C5")]
        public _semi_planar_e__Struct semi_planar;

        public partial struct _planar_e__Struct
        {
            public lv_yuv_plane_t y;

            public lv_yuv_plane_t u;

            public lv_yuv_plane_t v;
        }

        public partial struct _semi_planar_e__Struct
        {
            public lv_yuv_plane_t y;

            public lv_yuv_plane_t uv;
        }
    }
}
