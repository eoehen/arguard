using System.Globalization;

namespace oehen.arguard.LessThan;

/// <summary>
///     <see cref="long" /> argument validator.
/// </summary>
public static class ArgumentLongLessThanGuard
{
    /// <summary>
    ///     Throws an <see cref="ArgumentOutOfRangeException" /> exception if the <paramref name="argument" /> is less than 0.
    /// </summary>
    /// <param name="argument">Argument value.</param>
    /// <param name="nameOfArgument">Name of the argument.</param>
    /// <example>
    ///     <para>Throws when the long argument `longArgument` is less than 0.</para>
    ///     <code>
    /// <![CDATA[
    ///     var localVar = longArgument.ThrowIfIsLessThanZero(nameof(longArgument));
    /// ]]>
    /// </code>
    /// </example>
    public static long ThrowIfIsLessThanZero(this long argument, string nameOfArgument)
    {
        return argument.ThrowIfIsLessThan(0, nameOfArgument);
    }

    /// <summary>
    ///     Throws an <see cref="ArgumentOutOfRangeException" /> exception if the <paramref name="argument" /> is less than
    ///     <paramref name="compareValue" />.
    /// </summary>
    /// <param name="argument">Argument value.</param>
    /// <param name="compareValue">Value to compare.</param>
    /// <param name="nameOfArgument">Name of the argument.</param>
    /// <example>
    ///     <para>Throws when the long argument `longArgument` is less than 5.</para>
    ///     <code>
    /// <![CDATA[
    ///     var localVar = longArgument.ThrowIfIsLessThan(nameof(longArgument), 5);
    /// ]]>
    /// </code>
    /// </example>
    public static long ThrowIfIsLessThan(this long argument, long compareValue, string nameOfArgument)
    {
        if (argument < compareValue)
        {
            throw new ArgumentOutOfRangeException(
                nameOfArgument,
                argument,
                string.Format(CultureInfo.CurrentCulture,
                    ArgumentExceptionMessageResourceManager.GetMessage("ThrowIfIsLessThan"),
                    compareValue));
        }

        return argument;
    }

    /// <summary>
    ///     Throws an <see cref="ArgumentOutOfRangeException" /> exception if the <paramref name="argument" /> is less or equal
    ///     than 0.
    /// </summary>
    /// <param name="argument">Argument value.</param>
    /// <param name="nameOfArgument">Name of the argument.</param>
    /// <example>
    ///     <para>Throws when the long argument `longArgument` is less or equal than 0.</para>
    ///     <code>
    /// <![CDATA[
    ///     var localVar = .ThrowIfIsLessOrEqualThanZero(nameof(longArgument));
    /// ]]>
    /// </code>
    /// </example>
    public static long ThrowIfIsLessOrEqualThanZero(this long argument, string nameOfArgument)
    {
        return argument.ThrowIfIsLessOrEqualThan(0, nameOfArgument);
    }

    /// <summary>
    ///     Throws an <see cref="ArgumentOutOfRangeException" /> exception if the <paramref name="argument" /> is less or equal
    ///     than <paramref name="compareValue" />.
    /// </summary>
    /// <param name="argument">Argument value.</param>
    /// <param name="compareValue">Value to compare.</param>
    /// <param name="nameOfArgument">Name of the argument.</param>
    /// <example>
    ///     <para>Throws when the long argument `longArgument` value is less or equal than 5.</para>
    ///     <code>
    /// <![CDATA[
    ///     var localVar = longArgument.ThrowIfIsLessOrEqualThan(nameof(longArgument), 5);
    /// ]]>
    /// </code>
    /// </example>
    public static long ThrowIfIsLessOrEqualThan(this long argument, long compareValue, string nameOfArgument)
    {
        if (argument <= compareValue)
        {
            throw new ArgumentOutOfRangeException(
                nameOfArgument,
                argument,
                string.Format(CultureInfo.CurrentCulture,
                    ArgumentExceptionMessageResourceManager.GetMessage("ThrowIfIsLessOrEqualThan"),
                    compareValue));
        }

        return argument;
    }
}