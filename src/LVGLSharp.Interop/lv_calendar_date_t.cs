namespace LVGLSharp.Interop
{
    public partial struct lv_calendar_date_t
    {
        [NativeTypeName("uint16_t")]
        public ushort year;

        [NativeTypeName("int8_t")]
        public sbyte month;

        [NativeTypeName("int8_t")]
        public sbyte day;
    }
}
