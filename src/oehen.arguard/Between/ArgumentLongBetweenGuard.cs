using System.Globalization;

namespace oehen.arguard.Between;

/// <summary>
///     <see cref="long" /> argument between validator.
/// </summary>
public static class ArgumentLongBetweenGuard
{
    /// <summary>
    ///     Throws an <see cref="ArgumentOutOfRangeException" /> exception if the <paramref name="argument" /> is between
    ///     <paramref name="compareValueStart" /> and <paramref name="compareValueEnd" />.
    /// </summary>
    /// <param name="argument">Argument value.</param>
    /// <param name="compareValueStart">Start range to compare.</param>
    /// <param name="compareValueEnd">End range to compare.</param>
    /// <param name="nameOfArgument">Name of the argument.</param>
    /// <example>
    ///     <para>Throws when the argument `longArgument` is between 5 and 10.</para>
    ///     <code>
    /// <![CDATA[
    ///     var localVar = longArgument.ThrowIfIsBetween(5, 10, nameof(intArgument));
    /// ]]>
    /// </code>
    /// </example>
    public static long ThrowIfIsBetween(this long argument, long compareValueStart, long compareValueEnd,
        string nameOfArgument)
    {
        if (argument > compareValueStart && argument < compareValueEnd)
        {
            throw new ArgumentOutOfRangeException(
                nameOfArgument,
                argument,
                string.Format(CultureInfo.CurrentCulture,
                    ArgumentExceptionMessageResourceManager.GetMessage("ThrowIfIsBetween"),
                    compareValueStart, compareValueEnd));
        }

        return argument;
    }
}