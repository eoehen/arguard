using System.Globalization;
using System.IO;

namespace oehen.arguard
{
    /// <summary>
    ///     Argument FilePath validation.
    /// </summary>
    public static class ArgumentDirectoryPathGuard
    {
        /// <summary>
        ///     Throws an <see cref="DirectoryNotFoundException" /> if directory path in <paramref name="directoryPath" /> not
        ///     exists.
        /// </summary>
        /// <param name="directoryPath">Argument value.</param>
        /// <param name="nameOfArgument">Name of the argument.</param>
        /// <example>
        ///     <para>Throws when the directory path in `argument` not exists.</para>
        ///     <code>
        /// <![CDATA[
        ///     argument.ThrowIfDirectoryNotExists(nameof(argument));
        /// ]]>
        /// </code>
        /// </example>
        public static void ThrowIfDirectoryNotExists(this string directoryPath, string nameOfArgument)
        {
            if (!Directory.Exists(directoryPath))
            {
                throw new DirectoryNotFoundException(string.Format(CultureInfo.CurrentCulture,
                    ExceptionMessageResourceManager.GetMessage("ThrowIfDirectoryNotExists"),
                    nameOfArgument));
            }
        }
    }
}