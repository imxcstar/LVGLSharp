namespace LVGLSharp.Interop
{
    public enum lv_flex_flow_t
    {
        LV_FLEX_FLOW_ROW = 0x00,
        LV_FLEX_FLOW_COLUMN = (1 << 0),
        LV_FLEX_FLOW_ROW_WRAP = LV_FLEX_FLOW_ROW | (1 << 2),
        LV_FLEX_FLOW_ROW_REVERSE = LV_FLEX_FLOW_ROW | (1 << 3),
        LV_FLEX_FLOW_ROW_WRAP_REVERSE = LV_FLEX_FLOW_ROW | (1 << 2) | (1 << 3),
        LV_FLEX_FLOW_COLUMN_WRAP = LV_FLEX_FLOW_COLUMN | (1 << 2),
        LV_FLEX_FLOW_COLUMN_REVERSE = LV_FLEX_FLOW_COLUMN | (1 << 3),
        LV_FLEX_FLOW_COLUMN_WRAP_REVERSE = LV_FLEX_FLOW_COLUMN | (1 << 2) | (1 << 3),
    }
}
