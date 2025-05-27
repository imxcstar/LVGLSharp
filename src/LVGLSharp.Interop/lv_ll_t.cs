namespace LVGLSharp.Interop
{
    public unsafe partial struct lv_ll_t
    {
        [NativeTypeName("uint32_t")]
        public uint n_size;

        [NativeTypeName("lv_ll_node_t *")]
        public byte* head;

        [NativeTypeName("lv_ll_node_t *")]
        public byte* tail;
    }
}
