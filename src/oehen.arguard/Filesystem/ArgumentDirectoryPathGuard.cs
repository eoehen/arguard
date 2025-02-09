﻿using System.Globalization;
using System.IO;

namespace oehen.arguard.Filesystem;

/// <summary>
///     Argument directory path validator.
/// </summary>
public static class ArgumentDirectoryPathGuard
{
    /// <summary>
    ///     Throws an <see cref="DirectoryNotFoundException" /> if directory path in <paramref name="directoryPath" /> not
    ///     exists.
    /// </summary>
    /// <param name="directoryPath">Argument value.</param>
    /// <param name="nameOfArgument">Name of the argument.</param>
    /// <example>
    ///     <para>Throws when the directory path in `argument` not exists.</para>
    ///     <code>
    /// <![CDATA[
    ///     var localVar = argument.ThrowIfDirectoryNotExists(nameof(argument));
    /// ]]>
    /// </code>
    /// </example>
    public static string ThrowIfDirectoryNotExists(this string directoryPath, string nameOfArgument)
    {
        if (!Directory.Exists(directoryPath))
        {
            throw new DirectoryNotFoundException(string.Format(CultureInfo.CurrentCulture,
                ArgumentExceptionMessageResourceManager.GetMessage("ThrowIfDirectoryNotExists"),
                nameOfArgument));
        }

        return directoryPath;
    }
}