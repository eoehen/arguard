using System;
using FluentAssertions;
using Xunit;

namespace oehen.arguard.LessThan
{
    [UseCulture("en-US")]
    public class ArgumentIntLessOrEqualThanZeroGuardTest
    {
        [Theory]
        [InlineData(-1)]
        [InlineData(-2)]
        [InlineData(-3)]
        [InlineData(-123456)]
        public void Int_ThrowIfIsLessOrEqualThanZero_ShouldThrowArgumentOutOfRangeException_IfArgumentValueIsNegative(
            int argument)
        {
            var exception = Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                argument.ThrowIfIsLessOrEqualThanZero(nameof(argument));
            });
#if NET472
#elif NET48
            exception.Message.Should().StartWith($"Argument is less or equal than 0.");
#else
            exception.Message.Should().Be("Argument is less or equal than 0. (Parameter 'argument')" +
                                          Environment.NewLine + $"Actual value was {argument}.");
#endif
        }

        [Fact]
        public void Int_ThrowIfIsLessOrEqualThanZero_ShouldThrowArgumentOutOfRangeException_IfArgumentIsZero()
        {
            const int argument = 0;
            var exception = Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                argument.ThrowIfIsLessOrEqualThanZero(nameof(argument));
            });
#if NET472
#elif NET48
            exception.Message.Should().StartWith($"Argument is less or equal than 0.");
#else
            exception.Message.Should().Be("Argument is less or equal than 0. (Parameter 'argument')" +
                                          Environment.NewLine + $"Actual value was {argument}.");
#endif
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(123456)]
        [InlineData(int.MaxValue)]
        public void Int_ThrowIfIsLessOrEqualThanZero_ShouldNotThrowArgumentOutOfRangeException_IfArgumentIsMoreThanZero(
            int argument)
        {
            var exception = Record.Exception(() => { argument.ThrowIfIsLessOrEqualThanZero(nameof(argument)); });
            Assert.Null(exception);
        }
    }
}