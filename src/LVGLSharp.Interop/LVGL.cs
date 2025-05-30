using System;
using System.Runtime.InteropServices;
using static LVGLSharp.Interop.lv_buttonmatrix_ctrl_t;
using static LVGLSharp.Interop.lv_display_render_mode_t;
using static LVGLSharp.Interop.lv_display_rotation_t;
using static LVGLSharp.Interop.lv_event_code_t;
using static LVGLSharp.Interop.lv_imagebutton_state_t;
using static LVGLSharp.Interop.lv_indev_state_t;
using static LVGLSharp.Interop.lv_label_long_mode_t;
using static LVGLSharp.Interop.lv_result_t;
using static LVGLSharp.Interop.lv_style_res_t;

namespace LVGLSharp.Interop
{
    public static unsafe partial class LVGL
    {
        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_init();

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_deinit();

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern c_bool1 lv_is_initialized();

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* lv_memcpy(void* dst, [NativeTypeName("const void *")] void* src, [NativeTypeName("size_t")] nuint len);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_memset(void* dst, [NativeTypeName("uint8_t")] byte v, [NativeTypeName("size_t")] nuint len);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* lv_memmove(void* dst, [NativeTypeName("const void *")] void* src, [NativeTypeName("size_t")] nuint len);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int lv_memcmp([NativeTypeName("const void *")] void* p1, [NativeTypeName("const void *")] void* p2, [NativeTypeName("size_t")] nuint len);

        public static void lv_memzero(void* dst, [NativeTypeName("size_t")] nuint len)
        {
            lv_memset(dst, 0x00, len);
        }

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern nuint lv_strlen([NativeTypeName("const char *")] byte[] str);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern nuint lv_strnlen([NativeTypeName("const char *")] byte[] str, [NativeTypeName("size_t")] nuint max_len);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern nuint lv_strlcpy([NativeTypeName("char *")] sbyte* dst, [NativeTypeName("const char *")] byte[] src, [NativeTypeName("size_t")] nuint dst_size);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* lv_strncpy([NativeTypeName("char *")] sbyte* dst, [NativeTypeName("const char *")] byte[] src, [NativeTypeName("size_t")] nuint dest_size);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* lv_strcpy([NativeTypeName("char *")] sbyte* dst, [NativeTypeName("const char *")] byte[] src);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int lv_strcmp([NativeTypeName("const char *")] byte[] s1, [NativeTypeName("const char *")] byte[] s2);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int lv_strncmp([NativeTypeName("const char *")] byte[] s1, [NativeTypeName("const char *")] byte[] s2, [NativeTypeName("size_t")] nuint len);

        [return: NativeTypeName("bool")]
        public static c_bool1 lv_streq([NativeTypeName("const char *")] byte[] s1, [NativeTypeName("const char *")] byte[] s2)
        {
            return lv_strcmp(s1, s2) == 0;
        }

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* lv_strdup([NativeTypeName("const char *")] byte[] src);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* lv_strndup([NativeTypeName("const char *")] byte[] src, [NativeTypeName("size_t")] nuint max_len);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* lv_strcat([NativeTypeName("char *")] sbyte* dst, [NativeTypeName("const char *")] byte[] src);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* lv_strncat([NativeTypeName("char *")] sbyte* dst, [NativeTypeName("const char *")] byte[] src, [NativeTypeName("size_t")] nuint src_len);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* lv_strchr([NativeTypeName("const char *")] byte[] str, int c);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_mem_init();

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_mem_deinit();

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("lv_mem_pool_t")]
        public static extern void* lv_mem_add_pool(void* mem, [NativeTypeName("size_t")] nuint bytes);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_mem_remove_pool([NativeTypeName("lv_mem_pool_t")] void* pool);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* lv_malloc([NativeTypeName("size_t")] nuint size);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* lv_calloc([NativeTypeName("size_t")] nuint num, [NativeTypeName("size_t")] nuint size);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* lv_zalloc([NativeTypeName("size_t")] nuint size);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* lv_malloc_zeroed([NativeTypeName("size_t")] nuint size);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_free(void* data);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* lv_realloc(void* data_p, [NativeTypeName("size_t")] nuint new_size);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* lv_reallocf(void* data_p, [NativeTypeName("size_t")] nuint new_size);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* lv_malloc_core([NativeTypeName("size_t")] nuint size);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_free_core(void* p);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* lv_realloc_core(void* p, [NativeTypeName("size_t")] nuint new_size);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_mem_monitor_core(lv_mem_monitor_t* mon_p);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_result_t lv_mem_test_core();

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_result_t lv_mem_test();

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_mem_monitor(lv_mem_monitor_t* mon_p);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int lv_snprintf([NativeTypeName("char *")] sbyte* buffer, [NativeTypeName("size_t")] nuint count, [NativeTypeName("const char *")] byte[] format, __arglist);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int lv_vsnprintf([NativeTypeName("char *")] sbyte* buffer, [NativeTypeName("size_t")] nuint count, [NativeTypeName("const char *")] byte[] format, [NativeTypeName("va_list")] sbyte* va);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_tick_inc([NativeTypeName("uint32_t")] uint tick_period);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint32_t")]
        public static extern uint lv_tick_get();

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint32_t")]
        public static extern uint lv_tick_elaps([NativeTypeName("uint32_t")] uint prev_tick);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_delay_ms([NativeTypeName("uint32_t")] uint ms);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_tick_set_cb([NativeTypeName("lv_tick_get_cb_t")] delegate* unmanaged[Cdecl]<uint> cb);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_delay_set_cb([NativeTypeName("lv_delay_cb_t")] delegate* unmanaged[Cdecl]<uint, void> cb);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_ll_init(lv_ll_t* ll_p, [NativeTypeName("uint32_t")] uint node_size);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* lv_ll_ins_head(lv_ll_t* ll_p);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* lv_ll_ins_prev(lv_ll_t* ll_p, void* n_act);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* lv_ll_ins_tail(lv_ll_t* ll_p);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_ll_remove(lv_ll_t* ll_p, void* node_p);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_ll_clear_custom(lv_ll_t* ll_p, [NativeTypeName("void (*)(void *)")] delegate* unmanaged[Cdecl]<void*, void> cleanup);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_ll_clear(lv_ll_t* ll_p);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_ll_chg_list(lv_ll_t* ll_ori_p, lv_ll_t* ll_new_p, void* node, [NativeTypeName("bool")] c_bool1 head);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* lv_ll_get_head([NativeTypeName("const lv_ll_t *")] lv_ll_t* ll_p);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* lv_ll_get_tail([NativeTypeName("const lv_ll_t *")] lv_ll_t* ll_p);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* lv_ll_get_next([NativeTypeName("const lv_ll_t *")] lv_ll_t* ll_p, [NativeTypeName("const void *")] void* n_act);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* lv_ll_get_prev([NativeTypeName("const lv_ll_t *")] lv_ll_t* ll_p, [NativeTypeName("const void *")] void* n_act);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint32_t")]
        public static extern uint lv_ll_get_len([NativeTypeName("const lv_ll_t *")] lv_ll_t* ll_p);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_ll_move_before(lv_ll_t* ll_p, void* n_act, void* n_after);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern c_bool1 lv_ll_is_empty(lv_ll_t* ll_p);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint32_t")]
        public static extern uint lv_timer_handler();

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint32_t")]
        public static extern uint lv_timer_handler_run_in_period([NativeTypeName("uint32_t")] uint period);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_timer_periodic_handler();

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_timer_handler_set_resume_cb([NativeTypeName("lv_timer_handler_resume_cb_t")] delegate* unmanaged[Cdecl]<void*, void> cb, void* data);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_timer_t* lv_timer_create_basic();

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_timer_t* lv_timer_create([NativeTypeName("lv_timer_cb_t")] delegate* unmanaged[Cdecl]<lv_timer_t*, void> timer_xcb, [NativeTypeName("uint32_t")] uint period, void* user_data);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_timer_delete(lv_timer_t* timer);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_timer_pause(lv_timer_t* timer);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_timer_resume(lv_timer_t* timer);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_timer_set_cb(lv_timer_t* timer, [NativeTypeName("lv_timer_cb_t")] delegate* unmanaged[Cdecl]<lv_timer_t*, void> timer_cb);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_timer_set_period(lv_timer_t* timer, [NativeTypeName("uint32_t")] uint period);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_timer_ready(lv_timer_t* timer);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_timer_set_repeat_count(lv_timer_t* timer, [NativeTypeName("int32_t")] int repeat_count);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_timer_set_auto_delete(lv_timer_t* timer, [NativeTypeName("bool")] c_bool1 auto_delete);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_timer_set_user_data(lv_timer_t* timer, void* user_data);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_timer_reset(lv_timer_t* timer);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_timer_enable([NativeTypeName("bool")] c_bool1 en);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint32_t")]
        public static extern uint lv_timer_get_idle();

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint32_t")]
        public static extern uint lv_timer_get_time_until_next();

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_timer_t* lv_timer_get_next(lv_timer_t* timer);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* lv_timer_get_user_data(lv_timer_t* timer);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern c_bool1 lv_timer_get_paused(lv_timer_t* timer);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("int32_t")]
        public static extern int lv_trigo_sin([NativeTypeName("int16_t")] short angle);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("int32_t")]
        public static extern int lv_trigo_cos([NativeTypeName("int16_t")] short angle);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("int32_t")]
        public static extern int lv_cubic_bezier([NativeTypeName("int32_t")] int x, [NativeTypeName("int32_t")] int x1, [NativeTypeName("int32_t")] int y1, [NativeTypeName("int32_t")] int x2, [NativeTypeName("int32_t")] int y2);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("int32_t")]
        public static extern int lv_bezier3([NativeTypeName("int32_t")] int t, [NativeTypeName("int32_t")] int u0, [NativeTypeName("uint32_t")] uint u1, [NativeTypeName("int32_t")] int u2, [NativeTypeName("int32_t")] int u3);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint16_t")]
        public static extern ushort lv_atan2(int x, int y);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_sqrt([NativeTypeName("uint32_t")] uint x, lv_sqrt_res_t* q, [NativeTypeName("uint32_t")] uint mask);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("int32_t")]
        public static extern int lv_sqrt32([NativeTypeName("uint32_t")] uint x);

        [return: NativeTypeName("int32_t")]
        public static int lv_sqr([NativeTypeName("int32_t")] int x)
        {
            return x * x;
        }

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("int64_t")]
        public static extern long lv_pow([NativeTypeName("int64_t")] long @base, [NativeTypeName("int8_t")] sbyte exp);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("int32_t")]
        public static extern int lv_map([NativeTypeName("int32_t")] int x, [NativeTypeName("int32_t")] int min_in, [NativeTypeName("int32_t")] int max_in, [NativeTypeName("int32_t")] int min_out, [NativeTypeName("int32_t")] int max_out);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_rand_set_seed([NativeTypeName("uint32_t")] uint seed);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint32_t")]
        public static extern uint lv_rand([NativeTypeName("uint32_t")] uint min, [NativeTypeName("uint32_t")] uint max);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_array_init(lv_array_t* array, [NativeTypeName("uint32_t")] uint capacity, [NativeTypeName("uint32_t")] uint element_size);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_array_init_from_buf(lv_array_t* array, void* buf, [NativeTypeName("uint32_t")] uint capacity, [NativeTypeName("uint32_t")] uint element_size);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern c_bool1 lv_array_resize(lv_array_t* array, [NativeTypeName("uint32_t")] uint new_capacity);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_array_deinit(lv_array_t* array);

        [return: NativeTypeName("uint32_t")]
        public static uint lv_array_size([NativeTypeName("const lv_array_t *")] lv_array_t* array)
        {
            return array->size;
        }

        [return: NativeTypeName("uint32_t")]
        public static uint lv_array_capacity([NativeTypeName("const lv_array_t *")] lv_array_t* array)
        {
            return array->capacity;
        }

        [return: NativeTypeName("bool")]
        public static c_bool1 lv_array_is_empty([NativeTypeName("const lv_array_t *")] lv_array_t* array)
        {
            return array->size == 0;
        }

        [return: NativeTypeName("bool")]
        public static c_bool1 lv_array_is_full([NativeTypeName("const lv_array_t *")] lv_array_t* array)
        {
            return array->size == array->capacity;
        }

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_array_copy(lv_array_t* target, [NativeTypeName("const lv_array_t *")] lv_array_t* source);

        public static void lv_array_clear(lv_array_t* array)
        {
            array->size = 0;
        }

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_array_shrink(lv_array_t* array);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_result_t lv_array_remove(lv_array_t* array, [NativeTypeName("uint32_t")] uint index);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_result_t lv_array_erase(lv_array_t* array, [NativeTypeName("uint32_t")] uint start, [NativeTypeName("uint32_t")] uint end);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_result_t lv_array_concat(lv_array_t* array, [NativeTypeName("const lv_array_t *")] lv_array_t* other);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_result_t lv_array_push_back(lv_array_t* array, [NativeTypeName("const void *")] void* element);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_result_t lv_array_assign(lv_array_t* array, [NativeTypeName("uint32_t")] uint index, [NativeTypeName("const void *")] void* value);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* lv_array_at([NativeTypeName("const lv_array_t *")] lv_array_t* array, [NativeTypeName("uint32_t")] uint index);

        public static void* lv_array_front([NativeTypeName("const lv_array_t *")] lv_array_t* array)
        {
            return lv_array_at(array, 0);
        }

        public static void* lv_array_back([NativeTypeName("const lv_array_t *")] lv_array_t* array)
        {
            return lv_array_at(array, lv_array_size(array) - 1);
        }

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_result_t lv_async_call([NativeTypeName("lv_async_cb_t")] delegate* unmanaged[Cdecl]<void*, void> async_xcb, void* user_data);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_result_t lv_async_call_cancel([NativeTypeName("lv_async_cb_t")] delegate* unmanaged[Cdecl]<void*, void> async_xcb, void* user_data);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_anim_init(lv_anim_t* a);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_anim_set_var(lv_anim_t* a, void* var);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_anim_set_exec_cb(lv_anim_t* a, [NativeTypeName("lv_anim_exec_xcb_t")] delegate* unmanaged[Cdecl]<void*, int, void> exec_cb);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_anim_set_duration(lv_anim_t* a, [NativeTypeName("uint32_t")] uint duration);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_anim_set_delay(lv_anim_t* a, [NativeTypeName("uint32_t")] uint delay);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_anim_resume(lv_anim_t* a);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_anim_pause(lv_anim_t* a);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_anim_pause_for(lv_anim_t* a, [NativeTypeName("uint32_t")] uint ms);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern c_bool1 lv_anim_is_paused(lv_anim_t* a);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_anim_set_values(lv_anim_t* a, [NativeTypeName("int32_t")] int start, [NativeTypeName("int32_t")] int end);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_anim_set_custom_exec_cb(lv_anim_t* a, [NativeTypeName("lv_anim_custom_exec_cb_t")] delegate* unmanaged[Cdecl]<lv_anim_t*, int, void> exec_cb);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_anim_set_path_cb(lv_anim_t* a, [NativeTypeName("lv_anim_path_cb_t")] delegate* unmanaged[Cdecl]<lv_anim_t*, int> path_cb);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_anim_set_start_cb(lv_anim_t* a, [NativeTypeName("lv_anim_start_cb_t")] delegate* unmanaged[Cdecl]<lv_anim_t*, void> start_cb);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_anim_set_get_value_cb(lv_anim_t* a, [NativeTypeName("lv_anim_get_value_cb_t")] delegate* unmanaged[Cdecl]<lv_anim_t*, int> get_value_cb);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_anim_set_completed_cb(lv_anim_t* a, [NativeTypeName("lv_anim_completed_cb_t")] delegate* unmanaged[Cdecl]<lv_anim_t*, void> completed_cb);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_anim_set_deleted_cb(lv_anim_t* a, [NativeTypeName("lv_anim_deleted_cb_t")] delegate* unmanaged[Cdecl]<lv_anim_t*, void> deleted_cb);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_anim_set_reverse_duration(lv_anim_t* a, [NativeTypeName("uint32_t")] uint duration);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_anim_set_reverse_time(lv_anim_t* a, [NativeTypeName("uint32_t")] uint duration);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_anim_set_reverse_delay(lv_anim_t* a, [NativeTypeName("uint32_t")] uint delay);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_anim_set_repeat_count(lv_anim_t* a, [NativeTypeName("uint32_t")] uint cnt);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_anim_set_repeat_delay(lv_anim_t* a, [NativeTypeName("uint32_t")] uint delay);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_anim_set_early_apply(lv_anim_t* a, [NativeTypeName("bool")] c_bool1 en);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_anim_set_user_data(lv_anim_t* a, void* user_data);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_anim_set_bezier3_param(lv_anim_t* a, [NativeTypeName("int16_t")] short x1, [NativeTypeName("int16_t")] short y1, [NativeTypeName("int16_t")] short x2, [NativeTypeName("int16_t")] short y2);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_anim_t* lv_anim_start([NativeTypeName("const lv_anim_t *")] lv_anim_t* a);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint32_t")]
        public static extern uint lv_anim_get_delay([NativeTypeName("const lv_anim_t *")] lv_anim_t* a);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint32_t")]
        public static extern uint lv_anim_get_playtime([NativeTypeName("const lv_anim_t *")] lv_anim_t* a);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint32_t")]
        public static extern uint lv_anim_get_time([NativeTypeName("const lv_anim_t *")] lv_anim_t* a);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint32_t")]
        public static extern uint lv_anim_get_repeat_count([NativeTypeName("const lv_anim_t *")] lv_anim_t* a);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* lv_anim_get_user_data([NativeTypeName("const lv_anim_t *")] lv_anim_t* a);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern c_bool1 lv_anim_delete(void* var, [NativeTypeName("lv_anim_exec_xcb_t")] delegate* unmanaged[Cdecl]<void*, int, void> exec_cb);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_anim_delete_all();

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_anim_t* lv_anim_get(void* var, [NativeTypeName("lv_anim_exec_xcb_t")] delegate* unmanaged[Cdecl]<void*, int, void> exec_cb);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_timer_t* lv_anim_get_timer();

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern c_bool1 lv_anim_custom_delete(lv_anim_t* a, [NativeTypeName("lv_anim_custom_exec_cb_t")] delegate* unmanaged[Cdecl]<lv_anim_t*, int, void> exec_cb);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_anim_t* lv_anim_custom_get(lv_anim_t* a, [NativeTypeName("lv_anim_custom_exec_cb_t")] delegate* unmanaged[Cdecl]<lv_anim_t*, int, void> exec_cb);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint16_t")]
        public static extern ushort lv_anim_count_running();

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint32_t")]
        public static extern uint lv_anim_speed([NativeTypeName("uint32_t")] uint speed);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint32_t")]
        public static extern uint lv_anim_speed_clamped([NativeTypeName("uint32_t")] uint speed, [NativeTypeName("uint32_t")] uint min_time, [NativeTypeName("uint32_t")] uint max_time);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint32_t")]
        public static extern uint lv_anim_resolve_speed([NativeTypeName("uint32_t")] uint speed, [NativeTypeName("int32_t")] int start, [NativeTypeName("int32_t")] int end);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint32_t")]
        public static extern uint lv_anim_speed_to_time([NativeTypeName("uint32_t")] uint speed, [NativeTypeName("int32_t")] int start, [NativeTypeName("int32_t")] int end);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_anim_refr_now();

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("int32_t")]
        public static extern int lv_anim_path_linear([NativeTypeName("const lv_anim_t *")] lv_anim_t* a);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("int32_t")]
        public static extern int lv_anim_path_ease_in([NativeTypeName("const lv_anim_t *")] lv_anim_t* a);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("int32_t")]
        public static extern int lv_anim_path_ease_out([NativeTypeName("const lv_anim_t *")] lv_anim_t* a);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("int32_t")]
        public static extern int lv_anim_path_ease_in_out([NativeTypeName("const lv_anim_t *")] lv_anim_t* a);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("int32_t")]
        public static extern int lv_anim_path_overshoot([NativeTypeName("const lv_anim_t *")] lv_anim_t* a);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("int32_t")]
        public static extern int lv_anim_path_bounce([NativeTypeName("const lv_anim_t *")] lv_anim_t* a);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("int32_t")]
        public static extern int lv_anim_path_step([NativeTypeName("const lv_anim_t *")] lv_anim_t* a);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("int32_t")]
        public static extern int lv_anim_path_custom_bezier3([NativeTypeName("const lv_anim_t *")] lv_anim_t* a);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_anim_timeline_t* lv_anim_timeline_create();

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_anim_timeline_delete(lv_anim_timeline_t* at);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_anim_timeline_add(lv_anim_timeline_t* at, [NativeTypeName("uint32_t")] uint start_time, [NativeTypeName("const lv_anim_t *")] lv_anim_t* a);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint32_t")]
        public static extern uint lv_anim_timeline_start(lv_anim_timeline_t* at);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_anim_timeline_pause(lv_anim_timeline_t* at);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_anim_timeline_set_reverse(lv_anim_timeline_t* at, [NativeTypeName("bool")] c_bool1 reverse);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_anim_timeline_set_repeat_count(lv_anim_timeline_t* at, [NativeTypeName("uint32_t")] uint cnt);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_anim_timeline_set_repeat_delay(lv_anim_timeline_t* at, [NativeTypeName("uint32_t")] uint delay);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_anim_timeline_set_progress(lv_anim_timeline_t* at, [NativeTypeName("uint16_t")] ushort progress);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint32_t")]
        public static extern uint lv_anim_timeline_get_playtime(lv_anim_timeline_t* at);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern c_bool1 lv_anim_timeline_get_reverse(lv_anim_timeline_t* at);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint16_t")]
        public static extern ushort lv_anim_timeline_get_progress(lv_anim_timeline_t* at);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint32_t")]
        public static extern uint lv_anim_timeline_get_repeat_count(lv_anim_timeline_t* at);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint32_t")]
        public static extern uint lv_anim_timeline_get_repeat_delay(lv_anim_timeline_t* at);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern c_bool1 lv_rb_init(lv_rb_t* tree, [NativeTypeName("lv_rb_compare_t")] delegate* unmanaged[Cdecl]<void*, void*, sbyte> compare, [NativeTypeName("size_t")] nuint node_size);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_rb_node_t* lv_rb_insert(lv_rb_t* tree, void* key);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_rb_node_t* lv_rb_find(lv_rb_t* tree, [NativeTypeName("const void *")] void* key);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* lv_rb_remove_node(lv_rb_t* tree, lv_rb_node_t* node);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* lv_rb_remove(lv_rb_t* tree, [NativeTypeName("const void *")] void* key);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern c_bool1 lv_rb_drop_node(lv_rb_t* tree, lv_rb_node_t* node);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern c_bool1 lv_rb_drop(lv_rb_t* tree, [NativeTypeName("const void *")] void* key);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_rb_node_t* lv_rb_minimum(lv_rb_t* node);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_rb_node_t* lv_rb_maximum(lv_rb_t* node);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_rb_node_t* lv_rb_minimum_from(lv_rb_node_t* node);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_rb_node_t* lv_rb_maximum_from(lv_rb_node_t* node);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_rb_destroy(lv_rb_t* tree);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_area_set(lv_area_t* area_p, [NativeTypeName("int32_t")] int x1, [NativeTypeName("int32_t")] int y1, [NativeTypeName("int32_t")] int x2, [NativeTypeName("int32_t")] int y2);

        public static void lv_area_copy(lv_area_t* dest, [NativeTypeName("const lv_area_t *")] lv_area_t* src)
        {
            dest->x1 = src->x1;
            dest->y1 = src->y1;
            dest->x2 = src->x2;
            dest->y2 = src->y2;
        }

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("int32_t")]
        public static extern int lv_area_get_width([NativeTypeName("const lv_area_t *")] lv_area_t* area_p);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("int32_t")]
        public static extern int lv_area_get_height([NativeTypeName("const lv_area_t *")] lv_area_t* area_p);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_area_set_width(lv_area_t* area_p, [NativeTypeName("int32_t")] int w);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_area_set_height(lv_area_t* area_p, [NativeTypeName("int32_t")] int h);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint32_t")]
        public static extern uint lv_area_get_size([NativeTypeName("const lv_area_t *")] lv_area_t* area_p);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_area_increase(lv_area_t* area, [NativeTypeName("int32_t")] int w_extra, [NativeTypeName("int32_t")] int h_extra);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_area_move(lv_area_t* area, [NativeTypeName("int32_t")] int x_ofs, [NativeTypeName("int32_t")] int y_ofs);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_area_align([NativeTypeName("const lv_area_t *")] lv_area_t* @base, lv_area_t* to_align, lv_align_t align, [NativeTypeName("int32_t")] int ofs_x, [NativeTypeName("int32_t")] int ofs_y);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_point_transform(lv_point_t* point, [NativeTypeName("int32_t")] int angle, [NativeTypeName("int32_t")] int scale_x, [NativeTypeName("int32_t")] int scale_y, [NativeTypeName("const lv_point_t *")] lv_point_t* pivot, [NativeTypeName("bool")] c_bool1 zoom_first);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_point_array_transform(lv_point_t* points, [NativeTypeName("size_t")] nuint count, [NativeTypeName("int32_t")] int angle, [NativeTypeName("int32_t")] int scale_x, [NativeTypeName("int32_t")] int scale_y, [NativeTypeName("const lv_point_t *")] lv_point_t* pivot, [NativeTypeName("bool")] c_bool1 zoom_first);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_point_t lv_point_from_precise([NativeTypeName("const lv_point_precise_t *")] lv_point_precise_t* p);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_point_precise_t lv_point_to_precise([NativeTypeName("const lv_point_t *")] lv_point_t* p);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_point_set(lv_point_t* p, [NativeTypeName("int32_t")] int x, [NativeTypeName("int32_t")] int y);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_point_precise_set(lv_point_precise_t* p, [NativeTypeName("lv_value_precise_t")] int x, [NativeTypeName("lv_value_precise_t")] int y);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_point_swap(lv_point_t* p1, lv_point_t* p2);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_point_precise_swap(lv_point_precise_t* p1, lv_point_precise_t* p2);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("int32_t")]
        public static extern int lv_pct([NativeTypeName("int32_t")] int x);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("int32_t")]
        public static extern int lv_pct_to_px([NativeTypeName("int32_t")] int v, [NativeTypeName("int32_t")] int @base);

        public const int LV_OPA_TRANSP = 0;
        public const int LV_OPA_0 = 0;
        public const int LV_OPA_10 = 25;
        public const int LV_OPA_20 = 51;
        public const int LV_OPA_30 = 76;
        public const int LV_OPA_40 = 102;
        public const int LV_OPA_50 = 127;
        public const int LV_OPA_60 = 153;
        public const int LV_OPA_70 = 178;
        public const int LV_OPA_80 = 204;
        public const int LV_OPA_90 = 229;
        public const int LV_OPA_100 = 255;
        public const int LV_OPA_COVER = 255;

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint8_t")]
        public static extern byte lv_color_format_get_bpp(lv_color_format_t cf);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint8_t")]
        public static extern byte lv_color_format_get_size(lv_color_format_t cf);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern c_bool1 lv_color_format_has_alpha(lv_color_format_t src_cf);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_color32_t lv_color_to_32(lv_color_t color, [NativeTypeName("lv_opa_t")] byte opa);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint32_t")]
        public static extern uint lv_color_to_int(lv_color_t c);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern c_bool1 lv_color_eq(lv_color_t c1, lv_color_t c2);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern c_bool1 lv_color32_eq(lv_color32_t c1, lv_color32_t c2);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_color_t lv_color_hex([NativeTypeName("uint32_t")] uint c);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_color_t lv_color_make([NativeTypeName("uint8_t")] byte r, [NativeTypeName("uint8_t")] byte g, [NativeTypeName("uint8_t")] byte b);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_color32_t lv_color32_make([NativeTypeName("uint8_t")] byte r, [NativeTypeName("uint8_t")] byte g, [NativeTypeName("uint8_t")] byte b, [NativeTypeName("uint8_t")] byte a);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_color_t lv_color_hex3([NativeTypeName("uint32_t")] uint c);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint16_t")]
        public static extern ushort lv_color_to_u16(lv_color_t color);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint32_t")]
        public static extern uint lv_color_to_u32(lv_color_t color);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint16_t")]
        public static extern ushort lv_color_16_16_mix([NativeTypeName("uint16_t")] ushort c1, [NativeTypeName("uint16_t")] ushort c2, [NativeTypeName("uint8_t")] byte mix);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_color_t lv_color_lighten(lv_color_t c, [NativeTypeName("lv_opa_t")] byte lvl);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_color_t lv_color_darken(lv_color_t c, [NativeTypeName("lv_opa_t")] byte lvl);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_color_t lv_color_hsv_to_rgb([NativeTypeName("uint16_t")] ushort h, [NativeTypeName("uint8_t")] byte s, [NativeTypeName("uint8_t")] byte v);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_color_hsv_t lv_color_rgb_to_hsv([NativeTypeName("uint8_t")] byte r8, [NativeTypeName("uint8_t")] byte g8, [NativeTypeName("uint8_t")] byte b8);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_color_hsv_t lv_color_to_hsv(lv_color_t color);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_color_t lv_color_white();

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_color_t lv_color_black();

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_color_premultiply(lv_color32_t* c);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_color16_premultiply(lv_color16_t* c, [NativeTypeName("lv_opa_t")] byte a);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint8_t")]
        public static extern byte lv_color_luminance(lv_color_t c);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint8_t")]
        public static extern byte lv_color16_luminance([NativeTypeName("const lv_color16_t")] lv_color16_t c);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint8_t")]
        public static extern byte lv_color24_luminance([NativeTypeName("const uint8_t *")] byte[] c);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint8_t")]
        public static extern byte lv_color32_luminance(lv_color32_t c);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_color_t lv_palette_main(lv_palette_t p);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_color_t lv_palette_lighten(lv_palette_t p, [NativeTypeName("uint8_t")] byte lvl);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_color_t lv_palette_darken(lv_palette_t p, [NativeTypeName("uint8_t")] byte lvl);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_color_t lv_color_mix(lv_color_t c1, lv_color_t c2, [NativeTypeName("uint8_t")] byte mix);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_color32_t lv_color_mix32(lv_color32_t fg, lv_color32_t bg);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_color32_t lv_color_mix32_premultiplied(lv_color32_t fg, lv_color32_t bg);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint8_t")]
        public static extern byte lv_color_brightness(lv_color_t c);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_color_filter_dsc_init(lv_color_filter_dsc_t* dsc, [NativeTypeName("lv_color_filter_cb_t")] delegate* unmanaged[Cdecl]<lv_color_filter_dsc_t*, lv_color_t, byte, lv_color_t> cb);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_color32_t lv_color_over32(lv_color32_t fg, lv_color32_t bg);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_draw_buf_init_with_default_handlers(lv_draw_buf_handlers_t* handlers);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_draw_buf_handlers_init(lv_draw_buf_handlers_t* handlers, [NativeTypeName("lv_draw_buf_malloc_cb")] delegate* unmanaged[Cdecl]<nuint, lv_color_format_t, void*> buf_malloc_cb, [NativeTypeName("lv_draw_buf_free_cb")] delegate* unmanaged[Cdecl]<void*, void> buf_free_cb, [NativeTypeName("lv_draw_buf_align_cb")] delegate* unmanaged[Cdecl]<void*, lv_color_format_t, void*> align_pointer_cb, [NativeTypeName("lv_draw_buf_cache_operation_cb")] delegate* unmanaged[Cdecl]<lv_draw_buf_t*, lv_area_t*, void> invalidate_cache_cb, [NativeTypeName("lv_draw_buf_cache_operation_cb")] delegate* unmanaged[Cdecl]<lv_draw_buf_t*, lv_area_t*, void> flush_cache_cb, [NativeTypeName("lv_draw_buf_width_to_stride_cb")] delegate* unmanaged[Cdecl]<uint, lv_color_format_t, uint> width_to_stride_cb);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_draw_buf_handlers_t* lv_draw_buf_get_handlers();

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_draw_buf_handlers_t* lv_draw_buf_get_font_handlers();

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_draw_buf_handlers_t* lv_draw_buf_get_image_handlers();

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* lv_draw_buf_align(void* buf, lv_color_format_t color_format);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* lv_draw_buf_align_ex([NativeTypeName("const lv_draw_buf_handlers_t *")] lv_draw_buf_handlers_t* handlers, void* buf, lv_color_format_t color_format);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_draw_buf_invalidate_cache([NativeTypeName("const lv_draw_buf_t *")] lv_draw_buf_t* draw_buf, [NativeTypeName("const lv_area_t *")] lv_area_t* area);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_draw_buf_flush_cache([NativeTypeName("const lv_draw_buf_t *")] lv_draw_buf_t* draw_buf, [NativeTypeName("const lv_area_t *")] lv_area_t* area);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint32_t")]
        public static extern uint lv_draw_buf_width_to_stride([NativeTypeName("uint32_t")] uint w, lv_color_format_t color_format);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint32_t")]
        public static extern uint lv_draw_buf_width_to_stride_ex([NativeTypeName("const lv_draw_buf_handlers_t *")] lv_draw_buf_handlers_t* handlers, [NativeTypeName("uint32_t")] uint w, lv_color_format_t color_format);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_draw_buf_clear(lv_draw_buf_t* draw_buf, [NativeTypeName("const lv_area_t *")] lv_area_t* a);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_draw_buf_copy(lv_draw_buf_t* dest, [NativeTypeName("const lv_area_t *")] lv_area_t* dest_area, [NativeTypeName("const lv_draw_buf_t *")] lv_draw_buf_t* src, [NativeTypeName("const lv_area_t *")] lv_area_t* src_area);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_draw_buf_t* lv_draw_buf_create([NativeTypeName("uint32_t")] uint w, [NativeTypeName("uint32_t")] uint h, lv_color_format_t cf, [NativeTypeName("uint32_t")] uint stride);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_draw_buf_t* lv_draw_buf_create_ex([NativeTypeName("const lv_draw_buf_handlers_t *")] lv_draw_buf_handlers_t* handlers, [NativeTypeName("uint32_t")] uint w, [NativeTypeName("uint32_t")] uint h, lv_color_format_t cf, [NativeTypeName("uint32_t")] uint stride);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_draw_buf_t* lv_draw_buf_dup([NativeTypeName("const lv_draw_buf_t *")] lv_draw_buf_t* draw_buf);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_draw_buf_t* lv_draw_buf_dup_ex([NativeTypeName("const lv_draw_buf_handlers_t *")] lv_draw_buf_handlers_t* handlers, [NativeTypeName("const lv_draw_buf_t *")] lv_draw_buf_t* draw_buf);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_result_t lv_draw_buf_init(lv_draw_buf_t* draw_buf, [NativeTypeName("uint32_t")] uint w, [NativeTypeName("uint32_t")] uint h, lv_color_format_t cf, [NativeTypeName("uint32_t")] uint stride, void* data, [NativeTypeName("uint32_t")] uint data_size);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_draw_buf_t* lv_draw_buf_reshape(lv_draw_buf_t* draw_buf, lv_color_format_t cf, [NativeTypeName("uint32_t")] uint w, [NativeTypeName("uint32_t")] uint h, [NativeTypeName("uint32_t")] uint stride);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_draw_buf_destroy(lv_draw_buf_t* draw_buf);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* lv_draw_buf_goto_xy([NativeTypeName("const lv_draw_buf_t *")] lv_draw_buf_t* buf, [NativeTypeName("uint32_t")] uint x, [NativeTypeName("uint32_t")] uint y);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_result_t lv_draw_buf_adjust_stride(lv_draw_buf_t* src, [NativeTypeName("uint32_t")] uint stride);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_result_t lv_draw_buf_premultiply(lv_draw_buf_t* draw_buf);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern c_bool1 lv_draw_buf_has_flag([NativeTypeName("const lv_draw_buf_t *")] lv_draw_buf_t* draw_buf, [NativeTypeName("lv_image_flags_t")] lvimage_flags_t flag);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_draw_buf_set_flag(lv_draw_buf_t* draw_buf, [NativeTypeName("lv_image_flags_t")] lvimage_flags_t flag);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_draw_buf_clear_flag(lv_draw_buf_t* draw_buf, [NativeTypeName("lv_image_flags_t")] lvimage_flags_t flag);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_result_t lv_draw_buf_from_image(lv_draw_buf_t* buf, [NativeTypeName("const lv_image_dsc_t *")] lv_image_dsc_t* img);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_draw_buf_to_image([NativeTypeName("const lv_draw_buf_t *")] lv_draw_buf_t* buf, lv_image_dsc_t* img);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_draw_buf_set_palette(lv_draw_buf_t* draw_buf, [NativeTypeName("uint8_t")] byte index, lv_color32_t color);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_image_buf_set_palette(lv_image_dsc_t* dsc, [NativeTypeName("uint8_t")] byte id, lv_color32_t c);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_image_buf_free(lv_image_dsc_t* dsc);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* lv_utils_bsearch([NativeTypeName("const void *")] void* key, [NativeTypeName("const void *")] void* @base, [NativeTypeName("size_t")] nuint n, [NativeTypeName("size_t")] nuint size, [NativeTypeName("int (*)(const void *, const void *)")] delegate* unmanaged[Cdecl]<void*, void*, int> cmp);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_result_t lv_draw_buf_save_to_file([NativeTypeName("const lv_draw_buf_t *")] lv_draw_buf_t* draw_buf, [NativeTypeName("const char *")] byte[] path);

        [return: NativeTypeName("uint32_t")]
        public static uint lv_swap_bytes_32([NativeTypeName("uint32_t")] uint x)
        {
            return (x << 24) | ((x & 0x0000ff00U) << 8) | ((x & 0x00ff0000U) >> 8) | (x >> 24);
        }

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_iter_t* lv_iter_create(void* instance, [NativeTypeName("uint32_t")] uint elem_size, [NativeTypeName("uint32_t")] uint context_size, [NativeTypeName("lv_iter_next_cb")] delegate* unmanaged[Cdecl]<void*, void*, void*, lv_result_t> next_cb);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* lv_iter_get_context([NativeTypeName("const lv_iter_t *")] lv_iter_t* iter);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_iter_destroy(lv_iter_t* iter);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_result_t lv_iter_next(lv_iter_t* iter, void* elem);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_iter_make_peekable(lv_iter_t* iter, [NativeTypeName("uint32_t")] uint capacity);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_result_t lv_iter_peek(lv_iter_t* iter, void* elem);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_result_t lv_iter_peek_advance(lv_iter_t* iter);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_result_t lv_iter_peek_reset(lv_iter_t* iter);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_iter_inspect(lv_iter_t* iter, [NativeTypeName("lv_iter_inspect_cb")] delegate* unmanaged[Cdecl]<void*, void> inspect_cb);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_circle_buf_t* lv_circle_buf_create([NativeTypeName("uint32_t")] uint capacity, [NativeTypeName("uint32_t")] uint element_size);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_circle_buf_t* lv_circle_buf_create_from_buf(void* buf, [NativeTypeName("uint32_t")] uint capacity, [NativeTypeName("uint32_t")] uint element_size);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_circle_buf_t* lv_circle_buf_create_from_array([NativeTypeName("const lv_array_t *")] lv_array_t* array);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_result_t lv_circle_buf_resize(lv_circle_buf_t* circle_buf, [NativeTypeName("uint32_t")] uint capacity);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_circle_buf_destroy(lv_circle_buf_t* circle_buf);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint32_t")]
        public static extern uint lv_circle_buf_size([NativeTypeName("const lv_circle_buf_t *")] lv_circle_buf_t* circle_buf);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint32_t")]
        public static extern uint lv_circle_buf_capacity([NativeTypeName("const lv_circle_buf_t *")] lv_circle_buf_t* circle_buf);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint32_t")]
        public static extern uint lv_circle_buf_remain([NativeTypeName("const lv_circle_buf_t *")] lv_circle_buf_t* circle_buf);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern c_bool1 lv_circle_buf_is_empty([NativeTypeName("const lv_circle_buf_t *")] lv_circle_buf_t* circle_buf);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern c_bool1 lv_circle_buf_is_full([NativeTypeName("const lv_circle_buf_t *")] lv_circle_buf_t* circle_buf);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_circle_buf_reset(lv_circle_buf_t* circle_buf);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* lv_circle_buf_head([NativeTypeName("const lv_circle_buf_t *")] lv_circle_buf_t* circle_buf);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* lv_circle_buf_tail([NativeTypeName("const lv_circle_buf_t *")] lv_circle_buf_t* circle_buf);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_result_t lv_circle_buf_read(lv_circle_buf_t* circle_buf, void* data);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_result_t lv_circle_buf_write(lv_circle_buf_t* circle_buf, [NativeTypeName("const void *")] void* data);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint32_t")]
        public static extern uint lv_circle_buf_fill(lv_circle_buf_t* circle_buf, [NativeTypeName("uint32_t")] uint count, [NativeTypeName("lv_circle_buf_fill_cb_t")] delegate* unmanaged[Cdecl]<void*, uint, int, void*, c_bool1> fill_cb, void* user_data);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_result_t lv_circle_buf_skip(lv_circle_buf_t* circle_buf);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_result_t lv_circle_buf_peek([NativeTypeName("const lv_circle_buf_t *")] lv_circle_buf_t* circle_buf, void* data);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_result_t lv_circle_buf_peek_at([NativeTypeName("const lv_circle_buf_t *")] lv_circle_buf_t* circle_buf, [NativeTypeName("uint32_t")] uint index, void* data);

        public const int LV_TREE_WALK_PRE_ORDER = 0;
        public const int LV_TREE_WALK_POST_ORDER = 1;

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_tree_node_t* lv_tree_node_create([NativeTypeName("const lv_tree_class_t *")] lv_tree_class_t* class_p, lv_tree_node_t* parent);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_tree_node_delete(lv_tree_node_t* node);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern c_bool1 lv_tree_walk([NativeTypeName("const lv_tree_node_t *")] lv_tree_node_t* node, [NativeTypeName("lv_tree_walk_mode_t")] byte mode, [NativeTypeName("lv_tree_traverse_cb_t")] delegate* unmanaged[Cdecl]<lv_tree_node_t*, void*, c_bool1> cb, [NativeTypeName("lv_tree_before_cb_t")] delegate* unmanaged[Cdecl]<lv_tree_node_t*, void*, c_bool1> bcb, [NativeTypeName("lv_tree_after_cb_t")] delegate* unmanaged[Cdecl]<lv_tree_node_t*, void*, void> acb, void* user_data);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint32_t")]
        public static extern uint lv_cache_entry_get_size([NativeTypeName("const uint32_t")] uint node_size);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("int32_t")]
        public static extern int lv_cache_entry_get_ref(lv_cache_entry_t* entry);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint32_t")]
        public static extern uint lv_cache_entry_get_node_size(lv_cache_entry_t* entry);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern c_bool1 lv_cache_entry_is_invalid(lv_cache_entry_t* entry);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* lv_cache_entry_get_data(lv_cache_entry_t* entry);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const lv_cache_t *")]
        public static extern lv_cache_t* lv_cache_entry_get_cache([NativeTypeName("const lv_cache_entry_t *")] lv_cache_entry_t* entry);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_cache_entry_t* lv_cache_entry_get_entry(void* data, [NativeTypeName("const uint32_t")] uint node_size);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_cache_entry_t* lv_cache_entry_alloc([NativeTypeName("const uint32_t")] uint node_size, [NativeTypeName("const lv_cache_t *")] lv_cache_t* cache);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_cache_entry_init(lv_cache_entry_t* entry, [NativeTypeName("const lv_cache_t *")] lv_cache_t* cache, [NativeTypeName("const uint32_t")] uint node_size);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_cache_entry_delete(lv_cache_entry_t* entry);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint32_t")]
        public static extern uint lv_os_get_idle_percent();

        public static void lv_lock()
        {
        }

        public static lv_result_t lv_lock_isr()
        {
            return LV_RESULT_OK;
        }

        public static void lv_unlock()
        {
        }

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_result_t lv_image_header_cache_init([NativeTypeName("uint32_t")] uint count);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_image_header_cache_resize([NativeTypeName("uint32_t")] uint count, [NativeTypeName("bool")] c_bool1 evict_now);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_image_header_cache_drop([NativeTypeName("const void *")] void* src);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern c_bool1 lv_image_header_cache_is_enabled();

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_iter_t* lv_image_header_cache_iter_create();

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_image_header_cache_dump();

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_result_t lv_image_cache_init([NativeTypeName("uint32_t")] uint size);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_image_cache_resize([NativeTypeName("uint32_t")] uint new_size, [NativeTypeName("bool")] c_bool1 evict_now);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_image_cache_drop([NativeTypeName("const void *")] void* src);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern c_bool1 lv_image_cache_is_enabled();

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_iter_t* lv_image_cache_iter_create();

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_image_cache_dump();

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_cache_t* lv_cache_create([NativeTypeName("const lv_cache_class_t *")] lv_cache_class_t* cache_class, [NativeTypeName("size_t")] nuint node_size, [NativeTypeName("size_t")] nuint max_size, lv_cache_ops_t ops);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_cache_destroy(lv_cache_t* cache, void* user_data);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_cache_entry_t* lv_cache_acquire(lv_cache_t* cache, [NativeTypeName("const void *")] void* key, void* user_data);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_cache_entry_t* lv_cache_acquire_or_create(lv_cache_t* cache, [NativeTypeName("const void *")] void* key, void* user_data);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_cache_entry_t* lv_cache_add(lv_cache_t* cache, [NativeTypeName("const void *")] void* key, void* user_data);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_cache_release(lv_cache_t* cache, lv_cache_entry_t* entry, void* user_data);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_cache_reserve(lv_cache_t* cache, [NativeTypeName("uint32_t")] uint reserved_size, void* user_data);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_cache_drop(lv_cache_t* cache, [NativeTypeName("const void *")] void* key, void* user_data);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_cache_drop_all(lv_cache_t* cache, void* user_data);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern c_bool1 lv_cache_evict_one(lv_cache_t* cache, void* user_data);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_cache_set_max_size(lv_cache_t* cache, [NativeTypeName("size_t")] nuint max_size, void* user_data);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern nuint lv_cache_get_max_size(lv_cache_t* cache, void* user_data);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern nuint lv_cache_get_size(lv_cache_t* cache, void* user_data);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern nuint lv_cache_get_free_size(lv_cache_t* cache, void* user_data);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern c_bool1 lv_cache_is_enabled(lv_cache_t* cache);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_cache_set_compare_cb(lv_cache_t* cache, [NativeTypeName("lv_cache_compare_cb_t")] delegate* unmanaged[Cdecl]<void*, void*, sbyte> compare_cb, void* user_data);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_cache_set_create_cb(lv_cache_t* cache, [NativeTypeName("lv_cache_create_cb_t")] delegate* unmanaged[Cdecl]<void*, void*, c_bool1> alloc_cb, void* user_data);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_cache_set_free_cb(lv_cache_t* cache, [NativeTypeName("lv_cache_free_cb_t")] delegate* unmanaged[Cdecl]<void*, void*, void> free_cb, void* user_data);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_cache_set_name(lv_cache_t* cache, [NativeTypeName("const char *")] byte[] name);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern byte[] lv_cache_get_name(lv_cache_t* cache);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_iter_t* lv_cache_iter_create(lv_cache_t* cache);

        public const int LV_STR_SYMBOL_BULLET = 0;
        public const int LV_STR_SYMBOL_AUDIO = 1;
        public const int LV_STR_SYMBOL_VIDEO = 2;
        public const int LV_STR_SYMBOL_LIST = 3;
        public const int LV_STR_SYMBOL_OK = 4;
        public const int LV_STR_SYMBOL_CLOSE = 5;
        public const int LV_STR_SYMBOL_POWER = 6;
        public const int LV_STR_SYMBOL_SETTINGS = 7;
        public const int LV_STR_SYMBOL_HOME = 8;
        public const int LV_STR_SYMBOL_DOWNLOAD = 9;
        public const int LV_STR_SYMBOL_DRIVE = 10;
        public const int LV_STR_SYMBOL_REFRESH = 11;
        public const int LV_STR_SYMBOL_MUTE = 12;
        public const int LV_STR_SYMBOL_VOLUME_MID = 13;
        public const int LV_STR_SYMBOL_VOLUME_MAX = 14;
        public const int LV_STR_SYMBOL_IMAGE = 15;
        public const int LV_STR_SYMBOL_TINT = 16;
        public const int LV_STR_SYMBOL_PREV = 17;
        public const int LV_STR_SYMBOL_PLAY = 18;
        public const int LV_STR_SYMBOL_PAUSE = 19;
        public const int LV_STR_SYMBOL_STOP = 20;
        public const int LV_STR_SYMBOL_NEXT = 21;
        public const int LV_STR_SYMBOL_EJECT = 22;
        public const int LV_STR_SYMBOL_LEFT = 23;
        public const int LV_STR_SYMBOL_RIGHT = 24;
        public const int LV_STR_SYMBOL_PLUS = 25;
        public const int LV_STR_SYMBOL_MINUS = 26;
        public const int LV_STR_SYMBOL_EYE_OPEN = 27;
        public const int LV_STR_SYMBOL_EYE_CLOSE = 28;
        public const int LV_STR_SYMBOL_WARNING = 29;
        public const int LV_STR_SYMBOL_SHUFFLE = 30;
        public const int LV_STR_SYMBOL_UP = 31;
        public const int LV_STR_SYMBOL_DOWN = 32;
        public const int LV_STR_SYMBOL_LOOP = 33;
        public const int LV_STR_SYMBOL_DIRECTORY = 34;
        public const int LV_STR_SYMBOL_UPLOAD = 35;
        public const int LV_STR_SYMBOL_CALL = 36;
        public const int LV_STR_SYMBOL_CUT = 37;
        public const int LV_STR_SYMBOL_COPY = 38;
        public const int LV_STR_SYMBOL_SAVE = 39;
        public const int LV_STR_SYMBOL_BARS = 40;
        public const int LV_STR_SYMBOL_ENVELOPE = 41;
        public const int LV_STR_SYMBOL_CHARGE = 42;
        public const int LV_STR_SYMBOL_PASTE = 43;
        public const int LV_STR_SYMBOL_BELL = 44;
        public const int LV_STR_SYMBOL_KEYBOARD = 45;
        public const int LV_STR_SYMBOL_GPS = 46;
        public const int LV_STR_SYMBOL_FILE = 47;
        public const int LV_STR_SYMBOL_WIFI = 48;
        public const int LV_STR_SYMBOL_BATTERY_FULL = 49;
        public const int LV_STR_SYMBOL_BATTERY_3 = 50;
        public const int LV_STR_SYMBOL_BATTERY_2 = 51;
        public const int LV_STR_SYMBOL_BATTERY_1 = 52;
        public const int LV_STR_SYMBOL_BATTERY_EMPTY = 53;
        public const int LV_STR_SYMBOL_USB = 54;
        public const int LV_STR_SYMBOL_BLUETOOTH = 55;
        public const int LV_STR_SYMBOL_TRASH = 56;
        public const int LV_STR_SYMBOL_EDIT = 57;
        public const int LV_STR_SYMBOL_BACKSPACE = 58;
        public const int LV_STR_SYMBOL_SD_CARD = 59;
        public const int LV_STR_SYMBOL_NEW_LINE = 60;
        public const int LV_STR_SYMBOL_DUMMY = 61;

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const void *")]
        public static extern void* lv_font_get_glyph_bitmap(lv_font_glyph_dsc_t* g_dsc, lv_draw_buf_t* draw_buf);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const void *")]
        public static extern void* lv_font_get_glyph_static_bitmap(lv_font_glyph_dsc_t* g_dsc);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern c_bool1 lv_font_get_glyph_dsc([NativeTypeName("const lv_font_t *")] lv_font_t* font, lv_font_glyph_dsc_t* dsc_out, [NativeTypeName("uint32_t")] uint letter, [NativeTypeName("uint32_t")] uint letter_next);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_font_glyph_release_draw_data(lv_font_glyph_dsc_t* g_dsc);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint16_t")]
        public static extern ushort lv_font_get_glyph_width([NativeTypeName("const lv_font_t *")] lv_font_t* font, [NativeTypeName("uint32_t")] uint letter, [NativeTypeName("uint32_t")] uint letter_next);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("int32_t")]
        public static extern int lv_font_get_line_height([NativeTypeName("const lv_font_t *")] lv_font_t* font);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_font_set_kerning(lv_font_t* font, lv_font_kerning_t kerning);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const lv_font_t *")]
        public static extern lv_font_t* lv_font_get_default();

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern c_bool1 lv_font_info_is_equal([NativeTypeName("const lv_font_info_t *")] lv_font_info_t* ft_info_1, [NativeTypeName("const lv_font_info_t *")] lv_font_info_t* ft_info_2);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern c_bool1 lv_font_has_static_bitmap([NativeTypeName("const lv_font_t *")] lv_font_t* font);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_text_get_size(lv_point_t* size_res, [NativeTypeName("const char *")] byte[] text, [NativeTypeName("const lv_font_t *")] lv_font_t* font, [NativeTypeName("int32_t")] int letter_space, [NativeTypeName("int32_t")] int line_space, [NativeTypeName("int32_t")] int max_width, lv_text_flag_t flag);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("int32_t")]
        public static extern int lv_text_get_width([NativeTypeName("const char *")] byte[] txt, [NativeTypeName("uint32_t")] uint length, [NativeTypeName("const lv_font_t *")] lv_font_t* font, [NativeTypeName("int32_t")] int letter_space);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("int32_t")]
        public static extern int lv_text_get_width_with_flags([NativeTypeName("const char *")] byte[] txt, [NativeTypeName("uint32_t")] uint length, [NativeTypeName("const lv_font_t *")] lv_font_t* font, [NativeTypeName("int32_t")] int letter_space, lv_text_flag_t flags);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern c_bool1 lv_text_is_cmd(lv_text_cmd_state_t* state, [NativeTypeName("uint32_t")] uint c);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_grad_init_stops(lv_grad_dsc_t* grad, [NativeTypeName("const lv_color_t[]")] lv_color_t* colors, [NativeTypeName("const lv_opa_t[]")] byte* opa, [NativeTypeName("const uint8_t[]")] byte* fracs, int num_stops);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_grad_horizontal_init(lv_grad_dsc_t* dsc);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_grad_vertical_init(lv_grad_dsc_t* dsc);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint32_t")]
        public static extern uint lv_layout_register([NativeTypeName("lv_layout_update_cb_t")] delegate* unmanaged[Cdecl]<lv_obj_t*, void*, void> cb, void* user_data);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_flex_init();

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_set_flex_flow(lv_obj_t* obj, lv_flex_flow_t flow);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_set_flex_align(lv_obj_t* obj, lv_flex_align_t main_place, lv_flex_align_t cross_place, lv_flex_align_t track_cross_place);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_set_flex_grow(lv_obj_t* obj, [NativeTypeName("uint8_t")] byte grow);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_grid_init();

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_set_grid_dsc_array(lv_obj_t* obj, [NativeTypeName("const int32_t[]")] int* col_dsc, [NativeTypeName("const int32_t[]")] int* row_dsc);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_set_grid_align(lv_obj_t* obj, lv_grid_align_t column_align, lv_grid_align_t row_align);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_set_grid_cell(lv_obj_t* obj, lv_grid_align_t column_align, [NativeTypeName("int32_t")] int col_pos, [NativeTypeName("int32_t")] int col_span, lv_grid_align_t row_align, [NativeTypeName("int32_t")] int row_pos, [NativeTypeName("int32_t")] int row_span);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("int32_t")]
        public static extern int lv_grid_fr([NativeTypeName("uint8_t")] byte x);

        public const int LV_STYLE_PROP_INV = 0;
        public const int LV_STYLE_WIDTH = 1;
        public const int LV_STYLE_HEIGHT = 2;
        public const int LV_STYLE_LENGTH = 3;
        public const int LV_STYLE_MIN_WIDTH = 4;
        public const int LV_STYLE_MAX_WIDTH = 5;
        public const int LV_STYLE_MIN_HEIGHT = 6;
        public const int LV_STYLE_MAX_HEIGHT = 7;
        public const int LV_STYLE_X = 8;
        public const int LV_STYLE_Y = 9;
        public const int LV_STYLE_ALIGN = 10;
        public const int LV_STYLE_RADIUS = 12;
        public const int LV_STYLE_RADIAL_OFFSET = 13;
        public const int LV_STYLE_PAD_RADIAL = 14;
        public const int LV_STYLE_PAD_TOP = 16;
        public const int LV_STYLE_PAD_BOTTOM = 17;
        public const int LV_STYLE_PAD_LEFT = 18;
        public const int LV_STYLE_PAD_RIGHT = 19;
        public const int LV_STYLE_PAD_ROW = 20;
        public const int LV_STYLE_PAD_COLUMN = 21;
        public const int LV_STYLE_LAYOUT = 22;
        public const int LV_STYLE_MARGIN_TOP = 24;
        public const int LV_STYLE_MARGIN_BOTTOM = 25;
        public const int LV_STYLE_MARGIN_LEFT = 26;
        public const int LV_STYLE_MARGIN_RIGHT = 27;
        public const int LV_STYLE_BG_COLOR = 28;
        public const int LV_STYLE_BG_OPA = 29;
        public const int LV_STYLE_BG_GRAD_DIR = 32;
        public const int LV_STYLE_BG_MAIN_STOP = 33;
        public const int LV_STYLE_BG_GRAD_STOP = 34;
        public const int LV_STYLE_BG_GRAD_COLOR = 35;
        public const int LV_STYLE_BG_MAIN_OPA = 36;
        public const int LV_STYLE_BG_GRAD_OPA = 37;
        public const int LV_STYLE_BG_GRAD = 38;
        public const int LV_STYLE_BASE_DIR = 39;
        public const int LV_STYLE_BG_IMAGE_SRC = 40;
        public const int LV_STYLE_BG_IMAGE_OPA = 41;
        public const int LV_STYLE_BG_IMAGE_RECOLOR = 42;
        public const int LV_STYLE_BG_IMAGE_RECOLOR_OPA = 43;
        public const int LV_STYLE_BG_IMAGE_TILED = 44;
        public const int LV_STYLE_CLIP_CORNER = 45;
        public const int LV_STYLE_BORDER_WIDTH = 48;
        public const int LV_STYLE_BORDER_COLOR = 49;
        public const int LV_STYLE_BORDER_OPA = 50;
        public const int LV_STYLE_BORDER_SIDE = 52;
        public const int LV_STYLE_BORDER_POST = 53;
        public const int LV_STYLE_OUTLINE_WIDTH = 56;
        public const int LV_STYLE_OUTLINE_COLOR = 57;
        public const int LV_STYLE_OUTLINE_OPA = 58;
        public const int LV_STYLE_OUTLINE_PAD = 59;
        public const int LV_STYLE_SHADOW_WIDTH = 60;
        public const int LV_STYLE_SHADOW_COLOR = 61;
        public const int LV_STYLE_SHADOW_OPA = 62;
        public const int LV_STYLE_SHADOW_OFFSET_X = 64;
        public const int LV_STYLE_SHADOW_OFFSET_Y = 65;
        public const int LV_STYLE_SHADOW_SPREAD = 66;
        public const int LV_STYLE_IMAGE_OPA = 68;
        public const int LV_STYLE_IMAGE_RECOLOR = 69;
        public const int LV_STYLE_IMAGE_RECOLOR_OPA = 70;
        public const int LV_STYLE_LINE_WIDTH = 72;
        public const int LV_STYLE_LINE_DASH_WIDTH = 73;
        public const int LV_STYLE_LINE_DASH_GAP = 74;
        public const int LV_STYLE_LINE_ROUNDED = 75;
        public const int LV_STYLE_LINE_COLOR = 76;
        public const int LV_STYLE_LINE_OPA = 77;
        public const int LV_STYLE_ARC_WIDTH = 80;
        public const int LV_STYLE_ARC_ROUNDED = 81;
        public const int LV_STYLE_ARC_COLOR = 82;
        public const int LV_STYLE_ARC_OPA = 83;
        public const int LV_STYLE_ARC_IMAGE_SRC = 84;
        public const int LV_STYLE_TEXT_COLOR = 88;
        public const int LV_STYLE_TEXT_OPA = 89;
        public const int LV_STYLE_TEXT_FONT = 90;
        public const int LV_STYLE_TEXT_LETTER_SPACE = 91;
        public const int LV_STYLE_TEXT_LINE_SPACE = 92;
        public const int LV_STYLE_TEXT_DECOR = 93;
        public const int LV_STYLE_TEXT_ALIGN = 94;
        public const int LV_STYLE_TEXT_OUTLINE_STROKE_WIDTH = 95;
        public const int LV_STYLE_TEXT_OUTLINE_STROKE_OPA = 96;
        public const int LV_STYLE_TEXT_OUTLINE_STROKE_COLOR = 97;
        public const int LV_STYLE_OPA = 98;
        public const int LV_STYLE_OPA_LAYERED = 99;
        public const int LV_STYLE_COLOR_FILTER_DSC = 100;
        public const int LV_STYLE_COLOR_FILTER_OPA = 101;
        public const int LV_STYLE_ANIM = 102;
        public const int LV_STYLE_ANIM_DURATION = 103;
        public const int LV_STYLE_TRANSITION = 104;
        public const int LV_STYLE_BLEND_MODE = 105;
        public const int LV_STYLE_TRANSFORM_WIDTH = 106;
        public const int LV_STYLE_TRANSFORM_HEIGHT = 107;
        public const int LV_STYLE_TRANSLATE_X = 108;
        public const int LV_STYLE_TRANSLATE_Y = 109;
        public const int LV_STYLE_TRANSFORM_SCALE_X = 110;
        public const int LV_STYLE_TRANSFORM_SCALE_Y = 111;
        public const int LV_STYLE_TRANSFORM_ROTATION = 112;
        public const int LV_STYLE_TRANSFORM_PIVOT_X = 113;
        public const int LV_STYLE_TRANSFORM_PIVOT_Y = 114;
        public const int LV_STYLE_TRANSFORM_SKEW_X = 115;
        public const int LV_STYLE_TRANSFORM_SKEW_Y = 116;
        public const int LV_STYLE_BITMAP_MASK_SRC = 117;
        public const int LV_STYLE_ROTARY_SENSITIVITY = 118;
        public const int LV_STYLE_TRANSLATE_RADIAL = 119;
        public const int LV_STYLE_RECOLOR = 120;
        public const int LV_STYLE_RECOLOR_OPA = 121;
        public const int LV_STYLE_FLEX_FLOW = 122;
        public const int LV_STYLE_FLEX_MAIN_PLACE = 123;
        public const int LV_STYLE_FLEX_CROSS_PLACE = 124;
        public const int LV_STYLE_FLEX_TRACK_PLACE = 125;
        public const int LV_STYLE_FLEX_GROW = 126;
        public const int LV_STYLE_GRID_COLUMN_ALIGN = 127;
        public const int LV_STYLE_GRID_ROW_ALIGN = 128;
        public const int LV_STYLE_GRID_ROW_DSC_ARRAY = 129;
        public const int LV_STYLE_GRID_COLUMN_DSC_ARRAY = 130;
        public const int LV_STYLE_GRID_CELL_COLUMN_POS = 131;
        public const int LV_STYLE_GRID_CELL_COLUMN_SPAN = 132;
        public const int LV_STYLE_GRID_CELL_X_ALIGN = 133;
        public const int LV_STYLE_GRID_CELL_ROW_POS = 134;
        public const int LV_STYLE_GRID_CELL_ROW_SPAN = 135;
        public const int LV_STYLE_GRID_CELL_Y_ALIGN = 136;
        public const int LV_STYLE_LAST_BUILT_IN_PROP = 137;
        public const int LV_STYLE_NUM_BUILT_IN_PROPS = LV_STYLE_LAST_BUILT_IN_PROP + 1;
        public const int LV_STYLE_PROP_ANY = 0xFF;
        public const int LV_STYLE_PROP_CONST = 0xFF;

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_style_init(lv_style_t* style);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_style_reset(lv_style_t* style);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_style_copy(lv_style_t* dst, [NativeTypeName("const lv_style_t *")] lv_style_t* src);

        [return: NativeTypeName("bool")]
        public static c_bool1 lv_style_is_const([NativeTypeName("const lv_style_t *")] lv_style_t* style)
        {
            if (style->prop_cnt == 255)
            {
                return true;
            }

            return false;
        }

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("lv_style_prop_t")]
        public static extern byte lv_style_register_prop([NativeTypeName("uint8_t")] byte flag);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("lv_style_prop_t")]
        public static extern byte lv_style_get_num_custom_props();

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern c_bool1 lv_style_remove_prop(lv_style_t* style, [NativeTypeName("lv_style_prop_t")] byte prop);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_style_set_prop(lv_style_t* style, [NativeTypeName("lv_style_prop_t")] byte prop, lv_style_value_t value);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_style_res_t lv_style_get_prop([NativeTypeName("const lv_style_t *")] lv_style_t* style, [NativeTypeName("lv_style_prop_t")] byte prop, lv_style_value_t* value);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_style_transition_dsc_init(lv_style_transition_dsc_t* tr, [NativeTypeName("const lv_style_prop_t[]")] byte* props, [NativeTypeName("lv_anim_path_cb_t")] delegate* unmanaged[Cdecl]<lv_anim_t*, int> path_cb, [NativeTypeName("uint32_t")] uint time, [NativeTypeName("uint32_t")] uint delay, void* user_data);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_style_value_t lv_style_prop_get_default([NativeTypeName("lv_style_prop_t")] byte prop);

        public static lv_style_res_t lv_style_get_prop_inlined([NativeTypeName("const lv_style_t *")] lv_style_t* style, [NativeTypeName("lv_style_prop_t")] byte prop, lv_style_value_t* value)
        {
            if (_ = lv_style_is_const(style))
            {
                lv_style_const_prop_t* props = (lv_style_const_prop_t*)(style->values_and_props);
                uint i;

                for (i = 0; unchecked(props[i]).prop != LV_STYLE_PROP_INV; i++)
                {
                    if (unchecked(props[i]).prop == prop)
                    {
                        *value = unchecked(props[i]).value;
                        return LV_STYLE_RES_FOUND;
                    }
                }
            }
            else
            {
                byte* props = (byte*)(style->values_and_props) + style->prop_cnt * sizeof(lv_style_value_t);
                uint i;

                for (i = 0; i < style->prop_cnt; i++)
                {
                    if (unchecked(props[i]) == prop)
                    {
                        lv_style_value_t* values = (lv_style_value_t*)(style->values_and_props);

                        *value = unchecked(values[i]);
                        return LV_STYLE_RES_FOUND;
                    }
                }
            }

            return LV_STYLE_RES_NOT_FOUND;
        }

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern c_bool1 lv_style_is_empty([NativeTypeName("const lv_style_t *")] lv_style_t* style);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint8_t")]
        public static extern byte lv_style_prop_lookup_flags([NativeTypeName("lv_style_prop_t")] byte prop);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_style_set_width(lv_style_t* style, [NativeTypeName("int32_t")] int value);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_style_set_min_width(lv_style_t* style, [NativeTypeName("int32_t")] int value);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_style_set_max_width(lv_style_t* style, [NativeTypeName("int32_t")] int value);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_style_set_height(lv_style_t* style, [NativeTypeName("int32_t")] int value);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_style_set_min_height(lv_style_t* style, [NativeTypeName("int32_t")] int value);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_style_set_max_height(lv_style_t* style, [NativeTypeName("int32_t")] int value);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_style_set_length(lv_style_t* style, [NativeTypeName("int32_t")] int value);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_style_set_x(lv_style_t* style, [NativeTypeName("int32_t")] int value);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_style_set_y(lv_style_t* style, [NativeTypeName("int32_t")] int value);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_style_set_align(lv_style_t* style, lv_align_t value);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_style_set_transform_width(lv_style_t* style, [NativeTypeName("int32_t")] int value);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_style_set_transform_height(lv_style_t* style, [NativeTypeName("int32_t")] int value);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_style_set_translate_x(lv_style_t* style, [NativeTypeName("int32_t")] int value);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_style_set_translate_y(lv_style_t* style, [NativeTypeName("int32_t")] int value);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_style_set_translate_radial(lv_style_t* style, [NativeTypeName("int32_t")] int value);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_style_set_transform_scale_x(lv_style_t* style, [NativeTypeName("int32_t")] int value);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_style_set_transform_scale_y(lv_style_t* style, [NativeTypeName("int32_t")] int value);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_style_set_transform_rotation(lv_style_t* style, [NativeTypeName("int32_t")] int value);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_style_set_transform_pivot_x(lv_style_t* style, [NativeTypeName("int32_t")] int value);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_style_set_transform_pivot_y(lv_style_t* style, [NativeTypeName("int32_t")] int value);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_style_set_transform_skew_x(lv_style_t* style, [NativeTypeName("int32_t")] int value);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_style_set_transform_skew_y(lv_style_t* style, [NativeTypeName("int32_t")] int value);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_style_set_pad_top(lv_style_t* style, [NativeTypeName("int32_t")] int value);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_style_set_pad_bottom(lv_style_t* style, [NativeTypeName("int32_t")] int value);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_style_set_pad_left(lv_style_t* style, [NativeTypeName("int32_t")] int value);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_style_set_pad_right(lv_style_t* style, [NativeTypeName("int32_t")] int value);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_style_set_pad_row(lv_style_t* style, [NativeTypeName("int32_t")] int value);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_style_set_pad_column(lv_style_t* style, [NativeTypeName("int32_t")] int value);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_style_set_pad_radial(lv_style_t* style, [NativeTypeName("int32_t")] int value);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_style_set_margin_top(lv_style_t* style, [NativeTypeName("int32_t")] int value);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_style_set_margin_bottom(lv_style_t* style, [NativeTypeName("int32_t")] int value);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_style_set_margin_left(lv_style_t* style, [NativeTypeName("int32_t")] int value);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_style_set_margin_right(lv_style_t* style, [NativeTypeName("int32_t")] int value);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_style_set_bg_color(lv_style_t* style, lv_color_t value);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_style_set_bg_opa(lv_style_t* style, [NativeTypeName("lv_opa_t")] byte value);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_style_set_bg_grad_color(lv_style_t* style, lv_color_t value);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_style_set_bg_grad_dir(lv_style_t* style, lv_grad_dir_t value);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_style_set_bg_main_stop(lv_style_t* style, [NativeTypeName("int32_t")] int value);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_style_set_bg_grad_stop(lv_style_t* style, [NativeTypeName("int32_t")] int value);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_style_set_bg_main_opa(lv_style_t* style, [NativeTypeName("lv_opa_t")] byte value);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_style_set_bg_grad_opa(lv_style_t* style, [NativeTypeName("lv_opa_t")] byte value);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_style_set_bg_grad(lv_style_t* style, [NativeTypeName("const lv_grad_dsc_t *")] lv_grad_dsc_t* value);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_style_set_bg_image_src(lv_style_t* style, [NativeTypeName("const void *")] void* value);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_style_set_bg_image_opa(lv_style_t* style, [NativeTypeName("lv_opa_t")] byte value);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_style_set_bg_image_recolor(lv_style_t* style, lv_color_t value);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_style_set_bg_image_recolor_opa(lv_style_t* style, [NativeTypeName("lv_opa_t")] byte value);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_style_set_bg_image_tiled(lv_style_t* style, [NativeTypeName("bool")] c_bool1 value);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_style_set_border_color(lv_style_t* style, lv_color_t value);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_style_set_border_opa(lv_style_t* style, [NativeTypeName("lv_opa_t")] byte value);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_style_set_border_width(lv_style_t* style, [NativeTypeName("int32_t")] int value);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_style_set_border_side(lv_style_t* style, lv_border_side_t value);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_style_set_border_post(lv_style_t* style, [NativeTypeName("bool")] c_bool1 value);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_style_set_outline_width(lv_style_t* style, [NativeTypeName("int32_t")] int value);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_style_set_outline_color(lv_style_t* style, lv_color_t value);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_style_set_outline_opa(lv_style_t* style, [NativeTypeName("lv_opa_t")] byte value);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_style_set_outline_pad(lv_style_t* style, [NativeTypeName("int32_t")] int value);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_style_set_shadow_width(lv_style_t* style, [NativeTypeName("int32_t")] int value);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_style_set_shadow_offset_x(lv_style_t* style, [NativeTypeName("int32_t")] int value);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_style_set_shadow_offset_y(lv_style_t* style, [NativeTypeName("int32_t")] int value);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_style_set_shadow_spread(lv_style_t* style, [NativeTypeName("int32_t")] int value);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_style_set_shadow_color(lv_style_t* style, lv_color_t value);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_style_set_shadow_opa(lv_style_t* style, [NativeTypeName("lv_opa_t")] byte value);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_style_set_image_opa(lv_style_t* style, [NativeTypeName("lv_opa_t")] byte value);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_style_set_image_recolor(lv_style_t* style, lv_color_t value);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_style_set_image_recolor_opa(lv_style_t* style, [NativeTypeName("lv_opa_t")] byte value);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_style_set_line_width(lv_style_t* style, [NativeTypeName("int32_t")] int value);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_style_set_line_dash_width(lv_style_t* style, [NativeTypeName("int32_t")] int value);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_style_set_line_dash_gap(lv_style_t* style, [NativeTypeName("int32_t")] int value);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_style_set_line_rounded(lv_style_t* style, [NativeTypeName("bool")] c_bool1 value);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_style_set_line_color(lv_style_t* style, lv_color_t value);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_style_set_line_opa(lv_style_t* style, [NativeTypeName("lv_opa_t")] byte value);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_style_set_arc_width(lv_style_t* style, [NativeTypeName("int32_t")] int value);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_style_set_arc_rounded(lv_style_t* style, [NativeTypeName("bool")] c_bool1 value);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_style_set_arc_color(lv_style_t* style, lv_color_t value);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_style_set_arc_opa(lv_style_t* style, [NativeTypeName("lv_opa_t")] byte value);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_style_set_arc_image_src(lv_style_t* style, [NativeTypeName("const void *")] void* value);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_style_set_text_color(lv_style_t* style, lv_color_t value);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_style_set_text_opa(lv_style_t* style, [NativeTypeName("lv_opa_t")] byte value);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_style_set_text_font(lv_style_t* style, [NativeTypeName("const lv_font_t *")] lv_font_t* value);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_style_set_text_letter_space(lv_style_t* style, [NativeTypeName("int32_t")] int value);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_style_set_text_line_space(lv_style_t* style, [NativeTypeName("int32_t")] int value);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_style_set_text_decor(lv_style_t* style, lv_text_decor_t value);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_style_set_text_align(lv_style_t* style, lv_text_align_t value);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_style_set_text_outline_stroke_color(lv_style_t* style, lv_color_t value);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_style_set_text_outline_stroke_width(lv_style_t* style, [NativeTypeName("int32_t")] int value);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_style_set_text_outline_stroke_opa(lv_style_t* style, [NativeTypeName("lv_opa_t")] byte value);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_style_set_radius(lv_style_t* style, [NativeTypeName("int32_t")] int value);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_style_set_radial_offset(lv_style_t* style, [NativeTypeName("int32_t")] int value);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_style_set_clip_corner(lv_style_t* style, [NativeTypeName("bool")] c_bool1 value);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_style_set_opa(lv_style_t* style, [NativeTypeName("lv_opa_t")] byte value);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_style_set_opa_layered(lv_style_t* style, [NativeTypeName("lv_opa_t")] byte value);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_style_set_color_filter_dsc(lv_style_t* style, [NativeTypeName("const lv_color_filter_dsc_t *")] lv_color_filter_dsc_t* value);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_style_set_color_filter_opa(lv_style_t* style, [NativeTypeName("lv_opa_t")] byte value);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_style_set_recolor(lv_style_t* style, lv_color_t value);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_style_set_recolor_opa(lv_style_t* style, [NativeTypeName("lv_opa_t")] byte value);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_style_set_anim(lv_style_t* style, [NativeTypeName("const lv_anim_t *")] lv_anim_t* value);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_style_set_anim_duration(lv_style_t* style, [NativeTypeName("uint32_t")] uint value);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_style_set_transition(lv_style_t* style, [NativeTypeName("const lv_style_transition_dsc_t *")] lv_style_transition_dsc_t* value);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_style_set_blend_mode(lv_style_t* style, lv_blend_mode_t value);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_style_set_layout(lv_style_t* style, [NativeTypeName("uint16_t")] ushort value);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_style_set_base_dir(lv_style_t* style, lv_base_dir_t value);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_style_set_bitmap_mask_src(lv_style_t* style, [NativeTypeName("const void *")] void* value);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_style_set_rotary_sensitivity(lv_style_t* style, [NativeTypeName("uint32_t")] uint value);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_style_set_flex_flow(lv_style_t* style, lv_flex_flow_t value);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_style_set_flex_main_place(lv_style_t* style, lv_flex_align_t value);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_style_set_flex_cross_place(lv_style_t* style, lv_flex_align_t value);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_style_set_flex_track_place(lv_style_t* style, lv_flex_align_t value);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_style_set_flex_grow(lv_style_t* style, [NativeTypeName("uint8_t")] byte value);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_style_set_grid_column_dsc_array(lv_style_t* style, [NativeTypeName("const int32_t *")] int* value);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_style_set_grid_column_align(lv_style_t* style, lv_grid_align_t value);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_style_set_grid_row_dsc_array(lv_style_t* style, [NativeTypeName("const int32_t *")] int* value);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_style_set_grid_row_align(lv_style_t* style, lv_grid_align_t value);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_style_set_grid_cell_column_pos(lv_style_t* style, [NativeTypeName("int32_t")] int value);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_style_set_grid_cell_x_align(lv_style_t* style, lv_grid_align_t value);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_style_set_grid_cell_column_span(lv_style_t* style, [NativeTypeName("int32_t")] int value);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_style_set_grid_cell_row_pos(lv_style_t* style, [NativeTypeName("int32_t")] int value);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_style_set_grid_cell_y_align(lv_style_t* style, lv_grid_align_t value);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_style_set_grid_cell_row_span(lv_style_t* style, [NativeTypeName("int32_t")] int value);

        public static void lv_style_set_size(lv_style_t* style, [NativeTypeName("int32_t")] int width, [NativeTypeName("int32_t")] int height)
        {
            lv_style_set_width(style, width);
            lv_style_set_height(style, height);
        }

        public static void lv_style_set_pad_all(lv_style_t* style, [NativeTypeName("int32_t")] int value)
        {
            lv_style_set_pad_left(style, value);
            lv_style_set_pad_right(style, value);
            lv_style_set_pad_top(style, value);
            lv_style_set_pad_bottom(style, value);
        }

        public static void lv_style_set_pad_hor(lv_style_t* style, [NativeTypeName("int32_t")] int value)
        {
            lv_style_set_pad_left(style, value);
            lv_style_set_pad_right(style, value);
        }

        public static void lv_style_set_pad_ver(lv_style_t* style, [NativeTypeName("int32_t")] int value)
        {
            lv_style_set_pad_top(style, value);
            lv_style_set_pad_bottom(style, value);
        }

        public static void lv_style_set_pad_gap(lv_style_t* style, [NativeTypeName("int32_t")] int value)
        {
            lv_style_set_pad_row(style, value);
            lv_style_set_pad_column(style, value);
        }

        public static void lv_style_set_margin_hor(lv_style_t* style, [NativeTypeName("int32_t")] int value)
        {
            lv_style_set_margin_left(style, value);
            lv_style_set_margin_right(style, value);
        }

        public static void lv_style_set_margin_ver(lv_style_t* style, [NativeTypeName("int32_t")] int value)
        {
            lv_style_set_margin_top(style, value);
            lv_style_set_margin_bottom(style, value);
        }

        public static void lv_style_set_margin_all(lv_style_t* style, [NativeTypeName("int32_t")] int value)
        {
            lv_style_set_margin_left(style, value);
            lv_style_set_margin_right(style, value);
            lv_style_set_margin_top(style, value);
            lv_style_set_margin_bottom(style, value);
        }

        public static void lv_style_set_transform_scale(lv_style_t* style, [NativeTypeName("int32_t")] int value)
        {
            lv_style_set_transform_scale_x(style, value);
            lv_style_set_transform_scale_y(style, value);
        }

        [return: NativeTypeName("bool")]
        public static c_bool1 lv_style_prop_has_flag([NativeTypeName("lv_style_prop_t")] byte prop, [NativeTypeName("uint8_t")] byte flag)
        {
            return (lv_style_prop_lookup_flags(prop) & flag) != 0;
        }

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_result_t lv_event_send(lv_event_list_t* list, lv_event_t* e, [NativeTypeName("bool")] c_bool1 preprocess);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_event_dsc_t* lv_event_add(lv_event_list_t* list, [NativeTypeName("lv_event_cb_t")] delegate* unmanaged[Cdecl]<lv_event_t*, void> cb, lv_event_code_t filter, void* user_data);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern c_bool1 lv_event_remove_dsc(lv_event_list_t* list, lv_event_dsc_t* dsc);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint32_t")]
        public static extern uint lv_event_get_count(lv_event_list_t* list);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_event_dsc_t* lv_event_get_dsc(lv_event_list_t* list, [NativeTypeName("uint32_t")] uint index);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("lv_event_cb_t")]
        public static extern delegate* unmanaged[Cdecl]<lv_event_t*, void> lv_event_dsc_get_cb(lv_event_dsc_t* dsc);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* lv_event_dsc_get_user_data(lv_event_dsc_t* dsc);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern c_bool1 lv_event_remove(lv_event_list_t* list, [NativeTypeName("uint32_t")] uint index);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_event_remove_all(lv_event_list_t* list);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* lv_event_get_target(lv_event_t* e);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* lv_event_get_current_target(lv_event_t* e);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_event_code_t lv_event_get_code(lv_event_t* e);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* lv_event_get_param(lv_event_t* e);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* lv_event_get_user_data(lv_event_t* e);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_event_stop_bubbling(lv_event_t* e);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_event_stop_processing(lv_event_t* e);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint32_t")]
        public static extern uint lv_event_register_id();

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern byte[] lv_event_code_get_name(lv_event_code_t code);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_display_t* lv_display_create([NativeTypeName("int32_t")] int hor_res, [NativeTypeName("int32_t")] int ver_res);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_display_delete(lv_display_t* disp);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_display_set_default(lv_display_t* disp);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_display_t* lv_display_get_default();

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_display_t* lv_display_get_next(lv_display_t* disp);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_display_set_resolution(lv_display_t* disp, [NativeTypeName("int32_t")] int hor_res, [NativeTypeName("int32_t")] int ver_res);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_display_set_physical_resolution(lv_display_t* disp, [NativeTypeName("int32_t")] int hor_res, [NativeTypeName("int32_t")] int ver_res);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_display_set_offset(lv_display_t* disp, [NativeTypeName("int32_t")] int x, [NativeTypeName("int32_t")] int y);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_display_set_rotation(lv_display_t* disp, lv_display_rotation_t rotation);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_display_set_matrix_rotation(lv_display_t* disp, [NativeTypeName("bool")] c_bool1 enable);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_display_set_dpi(lv_display_t* disp, [NativeTypeName("int32_t")] int dpi);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("int32_t")]
        public static extern int lv_display_get_horizontal_resolution([NativeTypeName("const lv_display_t *")] lv_display_t* disp);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("int32_t")]
        public static extern int lv_display_get_vertical_resolution([NativeTypeName("const lv_display_t *")] lv_display_t* disp);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("int32_t")]
        public static extern int lv_display_get_original_horizontal_resolution([NativeTypeName("const lv_display_t *")] lv_display_t* disp);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("int32_t")]
        public static extern int lv_display_get_original_vertical_resolution([NativeTypeName("const lv_display_t *")] lv_display_t* disp);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("int32_t")]
        public static extern int lv_display_get_physical_horizontal_resolution([NativeTypeName("const lv_display_t *")] lv_display_t* disp);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("int32_t")]
        public static extern int lv_display_get_physical_vertical_resolution([NativeTypeName("const lv_display_t *")] lv_display_t* disp);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("int32_t")]
        public static extern int lv_display_get_offset_x([NativeTypeName("const lv_display_t *")] lv_display_t* disp);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("int32_t")]
        public static extern int lv_display_get_offset_y([NativeTypeName("const lv_display_t *")] lv_display_t* disp);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_display_rotation_t lv_display_get_rotation(lv_display_t* disp);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern c_bool1 lv_display_get_matrix_rotation(lv_display_t* disp);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("int32_t")]
        public static extern int lv_display_get_dpi([NativeTypeName("const lv_display_t *")] lv_display_t* disp);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_display_set_buffers(lv_display_t* disp, void* buf1, void* buf2, [NativeTypeName("uint32_t")] uint buf_size, lv_display_render_mode_t render_mode);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_display_set_buffers_with_stride(lv_display_t* disp, void* buf1, void* buf2, [NativeTypeName("uint32_t")] uint buf_size, [NativeTypeName("uint32_t")] uint stride, lv_display_render_mode_t render_mode);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_display_set_draw_buffers(lv_display_t* disp, lv_draw_buf_t* buf1, lv_draw_buf_t* buf2);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_display_set_3rd_draw_buffer(lv_display_t* disp, lv_draw_buf_t* buf3);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_display_set_render_mode(lv_display_t* disp, lv_display_render_mode_t render_mode);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_display_set_flush_cb(lv_display_t* disp, [NativeTypeName("lv_display_flush_cb_t")] delegate* unmanaged[Cdecl]<lv_display_t*, lv_area_t*, byte*, void> flush_cb);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_display_set_flush_wait_cb(lv_display_t* disp, [NativeTypeName("lv_display_flush_wait_cb_t")] delegate* unmanaged[Cdecl]<lv_display_t*, void> wait_cb);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_display_set_color_format(lv_display_t* disp, lv_color_format_t color_format);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_color_format_t lv_display_get_color_format(lv_display_t* disp);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_display_set_tile_cnt(lv_display_t* disp, [NativeTypeName("uint32_t")] uint tile_cnt);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint32_t")]
        public static extern uint lv_display_get_tile_cnt(lv_display_t* disp);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_display_set_antialiasing(lv_display_t* disp, [NativeTypeName("bool")] c_bool1 en);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern c_bool1 lv_display_get_antialiasing(lv_display_t* disp);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_display_flush_ready(lv_display_t* disp);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern c_bool1 lv_display_flush_is_last(lv_display_t* disp);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern c_bool1 lv_display_is_double_buffered(lv_display_t* disp);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_obj_t* lv_display_get_screen_active(lv_display_t* disp);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_obj_t* lv_display_get_screen_prev(lv_display_t* disp);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_obj_t* lv_display_get_layer_top(lv_display_t* disp);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_obj_t* lv_display_get_layer_sys(lv_display_t* disp);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_obj_t* lv_display_get_layer_bottom(lv_display_t* disp);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_screen_load([NativeTypeName("struct _lv_obj_t *")] lv_obj_t* scr);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_screen_load_anim(lv_obj_t* scr, lv_screen_load_anim_t anim_type, [NativeTypeName("uint32_t")] uint time, [NativeTypeName("uint32_t")] uint delay, [NativeTypeName("bool")] c_bool1 auto_del);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_obj_t* lv_screen_active();

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_obj_t* lv_layer_top();

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_obj_t* lv_layer_sys();

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_obj_t* lv_layer_bottom();

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_display_add_event_cb(lv_display_t* disp, [NativeTypeName("lv_event_cb_t")] delegate* unmanaged[Cdecl]<lv_event_t*, void> event_cb, lv_event_code_t filter, void* user_data);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint32_t")]
        public static extern uint lv_display_get_event_count(lv_display_t* disp);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_event_dsc_t* lv_display_get_event_dsc(lv_display_t* disp, [NativeTypeName("uint32_t")] uint index);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern c_bool1 lv_display_delete_event(lv_display_t* disp, [NativeTypeName("uint32_t")] uint index);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint32_t")]
        public static extern uint lv_display_remove_event_cb_with_user_data(lv_display_t* disp, [NativeTypeName("lv_event_cb_t")] delegate* unmanaged[Cdecl]<lv_event_t*, void> event_cb, void* user_data);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_result_t lv_display_send_event(lv_display_t* disp, lv_event_code_t code, void* param2);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_area_t* lv_event_get_invalidated_area(lv_event_t* e);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_display_set_theme(lv_display_t* disp, lv_theme_t* th);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_theme_t* lv_display_get_theme(lv_display_t* disp);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint32_t")]
        public static extern uint lv_display_get_inactive_time([NativeTypeName("const lv_display_t *")] lv_display_t* disp);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_display_trigger_activity(lv_display_t* disp);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_display_enable_invalidation(lv_display_t* disp, [NativeTypeName("bool")] c_bool1 en);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern c_bool1 lv_display_is_invalidation_enabled(lv_display_t* disp);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_timer_t* lv_display_get_refr_timer(lv_display_t* disp);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_display_delete_refr_timer(lv_display_t* disp);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern c_bool1 lv_display_register_vsync_event(lv_display_t* disp, [NativeTypeName("lv_event_cb_t")] delegate* unmanaged[Cdecl]<lv_event_t*, void> event_cb, void* user_data);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern c_bool1 lv_display_unregister_vsync_event(lv_display_t* disp, [NativeTypeName("lv_event_cb_t")] delegate* unmanaged[Cdecl]<lv_event_t*, void> event_cb, void* user_data);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_result_t lv_display_send_vsync_event(lv_display_t* disp, void* param1);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_display_set_user_data(lv_display_t* disp, void* user_data);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_display_set_driver_data(lv_display_t* disp, void* driver_data);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* lv_display_get_user_data(lv_display_t* disp);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* lv_display_get_driver_data(lv_display_t* disp);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_draw_buf_t* lv_display_get_buf_active(lv_display_t* disp);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_display_rotate_area(lv_display_t* disp, lv_area_t* area);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint32_t")]
        public static extern uint lv_display_get_draw_buf_size(lv_display_t* disp);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint32_t")]
        public static extern uint lv_display_get_invalidated_draw_buf_size(lv_display_t* disp, [NativeTypeName("uint32_t")] uint width, [NativeTypeName("uint32_t")] uint height);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("int32_t")]
        public static extern int lv_dpx([NativeTypeName("int32_t")] int n);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("int32_t")]
        public static extern int lv_display_dpx([NativeTypeName("const lv_display_t *")] lv_display_t* disp, [NativeTypeName("int32_t")] int n);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_delete(lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_clean(lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_delete_delayed(lv_obj_t* obj, [NativeTypeName("uint32_t")] uint delay_ms);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_delete_anim_completed_cb(lv_anim_t* a);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_delete_async(lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_set_parent(lv_obj_t* obj, lv_obj_t* parent);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_swap(lv_obj_t* obj1, lv_obj_t* obj2);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_move_to_index(lv_obj_t* obj, [NativeTypeName("int32_t")] int index);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_obj_t* lv_obj_get_screen([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_display_t* lv_obj_get_display([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_obj_t* lv_obj_get_parent([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_obj_t* lv_obj_get_child([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("int32_t")] int idx);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_obj_t* lv_obj_get_child_by_type([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("int32_t")] int idx, [NativeTypeName("const lv_obj_class_t *")] lv_obj_class_t* class_p);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_obj_t* lv_obj_get_sibling([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("int32_t")] int idx);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_obj_t* lv_obj_get_sibling_by_type([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("int32_t")] int idx, [NativeTypeName("const lv_obj_class_t *")] lv_obj_class_t* class_p);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint32_t")]
        public static extern uint lv_obj_get_child_count([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint32_t")]
        public static extern uint lv_obj_get_child_count_by_type([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("const lv_obj_class_t *")] lv_obj_class_t* class_p);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("int32_t")]
        public static extern int lv_obj_get_index([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("int32_t")]
        public static extern int lv_obj_get_index_by_type([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("const lv_obj_class_t *")] lv_obj_class_t* class_p);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_tree_walk(lv_obj_t* start_obj, [NativeTypeName("lv_obj_tree_walk_cb_t")] delegate* unmanaged[Cdecl]<lv_obj_t*, void*, lv_obj_tree_walk_res_t> cb, void* user_data);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_dump_tree(lv_obj_t* start_obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_set_pos(lv_obj_t* obj, [NativeTypeName("int32_t")] int x, [NativeTypeName("int32_t")] int y);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_set_x(lv_obj_t* obj, [NativeTypeName("int32_t")] int x);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_set_y(lv_obj_t* obj, [NativeTypeName("int32_t")] int y);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_set_size(lv_obj_t* obj, [NativeTypeName("int32_t")] int w, [NativeTypeName("int32_t")] int h);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern c_bool1 lv_obj_refr_size(lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_set_width(lv_obj_t* obj, [NativeTypeName("int32_t")] int w);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_set_height(lv_obj_t* obj, [NativeTypeName("int32_t")] int h);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_set_content_width(lv_obj_t* obj, [NativeTypeName("int32_t")] int w);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_set_content_height(lv_obj_t* obj, [NativeTypeName("int32_t")] int h);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_set_layout(lv_obj_t* obj, [NativeTypeName("uint32_t")] uint layout);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern c_bool1 lv_obj_is_layout_positioned([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_mark_layout_as_dirty(lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_update_layout([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_set_align(lv_obj_t* obj, lv_align_t align);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_align(lv_obj_t* obj, lv_align_t align, [NativeTypeName("int32_t")] int x_ofs, [NativeTypeName("int32_t")] int y_ofs);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_align_to(lv_obj_t* obj, [NativeTypeName("const lv_obj_t *")] lv_obj_t* @base, lv_align_t align, [NativeTypeName("int32_t")] int x_ofs, [NativeTypeName("int32_t")] int y_ofs);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_center(lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_set_transform(lv_obj_t* obj, [NativeTypeName("const lv_matrix_t *")] lv_matrix_t* matrix);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_reset_transform(lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_get_coords([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, lv_area_t* coords);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("int32_t")]
        public static extern int lv_obj_get_x([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("int32_t")]
        public static extern int lv_obj_get_x2([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("int32_t")]
        public static extern int lv_obj_get_y([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("int32_t")]
        public static extern int lv_obj_get_y2([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("int32_t")]
        public static extern int lv_obj_get_x_aligned([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("int32_t")]
        public static extern int lv_obj_get_y_aligned([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("int32_t")]
        public static extern int lv_obj_get_width([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("int32_t")]
        public static extern int lv_obj_get_height([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("int32_t")]
        public static extern int lv_obj_get_content_width([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("int32_t")]
        public static extern int lv_obj_get_content_height([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_get_content_coords([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, lv_area_t* area);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("int32_t")]
        public static extern int lv_obj_get_self_width([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("int32_t")]
        public static extern int lv_obj_get_self_height([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern c_bool1 lv_obj_refresh_self_size(lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_refr_pos(lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_move_to(lv_obj_t* obj, [NativeTypeName("int32_t")] int x, [NativeTypeName("int32_t")] int y);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_move_children_by(lv_obj_t* obj, [NativeTypeName("int32_t")] int x_diff, [NativeTypeName("int32_t")] int y_diff, [NativeTypeName("bool")] c_bool1 ignore_floating);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const lv_matrix_t *")]
        public static extern lv_matrix_t* lv_obj_get_transform([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_transform_point([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, lv_point_t* p, lv_obj_point_transform_flag_t flags);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_transform_point_array([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("lv_point_t[]")] lv_point_t* points, [NativeTypeName("size_t")] nuint count, lv_obj_point_transform_flag_t flags);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_get_transformed_area([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, lv_area_t* area, lv_obj_point_transform_flag_t flags);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_invalidate_area([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("const lv_area_t *")] lv_area_t* area);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_invalidate([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern c_bool1 lv_obj_area_is_visible([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, lv_area_t* area);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern c_bool1 lv_obj_is_visible([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_set_ext_click_area(lv_obj_t* obj, [NativeTypeName("int32_t")] int size);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_get_click_area([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, lv_area_t* area);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern c_bool1 lv_obj_hit_test(lv_obj_t* obj, [NativeTypeName("const lv_point_t *")] lv_point_t* point);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("int32_t")]
        public static extern int lv_clamp_width([NativeTypeName("int32_t")] int width, [NativeTypeName("int32_t")] int min_width, [NativeTypeName("int32_t")] int max_width, [NativeTypeName("int32_t")] int ref_width);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("int32_t")]
        public static extern int lv_clamp_height([NativeTypeName("int32_t")] int height, [NativeTypeName("int32_t")] int min_height, [NativeTypeName("int32_t")] int max_height, [NativeTypeName("int32_t")] int ref_height);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_set_scrollbar_mode(lv_obj_t* obj, lv_scrollbar_mode_t mode);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_set_scroll_dir(lv_obj_t* obj, lv_dir_t dir);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_set_scroll_snap_x(lv_obj_t* obj, lv_scroll_snap_t align);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_set_scroll_snap_y(lv_obj_t* obj, lv_scroll_snap_t align);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_scrollbar_mode_t lv_obj_get_scrollbar_mode([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_dir_t lv_obj_get_scroll_dir([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_scroll_snap_t lv_obj_get_scroll_snap_x([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_scroll_snap_t lv_obj_get_scroll_snap_y([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("int32_t")]
        public static extern int lv_obj_get_scroll_x([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("int32_t")]
        public static extern int lv_obj_get_scroll_y([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("int32_t")]
        public static extern int lv_obj_get_scroll_top([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("int32_t")]
        public static extern int lv_obj_get_scroll_bottom([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("int32_t")]
        public static extern int lv_obj_get_scroll_left([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("int32_t")]
        public static extern int lv_obj_get_scroll_right([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_get_scroll_end(lv_obj_t* obj, lv_point_t* end);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_scroll_by(lv_obj_t* obj, [NativeTypeName("int32_t")] int dx, [NativeTypeName("int32_t")] int dy, [NativeTypeName("lv_anim_enable_t")] c_bool1 anim_en);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_scroll_by_bounded(lv_obj_t* obj, [NativeTypeName("int32_t")] int dx, [NativeTypeName("int32_t")] int dy, [NativeTypeName("lv_anim_enable_t")] c_bool1 anim_en);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_scroll_to(lv_obj_t* obj, [NativeTypeName("int32_t")] int x, [NativeTypeName("int32_t")] int y, [NativeTypeName("lv_anim_enable_t")] c_bool1 anim_en);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_scroll_to_x(lv_obj_t* obj, [NativeTypeName("int32_t")] int x, [NativeTypeName("lv_anim_enable_t")] c_bool1 anim_en);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_scroll_to_y(lv_obj_t* obj, [NativeTypeName("int32_t")] int y, [NativeTypeName("lv_anim_enable_t")] c_bool1 anim_en);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_scroll_to_view(lv_obj_t* obj, [NativeTypeName("lv_anim_enable_t")] c_bool1 anim_en);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_scroll_to_view_recursive(lv_obj_t* obj, [NativeTypeName("lv_anim_enable_t")] c_bool1 anim_en);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern c_bool1 lv_obj_is_scrolling([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_stop_scroll_anim([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_update_snap(lv_obj_t* obj, [NativeTypeName("lv_anim_enable_t")] c_bool1 anim_en);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_get_scrollbar_area(lv_obj_t* obj, lv_area_t* hor, lv_area_t* ver);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_scrollbar_invalidate(lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_readjust_scroll(lv_obj_t* obj, [NativeTypeName("lv_anim_enable_t")] c_bool1 anim_en);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_add_style(lv_obj_t* obj, [NativeTypeName("const lv_style_t *")] lv_style_t* style, [NativeTypeName("lv_style_selector_t")] uint selector);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern c_bool1 lv_obj_replace_style(lv_obj_t* obj, [NativeTypeName("const lv_style_t *")] lv_style_t* old_style, [NativeTypeName("const lv_style_t *")] lv_style_t* new_style, [NativeTypeName("lv_style_selector_t")] uint selector);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_remove_style(lv_obj_t* obj, [NativeTypeName("const lv_style_t *")] lv_style_t* style, [NativeTypeName("lv_style_selector_t")] uint selector);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_remove_style_all(lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_report_style_change(lv_style_t* style);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_refresh_style(lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part, [NativeTypeName("lv_style_prop_t")] byte prop);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_enable_style_refresh([NativeTypeName("bool")] c_bool1 en);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_style_value_t lv_obj_get_style_prop([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part, [NativeTypeName("lv_style_prop_t")] byte prop);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern c_bool1 lv_obj_has_style_prop([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("lv_style_selector_t")] uint selector, [NativeTypeName("lv_style_prop_t")] byte prop);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_set_local_style_prop(lv_obj_t* obj, [NativeTypeName("lv_style_prop_t")] byte prop, lv_style_value_t value, [NativeTypeName("lv_style_selector_t")] uint selector);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_style_res_t lv_obj_get_local_style_prop(lv_obj_t* obj, [NativeTypeName("lv_style_prop_t")] byte prop, lv_style_value_t* value, [NativeTypeName("lv_style_selector_t")] uint selector);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern c_bool1 lv_obj_remove_local_style_prop(lv_obj_t* obj, [NativeTypeName("lv_style_prop_t")] byte prop, [NativeTypeName("lv_style_selector_t")] uint selector);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_style_value_t lv_obj_style_apply_color_filter([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part, lv_style_value_t v);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_fade_in(lv_obj_t* obj, [NativeTypeName("uint32_t")] uint time, [NativeTypeName("uint32_t")] uint delay);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_fade_out(lv_obj_t* obj, [NativeTypeName("uint32_t")] uint time, [NativeTypeName("uint32_t")] uint delay);

        [return: NativeTypeName("lv_part_t")]
        public static uint lv_obj_style_get_selector_part([NativeTypeName("lv_style_selector_t")] uint selector)
        {
            return selector & 0xFF0000;
        }

        [return: NativeTypeName("int32_t")]
        public static int lv_obj_get_style_width([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part)
        {
            lv_style_value_t v = lv_obj_get_style_prop(obj, part, (byte)(LV_STYLE_WIDTH));

            return (int)(v.num);
        }

        [return: NativeTypeName("int32_t")]
        public static int lv_obj_get_style_min_width([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part)
        {
            lv_style_value_t v = lv_obj_get_style_prop(obj, part, (byte)(LV_STYLE_MIN_WIDTH));

            return (int)(v.num);
        }

        [return: NativeTypeName("int32_t")]
        public static int lv_obj_get_style_max_width([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part)
        {
            lv_style_value_t v = lv_obj_get_style_prop(obj, part, (byte)(LV_STYLE_MAX_WIDTH));

            return (int)(v.num);
        }

        [return: NativeTypeName("int32_t")]
        public static int lv_obj_get_style_height([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part)
        {
            lv_style_value_t v = lv_obj_get_style_prop(obj, part, (byte)(LV_STYLE_HEIGHT));

            return (int)(v.num);
        }

        [return: NativeTypeName("int32_t")]
        public static int lv_obj_get_style_min_height([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part)
        {
            lv_style_value_t v = lv_obj_get_style_prop(obj, part, (byte)(LV_STYLE_MIN_HEIGHT));

            return (int)(v.num);
        }

        [return: NativeTypeName("int32_t")]
        public static int lv_obj_get_style_max_height([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part)
        {
            lv_style_value_t v = lv_obj_get_style_prop(obj, part, (byte)(LV_STYLE_MAX_HEIGHT));

            return (int)(v.num);
        }

        [return: NativeTypeName("int32_t")]
        public static int lv_obj_get_style_length([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part)
        {
            lv_style_value_t v = lv_obj_get_style_prop(obj, part, (byte)(LV_STYLE_LENGTH));

            return (int)(v.num);
        }

        [return: NativeTypeName("int32_t")]
        public static int lv_obj_get_style_x([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part)
        {
            lv_style_value_t v = lv_obj_get_style_prop(obj, part, (byte)(LV_STYLE_X));

            return (int)(v.num);
        }

        [return: NativeTypeName("int32_t")]
        public static int lv_obj_get_style_y([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part)
        {
            lv_style_value_t v = lv_obj_get_style_prop(obj, part, (byte)(LV_STYLE_Y));

            return (int)(v.num);
        }

        public static lv_align_t lv_obj_get_style_align([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part)
        {
            lv_style_value_t v = lv_obj_get_style_prop(obj, part, (byte)(LV_STYLE_ALIGN));

            return (lv_align_t)(v.num);
        }

        [return: NativeTypeName("int32_t")]
        public static int lv_obj_get_style_transform_width([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part)
        {
            lv_style_value_t v = lv_obj_get_style_prop(obj, part, (byte)(LV_STYLE_TRANSFORM_WIDTH));

            return (int)(v.num);
        }

        [return: NativeTypeName("int32_t")]
        public static int lv_obj_get_style_transform_height([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part)
        {
            lv_style_value_t v = lv_obj_get_style_prop(obj, part, (byte)(LV_STYLE_TRANSFORM_HEIGHT));

            return (int)(v.num);
        }

        [return: NativeTypeName("int32_t")]
        public static int lv_obj_get_style_translate_x([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part)
        {
            lv_style_value_t v = lv_obj_get_style_prop(obj, part, (byte)(LV_STYLE_TRANSLATE_X));

            return (int)(v.num);
        }

        [return: NativeTypeName("int32_t")]
        public static int lv_obj_get_style_translate_y([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part)
        {
            lv_style_value_t v = lv_obj_get_style_prop(obj, part, (byte)(LV_STYLE_TRANSLATE_Y));

            return (int)(v.num);
        }

        [return: NativeTypeName("int32_t")]
        public static int lv_obj_get_style_translate_radial([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part)
        {
            lv_style_value_t v = lv_obj_get_style_prop(obj, part, (byte)(LV_STYLE_TRANSLATE_RADIAL));

            return (int)(v.num);
        }

        [return: NativeTypeName("int32_t")]
        public static int lv_obj_get_style_transform_scale_x([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part)
        {
            lv_style_value_t v = lv_obj_get_style_prop(obj, part, (byte)(LV_STYLE_TRANSFORM_SCALE_X));

            return (int)(v.num);
        }

        [return: NativeTypeName("int32_t")]
        public static int lv_obj_get_style_transform_scale_y([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part)
        {
            lv_style_value_t v = lv_obj_get_style_prop(obj, part, (byte)(LV_STYLE_TRANSFORM_SCALE_Y));

            return (int)(v.num);
        }

        [return: NativeTypeName("int32_t")]
        public static int lv_obj_get_style_transform_rotation([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part)
        {
            lv_style_value_t v = lv_obj_get_style_prop(obj, part, (byte)(LV_STYLE_TRANSFORM_ROTATION));

            return (int)(v.num);
        }

        [return: NativeTypeName("int32_t")]
        public static int lv_obj_get_style_transform_pivot_x([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part)
        {
            lv_style_value_t v = lv_obj_get_style_prop(obj, part, (byte)(LV_STYLE_TRANSFORM_PIVOT_X));

            return (int)(v.num);
        }

        [return: NativeTypeName("int32_t")]
        public static int lv_obj_get_style_transform_pivot_y([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part)
        {
            lv_style_value_t v = lv_obj_get_style_prop(obj, part, (byte)(LV_STYLE_TRANSFORM_PIVOT_Y));

            return (int)(v.num);
        }

        [return: NativeTypeName("int32_t")]
        public static int lv_obj_get_style_transform_skew_x([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part)
        {
            lv_style_value_t v = lv_obj_get_style_prop(obj, part, (byte)(LV_STYLE_TRANSFORM_SKEW_X));

            return (int)(v.num);
        }

        [return: NativeTypeName("int32_t")]
        public static int lv_obj_get_style_transform_skew_y([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part)
        {
            lv_style_value_t v = lv_obj_get_style_prop(obj, part, (byte)(LV_STYLE_TRANSFORM_SKEW_Y));

            return (int)(v.num);
        }

        [return: NativeTypeName("int32_t")]
        public static int lv_obj_get_style_pad_top([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part)
        {
            lv_style_value_t v = lv_obj_get_style_prop(obj, part, (byte)(LV_STYLE_PAD_TOP));

            return (int)(v.num);
        }

        [return: NativeTypeName("int32_t")]
        public static int lv_obj_get_style_pad_bottom([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part)
        {
            lv_style_value_t v = lv_obj_get_style_prop(obj, part, (byte)(LV_STYLE_PAD_BOTTOM));

            return (int)(v.num);
        }

        [return: NativeTypeName("int32_t")]
        public static int lv_obj_get_style_pad_left([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part)
        {
            lv_style_value_t v = lv_obj_get_style_prop(obj, part, (byte)(LV_STYLE_PAD_LEFT));

            return (int)(v.num);
        }

        [return: NativeTypeName("int32_t")]
        public static int lv_obj_get_style_pad_right([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part)
        {
            lv_style_value_t v = lv_obj_get_style_prop(obj, part, (byte)(LV_STYLE_PAD_RIGHT));

            return (int)(v.num);
        }

        [return: NativeTypeName("int32_t")]
        public static int lv_obj_get_style_pad_row([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part)
        {
            lv_style_value_t v = lv_obj_get_style_prop(obj, part, (byte)(LV_STYLE_PAD_ROW));

            return (int)(v.num);
        }

        [return: NativeTypeName("int32_t")]
        public static int lv_obj_get_style_pad_column([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part)
        {
            lv_style_value_t v = lv_obj_get_style_prop(obj, part, (byte)(LV_STYLE_PAD_COLUMN));

            return (int)(v.num);
        }

        [return: NativeTypeName("int32_t")]
        public static int lv_obj_get_style_pad_radial([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part)
        {
            lv_style_value_t v = lv_obj_get_style_prop(obj, part, (byte)(LV_STYLE_PAD_RADIAL));

            return (int)(v.num);
        }

        [return: NativeTypeName("int32_t")]
        public static int lv_obj_get_style_margin_top([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part)
        {
            lv_style_value_t v = lv_obj_get_style_prop(obj, part, (byte)(LV_STYLE_MARGIN_TOP));

            return (int)(v.num);
        }

        [return: NativeTypeName("int32_t")]
        public static int lv_obj_get_style_margin_bottom([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part)
        {
            lv_style_value_t v = lv_obj_get_style_prop(obj, part, (byte)(LV_STYLE_MARGIN_BOTTOM));

            return (int)(v.num);
        }

        [return: NativeTypeName("int32_t")]
        public static int lv_obj_get_style_margin_left([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part)
        {
            lv_style_value_t v = lv_obj_get_style_prop(obj, part, (byte)(LV_STYLE_MARGIN_LEFT));

            return (int)(v.num);
        }

        [return: NativeTypeName("int32_t")]
        public static int lv_obj_get_style_margin_right([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part)
        {
            lv_style_value_t v = lv_obj_get_style_prop(obj, part, (byte)(LV_STYLE_MARGIN_RIGHT));

            return (int)(v.num);
        }

        public static lv_color_t lv_obj_get_style_bg_color([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part)
        {
            lv_style_value_t v = lv_obj_get_style_prop(obj, part, (byte)(LV_STYLE_BG_COLOR));

            return v.color;
        }

        public static lv_color_t lv_obj_get_style_bg_color_filtered([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part)
        {
            lv_style_value_t v = lv_obj_style_apply_color_filter(obj, part, lv_obj_get_style_prop(obj, part, (byte)(LV_STYLE_BG_COLOR)));

            return v.color;
        }

        [return: NativeTypeName("lv_opa_t")]
        public static byte lv_obj_get_style_bg_opa([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part)
        {
            lv_style_value_t v = lv_obj_get_style_prop(obj, part, (byte)(LV_STYLE_BG_OPA));

            return (byte)(v.num);
        }

        public static lv_color_t lv_obj_get_style_bg_grad_color([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part)
        {
            lv_style_value_t v = lv_obj_get_style_prop(obj, part, (byte)(LV_STYLE_BG_GRAD_COLOR));

            return v.color;
        }

        public static lv_color_t lv_obj_get_style_bg_grad_color_filtered([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part)
        {
            lv_style_value_t v = lv_obj_style_apply_color_filter(obj, part, lv_obj_get_style_prop(obj, part, (byte)(LV_STYLE_BG_GRAD_COLOR)));

            return v.color;
        }

        public static lv_grad_dir_t lv_obj_get_style_bg_grad_dir([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part)
        {
            lv_style_value_t v = lv_obj_get_style_prop(obj, part, (byte)(LV_STYLE_BG_GRAD_DIR));

            return (lv_grad_dir_t)(v.num);
        }

        [return: NativeTypeName("int32_t")]
        public static int lv_obj_get_style_bg_main_stop([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part)
        {
            lv_style_value_t v = lv_obj_get_style_prop(obj, part, (byte)(LV_STYLE_BG_MAIN_STOP));

            return (int)(v.num);
        }

        [return: NativeTypeName("int32_t")]
        public static int lv_obj_get_style_bg_grad_stop([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part)
        {
            lv_style_value_t v = lv_obj_get_style_prop(obj, part, (byte)(LV_STYLE_BG_GRAD_STOP));

            return (int)(v.num);
        }

        [return: NativeTypeName("lv_opa_t")]
        public static byte lv_obj_get_style_bg_main_opa([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part)
        {
            lv_style_value_t v = lv_obj_get_style_prop(obj, part, (byte)(LV_STYLE_BG_MAIN_OPA));

            return (byte)(v.num);
        }

        [return: NativeTypeName("lv_opa_t")]
        public static byte lv_obj_get_style_bg_grad_opa([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part)
        {
            lv_style_value_t v = lv_obj_get_style_prop(obj, part, (byte)(LV_STYLE_BG_GRAD_OPA));

            return (byte)(v.num);
        }

        [return: NativeTypeName("const lv_grad_dsc_t *")]
        public static lv_grad_dsc_t* lv_obj_get_style_bg_grad([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part)
        {
            lv_style_value_t v = lv_obj_get_style_prop(obj, part, (byte)(LV_STYLE_BG_GRAD));

            return (lv_grad_dsc_t*)(v.ptr);
        }

        [return: NativeTypeName("const void *")]
        public static void* lv_obj_get_style_bg_image_src([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part)
        {
            lv_style_value_t v = lv_obj_get_style_prop(obj, part, (byte)(LV_STYLE_BG_IMAGE_SRC));

            return (void*)(v.ptr);
        }

        [return: NativeTypeName("lv_opa_t")]
        public static byte lv_obj_get_style_bg_image_opa([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part)
        {
            lv_style_value_t v = lv_obj_get_style_prop(obj, part, (byte)(LV_STYLE_BG_IMAGE_OPA));

            return (byte)(v.num);
        }

        public static lv_color_t lv_obj_get_style_bg_image_recolor([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part)
        {
            lv_style_value_t v = lv_obj_get_style_prop(obj, part, (byte)(LV_STYLE_BG_IMAGE_RECOLOR));

            return v.color;
        }

        public static lv_color_t lv_obj_get_style_bg_image_recolor_filtered([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part)
        {
            lv_style_value_t v = lv_obj_style_apply_color_filter(obj, part, lv_obj_get_style_prop(obj, part, (byte)(LV_STYLE_BG_IMAGE_RECOLOR)));

            return v.color;
        }

        [return: NativeTypeName("lv_opa_t")]
        public static byte lv_obj_get_style_bg_image_recolor_opa([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part)
        {
            lv_style_value_t v = lv_obj_get_style_prop(obj, part, (byte)(LV_STYLE_BG_IMAGE_RECOLOR_OPA));

            return (byte)(v.num);
        }

        [return: NativeTypeName("bool")]
        public static c_bool1 lv_obj_get_style_bg_image_tiled([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part)
        {
            lv_style_value_t v = lv_obj_get_style_prop(obj, part, (byte)(LV_STYLE_BG_IMAGE_TILED));

            return (c_bool1)(v.num);
        }

        public static lv_color_t lv_obj_get_style_border_color([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part)
        {
            lv_style_value_t v = lv_obj_get_style_prop(obj, part, (byte)(LV_STYLE_BORDER_COLOR));

            return v.color;
        }

        public static lv_color_t lv_obj_get_style_border_color_filtered([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part)
        {
            lv_style_value_t v = lv_obj_style_apply_color_filter(obj, part, lv_obj_get_style_prop(obj, part, (byte)(LV_STYLE_BORDER_COLOR)));

            return v.color;
        }

        [return: NativeTypeName("lv_opa_t")]
        public static byte lv_obj_get_style_border_opa([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part)
        {
            lv_style_value_t v = lv_obj_get_style_prop(obj, part, (byte)(LV_STYLE_BORDER_OPA));

            return (byte)(v.num);
        }

        [return: NativeTypeName("int32_t")]
        public static int lv_obj_get_style_border_width([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part)
        {
            lv_style_value_t v = lv_obj_get_style_prop(obj, part, (byte)(LV_STYLE_BORDER_WIDTH));

            return (int)(v.num);
        }

        public static lv_border_side_t lv_obj_get_style_border_side([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part)
        {
            lv_style_value_t v = lv_obj_get_style_prop(obj, part, (byte)(LV_STYLE_BORDER_SIDE));

            return (lv_border_side_t)(v.num);
        }

        [return: NativeTypeName("bool")]
        public static c_bool1 lv_obj_get_style_border_post([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part)
        {
            lv_style_value_t v = lv_obj_get_style_prop(obj, part, (byte)(LV_STYLE_BORDER_POST));

            return (c_bool1)(v.num);
        }

        [return: NativeTypeName("int32_t")]
        public static int lv_obj_get_style_outline_width([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part)
        {
            lv_style_value_t v = lv_obj_get_style_prop(obj, part, (byte)(LV_STYLE_OUTLINE_WIDTH));

            return (int)(v.num);
        }

        public static lv_color_t lv_obj_get_style_outline_color([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part)
        {
            lv_style_value_t v = lv_obj_get_style_prop(obj, part, (byte)(LV_STYLE_OUTLINE_COLOR));

            return v.color;
        }

        public static lv_color_t lv_obj_get_style_outline_color_filtered([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part)
        {
            lv_style_value_t v = lv_obj_style_apply_color_filter(obj, part, lv_obj_get_style_prop(obj, part, (byte)(LV_STYLE_OUTLINE_COLOR)));

            return v.color;
        }

        [return: NativeTypeName("lv_opa_t")]
        public static byte lv_obj_get_style_outline_opa([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part)
        {
            lv_style_value_t v = lv_obj_get_style_prop(obj, part, (byte)(LV_STYLE_OUTLINE_OPA));

            return (byte)(v.num);
        }

        [return: NativeTypeName("int32_t")]
        public static int lv_obj_get_style_outline_pad([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part)
        {
            lv_style_value_t v = lv_obj_get_style_prop(obj, part, (byte)(LV_STYLE_OUTLINE_PAD));

            return (int)(v.num);
        }

        [return: NativeTypeName("int32_t")]
        public static int lv_obj_get_style_shadow_width([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part)
        {
            lv_style_value_t v = lv_obj_get_style_prop(obj, part, (byte)(LV_STYLE_SHADOW_WIDTH));

            return (int)(v.num);
        }

        [return: NativeTypeName("int32_t")]
        public static int lv_obj_get_style_shadow_offset_x([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part)
        {
            lv_style_value_t v = lv_obj_get_style_prop(obj, part, (byte)(LV_STYLE_SHADOW_OFFSET_X));

            return (int)(v.num);
        }

        [return: NativeTypeName("int32_t")]
        public static int lv_obj_get_style_shadow_offset_y([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part)
        {
            lv_style_value_t v = lv_obj_get_style_prop(obj, part, (byte)(LV_STYLE_SHADOW_OFFSET_Y));

            return (int)(v.num);
        }

        [return: NativeTypeName("int32_t")]
        public static int lv_obj_get_style_shadow_spread([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part)
        {
            lv_style_value_t v = lv_obj_get_style_prop(obj, part, (byte)(LV_STYLE_SHADOW_SPREAD));

            return (int)(v.num);
        }

        public static lv_color_t lv_obj_get_style_shadow_color([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part)
        {
            lv_style_value_t v = lv_obj_get_style_prop(obj, part, (byte)(LV_STYLE_SHADOW_COLOR));

            return v.color;
        }

        public static lv_color_t lv_obj_get_style_shadow_color_filtered([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part)
        {
            lv_style_value_t v = lv_obj_style_apply_color_filter(obj, part, lv_obj_get_style_prop(obj, part, (byte)(LV_STYLE_SHADOW_COLOR)));

            return v.color;
        }

        [return: NativeTypeName("lv_opa_t")]
        public static byte lv_obj_get_style_shadow_opa([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part)
        {
            lv_style_value_t v = lv_obj_get_style_prop(obj, part, (byte)(LV_STYLE_SHADOW_OPA));

            return (byte)(v.num);
        }

        [return: NativeTypeName("lv_opa_t")]
        public static byte lv_obj_get_style_image_opa([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part)
        {
            lv_style_value_t v = lv_obj_get_style_prop(obj, part, (byte)(LV_STYLE_IMAGE_OPA));

            return (byte)(v.num);
        }

        public static lv_color_t lv_obj_get_style_image_recolor([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part)
        {
            lv_style_value_t v = lv_obj_get_style_prop(obj, part, (byte)(LV_STYLE_IMAGE_RECOLOR));

            return v.color;
        }

        public static lv_color_t lv_obj_get_style_image_recolor_filtered([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part)
        {
            lv_style_value_t v = lv_obj_style_apply_color_filter(obj, part, lv_obj_get_style_prop(obj, part, (byte)(LV_STYLE_IMAGE_RECOLOR)));

            return v.color;
        }

        [return: NativeTypeName("lv_opa_t")]
        public static byte lv_obj_get_style_image_recolor_opa([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part)
        {
            lv_style_value_t v = lv_obj_get_style_prop(obj, part, (byte)(LV_STYLE_IMAGE_RECOLOR_OPA));

            return (byte)(v.num);
        }

        [return: NativeTypeName("int32_t")]
        public static int lv_obj_get_style_line_width([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part)
        {
            lv_style_value_t v = lv_obj_get_style_prop(obj, part, (byte)(LV_STYLE_LINE_WIDTH));

            return (int)(v.num);
        }

        [return: NativeTypeName("int32_t")]
        public static int lv_obj_get_style_line_dash_width([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part)
        {
            lv_style_value_t v = lv_obj_get_style_prop(obj, part, (byte)(LV_STYLE_LINE_DASH_WIDTH));

            return (int)(v.num);
        }

        [return: NativeTypeName("int32_t")]
        public static int lv_obj_get_style_line_dash_gap([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part)
        {
            lv_style_value_t v = lv_obj_get_style_prop(obj, part, (byte)(LV_STYLE_LINE_DASH_GAP));

            return (int)(v.num);
        }

        [return: NativeTypeName("bool")]
        public static c_bool1 lv_obj_get_style_line_rounded([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part)
        {
            lv_style_value_t v = lv_obj_get_style_prop(obj, part, (byte)(LV_STYLE_LINE_ROUNDED));

            return (c_bool1)(v.num);
        }

        public static lv_color_t lv_obj_get_style_line_color([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part)
        {
            lv_style_value_t v = lv_obj_get_style_prop(obj, part, (byte)(LV_STYLE_LINE_COLOR));

            return v.color;
        }

        public static lv_color_t lv_obj_get_style_line_color_filtered([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part)
        {
            lv_style_value_t v = lv_obj_style_apply_color_filter(obj, part, lv_obj_get_style_prop(obj, part, (byte)(LV_STYLE_LINE_COLOR)));

            return v.color;
        }

        [return: NativeTypeName("lv_opa_t")]
        public static byte lv_obj_get_style_line_opa([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part)
        {
            lv_style_value_t v = lv_obj_get_style_prop(obj, part, (byte)(LV_STYLE_LINE_OPA));

            return (byte)(v.num);
        }

        [return: NativeTypeName("int32_t")]
        public static int lv_obj_get_style_arc_width([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part)
        {
            lv_style_value_t v = lv_obj_get_style_prop(obj, part, (byte)(LV_STYLE_ARC_WIDTH));

            return (int)(v.num);
        }

        [return: NativeTypeName("bool")]
        public static c_bool1 lv_obj_get_style_arc_rounded([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part)
        {
            lv_style_value_t v = lv_obj_get_style_prop(obj, part, (byte)(LV_STYLE_ARC_ROUNDED));

            return (c_bool1)(v.num);
        }

        public static lv_color_t lv_obj_get_style_arc_color([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part)
        {
            lv_style_value_t v = lv_obj_get_style_prop(obj, part, (byte)(LV_STYLE_ARC_COLOR));

            return v.color;
        }

        public static lv_color_t lv_obj_get_style_arc_color_filtered([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part)
        {
            lv_style_value_t v = lv_obj_style_apply_color_filter(obj, part, lv_obj_get_style_prop(obj, part, (byte)(LV_STYLE_ARC_COLOR)));

            return v.color;
        }

        [return: NativeTypeName("lv_opa_t")]
        public static byte lv_obj_get_style_arc_opa([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part)
        {
            lv_style_value_t v = lv_obj_get_style_prop(obj, part, (byte)(LV_STYLE_ARC_OPA));

            return (byte)(v.num);
        }

        [return: NativeTypeName("const void *")]
        public static void* lv_obj_get_style_arc_image_src([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part)
        {
            lv_style_value_t v = lv_obj_get_style_prop(obj, part, (byte)(LV_STYLE_ARC_IMAGE_SRC));

            return (void*)(v.ptr);
        }

        public static lv_color_t lv_obj_get_style_text_color([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part)
        {
            lv_style_value_t v = lv_obj_get_style_prop(obj, part, (byte)(LV_STYLE_TEXT_COLOR));

            return v.color;
        }

        public static lv_color_t lv_obj_get_style_text_color_filtered([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part)
        {
            lv_style_value_t v = lv_obj_style_apply_color_filter(obj, part, lv_obj_get_style_prop(obj, part, (byte)(LV_STYLE_TEXT_COLOR)));

            return v.color;
        }

        [return: NativeTypeName("lv_opa_t")]
        public static byte lv_obj_get_style_text_opa([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part)
        {
            lv_style_value_t v = lv_obj_get_style_prop(obj, part, (byte)(LV_STYLE_TEXT_OPA));

            return (byte)(v.num);
        }

        [return: NativeTypeName("const lv_font_t *")]
        public static lv_font_t* lv_obj_get_style_text_font([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part)
        {
            lv_style_value_t v = lv_obj_get_style_prop(obj, part, (byte)(LV_STYLE_TEXT_FONT));

            return (lv_font_t*)(v.ptr);
        }

        [return: NativeTypeName("int32_t")]
        public static int lv_obj_get_style_text_letter_space([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part)
        {
            lv_style_value_t v = lv_obj_get_style_prop(obj, part, (byte)(LV_STYLE_TEXT_LETTER_SPACE));

            return (int)(v.num);
        }

        [return: NativeTypeName("int32_t")]
        public static int lv_obj_get_style_text_line_space([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part)
        {
            lv_style_value_t v = lv_obj_get_style_prop(obj, part, (byte)(LV_STYLE_TEXT_LINE_SPACE));

            return (int)(v.num);
        }

        public static lv_text_decor_t lv_obj_get_style_text_decor([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part)
        {
            lv_style_value_t v = lv_obj_get_style_prop(obj, part, (byte)(LV_STYLE_TEXT_DECOR));

            return (lv_text_decor_t)(v.num);
        }

        public static lv_text_align_t lv_obj_get_style_text_align([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part)
        {
            lv_style_value_t v = lv_obj_get_style_prop(obj, part, (byte)(LV_STYLE_TEXT_ALIGN));

            return (lv_text_align_t)(v.num);
        }

        public static lv_color_t lv_obj_get_style_text_outline_stroke_color([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part)
        {
            lv_style_value_t v = lv_obj_get_style_prop(obj, part, (byte)(LV_STYLE_TEXT_OUTLINE_STROKE_COLOR));

            return v.color;
        }

        public static lv_color_t lv_obj_get_style_text_outline_stroke_color_filtered([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part)
        {
            lv_style_value_t v = lv_obj_style_apply_color_filter(obj, part, lv_obj_get_style_prop(obj, part, (byte)(LV_STYLE_TEXT_OUTLINE_STROKE_COLOR)));

            return v.color;
        }

        [return: NativeTypeName("int32_t")]
        public static int lv_obj_get_style_text_outline_stroke_width([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part)
        {
            lv_style_value_t v = lv_obj_get_style_prop(obj, part, (byte)(LV_STYLE_TEXT_OUTLINE_STROKE_WIDTH));

            return (int)(v.num);
        }

        [return: NativeTypeName("lv_opa_t")]
        public static byte lv_obj_get_style_text_outline_stroke_opa([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part)
        {
            lv_style_value_t v = lv_obj_get_style_prop(obj, part, (byte)(LV_STYLE_TEXT_OUTLINE_STROKE_OPA));

            return (byte)(v.num);
        }

        [return: NativeTypeName("int32_t")]
        public static int lv_obj_get_style_radius([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part)
        {
            lv_style_value_t v = lv_obj_get_style_prop(obj, part, (byte)(LV_STYLE_RADIUS));

            return (int)(v.num);
        }

        [return: NativeTypeName("int32_t")]
        public static int lv_obj_get_style_radial_offset([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part)
        {
            lv_style_value_t v = lv_obj_get_style_prop(obj, part, (byte)(LV_STYLE_RADIAL_OFFSET));

            return (int)(v.num);
        }

        [return: NativeTypeName("bool")]
        public static c_bool1 lv_obj_get_style_clip_corner([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part)
        {
            lv_style_value_t v = lv_obj_get_style_prop(obj, part, (byte)(LV_STYLE_CLIP_CORNER));

            return (c_bool1)(v.num);
        }

        [return: NativeTypeName("lv_opa_t")]
        public static byte lv_obj_get_style_opa([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part)
        {
            lv_style_value_t v = lv_obj_get_style_prop(obj, part, (byte)(LV_STYLE_OPA));

            return (byte)(v.num);
        }

        [return: NativeTypeName("lv_opa_t")]
        public static byte lv_obj_get_style_opa_layered([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part)
        {
            lv_style_value_t v = lv_obj_get_style_prop(obj, part, (byte)(LV_STYLE_OPA_LAYERED));

            return (byte)(v.num);
        }

        [return: NativeTypeName("const lv_color_filter_dsc_t *")]
        public static lv_color_filter_dsc_t* lv_obj_get_style_color_filter_dsc([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part)
        {
            lv_style_value_t v = lv_obj_get_style_prop(obj, part, (byte)(LV_STYLE_COLOR_FILTER_DSC));

            return (lv_color_filter_dsc_t*)(v.ptr);
        }

        [return: NativeTypeName("lv_opa_t")]
        public static byte lv_obj_get_style_color_filter_opa([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part)
        {
            lv_style_value_t v = lv_obj_get_style_prop(obj, part, (byte)(LV_STYLE_COLOR_FILTER_OPA));

            return (byte)(v.num);
        }

        public static lv_color_t lv_obj_get_style_recolor([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part)
        {
            lv_style_value_t v = lv_obj_get_style_prop(obj, part, (byte)(LV_STYLE_RECOLOR));

            return v.color;
        }

        [return: NativeTypeName("lv_opa_t")]
        public static byte lv_obj_get_style_recolor_opa([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part)
        {
            lv_style_value_t v = lv_obj_get_style_prop(obj, part, (byte)(LV_STYLE_RECOLOR_OPA));

            return (byte)(v.num);
        }

        [return: NativeTypeName("const lv_anim_t *")]
        public static lv_anim_t* lv_obj_get_style_anim([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part)
        {
            lv_style_value_t v = lv_obj_get_style_prop(obj, part, (byte)(LV_STYLE_ANIM));

            return (lv_anim_t*)(v.ptr);
        }

        [return: NativeTypeName("uint32_t")]
        public static uint lv_obj_get_style_anim_duration([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part)
        {
            lv_style_value_t v = lv_obj_get_style_prop(obj, part, (byte)(LV_STYLE_ANIM_DURATION));

            return (uint)(v.num);
        }

        [return: NativeTypeName("const lv_style_transition_dsc_t *")]
        public static lv_style_transition_dsc_t* lv_obj_get_style_transition([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part)
        {
            lv_style_value_t v = lv_obj_get_style_prop(obj, part, (byte)(LV_STYLE_TRANSITION));

            return (lv_style_transition_dsc_t*)(v.ptr);
        }

        public static lv_blend_mode_t lv_obj_get_style_blend_mode([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part)
        {
            lv_style_value_t v = lv_obj_get_style_prop(obj, part, (byte)(LV_STYLE_BLEND_MODE));

            return (lv_blend_mode_t)(v.num);
        }

        [return: NativeTypeName("uint16_t")]
        public static ushort lv_obj_get_style_layout([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part)
        {
            lv_style_value_t v = lv_obj_get_style_prop(obj, part, (byte)(LV_STYLE_LAYOUT));

            return (ushort)(v.num);
        }

        public static lv_base_dir_t lv_obj_get_style_base_dir([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part)
        {
            lv_style_value_t v = lv_obj_get_style_prop(obj, part, (byte)(LV_STYLE_BASE_DIR));

            return (lv_base_dir_t)(v.num);
        }

        [return: NativeTypeName("const void *")]
        public static void* lv_obj_get_style_bitmap_mask_src([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part)
        {
            lv_style_value_t v = lv_obj_get_style_prop(obj, part, (byte)(LV_STYLE_BITMAP_MASK_SRC));

            return (void*)(v.ptr);
        }

        [return: NativeTypeName("uint32_t")]
        public static uint lv_obj_get_style_rotary_sensitivity([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part)
        {
            lv_style_value_t v = lv_obj_get_style_prop(obj, part, (byte)(LV_STYLE_ROTARY_SENSITIVITY));

            return (uint)(v.num);
        }

        public static lv_flex_flow_t lv_obj_get_style_flex_flow([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part)
        {
            lv_style_value_t v = lv_obj_get_style_prop(obj, part, (byte)(LV_STYLE_FLEX_FLOW));

            return (lv_flex_flow_t)(v.num);
        }

        public static lv_flex_align_t lv_obj_get_style_flex_main_place([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part)
        {
            lv_style_value_t v = lv_obj_get_style_prop(obj, part, (byte)(LV_STYLE_FLEX_MAIN_PLACE));

            return (lv_flex_align_t)(v.num);
        }

        public static lv_flex_align_t lv_obj_get_style_flex_cross_place([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part)
        {
            lv_style_value_t v = lv_obj_get_style_prop(obj, part, (byte)(LV_STYLE_FLEX_CROSS_PLACE));

            return (lv_flex_align_t)(v.num);
        }

        public static lv_flex_align_t lv_obj_get_style_flex_track_place([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part)
        {
            lv_style_value_t v = lv_obj_get_style_prop(obj, part, (byte)(LV_STYLE_FLEX_TRACK_PLACE));

            return (lv_flex_align_t)(v.num);
        }

        [return: NativeTypeName("uint8_t")]
        public static byte lv_obj_get_style_flex_grow([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part)
        {
            lv_style_value_t v = lv_obj_get_style_prop(obj, part, (byte)(LV_STYLE_FLEX_GROW));

            return (byte)(v.num);
        }

        [return: NativeTypeName("const int32_t *")]
        public static int* lv_obj_get_style_grid_column_dsc_array([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part)
        {
            lv_style_value_t v = lv_obj_get_style_prop(obj, part, (byte)(LV_STYLE_GRID_COLUMN_DSC_ARRAY));

            return (int*)(v.ptr);
        }

        public static lv_grid_align_t lv_obj_get_style_grid_column_align([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part)
        {
            lv_style_value_t v = lv_obj_get_style_prop(obj, part, (byte)(LV_STYLE_GRID_COLUMN_ALIGN));

            return (lv_grid_align_t)(v.num);
        }

        [return: NativeTypeName("const int32_t *")]
        public static int* lv_obj_get_style_grid_row_dsc_array([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part)
        {
            lv_style_value_t v = lv_obj_get_style_prop(obj, part, (byte)(LV_STYLE_GRID_ROW_DSC_ARRAY));

            return (int*)(v.ptr);
        }

        public static lv_grid_align_t lv_obj_get_style_grid_row_align([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part)
        {
            lv_style_value_t v = lv_obj_get_style_prop(obj, part, (byte)(LV_STYLE_GRID_ROW_ALIGN));

            return (lv_grid_align_t)(v.num);
        }

        [return: NativeTypeName("int32_t")]
        public static int lv_obj_get_style_grid_cell_column_pos([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part)
        {
            lv_style_value_t v = lv_obj_get_style_prop(obj, part, (byte)(LV_STYLE_GRID_CELL_COLUMN_POS));

            return (int)(v.num);
        }

        public static lv_grid_align_t lv_obj_get_style_grid_cell_x_align([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part)
        {
            lv_style_value_t v = lv_obj_get_style_prop(obj, part, (byte)(LV_STYLE_GRID_CELL_X_ALIGN));

            return (lv_grid_align_t)(v.num);
        }

        [return: NativeTypeName("int32_t")]
        public static int lv_obj_get_style_grid_cell_column_span([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part)
        {
            lv_style_value_t v = lv_obj_get_style_prop(obj, part, (byte)(LV_STYLE_GRID_CELL_COLUMN_SPAN));

            return (int)(v.num);
        }

        [return: NativeTypeName("int32_t")]
        public static int lv_obj_get_style_grid_cell_row_pos([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part)
        {
            lv_style_value_t v = lv_obj_get_style_prop(obj, part, (byte)(LV_STYLE_GRID_CELL_ROW_POS));

            return (int)(v.num);
        }

        public static lv_grid_align_t lv_obj_get_style_grid_cell_y_align([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part)
        {
            lv_style_value_t v = lv_obj_get_style_prop(obj, part, (byte)(LV_STYLE_GRID_CELL_Y_ALIGN));

            return (lv_grid_align_t)(v.num);
        }

        [return: NativeTypeName("int32_t")]
        public static int lv_obj_get_style_grid_cell_row_span([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part)
        {
            lv_style_value_t v = lv_obj_get_style_prop(obj, part, (byte)(LV_STYLE_GRID_CELL_ROW_SPAN));

            return (int)(v.num);
        }

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_set_style_width(lv_obj_t* obj, [NativeTypeName("int32_t")] int value, [NativeTypeName("lv_style_selector_t")] uint selector);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_set_style_min_width(lv_obj_t* obj, [NativeTypeName("int32_t")] int value, [NativeTypeName("lv_style_selector_t")] uint selector);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_set_style_max_width(lv_obj_t* obj, [NativeTypeName("int32_t")] int value, [NativeTypeName("lv_style_selector_t")] uint selector);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_set_style_height(lv_obj_t* obj, [NativeTypeName("int32_t")] int value, [NativeTypeName("lv_style_selector_t")] uint selector);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_set_style_min_height(lv_obj_t* obj, [NativeTypeName("int32_t")] int value, [NativeTypeName("lv_style_selector_t")] uint selector);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_set_style_max_height(lv_obj_t* obj, [NativeTypeName("int32_t")] int value, [NativeTypeName("lv_style_selector_t")] uint selector);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_set_style_length(lv_obj_t* obj, [NativeTypeName("int32_t")] int value, [NativeTypeName("lv_style_selector_t")] uint selector);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_set_style_x(lv_obj_t* obj, [NativeTypeName("int32_t")] int value, [NativeTypeName("lv_style_selector_t")] uint selector);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_set_style_y(lv_obj_t* obj, [NativeTypeName("int32_t")] int value, [NativeTypeName("lv_style_selector_t")] uint selector);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_set_style_align(lv_obj_t* obj, lv_align_t value, [NativeTypeName("lv_style_selector_t")] uint selector);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_set_style_transform_width(lv_obj_t* obj, [NativeTypeName("int32_t")] int value, [NativeTypeName("lv_style_selector_t")] uint selector);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_set_style_transform_height(lv_obj_t* obj, [NativeTypeName("int32_t")] int value, [NativeTypeName("lv_style_selector_t")] uint selector);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_set_style_translate_x(lv_obj_t* obj, [NativeTypeName("int32_t")] int value, [NativeTypeName("lv_style_selector_t")] uint selector);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_set_style_translate_y(lv_obj_t* obj, [NativeTypeName("int32_t")] int value, [NativeTypeName("lv_style_selector_t")] uint selector);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_set_style_translate_radial(lv_obj_t* obj, [NativeTypeName("int32_t")] int value, [NativeTypeName("lv_style_selector_t")] uint selector);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_set_style_transform_scale_x(lv_obj_t* obj, [NativeTypeName("int32_t")] int value, [NativeTypeName("lv_style_selector_t")] uint selector);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_set_style_transform_scale_y(lv_obj_t* obj, [NativeTypeName("int32_t")] int value, [NativeTypeName("lv_style_selector_t")] uint selector);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_set_style_transform_rotation(lv_obj_t* obj, [NativeTypeName("int32_t")] int value, [NativeTypeName("lv_style_selector_t")] uint selector);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_set_style_transform_pivot_x(lv_obj_t* obj, [NativeTypeName("int32_t")] int value, [NativeTypeName("lv_style_selector_t")] uint selector);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_set_style_transform_pivot_y(lv_obj_t* obj, [NativeTypeName("int32_t")] int value, [NativeTypeName("lv_style_selector_t")] uint selector);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_set_style_transform_skew_x(lv_obj_t* obj, [NativeTypeName("int32_t")] int value, [NativeTypeName("lv_style_selector_t")] uint selector);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_set_style_transform_skew_y(lv_obj_t* obj, [NativeTypeName("int32_t")] int value, [NativeTypeName("lv_style_selector_t")] uint selector);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_set_style_pad_top(lv_obj_t* obj, [NativeTypeName("int32_t")] int value, [NativeTypeName("lv_style_selector_t")] uint selector);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_set_style_pad_bottom(lv_obj_t* obj, [NativeTypeName("int32_t")] int value, [NativeTypeName("lv_style_selector_t")] uint selector);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_set_style_pad_left(lv_obj_t* obj, [NativeTypeName("int32_t")] int value, [NativeTypeName("lv_style_selector_t")] uint selector);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_set_style_pad_right(lv_obj_t* obj, [NativeTypeName("int32_t")] int value, [NativeTypeName("lv_style_selector_t")] uint selector);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_set_style_pad_row(lv_obj_t* obj, [NativeTypeName("int32_t")] int value, [NativeTypeName("lv_style_selector_t")] uint selector);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_set_style_pad_column(lv_obj_t* obj, [NativeTypeName("int32_t")] int value, [NativeTypeName("lv_style_selector_t")] uint selector);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_set_style_pad_radial(lv_obj_t* obj, [NativeTypeName("int32_t")] int value, [NativeTypeName("lv_style_selector_t")] uint selector);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_set_style_margin_top(lv_obj_t* obj, [NativeTypeName("int32_t")] int value, [NativeTypeName("lv_style_selector_t")] uint selector);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_set_style_margin_bottom(lv_obj_t* obj, [NativeTypeName("int32_t")] int value, [NativeTypeName("lv_style_selector_t")] uint selector);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_set_style_margin_left(lv_obj_t* obj, [NativeTypeName("int32_t")] int value, [NativeTypeName("lv_style_selector_t")] uint selector);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_set_style_margin_right(lv_obj_t* obj, [NativeTypeName("int32_t")] int value, [NativeTypeName("lv_style_selector_t")] uint selector);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_set_style_bg_color(lv_obj_t* obj, lv_color_t value, [NativeTypeName("lv_style_selector_t")] uint selector);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_set_style_bg_opa(lv_obj_t* obj, [NativeTypeName("lv_opa_t")] byte value, [NativeTypeName("lv_style_selector_t")] uint selector);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_set_style_bg_grad_color(lv_obj_t* obj, lv_color_t value, [NativeTypeName("lv_style_selector_t")] uint selector);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_set_style_bg_grad_dir(lv_obj_t* obj, lv_grad_dir_t value, [NativeTypeName("lv_style_selector_t")] uint selector);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_set_style_bg_main_stop(lv_obj_t* obj, [NativeTypeName("int32_t")] int value, [NativeTypeName("lv_style_selector_t")] uint selector);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_set_style_bg_grad_stop(lv_obj_t* obj, [NativeTypeName("int32_t")] int value, [NativeTypeName("lv_style_selector_t")] uint selector);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_set_style_bg_main_opa(lv_obj_t* obj, [NativeTypeName("lv_opa_t")] byte value, [NativeTypeName("lv_style_selector_t")] uint selector);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_set_style_bg_grad_opa(lv_obj_t* obj, [NativeTypeName("lv_opa_t")] byte value, [NativeTypeName("lv_style_selector_t")] uint selector);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_set_style_bg_grad(lv_obj_t* obj, [NativeTypeName("const lv_grad_dsc_t *")] lv_grad_dsc_t* value, [NativeTypeName("lv_style_selector_t")] uint selector);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_set_style_bg_image_src(lv_obj_t* obj, [NativeTypeName("const void *")] void* value, [NativeTypeName("lv_style_selector_t")] uint selector);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_set_style_bg_image_opa(lv_obj_t* obj, [NativeTypeName("lv_opa_t")] byte value, [NativeTypeName("lv_style_selector_t")] uint selector);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_set_style_bg_image_recolor(lv_obj_t* obj, lv_color_t value, [NativeTypeName("lv_style_selector_t")] uint selector);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_set_style_bg_image_recolor_opa(lv_obj_t* obj, [NativeTypeName("lv_opa_t")] byte value, [NativeTypeName("lv_style_selector_t")] uint selector);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_set_style_bg_image_tiled(lv_obj_t* obj, [NativeTypeName("bool")] c_bool1 value, [NativeTypeName("lv_style_selector_t")] uint selector);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_set_style_border_color(lv_obj_t* obj, lv_color_t value, [NativeTypeName("lv_style_selector_t")] uint selector);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_set_style_border_opa(lv_obj_t* obj, [NativeTypeName("lv_opa_t")] byte value, [NativeTypeName("lv_style_selector_t")] uint selector);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_set_style_border_width(lv_obj_t* obj, [NativeTypeName("int32_t")] int value, [NativeTypeName("lv_style_selector_t")] uint selector);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_set_style_border_side(lv_obj_t* obj, lv_border_side_t value, [NativeTypeName("lv_style_selector_t")] uint selector);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_set_style_border_post(lv_obj_t* obj, [NativeTypeName("bool")] c_bool1 value, [NativeTypeName("lv_style_selector_t")] uint selector);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_set_style_outline_width(lv_obj_t* obj, [NativeTypeName("int32_t")] int value, [NativeTypeName("lv_style_selector_t")] uint selector);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_set_style_outline_color(lv_obj_t* obj, lv_color_t value, [NativeTypeName("lv_style_selector_t")] uint selector);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_set_style_outline_opa(lv_obj_t* obj, [NativeTypeName("lv_opa_t")] byte value, [NativeTypeName("lv_style_selector_t")] uint selector);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_set_style_outline_pad(lv_obj_t* obj, [NativeTypeName("int32_t")] int value, [NativeTypeName("lv_style_selector_t")] uint selector);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_set_style_shadow_width(lv_obj_t* obj, [NativeTypeName("int32_t")] int value, [NativeTypeName("lv_style_selector_t")] uint selector);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_set_style_shadow_offset_x(lv_obj_t* obj, [NativeTypeName("int32_t")] int value, [NativeTypeName("lv_style_selector_t")] uint selector);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_set_style_shadow_offset_y(lv_obj_t* obj, [NativeTypeName("int32_t")] int value, [NativeTypeName("lv_style_selector_t")] uint selector);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_set_style_shadow_spread(lv_obj_t* obj, [NativeTypeName("int32_t")] int value, [NativeTypeName("lv_style_selector_t")] uint selector);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_set_style_shadow_color(lv_obj_t* obj, lv_color_t value, [NativeTypeName("lv_style_selector_t")] uint selector);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_set_style_shadow_opa(lv_obj_t* obj, [NativeTypeName("lv_opa_t")] byte value, [NativeTypeName("lv_style_selector_t")] uint selector);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_set_style_image_opa(lv_obj_t* obj, [NativeTypeName("lv_opa_t")] byte value, [NativeTypeName("lv_style_selector_t")] uint selector);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_set_style_image_recolor(lv_obj_t* obj, lv_color_t value, [NativeTypeName("lv_style_selector_t")] uint selector);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_set_style_image_recolor_opa(lv_obj_t* obj, [NativeTypeName("lv_opa_t")] byte value, [NativeTypeName("lv_style_selector_t")] uint selector);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_set_style_line_width(lv_obj_t* obj, [NativeTypeName("int32_t")] int value, [NativeTypeName("lv_style_selector_t")] uint selector);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_set_style_line_dash_width(lv_obj_t* obj, [NativeTypeName("int32_t")] int value, [NativeTypeName("lv_style_selector_t")] uint selector);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_set_style_line_dash_gap(lv_obj_t* obj, [NativeTypeName("int32_t")] int value, [NativeTypeName("lv_style_selector_t")] uint selector);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_set_style_line_rounded(lv_obj_t* obj, [NativeTypeName("bool")] c_bool1 value, [NativeTypeName("lv_style_selector_t")] uint selector);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_set_style_line_color(lv_obj_t* obj, lv_color_t value, [NativeTypeName("lv_style_selector_t")] uint selector);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_set_style_line_opa(lv_obj_t* obj, [NativeTypeName("lv_opa_t")] byte value, [NativeTypeName("lv_style_selector_t")] uint selector);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_set_style_arc_width(lv_obj_t* obj, [NativeTypeName("int32_t")] int value, [NativeTypeName("lv_style_selector_t")] uint selector);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_set_style_arc_rounded(lv_obj_t* obj, [NativeTypeName("bool")] c_bool1 value, [NativeTypeName("lv_style_selector_t")] uint selector);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_set_style_arc_color(lv_obj_t* obj, lv_color_t value, [NativeTypeName("lv_style_selector_t")] uint selector);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_set_style_arc_opa(lv_obj_t* obj, [NativeTypeName("lv_opa_t")] byte value, [NativeTypeName("lv_style_selector_t")] uint selector);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_set_style_arc_image_src(lv_obj_t* obj, [NativeTypeName("const void *")] void* value, [NativeTypeName("lv_style_selector_t")] uint selector);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_set_style_text_color(lv_obj_t* obj, lv_color_t value, [NativeTypeName("lv_style_selector_t")] uint selector);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_set_style_text_opa(lv_obj_t* obj, [NativeTypeName("lv_opa_t")] byte value, [NativeTypeName("lv_style_selector_t")] uint selector);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_set_style_text_font(lv_obj_t* obj, [NativeTypeName("const lv_font_t *")] lv_font_t* value, [NativeTypeName("lv_style_selector_t")] uint selector);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_set_style_text_letter_space(lv_obj_t* obj, [NativeTypeName("int32_t")] int value, [NativeTypeName("lv_style_selector_t")] uint selector);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_set_style_text_line_space(lv_obj_t* obj, [NativeTypeName("int32_t")] int value, [NativeTypeName("lv_style_selector_t")] uint selector);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_set_style_text_decor(lv_obj_t* obj, lv_text_decor_t value, [NativeTypeName("lv_style_selector_t")] uint selector);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_set_style_text_align(lv_obj_t* obj, lv_text_align_t value, [NativeTypeName("lv_style_selector_t")] uint selector);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_set_style_text_outline_stroke_color(lv_obj_t* obj, lv_color_t value, [NativeTypeName("lv_style_selector_t")] uint selector);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_set_style_text_outline_stroke_width(lv_obj_t* obj, [NativeTypeName("int32_t")] int value, [NativeTypeName("lv_style_selector_t")] uint selector);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_set_style_text_outline_stroke_opa(lv_obj_t* obj, [NativeTypeName("lv_opa_t")] byte value, [NativeTypeName("lv_style_selector_t")] uint selector);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_set_style_radius(lv_obj_t* obj, [NativeTypeName("int32_t")] int value, [NativeTypeName("lv_style_selector_t")] uint selector);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_set_style_radial_offset(lv_obj_t* obj, [NativeTypeName("int32_t")] int value, [NativeTypeName("lv_style_selector_t")] uint selector);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_set_style_clip_corner(lv_obj_t* obj, [NativeTypeName("bool")] c_bool1 value, [NativeTypeName("lv_style_selector_t")] uint selector);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_set_style_opa(lv_obj_t* obj, [NativeTypeName("lv_opa_t")] byte value, [NativeTypeName("lv_style_selector_t")] uint selector);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_set_style_opa_layered(lv_obj_t* obj, [NativeTypeName("lv_opa_t")] byte value, [NativeTypeName("lv_style_selector_t")] uint selector);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_set_style_color_filter_dsc(lv_obj_t* obj, [NativeTypeName("const lv_color_filter_dsc_t *")] lv_color_filter_dsc_t* value, [NativeTypeName("lv_style_selector_t")] uint selector);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_set_style_color_filter_opa(lv_obj_t* obj, [NativeTypeName("lv_opa_t")] byte value, [NativeTypeName("lv_style_selector_t")] uint selector);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_set_style_recolor(lv_obj_t* obj, lv_color_t value, [NativeTypeName("lv_style_selector_t")] uint selector);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_set_style_recolor_opa(lv_obj_t* obj, [NativeTypeName("lv_opa_t")] byte value, [NativeTypeName("lv_style_selector_t")] uint selector);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_set_style_anim(lv_obj_t* obj, [NativeTypeName("const lv_anim_t *")] lv_anim_t* value, [NativeTypeName("lv_style_selector_t")] uint selector);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_set_style_anim_duration(lv_obj_t* obj, [NativeTypeName("uint32_t")] uint value, [NativeTypeName("lv_style_selector_t")] uint selector);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_set_style_transition(lv_obj_t* obj, [NativeTypeName("const lv_style_transition_dsc_t *")] lv_style_transition_dsc_t* value, [NativeTypeName("lv_style_selector_t")] uint selector);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_set_style_blend_mode(lv_obj_t* obj, lv_blend_mode_t value, [NativeTypeName("lv_style_selector_t")] uint selector);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_set_style_layout(lv_obj_t* obj, [NativeTypeName("uint16_t")] ushort value, [NativeTypeName("lv_style_selector_t")] uint selector);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_set_style_base_dir(lv_obj_t* obj, lv_base_dir_t value, [NativeTypeName("lv_style_selector_t")] uint selector);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_set_style_bitmap_mask_src(lv_obj_t* obj, [NativeTypeName("const void *")] void* value, [NativeTypeName("lv_style_selector_t")] uint selector);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_set_style_rotary_sensitivity(lv_obj_t* obj, [NativeTypeName("uint32_t")] uint value, [NativeTypeName("lv_style_selector_t")] uint selector);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_set_style_flex_flow(lv_obj_t* obj, lv_flex_flow_t value, [NativeTypeName("lv_style_selector_t")] uint selector);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_set_style_flex_main_place(lv_obj_t* obj, lv_flex_align_t value, [NativeTypeName("lv_style_selector_t")] uint selector);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_set_style_flex_cross_place(lv_obj_t* obj, lv_flex_align_t value, [NativeTypeName("lv_style_selector_t")] uint selector);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_set_style_flex_track_place(lv_obj_t* obj, lv_flex_align_t value, [NativeTypeName("lv_style_selector_t")] uint selector);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_set_style_flex_grow(lv_obj_t* obj, [NativeTypeName("uint8_t")] byte value, [NativeTypeName("lv_style_selector_t")] uint selector);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_set_style_grid_column_dsc_array(lv_obj_t* obj, [NativeTypeName("const int32_t *")] int* value, [NativeTypeName("lv_style_selector_t")] uint selector);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_set_style_grid_column_align(lv_obj_t* obj, lv_grid_align_t value, [NativeTypeName("lv_style_selector_t")] uint selector);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_set_style_grid_row_dsc_array(lv_obj_t* obj, [NativeTypeName("const int32_t *")] int* value, [NativeTypeName("lv_style_selector_t")] uint selector);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_set_style_grid_row_align(lv_obj_t* obj, lv_grid_align_t value, [NativeTypeName("lv_style_selector_t")] uint selector);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_set_style_grid_cell_column_pos(lv_obj_t* obj, [NativeTypeName("int32_t")] int value, [NativeTypeName("lv_style_selector_t")] uint selector);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_set_style_grid_cell_x_align(lv_obj_t* obj, lv_grid_align_t value, [NativeTypeName("lv_style_selector_t")] uint selector);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_set_style_grid_cell_column_span(lv_obj_t* obj, [NativeTypeName("int32_t")] int value, [NativeTypeName("lv_style_selector_t")] uint selector);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_set_style_grid_cell_row_pos(lv_obj_t* obj, [NativeTypeName("int32_t")] int value, [NativeTypeName("lv_style_selector_t")] uint selector);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_set_style_grid_cell_y_align(lv_obj_t* obj, lv_grid_align_t value, [NativeTypeName("lv_style_selector_t")] uint selector);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_set_style_grid_cell_row_span(lv_obj_t* obj, [NativeTypeName("int32_t")] int value, [NativeTypeName("lv_style_selector_t")] uint selector);

        public static void lv_obj_set_style_pad_all(lv_obj_t* obj, [NativeTypeName("int32_t")] int value, [NativeTypeName("lv_style_selector_t")] uint selector)
        {
            lv_obj_set_style_pad_left(obj, value, selector);
            lv_obj_set_style_pad_right(obj, value, selector);
            lv_obj_set_style_pad_top(obj, value, selector);
            lv_obj_set_style_pad_bottom(obj, value, selector);
        }

        public static void lv_obj_set_style_pad_hor(lv_obj_t* obj, [NativeTypeName("int32_t")] int value, [NativeTypeName("lv_style_selector_t")] uint selector)
        {
            lv_obj_set_style_pad_left(obj, value, selector);
            lv_obj_set_style_pad_right(obj, value, selector);
        }

        public static void lv_obj_set_style_pad_ver(lv_obj_t* obj, [NativeTypeName("int32_t")] int value, [NativeTypeName("lv_style_selector_t")] uint selector)
        {
            lv_obj_set_style_pad_top(obj, value, selector);
            lv_obj_set_style_pad_bottom(obj, value, selector);
        }

        public static void lv_obj_set_style_margin_all(lv_obj_t* obj, [NativeTypeName("int32_t")] int value, [NativeTypeName("lv_style_selector_t")] uint selector)
        {
            lv_obj_set_style_margin_left(obj, value, selector);
            lv_obj_set_style_margin_right(obj, value, selector);
            lv_obj_set_style_margin_top(obj, value, selector);
            lv_obj_set_style_margin_bottom(obj, value, selector);
        }

        public static void lv_obj_set_style_margin_hor(lv_obj_t* obj, [NativeTypeName("int32_t")] int value, [NativeTypeName("lv_style_selector_t")] uint selector)
        {
            lv_obj_set_style_margin_left(obj, value, selector);
            lv_obj_set_style_margin_right(obj, value, selector);
        }

        public static void lv_obj_set_style_margin_ver(lv_obj_t* obj, [NativeTypeName("int32_t")] int value, [NativeTypeName("lv_style_selector_t")] uint selector)
        {
            lv_obj_set_style_margin_top(obj, value, selector);
            lv_obj_set_style_margin_bottom(obj, value, selector);
        }

        public static void lv_obj_set_style_pad_gap(lv_obj_t* obj, [NativeTypeName("int32_t")] int value, [NativeTypeName("lv_style_selector_t")] uint selector)
        {
            lv_obj_set_style_pad_row(obj, value, selector);
            lv_obj_set_style_pad_column(obj, value, selector);
        }

        public static void lv_obj_set_style_size(lv_obj_t* obj, [NativeTypeName("int32_t")] int width, [NativeTypeName("int32_t")] int height, [NativeTypeName("lv_style_selector_t")] uint selector)
        {
            lv_obj_set_style_width(obj, width, selector);
            lv_obj_set_style_height(obj, height, selector);
        }

        public static void lv_obj_set_style_transform_scale(lv_obj_t* obj, [NativeTypeName("int32_t")] int value, [NativeTypeName("lv_style_selector_t")] uint selector)
        {
            lv_obj_set_style_transform_scale_x(obj, value, selector);
            lv_obj_set_style_transform_scale_y(obj, value, selector);
        }

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_text_align_t lv_obj_calculate_style_text_align([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part, [NativeTypeName("const char *")] byte[] txt);

        [return: NativeTypeName("int32_t")]
        public static int lv_obj_get_style_transform_scale_x_safe([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part)
        {
            int scale = lv_obj_get_style_transform_scale_x(obj, part);

            return scale > 0 ? scale : 1;
        }

        [return: NativeTypeName("int32_t")]
        public static int lv_obj_get_style_transform_scale_y_safe([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part)
        {
            int scale = lv_obj_get_style_transform_scale_y(obj, part);

            return scale > 0 ? scale : 1;
        }

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("lv_opa_t")]
        public static extern byte lv_obj_get_style_opa_recursive([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_color32_t lv_obj_style_apply_recolor([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part, lv_color32_t color);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_color32_t lv_obj_get_style_recolor_recursive([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_fs_drv_init(lv_fs_drv_t* drv);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_fs_drv_register(lv_fs_drv_t* drv);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_fs_drv_t* lv_fs_get_drv([NativeTypeName("char")] sbyte letter);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern c_bool1 lv_fs_is_ready([NativeTypeName("char")] sbyte letter);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_fs_res_t lv_fs_open(lv_fs_file_t* file_p, [NativeTypeName("const char *")] byte[] path, lv_fs_mode_t mode);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_fs_make_path_from_buffer(lv_fs_path_ex_t* path, [NativeTypeName("char")] sbyte letter, [NativeTypeName("const void *")] void* buf, [NativeTypeName("uint32_t")] uint size);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_fs_res_t lv_fs_close(lv_fs_file_t* file_p);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_fs_res_t lv_fs_read(lv_fs_file_t* file_p, void* buf, [NativeTypeName("uint32_t")] uint btr, [NativeTypeName("uint32_t *")] uint* br);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_fs_res_t lv_fs_write(lv_fs_file_t* file_p, [NativeTypeName("const void *")] void* buf, [NativeTypeName("uint32_t")] uint btw, [NativeTypeName("uint32_t *")] uint* bw);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_fs_res_t lv_fs_seek(lv_fs_file_t* file_p, [NativeTypeName("uint32_t")] uint pos, lv_fs_whence_t whence);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_fs_res_t lv_fs_tell(lv_fs_file_t* file_p, [NativeTypeName("uint32_t *")] uint* pos);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_fs_res_t lv_fs_dir_open(lv_fs_dir_t* rddir_p, [NativeTypeName("const char *")] byte[] path);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_fs_res_t lv_fs_dir_read(lv_fs_dir_t* rddir_p, [NativeTypeName("char *")] sbyte* fn, [NativeTypeName("uint32_t")] uint fn_len);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_fs_res_t lv_fs_dir_close(lv_fs_dir_t* rddir_p);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* lv_fs_get_letters([NativeTypeName("char *")] sbyte* buf);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern byte[] lv_fs_get_ext([NativeTypeName("const char *")] byte[] fn);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* lv_fs_up([NativeTypeName("char *")] sbyte* path);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern byte[] lv_fs_get_last([NativeTypeName("const char *")] byte[] path);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_result_t lv_image_decoder_get_info([NativeTypeName("const void *")] void* src, lv_image_header_t* header);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_result_t lv_image_decoder_open(lv_image_decoder_dsc_t* dsc, [NativeTypeName("const void *")] void* src, [NativeTypeName("const lv_image_decoder_args_t *")] lv_image_decoder_args_t* args);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_result_t lv_image_decoder_get_area(lv_image_decoder_dsc_t* dsc, [NativeTypeName("const lv_area_t *")] lv_area_t* full_area, lv_area_t* decoded_area);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_image_decoder_close(lv_image_decoder_dsc_t* dsc);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_image_decoder_t* lv_image_decoder_create();

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_image_decoder_delete(lv_image_decoder_t* decoder);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_image_decoder_t* lv_image_decoder_get_next(lv_image_decoder_t* decoder);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_image_decoder_set_info_cb(lv_image_decoder_t* decoder, [NativeTypeName("lv_image_decoder_info_f_t")] delegate* unmanaged[Cdecl]<lv_image_decoder_t*, lv_image_decoder_dsc_t*, lv_image_header_t*, lv_result_t> info_cb);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_image_decoder_set_open_cb(lv_image_decoder_t* decoder, [NativeTypeName("lv_image_decoder_open_f_t")] delegate* unmanaged[Cdecl]<lv_image_decoder_t*, lv_image_decoder_dsc_t*, lv_result_t> open_cb);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_image_decoder_set_get_area_cb(lv_image_decoder_t* decoder, [NativeTypeName("lv_image_decoder_get_area_cb_t")] delegate* unmanaged[Cdecl]<lv_image_decoder_t*, lv_image_decoder_dsc_t*, lv_area_t*, lv_area_t*, lv_result_t> read_line_cb);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_image_decoder_set_close_cb(lv_image_decoder_t* decoder, [NativeTypeName("lv_image_decoder_close_f_t")] delegate* unmanaged[Cdecl]<lv_image_decoder_t*, lv_image_decoder_dsc_t*, void> close_cb);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_cache_entry_t* lv_image_decoder_add_to_cache(lv_image_decoder_t* decoder, lv_image_cache_data_t* search_key, [NativeTypeName("const lv_draw_buf_t *")] lv_draw_buf_t* decoded, void* user_data);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_draw_buf_t* lv_image_decoder_post_process(lv_image_decoder_dsc_t* dsc, lv_draw_buf_t* decoded);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_draw_init();

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_draw_deinit();

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* lv_draw_create_unit([NativeTypeName("size_t")] nuint size);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_draw_task_t* lv_draw_add_task(lv_layer_t* layer, [NativeTypeName("const lv_area_t *")] lv_area_t* coords, lv_draw_task_type_t type);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_draw_finalize_task_creation(lv_layer_t* layer, lv_draw_task_t* t);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_draw_dispatch();

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern c_bool1 lv_draw_dispatch_layer(lv_display_t* disp, lv_layer_t* layer);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_draw_dispatch_wait_for_request();

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_draw_wait_for_finish();

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_draw_dispatch_request();

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint32_t")]
        public static extern uint lv_draw_get_unit_count();

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_draw_task_t* lv_draw_get_available_task(lv_layer_t* layer, lv_draw_task_t* t_prev, [NativeTypeName("uint8_t")] byte draw_unit_id);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_draw_task_t* lv_draw_get_next_available_task(lv_layer_t* layer, lv_draw_task_t* t_prev, [NativeTypeName("uint8_t")] byte draw_unit_id);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint32_t")]
        public static extern uint lv_draw_get_dependent_count(lv_draw_task_t* t_check);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_layer_init(lv_layer_t* layer);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_layer_reset(lv_layer_t* layer);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_layer_t* lv_draw_layer_create(lv_layer_t* parent_layer, lv_color_format_t color_format, [NativeTypeName("const lv_area_t *")] lv_area_t* area);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_draw_layer_init(lv_layer_t* layer, lv_layer_t* parent_layer, lv_color_format_t color_format, [NativeTypeName("const lv_area_t *")] lv_area_t* area);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* lv_draw_layer_alloc_buf(lv_layer_t* layer);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* lv_draw_layer_go_to_xy(lv_layer_t* layer, [NativeTypeName("int32_t")] int x, [NativeTypeName("int32_t")] int y);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_draw_task_type_t lv_draw_task_get_type([NativeTypeName("const lv_draw_task_t *")] lv_draw_task_t* t);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* lv_draw_task_get_draw_dsc([NativeTypeName("const lv_draw_task_t *")] lv_draw_task_t* t);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_draw_task_get_area([NativeTypeName("const lv_draw_task_t *")] lv_draw_task_t* t, lv_area_t* area);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_draw_rect_dsc_init(lv_draw_rect_dsc_t* dsc);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_draw_fill_dsc_init(lv_draw_fill_dsc_t* dsc);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_draw_fill_dsc_t* lv_draw_task_get_fill_dsc(lv_draw_task_t* task);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_draw_fill(lv_layer_t* layer, [NativeTypeName("const lv_draw_fill_dsc_t *")] lv_draw_fill_dsc_t* dsc, [NativeTypeName("const lv_area_t *")] lv_area_t* coords);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_draw_border_dsc_init(lv_draw_border_dsc_t* dsc);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_draw_border_dsc_t* lv_draw_task_get_border_dsc(lv_draw_task_t* task);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_draw_border(lv_layer_t* layer, [NativeTypeName("const lv_draw_border_dsc_t *")] lv_draw_border_dsc_t* dsc, [NativeTypeName("const lv_area_t *")] lv_area_t* coords);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_draw_box_shadow_dsc_init(lv_draw_box_shadow_dsc_t* dsc);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_draw_box_shadow_dsc_t* lv_draw_task_get_box_shadow_dsc(lv_draw_task_t* task);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_draw_box_shadow(lv_layer_t* layer, [NativeTypeName("const lv_draw_box_shadow_dsc_t *")] lv_draw_box_shadow_dsc_t* dsc, [NativeTypeName("const lv_area_t *")] lv_area_t* coords);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_draw_rect(lv_layer_t* layer, [NativeTypeName("const lv_draw_rect_dsc_t *")] lv_draw_rect_dsc_t* dsc, [NativeTypeName("const lv_area_t *")] lv_area_t* coords);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_draw_letter_dsc_init(lv_draw_letter_dsc_t* dsc);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_draw_label_dsc_init(lv_draw_label_dsc_t* dsc);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_draw_label_dsc_t* lv_draw_task_get_label_dsc(lv_draw_task_t* task);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_draw_glyph_dsc_init(lv_draw_glyph_dsc_t* dsc);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_draw_label(lv_layer_t* layer, [NativeTypeName("const lv_draw_label_dsc_t *")] lv_draw_label_dsc_t* dsc, [NativeTypeName("const lv_area_t *")] lv_area_t* coords);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_draw_character(lv_layer_t* layer, lv_draw_label_dsc_t* dsc, [NativeTypeName("const lv_point_t *")] lv_point_t* point, [NativeTypeName("uint32_t")] uint unicode_letter);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_draw_letter(lv_layer_t* layer, lv_draw_letter_dsc_t* dsc, [NativeTypeName("const lv_point_t *")] lv_point_t* point);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_draw_label_iterate_characters(lv_draw_task_t* t, [NativeTypeName("const lv_draw_label_dsc_t *")] lv_draw_label_dsc_t* dsc, [NativeTypeName("const lv_area_t *")] lv_area_t* coords, [NativeTypeName("lv_draw_glyph_cb_t")] delegate* unmanaged[Cdecl]<lv_draw_task_t*, lv_draw_glyph_dsc_t*, lv_draw_fill_dsc_t*, lv_area_t*, void> cb);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_draw_unit_draw_letter(lv_draw_task_t* t, lv_draw_glyph_dsc_t* dsc, [NativeTypeName("const lv_point_t *")] lv_point_t* pos, [NativeTypeName("const lv_font_t *")] lv_font_t* font, [NativeTypeName("uint32_t")] uint letter, [NativeTypeName("lv_draw_glyph_cb_t")] delegate* unmanaged[Cdecl]<lv_draw_task_t*, lv_draw_glyph_dsc_t*, lv_draw_fill_dsc_t*, lv_area_t*, void> cb);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_draw_image_dsc_init(lv_draw_image_dsc_t* dsc);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_draw_image_dsc_t* lv_draw_task_get_image_dsc(lv_draw_task_t* task);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_draw_image(lv_layer_t* layer, [NativeTypeName("const lv_draw_image_dsc_t *")] lv_draw_image_dsc_t* dsc, [NativeTypeName("const lv_area_t *")] lv_area_t* coords);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_draw_layer(lv_layer_t* layer, [NativeTypeName("const lv_draw_image_dsc_t *")] lv_draw_image_dsc_t* dsc, [NativeTypeName("const lv_area_t *")] lv_area_t* coords);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_image_src_t lv_image_src_get_type([NativeTypeName("const void *")] void* src);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_draw_line_dsc_init(lv_draw_line_dsc_t* dsc);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_draw_line_dsc_t* lv_draw_task_get_line_dsc(lv_draw_task_t* task);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_draw_line(lv_layer_t* layer, [NativeTypeName("const lv_draw_line_dsc_t *")] lv_draw_line_dsc_t* dsc);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_draw_arc_dsc_init(lv_draw_arc_dsc_t* dsc);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_draw_arc_dsc_t* lv_draw_task_get_arc_dsc(lv_draw_task_t* task);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_draw_arc(lv_layer_t* layer, [NativeTypeName("const lv_draw_arc_dsc_t *")] lv_draw_arc_dsc_t* dsc);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_draw_arc_get_area([NativeTypeName("int32_t")] int x, [NativeTypeName("int32_t")] int y, [NativeTypeName("uint16_t")] ushort radius, [NativeTypeName("lv_value_precise_t")] int start_angle, [NativeTypeName("lv_value_precise_t")] int end_angle, [NativeTypeName("int32_t")] int w, [NativeTypeName("bool")] c_bool1 rounded, lv_area_t* area);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_draw_triangle_dsc_init(lv_draw_triangle_dsc_t* draw_dsc);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_draw_triangle_dsc_t* lv_draw_task_get_triangle_dsc(lv_draw_task_t* task);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_draw_triangle(lv_layer_t* layer, [NativeTypeName("const lv_draw_triangle_dsc_t *")] lv_draw_triangle_dsc_t* draw_dsc);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_init_draw_rect_dsc(lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part, lv_draw_rect_dsc_t* draw_dsc);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_init_draw_label_dsc(lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part, lv_draw_label_dsc_t* draw_dsc);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_init_draw_image_dsc(lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part, lv_draw_image_dsc_t* draw_dsc);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_init_draw_line_dsc(lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part, lv_draw_line_dsc_t* draw_dsc);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_init_draw_arc_dsc(lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part, lv_draw_arc_dsc_t* draw_dsc);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("int32_t")]
        public static extern int lv_obj_calculate_ext_draw_size(lv_obj_t* obj, [NativeTypeName("lv_part_t")] uint part);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_refresh_ext_draw_size(lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_obj_t* lv_obj_class_create_obj([NativeTypeName("const lv_obj_class_t *")] lv_obj_class_t* class_p, lv_obj_t* parent);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_class_init_obj(lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern c_bool1 lv_obj_is_editable(lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern c_bool1 lv_obj_is_group_def(lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_group_t* lv_group_create();

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_group_delete(lv_group_t* group);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_group_set_default(lv_group_t* group);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_group_t* lv_group_get_default();

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_group_add_obj(lv_group_t* group, lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_group_swap_obj(lv_obj_t* obj1, lv_obj_t* obj2);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_group_remove_obj(lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_group_remove_all_objs(lv_group_t* group);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_group_focus_obj(lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_group_focus_next(lv_group_t* group);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_group_focus_prev(lv_group_t* group);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_group_focus_freeze(lv_group_t* group, [NativeTypeName("bool")] c_bool1 en);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_result_t lv_group_send_data(lv_group_t* group, [NativeTypeName("uint32_t")] uint c);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_group_set_focus_cb(lv_group_t* group, [NativeTypeName("lv_group_focus_cb_t")] delegate* unmanaged[Cdecl]<lv_group_t*, void> focus_cb);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_group_set_edge_cb(lv_group_t* group, [NativeTypeName("lv_group_edge_cb_t")] delegate* unmanaged[Cdecl]<lv_group_t*, c_bool1, void> edge_cb);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_group_set_refocus_policy(lv_group_t* group, lv_group_refocus_policy_t policy);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_group_set_editing(lv_group_t* group, [NativeTypeName("bool")] c_bool1 edit);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_group_set_wrap(lv_group_t* group, [NativeTypeName("bool")] c_bool1 en);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_obj_t* lv_group_get_focused([NativeTypeName("const lv_group_t *")] lv_group_t* group);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("lv_group_focus_cb_t")]
        public static extern delegate* unmanaged[Cdecl]<lv_group_t*, void> lv_group_get_focus_cb([NativeTypeName("const lv_group_t *")] lv_group_t* group);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("lv_group_edge_cb_t")]
        public static extern delegate* unmanaged[Cdecl]<lv_group_t*, c_bool1, void> lv_group_get_edge_cb([NativeTypeName("const lv_group_t *")] lv_group_t* group);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern c_bool1 lv_group_get_editing([NativeTypeName("const lv_group_t *")] lv_group_t* group);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern c_bool1 lv_group_get_wrap(lv_group_t* group);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint32_t")]
        public static extern uint lv_group_get_obj_count(lv_group_t* group);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_obj_t* lv_group_get_obj_by_index(lv_group_t* group, [NativeTypeName("uint32_t")] uint index);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint32_t")]
        public static extern uint lv_group_get_count();

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_group_t* lv_group_by_index([NativeTypeName("uint32_t")] uint index);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_indev_t* lv_indev_create();

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_indev_delete(lv_indev_t* indev);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_indev_t* lv_indev_get_next(lv_indev_t* indev);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_indev_read(lv_indev_t* indev);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_indev_read_timer_cb(lv_timer_t* timer);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_indev_enable(lv_indev_t* indev, [NativeTypeName("bool")] c_bool1 enable);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_indev_t* lv_indev_active();

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_indev_set_type(lv_indev_t* indev, lv_indev_type_t indev_type);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_indev_set_read_cb(lv_indev_t* indev, [NativeTypeName("lv_indev_read_cb_t")] delegate* unmanaged[Cdecl]<lv_indev_t*, lv_indev_data_t*, void> read_cb);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_indev_set_user_data(lv_indev_t* indev, void* user_data);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_indev_set_driver_data(lv_indev_t* indev, void* driver_data);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_indev_set_display(lv_indev_t* indev, [NativeTypeName("struct _lv_display_t *")] lv_display_t* disp);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_indev_set_long_press_time(lv_indev_t* indev, [NativeTypeName("uint16_t")] ushort long_press_time);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_indev_set_long_press_repeat_time(lv_indev_t* indev, [NativeTypeName("uint16_t")] ushort long_press_repeat_time);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_indev_set_scroll_limit(lv_indev_t* indev, [NativeTypeName("uint8_t")] byte scroll_limit);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_indev_set_scroll_throw(lv_indev_t* indev, [NativeTypeName("uint8_t")] byte scroll_throw);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_indev_type_t lv_indev_get_type([NativeTypeName("const lv_indev_t *")] lv_indev_t* indev);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("lv_indev_read_cb_t")]
        public static extern delegate* unmanaged[Cdecl]<lv_indev_t*, lv_indev_data_t*, void> lv_indev_get_read_cb(lv_indev_t* indev);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_indev_state_t lv_indev_get_state([NativeTypeName("const lv_indev_t *")] lv_indev_t* indev);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_group_t* lv_indev_get_group([NativeTypeName("const lv_indev_t *")] lv_indev_t* indev);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_display_t* lv_indev_get_display([NativeTypeName("const lv_indev_t *")] lv_indev_t* indev);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* lv_indev_get_user_data([NativeTypeName("const lv_indev_t *")] lv_indev_t* indev);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* lv_indev_get_driver_data([NativeTypeName("const lv_indev_t *")] lv_indev_t* indev);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern c_bool1 lv_indev_get_press_moved([NativeTypeName("const lv_indev_t *")] lv_indev_t* indev);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_indev_reset(lv_indev_t* indev, lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_indev_stop_processing(lv_indev_t* indev);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_indev_reset_long_press(lv_indev_t* indev);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_indev_set_cursor(lv_indev_t* indev, lv_obj_t* cur_obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_indev_set_group(lv_indev_t* indev, lv_group_t* group);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_indev_set_button_points(lv_indev_t* indev, [NativeTypeName("const lv_point_t[]")] lv_point_t* points);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_indev_get_point([NativeTypeName("const lv_indev_t *")] lv_indev_t* indev, lv_point_t* point);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_dir_t lv_indev_get_gesture_dir([NativeTypeName("const lv_indev_t *")] lv_indev_t* indev);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint32_t")]
        public static extern uint lv_indev_get_key([NativeTypeName("const lv_indev_t *")] lv_indev_t* indev);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint8_t")]
        public static extern byte lv_indev_get_short_click_streak([NativeTypeName("const lv_indev_t *")] lv_indev_t* indev);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_dir_t lv_indev_get_scroll_dir([NativeTypeName("const lv_indev_t *")] lv_indev_t* indev);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_obj_t* lv_indev_get_scroll_obj([NativeTypeName("const lv_indev_t *")] lv_indev_t* indev);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_indev_get_vect([NativeTypeName("const lv_indev_t *")] lv_indev_t* indev, lv_point_t* point);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_obj_t* lv_indev_get_cursor(lv_indev_t* indev);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_indev_wait_release(lv_indev_t* indev);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_obj_t* lv_indev_get_active_obj();

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_timer_t* lv_indev_get_read_timer(lv_indev_t* indev);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_indev_set_mode(lv_indev_t* indev, lv_indev_mode_t mode);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_indev_mode_t lv_indev_get_mode(lv_indev_t* indev);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_obj_t* lv_indev_search_obj(lv_obj_t* obj, lv_point_t* point);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_indev_add_event_cb(lv_indev_t* indev, [NativeTypeName("lv_event_cb_t")] delegate* unmanaged[Cdecl]<lv_event_t*, void> event_cb, lv_event_code_t filter, void* user_data);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint32_t")]
        public static extern uint lv_indev_get_event_count(lv_indev_t* indev);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_event_dsc_t* lv_indev_get_event_dsc(lv_indev_t* indev, [NativeTypeName("uint32_t")] uint index);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern c_bool1 lv_indev_remove_event(lv_indev_t* indev, [NativeTypeName("uint32_t")] uint index);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint32_t")]
        public static extern uint lv_indev_remove_event_cb_with_user_data(lv_indev_t* indev, [NativeTypeName("lv_event_cb_t")] delegate* unmanaged[Cdecl]<lv_event_t*, void> event_cb, void* user_data);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_result_t lv_indev_send_event(lv_indev_t* indev, lv_event_code_t code, void* param2);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_result_t lv_obj_send_event(lv_obj_t* obj, lv_event_code_t event_code, void* param2);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_result_t lv_obj_event_base([NativeTypeName("const lv_obj_class_t *")] lv_obj_class_t* class_p, lv_event_t* e);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_obj_t* lv_event_get_current_target_obj(lv_event_t* e);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_obj_t* lv_event_get_target_obj(lv_event_t* e);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_event_dsc_t* lv_obj_add_event_cb(lv_obj_t* obj, [NativeTypeName("lv_event_cb_t")] delegate* unmanaged[Cdecl]<lv_event_t*, void> event_cb, lv_event_code_t filter, void* user_data);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint32_t")]
        public static extern uint lv_obj_get_event_count(lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_event_dsc_t* lv_obj_get_event_dsc(lv_obj_t* obj, [NativeTypeName("uint32_t")] uint index);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern c_bool1 lv_obj_remove_event(lv_obj_t* obj, [NativeTypeName("uint32_t")] uint index);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern c_bool1 lv_obj_remove_event_dsc(lv_obj_t* obj, lv_event_dsc_t* dsc);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint32_t")]
        public static extern uint lv_obj_remove_event_cb(lv_obj_t* obj, [NativeTypeName("lv_event_cb_t")] delegate* unmanaged[Cdecl]<lv_event_t*, void> event_cb);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint32_t")]
        public static extern uint lv_obj_remove_event_cb_with_user_data(lv_obj_t* obj, [NativeTypeName("lv_event_cb_t")] delegate* unmanaged[Cdecl]<lv_event_t*, void> event_cb, void* user_data);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_indev_t* lv_event_get_indev(lv_event_t* e);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_layer_t* lv_event_get_layer(lv_event_t* e);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const lv_area_t *")]
        public static extern lv_area_t* lv_event_get_old_size(lv_event_t* e);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint32_t")]
        public static extern uint lv_event_get_key(lv_event_t* e);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("int32_t")]
        public static extern int lv_event_get_rotary_diff(lv_event_t* e);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_anim_t* lv_event_get_scroll_anim(lv_event_t* e);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_event_set_ext_draw_size(lv_event_t* e, [NativeTypeName("int32_t")] int size);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_point_t* lv_event_get_self_size_info(lv_event_t* e);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_hit_test_info_t* lv_event_get_hit_test_info(lv_event_t* e);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const lv_area_t *")]
        public static extern lv_area_t* lv_event_get_cover_area(lv_event_t* e);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_event_set_cover_res(lv_event_t* e, lv_cover_res_t res);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_draw_task_t* lv_event_get_draw_task(lv_event_t* e);

        public const int LV_STATE_DEFAULT = 0x0000;
        public const int LV_STATE_CHECKED = 0x0001;
        public const int LV_STATE_FOCUSED = 0x0002;
        public const int LV_STATE_FOCUS_KEY = 0x0004;
        public const int LV_STATE_EDITED = 0x0008;
        public const int LV_STATE_HOVERED = 0x0010;
        public const int LV_STATE_PRESSED = 0x0020;
        public const int LV_STATE_SCROLLED = 0x0040;
        public const int LV_STATE_DISABLED = 0x0080;
        public const int LV_STATE_USER_1 = 0x1000;
        public const int LV_STATE_USER_2 = 0x2000;
        public const int LV_STATE_USER_3 = 0x4000;
        public const int LV_STATE_USER_4 = 0x8000;
        public const int LV_STATE_ANY = 0xFFFF;

        public const int LV_PART_MAIN = 0x000000;
        public const int LV_PART_SCROLLBAR = 0x010000;
        public const int LV_PART_INDICATOR = 0x020000;
        public const int LV_PART_KNOB = 0x030000;
        public const int LV_PART_SELECTED = 0x040000;
        public const int LV_PART_ITEMS = 0x050000;
        public const int LV_PART_CURSOR = 0x060000;
        public const int LV_PART_CUSTOM_FIRST = 0x080000;
        public const int LV_PART_ANY = 0x0F0000;

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_obj_t* lv_obj_create(lv_obj_t* parent);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_add_flag(lv_obj_t* obj, lv_obj_flag_t f);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_remove_flag(lv_obj_t* obj, lv_obj_flag_t f);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_set_flag(lv_obj_t* obj, lv_obj_flag_t f, [NativeTypeName("bool")] c_bool1 v);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_add_state(lv_obj_t* obj, [NativeTypeName("lv_state_t")] ushort state);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_remove_state(lv_obj_t* obj, [NativeTypeName("lv_state_t")] ushort state);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_set_state(lv_obj_t* obj, [NativeTypeName("lv_state_t")] ushort state, [NativeTypeName("bool")] c_bool1 v);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_set_user_data(lv_obj_t* obj, void* user_data);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern c_bool1 lv_obj_has_flag([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, lv_obj_flag_t f);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern c_bool1 lv_obj_has_flag_any([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, lv_obj_flag_t f);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("lv_state_t")]
        public static extern ushort lv_obj_get_state([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern c_bool1 lv_obj_has_state([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("lv_state_t")] ushort state);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_group_t* lv_obj_get_group([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* lv_obj_get_user_data(lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_allocate_spec_attr(lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern c_bool1 lv_obj_check_type([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("const lv_obj_class_t *")] lv_obj_class_t* class_p);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern c_bool1 lv_obj_has_class([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("const lv_obj_class_t *")] lv_obj_class_t* class_p);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const lv_obj_class_t *")]
        public static extern lv_obj_class_t* lv_obj_get_class([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern c_bool1 lv_obj_is_valid([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_null_on_delete(lv_obj_t** obj_ptr);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_refr_now(lv_display_t* disp);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_redraw(lv_layer_t* layer, lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_display_refr_timer(lv_timer_t* timer);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_font_t* lv_binfont_create([NativeTypeName("const char *")] byte[] path);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_binfont_destroy(lv_font_t* font);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const void *")]
        public static extern void* lv_font_get_bitmap_fmt_txt(lv_font_glyph_dsc_t* g_dsc, lv_draw_buf_t* draw_buf);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern c_bool1 lv_font_get_glyph_dsc_fmt_txt([NativeTypeName("const lv_font_t *")] lv_font_t* font, lv_font_glyph_dsc_t* dsc_out, [NativeTypeName("uint32_t")] uint unicode_letter, [NativeTypeName("uint32_t")] uint unicode_letter_next);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_obj_t* lv_image_create(lv_obj_t* parent);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_image_set_src(lv_obj_t* obj, [NativeTypeName("const void *")] void* src);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_image_set_offset_x(lv_obj_t* obj, [NativeTypeName("int32_t")] int x);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_image_set_offset_y(lv_obj_t* obj, [NativeTypeName("int32_t")] int y);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_image_set_rotation(lv_obj_t* obj, [NativeTypeName("int32_t")] int angle);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_image_set_pivot(lv_obj_t* obj, [NativeTypeName("int32_t")] int x, [NativeTypeName("int32_t")] int y);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_image_set_scale(lv_obj_t* obj, [NativeTypeName("uint32_t")] uint zoom);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_image_set_scale_x(lv_obj_t* obj, [NativeTypeName("uint32_t")] uint zoom);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_image_set_scale_y(lv_obj_t* obj, [NativeTypeName("uint32_t")] uint zoom);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_image_set_blend_mode(lv_obj_t* obj, lv_blend_mode_t blend_mode);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_image_set_antialias(lv_obj_t* obj, [NativeTypeName("bool")] c_bool1 antialias);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_image_set_inner_align(lv_obj_t* obj, lv_image_align_t align);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_image_set_bitmap_map_src(lv_obj_t* obj, [NativeTypeName("const lv_image_dsc_t *")] lv_image_dsc_t* src);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const void *")]
        public static extern void* lv_image_get_src(lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("int32_t")]
        public static extern int lv_image_get_offset_x(lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("int32_t")]
        public static extern int lv_image_get_offset_y(lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("int32_t")]
        public static extern int lv_image_get_rotation(lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_image_get_pivot(lv_obj_t* obj, lv_point_t* pivot);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("int32_t")]
        public static extern int lv_image_get_scale(lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("int32_t")]
        public static extern int lv_image_get_scale_x(lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("int32_t")]
        public static extern int lv_image_get_scale_y(lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("int32_t")]
        public static extern int lv_image_get_src_width(lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("int32_t")]
        public static extern int lv_image_get_src_height(lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("int32_t")]
        public static extern int lv_image_get_transformed_width(lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("int32_t")]
        public static extern int lv_image_get_transformed_height(lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_blend_mode_t lv_image_get_blend_mode(lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern c_bool1 lv_image_get_antialias(lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_image_align_t lv_image_get_inner_align(lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const lv_image_dsc_t *")]
        public static extern lv_image_dsc_t* lv_image_get_bitmap_map_src(lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_obj_t* lv_animimg_create(lv_obj_t* parent);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_animimg_set_src(lv_obj_t* obj, [NativeTypeName("const void *[]")] void** dsc, [NativeTypeName("size_t")] nuint num);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_animimg_set_src_reverse(lv_obj_t* obj, [NativeTypeName("const void *[]")] void** dsc, [NativeTypeName("size_t")] nuint num);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_animimg_start(lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern c_bool1 lv_animimg_delete(lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_animimg_set_duration(lv_obj_t* obj, [NativeTypeName("uint32_t")] uint duration);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_animimg_set_repeat_count(lv_obj_t* obj, [NativeTypeName("uint32_t")] uint count);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_animimg_set_reverse_duration(lv_obj_t* obj, [NativeTypeName("uint32_t")] uint duration);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_animimg_set_reverse_delay(lv_obj_t* obj, [NativeTypeName("uint32_t")] uint duration);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_animimg_set_start_cb(lv_obj_t* obj, [NativeTypeName("lv_anim_start_cb_t")] delegate* unmanaged[Cdecl]<lv_anim_t*, void> start_cb);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_animimg_set_completed_cb(lv_obj_t* obj, [NativeTypeName("lv_anim_completed_cb_t")] delegate* unmanaged[Cdecl]<lv_anim_t*, void> completed_cb);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const void **")]
        public static extern void** lv_animimg_get_src(lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint8_t")]
        public static extern byte lv_animimg_get_src_count(lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint32_t")]
        public static extern uint lv_animimg_get_duration(lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint32_t")]
        public static extern uint lv_animimg_get_repeat_count(lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_anim_t* lv_animimg_get_anim(lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_obj_t* lv_arc_create(lv_obj_t* parent);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_arc_set_start_angle(lv_obj_t* obj, [NativeTypeName("lv_value_precise_t")] int start);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_arc_set_end_angle(lv_obj_t* obj, [NativeTypeName("lv_value_precise_t")] int end);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_arc_set_angles(lv_obj_t* obj, [NativeTypeName("lv_value_precise_t")] int start, [NativeTypeName("lv_value_precise_t")] int end);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_arc_set_bg_start_angle(lv_obj_t* obj, [NativeTypeName("lv_value_precise_t")] int start);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_arc_set_bg_end_angle(lv_obj_t* obj, [NativeTypeName("lv_value_precise_t")] int end);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_arc_set_bg_angles(lv_obj_t* obj, [NativeTypeName("lv_value_precise_t")] int start, [NativeTypeName("lv_value_precise_t")] int end);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_arc_set_rotation(lv_obj_t* obj, [NativeTypeName("int32_t")] int rotation);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_arc_set_mode(lv_obj_t* obj, lv_arc_mode_t type);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_arc_set_value(lv_obj_t* obj, [NativeTypeName("int32_t")] int value);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_arc_set_range(lv_obj_t* obj, [NativeTypeName("int32_t")] int min, [NativeTypeName("int32_t")] int max);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_arc_set_change_rate(lv_obj_t* obj, [NativeTypeName("uint32_t")] uint rate);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_arc_set_knob_offset(lv_obj_t* obj, [NativeTypeName("int32_t")] int offset);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("lv_value_precise_t")]
        public static extern int lv_arc_get_angle_start(lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("lv_value_precise_t")]
        public static extern int lv_arc_get_angle_end(lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("lv_value_precise_t")]
        public static extern int lv_arc_get_bg_angle_start(lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("lv_value_precise_t")]
        public static extern int lv_arc_get_bg_angle_end(lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("int32_t")]
        public static extern int lv_arc_get_value([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("int32_t")]
        public static extern int lv_arc_get_min_value([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("int32_t")]
        public static extern int lv_arc_get_max_value([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_arc_mode_t lv_arc_get_mode([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("int32_t")]
        public static extern int lv_arc_get_rotation([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("int32_t")]
        public static extern int lv_arc_get_knob_offset([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_arc_align_obj_to_angle([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, lv_obj_t* obj_to_align, [NativeTypeName("int32_t")] int r_offset);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_arc_rotate_obj_to_angle([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, lv_obj_t* obj_to_rotate, [NativeTypeName("int32_t")] int r_offset);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_obj_t* lv_label_create(lv_obj_t* parent);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_label_set_text(lv_obj_t* obj, [NativeTypeName("const char *")] byte[] text);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_label_set_text_fmt(lv_obj_t* obj, [NativeTypeName("const char *")] byte[] fmt, __arglist);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_label_set_text_static(lv_obj_t* obj, [NativeTypeName("const char *")] byte[] text);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_label_set_long_mode(lv_obj_t* obj, lv_label_long_mode_t long_mode);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_label_set_text_selection_start(lv_obj_t* obj, [NativeTypeName("uint32_t")] uint index);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_label_set_text_selection_end(lv_obj_t* obj, [NativeTypeName("uint32_t")] uint index);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_label_set_recolor(lv_obj_t* obj, [NativeTypeName("bool")] c_bool1 en);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* lv_label_get_text([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_label_long_mode_t lv_label_get_long_mode([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_label_get_letter_pos([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("uint32_t")] uint char_id, lv_point_t* pos);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint32_t")]
        public static extern uint lv_label_get_letter_on([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, lv_point_t* pos_in, [NativeTypeName("bool")] c_bool1 bidi);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern c_bool1 lv_label_is_char_under_pos([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, lv_point_t* pos);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint32_t")]
        public static extern uint lv_label_get_text_selection_start([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint32_t")]
        public static extern uint lv_label_get_text_selection_end([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern c_bool1 lv_label_get_recolor([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_label_ins_text(lv_obj_t* obj, [NativeTypeName("uint32_t")] uint pos, [NativeTypeName("const char *")] byte[] txt);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_label_cut_text(lv_obj_t* obj, [NativeTypeName("uint32_t")] uint pos, [NativeTypeName("uint32_t")] uint cnt);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_obj_t* lv_bar_create(lv_obj_t* parent);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_bar_set_value(lv_obj_t* obj, [NativeTypeName("int32_t")] int value, [NativeTypeName("lv_anim_enable_t")] c_bool1 anim);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_bar_set_start_value(lv_obj_t* obj, [NativeTypeName("int32_t")] int start_value, [NativeTypeName("lv_anim_enable_t")] c_bool1 anim);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_bar_set_range(lv_obj_t* obj, [NativeTypeName("int32_t")] int min, [NativeTypeName("int32_t")] int max);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_bar_set_mode(lv_obj_t* obj, lv_bar_mode_t mode);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_bar_set_orientation(lv_obj_t* obj, lv_bar_orientation_t orientation);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("int32_t")]
        public static extern int lv_bar_get_value([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("int32_t")]
        public static extern int lv_bar_get_start_value([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("int32_t")]
        public static extern int lv_bar_get_min_value([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("int32_t")]
        public static extern int lv_bar_get_max_value([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_bar_mode_t lv_bar_get_mode(lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_bar_orientation_t lv_bar_get_orientation(lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern c_bool1 lv_bar_is_symmetrical(lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_obj_t* lv_button_create(lv_obj_t* parent);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_obj_t* lv_buttonmatrix_create(lv_obj_t* parent);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_buttonmatrix_set_map(lv_obj_t* obj, [NativeTypeName("const char *const[]")] sbyte** map);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_buttonmatrix_set_ctrl_map(lv_obj_t* obj, [NativeTypeName("const lv_buttonmatrix_ctrl_t[]")] lv_buttonmatrix_ctrl_t* ctrl_map);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_buttonmatrix_set_selected_button(lv_obj_t* obj, [NativeTypeName("uint32_t")] uint btn_id);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_buttonmatrix_set_button_ctrl(lv_obj_t* obj, [NativeTypeName("uint32_t")] uint btn_id, lv_buttonmatrix_ctrl_t ctrl);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_buttonmatrix_clear_button_ctrl(lv_obj_t* obj, [NativeTypeName("uint32_t")] uint btn_id, lv_buttonmatrix_ctrl_t ctrl);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_buttonmatrix_set_button_ctrl_all(lv_obj_t* obj, lv_buttonmatrix_ctrl_t ctrl);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_buttonmatrix_clear_button_ctrl_all(lv_obj_t* obj, lv_buttonmatrix_ctrl_t ctrl);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_buttonmatrix_set_button_width(lv_obj_t* obj, [NativeTypeName("uint32_t")] uint btn_id, [NativeTypeName("uint32_t")] uint width);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_buttonmatrix_set_one_checked(lv_obj_t* obj, [NativeTypeName("bool")] c_bool1 en);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *const *")]
        public static extern sbyte** lv_buttonmatrix_get_map([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint32_t")]
        public static extern uint lv_buttonmatrix_get_selected_button([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern byte[] lv_buttonmatrix_get_button_text([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("uint32_t")] uint btn_id);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern c_bool1 lv_buttonmatrix_has_button_ctrl(lv_obj_t* obj, [NativeTypeName("uint32_t")] uint btn_id, lv_buttonmatrix_ctrl_t ctrl);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern c_bool1 lv_buttonmatrix_get_one_checked([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_obj_t* lv_calendar_create(lv_obj_t* parent);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_calendar_set_today_date(lv_obj_t* obj, [NativeTypeName("uint32_t")] uint year, [NativeTypeName("uint32_t")] uint month, [NativeTypeName("uint32_t")] uint day);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_calendar_set_month_shown(lv_obj_t* obj, [NativeTypeName("uint32_t")] uint year, [NativeTypeName("uint32_t")] uint month);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_calendar_set_highlighted_dates(lv_obj_t* obj, [NativeTypeName("lv_calendar_date_t[]")] lv_calendar_date_t* highlighted, [NativeTypeName("size_t")] nuint date_num);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_calendar_set_day_names(lv_obj_t* obj, [NativeTypeName("const char **")] byte[]* day_names);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_obj_t* lv_calendar_get_btnmatrix([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const lv_calendar_date_t *")]
        public static extern lv_calendar_date_t* lv_calendar_get_today_date([NativeTypeName("const lv_obj_t *")] lv_obj_t* calendar);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const lv_calendar_date_t *")]
        public static extern lv_calendar_date_t* lv_calendar_get_showed_date([NativeTypeName("const lv_obj_t *")] lv_obj_t* calendar);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_calendar_date_t* lv_calendar_get_highlighted_dates([NativeTypeName("const lv_obj_t *")] lv_obj_t* calendar);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern nuint lv_calendar_get_highlighted_dates_num([NativeTypeName("const lv_obj_t *")] lv_obj_t* calendar);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_result_t lv_calendar_get_pressed_date([NativeTypeName("const lv_obj_t *")] lv_obj_t* calendar, lv_calendar_date_t* date);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_obj_t* lv_calendar_add_header_arrow(lv_obj_t* parent);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_obj_t* lv_calendar_add_header_dropdown(lv_obj_t* parent);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_calendar_header_dropdown_set_year_list(lv_obj_t* parent, [NativeTypeName("const char *")] byte[] years_list);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_obj_t* lv_canvas_create(lv_obj_t* parent);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_canvas_set_buffer(lv_obj_t* obj, void* buf, [NativeTypeName("int32_t")] int w, [NativeTypeName("int32_t")] int h, lv_color_format_t cf);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_canvas_set_draw_buf(lv_obj_t* obj, lv_draw_buf_t* draw_buf);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_canvas_set_px(lv_obj_t* obj, [NativeTypeName("int32_t")] int x, [NativeTypeName("int32_t")] int y, lv_color_t color, [NativeTypeName("lv_opa_t")] byte opa);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_canvas_set_palette(lv_obj_t* obj, [NativeTypeName("uint8_t")] byte index, lv_color32_t color);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_draw_buf_t* lv_canvas_get_draw_buf(lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_color32_t lv_canvas_get_px(lv_obj_t* obj, [NativeTypeName("int32_t")] int x, [NativeTypeName("int32_t")] int y);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_image_dsc_t* lv_canvas_get_image(lv_obj_t* canvas);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const void *")]
        public static extern void* lv_canvas_get_buf(lv_obj_t* canvas);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_canvas_copy_buf(lv_obj_t* obj, [NativeTypeName("const lv_area_t *")] lv_area_t* canvas_area, lv_draw_buf_t* dest_buf, [NativeTypeName("const lv_area_t *")] lv_area_t* dest_area);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_canvas_fill_bg(lv_obj_t* obj, lv_color_t color, [NativeTypeName("lv_opa_t")] byte opa);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_canvas_init_layer(lv_obj_t* canvas, lv_layer_t* layer);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_canvas_finish_layer(lv_obj_t* canvas, lv_layer_t* layer);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint32_t")]
        public static extern uint lv_canvas_buf_size([NativeTypeName("int32_t")] int w, [NativeTypeName("int32_t")] int h, [NativeTypeName("uint8_t")] byte bpp, [NativeTypeName("uint8_t")] byte stride);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_obj_t* lv_chart_create(lv_obj_t* parent);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_chart_set_type(lv_obj_t* obj, lv_chart_type_t type);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_chart_set_point_count(lv_obj_t* obj, [NativeTypeName("uint32_t")] uint cnt);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_chart_set_axis_range(lv_obj_t* obj, lv_chart_axis_t axis, [NativeTypeName("int32_t")] int min, [NativeTypeName("int32_t")] int max);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_chart_set_update_mode(lv_obj_t* obj, lv_chart_update_mode_t update_mode);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_chart_set_div_line_count(lv_obj_t* obj, [NativeTypeName("uint8_t")] byte hdiv, [NativeTypeName("uint8_t")] byte vdiv);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_chart_type_t lv_chart_get_type([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint32_t")]
        public static extern uint lv_chart_get_point_count([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint32_t")]
        public static extern uint lv_chart_get_x_start_point([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, lv_chart_series_t* ser);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_chart_get_point_pos_by_id(lv_obj_t* obj, lv_chart_series_t* ser, [NativeTypeName("uint32_t")] uint id, lv_point_t* p_out);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_chart_refresh(lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_chart_series_t* lv_chart_add_series(lv_obj_t* obj, lv_color_t color, lv_chart_axis_t axis);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_chart_remove_series(lv_obj_t* obj, lv_chart_series_t* series);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_chart_hide_series(lv_obj_t* chart, lv_chart_series_t* series, [NativeTypeName("bool")] c_bool1 hide);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_chart_set_series_color(lv_obj_t* chart, lv_chart_series_t* series, lv_color_t color);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_color_t lv_chart_get_series_color(lv_obj_t* chart, [NativeTypeName("const lv_chart_series_t *")] lv_chart_series_t* series);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_chart_set_x_start_point(lv_obj_t* obj, lv_chart_series_t* ser, [NativeTypeName("uint32_t")] uint id);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_chart_series_t* lv_chart_get_series_next([NativeTypeName("const lv_obj_t *")] lv_obj_t* chart, [NativeTypeName("const lv_chart_series_t *")] lv_chart_series_t* ser);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_chart_cursor_t* lv_chart_add_cursor(lv_obj_t* obj, lv_color_t color, lv_dir_t dir);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_chart_set_cursor_pos(lv_obj_t* chart, lv_chart_cursor_t* cursor, lv_point_t* pos);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_chart_set_cursor_pos_x(lv_obj_t* chart, lv_chart_cursor_t* cursor, [NativeTypeName("int32_t")] int x);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_chart_set_cursor_pos_y(lv_obj_t* chart, lv_chart_cursor_t* cursor, [NativeTypeName("int32_t")] int y);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_chart_set_cursor_point(lv_obj_t* chart, lv_chart_cursor_t* cursor, lv_chart_series_t* ser, [NativeTypeName("uint32_t")] uint point_id);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_point_t lv_chart_get_cursor_point(lv_obj_t* chart, lv_chart_cursor_t* cursor);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_chart_set_all_values(lv_obj_t* obj, lv_chart_series_t* ser, [NativeTypeName("int32_t")] int value);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_chart_set_next_value(lv_obj_t* obj, lv_chart_series_t* ser, [NativeTypeName("int32_t")] int value);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_chart_set_next_value2(lv_obj_t* obj, lv_chart_series_t* ser, [NativeTypeName("int32_t")] int x_value, [NativeTypeName("int32_t")] int y_value);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_chart_set_series_values(lv_obj_t* obj, lv_chart_series_t* ser, [NativeTypeName("const int32_t[]")] int* values, [NativeTypeName("size_t")] nuint values_cnt);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_chart_set_series_values2(lv_obj_t* obj, lv_chart_series_t* ser, [NativeTypeName("const int32_t[]")] int* x_values, [NativeTypeName("const int32_t[]")] int* y_values, [NativeTypeName("size_t")] nuint values_cnt);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_chart_set_series_value_by_id(lv_obj_t* obj, lv_chart_series_t* ser, [NativeTypeName("uint32_t")] uint id, [NativeTypeName("int32_t")] int value);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_chart_set_series_value_by_id2(lv_obj_t* obj, lv_chart_series_t* ser, [NativeTypeName("uint32_t")] uint id, [NativeTypeName("int32_t")] int x_value, [NativeTypeName("int32_t")] int y_value);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_chart_set_series_ext_y_array(lv_obj_t* obj, lv_chart_series_t* ser, [NativeTypeName("int32_t[]")] int* array);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_chart_set_series_ext_x_array(lv_obj_t* obj, lv_chart_series_t* ser, [NativeTypeName("int32_t[]")] int* array);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("int32_t *")]
        public static extern int* lv_chart_get_series_y_array([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, lv_chart_series_t* ser);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("int32_t *")]
        public static extern int* lv_chart_get_series_x_array([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, lv_chart_series_t* ser);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint32_t")]
        public static extern uint lv_chart_get_pressed_point([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("int32_t")]
        public static extern int lv_chart_get_first_point_center_offset(lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_obj_t* lv_checkbox_create(lv_obj_t* parent);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_checkbox_set_text(lv_obj_t* obj, [NativeTypeName("const char *")] byte[] txt);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_checkbox_set_text_static(lv_obj_t* obj, [NativeTypeName("const char *")] byte[] txt);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern byte[] lv_checkbox_get_text([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_obj_t* lv_dropdown_create(lv_obj_t* parent);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_dropdown_set_text(lv_obj_t* obj, [NativeTypeName("const char *")] byte[] txt);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_dropdown_set_options(lv_obj_t* obj, [NativeTypeName("const char *")] byte[] options);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_dropdown_set_options_static(lv_obj_t* obj, [NativeTypeName("const char *")] byte[] options);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_dropdown_add_option(lv_obj_t* obj, [NativeTypeName("const char *")] byte[] option, [NativeTypeName("uint32_t")] uint pos);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_dropdown_clear_options(lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_dropdown_set_selected(lv_obj_t* obj, [NativeTypeName("uint32_t")] uint sel_opt);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_dropdown_set_dir(lv_obj_t* obj, lv_dir_t dir);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_dropdown_set_symbol(lv_obj_t* obj, [NativeTypeName("const void *")] void* symbol);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_dropdown_set_selected_highlight(lv_obj_t* obj, [NativeTypeName("bool")] c_bool1 en);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_obj_t* lv_dropdown_get_list(lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern byte[] lv_dropdown_get_text(lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern byte[] lv_dropdown_get_options([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint32_t")]
        public static extern uint lv_dropdown_get_selected([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint32_t")]
        public static extern uint lv_dropdown_get_option_count([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_dropdown_get_selected_str([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("char *")] sbyte* buf, [NativeTypeName("uint32_t")] uint buf_size);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("int32_t")]
        public static extern int lv_dropdown_get_option_index(lv_obj_t* obj, [NativeTypeName("const char *")] byte[] option);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern byte[] lv_dropdown_get_symbol(lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern c_bool1 lv_dropdown_get_selected_highlight(lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_dir_t lv_dropdown_get_dir([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_dropdown_open(lv_obj_t* dropdown_obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_dropdown_close(lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern c_bool1 lv_dropdown_is_open(lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_obj_t* lv_imagebutton_create(lv_obj_t* parent);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_imagebutton_set_src(lv_obj_t* imagebutton, lv_imagebutton_state_t state, [NativeTypeName("const void *")] void* src_left, [NativeTypeName("const void *")] void* src_mid, [NativeTypeName("const void *")] void* src_right);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_imagebutton_set_state(lv_obj_t* imagebutton, lv_imagebutton_state_t state);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const void *")]
        public static extern void* lv_imagebutton_get_src_left(lv_obj_t* imagebutton, lv_imagebutton_state_t state);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const void *")]
        public static extern void* lv_imagebutton_get_src_middle(lv_obj_t* imagebutton, lv_imagebutton_state_t state);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const void *")]
        public static extern void* lv_imagebutton_get_src_right(lv_obj_t* imagebutton, lv_imagebutton_state_t state);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_obj_t* lv_keyboard_create(lv_obj_t* parent);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_keyboard_set_textarea(lv_obj_t* kb, lv_obj_t* ta);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_keyboard_set_mode(lv_obj_t* kb, lv_keyboard_mode_t mode);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_keyboard_set_popovers(lv_obj_t* kb, [NativeTypeName("bool")] c_bool1 en);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_keyboard_set_map(lv_obj_t* kb, lv_keyboard_mode_t mode, [NativeTypeName("const char *const[]")] sbyte** map, [NativeTypeName("const lv_buttonmatrix_ctrl_t[]")] lv_buttonmatrix_ctrl_t* ctrl_map);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_obj_t* lv_keyboard_get_textarea([NativeTypeName("const lv_obj_t *")] lv_obj_t* kb);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_keyboard_mode_t lv_keyboard_get_mode([NativeTypeName("const lv_obj_t *")] lv_obj_t* kb);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern c_bool1 lv_keyboard_get_popovers([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *const *")]
        public static extern sbyte** lv_keyboard_get_map_array([NativeTypeName("const lv_obj_t *")] lv_obj_t* kb);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint32_t")]
        public static extern uint lv_keyboard_get_selected_button([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern byte[] lv_keyboard_get_button_text([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("uint32_t")] uint btn_id);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_keyboard_def_event_cb(lv_event_t* e);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_obj_t* lv_led_create(lv_obj_t* parent);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_led_set_color(lv_obj_t* led, lv_color_t color);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_led_set_brightness(lv_obj_t* led, [NativeTypeName("uint8_t")] byte bright);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_led_on(lv_obj_t* led);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_led_off(lv_obj_t* led);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_led_toggle(lv_obj_t* led);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint8_t")]
        public static extern byte lv_led_get_brightness([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_obj_t* lv_line_create(lv_obj_t* parent);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_line_set_points(lv_obj_t* obj, [NativeTypeName("const lv_point_precise_t[]")] lv_point_precise_t* points, [NativeTypeName("uint32_t")] uint point_num);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_line_set_points_mutable(lv_obj_t* obj, [NativeTypeName("lv_point_precise_t[]")] lv_point_precise_t* points, [NativeTypeName("uint32_t")] uint point_num);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_line_set_y_invert(lv_obj_t* obj, [NativeTypeName("bool")] c_bool1 en);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const lv_point_precise_t *")]
        public static extern lv_point_precise_t* lv_line_get_points(lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint32_t")]
        public static extern uint lv_line_get_point_count(lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern c_bool1 lv_line_is_point_array_mutable(lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_point_precise_t* lv_line_get_points_mutable(lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern c_bool1 lv_line_get_y_invert([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_obj_t* lv_list_create(lv_obj_t* parent);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_obj_t* lv_list_add_text(lv_obj_t* list, [NativeTypeName("const char *")] byte[] txt);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_obj_t* lv_list_add_button(lv_obj_t* list, [NativeTypeName("const void *")] void* icon, [NativeTypeName("const char *")] byte[] txt);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern byte[] lv_list_get_button_text(lv_obj_t* list, lv_obj_t* btn);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_list_set_button_text(lv_obj_t* list, lv_obj_t* btn, [NativeTypeName("const char *")] byte[] txt);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_obj_t* lv_menu_create(lv_obj_t* parent);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_obj_t* lv_menu_page_create(lv_obj_t* menu, [NativeTypeName("const char *const")] sbyte* title);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_obj_t* lv_menu_cont_create(lv_obj_t* parent);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_obj_t* lv_menu_section_create(lv_obj_t* parent);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_obj_t* lv_menu_separator_create(lv_obj_t* parent);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_menu_set_page(lv_obj_t* obj, lv_obj_t* page);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_menu_set_page_title(lv_obj_t* page, [NativeTypeName("const char *const")] sbyte* title);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_menu_set_page_title_static(lv_obj_t* page, [NativeTypeName("const char *const")] sbyte* title);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_menu_set_sidebar_page(lv_obj_t* obj, lv_obj_t* page);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_menu_set_mode_header(lv_obj_t* obj, lv_menu_mode_header_t mode);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_menu_set_mode_root_back_button(lv_obj_t* obj, lv_menu_mode_root_back_button_t mode);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_menu_set_load_page_event(lv_obj_t* menu, lv_obj_t* obj, lv_obj_t* page);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_obj_t* lv_menu_get_cur_main_page(lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_obj_t* lv_menu_get_cur_sidebar_page(lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_obj_t* lv_menu_get_main_header(lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_obj_t* lv_menu_get_main_header_back_button(lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_obj_t* lv_menu_get_sidebar_header(lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_obj_t* lv_menu_get_sidebar_header_back_button(lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern c_bool1 lv_menu_back_button_is_root(lv_obj_t* menu, lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_menu_clear_history(lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_obj_t* lv_msgbox_create(lv_obj_t* parent);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_obj_t* lv_msgbox_add_title(lv_obj_t* obj, [NativeTypeName("const char *")] byte[] title);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_obj_t* lv_msgbox_add_header_button(lv_obj_t* obj, [NativeTypeName("const void *")] void* icon);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_obj_t* lv_msgbox_add_text(lv_obj_t* obj, [NativeTypeName("const char *")] byte[] text);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_obj_t* lv_msgbox_add_footer_button(lv_obj_t* obj, [NativeTypeName("const char *")] byte[] text);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_obj_t* lv_msgbox_add_close_button(lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_obj_t* lv_msgbox_get_header(lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_obj_t* lv_msgbox_get_footer(lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_obj_t* lv_msgbox_get_content(lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_obj_t* lv_msgbox_get_title(lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_msgbox_close(lv_obj_t* mbox);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_msgbox_close_async(lv_obj_t* mbox);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_obj_t* lv_roller_create(lv_obj_t* parent);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_roller_set_options(lv_obj_t* obj, [NativeTypeName("const char *")] byte[] options, lv_roller_mode_t mode);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_roller_set_selected(lv_obj_t* obj, [NativeTypeName("uint32_t")] uint sel_opt, [NativeTypeName("lv_anim_enable_t")] c_bool1 anim);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern c_bool1 lv_roller_set_selected_str(lv_obj_t* obj, [NativeTypeName("const char *")] byte[] sel_opt, [NativeTypeName("lv_anim_enable_t")] c_bool1 anim);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_roller_set_visible_row_count(lv_obj_t* obj, [NativeTypeName("uint32_t")] uint row_cnt);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint32_t")]
        public static extern uint lv_roller_get_selected([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_roller_get_selected_str([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("char *")] sbyte* buf, [NativeTypeName("uint32_t")] uint buf_size);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern byte[] lv_roller_get_options([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint32_t")]
        public static extern uint lv_roller_get_option_count([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_obj_t* lv_scale_create(lv_obj_t* parent);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_scale_set_mode(lv_obj_t* obj, lv_scale_mode_t mode);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_scale_set_total_tick_count(lv_obj_t* obj, [NativeTypeName("uint32_t")] uint total_tick_count);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_scale_set_major_tick_every(lv_obj_t* obj, [NativeTypeName("uint32_t")] uint major_tick_every);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_scale_set_label_show(lv_obj_t* obj, [NativeTypeName("bool")] c_bool1 show_label);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_scale_set_range(lv_obj_t* obj, [NativeTypeName("int32_t")] int min, [NativeTypeName("int32_t")] int max);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_scale_set_angle_range(lv_obj_t* obj, [NativeTypeName("uint32_t")] uint angle_range);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_scale_set_rotation(lv_obj_t* obj, [NativeTypeName("int32_t")] int rotation);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_scale_set_line_needle_value(lv_obj_t* obj, lv_obj_t* needle_line, [NativeTypeName("int32_t")] int needle_length, [NativeTypeName("int32_t")] int value);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_scale_set_image_needle_value(lv_obj_t* obj, lv_obj_t* needle_img, [NativeTypeName("int32_t")] int value);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_scale_set_text_src(lv_obj_t* obj, [NativeTypeName("const char *[]")] byte[]* txt_src);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_scale_set_post_draw(lv_obj_t* obj, [NativeTypeName("bool")] c_bool1 en);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_scale_set_draw_ticks_on_top(lv_obj_t* obj, [NativeTypeName("bool")] c_bool1 en);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_scale_section_t* lv_scale_add_section(lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_scale_section_set_range(lv_scale_section_t* section, [NativeTypeName("int32_t")] int min, [NativeTypeName("int32_t")] int max);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_scale_set_section_range(lv_obj_t* scale, lv_scale_section_t* section, [NativeTypeName("int32_t")] int min, [NativeTypeName("int32_t")] int max);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_scale_section_set_style(lv_scale_section_t* section, [NativeTypeName("lv_part_t")] uint part, lv_style_t* section_part_style);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_scale_set_section_style_main(lv_obj_t* scale, lv_scale_section_t* section, [NativeTypeName("const lv_style_t *")] lv_style_t* style);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_scale_set_section_style_indicator(lv_obj_t* scale, lv_scale_section_t* section, [NativeTypeName("const lv_style_t *")] lv_style_t* style);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_scale_set_section_style_items(lv_obj_t* scale, lv_scale_section_t* section, [NativeTypeName("const lv_style_t *")] lv_style_t* style);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_scale_mode_t lv_scale_get_mode(lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("int32_t")]
        public static extern int lv_scale_get_total_tick_count(lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("int32_t")]
        public static extern int lv_scale_get_major_tick_every(lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("int32_t")]
        public static extern int lv_scale_get_rotation(lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern c_bool1 lv_scale_get_label_show(lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint32_t")]
        public static extern uint lv_scale_get_angle_range(lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("int32_t")]
        public static extern int lv_scale_get_range_min_value(lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("int32_t")]
        public static extern int lv_scale_get_range_max_value(lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_obj_t* lv_slider_create(lv_obj_t* parent);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_slider_set_value(lv_obj_t* obj, [NativeTypeName("int32_t")] int value, [NativeTypeName("lv_anim_enable_t")] c_bool1 anim);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_slider_set_start_value(lv_obj_t* obj, [NativeTypeName("int32_t")] int value, [NativeTypeName("lv_anim_enable_t")] c_bool1 anim);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_slider_set_range(lv_obj_t* obj, [NativeTypeName("int32_t")] int min, [NativeTypeName("int32_t")] int max);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_slider_set_mode(lv_obj_t* obj, lv_slider_mode_t mode);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_slider_set_orientation(lv_obj_t* obj, lv_slider_orientation_t orientation);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("int32_t")]
        public static extern int lv_slider_get_value([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("int32_t")]
        public static extern int lv_slider_get_left_value([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("int32_t")]
        public static extern int lv_slider_get_min_value([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("int32_t")]
        public static extern int lv_slider_get_max_value([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern c_bool1 lv_slider_is_dragged([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_slider_mode_t lv_slider_get_mode(lv_obj_t* slider);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_slider_orientation_t lv_slider_get_orientation(lv_obj_t* slider);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern c_bool1 lv_slider_is_symmetrical(lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_span_stack_init();

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_span_stack_deinit();

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_obj_t* lv_spangroup_create(lv_obj_t* parent);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_span_t* lv_spangroup_add_span(lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_spangroup_delete_span(lv_obj_t* obj, lv_span_t* span);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_span_set_text(lv_span_t* span, [NativeTypeName("const char *")] byte[] text);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_spangroup_set_span_text(lv_obj_t* obj, lv_span_t* span, [NativeTypeName("const char *")] byte[] text);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_spangroup_set_span_text_static(lv_obj_t* obj, lv_span_t* span, [NativeTypeName("const char *")] byte[] text);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_spangroup_set_span_style(lv_obj_t* obj, lv_span_t* span, [NativeTypeName("const lv_style_t *")] lv_style_t* style);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_spangroup_set_align(lv_obj_t* obj, lv_text_align_t align);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_spangroup_set_overflow(lv_obj_t* obj, lv_span_overflow_t overflow);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_spangroup_set_indent(lv_obj_t* obj, [NativeTypeName("int32_t")] int indent);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_spangroup_set_mode(lv_obj_t* obj, lv_span_mode_t mode);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_spangroup_set_max_lines(lv_obj_t* obj, [NativeTypeName("int32_t")] int lines);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_style_t* lv_span_get_style(lv_span_t* span);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern byte[] lv_span_get_text(lv_span_t* span);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_span_t* lv_spangroup_get_child([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj, [NativeTypeName("int32_t")] int id);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint32_t")]
        public static extern uint lv_spangroup_get_span_count([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_text_align_t lv_spangroup_get_align(lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_span_overflow_t lv_spangroup_get_overflow(lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("int32_t")]
        public static extern int lv_spangroup_get_indent(lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_span_mode_t lv_spangroup_get_mode(lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("int32_t")]
        public static extern int lv_spangroup_get_max_lines(lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("int32_t")]
        public static extern int lv_spangroup_get_max_line_height(lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint32_t")]
        public static extern uint lv_spangroup_get_expand_width(lv_obj_t* obj, [NativeTypeName("uint32_t")] uint max_width);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("int32_t")]
        public static extern int lv_spangroup_get_expand_height(lv_obj_t* obj, [NativeTypeName("int32_t")] int width);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_span_coords_t lv_spangroup_get_span_coords(lv_obj_t* obj, [NativeTypeName("const lv_span_t *")] lv_span_t* span);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_span_t* lv_spangroup_get_span_by_point(lv_obj_t* obj, [NativeTypeName("const lv_point_t *")] lv_point_t* point);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_spangroup_refresh(lv_obj_t* obj);

        public const int LV_PART_TEXTAREA_PLACEHOLDER = LV_PART_CUSTOM_FIRST;

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_obj_t* lv_textarea_create(lv_obj_t* parent);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_textarea_add_char(lv_obj_t* obj, [NativeTypeName("uint32_t")] uint c);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_textarea_add_text(lv_obj_t* obj, [NativeTypeName("const char *")] byte[] txt);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_textarea_delete_char(lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_textarea_delete_char_forward(lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_textarea_set_text(lv_obj_t* obj, [NativeTypeName("const char *")] byte[] txt);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_textarea_set_placeholder_text(lv_obj_t* obj, [NativeTypeName("const char *")] byte[] txt);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_textarea_set_cursor_pos(lv_obj_t* obj, [NativeTypeName("int32_t")] int pos);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_textarea_set_cursor_click_pos(lv_obj_t* obj, [NativeTypeName("bool")] c_bool1 en);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_textarea_set_password_mode(lv_obj_t* obj, [NativeTypeName("bool")] c_bool1 en);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_textarea_set_password_bullet(lv_obj_t* obj, [NativeTypeName("const char *")] byte[] bullet);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_textarea_set_one_line(lv_obj_t* obj, [NativeTypeName("bool")] c_bool1 en);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_textarea_set_accepted_chars(lv_obj_t* obj, [NativeTypeName("const char *")] byte[] list);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_textarea_set_max_length(lv_obj_t* obj, [NativeTypeName("uint32_t")] uint num);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_textarea_set_insert_replace(lv_obj_t* obj, [NativeTypeName("const char *")] byte[] txt);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_textarea_set_text_selection(lv_obj_t* obj, [NativeTypeName("bool")] c_bool1 en);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_textarea_set_password_show_time(lv_obj_t* obj, [NativeTypeName("uint32_t")] uint time);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_textarea_set_align(lv_obj_t* obj, lv_text_align_t align);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern byte[] lv_textarea_get_text([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern byte[] lv_textarea_get_placeholder_text(lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_obj_t* lv_textarea_get_label([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint32_t")]
        public static extern uint lv_textarea_get_cursor_pos([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern c_bool1 lv_textarea_get_cursor_click_pos(lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern c_bool1 lv_textarea_get_password_mode([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern byte[] lv_textarea_get_password_bullet(lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern c_bool1 lv_textarea_get_one_line([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern byte[] lv_textarea_get_accepted_chars(lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint32_t")]
        public static extern uint lv_textarea_get_max_length(lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern c_bool1 lv_textarea_text_is_selected([NativeTypeName("const lv_obj_t *")] lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern c_bool1 lv_textarea_get_text_selection(lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint32_t")]
        public static extern uint lv_textarea_get_password_show_time(lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint32_t")]
        public static extern uint lv_textarea_get_current_char(lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_textarea_clear_selection(lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_textarea_cursor_right(lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_textarea_cursor_left(lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_textarea_cursor_down(lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_textarea_cursor_up(lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_obj_t* lv_spinbox_create(lv_obj_t* parent);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_spinbox_set_value(lv_obj_t* obj, [NativeTypeName("int32_t")] int v);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_spinbox_set_rollover(lv_obj_t* obj, [NativeTypeName("bool")] c_bool1 rollover);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_spinbox_set_digit_format(lv_obj_t* obj, [NativeTypeName("uint32_t")] uint digit_count, [NativeTypeName("uint32_t")] uint sep_pos);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_spinbox_set_step(lv_obj_t* obj, [NativeTypeName("uint32_t")] uint step);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_spinbox_set_range(lv_obj_t* obj, [NativeTypeName("int32_t")] int range_min, [NativeTypeName("int32_t")] int range_max);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_spinbox_set_cursor_pos(lv_obj_t* obj, [NativeTypeName("uint32_t")] uint pos);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_spinbox_set_digit_step_direction(lv_obj_t* obj, lv_dir_t direction);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern c_bool1 lv_spinbox_get_rollover(lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("int32_t")]
        public static extern int lv_spinbox_get_value(lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("int32_t")]
        public static extern int lv_spinbox_get_step(lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_spinbox_step_next(lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_spinbox_step_prev(lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_spinbox_increment(lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_spinbox_decrement(lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_obj_t* lv_spinner_create(lv_obj_t* parent);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_spinner_set_anim_params(lv_obj_t* obj, [NativeTypeName("uint32_t")] uint t, [NativeTypeName("uint32_t")] uint angle);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_obj_t* lv_switch_create(lv_obj_t* parent);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_switch_set_orientation(lv_obj_t* obj, lv_switch_orientation_t orientation);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_switch_orientation_t lv_switch_get_orientation(lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_obj_t* lv_table_create(lv_obj_t* parent);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_table_set_cell_value(lv_obj_t* obj, [NativeTypeName("uint32_t")] uint row, [NativeTypeName("uint32_t")] uint col, [NativeTypeName("const char *")] byte[] txt);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_table_set_cell_value_fmt(lv_obj_t* obj, [NativeTypeName("uint32_t")] uint row, [NativeTypeName("uint32_t")] uint col, [NativeTypeName("const char *")] byte[] fmt, __arglist);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_table_set_row_count(lv_obj_t* obj, [NativeTypeName("uint32_t")] uint row_cnt);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_table_set_column_count(lv_obj_t* obj, [NativeTypeName("uint32_t")] uint col_cnt);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_table_set_column_width(lv_obj_t* obj, [NativeTypeName("uint32_t")] uint col_id, [NativeTypeName("int32_t")] int w);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_table_set_cell_ctrl(lv_obj_t* obj, [NativeTypeName("uint32_t")] uint row, [NativeTypeName("uint32_t")] uint col, lv_table_cell_ctrl_t ctrl);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_table_clear_cell_ctrl(lv_obj_t* obj, [NativeTypeName("uint32_t")] uint row, [NativeTypeName("uint32_t")] uint col, lv_table_cell_ctrl_t ctrl);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_table_set_cell_user_data(lv_obj_t* obj, [NativeTypeName("uint16_t")] ushort row, [NativeTypeName("uint16_t")] ushort col, void* user_data);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_table_set_selected_cell(lv_obj_t* obj, [NativeTypeName("uint16_t")] ushort row, [NativeTypeName("uint16_t")] ushort col);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern byte[] lv_table_get_cell_value(lv_obj_t* obj, [NativeTypeName("uint32_t")] uint row, [NativeTypeName("uint32_t")] uint col);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint32_t")]
        public static extern uint lv_table_get_row_count(lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint32_t")]
        public static extern uint lv_table_get_column_count(lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("int32_t")]
        public static extern int lv_table_get_column_width(lv_obj_t* obj, [NativeTypeName("uint32_t")] uint col);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern c_bool1 lv_table_has_cell_ctrl(lv_obj_t* obj, [NativeTypeName("uint32_t")] uint row, [NativeTypeName("uint32_t")] uint col, lv_table_cell_ctrl_t ctrl);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_table_get_selected_cell(lv_obj_t* obj, [NativeTypeName("uint32_t *")] uint* row, [NativeTypeName("uint32_t *")] uint* col);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* lv_table_get_cell_user_data(lv_obj_t* obj, [NativeTypeName("uint16_t")] ushort row, [NativeTypeName("uint16_t")] ushort col);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_obj_t* lv_tabview_create(lv_obj_t* parent);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_obj_t* lv_tabview_add_tab(lv_obj_t* obj, [NativeTypeName("const char *")] byte[] name);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_tabview_rename_tab(lv_obj_t* obj, [NativeTypeName("uint32_t")] uint idx, [NativeTypeName("const char *")] byte[] new_name);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_tabview_set_active(lv_obj_t* obj, [NativeTypeName("uint32_t")] uint idx, [NativeTypeName("lv_anim_enable_t")] c_bool1 anim_en);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_tabview_set_tab_bar_position(lv_obj_t* obj, lv_dir_t dir);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_tabview_set_tab_bar_size(lv_obj_t* obj, [NativeTypeName("int32_t")] int size);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint32_t")]
        public static extern uint lv_tabview_get_tab_count(lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint32_t")]
        public static extern uint lv_tabview_get_tab_active(lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_obj_t* lv_tabview_get_content(lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_obj_t* lv_tabview_get_tab_bar(lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_obj_t* lv_tileview_create(lv_obj_t* parent);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_obj_t* lv_tileview_add_tile(lv_obj_t* tv, [NativeTypeName("uint8_t")] byte col_id, [NativeTypeName("uint8_t")] byte row_id, lv_dir_t dir);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_tileview_set_tile(lv_obj_t* tv, lv_obj_t* tile_obj, [NativeTypeName("lv_anim_enable_t")] c_bool1 anim_en);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_tileview_set_tile_by_index(lv_obj_t* tv, [NativeTypeName("uint32_t")] uint col_id, [NativeTypeName("uint32_t")] uint row_id, [NativeTypeName("lv_anim_enable_t")] c_bool1 anim_en);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_obj_t* lv_tileview_get_tile_active(lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_obj_t* lv_win_create(lv_obj_t* parent);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_obj_t* lv_win_add_title(lv_obj_t* win, [NativeTypeName("const char *")] byte[] txt);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_obj_t* lv_win_add_button(lv_obj_t* win, [NativeTypeName("const void *")] void* icon, [NativeTypeName("int32_t")] int btn_w);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_obj_t* lv_win_get_header(lv_obj_t* win);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_obj_t* lv_win_get_content(lv_obj_t* win);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_subject_init_int(lv_subject_t* subject, [NativeTypeName("int32_t")] int value);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_subject_set_int(lv_subject_t* subject, [NativeTypeName("int32_t")] int value);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("int32_t")]
        public static extern int lv_subject_get_int(lv_subject_t* subject);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("int32_t")]
        public static extern int lv_subject_get_previous_int(lv_subject_t* subject);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_subject_init_string(lv_subject_t* subject, [NativeTypeName("char *")] sbyte* buf, [NativeTypeName("char *")] sbyte* prev_buf, [NativeTypeName("size_t")] nuint size, [NativeTypeName("const char *")] byte[] value);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_subject_copy_string(lv_subject_t* subject, [NativeTypeName("const char *")] byte[] buf);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_subject_snprintf(lv_subject_t* subject, [NativeTypeName("const char *")] byte[] format, __arglist);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern byte[] lv_subject_get_string(lv_subject_t* subject);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern byte[] lv_subject_get_previous_string(lv_subject_t* subject);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_subject_init_pointer(lv_subject_t* subject, void* value);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_subject_set_pointer(lv_subject_t* subject, void* ptr);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const void *")]
        public static extern void* lv_subject_get_pointer(lv_subject_t* subject);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const void *")]
        public static extern void* lv_subject_get_previous_pointer(lv_subject_t* subject);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_subject_init_color(lv_subject_t* subject, lv_color_t color);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_subject_set_color(lv_subject_t* subject, lv_color_t color);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_color_t lv_subject_get_color(lv_subject_t* subject);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_color_t lv_subject_get_previous_color(lv_subject_t* subject);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_subject_init_group(lv_subject_t* group_subject, [NativeTypeName("lv_subject_t *[]")] lv_subject_t** list, [NativeTypeName("uint32_t")] uint list_len);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_subject_deinit(lv_subject_t* subject);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_subject_t* lv_subject_get_group_element(lv_subject_t* subject, [NativeTypeName("int32_t")] int index);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_observer_t* lv_subject_add_observer(lv_subject_t* subject, [NativeTypeName("lv_observer_cb_t")] delegate* unmanaged[Cdecl]<lv_observer_t*, lv_subject_t*, void> observer_cb, void* user_data);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_observer_t* lv_subject_add_observer_obj(lv_subject_t* subject, [NativeTypeName("lv_observer_cb_t")] delegate* unmanaged[Cdecl]<lv_observer_t*, lv_subject_t*, void> observer_cb, lv_obj_t* obj, void* user_data);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_observer_t* lv_subject_add_observer_with_target(lv_subject_t* subject, [NativeTypeName("lv_observer_cb_t")] delegate* unmanaged[Cdecl]<lv_observer_t*, lv_subject_t*, void> observer_cb, void* target, void* user_data);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_observer_remove(lv_observer_t* observer);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_obj_remove_from_subject(lv_obj_t* obj, lv_subject_t* subject);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* lv_observer_get_target(lv_observer_t* observer);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_obj_t* lv_observer_get_target_obj(lv_observer_t* observer);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* lv_observer_get_user_data([NativeTypeName("const lv_observer_t *")] lv_observer_t* observer);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_subject_notify(lv_subject_t* subject);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_observer_t* lv_obj_bind_flag_if_eq(lv_obj_t* obj, lv_subject_t* subject, lv_obj_flag_t flag, [NativeTypeName("int32_t")] int ref_value);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_observer_t* lv_obj_bind_flag_if_not_eq(lv_obj_t* obj, lv_subject_t* subject, lv_obj_flag_t flag, [NativeTypeName("int32_t")] int ref_value);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_observer_t* lv_obj_bind_flag_if_gt(lv_obj_t* obj, lv_subject_t* subject, lv_obj_flag_t flag, [NativeTypeName("int32_t")] int ref_value);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_observer_t* lv_obj_bind_flag_if_ge(lv_obj_t* obj, lv_subject_t* subject, lv_obj_flag_t flag, [NativeTypeName("int32_t")] int ref_value);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_observer_t* lv_obj_bind_flag_if_lt(lv_obj_t* obj, lv_subject_t* subject, lv_obj_flag_t flag, [NativeTypeName("int32_t")] int ref_value);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_observer_t* lv_obj_bind_flag_if_le(lv_obj_t* obj, lv_subject_t* subject, lv_obj_flag_t flag, [NativeTypeName("int32_t")] int ref_value);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_observer_t* lv_obj_bind_state_if_eq(lv_obj_t* obj, lv_subject_t* subject, [NativeTypeName("lv_state_t")] ushort state, [NativeTypeName("int32_t")] int ref_value);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_observer_t* lv_obj_bind_state_if_not_eq(lv_obj_t* obj, lv_subject_t* subject, [NativeTypeName("lv_state_t")] ushort state, [NativeTypeName("int32_t")] int ref_value);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_observer_t* lv_obj_bind_state_if_gt(lv_obj_t* obj, lv_subject_t* subject, [NativeTypeName("lv_state_t")] ushort state, [NativeTypeName("int32_t")] int ref_value);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_observer_t* lv_obj_bind_state_if_ge(lv_obj_t* obj, lv_subject_t* subject, [NativeTypeName("lv_state_t")] ushort state, [NativeTypeName("int32_t")] int ref_value);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_observer_t* lv_obj_bind_state_if_lt(lv_obj_t* obj, lv_subject_t* subject, [NativeTypeName("lv_state_t")] ushort state, [NativeTypeName("int32_t")] int ref_value);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_observer_t* lv_obj_bind_state_if_le(lv_obj_t* obj, lv_subject_t* subject, [NativeTypeName("lv_state_t")] ushort state, [NativeTypeName("int32_t")] int ref_value);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_observer_t* lv_obj_bind_checked(lv_obj_t* obj, lv_subject_t* subject);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_observer_t* lv_label_bind_text(lv_obj_t* obj, lv_subject_t* subject, [NativeTypeName("const char *")] byte[] fmt);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_observer_t* lv_arc_bind_value(lv_obj_t* obj, lv_subject_t* subject);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_observer_t* lv_slider_bind_value(lv_obj_t* obj, lv_subject_t* subject);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_observer_t* lv_roller_bind_value(lv_obj_t* obj, lv_subject_t* subject);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_observer_t* lv_dropdown_bind_value(lv_obj_t* obj, lv_subject_t* subject);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_bin_decoder_init();

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_result_t lv_bin_decoder_info(lv_image_decoder_t* decoder, lv_image_decoder_dsc_t* dsc, lv_image_header_t* header);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_result_t lv_bin_decoder_get_area(lv_image_decoder_t* decoder, lv_image_decoder_dsc_t* dsc, [NativeTypeName("const lv_area_t *")] lv_area_t* full_area, lv_area_t* decoded_area);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_result_t lv_bin_decoder_open(lv_image_decoder_t* decoder, lv_image_decoder_dsc_t* dsc);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_bin_decoder_close(lv_image_decoder_t* decoder, lv_image_decoder_dsc_t* dsc);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_draw_sw_i1_to_argb8888([NativeTypeName("const void *")] void* buf_i1, void* buf_argb8888, [NativeTypeName("uint32_t")] uint width, [NativeTypeName("uint32_t")] uint height, [NativeTypeName("uint32_t")] uint buf_i1_stride, [NativeTypeName("uint32_t")] uint buf_argb8888_stride, [NativeTypeName("uint32_t")] uint index0_color, [NativeTypeName("uint32_t")] uint index1_color);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_draw_sw_rgb565_swap(void* buf, [NativeTypeName("uint32_t")] uint buf_size_px);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_draw_sw_i1_invert(void* buf, [NativeTypeName("uint32_t")] uint buf_size);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_draw_sw_i1_convert_to_vtiled([NativeTypeName("const void *")] void* buf, [NativeTypeName("uint32_t")] uint buf_size, [NativeTypeName("uint32_t")] uint width, [NativeTypeName("uint32_t")] uint height, void* out_buf, [NativeTypeName("uint32_t")] uint out_buf_size, [NativeTypeName("bool")] c_bool1 bit_order_lsb);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_draw_sw_rotate([NativeTypeName("const void *")] void* src, void* dest, [NativeTypeName("int32_t")] int src_width, [NativeTypeName("int32_t")] int src_height, [NativeTypeName("int32_t")] int src_stride, [NativeTypeName("int32_t")] int dest_stride, lv_display_rotation_t rotation, lv_color_format_t color_format);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_theme_t* lv_theme_get_from_obj(lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_theme_apply(lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_theme_set_parent(lv_theme_t* new_theme, lv_theme_t* parent);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_theme_set_apply_cb(lv_theme_t* theme, [NativeTypeName("lv_theme_apply_cb_t")] delegate* unmanaged[Cdecl]<lv_theme_t*, lv_obj_t*, void> apply_cb);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const lv_font_t *")]
        public static extern lv_font_t* lv_theme_get_font_small(lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const lv_font_t *")]
        public static extern lv_font_t* lv_theme_get_font_normal(lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const lv_font_t *")]
        public static extern lv_font_t* lv_theme_get_font_large(lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_color_t lv_theme_get_color_primary(lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_color_t lv_theme_get_color_secondary(lv_obj_t* obj);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_theme_t* lv_theme_default_init(lv_display_t* disp, lv_color_t color_primary, lv_color_t color_secondary, [NativeTypeName("bool")] c_bool1 dark, [NativeTypeName("const lv_font_t *")] lv_font_t* font);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_theme_t* lv_theme_default_get();

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern c_bool1 lv_theme_default_is_inited();

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_theme_default_deinit();

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_theme_t* lv_theme_mono_init(lv_display_t* disp, [NativeTypeName("bool")] c_bool1 dark_bg, [NativeTypeName("const lv_font_t *")] lv_font_t* font);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern c_bool1 lv_theme_mono_is_inited();

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_theme_mono_deinit();

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_theme_t* lv_theme_simple_init(lv_display_t* disp);

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern c_bool1 lv_theme_simple_is_inited();

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern lv_theme_t* lv_theme_simple_get();

        [DllImport("lvgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void lv_theme_simple_deinit();

        [return: NativeTypeName("uint32_t")]
        public static uint lv_task_handler()
        {
            return lv_timer_handler();
        }

        public static void lv_obj_move_background(lv_obj_t* obj)
        {
            lv_obj_move_to_index(obj, 0);
        }

        public static int lv_version_major()
        {
            return 9;
        }

        public static int lv_version_minor()
        {
            return 3;
        }

        public static int lv_version_patch()
        {
            return 0;
        }

        [return: NativeTypeName("const char *")]
        public static byte[] lv_version_info()
        {
            return new byte[] { 0x64, 0x65, 0x76, 0x00 };
        }

        [NativeTypeName("#define LVGL_VERSION_MAJOR 9")]
        public const int LVGL_VERSION_MAJOR = 9;

        [NativeTypeName("#define LVGL_VERSION_MINOR 3")]
        public const int LVGL_VERSION_MINOR = 3;

        [NativeTypeName("#define LVGL_VERSION_PATCH 0")]
        public const int LVGL_VERSION_PATCH = 0;

        [NativeTypeName("#define LVGL_VERSION_INFO \"dev\"")]
        public static ReadOnlySpan<byte> LVGL_VERSION_INFO => new byte[] { 0x64, 0x65, 0x76, 0x00 };

        [NativeTypeName("#define LV_OS_NONE 0")]
        public const int LV_OS_NONE = 0;

        [NativeTypeName("#define LV_OS_PTHREAD 1")]
        public const int LV_OS_PTHREAD = 1;

        [NativeTypeName("#define LV_OS_FREERTOS 2")]
        public const int LV_OS_FREERTOS = 2;

        [NativeTypeName("#define LV_OS_CMSIS_RTOS2 3")]
        public const int LV_OS_CMSIS_RTOS2 = 3;

        [NativeTypeName("#define LV_OS_RTTHREAD 4")]
        public const int LV_OS_RTTHREAD = 4;

        [NativeTypeName("#define LV_OS_WINDOWS 5")]
        public const int LV_OS_WINDOWS = 5;

        [NativeTypeName("#define LV_OS_MQX 6")]
        public const int LV_OS_MQX = 6;

        [NativeTypeName("#define LV_OS_SDL2 7")]
        public const int LV_OS_SDL2 = 7;

        [NativeTypeName("#define LV_OS_CUSTOM 255")]
        public const int LV_OS_CUSTOM = 255;

        [NativeTypeName("#define LV_STDLIB_BUILTIN 0")]
        public const int LV_STDLIB_BUILTIN = 0;

        [NativeTypeName("#define LV_STDLIB_CLIB 1")]
        public const int LV_STDLIB_CLIB = 1;

        [NativeTypeName("#define LV_STDLIB_MICROPYTHON 2")]
        public const int LV_STDLIB_MICROPYTHON = 2;

        [NativeTypeName("#define LV_STDLIB_RTTHREAD 3")]
        public const int LV_STDLIB_RTTHREAD = 3;

        [NativeTypeName("#define LV_STDLIB_CUSTOM 255")]
        public const int LV_STDLIB_CUSTOM = 255;

        [NativeTypeName("#define LV_DRAW_SW_ASM_NONE 0")]
        public const int LV_DRAW_SW_ASM_NONE = 0;

        [NativeTypeName("#define LV_DRAW_SW_ASM_NEON 1")]
        public const int LV_DRAW_SW_ASM_NEON = 1;

        [NativeTypeName("#define LV_DRAW_SW_ASM_HELIUM 2")]
        public const int LV_DRAW_SW_ASM_HELIUM = 2;

        [NativeTypeName("#define LV_DRAW_SW_ASM_CUSTOM 255")]
        public const int LV_DRAW_SW_ASM_CUSTOM = 255;

        [NativeTypeName("#define LV_NEMA_HAL_CUSTOM 0")]
        public const int LV_NEMA_HAL_CUSTOM = 0;

        [NativeTypeName("#define LV_NEMA_HAL_STM32 1")]
        public const int LV_NEMA_HAL_STM32 = 1;

        [NativeTypeName("#define LV_DRAW_SW_SUPPORT_RGB565_SWAPPED 1")]
        public const int LV_DRAW_SW_SUPPORT_RGB565_SWAPPED = 1;

        [NativeTypeName("#define LV_USE_ANIMIMAGE LV_USE_ANIMIMG")]
        public const int LV_USE_ANIMIMAGE = 1;

        [NativeTypeName("#define LV_LOG_LEVEL LV_LOG_LEVEL_NONE")]
        public const int LV_LOG_LEVEL = 5;

        [NativeTypeName("#define LV_LOG_TRACE_MEM 0")]
        public const int LV_LOG_TRACE_MEM = 0;

        [NativeTypeName("#define LV_LOG_TRACE_TIMER 0")]
        public const int LV_LOG_TRACE_TIMER = 0;

        [NativeTypeName("#define LV_LOG_TRACE_INDEV 0")]
        public const int LV_LOG_TRACE_INDEV = 0;

        [NativeTypeName("#define LV_LOG_TRACE_DISP_REFR 0")]
        public const int LV_LOG_TRACE_DISP_REFR = 0;

        [NativeTypeName("#define LV_LOG_TRACE_EVENT 0")]
        public const int LV_LOG_TRACE_EVENT = 0;

        [NativeTypeName("#define LV_LOG_TRACE_OBJ_CREATE 0")]
        public const int LV_LOG_TRACE_OBJ_CREATE = 0;

        [NativeTypeName("#define LV_LOG_TRACE_LAYOUT 0")]
        public const int LV_LOG_TRACE_LAYOUT = 0;

        [NativeTypeName("#define LV_LOG_TRACE_ANIM 0")]
        public const int LV_LOG_TRACE_ANIM = 0;

        [NativeTypeName("#define LV_USE_PERF_MONITOR 0")]
        public const int LV_USE_PERF_MONITOR = 0;

        [NativeTypeName("#define LV_USE_MEM_MONITOR 0")]
        public const int LV_USE_MEM_MONITOR = 0;

        [NativeTypeName("#define LV_USE_LZ4 0")]
        public const int LV_USE_LZ4 = 0;

        [NativeTypeName("#define LV_USE_THORVG 0")]
        public const int LV_USE_THORVG = 0;

        [NativeTypeName("#define LV_PRId32 PRId32")]
        public static ReadOnlySpan<byte> LV_PRId32 => new byte[] { 0x64, 0x00 };

        [NativeTypeName("#define LV_PRIu32 PRIu32")]
        public static ReadOnlySpan<byte> LV_PRIu32 => new byte[] { 0x75, 0x00 };

        [NativeTypeName("#define LV_PRIx32 PRIx32")]
        public static ReadOnlySpan<byte> LV_PRIx32 => new byte[] { 0x78, 0x00 };

        [NativeTypeName("#define LV_PRIX32 PRIX32")]
        public static ReadOnlySpan<byte> LV_PRIX32 => new byte[] { 0x58, 0x00 };

        [NativeTypeName("#define LV_PRId64 PRId64")]
        public static ReadOnlySpan<byte> LV_PRId64 => new byte[] { 0x6C, 0x6C, 0x64, 0x00 };

        [NativeTypeName("#define LV_PRIu64 PRIu64")]
        public static ReadOnlySpan<byte> LV_PRIu64 => new byte[] { 0x6C, 0x6C, 0x75, 0x00 };

        [NativeTypeName("#define LV_PRIx64 PRIx64")]
        public static ReadOnlySpan<byte> LV_PRIx64 => new byte[] { 0x6C, 0x6C, 0x78, 0x00 };

        [NativeTypeName("#define LV_PRIX64 PRIX64")]
        public static ReadOnlySpan<byte> LV_PRIX64 => new byte[] { 0x6C, 0x6C, 0x58, 0x00 };

        [NativeTypeName("#define LV_LOG_LEVEL_TRACE 0")]
        public const int LV_LOG_LEVEL_TRACE = 0;

        [NativeTypeName("#define LV_LOG_LEVEL_INFO 1")]
        public const int LV_LOG_LEVEL_INFO = 1;

        [NativeTypeName("#define LV_LOG_LEVEL_WARN 2")]
        public const int LV_LOG_LEVEL_WARN = 2;

        [NativeTypeName("#define LV_LOG_LEVEL_ERROR 3")]
        public const int LV_LOG_LEVEL_ERROR = 3;

        [NativeTypeName("#define LV_LOG_LEVEL_USER 4")]
        public const int LV_LOG_LEVEL_USER = 4;

        [NativeTypeName("#define LV_LOG_LEVEL_NONE 5")]
        public const int LV_LOG_LEVEL_NONE = 5;

        [NativeTypeName("#define LV_LOG_LEVEL_NUM 5")]
        public const int LV_LOG_LEVEL_NUM = 5;

        [NativeTypeName("#define LV_NO_TIMER_READY 0xFFFFFFFF")]
        public const uint LV_NO_TIMER_READY = 0xFFFFFFFF;

        [NativeTypeName("#define LV_TRIGO_SIN_MAX 32768")]
        public const int LV_TRIGO_SIN_MAX = 32768;

        [NativeTypeName("#define LV_TRIGO_SHIFT 15")]
        public const int LV_TRIGO_SHIFT = 15;

        [NativeTypeName("#define LV_BEZIER_VAL_SHIFT 10")]
        public const int LV_BEZIER_VAL_SHIFT = 10;

        [NativeTypeName("#define LV_BEZIER_VAL_MAX (1L << LV_BEZIER_VAL_SHIFT)")]
        public const nint LV_BEZIER_VAL_MAX = (1 << 10);

        [NativeTypeName("#define LV_ARRAY_DEFAULT_CAPACITY 4")]
        public const int LV_ARRAY_DEFAULT_CAPACITY = 4;

        [NativeTypeName("#define LV_ARRAY_DEFAULT_SHRINK_RATIO 2")]
        public const int LV_ARRAY_DEFAULT_SHRINK_RATIO = 2;

        [NativeTypeName("#define LV_ANIM_REPEAT_INFINITE 0xFFFFFFFF")]
        public const uint LV_ANIM_REPEAT_INFINITE = 0xFFFFFFFF;

        [NativeTypeName("#define LV_ANIM_PLAYTIME_INFINITE 0xFFFFFFFF")]
        public const uint LV_ANIM_PLAYTIME_INFINITE = 0xFFFFFFFF;

        [NativeTypeName("#define LV_ANIM_PAUSE_FOREVER 0xFFFFFFFF")]
        public const uint LV_ANIM_PAUSE_FOREVER = 0xFFFFFFFF;

        [NativeTypeName("#define LV_ANIM_TIMELINE_PROGRESS_MAX 0xFFFF")]
        public const int LV_ANIM_TIMELINE_PROGRESS_MAX = 0xFFFF;

        [NativeTypeName("#define LV_COORD_TYPE_SHIFT (29U)")]
        public const uint LV_COORD_TYPE_SHIFT = (29U);

        [NativeTypeName("#define LV_COLOR_NATIVE_WITH_ALPHA_SIZE 3")]
        public const int LV_COLOR_NATIVE_WITH_ALPHA_SIZE = 3;

        [NativeTypeName("#define LV_OPA_MIN 2")]
        public const int LV_OPA_MIN = 2;

        [NativeTypeName("#define LV_OPA_MAX 253")]
        public const int LV_OPA_MAX = 253;

        [NativeTypeName("#define LV_IMAGE_HEADER_MAGIC (0x19)")]
        public const int LV_IMAGE_HEADER_MAGIC = (0x19);

        [NativeTypeName("#define LV_STRIDE_AUTO 0")]
        public const int LV_STRIDE_AUTO = 0;

        [NativeTypeName("#define LV_SYMBOL_BULLET \"\\xE2\\x80\\xA2\"")]
        public static ReadOnlySpan<byte> LV_SYMBOL_BULLET => new byte[] { 0xE2, 0x80, 0xA2, 0x00 };

        [NativeTypeName("#define LV_SYMBOL_AUDIO \"\\xEF\\x80\\x81\"")]
        public static ReadOnlySpan<byte> LV_SYMBOL_AUDIO => new byte[] { 0xEF, 0x80, 0x81, 0x00 };

        [NativeTypeName("#define LV_SYMBOL_VIDEO \"\\xEF\\x80\\x88\"")]
        public static ReadOnlySpan<byte> LV_SYMBOL_VIDEO => new byte[] { 0xEF, 0x80, 0x88, 0x00 };

        [NativeTypeName("#define LV_SYMBOL_LIST \"\\xEF\\x80\\x8B\"")]
        public static ReadOnlySpan<byte> LV_SYMBOL_LIST => new byte[] { 0xEF, 0x80, 0x8B, 0x00 };

        [NativeTypeName("#define LV_SYMBOL_OK \"\\xEF\\x80\\x8C\"")]
        public static ReadOnlySpan<byte> LV_SYMBOL_OK => new byte[] { 0xEF, 0x80, 0x8C, 0x00 };

        [NativeTypeName("#define LV_SYMBOL_CLOSE \"\\xEF\\x80\\x8D\"")]
        public static ReadOnlySpan<byte> LV_SYMBOL_CLOSE => new byte[] { 0xEF, 0x80, 0x8D, 0x00 };

        [NativeTypeName("#define LV_SYMBOL_POWER \"\\xEF\\x80\\x91\"")]
        public static ReadOnlySpan<byte> LV_SYMBOL_POWER => new byte[] { 0xEF, 0x80, 0x91, 0x00 };

        [NativeTypeName("#define LV_SYMBOL_SETTINGS \"\\xEF\\x80\\x93\"")]
        public static ReadOnlySpan<byte> LV_SYMBOL_SETTINGS => new byte[] { 0xEF, 0x80, 0x93, 0x00 };

        [NativeTypeName("#define LV_SYMBOL_HOME \"\\xEF\\x80\\x95\"")]
        public static ReadOnlySpan<byte> LV_SYMBOL_HOME => new byte[] { 0xEF, 0x80, 0x95, 0x00 };

        [NativeTypeName("#define LV_SYMBOL_DOWNLOAD \"\\xEF\\x80\\x99\"")]
        public static ReadOnlySpan<byte> LV_SYMBOL_DOWNLOAD => new byte[] { 0xEF, 0x80, 0x99, 0x00 };

        [NativeTypeName("#define LV_SYMBOL_DRIVE \"\\xEF\\x80\\x9C\"")]
        public static ReadOnlySpan<byte> LV_SYMBOL_DRIVE => new byte[] { 0xEF, 0x80, 0x9C, 0x00 };

        [NativeTypeName("#define LV_SYMBOL_REFRESH \"\\xEF\\x80\\xA1\"")]
        public static ReadOnlySpan<byte> LV_SYMBOL_REFRESH => new byte[] { 0xEF, 0x80, 0xA1, 0x00 };

        [NativeTypeName("#define LV_SYMBOL_MUTE \"\\xEF\\x80\\xA6\"")]
        public static ReadOnlySpan<byte> LV_SYMBOL_MUTE => new byte[] { 0xEF, 0x80, 0xA6, 0x00 };

        [NativeTypeName("#define LV_SYMBOL_VOLUME_MID \"\\xEF\\x80\\xA7\"")]
        public static ReadOnlySpan<byte> LV_SYMBOL_VOLUME_MID => new byte[] { 0xEF, 0x80, 0xA7, 0x00 };

        [NativeTypeName("#define LV_SYMBOL_VOLUME_MAX \"\\xEF\\x80\\xA8\"")]
        public static ReadOnlySpan<byte> LV_SYMBOL_VOLUME_MAX => new byte[] { 0xEF, 0x80, 0xA8, 0x00 };

        [NativeTypeName("#define LV_SYMBOL_IMAGE \"\\xEF\\x80\\xBE\"")]
        public static ReadOnlySpan<byte> LV_SYMBOL_IMAGE => new byte[] { 0xEF, 0x80, 0xBE, 0x00 };

        [NativeTypeName("#define LV_SYMBOL_TINT \"\\xEF\\x81\\x83\"")]
        public static ReadOnlySpan<byte> LV_SYMBOL_TINT => new byte[] { 0xEF, 0x81, 0x83, 0x00 };

        [NativeTypeName("#define LV_SYMBOL_PREV \"\\xEF\\x81\\x88\"")]
        public static ReadOnlySpan<byte> LV_SYMBOL_PREV => new byte[] { 0xEF, 0x81, 0x88, 0x00 };

        [NativeTypeName("#define LV_SYMBOL_PLAY \"\\xEF\\x81\\x8B\"")]
        public static ReadOnlySpan<byte> LV_SYMBOL_PLAY => new byte[] { 0xEF, 0x81, 0x8B, 0x00 };

        [NativeTypeName("#define LV_SYMBOL_PAUSE \"\\xEF\\x81\\x8C\"")]
        public static ReadOnlySpan<byte> LV_SYMBOL_PAUSE => new byte[] { 0xEF, 0x81, 0x8C, 0x00 };

        [NativeTypeName("#define LV_SYMBOL_STOP \"\\xEF\\x81\\x8D\"")]
        public static ReadOnlySpan<byte> LV_SYMBOL_STOP => new byte[] { 0xEF, 0x81, 0x8D, 0x00 };

        [NativeTypeName("#define LV_SYMBOL_NEXT \"\\xEF\\x81\\x91\"")]
        public static ReadOnlySpan<byte> LV_SYMBOL_NEXT => new byte[] { 0xEF, 0x81, 0x91, 0x00 };

        [NativeTypeName("#define LV_SYMBOL_EJECT \"\\xEF\\x81\\x92\"")]
        public static ReadOnlySpan<byte> LV_SYMBOL_EJECT => new byte[] { 0xEF, 0x81, 0x92, 0x00 };

        [NativeTypeName("#define LV_SYMBOL_LEFT \"\\xEF\\x81\\x93\"")]
        public static ReadOnlySpan<byte> LV_SYMBOL_LEFT => new byte[] { 0xEF, 0x81, 0x93, 0x00 };

        [NativeTypeName("#define LV_SYMBOL_RIGHT \"\\xEF\\x81\\x94\"")]
        public static ReadOnlySpan<byte> LV_SYMBOL_RIGHT => new byte[] { 0xEF, 0x81, 0x94, 0x00 };

        [NativeTypeName("#define LV_SYMBOL_PLUS \"\\xEF\\x81\\xA7\"")]
        public static ReadOnlySpan<byte> LV_SYMBOL_PLUS => new byte[] { 0xEF, 0x81, 0xA7, 0x00 };

        [NativeTypeName("#define LV_SYMBOL_MINUS \"\\xEF\\x81\\xA8\"")]
        public static ReadOnlySpan<byte> LV_SYMBOL_MINUS => new byte[] { 0xEF, 0x81, 0xA8, 0x00 };

        [NativeTypeName("#define LV_SYMBOL_EYE_OPEN \"\\xEF\\x81\\xAE\"")]
        public static ReadOnlySpan<byte> LV_SYMBOL_EYE_OPEN => new byte[] { 0xEF, 0x81, 0xAE, 0x00 };

        [NativeTypeName("#define LV_SYMBOL_EYE_CLOSE \"\\xEF\\x81\\xB0\"")]
        public static ReadOnlySpan<byte> LV_SYMBOL_EYE_CLOSE => new byte[] { 0xEF, 0x81, 0xB0, 0x00 };

        [NativeTypeName("#define LV_SYMBOL_WARNING \"\\xEF\\x81\\xB1\"")]
        public static ReadOnlySpan<byte> LV_SYMBOL_WARNING => new byte[] { 0xEF, 0x81, 0xB1, 0x00 };

        [NativeTypeName("#define LV_SYMBOL_SHUFFLE \"\\xEF\\x81\\xB4\"")]
        public static ReadOnlySpan<byte> LV_SYMBOL_SHUFFLE => new byte[] { 0xEF, 0x81, 0xB4, 0x00 };

        [NativeTypeName("#define LV_SYMBOL_UP \"\\xEF\\x81\\xB7\"")]
        public static ReadOnlySpan<byte> LV_SYMBOL_UP => new byte[] { 0xEF, 0x81, 0xB7, 0x00 };

        [NativeTypeName("#define LV_SYMBOL_DOWN \"\\xEF\\x81\\xB8\"")]
        public static ReadOnlySpan<byte> LV_SYMBOL_DOWN => new byte[] { 0xEF, 0x81, 0xB8, 0x00 };

        [NativeTypeName("#define LV_SYMBOL_LOOP \"\\xEF\\x81\\xB9\"")]
        public static ReadOnlySpan<byte> LV_SYMBOL_LOOP => new byte[] { 0xEF, 0x81, 0xB9, 0x00 };

        [NativeTypeName("#define LV_SYMBOL_DIRECTORY \"\\xEF\\x81\\xBB\"")]
        public static ReadOnlySpan<byte> LV_SYMBOL_DIRECTORY => new byte[] { 0xEF, 0x81, 0xBB, 0x00 };

        [NativeTypeName("#define LV_SYMBOL_UPLOAD \"\\xEF\\x82\\x93\"")]
        public static ReadOnlySpan<byte> LV_SYMBOL_UPLOAD => new byte[] { 0xEF, 0x82, 0x93, 0x00 };

        [NativeTypeName("#define LV_SYMBOL_CALL \"\\xEF\\x82\\x95\"")]
        public static ReadOnlySpan<byte> LV_SYMBOL_CALL => new byte[] { 0xEF, 0x82, 0x95, 0x00 };

        [NativeTypeName("#define LV_SYMBOL_CUT \"\\xEF\\x83\\x84\"")]
        public static ReadOnlySpan<byte> LV_SYMBOL_CUT => new byte[] { 0xEF, 0x83, 0x84, 0x00 };

        [NativeTypeName("#define LV_SYMBOL_COPY \"\\xEF\\x83\\x85\"")]
        public static ReadOnlySpan<byte> LV_SYMBOL_COPY => new byte[] { 0xEF, 0x83, 0x85, 0x00 };

        [NativeTypeName("#define LV_SYMBOL_SAVE \"\\xEF\\x83\\x87\"")]
        public static ReadOnlySpan<byte> LV_SYMBOL_SAVE => new byte[] { 0xEF, 0x83, 0x87, 0x00 };

        [NativeTypeName("#define LV_SYMBOL_BARS \"\\xEF\\x83\\x89\"")]
        public static ReadOnlySpan<byte> LV_SYMBOL_BARS => new byte[] { 0xEF, 0x83, 0x89, 0x00 };

        [NativeTypeName("#define LV_SYMBOL_ENVELOPE \"\\xEF\\x83\\xA0\"")]
        public static ReadOnlySpan<byte> LV_SYMBOL_ENVELOPE => new byte[] { 0xEF, 0x83, 0xA0, 0x00 };

        [NativeTypeName("#define LV_SYMBOL_CHARGE \"\\xEF\\x83\\xA7\"")]
        public static ReadOnlySpan<byte> LV_SYMBOL_CHARGE => new byte[] { 0xEF, 0x83, 0xA7, 0x00 };

        [NativeTypeName("#define LV_SYMBOL_PASTE \"\\xEF\\x83\\xAA\"")]
        public static ReadOnlySpan<byte> LV_SYMBOL_PASTE => new byte[] { 0xEF, 0x83, 0xAA, 0x00 };

        [NativeTypeName("#define LV_SYMBOL_BELL \"\\xEF\\x83\\xB3\"")]
        public static ReadOnlySpan<byte> LV_SYMBOL_BELL => new byte[] { 0xEF, 0x83, 0xB3, 0x00 };

        [NativeTypeName("#define LV_SYMBOL_KEYBOARD \"\\xEF\\x84\\x9C\"")]
        public static ReadOnlySpan<byte> LV_SYMBOL_KEYBOARD => new byte[] { 0xEF, 0x84, 0x9C, 0x00 };

        [NativeTypeName("#define LV_SYMBOL_GPS \"\\xEF\\x84\\xA4\"")]
        public static ReadOnlySpan<byte> LV_SYMBOL_GPS => new byte[] { 0xEF, 0x84, 0xA4, 0x00 };

        [NativeTypeName("#define LV_SYMBOL_FILE \"\\xEF\\x85\\x9B\"")]
        public static ReadOnlySpan<byte> LV_SYMBOL_FILE => new byte[] { 0xEF, 0x85, 0x9B, 0x00 };

        [NativeTypeName("#define LV_SYMBOL_WIFI \"\\xEF\\x87\\xAB\"")]
        public static ReadOnlySpan<byte> LV_SYMBOL_WIFI => new byte[] { 0xEF, 0x87, 0xAB, 0x00 };

        [NativeTypeName("#define LV_SYMBOL_BATTERY_FULL \"\\xEF\\x89\\x80\"")]
        public static ReadOnlySpan<byte> LV_SYMBOL_BATTERY_FULL => new byte[] { 0xEF, 0x89, 0x80, 0x00 };

        [NativeTypeName("#define LV_SYMBOL_BATTERY_3 \"\\xEF\\x89\\x81\"")]
        public static ReadOnlySpan<byte> LV_SYMBOL_BATTERY_3 => new byte[] { 0xEF, 0x89, 0x81, 0x00 };

        [NativeTypeName("#define LV_SYMBOL_BATTERY_2 \"\\xEF\\x89\\x82\"")]
        public static ReadOnlySpan<byte> LV_SYMBOL_BATTERY_2 => new byte[] { 0xEF, 0x89, 0x82, 0x00 };

        [NativeTypeName("#define LV_SYMBOL_BATTERY_1 \"\\xEF\\x89\\x83\"")]
        public static ReadOnlySpan<byte> LV_SYMBOL_BATTERY_1 => new byte[] { 0xEF, 0x89, 0x83, 0x00 };

        [NativeTypeName("#define LV_SYMBOL_BATTERY_EMPTY \"\\xEF\\x89\\x84\"")]
        public static ReadOnlySpan<byte> LV_SYMBOL_BATTERY_EMPTY => new byte[] { 0xEF, 0x89, 0x84, 0x00 };

        [NativeTypeName("#define LV_SYMBOL_USB \"\\xEF\\x8a\\x87\"")]
        public static ReadOnlySpan<byte> LV_SYMBOL_USB => new byte[] { 0xEF, 0x8A, 0x87, 0x00 };

        [NativeTypeName("#define LV_SYMBOL_BLUETOOTH \"\\xEF\\x8a\\x93\"")]
        public static ReadOnlySpan<byte> LV_SYMBOL_BLUETOOTH => new byte[] { 0xEF, 0x8A, 0x93, 0x00 };

        [NativeTypeName("#define LV_SYMBOL_TRASH \"\\xEF\\x8B\\xAD\"")]
        public static ReadOnlySpan<byte> LV_SYMBOL_TRASH => new byte[] { 0xEF, 0x8B, 0xAD, 0x00 };

        [NativeTypeName("#define LV_SYMBOL_EDIT \"\\xEF\\x8C\\x84\"")]
        public static ReadOnlySpan<byte> LV_SYMBOL_EDIT => new byte[] { 0xEF, 0x8C, 0x84, 0x00 };

        [NativeTypeName("#define LV_SYMBOL_BACKSPACE \"\\xEF\\x95\\x9A\"")]
        public static ReadOnlySpan<byte> LV_SYMBOL_BACKSPACE => new byte[] { 0xEF, 0x95, 0x9A, 0x00 };

        [NativeTypeName("#define LV_SYMBOL_SD_CARD \"\\xEF\\x9F\\x82\"")]
        public static ReadOnlySpan<byte> LV_SYMBOL_SD_CARD => new byte[] { 0xEF, 0x9F, 0x82, 0x00 };

        [NativeTypeName("#define LV_SYMBOL_NEW_LINE \"\\xEF\\xA2\\xA2\"")]
        public static ReadOnlySpan<byte> LV_SYMBOL_NEW_LINE => new byte[] { 0xEF, 0xA2, 0xA2, 0x00 };

        [NativeTypeName("#define LV_SYMBOL_DUMMY \"\\xEF\\xA3\\xBF\"")]
        public static ReadOnlySpan<byte> LV_SYMBOL_DUMMY => new byte[] { 0xEF, 0xA3, 0xBF, 0x00 };

        [NativeTypeName("#define LV_TXT_ENC_UTF8 1")]
        public const int LV_TXT_ENC_UTF8 = 1;

        [NativeTypeName("#define LV_TXT_ENC_ASCII 2")]
        public const int LV_TXT_ENC_ASCII = 2;

        [NativeTypeName("#define LV_TEXT_LEN_MAX UINT32_MAX")]
        public const uint LV_TEXT_LEN_MAX = 0xffffffffU;

        [NativeTypeName("#define LV_BIDI_LRO \"\\xE2\\x80\\xAD\"")]
        public static ReadOnlySpan<byte> LV_BIDI_LRO => new byte[] { 0xE2, 0x80, 0xAD, 0x00 };

        [NativeTypeName("#define LV_BIDI_RLO \"\\xE2\\x80\\xAE\"")]
        public static ReadOnlySpan<byte> LV_BIDI_RLO => new byte[] { 0xE2, 0x80, 0xAE, 0x00 };

        [NativeTypeName("#define LV_FLEX_COLUMN (1 << 0)")]
        public const int LV_FLEX_COLUMN = (1 << 0);

        [NativeTypeName("#define LV_FLEX_WRAP (1 << 2)")]
        public const int LV_FLEX_WRAP = (1 << 2);

        [NativeTypeName("#define LV_FLEX_REVERSE (1 << 3)")]
        public const int LV_FLEX_REVERSE = (1 << 3);

        [NativeTypeName("#define LV_STYLE_SENTINEL_VALUE 0xAABBCCDD")]
        public const uint LV_STYLE_SENTINEL_VALUE = 0xAABBCCDD;

        [NativeTypeName("#define LV_STYLE_PROP_FLAG_NONE (0)")]
        public const int LV_STYLE_PROP_FLAG_NONE = (0);

        [NativeTypeName("#define LV_STYLE_PROP_FLAG_INHERITABLE (1 << 0)")]
        public const int LV_STYLE_PROP_FLAG_INHERITABLE = (1 << 0);

        [NativeTypeName("#define LV_STYLE_PROP_FLAG_EXT_DRAW_UPDATE (1 << 1)")]
        public const int LV_STYLE_PROP_FLAG_EXT_DRAW_UPDATE = (1 << 1);

        [NativeTypeName("#define LV_STYLE_PROP_FLAG_LAYOUT_UPDATE (1 << 2)")]
        public const int LV_STYLE_PROP_FLAG_LAYOUT_UPDATE = (1 << 2);

        [NativeTypeName("#define LV_STYLE_PROP_FLAG_PARENT_LAYOUT_UPDATE (1 << 3)")]
        public const int LV_STYLE_PROP_FLAG_PARENT_LAYOUT_UPDATE = (1 << 3);

        [NativeTypeName("#define LV_STYLE_PROP_FLAG_LAYER_UPDATE (1 << 4)")]
        public const int LV_STYLE_PROP_FLAG_LAYER_UPDATE = (1 << 4);

        [NativeTypeName("#define LV_STYLE_PROP_FLAG_TRANSFORM (1 << 5)")]
        public const int LV_STYLE_PROP_FLAG_TRANSFORM = (1 << 5);

        [NativeTypeName("#define LV_STYLE_PROP_FLAG_ALL (0x3F)")]
        public const int LV_STYLE_PROP_FLAG_ALL = (0x3F);

        [NativeTypeName("#define LV_SCALE_NONE 256")]
        public const int LV_SCALE_NONE = 256;

        [NativeTypeName("#define LV_HOR_RES lv_display_get_horizontal_resolution(lv_display_get_default())")]
        public static int LV_HOR_RES => lv_display_get_horizontal_resolution(lv_display_get_default());

        [NativeTypeName("#define LV_VER_RES lv_display_get_vertical_resolution(lv_display_get_default())")]
        public static int LV_VER_RES => lv_display_get_vertical_resolution(lv_display_get_default());

        [NativeTypeName("#define LV_FS_MAX_FN_LENGTH 64")]
        public const int LV_FS_MAX_FN_LENGTH = 64;

        [NativeTypeName("#define LV_FS_MAX_PATH_LENGTH 256")]
        public const int LV_FS_MAX_PATH_LENGTH = 256;

        [NativeTypeName("#define LV_FS_CACHE_FROM_BUFFER UINT32_MAX")]
        public const uint LV_FS_CACHE_FROM_BUFFER = 0xffffffffU;

        [NativeTypeName("#define LV_DRAW_UNIT_NONE 0")]
        public const int LV_DRAW_UNIT_NONE = 0;

        [NativeTypeName("#define LV_DRAW_UNIT_IDLE -1")]
        public const int LV_DRAW_UNIT_IDLE = -1;

        [NativeTypeName("#define LV_RADIUS_CIRCLE 0x7FFF")]
        public const int LV_RADIUS_CIRCLE = 0x7FFF;

        [NativeTypeName("#define LV_DRAW_LABEL_NO_TXT_SEL (0xFFFF)")]
        public const int LV_DRAW_LABEL_NO_TXT_SEL = (0xFFFF);

        [NativeTypeName("#define LV_LABEL_DOT_NUM 3")]
        public const int LV_LABEL_DOT_NUM = 3;

        [NativeTypeName("#define LV_LABEL_POS_LAST 0xFFFF")]
        public const int LV_LABEL_POS_LAST = 0xFFFF;

        [NativeTypeName("#define LV_LABEL_TEXT_SELECTION_OFF LV_DRAW_LABEL_NO_TXT_SEL")]
        public const int LV_LABEL_TEXT_SELECTION_OFF = (0xFFFF);

        [NativeTypeName("#define LV_LABEL_DEFAULT_TEXT \"Text\"")]
        public static ReadOnlySpan<byte> LV_LABEL_DEFAULT_TEXT => new byte[] { 0x54, 0x65, 0x78, 0x74, 0x00 };

        [NativeTypeName("#define LV_BUTTONMATRIX_BUTTON_NONE 0xFFFF")]
        public const int LV_BUTTONMATRIX_BUTTON_NONE = 0xFFFF;

        [NativeTypeName("#define LV_CHART_POINT_NONE (INT32_MAX)")]
        public const int LV_CHART_POINT_NONE = (2147483647);

        [NativeTypeName("#define LV_DROPDOWN_POS_LAST 0xFFFF")]
        public const int LV_DROPDOWN_POS_LAST = 0xFFFF;

        [NativeTypeName("#define LV_KEYBOARD_CTRL_BUTTON_FLAGS (LV_BUTTONMATRIX_CTRL_NO_REPEAT | LV_BUTTONMATRIX_CTRL_CLICK_TRIG | LV_BUTTONMATRIX_CTRL_CHECKED)")]
        public const int LV_KEYBOARD_CTRL_BUTTON_FLAGS = ((int)(LV_BUTTONMATRIX_CTRL_NO_REPEAT) | (int)(LV_BUTTONMATRIX_CTRL_CLICK_TRIG) | (int)(LV_BUTTONMATRIX_CTRL_CHECKED));

        [NativeTypeName("#define LV_LED_BRIGHT_MIN 80")]
        public const int LV_LED_BRIGHT_MIN = 80;

        [NativeTypeName("#define LV_LED_BRIGHT_MAX 255")]
        public const int LV_LED_BRIGHT_MAX = 255;

        [NativeTypeName("#define LV_SCALE_TOTAL_TICK_COUNT_DEFAULT (11U)")]
        public const uint LV_SCALE_TOTAL_TICK_COUNT_DEFAULT = (11U);

        [NativeTypeName("#define LV_SCALE_MAJOR_TICK_EVERY_DEFAULT (5U)")]
        public const uint LV_SCALE_MAJOR_TICK_EVERY_DEFAULT = (5U);

        [NativeTypeName("#define LV_SCALE_LABEL_ENABLED_DEFAULT (1U)")]
        public const uint LV_SCALE_LABEL_ENABLED_DEFAULT = (1U);

        [NativeTypeName("#define LV_SCALE_LABEL_ROTATE_MATCH_TICKS 0x100000")]
        public const int LV_SCALE_LABEL_ROTATE_MATCH_TICKS = 0x100000;

        [NativeTypeName("#define LV_SCALE_LABEL_ROTATE_KEEP_UPRIGHT 0x80000")]
        public const int LV_SCALE_LABEL_ROTATE_KEEP_UPRIGHT = 0x80000;

        [NativeTypeName("#define LV_SCALE_ROTATION_ANGLE_MASK 0x7FFFF")]
        public const int LV_SCALE_ROTATION_ANGLE_MASK = 0x7FFFF;

        [NativeTypeName("#define LV_TEXTAREA_CURSOR_LAST (0x7FFF)")]
        public const int LV_TEXTAREA_CURSOR_LAST = (0x7FFF);

        [NativeTypeName("#define LV_SPINBOX_MAX_DIGIT_COUNT 10")]
        public const int LV_SPINBOX_MAX_DIGIT_COUNT = 10;

        [NativeTypeName("#define LV_SWITCH_KNOB_EXT_AREA_CORRECTION 2")]
        public const int LV_SWITCH_KNOB_EXT_AREA_CORRECTION = 2;

        [NativeTypeName("#define LV_TABLE_CELL_NONE 0XFFFF")]
        public const int LV_TABLE_CELL_NONE = 0XFFFF;

        [NativeTypeName("#define LV_FS_MAX_PATH_LEN 256")]
        public const int LV_FS_MAX_PATH_LEN = 256;

        [NativeTypeName("#define LV_DISP_ROTATION_0 LV_DISPLAY_ROTATION_0")]
        public const lv_display_rotation_t LV_DISP_ROTATION_0 = LV_DISPLAY_ROTATION_0;

        [NativeTypeName("#define LV_DISP_ROTATION_90 LV_DISPLAY_ROTATION_90")]
        public const lv_display_rotation_t LV_DISP_ROTATION_90 = LV_DISPLAY_ROTATION_90;

        [NativeTypeName("#define LV_DISP_ROTATION_180 LV_DISPLAY_ROTATION_180")]
        public const lv_display_rotation_t LV_DISP_ROTATION_180 = LV_DISPLAY_ROTATION_180;

        [NativeTypeName("#define LV_DISP_ROTATION_270 LV_DISPLAY_ROTATION_270")]
        public const lv_display_rotation_t LV_DISP_ROTATION_270 = LV_DISPLAY_ROTATION_270;

        [NativeTypeName("#define LV_DISP_RENDER_MODE_PARTIAL LV_DISPLAY_RENDER_MODE_PARTIAL")]
        public const lv_display_render_mode_t LV_DISP_RENDER_MODE_PARTIAL = LV_DISPLAY_RENDER_MODE_PARTIAL;

        [NativeTypeName("#define LV_DISP_RENDER_MODE_DIRECT LV_DISPLAY_RENDER_MODE_DIRECT")]
        public const lv_display_render_mode_t LV_DISP_RENDER_MODE_DIRECT = LV_DISPLAY_RENDER_MODE_DIRECT;

        [NativeTypeName("#define LV_DISP_RENDER_MODE_FULL LV_DISPLAY_RENDER_MODE_FULL")]
        public const lv_display_render_mode_t LV_DISP_RENDER_MODE_FULL = LV_DISPLAY_RENDER_MODE_FULL;

        [NativeTypeName("#define LV_BTNMATRIX_BTN_NONE LV_BUTTONMATRIX_BUTTON_NONE")]
        public const int LV_BTNMATRIX_BTN_NONE = 0xFFFF;

        [NativeTypeName("#define LV_BTNMATRIX_CTRL_HIDDEN LV_BUTTONMATRIX_CTRL_HIDDEN")]
        public const lv_buttonmatrix_ctrl_t LV_BTNMATRIX_CTRL_HIDDEN = LV_BUTTONMATRIX_CTRL_HIDDEN;

        [NativeTypeName("#define LV_BTNMATRIX_CTRL_NO_REPEAT LV_BUTTONMATRIX_CTRL_NO_REPEAT")]
        public const lv_buttonmatrix_ctrl_t LV_BTNMATRIX_CTRL_NO_REPEAT = LV_BUTTONMATRIX_CTRL_NO_REPEAT;

        [NativeTypeName("#define LV_BTNMATRIX_CTRL_DISABLED LV_BUTTONMATRIX_CTRL_DISABLED")]
        public const lv_buttonmatrix_ctrl_t LV_BTNMATRIX_CTRL_DISABLED = LV_BUTTONMATRIX_CTRL_DISABLED;

        [NativeTypeName("#define LV_BTNMATRIX_CTRL_CHECKABLE LV_BUTTONMATRIX_CTRL_CHECKABLE")]
        public const lv_buttonmatrix_ctrl_t LV_BTNMATRIX_CTRL_CHECKABLE = LV_BUTTONMATRIX_CTRL_CHECKABLE;

        [NativeTypeName("#define LV_BTNMATRIX_CTRL_CHECKED LV_BUTTONMATRIX_CTRL_CHECKED")]
        public const lv_buttonmatrix_ctrl_t LV_BTNMATRIX_CTRL_CHECKED = LV_BUTTONMATRIX_CTRL_CHECKED;

        [NativeTypeName("#define LV_BTNMATRIX_CTRL_CLICK_TRIG LV_BUTTONMATRIX_CTRL_CLICK_TRIG")]
        public const lv_buttonmatrix_ctrl_t LV_BTNMATRIX_CTRL_CLICK_TRIG = LV_BUTTONMATRIX_CTRL_CLICK_TRIG;

        [NativeTypeName("#define LV_BTNMATRIX_CTRL_POPOVER LV_BUTTONMATRIX_CTRL_POPOVER")]
        public const lv_buttonmatrix_ctrl_t LV_BTNMATRIX_CTRL_POPOVER = LV_BUTTONMATRIX_CTRL_POPOVER;

        [NativeTypeName("#define LV_BTNMATRIX_CTRL_CUSTOM_1 LV_BUTTONMATRIX_CTRL_CUSTOM_1")]
        public const lv_buttonmatrix_ctrl_t LV_BTNMATRIX_CTRL_CUSTOM_1 = LV_BUTTONMATRIX_CTRL_CUSTOM_1;

        [NativeTypeName("#define LV_BTNMATRIX_CTRL_CUSTOM_2 LV_BUTTONMATRIX_CTRL_CUSTOM_2")]
        public const lv_buttonmatrix_ctrl_t LV_BTNMATRIX_CTRL_CUSTOM_2 = LV_BUTTONMATRIX_CTRL_CUSTOM_2;

        [NativeTypeName("#define LV_IMGBTN_STATE_RELEASED LV_IMAGEBUTTON_STATE_RELEASED")]
        public const lv_imagebutton_state_t LV_IMGBTN_STATE_RELEASED = LV_IMAGEBUTTON_STATE_RELEASED;

        [NativeTypeName("#define LV_IMGBTN_STATE_PRESSED LV_IMAGEBUTTON_STATE_PRESSED")]
        public const lv_imagebutton_state_t LV_IMGBTN_STATE_PRESSED = LV_IMAGEBUTTON_STATE_PRESSED;

        [NativeTypeName("#define LV_IMGBTN_STATE_DISABLED LV_IMAGEBUTTON_STATE_DISABLED")]
        public const lv_imagebutton_state_t LV_IMGBTN_STATE_DISABLED = LV_IMAGEBUTTON_STATE_DISABLED;

        [NativeTypeName("#define LV_IMGBTN_STATE_CHECKED_RELEASED LV_IMAGEBUTTON_STATE_CHECKED_RELEASED")]
        public const lv_imagebutton_state_t LV_IMGBTN_STATE_CHECKED_RELEASED = LV_IMAGEBUTTON_STATE_CHECKED_RELEASED;

        [NativeTypeName("#define LV_IMGBTN_STATE_CHECKED_PRESSED LV_IMAGEBUTTON_STATE_CHECKED_PRESSED")]
        public const lv_imagebutton_state_t LV_IMGBTN_STATE_CHECKED_PRESSED = LV_IMAGEBUTTON_STATE_CHECKED_PRESSED;

        [NativeTypeName("#define LV_IMGBTN_STATE_CHECKED_DISABLED LV_IMAGEBUTTON_STATE_CHECKED_DISABLED")]
        public const lv_imagebutton_state_t LV_IMGBTN_STATE_CHECKED_DISABLED = LV_IMAGEBUTTON_STATE_CHECKED_DISABLED;

        [NativeTypeName("#define LV_RES_OK LV_RESULT_OK")]
        public const lv_result_t LV_RES_OK = LV_RESULT_OK;

        [NativeTypeName("#define LV_RES_INV LV_RESULT_INVALID")]
        public const lv_result_t LV_RES_INV = LV_RESULT_INVALID;

        [NativeTypeName("#define LV_INDEV_STATE_PR LV_INDEV_STATE_PRESSED")]
        public const lv_indev_state_t LV_INDEV_STATE_PR = LV_INDEV_STATE_PRESSED;

        [NativeTypeName("#define LV_INDEV_STATE_REL LV_INDEV_STATE_RELEASED")]
        public const lv_indev_state_t LV_INDEV_STATE_REL = LV_INDEV_STATE_RELEASED;

        [NativeTypeName("#define lv_obj_del lv_obj_delete")]
        public static delegate*<lv_obj_t*, void> lv_obj_del => &lv_obj_delete;

        [NativeTypeName("#define lv_obj_del_async lv_obj_delete_async")]
        public static delegate*<lv_obj_t*, void> lv_obj_del_async => &lv_obj_delete_async;

        [NativeTypeName("#define lv_obj_clear_flag lv_obj_remove_flag")]
        public static delegate*<lv_obj_t*, lv_obj_flag_t, void> lv_obj_clear_flag => &lv_obj_remove_flag;

        [NativeTypeName("#define lv_obj_clear_state lv_obj_remove_state")]
        public static delegate*<lv_obj_t*, ushort, void> lv_obj_clear_state => &lv_obj_remove_state;

        [NativeTypeName("#define lv_indev_set_disp lv_indev_set_display")]
        public static delegate*<lv_indev_t*, lv_display_t*, void> lv_indev_set_disp => &lv_indev_set_display;

        [NativeTypeName("#define lv_indev_get_act lv_indev_active")]
        public static delegate*<lv_indev_t*> lv_indev_get_act => &lv_indev_active;

        [NativeTypeName("#define lv_scr_act lv_screen_active")]
        public static delegate*<lv_obj_t*> lv_scr_act => &lv_screen_active;

        [NativeTypeName("#define lv_disp_remove lv_display_delete")]
        public static delegate*<lv_display_t*, void> lv_disp_remove => &lv_display_delete;

        [NativeTypeName("#define lv_disp_set_default lv_display_set_default")]
        public static delegate*<lv_display_t*, void> lv_disp_set_default => &lv_display_set_default;

        [NativeTypeName("#define lv_disp_get_default lv_display_get_default")]
        public static delegate*<lv_display_t*> lv_disp_get_default => &lv_display_get_default;

        [NativeTypeName("#define lv_disp_get_next lv_display_get_next")]
        public static delegate*<lv_display_t*, lv_display_t*> lv_disp_get_next => &lv_display_get_next;

        [NativeTypeName("#define lv_disp_set_rotation lv_display_set_rotation")]
        public static delegate*<lv_display_t*, lv_display_rotation_t, void> lv_disp_set_rotation => &lv_display_set_rotation;

        [NativeTypeName("#define lv_disp_get_hor_res lv_display_get_horizontal_resolution")]
        public static delegate*<lv_display_t*, int> lv_disp_get_hor_res => &lv_display_get_horizontal_resolution;

        [NativeTypeName("#define lv_disp_get_ver_res lv_display_get_vertical_resolution")]
        public static delegate*<lv_display_t*, int> lv_disp_get_ver_res => &lv_display_get_vertical_resolution;

        [NativeTypeName("#define lv_disp_get_physical_hor_res lv_display_get_physical_horizontal_resolution")]
        public static delegate*<lv_display_t*, int> lv_disp_get_physical_hor_res => &lv_display_get_physical_horizontal_resolution;

        [NativeTypeName("#define lv_disp_get_physical_ver_res lv_display_get_physical_vertical_resolution")]
        public static delegate*<lv_display_t*, int> lv_disp_get_physical_ver_res => &lv_display_get_physical_vertical_resolution;

        [NativeTypeName("#define lv_disp_get_offset_x lv_display_get_offset_x")]
        public static delegate*<lv_display_t*, int> lv_disp_get_offset_x => &lv_display_get_offset_x;

        [NativeTypeName("#define lv_disp_get_offset_y lv_display_get_offset_y")]
        public static delegate*<lv_display_t*, int> lv_disp_get_offset_y => &lv_display_get_offset_y;

        [NativeTypeName("#define lv_disp_get_rotation lv_display_get_rotation")]
        public static delegate*<lv_display_t*, lv_display_rotation_t> lv_disp_get_rotation => &lv_display_get_rotation;

        [NativeTypeName("#define lv_disp_get_dpi lv_display_get_dpi")]
        public static delegate*<lv_display_t*, int> lv_disp_get_dpi => &lv_display_get_dpi;

        [NativeTypeName("#define lv_disp_get_antialiasing lv_display_get_antialiasing")]
        public static delegate*<lv_display_t*, c_bool1> lv_disp_get_antialiasing => &lv_display_get_antialiasing;

        [NativeTypeName("#define lv_disp_flush_ready lv_display_flush_ready")]
        public static delegate*<lv_display_t*, void> lv_disp_flush_ready => &lv_display_flush_ready;

        [NativeTypeName("#define lv_disp_flush_is_last lv_display_flush_is_last")]
        public static delegate*<lv_display_t*, c_bool1> lv_disp_flush_is_last => &lv_display_flush_is_last;

        [NativeTypeName("#define lv_disp_get_scr_act lv_display_get_screen_active")]
        public static delegate*<lv_display_t*, lv_obj_t*> lv_disp_get_scr_act => &lv_display_get_screen_active;

        [NativeTypeName("#define lv_disp_get_scr_prev lv_display_get_screen_prev")]
        public static delegate*<lv_display_t*, lv_obj_t*> lv_disp_get_scr_prev => &lv_display_get_screen_prev;

        [NativeTypeName("#define lv_disp_load_scr lv_screen_load")]
        public static delegate*<lv_obj_t*, void> lv_disp_load_scr => &lv_screen_load;

        [NativeTypeName("#define lv_scr_load lv_screen_load")]
        public static delegate*<lv_obj_t*, void> lv_scr_load => &lv_screen_load;

        [NativeTypeName("#define lv_scr_load_anim lv_screen_load_anim")]
        public static delegate*<lv_obj_t*, lv_screen_load_anim_t, uint, uint, c_bool1, void> lv_scr_load_anim => &lv_screen_load_anim;

        [NativeTypeName("#define lv_disp_get_layer_top lv_display_get_layer_top")]
        public static delegate*<lv_display_t*, lv_obj_t*> lv_disp_get_layer_top => &lv_display_get_layer_top;

        [NativeTypeName("#define lv_disp_get_layer_sys lv_display_get_layer_sys")]
        public static delegate*<lv_display_t*, lv_obj_t*> lv_disp_get_layer_sys => &lv_display_get_layer_sys;

        [NativeTypeName("#define lv_disp_send_event lv_display_send_event")]
        public static delegate*<lv_display_t*, lv_event_code_t, void*, lv_result_t> lv_disp_send_event => &lv_display_send_event;

        [NativeTypeName("#define lv_disp_set_theme lv_display_set_theme")]
        public static delegate*<lv_display_t*, lv_theme_t*, void> lv_disp_set_theme => &lv_display_set_theme;

        [NativeTypeName("#define lv_disp_get_theme lv_display_get_theme")]
        public static delegate*<lv_display_t*, lv_theme_t*> lv_disp_get_theme => &lv_display_get_theme;

        [NativeTypeName("#define lv_disp_get_inactive_time lv_display_get_inactive_time")]
        public static delegate*<lv_display_t*, uint> lv_disp_get_inactive_time => &lv_display_get_inactive_time;

        [NativeTypeName("#define lv_disp_trig_activity lv_display_trigger_activity")]
        public static delegate*<lv_display_t*, void> lv_disp_trig_activity => &lv_display_trigger_activity;

        [NativeTypeName("#define lv_disp_enable_invalidation lv_display_enable_invalidation")]
        public static delegate*<lv_display_t*, c_bool1, void> lv_disp_enable_invalidation => &lv_display_enable_invalidation;

        [NativeTypeName("#define lv_disp_is_invalidation_enabled lv_display_is_invalidation_enabled")]
        public static delegate*<lv_display_t*, c_bool1> lv_disp_is_invalidation_enabled => &lv_display_is_invalidation_enabled;

        [NativeTypeName("#define lv_disp_refr_timer lv_display_refr_timer")]
        public static delegate*<lv_timer_t*, void> lv_disp_refr_timer => &lv_display_refr_timer;

        [NativeTypeName("#define lv_disp_get_refr_timer lv_display_get_refr_timer")]
        public static delegate*<lv_display_t*, lv_timer_t*> lv_disp_get_refr_timer => &lv_display_get_refr_timer;

        [NativeTypeName("#define lv_timer_del lv_timer_delete")]
        public static delegate*<lv_timer_t*, void> lv_timer_del => &lv_timer_delete;

        [NativeTypeName("#define lv_anim_del lv_anim_delete")]
        public static delegate*<void*, delegate* unmanaged[Cdecl]<void*, int, void>, c_bool1> lv_anim_del => &lv_anim_delete;

        [NativeTypeName("#define lv_anim_del_all lv_anim_delete_all")]
        public static delegate*<void> lv_anim_del_all => &lv_anim_delete_all;

        [NativeTypeName("#define lv_anim_set_ready_cb lv_anim_set_completed_cb")]
        public static delegate*<lv_anim_t*, delegate* unmanaged[Cdecl]<lv_anim_t*, void>, void> lv_anim_set_ready_cb => &lv_anim_set_completed_cb;

        [NativeTypeName("#define lv_group_del lv_group_delete")]
        public static delegate*<lv_group_t*, void> lv_group_del => &lv_group_delete;

        [NativeTypeName("#define lv_txt_get_size lv_text_get_size")]
        public static delegate*<lv_point_t*, byte[], lv_font_t*, int, int, int, lv_text_flag_t, void> lv_txt_get_size => &lv_text_get_size;

        [NativeTypeName("#define lv_txt_get_width lv_text_get_width")]
        public static delegate*<byte[], uint, lv_font_t*, int, int> lv_txt_get_width => &lv_text_get_width;

        [NativeTypeName("#define lv_img_create lv_image_create")]
        public static delegate*<lv_obj_t*, lv_obj_t*> lv_img_create => &lv_image_create;

        [NativeTypeName("#define lv_img_set_src lv_image_set_src")]
        public static delegate*<lv_obj_t*, void*, void> lv_img_set_src => &lv_image_set_src;

        [NativeTypeName("#define lv_img_set_offset_x lv_image_set_offset_x")]
        public static delegate*<lv_obj_t*, int, void> lv_img_set_offset_x => &lv_image_set_offset_x;

        [NativeTypeName("#define lv_img_set_offset_y lv_image_set_offset_y")]
        public static delegate*<lv_obj_t*, int, void> lv_img_set_offset_y => &lv_image_set_offset_y;

        [NativeTypeName("#define lv_img_set_angle lv_image_set_rotation")]
        public static delegate*<lv_obj_t*, int, void> lv_img_set_angle => &lv_image_set_rotation;

        [NativeTypeName("#define lv_img_set_pivot lv_image_set_pivot")]
        public static delegate*<lv_obj_t*, int, int, void> lv_img_set_pivot => &lv_image_set_pivot;

        [NativeTypeName("#define lv_img_set_zoom lv_image_set_scale")]
        public static delegate*<lv_obj_t*, uint, void> lv_img_set_zoom => &lv_image_set_scale;

        [NativeTypeName("#define lv_img_set_antialias lv_image_set_antialias")]
        public static delegate*<lv_obj_t*, c_bool1, void> lv_img_set_antialias => &lv_image_set_antialias;

        [NativeTypeName("#define lv_img_get_src lv_image_get_src")]
        public static delegate*<lv_obj_t*, void*> lv_img_get_src => &lv_image_get_src;

        [NativeTypeName("#define lv_img_get_offset_x lv_image_get_offset_x")]
        public static delegate*<lv_obj_t*, int> lv_img_get_offset_x => &lv_image_get_offset_x;

        [NativeTypeName("#define lv_img_get_offset_y lv_image_get_offset_y")]
        public static delegate*<lv_obj_t*, int> lv_img_get_offset_y => &lv_image_get_offset_y;

        [NativeTypeName("#define lv_img_get_angle lv_image_get_rotation")]
        public static delegate*<lv_obj_t*, int> lv_img_get_angle => &lv_image_get_rotation;

        [NativeTypeName("#define lv_img_get_pivot lv_image_get_pivot")]
        public static delegate*<lv_obj_t*, lv_point_t*, void> lv_img_get_pivot => &lv_image_get_pivot;

        [NativeTypeName("#define lv_img_get_zoom lv_image_get_scale")]
        public static delegate*<lv_obj_t*, int> lv_img_get_zoom => &lv_image_get_scale;

        [NativeTypeName("#define lv_img_get_antialias lv_image_get_antialias")]
        public static delegate*<lv_obj_t*, c_bool1> lv_img_get_antialias => &lv_image_get_antialias;

        [NativeTypeName("#define lv_imgbtn_create lv_imagebutton_create")]
        public static delegate*<lv_obj_t*, lv_obj_t*> lv_imgbtn_create => &lv_imagebutton_create;

        [NativeTypeName("#define lv_imgbtn_set_src lv_imagebutton_set_src")]
        public static delegate*<lv_obj_t*, lv_imagebutton_state_t, void*, void*, void*, void> lv_imgbtn_set_src => &lv_imagebutton_set_src;

        [NativeTypeName("#define lv_imgbtn_set_state lv_imagebutton_set_state")]
        public static delegate*<lv_obj_t*, lv_imagebutton_state_t, void> lv_imgbtn_set_state => &lv_imagebutton_set_state;

        [NativeTypeName("#define lv_imgbtn_get_src_left lv_imagebutton_get_src_left")]
        public static delegate*<lv_obj_t*, lv_imagebutton_state_t, void*> lv_imgbtn_get_src_left => &lv_imagebutton_get_src_left;

        [NativeTypeName("#define lv_imgbtn_get_src_middle lv_imagebutton_get_src_middle")]
        public static delegate*<lv_obj_t*, lv_imagebutton_state_t, void*> lv_imgbtn_get_src_middle => &lv_imagebutton_get_src_middle;

        [NativeTypeName("#define lv_imgbtn_get_src_right lv_imagebutton_get_src_right")]
        public static delegate*<lv_obj_t*, lv_imagebutton_state_t, void*> lv_imgbtn_get_src_right => &lv_imagebutton_get_src_right;

        [NativeTypeName("#define lv_list_set_btn_text lv_list_set_button_text")]
        public static delegate*<lv_obj_t*, lv_obj_t*, byte[], void> lv_list_set_btn_text => &lv_list_set_button_text;

        [NativeTypeName("#define lv_list_get_btn_text lv_list_get_button_text")]
        public static delegate*<lv_obj_t*, lv_obj_t*, byte[]> lv_list_get_btn_text => &lv_list_get_button_text;

        [NativeTypeName("#define lv_list_add_btn lv_list_add_button")]
        public static delegate*<lv_obj_t*, void*, byte[], lv_obj_t*> lv_list_add_btn => &lv_list_add_button;

        [NativeTypeName("#define lv_btn_create lv_button_create")]
        public static delegate*<lv_obj_t*, lv_obj_t*> lv_btn_create => &lv_button_create;

        [NativeTypeName("#define lv_btnmatrix_create lv_buttonmatrix_create")]
        public static delegate*<lv_obj_t*, lv_obj_t*> lv_btnmatrix_create => &lv_buttonmatrix_create;

        [NativeTypeName("#define lv_btnmatrix_set_map lv_buttonmatrix_set_map")]
        public static delegate*<lv_obj_t*, sbyte**, void> lv_btnmatrix_set_map => &lv_buttonmatrix_set_map;

        [NativeTypeName("#define lv_btnmatrix_set_ctrl_map lv_buttonmatrix_set_ctrl_map")]
        public static delegate*<lv_obj_t*, lv_buttonmatrix_ctrl_t*, void> lv_btnmatrix_set_ctrl_map => &lv_buttonmatrix_set_ctrl_map;

        [NativeTypeName("#define lv_btnmatrix_set_selected_btn lv_buttonmatrix_set_selected_button")]
        public static delegate*<lv_obj_t*, uint, void> lv_btnmatrix_set_selected_btn => &lv_buttonmatrix_set_selected_button;

        [NativeTypeName("#define lv_btnmatrix_set_btn_ctrl lv_buttonmatrix_set_button_ctrl")]
        public static delegate*<lv_obj_t*, uint, lv_buttonmatrix_ctrl_t, void> lv_btnmatrix_set_btn_ctrl => &lv_buttonmatrix_set_button_ctrl;

        [NativeTypeName("#define lv_btnmatrix_clear_btn_ctrl lv_buttonmatrix_clear_button_ctrl")]
        public static delegate*<lv_obj_t*, uint, lv_buttonmatrix_ctrl_t, void> lv_btnmatrix_clear_btn_ctrl => &lv_buttonmatrix_clear_button_ctrl;

        [NativeTypeName("#define lv_btnmatrix_set_btn_ctrl_all lv_buttonmatrix_set_button_ctrl_all")]
        public static delegate*<lv_obj_t*, lv_buttonmatrix_ctrl_t, void> lv_btnmatrix_set_btn_ctrl_all => &lv_buttonmatrix_set_button_ctrl_all;

        [NativeTypeName("#define lv_btnmatrix_clear_btn_ctrl_all lv_buttonmatrix_clear_button_ctrl_all")]
        public static delegate*<lv_obj_t*, lv_buttonmatrix_ctrl_t, void> lv_btnmatrix_clear_btn_ctrl_all => &lv_buttonmatrix_clear_button_ctrl_all;

        [NativeTypeName("#define lv_btnmatrix_set_btn_width lv_buttonmatrix_set_button_width")]
        public static delegate*<lv_obj_t*, uint, uint, void> lv_btnmatrix_set_btn_width => &lv_buttonmatrix_set_button_width;

        [NativeTypeName("#define lv_btnmatrix_set_one_checked lv_buttonmatrix_set_one_checked")]
        public static delegate*<lv_obj_t*, c_bool1, void> lv_btnmatrix_set_one_checked => &lv_buttonmatrix_set_one_checked;

        [NativeTypeName("#define lv_btnmatrix_get_map lv_buttonmatrix_get_map")]
        public static delegate*<lv_obj_t*, sbyte**> lv_btnmatrix_get_map => &lv_buttonmatrix_get_map;

        [NativeTypeName("#define lv_btnmatrix_get_selected_btn lv_buttonmatrix_get_selected_button")]
        public static delegate*<lv_obj_t*, uint> lv_btnmatrix_get_selected_btn => &lv_buttonmatrix_get_selected_button;

        [NativeTypeName("#define lv_btnmatrix_get_btn_text lv_buttonmatrix_get_button_text")]
        public static delegate*<lv_obj_t*, uint, byte[]> lv_btnmatrix_get_btn_text => &lv_buttonmatrix_get_button_text;

        [NativeTypeName("#define lv_btnmatrix_has_button_ctrl lv_buttonmatrix_has_button_ctrl")]
        public static delegate*<lv_obj_t*, uint, lv_buttonmatrix_ctrl_t, c_bool1> lv_btnmatrix_has_button_ctrl => &lv_buttonmatrix_has_button_ctrl;

        [NativeTypeName("#define lv_btnmatrix_get_one_checked lv_buttonmatrix_get_one_checked")]
        public static delegate*<lv_obj_t*, c_bool1> lv_btnmatrix_get_one_checked => &lv_buttonmatrix_get_one_checked;

        [NativeTypeName("#define lv_tabview_get_tab_btns lv_tabview_get_tab_bar")]
        public static delegate*<lv_obj_t*, lv_obj_t*> lv_tabview_get_tab_btns => &lv_tabview_get_tab_bar;

        [NativeTypeName("#define lv_tabview_get_tab_act lv_tabview_get_tab_active")]
        public static delegate*<lv_obj_t*, uint> lv_tabview_get_tab_act => &lv_tabview_get_tab_active;

        [NativeTypeName("#define lv_tabview_set_act lv_tabview_set_active")]
        public static delegate*<lv_obj_t*, uint, c_bool1, void> lv_tabview_set_act => &lv_tabview_set_active;

        [NativeTypeName("#define lv_tileview_get_tile_act lv_tileview_get_tile_active")]
        public static delegate*<lv_obj_t*, lv_obj_t*> lv_tileview_get_tile_act => &lv_tileview_get_tile_active;

        [NativeTypeName("#define lv_obj_set_tile_id lv_tileview_set_tile_by_index")]
        public static delegate*<lv_obj_t*, uint, uint, c_bool1, void> lv_obj_set_tile_id => &lv_tileview_set_tile_by_index;

        [NativeTypeName("#define lv_obj_set_tile lv_tileview_set_tile")]
        public static delegate*<lv_obj_t*, lv_obj_t*, c_bool1, void> lv_obj_set_tile => &lv_tileview_set_tile;

        [NativeTypeName("#define lv_roller_set_visible_row_cnt lv_roller_set_visible_row_count")]
        public static delegate*<lv_obj_t*, uint, void> lv_roller_set_visible_row_cnt => &lv_roller_set_visible_row_count;

        [NativeTypeName("#define lv_roller_get_option_cnt lv_roller_get_option_count")]
        public static delegate*<lv_obj_t*, uint> lv_roller_get_option_cnt => &lv_roller_get_option_count;

        [NativeTypeName("#define lv_table_set_col_cnt lv_table_set_column_count")]
        public static delegate*<lv_obj_t*, uint, void> lv_table_set_col_cnt => &lv_table_set_column_count;

        [NativeTypeName("#define lv_table_set_row_cnt lv_table_set_row_count")]
        public static delegate*<lv_obj_t*, uint, void> lv_table_set_row_cnt => &lv_table_set_row_count;

        [NativeTypeName("#define lv_table_get_col_cnt lv_table_get_column_count")]
        public static delegate*<lv_obj_t*, uint> lv_table_get_col_cnt => &lv_table_get_column_count;

        [NativeTypeName("#define lv_table_get_row_cnt lv_table_get_row_count")]
        public static delegate*<lv_obj_t*, uint> lv_table_get_row_cnt => &lv_table_get_row_count;

        [NativeTypeName("#define lv_table_set_col_width lv_table_set_column_width")]
        public static delegate*<lv_obj_t*, uint, int, void> lv_table_set_col_width => &lv_table_set_column_width;

        [NativeTypeName("#define lv_table_get_col_width lv_table_get_column_width")]
        public static delegate*<lv_obj_t*, uint, int> lv_table_get_col_width => &lv_table_get_column_width;

        [NativeTypeName("#define lv_dropdown_get_option_cnt lv_dropdown_get_option_count")]
        public static delegate*<lv_obj_t*, uint> lv_dropdown_get_option_cnt => &lv_dropdown_get_option_count;

        [NativeTypeName("#define lv_obj_get_child_cnt lv_obj_get_child_count")]
        public static delegate*<lv_obj_t*, uint> lv_obj_get_child_cnt => &lv_obj_get_child_count;

        [NativeTypeName("#define lv_obj_get_disp lv_obj_get_display")]
        public static delegate*<lv_obj_t*, lv_display_t*> lv_obj_get_disp => &lv_obj_get_display;

        [NativeTypeName("#define lv_obj_delete_anim_ready_cb lv_obj_delete_anim_completed_cb")]
        public static delegate*<lv_anim_t*, void> lv_obj_delete_anim_ready_cb => &lv_obj_delete_anim_completed_cb;

        [NativeTypeName("#define LV_STYLE_ANIM_TIME LV_STYLE_ANIM_DURATION")]
        public const int LV_STYLE_ANIM_TIME = LV_STYLE_ANIM_DURATION;

        [NativeTypeName("#define LV_STYLE_IMG_OPA LV_STYLE_IMAGE_OPA")]
        public const int LV_STYLE_IMG_OPA = LV_STYLE_IMAGE_OPA;

        [NativeTypeName("#define LV_STYLE_IMG_RECOLOR LV_STYLE_IMAGE_RECOLOR")]
        public const int LV_STYLE_IMG_RECOLOR = LV_STYLE_IMAGE_RECOLOR;

        [NativeTypeName("#define LV_STYLE_IMG_RECOLOR_OPA LV_STYLE_IMAGE_RECOLOR_OPA")]
        public const int LV_STYLE_IMG_RECOLOR_OPA = LV_STYLE_IMAGE_RECOLOR_OPA;

        [NativeTypeName("#define LV_STYLE_SHADOW_OFS_X LV_STYLE_SHADOW_OFFSET_X")]
        public const int LV_STYLE_SHADOW_OFS_X = LV_STYLE_SHADOW_OFFSET_X;

        [NativeTypeName("#define LV_STYLE_SHADOW_OFS_Y LV_STYLE_SHADOW_OFFSET_Y")]
        public const int LV_STYLE_SHADOW_OFS_Y = LV_STYLE_SHADOW_OFFSET_Y;

        [NativeTypeName("#define LV_STYLE_TRANSFORM_ANGLE LV_STYLE_TRANSFORM_ROTATION")]
        public const int LV_STYLE_TRANSFORM_ANGLE = LV_STYLE_TRANSFORM_ROTATION;

        [NativeTypeName("#define lv_obj_get_style_anim_time lv_obj_get_style_anim_duration")]
        public static delegate*<lv_obj_t*, uint, uint> lv_obj_get_style_anim_time => &lv_obj_get_style_anim_duration;

        [NativeTypeName("#define lv_obj_get_style_img_opa lv_obj_get_style_image_opa")]
        public static delegate*<lv_obj_t*, uint, byte> lv_obj_get_style_img_opa => &lv_obj_get_style_image_opa;

        [NativeTypeName("#define lv_obj_get_style_img_recolor lv_obj_get_style_image_recolor")]
        public static delegate*<lv_obj_t*, uint, lv_color_t> lv_obj_get_style_img_recolor => &lv_obj_get_style_image_recolor;

        [NativeTypeName("#define lv_obj_get_style_img_recolor_filtered lv_obj_get_style_image_recolor_filtered")]
        public static delegate*<lv_obj_t*, uint, lv_color_t> lv_obj_get_style_img_recolor_filtered => &lv_obj_get_style_image_recolor_filtered;

        [NativeTypeName("#define lv_obj_get_style_img_recolor_opa lv_obj_get_style_image_recolor_opa")]
        public static delegate*<lv_obj_t*, uint, byte> lv_obj_get_style_img_recolor_opa => &lv_obj_get_style_image_recolor_opa;

        [NativeTypeName("#define lv_obj_get_style_shadow_ofs_x lv_obj_get_style_shadow_offset_x")]
        public static delegate*<lv_obj_t*, uint, int> lv_obj_get_style_shadow_ofs_x => &lv_obj_get_style_shadow_offset_x;

        [NativeTypeName("#define lv_obj_get_style_shadow_ofs_y lv_obj_get_style_shadow_offset_y")]
        public static delegate*<lv_obj_t*, uint, int> lv_obj_get_style_shadow_ofs_y => &lv_obj_get_style_shadow_offset_y;

        [NativeTypeName("#define lv_obj_get_style_transform_angle lv_obj_get_style_transform_rotation")]
        public static delegate*<lv_obj_t*, uint, int> lv_obj_get_style_transform_angle => &lv_obj_get_style_transform_rotation;

        [NativeTypeName("#define lv_obj_get_style_bg_img_src lv_obj_get_style_bg_image_src")]
        public static delegate*<lv_obj_t*, uint, void*> lv_obj_get_style_bg_img_src => &lv_obj_get_style_bg_image_src;

        [NativeTypeName("#define lv_obj_get_style_bg_img_recolor lv_obj_get_style_bg_image_recolor")]
        public static delegate*<lv_obj_t*, uint, lv_color_t> lv_obj_get_style_bg_img_recolor => &lv_obj_get_style_bg_image_recolor;

        [NativeTypeName("#define lv_obj_get_style_bg_img_recolor_opa lv_obj_get_style_bg_image_recolor_opa")]
        public static delegate*<lv_obj_t*, uint, byte> lv_obj_get_style_bg_img_recolor_opa => &lv_obj_get_style_bg_image_recolor_opa;

        [NativeTypeName("#define lv_obj_set_style_anim_time lv_obj_set_style_anim_duration")]
        public static delegate*<lv_obj_t*, uint, uint, void> lv_obj_set_style_anim_time => &lv_obj_set_style_anim_duration;

        [NativeTypeName("#define lv_obj_set_style_img_opa lv_obj_set_style_image_opa")]
        public static delegate*<lv_obj_t*, byte, uint, void> lv_obj_set_style_img_opa => &lv_obj_set_style_image_opa;

        [NativeTypeName("#define lv_obj_set_style_img_recolor lv_obj_set_style_image_recolor")]
        public static delegate*<lv_obj_t*, lv_color_t, uint, void> lv_obj_set_style_img_recolor => &lv_obj_set_style_image_recolor;

        [NativeTypeName("#define lv_obj_set_style_img_recolor_opa lv_obj_set_style_image_recolor_opa")]
        public static delegate*<lv_obj_t*, byte, uint, void> lv_obj_set_style_img_recolor_opa => &lv_obj_set_style_image_recolor_opa;

        [NativeTypeName("#define lv_obj_set_style_shadow_ofs_x lv_obj_set_style_shadow_offset_x")]
        public static delegate*<lv_obj_t*, int, uint, void> lv_obj_set_style_shadow_ofs_x => &lv_obj_set_style_shadow_offset_x;

        [NativeTypeName("#define lv_obj_set_style_shadow_ofs_y lv_obj_set_style_shadow_offset_y")]
        public static delegate*<lv_obj_t*, int, uint, void> lv_obj_set_style_shadow_ofs_y => &lv_obj_set_style_shadow_offset_y;

        [NativeTypeName("#define lv_obj_set_style_transform_zoom lv_obj_set_style_transform_scale")]
        public static delegate*<lv_obj_t*, int, uint, void> lv_obj_set_style_transform_zoom => &lv_obj_set_style_transform_scale;

        [NativeTypeName("#define lv_obj_set_style_transform_angle lv_obj_set_style_transform_rotation")]
        public static delegate*<lv_obj_t*, int, uint, void> lv_obj_set_style_transform_angle => &lv_obj_set_style_transform_rotation;

        [NativeTypeName("#define lv_obj_set_style_bg_img_src lv_obj_set_style_bg_image_src")]
        public static delegate*<lv_obj_t*, void*, uint, void> lv_obj_set_style_bg_img_src => &lv_obj_set_style_bg_image_src;

        [NativeTypeName("#define lv_obj_set_style_bg_img_recolor lv_obj_set_style_bg_image_recolor")]
        public static delegate*<lv_obj_t*, lv_color_t, uint, void> lv_obj_set_style_bg_img_recolor => &lv_obj_set_style_bg_image_recolor;

        [NativeTypeName("#define lv_obj_set_style_bg_img_recolor_opa lv_obj_set_style_bg_image_recolor_opa")]
        public static delegate*<lv_obj_t*, byte, uint, void> lv_obj_set_style_bg_img_recolor_opa => &lv_obj_set_style_bg_image_recolor_opa;

        [NativeTypeName("#define lv_style_set_anim_time lv_style_set_anim_duration")]
        public static delegate*<lv_style_t*, uint, void> lv_style_set_anim_time => &lv_style_set_anim_duration;

        [NativeTypeName("#define lv_style_set_img_opa lv_style_set_image_opa")]
        public static delegate*<lv_style_t*, byte, void> lv_style_set_img_opa => &lv_style_set_image_opa;

        [NativeTypeName("#define lv_style_set_img_recolor lv_style_set_image_recolor")]
        public static delegate*<lv_style_t*, lv_color_t, void> lv_style_set_img_recolor => &lv_style_set_image_recolor;

        [NativeTypeName("#define lv_style_set_img_recolor_opa lv_style_set_image_recolor_opa")]
        public static delegate*<lv_style_t*, byte, void> lv_style_set_img_recolor_opa => &lv_style_set_image_recolor_opa;

        [NativeTypeName("#define lv_style_set_shadow_ofs_x lv_style_set_shadow_offset_x")]
        public static delegate*<lv_style_t*, int, void> lv_style_set_shadow_ofs_x => &lv_style_set_shadow_offset_x;

        [NativeTypeName("#define lv_style_set_shadow_ofs_y lv_style_set_shadow_offset_y")]
        public static delegate*<lv_style_t*, int, void> lv_style_set_shadow_ofs_y => &lv_style_set_shadow_offset_y;

        [NativeTypeName("#define lv_style_set_transform_angle lv_style_set_transform_rotation")]
        public static delegate*<lv_style_t*, int, void> lv_style_set_transform_angle => &lv_style_set_transform_rotation;

        [NativeTypeName("#define lv_style_set_transform_zoom lv_style_set_transform_scale")]
        public static delegate*<lv_style_t*, int, void> lv_style_set_transform_zoom => &lv_style_set_transform_scale;

        [NativeTypeName("#define lv_style_set_bg_img_src lv_style_set_bg_image_src")]
        public static delegate*<lv_style_t*, void*, void> lv_style_set_bg_img_src => &lv_style_set_bg_image_src;

        [NativeTypeName("#define lv_style_set_bg_img_recolor lv_style_set_bg_image_recolor")]
        public static delegate*<lv_style_t*, lv_color_t, void> lv_style_set_bg_img_recolor => &lv_style_set_bg_image_recolor;

        [NativeTypeName("#define lv_style_set_bg_img_recolor_opa lv_style_set_bg_image_recolor_opa")]
        public static delegate*<lv_style_t*, byte, void> lv_style_set_bg_img_recolor_opa => &lv_style_set_bg_image_recolor_opa;

        [NativeTypeName("#define lv_keyboard_get_selected_btn lv_keyboard_get_selected_button")]
        public static delegate*<lv_obj_t*, uint> lv_keyboard_get_selected_btn => &lv_keyboard_get_selected_button;

        [NativeTypeName("#define lv_keyboard_get_btn_text lv_keyboard_get_button_text")]
        public static delegate*<lv_obj_t*, uint, byte[]> lv_keyboard_get_btn_text => &lv_keyboard_get_button_text;

        [NativeTypeName("#define LV_ZOOM_NONE LV_SCALE_NONE")]
        public const int LV_ZOOM_NONE = 256;

        [NativeTypeName("#define lv_image_decoder_built_in_open lv_bin_decoder_open")]
        public static delegate*<lv_image_decoder_t*, lv_image_decoder_dsc_t*, lv_result_t> lv_image_decoder_built_in_open => &lv_bin_decoder_open;

        [NativeTypeName("#define lv_image_decoder_built_in_close lv_bin_decoder_close")]
        public static delegate*<lv_image_decoder_t*, lv_image_decoder_dsc_t*, void> lv_image_decoder_built_in_close => &lv_bin_decoder_close;

        [NativeTypeName("#define lv_image_set_align lv_image_set_inner_align")]
        public static delegate*<lv_obj_t*, lv_image_align_t, void> lv_image_set_align => &lv_image_set_inner_align;

        [NativeTypeName("#define lv_image_get_align lv_image_get_inner_align")]
        public static delegate*<lv_obj_t*, lv_image_align_t> lv_image_get_align => &lv_image_get_inner_align;

        [NativeTypeName("#define lv_button_bind_checked lv_obj_bind_checked")]
        public static delegate*<lv_obj_t*, lv_subject_t*, lv_observer_t*> lv_button_bind_checked => &lv_obj_bind_checked;

        [NativeTypeName("#define _lv_utils_bsearch lv_utils_bsearch")]
        public static delegate*<void*, void*, nuint, nuint, delegate* unmanaged[Cdecl]<void*, void*, int>, void*> _lv_utils_bsearch => &lv_utils_bsearch;

        [NativeTypeName("#define lv_draw_buf_align_user lv_draw_buf_align_ex")]
        public static delegate*<lv_draw_buf_handlers_t*, void*, lv_color_format_t, void*> lv_draw_buf_align_user => &lv_draw_buf_align_ex;

        [NativeTypeName("#define lv_draw_buf_create_user lv_draw_buf_create_ex")]
        public static delegate*<lv_draw_buf_handlers_t*, uint, uint, lv_color_format_t, uint, lv_draw_buf_t*> lv_draw_buf_create_user => &lv_draw_buf_create_ex;

        [NativeTypeName("#define lv_draw_buf_width_to_stride_user lv_draw_buf_width_to_stride_ex")]
        public static delegate*<lv_draw_buf_handlers_t*, uint, lv_color_format_t, uint> lv_draw_buf_width_to_stride_user => &lv_draw_buf_width_to_stride_ex;

        [NativeTypeName("#define lv_draw_buf_dup_user lv_draw_buf_dup_ex")]
        public static delegate*<lv_draw_buf_handlers_t*, lv_draw_buf_t*, lv_draw_buf_t*> lv_draw_buf_dup_user => &lv_draw_buf_dup_ex;

        [NativeTypeName("#define _LV_EVENT_LAST LV_EVENT_LAST")]
        public const lv_event_code_t _LV_EVENT_LAST = LV_EVENT_LAST;

        [NativeTypeName("#define lv_obj_add_event lv_obj_add_event_cb")]
        public static delegate*<lv_obj_t*, delegate* unmanaged[Cdecl]<lv_event_t*, void>, lv_event_code_t, void*, lv_event_dsc_t*> lv_obj_add_event => &lv_obj_add_event_cb;

        [NativeTypeName("#define _LV_STYLE_LAST_BUILT_IN_PROP LV_STYLE_LAST_BUILT_IN_PROP")]
        public const int _LV_STYLE_LAST_BUILT_IN_PROP = LV_STYLE_LAST_BUILT_IN_PROP;

        [NativeTypeName("#define _LV_FLEX_REVERSE LV_FLEX_REVERSE")]
        public const int _LV_FLEX_REVERSE = (1 << 3);

        [NativeTypeName("#define _LV_FLEX_WRAP LV_FLEX_WRAP")]
        public const int _LV_FLEX_WRAP = (1 << 2);

        [NativeTypeName("#define _LV_FLEX_COLUMN LV_FLEX_COLUMN")]
        public const int _LV_FLEX_COLUMN = (1 << 0);

        [NativeTypeName("#define _lv_ll_init lv_ll_init")]
        public static delegate*<lv_ll_t*, uint, void> _lv_ll_init => &lv_ll_init;

        [NativeTypeName("#define _lv_ll_ins_head lv_ll_ins_head")]
        public static delegate*<lv_ll_t*, void*> _lv_ll_ins_head => &lv_ll_ins_head;

        [NativeTypeName("#define _lv_ll_ins_prev lv_ll_ins_prev")]
        public static delegate*<lv_ll_t*, void*, void*> _lv_ll_ins_prev => &lv_ll_ins_prev;

        [NativeTypeName("#define _lv_ll_ins_tail lv_ll_ins_tail")]
        public static delegate*<lv_ll_t*, void*> _lv_ll_ins_tail => &lv_ll_ins_tail;

        [NativeTypeName("#define _lv_ll_get_head lv_ll_get_head")]
        public static delegate*<lv_ll_t*, void*> _lv_ll_get_head => &lv_ll_get_head;

        [NativeTypeName("#define _lv_ll_get_tail lv_ll_get_tail")]
        public static delegate*<lv_ll_t*, void*> _lv_ll_get_tail => &lv_ll_get_tail;

        [NativeTypeName("#define _lv_ll_get_next lv_ll_get_next")]
        public static delegate*<lv_ll_t*, void*, void*> _lv_ll_get_next => &lv_ll_get_next;

        [NativeTypeName("#define _lv_ll_get_prev lv_ll_get_prev")]
        public static delegate*<lv_ll_t*, void*, void*> _lv_ll_get_prev => &lv_ll_get_prev;

        [NativeTypeName("#define _lv_ll_get_len lv_ll_get_len")]
        public static delegate*<lv_ll_t*, uint> _lv_ll_get_len => &lv_ll_get_len;

        [NativeTypeName("#define _lv_ll_move_before lv_ll_move_before")]
        public static delegate*<lv_ll_t*, void*, void*, void> _lv_ll_move_before => &lv_ll_move_before;

        [NativeTypeName("#define _lv_ll_is_empty lv_ll_is_empty")]
        public static delegate*<lv_ll_t*, c_bool1> _lv_ll_is_empty => &lv_ll_is_empty;

        [NativeTypeName("#define _lv_ll_clear lv_ll_clear")]
        public static delegate*<lv_ll_t*, void> _lv_ll_clear => &lv_ll_clear;

        [NativeTypeName("#define _lv_ll_remove lv_ll_remove")]
        public static delegate*<lv_ll_t*, void*, void> _lv_ll_remove => &lv_ll_remove;

        [NativeTypeName("#define _lv_ll_chg_list lv_ll_chg_list")]
        public static delegate*<lv_ll_t*, lv_ll_t*, void*, c_bool1, void> _lv_ll_chg_list => &lv_ll_chg_list;

        [NativeTypeName("#define _lv_display_refr_timer lv_disp_refr_timer")]
        public static delegate*<lv_timer_t*, void> _lv_display_refr_timer => &lv_display_refr_timer;

        [NativeTypeName("#define _lv_disp_refr_timer lv_disp_refr_timer")]
        public static delegate*<lv_timer_t*, void> _lv_disp_refr_timer => &lv_display_refr_timer;

        [NativeTypeName("#define _lv_disp_get_refr_timer lv_disp_get_refr_timer")]
        public static delegate*<lv_display_t*, lv_timer_t*> _lv_disp_get_refr_timer => &lv_display_get_refr_timer;

        [NativeTypeName("#define lv_obj_update_flag lv_obj_set_flag")]
        public static delegate*<lv_obj_t*, lv_obj_flag_t, c_bool1, void> lv_obj_update_flag => &lv_obj_set_flag;

        [NativeTypeName("#define lv_chart_set_all_value lv_chart_set_all_values")]
        public static delegate*<lv_obj_t*, lv_chart_series_t*, int, void> lv_chart_set_all_value => &lv_chart_set_all_values;

        [NativeTypeName("#define lv_calendar_set_showed_date lv_calendar_set_month_shown")]
        public static delegate*<lv_obj_t*, uint, uint, void> lv_calendar_set_showed_date => &lv_calendar_set_month_shown;

        [NativeTypeName("#define lv_chart_set_range lv_chart_set_axis_range")]
        public static delegate*<lv_obj_t*, lv_chart_axis_t, int, int, void> lv_chart_set_range => &lv_chart_set_axis_range;

        [NativeTypeName("#define lv_chart_set_value_by_id lv_chart_set_series_value_by_id")]
        public static delegate*<lv_obj_t*, lv_chart_series_t*, uint, int, void> lv_chart_set_value_by_id => &lv_chart_set_series_value_by_id;

        [NativeTypeName("#define lv_chart_get_x_array lv_chart_get_series_x_array")]
        public static delegate*<lv_obj_t*, lv_chart_series_t*, int*> lv_chart_get_x_array => &lv_chart_get_series_x_array;

        [NativeTypeName("#define lv_chart_get_y_array lv_chart_get_series_y_array")]
        public static delegate*<lv_obj_t*, lv_chart_series_t*, int*> lv_chart_get_y_array => &lv_chart_get_series_y_array;

        [NativeTypeName("#define lv_chart_set_ext_x_array lv_chart_set_series_ext_x_array")]
        public static delegate*<lv_obj_t*, lv_chart_series_t*, int*, void> lv_chart_set_ext_x_array => &lv_chart_set_series_ext_x_array;

        [NativeTypeName("#define lv_chart_set_ext_y_array lv_chart_set_series_ext_y_array")]
        public static delegate*<lv_obj_t*, lv_chart_series_t*, int*, void> lv_chart_set_ext_y_array => &lv_chart_set_series_ext_y_array;

        [NativeTypeName("#define LV_LABEL_LONG_WRAP LV_LABEL_LONG_MODE_WRAP")]
        public const lv_label_long_mode_t LV_LABEL_LONG_WRAP = LV_LABEL_LONG_MODE_WRAP;

        [NativeTypeName("#define LV_LABEL_LONG_DOT LV_LABEL_LONG_MODE_DOTS")]
        public const lv_label_long_mode_t LV_LABEL_LONG_DOT = LV_LABEL_LONG_MODE_DOTS;

        [NativeTypeName("#define LV_LABEL_LONG_SCROLL LV_LABEL_LONG_MODE_SCROLL")]
        public const lv_label_long_mode_t LV_LABEL_LONG_SCROLL = LV_LABEL_LONG_MODE_SCROLL;

        [NativeTypeName("#define LV_LABEL_LONG_SCROLL_CIRCULAR LV_LABEL_LONG_MODE_SCROLL_CIRCULAR")]
        public const lv_label_long_mode_t LV_LABEL_LONG_SCROLL_CIRCULAR = LV_LABEL_LONG_MODE_SCROLL_CIRCULAR;

        [NativeTypeName("#define LV_LABEL_LONG_CLIP LV_LABEL_LONG_MODE_CLIP")]
        public const lv_label_long_mode_t LV_LABEL_LONG_CLIP = LV_LABEL_LONG_MODE_CLIP;

        [NativeTypeName("#define lv_anim_set_time lv_anim_set_duration")]
        public static delegate*<lv_anim_t*, uint, void> lv_anim_set_time => &lv_anim_set_duration;

        [NativeTypeName("#define lv_anim_set_playback_time lv_anim_set_reverse_duration")]
        public static delegate*<lv_anim_t*, uint, void> lv_anim_set_playback_time => &lv_anim_set_reverse_duration;

        [NativeTypeName("#define lv_anim_set_playback_delay lv_anim_set_reverse_delay")]
        public static delegate*<lv_anim_t*, uint, void> lv_anim_set_playback_delay => &lv_anim_set_reverse_delay;

        [NativeTypeName("#define lv_anim_set_playback_duration lv_anim_set_reverse_duration")]
        public static delegate*<lv_anim_t*, uint, void> lv_anim_set_playback_duration => &lv_anim_set_reverse_duration;

        [NativeTypeName("#define lv_gradient_init_stops lv_grad_init_stops")]
        public static delegate*<lv_grad_dsc_t*, lv_color_t*, byte*, byte*, int, void> lv_gradient_init_stops => &lv_grad_init_stops;

        [NativeTypeName("#define lv_spangroup_new_span lv_spangroup_add_span")]
        public static delegate*<lv_obj_t*, lv_span_t*> lv_spangroup_new_span => &lv_spangroup_add_span;

        [NativeTypeName("#define lv_spangroup_refr_mode lv_spangroup_refresh")]
        public static delegate*<lv_obj_t*, void> lv_spangroup_refr_mode => &lv_spangroup_refresh;

        [NativeTypeName("#define lv_slider_set_left_value lv_slider_set_start_value")]
        public static delegate*<lv_obj_t*, int, c_bool1, void> lv_slider_set_left_value => &lv_slider_set_start_value;

        [NativeTypeName("#define lv_calendar_header_arrow_create lv_calendar_add_header_arrow")]
        public static delegate*<lv_obj_t*, lv_obj_t*> lv_calendar_header_arrow_create => &lv_calendar_add_header_arrow;

        [NativeTypeName("#define lv_calendar_header_dropdown_create lv_calendar_add_header_dropdown")]
        public static delegate*<lv_obj_t*, lv_obj_t*> lv_calendar_header_dropdown_create => &lv_calendar_add_header_dropdown;
    }
}
