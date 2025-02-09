﻿using System.Globalization;

namespace oehen.arguard;

/// <summary>
///     Argument equal validator.
/// </summary>
public static class ArgumentEqualGuard
{
    /// <summary>
    ///     Throws an <see cref="InvalidOperationException" /> if <paramref name="argument" /> is not equal
    ///     <paramref name="compareArgument"></paramref>
    ///     .
    /// </summary>
    /// <typeparam name="T">Generic argument type.</typeparam>
    /// <param name="argument">Argument value.</param>
    /// <param name="compareArgument">Compare argument object.</param>
    /// <param name="nameOfArgument">Name of the argument.</param>
    /// <example>
    ///     <para>Throws when <paramref name="argument" /> and <paramref name="compareArgument" /> are not equal.</para>
    ///     <code>
    /// <![CDATA[
    ///     var localVar = argument.ThrowIfNotEqual(nameof(argument), compareArgument);
    /// ]]>
    /// </code>
    /// </example>
    public static T ThrowIfNotEqual<T>(this T argument, T compareArgument, string nameOfArgument)
    {
        if (!argument.Equals(compareArgument))
        {
            throw new InvalidOperationException(string.Format(CultureInfo.CurrentCulture,
                ArgumentExceptionMessageResourceManager.GetMessage("ThrowIfNotEqual"),
                nameOfArgument, compareArgument));
        }

        return argument;
    }
}