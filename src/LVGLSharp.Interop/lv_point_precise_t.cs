namespace LVGLSharp.Interop
{
    public partial struct lv_point_precise_t
    {
        [NativeTypeName("lv_value_precise_t")]
        public c_int32 x;

        [NativeTypeName("lv_value_precise_t")]
        public c_int32 y;
    }
}
