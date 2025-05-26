namespace LVGLSharp.Interop
{
    public unsafe partial struct lv_subject_t
    {
        public lv_ll_t subs_ll;

        public lv_subject_value_t value;

        public lv_subject_value_t prev_value;

        public void* user_data;

        public c_uint32 _bitfield;

        [NativeTypeName("uint32_t : 4")]
        public c_uint32 type
        {
            readonly get
            {
                return _bitfield & 0xFu;
            }

            set
            {
                _bitfield = (_bitfield & ~0xFu) | (value & 0xFu);
            }
        }

        [NativeTypeName("uint32_t : 24")]
        public c_uint32 size
        {
            readonly get
            {
                return (_bitfield >> 4) & 0xFFFFFFu;
            }

            set
            {
                _bitfield = (_bitfield & ~(0xFFFFFFu << 4)) | ((value & 0xFFFFFFu) << 4);
            }
        }

        [NativeTypeName("uint32_t : 1")]
        public c_uint32 notify_restart_query
        {
            readonly get
            {
                return (_bitfield >> 28) & 0x1u;
            }

            set
            {
                _bitfield = (_bitfield & ~(0x1u << 28)) | ((value & 0x1u) << 28);
            }
        }
    }
}
