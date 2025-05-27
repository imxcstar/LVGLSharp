#include "lv_conf.h"
#include "lvgl/lvgl.h"

struct _lv_circle_buf_t {
    lv_array_t array;
    uint32_t head;
    uint32_t tail;    /**< The next write position */

    bool inner_alloc; /**< true: the array is allocated by the buffer, false: the array is created from an external buffer */
};