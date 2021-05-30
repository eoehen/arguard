using System;
using System.Globalization;

namespace oehen.arguard
{
    /// <summary>
    ///     Argument equal validator.
    /// </summary>
    public static class ArgumentEqualGuard
    {
        /// <summary>
        ///     Throws an <see cref="InvalidOperationException" /> if <paramref name="argument" /> is not equal <param name="compareArgument"></param>.
        /// </summary>
        /// <param name="argument">Argument value.</param>
        /// <param name="compareArgument">Compare object.</param>
        /// <param name="nameOfArgument">Name of the argument.</param>
        /// <example>
        ///     <para>Throws when the argument `argument` and `compareArgument` are not equal.</para>
        ///     <code>
        /// <![CDATA[
        ///     argument.ThrowIfNotEqual(nameof(argument), compareArgument);
        /// ]]>
        /// </code>
        /// </example>
        public static void ThrowIfNotEqual<T>(this T argument, T compareArgument, string nameOfArgument)
        {
            if (!argument.Equals(compareArgument))
            {
                throw new InvalidOperationException(string.Format(CultureInfo.CurrentCulture,
                    ArgumentExceptionMessageResourceManager.GetMessage("ThrowIfNotEqual"),
                    nameOfArgument));
            }
        }
    }
}