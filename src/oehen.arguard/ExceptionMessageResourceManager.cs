using System.Collections.Generic;
using System.Globalization;

namespace oehen.arguard
{
    public static class ExceptionMessageResourceManager
    {
        public static IEnumerable<string> GetAllKeys()
        {
            var keys = new List<string>();
            var enumerator = 
                ExceptionMessages.ResourceManager.GetResourceSet(CultureInfo.CurrentCulture, true, true).GetEnumerator();
            while (enumerator.MoveNext())
            {
                keys.Add(enumerator.Key.ToString());
            }
            return keys;
        }

        public static string GetMessage(string name)
        {
            return ExceptionMessages.ResourceManager.GetString(name, CultureInfo.CurrentCulture);
        }
    }
}
