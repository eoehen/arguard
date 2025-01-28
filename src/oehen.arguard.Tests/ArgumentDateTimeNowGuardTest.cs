using System;

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
            act.ShouldThrow<InvalidOperationException>();
        }

        [Fact]
        public void
            ThrowIfIsLessThanNow_When_Argument_Is_Now_Should_Throw_InvalidOperationException()
        {
            var argument = DateTime.Now;
            Action act = () => argument.ThrowIfIsLessThanNow(nameof(argument));
            act.ShouldThrow<InvalidOperationException>();
        }

        [Fact]
        public void
            ThrowIfIsLessThanNow_When_Argument_Is_Today_Should_Throw_InvalidOperationException()
        {
            var argument = DateTime.Today;
            Action act = () => argument.ThrowIfIsLessThanNow(nameof(argument));
            act.ShouldThrow<InvalidOperationException>();
        }

        [Fact]
        public void
            ThrowIfIsLessThanNow_When_Argument_Is_Tomorrow_Should_Not_Throw_InvalidOperationException()
        {
            var argument = DateTime.Now.AddDays(1);
            Action act = () => argument.ThrowIfIsLessThanNow(nameof(argument));
            act.ShouldNotThrow();
        }

        [Fact]
        public void
            ThrowIfIsLessThanNow_When_Argument_Is_Tomorrow_Should_Return_Tomorrow()
        {
            var argument = DateTime.Now.AddDays(1);
            var result = argument.ThrowIfIsLessThanNow(nameof(argument));
            result.ShouldBe((argument));
        }

        [Fact]
        public void
            ThrowIfIsLaterThanNow_When_Argument_Is_Yesterday_Should_Not_Throw_InvalidOperationException()
        {
            var argument = DateTime.Now.AddDays(-1);
            Action act = () => argument.ThrowIfIsLaterThanNow(nameof(argument));
            act.ShouldNotThrow();
        }
        
        [Fact]
        public void
            ThrowIfIsLaterThanNow_When_Argument_Is_Yesterday_Should_Return_Yesterday()
        {
            var argument = DateTime.Now.AddDays(-1);
            var result = argument.ThrowIfIsLaterThanNow(nameof(argument));
            result.ShouldBe((argument));
        }
        
        [Fact]
        public void
            ThrowIfIsLaterThanNow_When_Argument_Is_Now_Should_Not_Throw_InvalidOperationException()
        {
            var argument = DateTime.Now;
            Action act = () => argument.ThrowIfIsLaterThanNow(nameof(argument));
            act.ShouldNotThrow();
        }

        [Fact]
        public void
            ThrowIfIsLaterThanNow_When_Argument_Is_Now_Should_Return_Now()
        {
            var argument = DateTime.Now;
            var result = argument.ThrowIfIsLaterThanNow(nameof(argument));
            result.ShouldBe((argument));
        }
        
        [Fact]
        public void
            ThrowIfIsLaterThanNow_When_Argument_Is_Today_Should_Not_Throw_InvalidOperationException()
        {
            var argument = DateTime.Today;
            Action act = () => argument.ThrowIfIsLaterThanNow(nameof(argument));
            act.ShouldNotThrow();
        }

        [Fact]
        public void
            ThrowIfIsLaterThanNow_When_Argument_Is_Today_Should_Return_Today()
        {
            var argument = DateTime.Today;
            var result = argument.ThrowIfIsLaterThanNow(nameof(argument));
            result.ShouldBe(argument);
        }
        
        [Fact]
        public void
            ThrowIfIsLaterThanNow_When_Argument_Is_Tomorrow_Should_Throw_InvalidOperationException()
        {
            var argument = DateTime.Now.AddDays(1);
            Action act = () => argument.ThrowIfIsLaterThanNow(nameof(argument));
            act.ShouldThrow<InvalidOperationException>();
        }
    }
}