using System.Globalization;
using System.IO;

namespace oehen.arguard
{
    /// <summary>
    ///     Argument file path validator.
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
        ///     var localVar = argument.ThrowIfFileNotExists(nameof(argument));
        /// ]]>
        /// </code>
        /// </example>
        public static string ThrowIfFileNotExists(this string filePath, string nameOfArgument)
        {
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException(string.Format(CultureInfo.CurrentCulture,
                    ArgumentExceptionMessageResourceManager.GetMessage("ThrowIfFileNotExists"),
                    nameOfArgument), filePath);
            }

            return filePath;
        }
    }
}