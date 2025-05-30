namespace LVGLSharp.Interop
{
    public partial struct lv_circle_buf_t
    {
        public lv_array_t array;

        [NativeTypeName("uint32_t")]
        public uint head;

        [NativeTypeName("uint32_t")]
        public uint tail;

        [NativeTypeName("bool")]
        public c_bool1 inner_alloc;
    }
}
