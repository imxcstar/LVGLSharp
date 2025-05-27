using System.Runtime.InteropServices;

namespace LVGLSharp.Interop
{
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct lv_subject_value_t
    {
        [FieldOffset(0)]
        [NativeTypeName("int32_t")]
        public int num;

        [FieldOffset(0)]
        [NativeTypeName("const void *")]
        public void* pointer;

        [FieldOffset(0)]
        public lv_color_t color;
    }
}
