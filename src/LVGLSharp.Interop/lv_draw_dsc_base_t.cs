namespace LVGLSharp.Interop
{
    public unsafe partial struct lv_draw_dsc_base_t
    {
        [NativeTypeName("lv_obj_t *")]
        public _lv_obj_t* obj;

        [NativeTypeName("lv_part_t")]
        public c_uint32 part;

        [NativeTypeName("uint32_t")]
        public c_uint32 id1;

        [NativeTypeName("uint32_t")]
        public c_uint32 id2;

        [NativeTypeName("lv_layer_t *")]
        public _lv_layer_t* layer;

        [NativeTypeName("size_t")]
        public nuint dsc_size;

        public void* user_data;
    }
}
