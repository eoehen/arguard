using System;
using System.Diagnostics.CodeAnalysis;

namespace oehen.arguard
{
    [ExcludeFromCodeCoverage]
    [AttributeUsage(AttributeTargets.Parameter)]
    public sealed class ValidatedNotNullAttribute : Attribute
    {
    }
}