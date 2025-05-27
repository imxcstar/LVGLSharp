namespace LVGLSharp.Interop
{
    public partial struct lv_mem_monitor_t
    {
        [NativeTypeName("size_t")]
        public nuint total_size;

        [NativeTypeName("size_t")]
        public nuint free_cnt;

        [NativeTypeName("size_t")]
        public nuint free_size;

        [NativeTypeName("size_t")]
        public nuint free_biggest_size;

        [NativeTypeName("size_t")]
        public nuint used_cnt;

        [NativeTypeName("size_t")]
        public nuint max_used;

        [NativeTypeName("uint8_t")]
        public byte used_pct;

        [NativeTypeName("uint8_t")]
        public byte frag_pct;
    }
}
