using System.Runtime.InteropServices;

namespace LVGLSharp.Interop
{
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct lv_style_value_t
    {
        [FieldOffset(0)]
        [NativeTypeName("int32_t")]
        public c_int32 num;

        [FieldOffset(0)]
        [NativeTypeName("const void *")]
        public void* ptr;

        [FieldOffset(0)]
        public lv_color_t color;
    }
}
