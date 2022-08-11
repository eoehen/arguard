using System;
using FluentAssertions;
using Xunit;

namespace oehen.arguard
{
    [UseCulture("en-US")]
    public class ArgumentIntLessThanGuardTest
    {
        [Theory]
        [InlineData(-1, 0)]
        [InlineData(2, 3)]
        [InlineData(-3, 5)]
        [InlineData(5, 5)]
        public void
            ThrowIfIsLessOrEqualThanCompareValue_ShouldThrowArgumentOutOfRangeException_IfArgumentValueIsLessOrEqualThanTheCompareValue(
                int argument, int compareValue)
        {
            var exception = Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                argument.ThrowIfIsLessOrEqualThan(compareValue, nameof(argument));
            });
            exception.Message.Should().Be($"Argument is less or equal than {compareValue}. (Parameter 'argument')" +
                                          Environment.NewLine + $"Actual value was {argument}.");
        }

        [Theory]
        [InlineData(-1, 0)]
        [InlineData(2, 3)]
        [InlineData(-3, 5)]
        public void
            ThrowIfIsLessThanCompareValue_ShouldThrowArgumentOutOfRangeException_IfArgumentValueIsLessThanTheCompareValue(
                int argument, int compareValue)
        {
            var exception = Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                argument.ThrowIfIsLessThan(compareValue, nameof(argument));
            });
            exception.Message.Should().Be($"Argument is less than {compareValue}. (Parameter 'argument')" +
                                          Environment.NewLine + $"Actual value was {argument}.");
        }

        [Theory]
        [InlineData(11, 2)]
        [InlineData(3, 2)]
        [InlineData(5, 3)]
        [InlineData(3, 3)]
        public void
            ThrowIfIsLessThanCompareValue_ShouldNotThrowArgumentOutOfRangeException_IfArgumentValueIsGreaterThanTheCompareValue(
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
            ThrowIfIsLessOrEqualThanCompareValue_ShouldNotThrowArgumentOutOfRangeException_IfArgumentValueIsGreaterOrEqualThanTheCompareValue(
                int argument, int compareValue)
        {
            var exception = Record.Exception(() =>
            {
                argument.ThrowIfIsLessOrEqualThan(compareValue, nameof(argument));
            });
            Assert.Null(exception);
        }
    }
}