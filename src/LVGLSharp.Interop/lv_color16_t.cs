namespace LVGLSharp.Interop
{
    public partial struct lv_color16_t
    {
        public c_uint16 _bitfield;

        [NativeTypeName("uint16_t : 5")]
        public c_uint16 blue
        {
            readonly get
            {
                return (c_uint16)(_bitfield & 0x1Fu);
            }

            set
            {
                _bitfield = (c_uint16)((_bitfield & ~0x1Fu) | (value & 0x1Fu));
            }
        }

        [NativeTypeName("uint16_t : 6")]
        public c_uint16 green
        {
            readonly get
            {
                return (c_uint16)((_bitfield >> 5) & 0x3Fu);
            }

            set
            {
                _bitfield = (c_uint16)((_bitfield & ~(0x3Fu << 5)) | ((value & 0x3Fu) << 5));
            }
        }

        [NativeTypeName("uint16_t : 5")]
        public c_uint16 red
        {
            readonly get
            {
                return (c_uint16)((_bitfield >> 11) & 0x1Fu);
            }

            set
            {
                _bitfield = (c_uint16)((_bitfield & ~(0x1Fu << 11)) | ((value & 0x1Fu) << 11));
            }
        }
    }
}
