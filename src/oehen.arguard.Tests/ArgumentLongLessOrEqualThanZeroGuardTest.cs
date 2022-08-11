using System;
using FluentAssertions;
using Xunit;

namespace oehen.arguard
{
    [UseCulture("en-US")]
    public class ArgumentLongLessOrEqualThanZeroGuardTest
    {
        [Theory]
        [InlineData(-1)]
        [InlineData(-2)]
        [InlineData(-3)]
        [InlineData(-123456)]
        public void ThrowIfIsLessOrEqualThanZero_ShouldThrowArgumentOutOfRangeException_IfArgumentValueIsNegative(
            long argument)
        {
            var exception = Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                argument.ThrowIfIsLessOrEqualThanZero(nameof(argument));
            });
            exception.Message.Should().Be("Argument is less or equal than 0. (Parameter 'argument')" +
                                          Environment.NewLine + $"Actual value was {argument}.");
        }

        [Fact]
        public void ThrowIfIsLessOrEqualThanZero_ShouldThrowArgumentOutOfRangeException_IfArgumentIsZero()
        {
            const long argument = 0;
            var exception = Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                argument.ThrowIfIsLessOrEqualThanZero(nameof(argument));
            });
            exception.Message.Should().Be("Argument is less or equal than 0. (Parameter 'argument')" +
                                          Environment.NewLine + "Actual value was 0.");
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(123456)]
        [InlineData(int.MaxValue)]
        public void ThrowIfIsLessOrEqualThanZero_ShouldNotThrowArgumentOutOfRangeException_IfArgumentIsMoreThanZero(
            long argument)
        {
            var exception = Record.Exception(() => { argument.ThrowIfIsLessOrEqualThanZero(nameof(argument)); });
            Assert.Null(exception);
        }
    }
}