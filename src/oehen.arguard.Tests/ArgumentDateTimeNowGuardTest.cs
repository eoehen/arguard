using System;
using FluentAssertions;
using Xunit;

namespace oehen.arguard
{
    public class ArgumentDateTimeNowGuardTest
    {
        [Fact]
        public void
            ThrowIfIsLessThanNow_When_Argument_Is_Yesterday_Should_Throw_InvalidOperationException()
        {
            var argument = DateTime.Now.AddDays(-1);
            Action act = () => argument.ThrowIfIsLessThanNow(nameof(argument));
            act.Should().Throw<InvalidOperationException>();
        }

        [Fact]
        public void
            ThrowIfIsLessThanNow_When_Argument_Is_Now_Should_Throw_InvalidOperationException()
        {
            var argument = DateTime.Now;
            Action act = () => argument.ThrowIfIsLessThanNow(nameof(argument));
            act.Should().Throw<InvalidOperationException>();
        }

        [Fact]
        public void
            ThrowIfIsLessThanNow_When_Argument_Is_Today_Should_Throw_InvalidOperationException()
        {
            var argument = DateTime.Today;
            Action act = () => argument.ThrowIfIsLessThanNow(nameof(argument));
            act.Should().Throw<InvalidOperationException>();
        }

        [Fact]
        public void
            ThrowIfIsLessThanNow_When_Argument_Is_Tomorrow_Should_Not_Throw_InvalidOperationException()
        {
            var argument = DateTime.Now.AddDays(1);
            Action act = () => argument.ThrowIfIsLessThanNow(nameof(argument));
            act.Should().NotThrow<InvalidOperationException>();
        }

        [Fact]
        public void
            ThrowIfIsLaterThanNow_When_Argument_Is_Yesterday_Should_Not_Throw_InvalidOperationException()
        {
            var argument = DateTime.Now.AddDays(-1);
            Action act = () => argument.ThrowIfIsLaterThanNow(nameof(argument));
            act.Should().NotThrow<InvalidOperationException>();
        }

        [Fact]
        public void
            ThrowIfIsLaterThanNow_When_Argument_Is_Now_Should_Not_Throw_InvalidOperationException()
        {
            var argument = DateTime.Now;
            Action act = () => argument.ThrowIfIsLaterThanNow(nameof(argument));
            act.Should().NotThrow<InvalidOperationException>();
        }

        [Fact]
        public void
            ThrowIfIsLaterThanNow_When_Argument_Is_Today_Should_Not_Throw_InvalidOperationException()
        {
            var argument = DateTime.Today;
            Action act = () => argument.ThrowIfIsLaterThanNow(nameof(argument));
            act.Should().NotThrow<InvalidOperationException>();
        }

        [Fact]
        public void
            ThrowIfIsLaterThanNow_When_Argument_Is_Tomorrow_Should_Throw_InvalidOperationException()
        {
            var argument = DateTime.Now.AddDays(1);
            Action act = () => argument.ThrowIfIsLaterThanNow(nameof(argument));
            act.Should().Throw<InvalidOperationException>();
        }
    }
}