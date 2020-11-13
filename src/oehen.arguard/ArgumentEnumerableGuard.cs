using System;
using System.Collections.Generic;
using System.Globalization;
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
        public static void ThrowIfIsNullOrEmpty<T>([ValidatedNotNull]this IEnumerable<T> argument, string nameOfArgument)
        {
            argument.ThrowIfNull(nameOfArgument);
            if (!argument.Any())
                throw new ArgumentNullException(nameOfArgument,
                    ExceptionMessages.ResourceManager.GetString("ArgumentNullOrEmpty", CultureInfo.CurrentCulture));
        }
    }
}