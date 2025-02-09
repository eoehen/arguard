// ReSharper disable UnusedVariable
using System;

namespace oehen.arguard.LessThan;

[UseCulture("en-US")]
public class ArgumentIntLessThanGuardTest
{
    [Theory]
    [InlineData(-1, 0)]
    [InlineData(2, 3)]
    [InlineData(-3, 5)]
    [InlineData(5, 5)]
    public void
        Int_ThrowIfIsLessOrEqualThanCompareValue_ShouldThrowArgumentOutOfRangeException_IfArgumentValueIsLessOrEqualThanTheCompareValue(
            int argument, int compareValue)
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
    [InlineData(-1, 0)]
    [InlineData(2, 3)]
    [InlineData(-3, 5)]
    public void
        Int_ThrowIfIsLessThanCompareValue_ShouldThrowArgumentOutOfRangeException_IfArgumentValueIsLessThanTheCompareValue(
            int argument, int compareValue)
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
    [InlineData(11, 2)]
    [InlineData(3, 2)]
    [InlineData(5, 3)]
    [InlineData(3, 3)]
    public void
        Int_ThrowIfIsLessThanCompareValue_ShouldNotThrowArgumentOutOfRangeException_IfArgumentValueIsGreaterThanTheCompareValue(
            int argument, int compareValue)
    {
        var exception = Record.Exception(() => { argument.ThrowIfIsLessThan(compareValue, nameof(argument)); });
        Assert.Null(exception);
    }

    [Theory]
    [InlineData(11, 2)]
    [InlineData(3, 2)]
    [InlineData(5, 3)]
    public void
        Int_ThrowIfIsLessOrEqualThanCompareValue_ShouldNotThrowArgumentOutOfRangeException_IfArgumentValueIsGreaterOrEqualThanTheCompareValue(
            int argument, int compareValue)
    {
        var exception = Record.Exception(() => { argument.ThrowIfIsLessOrEqualThan(compareValue, nameof(argument)); });
        Assert.Null(exception);
    }
}