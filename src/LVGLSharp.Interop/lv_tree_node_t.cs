namespace LVGLSharp.Interop
{
    public unsafe partial struct lv_tree_node_t
    {
        [NativeTypeName("struct _lv_tree_node_t *")]
        public lv_tree_node_t* parent;

        [NativeTypeName("struct _lv_tree_node_t **")]
        public lv_tree_node_t** children;

        [NativeTypeName("uint32_t")]
        public uint child_cnt;

        [NativeTypeName("uint32_t")]
        public uint child_cap;

        [NativeTypeName("const struct _lv_tree_class_t *")]
        public lv_tree_class_t* class_p;
    }
}
