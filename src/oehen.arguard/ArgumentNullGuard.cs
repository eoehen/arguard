using System;

namespace oehen.arguard
{
    /// <summary>
    ///     <see cref="object" /> argument null validator.
    /// </summary>
    public static class ArgumentNullGuard
    {
        /// <summary>
        ///     Throws an <see cref="ArgumentNullException" /> if <paramref name="argument" /> is null.
        /// </summary>
        /// <param name="argument">Argument value.</param>
        /// <param name="nameOfArgument">Name of the argument.</param>
        /// <example>
        ///     <para>Throws when the argument `objArgument` is null.</para>
        ///     <code>
        /// <![CDATA[
        ///     var localVar = objArgument.ThrowIfNull(nameof(objArgument));
        /// ]]>
        /// </code>
        /// </example>
        public static T ThrowIfNull<T>([ArgumentValidatedNotNull] this T argument, string nameOfArgument)
        {
            if (object.Equals(argument, default(T)))
            {
                throw new ArgumentNullException(nameOfArgument);
            }

            return argument;
        }
    }
}