using System;
using System.Globalization;

namespace oehen.arguard
{
    /// <summary>
    ///     <see cref="decimal" /> argument validator.
    /// </summary>
    public static class ArgumentDecimalLessThanGuard
    {
        /// <summary>
        ///     Throws an <see cref="ArgumentOutOfRangeException" /> exception if the <paramref name="argument" /> is less than 0.
        /// </summary>
        /// <param name="argument">Argument value.</param>
        /// <param name="nameOfArgument">Name of the argument.</param>
        /// <example>
        ///     <para>Throws when the decimal argument `decimalArgument` is less than 0.</para>
        ///     <code>
        /// <![CDATA[
        ///     var localVar = decimalArgument.ThrowIfIsLessThanZero(nameof(decimalArgument));
        /// ]]>
        /// </code>
        /// </example>
        public static decimal ThrowIfIsLessThanZero(this decimal argument, string nameOfArgument)
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
        ///     <para>Throws when the decimal argument `decimalArgument` is less than 5.</para>
        ///     <code>
        /// <![CDATA[
        ///     var localVar = decimalArgument.ThrowIfIsLessThan(nameof(decimalArgument), 5);
        /// ]]>
        /// </code>
        /// </example>
        public static decimal ThrowIfIsLessThan(this decimal argument, decimal compareValue, string nameOfArgument)
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
        ///     <para>Throws when the decimal argument `decimalArgument` is less or equal than 0.</para>
        ///     <code>
        /// <![CDATA[
        ///     var localVar = .ThrowIfIsLessOrEqualThanZero(nameof(decimalArgument));
        /// ]]>
        /// </code>
        /// </example>
        public static decimal ThrowIfIsLessOrEqualThanZero(this decimal argument, string nameOfArgument)
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
        ///     <para>Throws when the decimal argument `decimalArgument` value is less or equal than 5.</para>
        ///     <code>
        /// <![CDATA[
        ///     var localVar = decimalArgument.ThrowIfIsLessOrEqualThan(nameof(decimalArgument), 5);
        /// ]]>
        /// </code>
        /// </example>
        public static decimal ThrowIfIsLessOrEqualThan(this decimal argument, decimal compareValue, string nameOfArgument)
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