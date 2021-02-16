﻿using JetBrains.Annotations;
using System;

namespace oehen.arguard
{
    /// <summary>
    /// Argument null validation.
    /// </summary>
    public static class ArgumentNullGuard
    {
        /// <summary>
        /// Throws an <see cref="ArgumentNullException"/> if <paramref name="argument"/> is null.
        /// </summary>
        /// <param name="argument">Argument value.</param>
        /// <param name="nameOfArgument">Name of the argument.</param>
        /// <example>
        /// <para>Throws when the argument `objArgument` is null.</para>
        /// <code>
        /// <![CDATA[
        ///     objArgument.ThrowIfNull(nameof(objArgument));
        /// ]]>
        /// </code>
        /// </example>        
        [AssertionMethod]
        public static void ThrowIfNull([ValidatedNotNull]this object argument, string nameOfArgument)
        {
            if (argument == null) 
                throw new ArgumentNullException(nameOfArgument);
        }
    }
}
