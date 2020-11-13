using System;
using System.Diagnostics.CodeAnalysis;

namespace oehen.arguard
{
    /// <summary>
    /// Validated not null attribute.
    /// </summary>
    [ExcludeFromCodeCoverage]
    [AttributeUsage(AttributeTargets.Parameter)]
    public sealed class ValidatedNotNullAttribute : Attribute
    {
    }
}