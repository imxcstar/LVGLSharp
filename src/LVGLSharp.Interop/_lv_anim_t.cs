using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace LVGLSharp.Interop
{
    public unsafe partial struct _lv_anim_t
    {
        public void* var;

        [NativeTypeName("lv_anim_exec_xcb_t")]
        public delegate* unmanaged[Cdecl]<void*, int, void> exec_cb;

        [NativeTypeName("lv_anim_custom_exec_cb_t")]
        public delegate* unmanaged[Cdecl]<_lv_anim_t*, int, void> custom_exec_cb;

        [NativeTypeName("lv_anim_start_cb_t")]
        public delegate* unmanaged[Cdecl]<_lv_anim_t*, void> start_cb;

        [NativeTypeName("lv_anim_completed_cb_t")]
        public delegate* unmanaged[Cdecl]<_lv_anim_t*, void> completed_cb;

        [NativeTypeName("lv_anim_deleted_cb_t")]
        public delegate* unmanaged[Cdecl]<_lv_anim_t*, void> deleted_cb;

        [NativeTypeName("lv_anim_get_value_cb_t")]
        public delegate* unmanaged[Cdecl]<_lv_anim_t*, int> get_value_cb;

        public void* user_data;

        [NativeTypeName("lv_anim_path_cb_t")]
        public delegate* unmanaged[Cdecl]<_lv_anim_t*, int> path_cb;

        [NativeTypeName("int32_t")]
        public int start_value;

        [NativeTypeName("int32_t")]
        public int current_value;

        [NativeTypeName("int32_t")]
        public int end_value;

        [NativeTypeName("int32_t")]
        public int duration;

        [NativeTypeName("int32_t")]
        public int act_time;

        [NativeTypeName("uint32_t")]
        public uint reverse_delay;

        [NativeTypeName("uint32_t")]
        public uint reverse_duration;

        [NativeTypeName("uint32_t")]
        public uint repeat_delay;

        [NativeTypeName("uint32_t")]
        public uint repeat_cnt;

        [NativeTypeName("union _lv_anim_path_para_t")]
        public _lv_anim_path_para_t parameter;

        [NativeTypeName("uint32_t")]
        public uint last_timer_run;

        [NativeTypeName("uint32_t")]
        public uint pause_time;

        [NativeTypeName("uint32_t")]
        public uint pause_duration;

        [NativeBitfield("is_paused", offset: 0, length: 1)]
        [NativeBitfield("reverse_play_in_progress", offset: 1, length: 1)]
        [NativeBitfield("run_round", offset: 2, length: 1)]
        [NativeBitfield("start_cb_called", offset: 3, length: 1)]
        [NativeBitfield("early_apply", offset: 4, length: 1)]
        public byte _bitfield;

        [NativeTypeName("uint8_t : 1")]
        public byte is_paused
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return (byte)(_bitfield & 0x1u);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (byte)((_bitfield & ~0x1u) | (value & 0x1u));
            }
        }

        [NativeTypeName("uint8_t : 1")]
        public byte reverse_play_in_progress
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return (byte)((_bitfield >> 1) & 0x1u);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (byte)((_bitfield & ~(0x1u << 1)) | ((value & 0x1u) << 1));
            }
        }

        [NativeTypeName("uint8_t : 1")]
        public byte run_round
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return (byte)((_bitfield >> 2) & 0x1u);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (byte)((_bitfield & ~(0x1u << 2)) | ((value & 0x1u) << 2));
            }
        }

        [NativeTypeName("uint8_t : 1")]
        public byte start_cb_called
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return (byte)((_bitfield >> 3) & 0x1u);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (byte)((_bitfield & ~(0x1u << 3)) | ((value & 0x1u) << 3));
            }
        }

        [NativeTypeName("uint8_t : 1")]
        public byte early_apply
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return (byte)((_bitfield >> 4) & 0x1u);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (byte)((_bitfield & ~(0x1u << 4)) | ((value & 0x1u) << 4));
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
