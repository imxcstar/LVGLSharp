namespace LVGLSharp.Interop
{
    public enum lv_font_glyph_format_t
    {
        LV_FONT_GLYPH_FORMAT_NONE = 0,
        LV_FONT_GLYPH_FORMAT_A1 = 0x01,
        LV_FONT_GLYPH_FORMAT_A2 = 0x02,
        LV_FONT_GLYPH_FORMAT_A3 = 0x03,
        LV_FONT_GLYPH_FORMAT_A4 = 0x04,
        LV_FONT_GLYPH_FORMAT_A8 = 0x08,
        LV_FONT_GLYPH_FORMAT_IMAGE = 0x19,
        LV_FONT_GLYPH_FORMAT_VECTOR = 0x1A,
        LV_FONT_GLYPH_FORMAT_SVG = 0x1B,
        LV_FONT_GLYPH_FORMAT_CUSTOM = 0xFF,
    }
}
