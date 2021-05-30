﻿using System;
using System.Globalization;

namespace oehen.arguard
{
    /// <summary>
    ///     Argument type validator.
    /// </summary>
    public static class ArgumentTypeGuard
    {
        /// <summary>
        ///     Throws an <see cref="InvalidOperationException" /> if <paramref name="argument" /> is not type of <typeparamref name="T"/>.
        /// </summary>
        /// <param name="argument">Argument value.</param>
        /// <param name="nameOfArgument">Name of the argument.</param>
        /// <example>
        ///     <para>Throws when <paramref name="argument"/> is not type of <typeparamref name="T"/>.</para>
        ///     <code>
        /// <![CDATA[
        ///     argument.ThrowIfNotTypeOf<T>(nameof(argument));
        /// ]]>
        /// </code>
        /// </example>
        public static void ThrowIfNotTypeOf<T>(this object argument, string nameOfArgument)
        {
            if (!(argument is T))
            {
                throw new InvalidOperationException(string.Format(CultureInfo.CurrentCulture,
                    ArgumentExceptionMessageResourceManager.GetMessage("ThrowIfNotTypeOf"),
                    nameOfArgument, typeof(T).Name));
            }
        }
        
        /// <summary>
        ///     Throws an <see cref="InvalidOperationException" /> if <paramref name="argument" /> is not type of <paramref name="type"/>.
        /// </summary>
        /// <param name="argument">Argument value.</param>
        /// <param name="type">Compare type.</param>
        /// <param name="nameOfArgument">Name of the argument.</param>
        /// <typeparam name="T"></typeparam>
        /// <exception cref="InvalidOperationException"></exception>
        /// <example>
        ///     <para>Throws when <paramref name="argument"/> is not type of <paramref name="type"/>.</para>
        ///     <code>
        /// <![CDATA[
        ///     argument.ThrowIfNotTypeOf(nameof(argument), typeof(String));
        /// ]]>
        /// </code>
        /// </example>
        public static void ThrowIfNotTypeOf<T>(this T argument, Type type, string nameOfArgument)
        {
            if (typeof(T) != type)
            {
                throw new InvalidOperationException(string.Format(CultureInfo.CurrentCulture,
                    ArgumentExceptionMessageResourceManager.GetMessage("ThrowIfNotTypeOf"),
                    nameOfArgument, typeof(T).Name));
            }
        }
    }
}