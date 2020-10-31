using System;
using System.Globalization;

namespace oehen.arguard
{
    public static class ArgumentLessThanGuard
    {
        public static void ThrowIfIsLessThanZero(this int argument, string nameOfArgument)
        {
            argument.ThrowIfIsLessThan(0, nameOfArgument);
        }

        public static void ThrowIfIsLessThan(this int argument, int compareValue, string nameOfArgument)
        {
            if (argument < compareValue)
                throw new ArgumentOutOfRangeException(
                    nameOfArgument,
                    argument,
                    string.Format(CultureInfo.CurrentCulture,
                        ExceptionMessages.ResourceManager.GetString(
                            "ThrowIfIsLessThan", CultureInfo.CurrentCulture) ?? "",
                        compareValue));
        }

        public static void ThrowIfIsLessOrEqualThanZero(this int argument, string nameOfArgument)
        {
            argument.ThrowIfIsLessOrEqualThan(0, nameOfArgument);
        }

        public static void ThrowIfIsLessOrEqualThan(this int argument, int compareValue, string nameOfArgument)
        {
            if (argument <= compareValue)
                throw new ArgumentOutOfRangeException(
                    nameOfArgument,
                    argument,
                    string.Format(CultureInfo.CurrentCulture,
                        ExceptionMessages.ResourceManager.GetString(
                            "ThrowIfIsLessOrEqualThan", CultureInfo.CurrentCulture) ?? "",
                        compareValue));
        }
    }
}