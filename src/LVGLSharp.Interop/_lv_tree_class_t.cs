namespace LVGLSharp.Interop
{
    public unsafe partial struct _lv_tree_class_t
    {
        [NativeTypeName("const struct _lv_tree_class_t *")]
        public _lv_tree_class_t* base_class;

        [NativeTypeName("uint32_t")]
        public c_uint32 instance_size;

        [NativeTypeName("void (*)(const struct _lv_tree_class_t *, struct _lv_tree_node_t *)")]
        public delegate* unmanaged[Cdecl]<_lv_tree_class_t*, _lv_tree_node_t*, void> constructor_cb;

        [NativeTypeName("void (*)(const struct _lv_tree_class_t *, struct _lv_tree_node_t *)")]
        public delegate* unmanaged[Cdecl]<_lv_tree_class_t*, _lv_tree_node_t*, void> destructor_cb;
    }
}
