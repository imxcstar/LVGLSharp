namespace LVGLSharp.Interop
{
    public partial struct lv_event_list_t
    {
        [NativeTypeName("lv_array_t")]
        public _lv_array_t array;

        public c_uint8 _bitfield;

        [NativeTypeName("uint8_t : 1")]
        public c_uint8 is_traversing
        {
            readonly get
            {
                return (c_uint8)(_bitfield & 0x1u);
            }

            set
            {
                _bitfield = (c_uint8)((_bitfield & ~0x1u) | (value & 0x1u));
            }
        }

        [NativeTypeName("uint8_t : 1")]
        public c_uint8 has_marked_deleting
        {
            readonly get
            {
                return (c_uint8)((_bitfield >> 1) & 0x1u);
            }

            set
            {
                _bitfield = (c_uint8)((_bitfield & ~(0x1u << 1)) | ((value & 0x1u) << 1));
            }
        }
    }
}
