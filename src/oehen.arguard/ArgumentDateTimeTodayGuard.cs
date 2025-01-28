using System.Globalization;

namespace oehen.arguard;

/// <summary>
///     Argument <see cref="DateTime.Today" /> validator.
/// </summary>
public static class ArgumentDateTimeTodayGuard
{
    /// <summary>
    ///     Throws an <see cref="InvalidOperationException" /> if <paramref name="argument" /> is
    ///     not <see cref="DateTime.Today" />.
    /// </summary>
    /// <param name="argument">Argument value.</param>
    /// <param name="nameOfArgument">Name of the argument.</param>
    /// <example>
    ///     <para>Throws when <paramref name="argument" /> is not <see cref="DateTime.Today" />.</para>
    ///     <code>
    /// <![CDATA[
    ///     var localVar = argument.ThrowIfNotToday(nameof(argument));
    /// ]]>
    /// </code>
    /// </example>
    public static DateTime ThrowIfIsNotToday(this DateTime argument, string nameOfArgument)
    {
        if (argument.Date != DateTime.Today)
        {
            throw new InvalidOperationException(string.Format(CultureInfo.CurrentCulture,
                ArgumentExceptionMessageResourceManager.GetMessage("ThrowIfNotToday"),
                nameOfArgument));
        }

        return argument;
    }

    /// <summary>
    ///     Throws an <see cref="InvalidOperationException" /> if <paramref name="argument" /> is
    ///     less than<see cref="DateTime.Today" />.
    /// </summary>
    /// <param name="argument">Argument value.</param>
    /// <param name="nameOfArgument">Name of the argument.</param>
    /// <example>
    ///     <para>Throws when <paramref name="argument" /> is less than <see cref="DateTime.Today" />.</para>
    ///     <code>
    /// <![CDATA[
    ///     var localVar = argument.ThrowIfLessThanToday(nameof(argument));
    /// ]]>
    /// </code>
    /// </example>
    public static DateTime ThrowIfIsLessThanToday(this DateTime argument, string nameOfArgument)
    {
        if (argument.Date < DateTime.Today)
        {
            throw new InvalidOperationException(string.Format(CultureInfo.CurrentCulture,
                ArgumentExceptionMessageResourceManager.GetMessage("ThrowIfLessThanToday"),
                nameOfArgument));
        }

        return argument;
    }

    /// <summary>
    ///     Throws an <see cref="InvalidOperationException" /> if <paramref name="argument" /> is
    ///     later than<see cref="DateTime.Today" />.
    /// </summary>
    /// <param name="argument">Argument value.</param>
    /// <param name="nameOfArgument">Name of the argument.</param>
    /// <example>
    ///     <para>Throws when <paramref name="argument" /> is later than <see cref="DateTime.Today" />.</para>
    ///     <code>
    /// <![CDATA[
    ///     var localVar = argument.ThrowIfNotLaterThanToday(nameof(argument));
    /// ]]>
    /// </code>
    /// </example>
    public static DateTime ThrowIfIsLaterThanToday(this DateTime argument, string nameOfArgument)
    {
        if (argument.Date > DateTime.Today)
        {
            throw new InvalidOperationException(string.Format(CultureInfo.CurrentCulture,
                ArgumentExceptionMessageResourceManager.GetMessage("ThrowIfLaterThanToday"),
                nameOfArgument));
        }

        return argument;
    }
}