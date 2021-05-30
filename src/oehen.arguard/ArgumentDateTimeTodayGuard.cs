using System;
using System.Globalization;

namespace oehen.arguard
{
    /// <summary>
    ///     Argument <see cref="DateTime.Today"/> validator.
    /// </summary>
    public static class ArgumentDateTimeTodayGuard
    {
        /// <summary>
        ///     Throws an <see cref="InvalidOperationException" /> if <paramref name="argument" /> is
        ///     not <see cref="DateTime.Today"/>.
        /// </summary>
        /// <param name="argument">Argument value.</param>
        /// <param name="nameOfArgument">Name of the argument.</param>
        /// <example>
        ///     <para>Throws when <paramref name="argument" /> is not <see cref="DateTime.Today"/>.</para>
        ///     <code>
        /// <![CDATA[
        ///     argument.ThrowIfNotToday(nameof(argument));
        /// ]]>
        /// </code>
        /// </example>
        public static void ThrowIfIsNotToday(this DateTime argument, string nameOfArgument)
        {
            if (argument.Date != DateTime.Today)
            {
                throw new InvalidOperationException(string.Format(CultureInfo.CurrentCulture,
                    ArgumentExceptionMessageResourceManager.GetMessage("ThrowIfNotToday"),
                    nameOfArgument));
            }
        }
        
        /// <summary>
        ///     Throws an <see cref="InvalidOperationException" /> if <paramref name="argument" /> is
        ///     less than<see cref="DateTime.Today"/>.
        /// </summary>
        /// <param name="argument">Argument value.</param>
        /// <param name="nameOfArgument">Name of the argument.</param>
        /// <example>
        ///     <para>Throws when <paramref name="argument" /> is less than <see cref="DateTime.Today"/>.</para>
        ///     <code>
        /// <![CDATA[
        ///     argument.ThrowIfLessThanToday(nameof(argument));
        /// ]]>
        /// </code>
        /// </example>
        public static void ThrowIfIsLessThanToday(this DateTime argument, string nameOfArgument)
        {
            if (argument.Date < DateTime.Today)
            {
                throw new InvalidOperationException(string.Format(CultureInfo.CurrentCulture,
                    ArgumentExceptionMessageResourceManager.GetMessage("ThrowIfLessThanToday"),
                    nameOfArgument));
            }
        }
        
        /// <summary>
        ///     Throws an <see cref="InvalidOperationException" /> if <paramref name="argument" /> is
        ///     later than<see cref="DateTime.Today"/>.
        /// </summary>
        /// <param name="argument">Argument value.</param>
        /// <param name="nameOfArgument">Name of the argument.</param>
        /// <example>
        ///     <para>Throws when <paramref name="argument" /> is later than <see cref="DateTime.Today"/>.</para>
        ///     <code>
        /// <![CDATA[
        ///     argument.ThrowIfNotLaterThanToday(nameof(argument));
        /// ]]>
        /// </code>
        /// </example>
        public static void ThrowIfIsLaterThanToday(this DateTime argument, string nameOfArgument)
        {
            if (argument.Date > DateTime.Today)
            {
                throw new InvalidOperationException(string.Format(CultureInfo.CurrentCulture,
                    ArgumentExceptionMessageResourceManager.GetMessage("ThrowIfLaterThanToday"),
                    nameOfArgument));
            }
        }
    }
}