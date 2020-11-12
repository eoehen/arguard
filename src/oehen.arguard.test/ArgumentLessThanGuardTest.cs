using System;
using FluentAssertions;
using Xunit;

namespace oehen.arguard
{
    public class ArgumentLessThanGuardTest
    {
        [Theory]
        [InlineData(-1)]
        [InlineData(-2)]
        [InlineData(-3)]
        [InlineData(-123456)]
        public void ThrowIfIsLessOrEqualThanZero_ShouldThrowArgumentOutOfRangeException_IfArgumentValueIsNegative(int argument)
        {
            var exception = Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                argument.ThrowIfIsLessOrEqualThanZero(nameof(argument));
            });
            exception.Message.Should().Be("Argument is less or equal than 0. (Parameter 'argument')" +
                                          Environment.NewLine + $"Actual value was {argument}.");
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(-2)]
        [InlineData(-3)]
        [InlineData(-123456)]
        public void ThrowIfIsLessThanZero_ShouldThrowArgumentOutOfRangeException_IfArgumentValueIsNegative(int argument)
        {
            var exception = Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                argument.ThrowIfIsLessThanZero(nameof(argument));
            });
            exception.Message.Should().Be("Argument is less than 0. (Parameter 'argument')" +
                                          Environment.NewLine + $"Actual value was {argument}.");
        }

        [Fact]
        public void ThrowIfIsLessOrEqualThanZero_ShouldThrowArgumentOutOfRangeException_IfArgumentIsZero()
        {
            const int argument = 0;
            var exception = Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                argument.ThrowIfIsLessOrEqualThanZero(nameof(argument));
            });
            exception.Message.Should().Be("Argument is less or equal than 0. (Parameter 'argument')" +
                                          Environment.NewLine + "Actual value was 0.");
        }

        [Fact]
        public void ThrowIfIsLessThanZero_ShouldNotThrowArgumentOutOfRangeException_IfArgumentIsZero()
        {
            const int argument = 0;
            var exception = Record.Exception(() =>
            {
                argument.ThrowIfIsLessThanZero(nameof(argument));
            });
            Assert.Null(exception);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(123456)]
        [InlineData(int.MaxValue)]
        public void ThrowIfIsLessOrEqualThanZero_ShouldNotThrowArgumentOutOfRangeException_IfArgumentIsMoreThanZero(int argument)
        {
            var exception = Record.Exception(() =>
            {
                argument.ThrowIfIsLessOrEqualThanZero(nameof(argument));
            });
            Assert.Null(exception);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(123456)]
        [InlineData(int.MaxValue)]
        public void ThrowIfIsLessThanZero_ShouldNotThrowArgumentOutOfRangeException_IfArgumentIsMoreThanZero(int argument)
        {
            var exception = Record.Exception(() =>
            {
                argument.ThrowIfIsLessThanZero(nameof(argument));
            });
            Assert.Null(exception);
        }
    }
}
