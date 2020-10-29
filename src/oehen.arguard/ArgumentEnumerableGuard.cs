using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace oehen.arguard
{
    public static class ArgumentEnumerableGuard
    {
        /// <summary>
        ///     Checks if this argument is not null and has entries.
        /// </summary>
        public static void ThrowIfIsNullOrEmpty<T>([ValidatedNotNull]this IEnumerable<T> argument, string nameOfArgument)
        {
            argument.ThrowIfNull(nameOfArgument);
            if (!argument.Any())
                throw new ArgumentNullException(nameOfArgument,
                    ExceptionMessages.ResourceManager.GetString("ArgumentNullOrEmpty", CultureInfo.CurrentCulture));
        }
    }
}