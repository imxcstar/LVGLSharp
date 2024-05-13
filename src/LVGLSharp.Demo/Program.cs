using System.Runtime.InteropServices;
using System.Text;
using lvgl;

lv_init.LvInit();

var display = lv_windows_display.LvWindowsCreateDisplay("Test", 800, 480, 100, false, false);

lv_windows_input.LvWindowsAcquirePointerIndev(display);
lv_windows_input.LvWindowsAcquireKeypadIndev(display);
lv_windows_input.LvWindowsAcquireEncoderIndev(display);

var active = lv_display.LvDisplayGetScreenActive(lv_display.LvDisplayGetDefault());

lv_flex.LvObjSetFlexFlow(active, LvFlexFlowT.LV_FLEX_FLOW_COLUMN);
lv_flex.LvObjSetFlexAlign(active, LvFlexAlignT.LV_FLEX_ALIGN_CENTER, LvFlexAlignT.LV_FLEX_ALIGN_START, LvFlexAlignT.LV_FLEX_ALIGN_CENTER);

var fontStyle = new LvStyleT();
lv_style.LvStyleInit(fontStyle);
var fontData = File.ReadAllBytes(@"C:\Windows\Fonts\msyh.ttc");
var fontDataPtr = Marshal.AllocHGlobal(fontData.Length);
Marshal.Copy(fontData, 0, fontDataPtr, fontData.Length);
var font = lv_tiny_ttf.LvTinyTtfCreateData(fontDataPtr, (ulong)fontData.LongLength, 16);
lv_style_gen.LvStyleSetTextFont(fontStyle, font);

var textbox = lv_textarea.LvTextareaCreate(active);
lv_obj_style.LvObjAddStyle(textbox, fontStyle, 0);
lv_obj_pos.LvObjSetSize(textbox, 150, 80);

var cb = lv_checkbox.LvCheckboxCreate(active);
lv_obj_style.LvObjAddStyle(cb, fontStyle, 0);
lv_checkbox.LvCheckboxSetText(cb, "测试");

var button = lv_button.LvButtonCreate(active);
var label = lv_label.LvLabelCreate(button);
var i = 0;
lv_obj_pos.LvObjSetSize(button, 100, 50);
lv_obj_event.LvObjAddEventCb(button, e =>
{
    i++;
    lv_label.LvLabelSetText(label, $"点击 {i}");
}, LvEventCodeT.LV_EVENT_CLICKED, 0);
lv_obj_style.LvObjAddStyle(label, fontStyle, 0);
lv_label.LvLabelSetText(label, "按钮");
lv_obj_pos.LvObjAlign(label, (byte)LvAlignT.LV_ALIGN_CENTER, 0, 0);

while (true)
{
    await Task.Delay((int)lv_timer.LvTimerHandler());
}