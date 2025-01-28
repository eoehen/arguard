using System.Collections.Generic;
using System.Linq;

namespace oehen.arguard;

/// <summary>
///     <see cref="Enumerable" /> argument validator.
/// </summary>
public static class ArgumentEnumerableGuard
{
    /// <summary>
    ///     Throws an <see cref="ArgumentNullException" /> if the <paramref name="argument" /> is null or empty.
    /// </summary>
    /// <param name="argument">Argument value.</param>
    /// <param name="nameOfArgument">Name of the argument.</param>
    /// <example>
    ///     <para>How to validate argument `enumerableArgument`.</para>
    ///     <code>
    /// <![CDATA[
    ///     var localVar = enumerableArgument.ThrowIfIsNullOrEmpty(nameof(enumerableArgument));
    /// ]]>
    /// </code>
    /// </example>
    public static IEnumerable<T> ThrowIfIsNullOrEmpty<T>([ArgumentValidatedNotNull] this IEnumerable<T> argument,
        string nameOfArgument)
    {
        var argumentAsArray = argument.ToArray();
        argumentAsArray.ThrowIfNull(nameOfArgument);
        if (argumentAsArray.Length == 0)
        {
            throw new ArgumentNullException(nameOfArgument,
                ArgumentExceptionMessageResourceManager.GetMessage("ArgumentNullOrEmpty"));
        }

        return argumentAsArray;
    }
}