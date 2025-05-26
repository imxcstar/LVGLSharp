namespace LVGLSharp.Interop
{
    public enum lv_dir_t
    {
        LV_DIR_NONE = 0x00,
        LV_DIR_LEFT = (1 << 0),
        LV_DIR_RIGHT = (1 << 1),
        LV_DIR_TOP = (1 << 2),
        LV_DIR_BOTTOM = (1 << 3),
        LV_DIR_HOR = LV_DIR_LEFT | LV_DIR_RIGHT,
        LV_DIR_VER = LV_DIR_TOP | LV_DIR_BOTTOM,
        LV_DIR_ALL = LV_DIR_HOR | LV_DIR_VER,
    }
}
