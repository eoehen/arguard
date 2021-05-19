using System;
using System.Collections.Generic;
using System.Linq;

namespace oehen.arguard
{
    /// <summary>
    /// Enumerable argument null or empty validator.
    /// </summary>
    public static class ArgumentEnumerableGuard
    {
        /// <summary>
        /// Throws an <see cref="ArgumentNullException"/> if the <paramref name="argument"/> is null or empty.
        /// </summary>
        /// <param name="argument">Argument value.</param>
        /// <param name="nameOfArgument">Name of the argument.</param>
        /// <example>
        /// <para>How to validate argument `enumerableArgument`.</para>
        /// <code>
        /// <![CDATA[
        ///     enumerableArgument.ThrowIfIsNullOrEmpty(nameof(enumerableArgument));
        /// ]]>
        /// </code>
        /// </example>
        public static void ThrowIfIsNullOrEmpty<T>([ValidatedNotNull]this IEnumerable<T> argument, string nameOfArgument)
        {
            argument.ThrowIfNull(nameOfArgument);
            if (!argument.Any())
            {
                throw new ArgumentNullException(nameOfArgument,
                    ExceptionMessageResourceManager.GetMessage("ArgumentNullOrEmpty"));
            }
        }
    }
}