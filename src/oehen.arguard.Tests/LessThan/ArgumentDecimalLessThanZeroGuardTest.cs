using System;


namespace oehen.arguard.LessThan
{
    [UseCulture("en-US")]
    public class ArgumentDecimalLessThanZeroGuardTest
    {
        [Theory]
        [InlineData(-1.33)]
        [InlineData(-2.55)]
        [InlineData(-3.5889)]
        [InlineData(-123456.789)]
        public void Decimal_ThrowIfIsLessThanZero_ShouldThrowArgumentOutOfRangeException_IfArgumentValueIsNegative(decimal argument)
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
        [InlineData(1.33)]
        [InlineData(2.55)]
        [InlineData(3.5889)]
        [InlineData(123456)]
        public void Decimal_ThrowIfIsLessThanZero_ShouldNotThrowArgumentOutOfRangeException_IfArgumentIsMoreThanZero(
            decimal argument)
        {
            var exception = Record.Exception(() => { argument.ThrowIfIsLessThanZero(nameof(argument)); });
            Assert.Null(exception);
        }

        [Fact]
        public void Decimal_ThrowIfIsLessThanZero_ShouldNotThrowArgumentOutOfRangeException_IfArgumentIsZero()
        {
            const decimal argument = 0;
            var exception = Record.Exception(() => { argument.ThrowIfIsLessThanZero(nameof(argument)); });
            Assert.Null(exception);
        }
    }
}