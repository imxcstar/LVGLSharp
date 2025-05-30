namespace LVGLSharp.Interop
{
    public unsafe partial struct lv_font_class_t
    {
        [NativeTypeName("lv_font_t *(*)(const lv_font_info_t *, const void *)")]
        public delegate* unmanaged[Cdecl]<lv_font_info_t*, void*, lv_font_t*> create_cb;

        [NativeTypeName("void (*)(lv_font_t *)")]
        public delegate* unmanaged[Cdecl]<lv_font_t*, void> delete_cb;

        [NativeTypeName("void *(*)(const void *)")]
        public delegate* unmanaged[Cdecl]<void*, void*> dup_src_cb;

        [NativeTypeName("void (*)(void *)")]
        public delegate* unmanaged[Cdecl]<void*, void> free_src_cb;
    }
}
