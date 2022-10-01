using System;
using FluentAssertions;
using Xunit;

namespace oehen.arguard.LessThan
{
    [UseCulture("en-US")]
    public class ArgumentLongLessThanZeroGuardTest
    {
        [Theory]
        [InlineData(-1)]
        [InlineData(-2)]
        [InlineData(-3)]
        [InlineData(-123456)]
        public void Long_ThrowIfIsLessThanZero_ShouldThrowArgumentOutOfRangeException_IfArgumentValueIsNegative(long argument)
        {
            var exception = Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                argument.ThrowIfIsLessThanZero(nameof(argument));
            });
            exception.Message.Should().Be("Argument is less than 0. (Parameter 'argument')" +
                                          Environment.NewLine + $"Actual value was {argument}.");
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(123456)]
        [InlineData(int.MaxValue)]
        public void Long_ThrowIfIsLessThanZero_ShouldNotThrowArgumentOutOfRangeException_IfArgumentIsMoreThanZero(
            long argument)
        {
            var exception = Record.Exception(() => { argument.ThrowIfIsLessThanZero(nameof(argument)); });
            Assert.Null(exception);
        }

        [Fact]
        public void Long_ThrowIfIsLessThanZero_ShouldNotThrowArgumentOutOfRangeException_IfArgumentIsZero()
        {
            const int argument = 0;
            var exception = Record.Exception(() => { argument.ThrowIfIsLessThanZero(nameof(argument)); });
            Assert.Null(exception);
        }
    }
}