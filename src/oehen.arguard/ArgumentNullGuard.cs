using System;

namespace oehen.arguard
{
    public static class ArgumentNullGuard
    {
        /// <summary>
        /// Checks if this argument is not null.
        /// </summary>
        public static void ThrowIfNull([ValidatedNotNull]this object argument, string nameOfArgument)
        {
            if (argument == null) 
                throw new ArgumentNullException(nameOfArgument);
        }
    }
}
