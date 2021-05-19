using System;
using System.Globalization;

namespace oehen.arguard
{
    /// <summary>
    ///     Argument <see cref="bool" /> validation.
    /// </summary>
    public static class ArgumentBooleanGuard
    {
        /// <summary>
        ///     Throws an <see cref="ArgumentException" /> if <paramref name="argument" /> is true.
        /// </summary>
        /// <param name="argument">Argument value.</param>
        /// <param name="nameOfArgument">Name of the argument.</param>
        /// <example>
        ///     <para>Throws when the argument `argument` is true.</para>
        ///     <code>
        /// <![CDATA[
        ///     argument.ThrowIfTrue(nameof(argument));
        /// ]]>
        /// </code>
        /// </example>
        public static void ThrowIfTrue(this bool argument, string nameOfArgument)
        {
            if (argument)
            {
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture,
                    ExceptionMessageResourceManager.GetMessage("ThrowIfTrue"),
                    nameOfArgument));
            }
        }

        /// <summary>
        ///     Throws an <see cref="ArgumentException" /> if <paramref name="argument" /> is false.
        /// </summary>
        /// <param name="argument">Argument value.</param>
        /// <param name="nameOfArgument">Name of the argument.</param>
        /// <example>
        ///     <para>Throws when the argument `argument` is false.</para>
        ///     <code>
        /// <![CDATA[
        ///     argument.ThrowIfFalse(nameof(argument));
        /// ]]>
        /// </code>
        /// </example>
        public static void ThrowIfFalse(this bool argument, string nameOfArgument)
        {
            if (!argument)
            {
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture,
                    ExceptionMessageResourceManager.GetMessage("ThrowIfFalse"),
                    nameOfArgument));
            }
        }
    }
}