using System;
using FluentAssertions;
using Xunit;

namespace oehen.arguard.Between
{
    [UseCulture("en-US")]
    public class ArgumentLongBetweenGuardTest
    {
        [Theory]
        [InlineData(4, 3, 8)]
        [InlineData(5, 3, 8)]
        [InlineData(7, 3, 8)]
        public void
            Long_ThrowIfIsBetween_Should_Throw_Exception_When_Argument_Is_Between_Start_And_End_Value(long argument, long compareValueStart, long compareValueEnd)
        {
            var exception = Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                argument.ThrowIfIsBetween(compareValueStart, compareValueEnd, nameof(argument));
            });
            exception.Message.Should().Be($"Argument is between {compareValueStart} and {compareValueEnd}. (Parameter 'argument')" +
                                          Environment.NewLine + $"Actual value was {argument}.");
        }

        [Theory]
        [InlineData(2, 3, 8)]
        [InlineData(1, 3, 8)]
        [InlineData(9, 3, 8)]
        [InlineData(10, 3, 8)]
        public void
            Long_ThrowIfIsBetween_Should_Not_Throw_Exception_When_Argument_Is_Between_Start_And_End_Value(long argument, long compareValueStart, long compareValueEnd)
        {
            var exception = Record.Exception(() =>
            {
                argument.ThrowIfIsBetween(compareValueStart, compareValueEnd, nameof(argument));
            });
            Assert.Null(exception);
        }
    }
}