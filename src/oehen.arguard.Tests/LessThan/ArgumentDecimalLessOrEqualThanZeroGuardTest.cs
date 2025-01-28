// ReSharper disable UnusedVariable
using System;

namespace oehen.arguard.LessThan;

[UseCulture("en-US")]
public class ArgumentDecimalLessOrEqualThanZeroGuardTest
{
    [Theory]
    [InlineData(-1.33)]
    [InlineData(-2.55)]
    [InlineData(-3.5889)]
    [InlineData(-123456.789)]
    public void Decimal_ThrowIfIsLessOrEqualThanZero_ShouldThrowArgumentOutOfRangeException_IfArgumentValueIsNegative(
        decimal argument)
    {
        var exception = Assert.Throws<ArgumentOutOfRangeException>(() =>
        {
            argument.ThrowIfIsLessOrEqualThanZero(nameof(argument));
        });
#if NET472
#elif NET48
            exception.Message.ShouldStartWith($"Argument is less or equal than 0.");
#else
            exception.Message.ShouldBe("Argument is less or equal than 0. (Parameter 'argument')" +
                                          Environment.NewLine + $"Actual value was {argument}.");
#endif
    }

    [Fact]
    public void Decimal_ThrowIfIsLessOrEqualThanZero_ShouldThrowArgumentOutOfRangeException_IfArgumentIsZero()
    {
        const decimal argument = 0;
        var exception = Assert.Throws<ArgumentOutOfRangeException>(() =>
        {
            argument.ThrowIfIsLessOrEqualThanZero(nameof(argument));
        });

#if NET472
#elif NET48
            exception.Message.ShouldStartWith($"Argument is less or equal than 0.");
#else
            exception.Message.ShouldBe("Argument is less or equal than 0. (Parameter 'argument')" +
                                          Environment.NewLine + "Actual value was 0.");
#endif
    }

    [Theory]
    [InlineData(1.23)]
    [InlineData(2.23)]
    [InlineData(3.23)]
    [InlineData(123456.23)]
    [InlineData(int.MaxValue)]
    public void Decimal_ThrowIfIsLessOrEqualThanZero_ShouldNotThrowArgumentOutOfRangeException_IfArgumentIsMoreThanZero(
        decimal argument)
    {
        var exception = Record.Exception(() => { argument.ThrowIfIsLessOrEqualThanZero(nameof(argument)); });
        Assert.Null(exception);
    }
}