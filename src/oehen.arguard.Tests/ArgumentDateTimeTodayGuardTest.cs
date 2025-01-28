using System;


namespace oehen.arguard
{
    public class ArgumentDateTimeGuardTest
    {
        [Fact]
        public void
            ThrowIfIsNotToday_When_Argument_Is_Yesterday_Should_Throw_InvalidOperationException()
        {
            var argument = DateTime.Now.AddDays(-1);
            Action act = () => argument.ThrowIfIsNotToday(nameof(argument));
            act.ShouldThrow<InvalidOperationException>();
        }

        [Fact]
        public void
            ThrowIfIsNotToday_When_Argument_Is_Tomorrow_Should_Throw_InvalidOperationException()
        {
            var argument = DateTime.Now.AddDays(1);
            Action act = () => argument.ThrowIfIsNotToday(nameof(argument));
            act.ShouldThrow<InvalidOperationException>();
        }

        [Fact]
        public void
            ThrowIfIsNotToday_When_Argument_Is_Today_Should_Not_Throw_InvalidOperationException()
        {
            var argument = DateTime.Today;
            Action act = () => argument.ThrowIfIsNotToday(nameof(argument));
            act.ShouldNotThrow();
        }

        [Fact]
        public void
            ThrowIfIsNotToday_When_Argument_Is_Today_Should_Return_ArgumentValue()
        {
            var argument = DateTime.Today;
            var result = argument.ThrowIfIsNotToday(nameof(argument));
            result.ShouldBe(argument);
        }

        [Fact]
        public void
            ThrowIfIsNotToday_When_Argument_Is_Now_Should_Not_Throw_InvalidOperationException()
        {
            var argument = DateTime.Now;
            Action act = () => argument.ThrowIfIsNotToday(nameof(argument));
            act.ShouldNotThrow();
        }

        [Fact]
        public void
            ThrowIfIsNotToday_When_Argument_Is_Now_Should_Return_ArgumentValue()
        {
            var argument = DateTime.Now;
            var result = argument.ThrowIfIsNotToday(nameof(argument));
            result.ShouldBe(argument);
        }
        
        [Fact]
        public void
            ThrowIfIsLessThanToday_When_Argument_Is_Yesterday_Should_Throw_InvalidOperationException()
        {
            var argument = DateTime.Now.AddDays(-1);
            Action act = () => argument.ThrowIfIsLessThanToday(nameof(argument));
            act.ShouldThrow<InvalidOperationException>();
        }

        [Fact]
        public void
            ThrowIfIsLessThanToday_When_Argument_Is_Now_Should_Not_Throw_InvalidOperationException()
        {
            var argument = DateTime.Now;
            Action act = () => argument.ThrowIfIsLessThanToday(nameof(argument));
            act.ShouldNotThrow();
        }
        
        [Fact]
        public void
            ThrowIfIsLessThanToday_When_Argument_Is_Now_Should_Return_ArgumentValue()
        {
            var argument = DateTime.Now;
            var result = argument.ThrowIfIsLessThanToday(nameof(argument));
            result.ShouldBe(argument);
        }
        
        [Fact]
        public void
            ThrowIfIsLessThanToday_When_Argument_Is_Today_Should_Not_Throw_InvalidOperationException()
        {
            var argument = DateTime.Today;
            Action act = () => argument.ThrowIfIsLessThanToday(nameof(argument));
            act.ShouldNotThrow();
        }

        [Fact]
        public void
            ThrowIfIsLessThanToday_When_Argument_Is_Today_Should_Return_ArgumentValue()
        {
            var argument = DateTime.Today;
            var result = argument.ThrowIfIsLessThanToday(nameof(argument));
            result.ShouldBe(argument);
        }

        [Fact]
        public void
            ThrowIfIsLessThanToday_When_Argument_Is_Tomorrow_Should_Not_Throw_InvalidOperationException()
        {
            var argument = DateTime.Now.AddDays(1);
            Action act = () => argument.ThrowIfIsLessThanToday(nameof(argument));
            act.ShouldNotThrow();
        }
        
        [Fact]
        public void
            ThrowIfIsLessThanToday_When_Argument_Is_Tomorrow_Should_Return_ArgumentValue()
        {
            var argument = DateTime.Now.AddDays(1);
            var result = argument.ThrowIfIsLessThanToday(nameof(argument));
            result.ShouldBe(argument);
        }
        
        [Fact]
        public void
            ThrowIfIsLaterThanToday_When_Argument_Is_Yesterday_Should_Not_Throw_InvalidOperationException()
        {
            var argument = DateTime.Now.AddDays(-1);
            Action act = () => argument.ThrowIfIsLaterThanToday(nameof(argument));
            act.ShouldNotThrow();
        }

        [Fact]
        public void
            ThrowIfIsLaterThanToday_When_Argument_Is_Yesterday_Should_Return_ArgumentValue()
        {
            var argument = DateTime.Now.AddDays(-1);
            var result = argument.ThrowIfIsLaterThanToday(nameof(argument));
            result.ShouldBe(argument);
        }

        [Fact]
        public void
            ThrowIfIsLaterThanToday_When_Argument_Is_Now_Should_Not_Throw_InvalidOperationException()
        {
            var argument = DateTime.Now;
            Action act = () => argument.ThrowIfIsLaterThanToday(nameof(argument));
            act.ShouldNotThrow();
        }

        [Fact]
        public void
            ThrowIfIsLaterThanToday_When_Argument_Is_Now_Should_Return_ArgumentValue()
        {
            var argument = DateTime.Now;
            var result = argument.ThrowIfIsLaterThanToday(nameof(argument));
            result.ShouldBe(argument);
        }

        [Fact]
        public void
            ThrowIfIsLaterThanToday_When_Argument_Is_Today_Should_Not_Throw_InvalidOperationException()
        {
            var argument = DateTime.Today;
            Action act = () => argument.ThrowIfIsLaterThanToday(nameof(argument));
            act.ShouldNotThrow();
        }

        [Fact]
        public void
            ThrowIfIsLaterThanToday_When_Argument_Is_Today_Should_Return_ArgumentValue()
        {
            var argument = DateTime.Today;
            var result = argument.ThrowIfIsLaterThanToday(nameof(argument));
            result.ShouldBe(argument);
        }

        [Fact]
        public void
            ThrowIfIsLaterThanToday_When_Argument_Is_Tomorrow_Should_Throw_InvalidOperationException()
        {
            var argument = DateTime.Now.AddDays(1);
            Action act = () => argument.ThrowIfIsLaterThanToday(nameof(argument));
            act.ShouldThrow<InvalidOperationException>();
        }
    }
}