using System;
using FluentAssertions;
using Xunit;

namespace oehen.arguard
{
    [UseCulture("en-US")]
    public class ArgumentEmtpyGuardTest
    {
        [Fact]
        public void ThrowIfIsNullOrEmpty_ShouldThrowArgumentNullException_If_StringArgumentIsNullOrEmpty()
        {
            const string argument = "";
            var exception = Assert.Throws<ArgumentNullException>(() =>
            {
                // ReSharper disable once ExpressionIsAlwaysNull
                argument.ThrowIfIsNullOrEmpty(nameof(argument));
            });
            exception.Message.Should().Be("Argument is null or empty. (Parameter 'argument')");
        }

        [Fact]
        public void ThrowIfIsNullOrEmpty_ShouldNotThrowArgumentOutOfRangeException_IfArgumentIsStringValue()
        {
            const string argument = "not empty value";
            var exception = Record.Exception(() => { argument.ThrowIfIsNullOrEmpty(nameof(argument)); });
            Assert.Null(exception);
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
            const string argument = " ";
            var exception = Assert.Throws<ArgumentNullException>(() =>
            {
                // ReSharper disable once ExpressionIsAlwaysNull
                argument.ThrowIfIsNullOrWhiteSpace(nameof(argument));
            });
            exception.Message.Should().Be("Argument is null or whitespace. (Parameter 'argument')");
        }

        [Fact]
        public void ThrowIfIsNullOrWhiteSpace_ShouldNotThrowArgumentOutOfRangeException_IfArgumentIsStringValue()
        {
            const string argument = "Hello";
            var exception = Record.Exception(() => { argument.ThrowIfIsNullOrWhiteSpace(nameof(argument)); });
            Assert.Null(exception);
        }
    }
}