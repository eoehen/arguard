// ReSharper disable UnusedVariable
using System;

namespace oehen.arguard.LessThan;

[UseCulture("en-US")]
public class ArgumentDecimalLessThanGuardTest
{
    [Theory]
    [InlineData(-1.23, 0.23)]
    [InlineData(2.23, 3.23)]
    [InlineData(-3.23, 5.23)]
    [InlineData(5.23, 5.23)]
    public void
        Decimal_ThrowIfIsLessOrEqualThanCompareValue_ShouldThrowArgumentOutOfRangeException_IfArgumentValueIsLessOrEqualThanTheCompareValue(
            decimal argument, decimal compareValue)
    {
        var exception = Assert.Throws<ArgumentOutOfRangeException>(() =>
        {
            argument.ThrowIfIsLessOrEqualThan(compareValue, nameof(argument));
        });
#if NET472
#elif NET48
            exception.Message.ShouldStartWith($"Argument is less or equal than {compareValue}.");
#else
            exception.Message.ShouldBe($"Argument is less or equal than {compareValue}. (Parameter 'argument')" +
                                          Environment.NewLine + $"Actual value was {argument}.");
#endif
    }

    [Theory]
    [InlineData(-1.23, 0.23)]
    [InlineData(2.23, 3.23)]
    [InlineData(-3.23, 5.23)]
    public void
        Decimal_ThrowIfIsLessThanCompareValue_ShouldThrowArgumentOutOfRangeException_IfArgumentValueIsLessThanTheCompareValue(
            decimal argument, decimal compareValue)
    {
        var exception = Assert.Throws<ArgumentOutOfRangeException>(() =>
        {
            argument.ThrowIfIsLessThan(compareValue, nameof(argument));
        });
#if NET472
#elif NET48
            exception.Message.ShouldStartWith($"Argument is less than {compareValue}.");
#else
            exception.Message.ShouldBe($"Argument is less than {compareValue}. (Parameter 'argument')" +
                                          Environment.NewLine + $"Actual value was {argument}.");
#endif
    }

    [Theory]
    [InlineData(11.23, 2.23)]
    [InlineData(3.23, 2.23)]
    [InlineData(5.23, 3.23)]
    [InlineData(3.23, 3.23)]
    public void
        Decimal_ThrowIfIsLessThanCompareValue_ShouldNotThrowArgumentOutOfRangeException_IfArgumentValueIsGreaterThanTheCompareValue(
            decimal argument, decimal compareValue)
    {
        var exception = Record.Exception(() => { argument.ThrowIfIsLessThan(compareValue, nameof(argument)); });
        Assert.Null(exception);
    }

    [Theory]
    [InlineData(11.23, 2.23)]
    [InlineData(3.23, 2.23)]
    [InlineData(5.23, 3.23)]
    public void
        Decimal_ThrowIfIsLessOrEqualThanCompareValue_ShouldNotThrowArgumentOutOfRangeException_IfArgumentValueIsGreaterOrEqualThanTheCompareValue(
            decimal argument, decimal compareValue)
    {
        var exception = Record.Exception(() => { argument.ThrowIfIsLessOrEqualThan(compareValue, nameof(argument)); });
        Assert.Null(exception);
    }
}