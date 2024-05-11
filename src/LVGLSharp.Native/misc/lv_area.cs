using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LVGLSharp
{
    public static partial class Native
    {
        public enum lv_align_t
        {
            LV_ALIGN_DEFAULT = 0,
            LV_ALIGN_TOP_LEFT,
            LV_ALIGN_TOP_MID,
            LV_ALIGN_TOP_RIGHT,
            LV_ALIGN_BOTTOM_LEFT,
            LV_ALIGN_BOTTOM_MID,
            LV_ALIGN_BOTTOM_RIGHT,
            LV_ALIGN_LEFT_MID,
            LV_ALIGN_RIGHT_MID,
            LV_ALIGN_CENTER,

            LV_ALIGN_OUT_TOP_LEFT,
            LV_ALIGN_OUT_TOP_MID,
            LV_ALIGN_OUT_TOP_RIGHT,
            LV_ALIGN_OUT_BOTTOM_LEFT,
            LV_ALIGN_OUT_BOTTOM_MID,
            LV_ALIGN_OUT_BOTTOM_RIGHT,
            LV_ALIGN_OUT_LEFT_TOP,
            LV_ALIGN_OUT_LEFT_MID,
            LV_ALIGN_OUT_LEFT_BOTTOM,
            LV_ALIGN_OUT_RIGHT_TOP,
            LV_ALIGN_OUT_RIGHT_MID,
            LV_ALIGN_OUT_RIGHT_BOTTOM,
        }
    }
}
