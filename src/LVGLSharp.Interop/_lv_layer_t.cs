namespace LVGLSharp.Interop
{
    public unsafe partial struct _lv_layer_t
    {
        [NativeTypeName("lv_draw_buf_t *")]
        public _lv_draw_buf_t* draw_buf;

        public lv_area_t buf_area;

        public lv_color_format_t color_format;

        public lv_area_t _clip_area;

        public lv_area_t phy_clip_area;

        [NativeTypeName("lv_opa_t")]
        public c_uint8 opa;

        public lv_color32_t recolor;

        [NativeTypeName("int32_t")]
        public c_int32 partial_y_offset;

        [NativeTypeName("lv_draw_task_t *")]
        public _lv_draw_task_t* draw_task_head;

        [NativeTypeName("lv_layer_t *")]
        public _lv_layer_t* parent;

        [NativeTypeName("lv_layer_t *")]
        public _lv_layer_t* next;

        [NativeTypeName("bool")]
        public c_bool1 all_tasks_added;

        public void* user_data;
    }
}
