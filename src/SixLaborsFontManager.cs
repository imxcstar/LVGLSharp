using LVGLSharp.Interop;
using SixLabors.Fonts;
using SixLabors.Fonts.Unicode;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Drawing;
using SixLabors.ImageSharp.Drawing.Processing;
using SixLabors.ImageSharp.Memory;
using SixLabors.ImageSharp.PixelFormats;
using SixLabors.ImageSharp.Processing;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace LVGLSharp
{
    public unsafe class SixLaborsFontManager : IDisposable
    {
        private Font _font = null!;
        private float _lineHeight;
        private lv_font_t* _nativeLvFont;
        private HashSet<uint> _fallbackFOntUnicodeLetterRange = null!;
        private Configuration _configuration = null!;
        private float _dpi;

        private readonly Dictionary<uint, IntPtr> _allocatedGlyphBitmaps = new();
        private static readonly Dictionary<IntPtr, SixLaborsFontManager> s_fontManagers = new();
        private static readonly object s_lock = new();

        public SixLaborsFontManager(string fontPath, float size, float dpi = 72f, lv_font_t* fallback = null, HashSet<uint>? fallbackFOntUnicodeLetterRange = null)
        {
            FontCollection collection = new();
            FontFamily family = collection.Add(fontPath);
            var font = family.CreateFont(size, FontStyle.Regular);
            Init(font, dpi, fallback, fallbackFOntUnicodeLetterRange);
        }

        public SixLaborsFontManager(Font font, float dpi = 72f, lv_font_t* fallback = null, HashSet<uint>? fallbackFOntUnicodeLetterRange = null)
        {
            Init(font, dpi, fallback, fallbackFOntUnicodeLetterRange);
        }

        public SixLaborsFontManager(FontFamily fontFamily, float size, float dpi = 72f, lv_font_t* fallback = null, HashSet<uint>? fallbackFOntUnicodeLetterRange = null)
        {
            Init(new Font(fontFamily, size), dpi, fallback, fallbackFOntUnicodeLetterRange);
        }

        private void Init(Font font, float dpi = 72f, lv_font_t* fallback = null, HashSet<uint>? fallbackFOntUnicodeLetterRange = null)
        {
            Configuration.Default.MemoryAllocator = MemoryAllocator.Create(new MemoryAllocatorOptions()
            {
                MaximumPoolSizeMegabytes = 8,
                AllocationLimitMegabytes = 8
            });

            _dpi = dpi;

            _fallbackFOntUnicodeLetterRange = fallbackFOntUnicodeLetterRange ?? new HashSet<uint>();

            _font = font;

            _nativeLvFont = (lv_font_t*)NativeMemory.Alloc((nuint)sizeof(lv_font_t));
            NativeMemory.Clear(_nativeLvFont, (nuint)sizeof(lv_font_t));

            _configuration = Configuration.Default.Clone();
            _configuration.PreferContiguousImageBuffers = true;

            float scale = _font.Size / _font.FontMetrics.UnitsPerEm;
            var horizontalMetrics = _font.FontMetrics.HorizontalMetrics;
            float lineHeightPx = horizontalMetrics.LineHeight * scale;

            _lineHeight = lineHeightPx;

            _nativeLvFont->get_glyph_dsc = &GetGlyphDsc;
            _nativeLvFont->get_glyph_bitmap = &GetGlyphBitmap;
            _nativeLvFont->release_glyph = &ReleaseGlyph;
            _nativeLvFont->line_height = (int)Math.Round(lineHeightPx);
            _nativeLvFont->base_line = 0;
            _nativeLvFont->underline_position = (sbyte)Math.Round(_font.FontMetrics.UnderlinePosition * scale);
            _nativeLvFont->underline_thickness = (sbyte)Math.Round(_font.FontMetrics.UnderlineThickness * scale);
            _nativeLvFont->subpx = 0;
            _nativeLvFont->kerning = 0;
            _nativeLvFont->static_bitmap = 0;
            _nativeLvFont->fallback = fallback;
            _nativeLvFont->dsc = _nativeLvFont;

            lock (s_lock)
            {
                s_fontManagers[(IntPtr)_nativeLvFont] = this;
            }
        }

        public lv_font_t* GetLvFontPtr()
        {
            return _nativeLvFont;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl) })]
        private static c_bool1 GetGlyphDsc(lv_font_t* font, lv_font_glyph_dsc_t* dsc_out, uint unicode_letter, uint unicode_letter_next)
        {
            if (!TryGetManager(font, out var manager)) return false;

            if (manager._fallbackFOntUnicodeLetterRange.Contains(unicode_letter))
                return false;

            var slFont = manager._font;

            if (!slFont.TryGetGlyphs(new CodePoint(unicode_letter), out var glyphs) || glyphs.Count == 0)
            {
                return false;
            }

            var glyph = glyphs[0];
            var glyphMetrics = glyph.GlyphMetrics;

            float scale = slFont.Size / slFont.FontMetrics.UnitsPerEm;

            FontRectangle bbox = glyph.BoundingBox(GlyphLayoutMode.Horizontal, Vector2.Zero, manager._dpi);

            string characterToDraw = char.ConvertFromUtf32((int)unicode_letter);
            var options = new TextOptions(slFont)
            {
                Dpi = manager._dpi,
                Origin = new PointF(0, 0)
            };
            var paths = TextBuilder.GenerateGlyphs(characterToDraw, options);

            var glyphPath = paths.First();
            var bounds = glyphPath.Bounds;

            dsc_out->adv_w = (ushort)Math.Round(glyphMetrics.AdvanceWidth * scale * manager._dpi / 72f);
            dsc_out->box_w = (ushort)Math.Ceiling(bbox.Width + bounds.Left);
            dsc_out->box_h = (ushort)Math.Round(bbox.Height + bounds.Top);
            dsc_out->ofs_x = 0;
            dsc_out->ofs_y = (short)Math.Round(manager._lineHeight - dsc_out->box_h);
            dsc_out->stride = dsc_out->box_w;
            dsc_out->format = lv_font_glyph_format_t.LV_FONT_GLYPH_FORMAT_A8;
            dsc_out->is_placeholder = 0;
            dsc_out->gid.index = unicode_letter;

            return true;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl) })]
        private static void* GetGlyphBitmap(lv_font_glyph_dsc_t* dsc, lv_draw_buf_t* draw_buf)
        {
            if (dsc->resolved_font == null || dsc->box_w <= 0 || dsc->box_h <= 0) return null;
            if (!TryGetManager(dsc->resolved_font, out var manager)) return null;

            var unicodeCodePoint = dsc->gid.index;
            var slFont = manager._font;

            string characterToDraw = char.ConvertFromUtf32((int)unicodeCodePoint);

            using var image = new Image<A8>(manager._configuration, dsc->box_w, dsc->box_h);
            image.Mutate(x => x.DrawText(new RichTextOptions(slFont)
            {
                Origin = new PointF(0, 0),
                HorizontalAlignment = HorizontalAlignment.Left,
                VerticalAlignment = VerticalAlignment.Top,
                Dpi = manager._dpi
            }, characterToDraw, Color.Black));

            int bufferSize = dsc->box_w * dsc->box_h;
            if (draw_buf->data_size < bufferSize)
                return null;

            var destinationSpan = new Span<byte>(draw_buf->data, bufferSize);
            image.CopyPixelDataTo(destinationSpan);

            return draw_buf;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl) })]
        private static void ReleaseGlyph(lv_font_t* font, lv_font_glyph_dsc_t* dsc)
        {
            if (!TryGetManager(font, out var manager)) return;

            var letterId = dsc->gid.index;
            if (manager._allocatedGlyphBitmaps.TryGetValue(letterId, out var pointer))
            {
                Marshal.FreeHGlobal(pointer);
                manager._allocatedGlyphBitmaps.Remove(letterId);
            }
        }

        private static bool TryGetManager(lv_font_t* font, out SixLaborsFontManager manager)
        {
            lock (s_lock)
            {
                return s_fontManagers.TryGetValue((IntPtr)font->dsc, out manager);
            }
        }

        public void Dispose()
        {
            lock (s_lock)
            {
                if (_nativeLvFont == null) return;

                foreach (var ptr in _allocatedGlyphBitmaps.Values)
                {
                    Marshal.FreeHGlobal(ptr);
                }
                _allocatedGlyphBitmaps.Clear();

                s_fontManagers.Remove((IntPtr)_nativeLvFont);

                NativeMemory.Free(_nativeLvFont);
                _nativeLvFont = null;
            }
            GC.SuppressFinalize(this);
        }
    }
}