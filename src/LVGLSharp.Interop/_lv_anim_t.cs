using System.Runtime.InteropServices;

namespace LVGLSharp.Interop
{
    public unsafe partial struct _lv_anim_t
    {
        public void* var;

        [NativeTypeName("lv_anim_exec_xcb_t")]
        public delegate* unmanaged[Cdecl]<void*, c_int32, void> exec_cb;

        [NativeTypeName("lv_anim_custom_exec_cb_t")]
        public delegate* unmanaged[Cdecl]<_lv_anim_t*, c_int32, void> custom_exec_cb;

        [NativeTypeName("lv_anim_start_cb_t")]
        public delegate* unmanaged[Cdecl]<_lv_anim_t*, void> start_cb;

        [NativeTypeName("lv_anim_completed_cb_t")]
        public delegate* unmanaged[Cdecl]<_lv_anim_t*, void> completed_cb;

        [NativeTypeName("lv_anim_deleted_cb_t")]
        public delegate* unmanaged[Cdecl]<_lv_anim_t*, void> deleted_cb;

        [NativeTypeName("lv_anim_get_value_cb_t")]
        public delegate* unmanaged[Cdecl]<_lv_anim_t*, c_int32> get_value_cb;

        public void* user_data;

        [NativeTypeName("lv_anim_path_cb_t")]
        public delegate* unmanaged[Cdecl]<_lv_anim_t*, c_int32> path_cb;

        [NativeTypeName("int32_t")]
        public c_int32 start_value;

        [NativeTypeName("int32_t")]
        public c_int32 current_value;

        [NativeTypeName("int32_t")]
        public c_int32 end_value;

        [NativeTypeName("int32_t")]
        public c_int32 duration;

        [NativeTypeName("int32_t")]
        public c_int32 act_time;

        [NativeTypeName("uint32_t")]
        public c_uint32 reverse_delay;

        [NativeTypeName("uint32_t")]
        public c_uint32 reverse_duration;

        [NativeTypeName("uint32_t")]
        public c_uint32 repeat_delay;

        [NativeTypeName("uint32_t")]
        public c_uint32 repeat_cnt;

        [NativeTypeName("union _lv_anim_path_para_t")]
        public _lv_anim_path_para_t parameter;

        [NativeTypeName("uint32_t")]
        public c_uint32 last_timer_run;

        [NativeTypeName("uint32_t")]
        public c_uint32 pause_time;

        [NativeTypeName("uint32_t")]
        public c_uint32 pause_duration;

        public c_uint8 _bitfield;

        [NativeTypeName("uint8_t : 1")]
        public c_uint8 is_paused
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
        public c_uint8 reverse_play_in_progress
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

        [NativeTypeName("uint8_t : 1")]
        public c_uint8 run_round
        {
            readonly get
            {
                return (c_uint8)((_bitfield >> 2) & 0x1u);
            }

            set
            {
                _bitfield = (c_uint8)((_bitfield & ~(0x1u << 2)) | ((value & 0x1u) << 2));
            }
        }

        [NativeTypeName("uint8_t : 1")]
        public c_uint8 start_cb_called
        {
            readonly get
            {
                return (c_uint8)((_bitfield >> 3) & 0x1u);
            }

            set
            {
                _bitfield = (c_uint8)((_bitfield & ~(0x1u << 3)) | ((value & 0x1u) << 3));
            }
        }

        [NativeTypeName("uint8_t : 1")]
        public c_uint8 early_apply
        {
            readonly get
            {
                return (c_uint8)((_bitfield >> 4) & 0x1u);
            }

            set
            {
                _bitfield = (c_uint8)((_bitfield & ~(0x1u << 4)) | ((value & 0x1u) << 4));
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _lv_anim_path_para_t
        {
            [FieldOffset(0)]
            public lv_anim_bezier3_para_t bezier3;
        }
    }
}
