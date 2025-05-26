namespace LVGLSharp.Interop
{
    public partial struct lv_calendar_date_t
    {
        [NativeTypeName("uint16_t")]
        public c_uint16 year;

        [NativeTypeName("int8_t")]
        public c_int8 month;

        [NativeTypeName("int8_t")]
        public c_int8 day;
    }
}
