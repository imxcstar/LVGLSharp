namespace LVGLSharp.Interop
{
    public partial struct _lv_circle_buf_t
    {
        [NativeTypeName("lv_array_t")]
        public _lv_array_t array;

        [NativeTypeName("uint32_t")]
        public c_uint32 head;

        [NativeTypeName("uint32_t")]
        public c_uint32 tail;

        [NativeTypeName("bool")]
        public c_bool1 inner_alloc;
    }
}
