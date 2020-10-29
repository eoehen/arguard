using System;
using System.Globalization;

namespace oehen.arguard
{
    public static class ArgumentEmtpyGuard
    {
        public static void ThrowIfIsNullOrEmpty([ValidatedNotNull]this string argument, string nameOfArgument)
        {
            if (string.IsNullOrEmpty(argument))
                throw new ArgumentNullException(nameOfArgument,
                    ExceptionMessages.ResourceManager.GetString("ArgumentNullOrEmpty", CultureInfo.CurrentCulture));
        }

        public static void ThrowIfIsNullOrWhiteSpace([ValidatedNotNull]this string argument, string nameOfArgument)
        {
            if (string.IsNullOrWhiteSpace(argument))
                throw new ArgumentNullException(nameOfArgument,
                    ExceptionMessages.ResourceManager.GetString("ArgumentNullOrWhitespace",
                        CultureInfo.CurrentCulture));
        }
    }
}