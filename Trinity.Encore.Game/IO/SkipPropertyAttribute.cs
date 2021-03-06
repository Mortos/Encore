using System;

namespace Trinity.Encore.Game.IO
{
    /// <summary>
    /// Instructs ClientDbReader to not read a value for a property.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, Inherited = false)]
    public sealed class SkipPropertyAttribute : Attribute
    {
    }
}
