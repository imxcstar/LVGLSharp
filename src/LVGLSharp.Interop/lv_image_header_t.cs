using System;

namespace LVGLSharp.Interop
{
    public readonly unsafe partial struct lv_image_header_t : IComparable, IComparable<lv_image_header_t>, IEquatable<lv_image_header_t>, IFormattable
    {
        public readonly void* Value;

        public lv_image_header_t(void* value)
        {
            Value = value;
        }

        public static lv_image_header_t NULL => new lv_image_header_t(null);

        public static bool operator ==(lv_image_header_t left, lv_image_header_t right) => left.Value == right.Value;

        public static bool operator !=(lv_image_header_t left, lv_image_header_t right) => left.Value != right.Value;

        public static bool operator <(lv_image_header_t left, lv_image_header_t right) => left.Value < right.Value;

        public static bool operator <=(lv_image_header_t left, lv_image_header_t right) => left.Value <= right.Value;

        public static bool operator >(lv_image_header_t left, lv_image_header_t right) => left.Value > right.Value;

        public static bool operator >=(lv_image_header_t left, lv_image_header_t right) => left.Value >= right.Value;

        public static explicit operator lv_image_header_t(void* value) => new lv_image_header_t(value);

        public static implicit operator void*(lv_image_header_t value) => value.Value;

        public static explicit operator lv_image_header_t(byte value) => new lv_image_header_t(unchecked((void*)(value)));

        public static explicit operator byte(lv_image_header_t value) => (byte)(value.Value);

        public static explicit operator lv_image_header_t(short value) => new lv_image_header_t(unchecked((void*)(value)));

        public static explicit operator short(lv_image_header_t value) => (short)(value.Value);

        public static explicit operator lv_image_header_t(int value) => new lv_image_header_t(unchecked((void*)(value)));

        public static explicit operator int(lv_image_header_t value) => (int)(value.Value);

        public static explicit operator lv_image_header_t(long value) => new lv_image_header_t(unchecked((void*)(value)));

        public static explicit operator long(lv_image_header_t value) => (long)(value.Value);

        public static explicit operator lv_image_header_t(nint value) => new lv_image_header_t(unchecked((void*)(value)));

        public static implicit operator nint(lv_image_header_t value) => (nint)(value.Value);

        public static explicit operator lv_image_header_t(sbyte value) => new lv_image_header_t(unchecked((void*)(value)));

        public static explicit operator sbyte(lv_image_header_t value) => (sbyte)(value.Value);

        public static explicit operator lv_image_header_t(ushort value) => new lv_image_header_t(unchecked((void*)(value)));

        public static explicit operator ushort(lv_image_header_t value) => (ushort)(value.Value);

        public static explicit operator lv_image_header_t(uint value) => new lv_image_header_t(unchecked((void*)(value)));

        public static explicit operator uint(lv_image_header_t value) => (uint)(value.Value);

        public static explicit operator lv_image_header_t(ulong value) => new lv_image_header_t(unchecked((void*)(value)));

        public static explicit operator ulong(lv_image_header_t value) => (ulong)(value.Value);

        public static explicit operator lv_image_header_t(nuint value) => new lv_image_header_t(unchecked((void*)(value)));

        public static implicit operator nuint(lv_image_header_t value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
                if (obj is lv_image_header_t other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of lv_image_header_t.");
        }

        public int CompareTo(lv_image_header_t other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

        public override bool Equals(object? obj) => (obj is lv_image_header_t other) && Equals(other);

        public bool Equals(lv_image_header_t other) => ((nuint)(Value)).Equals((nuint)(other.Value));

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

        public override string ToString() => ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => ((nuint)(Value)).ToString(format, formatProvider);
    }
}
