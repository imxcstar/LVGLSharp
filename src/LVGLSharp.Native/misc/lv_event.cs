using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LVGLSharp
{
    public static partial class Native
    {
        /// <summary>
        /// Type of event being sent to the object.
        /// </summary>
        public enum lv_event_code_t
        {
            LV_EVENT_ALL = 0,

            /** Input device events*/
            LV_EVENT_PRESSED,             /**< The object has been pressed*/
            LV_EVENT_PRESSING,            /**< The object is being pressed (called continuously while pressing)*/
            LV_EVENT_PRESS_LOST,          /**< The object is still being pressed but slid cursor/finger off of the object */
            LV_EVENT_SHORT_CLICKED,       /**< The object was pressed for a short period of time, then released it. Not called if scrolled.*/
            LV_EVENT_LONG_PRESSED,        /**< Object has been pressed for at least `long_press_time`.  Not called if scrolled.*/
            LV_EVENT_LONG_PRESSED_REPEAT, /**< Called after `long_press_time` in every `long_press_repeat_time` ms.  Not called if scrolled.*/
            LV_EVENT_CLICKED,             /**< Called on release if not scrolled (regardless to long press)*/
            LV_EVENT_RELEASED,            /**< Called in every cases when the object has been released*/
            LV_EVENT_SCROLL_BEGIN,        /**< Scrolling begins. The event parameter is a pointer to the animation of the scroll. Can be modified*/
            LV_EVENT_SCROLL_THROW_BEGIN,
            LV_EVENT_SCROLL_END,          /**< Scrolling ends*/
            LV_EVENT_SCROLL,              /**< Scrolling*/
            LV_EVENT_GESTURE,             /**< A gesture is detected. Get the gesture with `lv_indev_get_gesture_dir(lv_indev_active());` */
            LV_EVENT_KEY,                 /**< A key is sent to the object. Get the key with `lv_indev_get_key(lv_indev_active());`*/
            LV_EVENT_ROTARY,              /**< An encoder or wheel was rotated. Get the rotation count with `lv_event_get_rotary_diff(e);`*/
            LV_EVENT_FOCUSED,             /**< The object is focused*/
            LV_EVENT_DEFOCUSED,           /**< The object is defocused*/
            LV_EVENT_LEAVE,               /**< The object is defocused but still selected*/
            LV_EVENT_HIT_TEST,            /**< Perform advanced hit-testing*/
            LV_EVENT_INDEV_RESET,         /**< Indev has been reset*/

            /** Drawing events*/
            LV_EVENT_COVER_CHECK,        /**< Check if the object fully covers an area. The event parameter is `lv_cover_check_info_t *`.*/
            LV_EVENT_REFR_EXT_DRAW_SIZE, /**< Get the required extra draw area around the object (e.g. for shadow). The event parameter is `int32_t *` to store the size.*/
            LV_EVENT_DRAW_MAIN_BEGIN,    /**< Starting the main drawing phase*/
            LV_EVENT_DRAW_MAIN,          /**< Perform the main drawing*/
            LV_EVENT_DRAW_MAIN_END,      /**< Finishing the main drawing phase*/
            LV_EVENT_DRAW_POST_BEGIN,    /**< Starting the post draw phase (when all children are drawn)*/
            LV_EVENT_DRAW_POST,          /**< Perform the post draw phase (when all children are drawn)*/
            LV_EVENT_DRAW_POST_END,      /**< Finishing the post draw phase (when all children are drawn)*/
            LV_EVENT_DRAW_TASK_ADDED,      /**< Adding a draw task */

            /** Special events*/
            LV_EVENT_VALUE_CHANGED,       /**< The object's value has changed (i.e. slider moved)*/
            LV_EVENT_INSERT,              /**< A text is inserted to the object. The event data is `char *` being inserted.*/
            LV_EVENT_REFRESH,             /**< Notify the object to refresh something on it (for the user)*/
            LV_EVENT_READY,               /**< A process has finished*/
            LV_EVENT_CANCEL,              /**< A process has been cancelled */

            /** Other events*/
            LV_EVENT_CREATE,              /**< Object is being created*/
            LV_EVENT_DELETE,              /**< Object is being deleted*/
            LV_EVENT_CHILD_CHANGED,       /**< Child was removed, added, or its size, position were changed */
            LV_EVENT_CHILD_CREATED,       /**< Child was created, always bubbles up to all parents*/
            LV_EVENT_CHILD_DELETED,       /**< Child was deleted, always bubbles up to all parents*/
            LV_EVENT_SCREEN_UNLOAD_START, /**< A screen unload started, fired immediately when scr_load is called*/
            LV_EVENT_SCREEN_LOAD_START,   /**< A screen load started, fired when the screen change delay is expired*/
            LV_EVENT_SCREEN_LOADED,       /**< A screen was loaded*/
            LV_EVENT_SCREEN_UNLOADED,     /**< A screen was unloaded*/
            LV_EVENT_SIZE_CHANGED,        /**< Object coordinates/size have changed*/
            LV_EVENT_STYLE_CHANGED,       /**< Object's style has changed*/
            LV_EVENT_LAYOUT_CHANGED,      /**< The children position has changed due to a layout recalculation*/
            LV_EVENT_GET_SELF_SIZE,       /**< Get the internal size of a widget*/

            /** Events of optional LVGL components*/
            LV_EVENT_INVALIDATE_AREA,
            LV_EVENT_RESOLUTION_CHANGED,
            LV_EVENT_COLOR_FORMAT_CHANGED,
            LV_EVENT_REFR_REQUEST,
            LV_EVENT_REFR_START,
            LV_EVENT_REFR_READY,
            LV_EVENT_RENDER_START,
            LV_EVENT_RENDER_READY,
            LV_EVENT_FLUSH_START,
            LV_EVENT_FLUSH_FINISH,
            LV_EVENT_FLUSH_WAIT_START,
            LV_EVENT_FLUSH_WAIT_FINISH,

            LV_EVENT_VSYNC,

            _LV_EVENT_LAST,                 /** Number of default events*/

            LV_EVENT_PREPROCESS = 0x8000,   /** This is a flag that can be set with an event so it's processed
                                      before the class default event processing */
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void lv_event_cb_t(IntPtr e);
    }
}
