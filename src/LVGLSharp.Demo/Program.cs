using static LVGLSharp.Native;
using static LVGLSharp.NativeWindows;

lv_init();

var display = lv_windows_create_display("Test", 800, 480, 100, false, false);

lv_windows_acquire_pointer_indev(display);

lv_windows_acquire_keypad_indev(display);

lv_windows_acquire_encoder_indev(display);

var active = lv_screen_active();

lv_obj_set_flex_flow(active, lv_flex_flow_t.LV_FLEX_FLOW_COLUMN);
lv_obj_set_flex_align(active, lv_flex_align_t.LV_FLEX_ALIGN_CENTER, lv_flex_align_t.LV_FLEX_ALIGN_START, lv_flex_align_t.LV_FLEX_ALIGN_CENTER);

var cb = lv_checkbox_create(active);
lv_checkbox_set_text(cb, "Apple");

var button = lv_button_create(active);
lv_obj_set_size(button, 100, 50);
var label = lv_label_create(button);
lv_label_set_text(label, "Button");
lv_obj_center(label);

while (true)
{
    await Task.Delay(lv_timer_handler());
}