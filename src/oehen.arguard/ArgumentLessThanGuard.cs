using JetBrains.Annotations;
using System;
using System.Globalization;

namespace oehen.arguard
{
    /// <summary>
    /// Integer argument validation.
    /// </summary>
    public static class ArgumentLessThanGuard
    {
        /// <summary>
        /// Throws an <see cref="ArgumentOutOfRangeException"/> exception if the <paramref name="argument"/> is less than 0.
        /// </summary>
        /// <param name="argument">Argument value.</param>
        /// <param name="nameOfArgument">Name of the argument.</param>
        [AssertionMethod]
        public static void ThrowIfIsLessThanZero(this int argument, string nameOfArgument)
        {
            argument.ThrowIfIsLessThan(0, nameOfArgument);
        }

        /// <summary>
        /// Throws an <see cref="ArgumentOutOfRangeException"/> exception if the <paramref name="argument"/> is less than <paramref name="compareValue"/>.
        /// </summary>
        /// <param name="argument">Argument value.</param>
        /// <param name="compareValue">Value to compare.</param>
        /// <param name="nameOfArgument">Name of the argument.</param>
        [AssertionMethod]
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

        /// <summary>
        /// Throws an <see cref="ArgumentOutOfRangeException"/> exception if the <paramref name="argument"/> is less or equal than 0.
        /// </summary>
        /// <param name="argument">Argument value.</param>
        /// <param name="nameOfArgument">Name of the argument.</param>
        [AssertionMethod]
        public static void ThrowIfIsLessOrEqualThanZero(this int argument, string nameOfArgument)
        {
            argument.ThrowIfIsLessOrEqualThan(0, nameOfArgument);
        }

        /// <summary>
        /// Throws an <see cref="ArgumentOutOfRangeException"/> exception if the <paramref name="argument"/> is less or equal than <paramref name="compareValue"/>.
        /// </summary>
        /// <param name="argument">Argument value.</param>
        /// <param name="compareValue">Value to compare.</param>
        /// <param name="nameOfArgument">Name of the argument.</param>
        [AssertionMethod]
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