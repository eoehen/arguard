// ReSharper disable UnusedVariable
using System;

namespace oehen.arguard.LessThan;

[UseCulture("en-US")]
public class ArgumentIntLessThanZeroGuardTest
{
    [Theory]
    [InlineData(-1)]
    [InlineData(-2)]
    [InlineData(-3)]
    [InlineData(-123456)]
    public void Int_ThrowIfIsLessThanZero_ShouldThrowArgumentOutOfRangeException_IfArgumentValueIsNegative(int argument)
    {
        var exception = Assert.Throws<ArgumentOutOfRangeException>(() =>
        {
            argument.ThrowIfIsLessThanZero(nameof(argument));
        });
#if NET472
#elif NET48
            exception.Message.ShouldStartWith($"Argument is less than 0.");
#else
            exception.Message.ShouldBe("Argument is less than 0. (Parameter 'argument')" +
                                          Environment.NewLine + $"Actual value was {argument}.");
#endif
    }

    [Theory]
    [InlineData(1)]
    [InlineData(2)]
    [InlineData(3)]
    [InlineData(123456)]
    [InlineData(int.MaxValue)]
    public void Int_ThrowIfIsLessThanZero_ShouldNotThrowArgumentOutOfRangeException_IfArgumentIsMoreThanZero(
        int argument)
    {
        var exception = Record.Exception(() => { argument.ThrowIfIsLessThanZero(nameof(argument)); });
        Assert.Null(exception);
    }

    [Fact]
    public void Int_ThrowIfIsLessThanZero_ShouldNotThrowArgumentOutOfRangeException_IfArgumentIsZero()
    {
        const int argument = 0;
        var exception = Record.Exception(() => { argument.ThrowIfIsLessThanZero(nameof(argument)); });
        Assert.Null(exception);
    }
}