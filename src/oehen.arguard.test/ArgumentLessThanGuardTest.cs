using System;
using FluentAssertions;
using Xunit;

namespace oehen.arguard
{
    public class ArgumentLessThanGuardTest
    {
        [Fact]
        public void ThrowIfIsLessOrEqualThanZero_ShouldThrowArgumentOutOfRangeException_IfArgumentIsMinusTwo()
        {
            const int argument = -2;
            var exception = Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                argument.ThrowIfIsLessOrEqualThanZero(nameof(argument));
            });
            exception.Message.Should().Be("Argument is less or equal than 0. (Parameter 'argument')" +
                                          Environment.NewLine + "Actual value was -2.");
        }

        [Fact]
        public void ThrowIfIsLessThanZero_ShouldThrowArgumentOutOfRangeException_IfArgumentIsMinusTwo()
        {
            const int argument = -2;
            var exception = Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                argument.ThrowIfIsLessThanZero(nameof(argument));
            });
            exception.Message.Should().Be("Argument is less than 0. (Parameter 'argument')" +
                                          Environment.NewLine + "Actual value was -2.");
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

        [Fact]
        public void ThrowIfIsLessOrEqualThanZero_ShouldNotThrowArgumentOutOfRangeException_IfArgumentIsMoreThanZero()
        {
            const int argument = 1;
            var exception = Record.Exception(() =>
            {
                argument.ThrowIfIsLessOrEqualThanZero(nameof(argument));
            });
            Assert.Null(exception);
        }

        [Fact]
        public void ThrowIfIsLessThanZero_ShouldNotThrowArgumentOutOfRangeException_IfArgumentIsMoreThanZero()
        {
            const int argument = 1;
            var exception = Record.Exception(() =>
            {
                argument.ThrowIfIsLessThanZero(nameof(argument));
            });
            Assert.Null(exception);
        }
    }
}
