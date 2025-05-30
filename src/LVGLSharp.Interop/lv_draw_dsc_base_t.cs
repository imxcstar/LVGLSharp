namespace LVGLSharp.Interop
{
    public unsafe partial struct lv_draw_dsc_base_t
    {
        public lv_obj_t* obj;

        [NativeTypeName("lv_part_t")]
        public uint part;

        [NativeTypeName("uint32_t")]
        public uint id1;

        [NativeTypeName("uint32_t")]
        public uint id2;

        public lv_layer_t* layer;

        [NativeTypeName("size_t")]
        public nuint dsc_size;

        public void* user_data;
    }
}
