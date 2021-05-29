using System.Collections.Generic;
using System.Globalization;

namespace oehen.arguard
{
    /// <summary>
    /// Exception message resource manager.
    /// </summary>
    internal static class ArgumentExceptionMessageResourceManager
    {
        /// <summary>
        /// Get all resource keys.
        /// </summary>
        /// <returns>List of resource keys.</returns>
        public static IEnumerable<string> GetAllKeys()
        {
            var keys = new List<string>();
            var enumerator = 
                ExceptionMessages.ResourceManager.GetResourceSet(CultureInfo.CurrentCulture, true, true).GetEnumerator();
            while (enumerator.MoveNext())
            {
                if (enumerator.Key != null)
                {
                    keys.Add(enumerator.Key.ToString());
                }
            }
            return keys;
        }

        /// <summary>
        /// Get localized message of <see cref="CultureInfo.CurrentCulture"/> 
        /// </summary>
        /// <param name="name">Resource key.</param>
        /// <returns>Localized message.</returns>
        public static string GetMessage(string name)
        {
            return ExceptionMessages.ResourceManager.GetString(name, CultureInfo.CurrentCulture);
        }
    }
}
