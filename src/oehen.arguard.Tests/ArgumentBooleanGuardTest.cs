using System;


namespace oehen.arguard
{
    public class ArgumentBooleanGuardTest
    {
        [Fact]
        public void ArgumentBooleanGuardTest_ThrowIfTrue_When_argument_is_True_Then_Should_Throw_ArgumentException()
        {
            const bool argument = true;
            Action act = () => argument.ThrowIfTrue(nameof(argument));
            act.ShouldThrow<ArgumentException>();
        }

        [Fact]
        public void ArgumentBooleanGuardTest_ThrowIfFalse_When_argument_is_False_Then_Should_Throw_ArgumentException()
        {
            const bool argument = false;
            Action act = () => argument.ThrowIfFalse(nameof(argument));
            act.ShouldThrow<ArgumentException>();
        }

        [Fact]
        public void
            ArgumentBooleanGuardTest_ThrowIfTrue_When_argument_is_False_Then_Should_not_Throw_ArgumentException()
        {
            const bool argument = false;
            Action act = () => argument.ThrowIfTrue(nameof(argument));
            act.ShouldNotThrow();
        }

        [Fact]
        public void
            ArgumentBooleanGuardTest_ThrowIfFalse_When_argument_is_True_Then_Should_not_Throw_ArgumentException()
        {
            const bool argument = true;
            Action act = () => argument.ThrowIfFalse(nameof(argument));
            act.ShouldNotThrow();
        }
    }
}