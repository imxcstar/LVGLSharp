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
        [DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr lv_obj_add_event_cb(IntPtr obj, lv_event_cb_t event_cb, lv_event_code_t filter, IntPtr user_data);
    }
}
