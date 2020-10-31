using System;
using FluentAssertions;
using Xunit;

namespace oehen.arguard
{
    public class ArgumentNullGuardTest
    {
        [Fact]
        public void ThrowArgumentNullException_If_ObjectArgumentIsNull()
        {
            object argument = null;
            var exception = Assert.Throws<ArgumentNullException>(() =>
            {
                // ReSharper disable once ExpressionIsAlwaysNull
                argument.ThrowIfNull(nameof(argument));
            });
            exception.Message.Should().Be("Value cannot be null. (Parameter 'argument')");
        }

        [Fact]
        public void ThrowArgumentNullException_If_StringArgumentIsNull()
        {
            string argument = null;
            var exception = Assert.Throws<ArgumentNullException>(() =>
            {
                // ReSharper disable once ExpressionIsAlwaysNull
                argument.ThrowIfNull(nameof(argument));
            });
            exception.Message.Should().Be("Value cannot be null. (Parameter 'argument')");
        }

        [Fact]
        public void ThrowArgumentNullException_If_NullableIntArgumentIsNull()
        {
            int? argument = null;
            var exception = Assert.Throws<ArgumentNullException>(() =>
            {
                // ReSharper disable once ExpressionIsAlwaysNull
                argument.ThrowIfNull(nameof(argument));
            });
            exception.Message.Should().Be("Value cannot be null. (Parameter 'argument')");
        }

        [Fact]
        public void NotThrowIfIsLessOrEqualThanZero_ShouldNotThrowArgumentOutOfRangeException_IfArgumentIsNotNull()
        {
            string argument = "Hello";
            var exception = Record.Exception(() =>
            {
                argument.ThrowIfNull(nameof(argument));
            });
            Assert.Null(exception);
        }
    }
}
