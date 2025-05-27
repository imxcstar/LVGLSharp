using System;
using System.Diagnostics;

namespace LVGLSharp.Interop
{
    /// <summary>Defines the layout of a bitfield as it was used in the native signature.</summary>
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = true, Inherited = true)]
    [Conditional("DEBUG")]
    internal sealed partial class NativeBitfieldAttribute : Attribute
    {
        private readonly string _name;
    private readonly int _offset;
    private readonly int _length;

        /// <summary>Initializes a new instance of the <see cref="NativeBitfieldAttribute" /> class.</summary>
        /// <param name="name">The name of the bitfield that was used in the native signature.</param>
    /// <param name="offset">The offset of the bitfield that was used in the native signature.</param>
    /// <param name="length">The length of the bitfield that was used in the native signature.</param>
        public NativeBitfieldAttribute(string name, int offset, int length)
        {
            _name = name;
        _offset = offset;
        _length = length;
        }

        /// <summary>Gets the length of the bitfield that was used in the native signature.</summary>
        public int Length => _length;

        /// <summary>Gets the name of the bitfield that was used in the native signature.</summary>
        public string Name => _name;

        /// <summary>Gets the offset of the bitfield that was used in the native signature.</summary>
        public int Offset => _offset;
    }
}
