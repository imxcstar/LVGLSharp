namespace LVGLSharp.Interop
{
    public unsafe partial struct lv_layer_t
    {
        public lv_draw_buf_t* draw_buf;

        public lv_area_t buf_area;

        public lv_color_format_t color_format;

        public lv_area_t _clip_area;

        public lv_area_t phy_clip_area;

        [NativeTypeName("lv_opa_t")]
        public byte opa;

        public lv_color32_t recolor;

        [NativeTypeName("int32_t")]
        public int partial_y_offset;

        public lv_draw_task_t* draw_task_head;

        public lv_layer_t* parent;

        public lv_layer_t* next;

        [NativeTypeName("bool")]
        public c_bool1 all_tasks_added;

        public void* user_data;
    }
}
