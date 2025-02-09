﻿namespace oehen.arguard;

/// <summary>
///     <see cref="string" />> argument validator.
/// </summary>
public static class ArgumentEmtpyGuard
{
    /// <summary>
    ///     Throws an <see cref="ArgumentNullException" /> if the <paramref name="argument" /> is null or empty.
    /// </summary>
    /// <param name="argument">Argument value.</param>
    /// <param name="nameOfArgument">Name of the argument.</param>
    /// <example>
    ///     <para>How to validate argument `stringArgument`.</para>
    ///     <code>
    /// <![CDATA[
    ///     var localVar = stringArgument.ThrowIfIsNullOrEmpty(nameof(stringArgument));
    /// ]]>
    /// </code>
    /// </example>
    public static string ThrowIfIsNullOrEmpty([ArgumentValidatedNotNull] this string argument, string nameOfArgument)
    {
        if (string.IsNullOrEmpty(argument))
        {
            throw new ArgumentNullException(nameOfArgument,
                ArgumentExceptionMessageResourceManager.GetMessage("ArgumentNullOrEmpty"));
        }

        return argument;
    }

    /// <summary>
    ///     Throws an <see cref="ArgumentNullException" /> if the <paramref name="argument" /> is null or whitespace.
    /// </summary>
    /// <param name="argument">Argument value.</param>
    /// <param name="nameOfArgument">Name of the argument.</param>
    /// <example>
    ///     <para>How to validate argument `stringArgument`.</para>
    ///     <code>
    /// <![CDATA[
    ///     var localVar = stringArgument.ThrowIfIsNullOrWhiteSpace(nameof(stringArgument));
    /// ]]>
    /// </code>
    /// </example>
    public static string ThrowIfIsNullOrWhiteSpace([ArgumentValidatedNotNull] this string argument,
        string nameOfArgument)
    {
        if (string.IsNullOrWhiteSpace(argument))
        {
            throw new ArgumentNullException(nameOfArgument,
                ArgumentExceptionMessageResourceManager.GetMessage("ArgumentNullOrWhitespace"));
        }

        return argument;
    }
}