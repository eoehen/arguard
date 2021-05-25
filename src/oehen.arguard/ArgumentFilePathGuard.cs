using System;
using System.Globalization;
using System.IO;

namespace oehen.arguard
{
    /// <summary>
    ///     Argument FilePath validation.
    /// </summary>
    public static class ArgumentFilePathGuard
    {
        /// <summary>
        ///     Throws an <see cref="FileNotFoundException" /> if <paramref name="filePath" /> filepath not exists.
        /// </summary>
        /// <param name="filePath">Argument value.</param>
        /// <param name="nameOfArgument">Name of the argument.</param>
        /// <example>
        ///     <para>Throws when the file path in `argument` not exists.</para>
        ///     <code>
        /// <![CDATA[
        ///     argument.ThrowIfFileNotExists(nameof(argument));
        /// ]]>
        /// </code>
        /// </example>
        public static void ThrowIfFileNotExists(this string filePath, string nameOfArgument)
        {
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException(string.Format(CultureInfo.CurrentCulture,
                    ExceptionMessageResourceManager.GetMessage("ThrowIfFileNotExists"),
                    nameOfArgument), filePath);
            }
        }
    }
}