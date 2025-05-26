namespace LVGLSharp.Interop
{
    public unsafe partial struct lv_ll_t
    {
        [NativeTypeName("uint32_t")]
        public c_uint32 n_size;

        [NativeTypeName("lv_ll_node_t *")]
        public c_uint8* head;

        [NativeTypeName("lv_ll_node_t *")]
        public c_uint8* tail;
    }
}
