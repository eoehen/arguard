using System;
using System.Globalization;

namespace oehen.arguard
{
    /// <summary>
    ///     <see cref="int" /> argument validator.
    /// </summary>
    public static class ArgumentIntLessThanGuard
    {
        /// <summary>
        ///     Throws an <see cref="ArgumentOutOfRangeException" /> exception if the <paramref name="argument" /> is less than 0.
        /// </summary>
        /// <param name="argument">Argument value.</param>
        /// <param name="nameOfArgument">Name of the argument.</param>
        /// <example>
        ///     <para>Throws when the argument `intArgument` is less than 0.</para>
        ///     <code>
        /// <![CDATA[
        ///     var localVar = intArgument.ThrowIfIsLessThanZero(nameof(intArgument));
        /// ]]>
        /// </code>
        /// </example>
        public static int ThrowIfIsLessThanZero(this int argument, string nameOfArgument)
        {
            return argument.ThrowIfIsLessThan(0, nameOfArgument);
        }

        /// <summary>
        ///     Throws an <see cref="ArgumentOutOfRangeException" /> exception if the <paramref name="argument" /> is less than
        ///     <paramref name="compareValue" />.
        /// </summary>
        /// <param name="argument">Argument value.</param>
        /// <param name="compareValue">Value to compare.</param>
        /// <param name="nameOfArgument">Name of the argument.</param>
        /// <example>
        ///     <para>Throws when the argument `intArgument` is less than 5.</para>
        ///     <code>
        /// <![CDATA[
        ///     var localVar = intArgument.ThrowIfIsLessThan(nameof(intArgument), 5);
        /// ]]>
        /// </code>
        /// </example>
        public static int ThrowIfIsLessThan(this int argument, int compareValue, string nameOfArgument)
        {
            if (argument < compareValue)
            {
                throw new ArgumentOutOfRangeException(
                    nameOfArgument,
                    argument,
                    string.Format(CultureInfo.CurrentCulture,
                        ArgumentExceptionMessageResourceManager.GetMessage("ThrowIfIsLessThan"),
                        compareValue));
            }
            return argument;
        }

        /// <summary>
        ///     Throws an <see cref="ArgumentOutOfRangeException" /> exception if the <paramref name="argument" /> is less or equal
        ///     than 0.
        /// </summary>
        /// <param name="argument">Argument value.</param>
        /// <param name="nameOfArgument">Name of the argument.</param>
        /// <example>
        ///     <para>Throws when the argument `intArgument` is less or equal than 0.</para>
        ///     <code>
        /// <![CDATA[
        ///     var localVar = .ThrowIfIsLessOrEqualThanZero(nameof(intArgument));
        /// ]]>
        /// </code>
        /// </example>
        public static int ThrowIfIsLessOrEqualThanZero(this int argument, string nameOfArgument)
        {
            return argument.ThrowIfIsLessOrEqualThan(0, nameOfArgument);
        }

        /// <summary>
        ///     Throws an <see cref="ArgumentOutOfRangeException" /> exception if the <paramref name="argument" /> is less or equal
        ///     than <paramref name="compareValue" />.
        /// </summary>
        /// <param name="argument">Argument value.</param>
        /// <param name="compareValue">Value to compare.</param>
        /// <param name="nameOfArgument">Name of the argument.</param>
        /// <example>
        ///     <para>Throws when the argument `intArgument` value is less or equal than 5.</para>
        ///     <code>
        /// <![CDATA[
        ///     var localVar = intArgument.ThrowIfIsLessOrEqualThan(nameof(intArgument), 5);
        /// ]]>
        /// </code>
        /// </example>
        public static int ThrowIfIsLessOrEqualThan(this int argument, int compareValue, string nameOfArgument)
        {
            if (argument <= compareValue)
            {
                throw new ArgumentOutOfRangeException(
                    nameOfArgument,
                    argument,
                    string.Format(CultureInfo.CurrentCulture,
                        ArgumentExceptionMessageResourceManager.GetMessage("ThrowIfIsLessOrEqualThan"),
                        compareValue));
            }

            return argument;
        }
    }
}