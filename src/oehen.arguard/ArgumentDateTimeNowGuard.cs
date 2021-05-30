using System;
using System.Globalization;

namespace oehen.arguard
{
    /// <summary>
    ///     Argument <see cref="DateTime.Now"/> validator.
    /// </summary>
    public static class ArgumentDateTimeNowGuard
    {
        /// <summary>
        ///     Throws an <see cref="InvalidOperationException" /> if <paramref name="argument" /> is
        ///     less than<see cref="DateTime.Now"/>.
        /// </summary>
        /// <param name="argument">Argument value.</param>
        /// <param name="nameOfArgument">Name of the argument.</param>
        /// <example>
        ///     <para>Throws when <paramref name="argument" /> is less than <see cref="DateTime.Now"/>.</para>
        ///     <code>
        /// <![CDATA[
        ///     argument.ThrowIfIsLessThanNow(nameof(argument));
        /// ]]>
        /// </code>
        /// </example>
        public static void ThrowIfIsLessThanNow(this DateTime argument, string nameOfArgument)
        {
            if (argument.Date < DateTime.Now)
            {
                throw new InvalidOperationException(string.Format(CultureInfo.CurrentCulture,
                    ArgumentExceptionMessageResourceManager.GetMessage("ThrowIfIsLessThanNow"),
                    nameOfArgument));
            }
        }
        
        /// <summary>
        ///     Throws an <see cref="InvalidOperationException" /> if <paramref name="argument" /> is
        ///     later than<see cref="DateTime.Now"/>.
        /// </summary>
        /// <param name="argument">Argument value.</param>
        /// <param name="nameOfArgument">Name of the argument.</param>
        /// <example>
        ///     <para>Throws when <paramref name="argument" /> is later than <see cref="DateTime.Now"/>.</para>
        ///     <code>
        /// <![CDATA[
        ///     argument.ThrowIfIsLaterThanNow(nameof(argument));
        /// ]]>
        /// </code>
        /// </example>
        public static void ThrowIfIsLaterThanNow(this DateTime argument, string nameOfArgument)
        {
            if (argument.Date > DateTime.Now)
            {
                throw new InvalidOperationException(string.Format(CultureInfo.CurrentCulture,
                    ArgumentExceptionMessageResourceManager.GetMessage("ThrowIfIsLaterThanNow"),
                    nameOfArgument));
            }
        }
    }
}