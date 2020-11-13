using System;
using System.Globalization;

namespace oehen.arguard
{
    /// <summary>
    /// String argument null or empty validation.
    /// </summary>
    public static class ArgumentEmtpyGuard
    {
        /// <summary>
        /// Throws an <see cref="ArgumentNullException"/> if the <paramref name="argument"/> is null or empty.
        /// </summary>
        /// <param name="argument">Argument value.</param>
        /// <param name="nameOfArgument">Name of the argument.</param>
        public static void ThrowIfIsNullOrEmpty([ValidatedNotNull]this string argument, string nameOfArgument)
        {
            if (string.IsNullOrEmpty(argument))
                throw new ArgumentNullException(nameOfArgument,
                    ExceptionMessages.ResourceManager.GetString("ArgumentNullOrEmpty", CultureInfo.CurrentCulture));
        }

        /// <summary>
        /// Throws an <see cref="ArgumentNullException"/> if the <paramref name="argument"/> is null or whitespace.
        /// </summary>
        /// <param name="argument">Argument value.</param>
        /// <param name="nameOfArgument">Name of the argument.</param>
        public static void ThrowIfIsNullOrWhiteSpace([ValidatedNotNull]this string argument, string nameOfArgument)
        {
            if (string.IsNullOrWhiteSpace(argument))
                throw new ArgumentNullException(nameOfArgument,
                    ExceptionMessages.ResourceManager.GetString("ArgumentNullOrWhitespace",
                        CultureInfo.CurrentCulture));
        }
    }
}