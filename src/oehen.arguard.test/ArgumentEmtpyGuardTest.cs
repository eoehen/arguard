using System;
using FluentAssertions;
using Xunit;

namespace oehen.arguard
{
    public class ArgumentEmtpyGuardTest
    {
        [Fact]
        public void ThrowIfIsNullOrEmpty_ShouldThrowArgumentNullException_If_StringArgumentIsNullOrEmpty()
        {
            string argument = "";
            var exception = Assert.Throws<ArgumentNullException>(() =>
            {
                // ReSharper disable once ExpressionIsAlwaysNull
                argument.ThrowIfIsNullOrEmpty(nameof(argument));
            });
            exception.Message.Should().Be("Argument is null or empty. (Parameter 'argument')");
        }

        [Fact]
        public void ThrowIfIsNullOrWhiteSpace_ShouldThrowArgumentNullException_If_StringArgumentIsNull()
        {
            string argument = null;
            var exception = Assert.Throws<ArgumentNullException>(() =>
            {
                // ReSharper disable once ExpressionIsAlwaysNull
                argument.ThrowIfIsNullOrWhiteSpace(nameof(argument));
            });
            exception.Message.Should().Be("Argument is null or whitespace. (Parameter 'argument')");
        }

        [Fact]
        public void ThrowIfIsNullOrWhiteSpace_ShouldThrowArgumentNullException_If_StringArgumentIsWhiteSpace()
        {
            string argument = " ";
            var exception = Assert.Throws<ArgumentNullException>(() =>
            {
                // ReSharper disable once ExpressionIsAlwaysNull
                argument.ThrowIfIsNullOrWhiteSpace(nameof(argument));
            });
            exception.Message.Should().Be("Argument is null or whitespace. (Parameter 'argument')");
        }

        [Fact]
        public void ThrowIfIsLessOrEqualThanZero_ShouldNotThrowArgumentOutOfRangeException_IfArgumentIsStringValue()
        {
            string argument = "Hello";
            var exception = Record.Exception(() =>
            {
                argument.ThrowIfIsNullOrWhiteSpace(nameof(argument));
            });
            Assert.Null(exception);
        }

    }
}
