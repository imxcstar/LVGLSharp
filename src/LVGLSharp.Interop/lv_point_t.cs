namespace LVGLSharp.Interop
{
    public partial struct lv_point_t
    {
        [NativeTypeName("int32_t")]
        public c_int32 x;

        [NativeTypeName("int32_t")]
        public c_int32 y;
    }
}
