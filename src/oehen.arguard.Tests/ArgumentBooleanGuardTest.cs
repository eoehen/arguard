using System;
using FluentAssertions;
using Xunit;

namespace oehen.arguard
{
    public class ArgumentBooleanGuardTest
    {
        [Fact]
        public void ArgumentBooleanGuardTest_ThrowIfTrue_When_argument_is_True_Then_Should_Throw_ArgumentException()
        {
            const bool argument = true;
            Action act = () => argument.ThrowIfTrue(nameof(argument));;
            act.Should().Throw<ArgumentException>();
        }

        [Fact]
        public void ArgumentBooleanGuardTest_ThrowIfFalse_When_argument_is_False_Then_Should_Throw_ArgumentException()
        {
            const bool argument = false;
            Action act = () => argument.ThrowIfFalse(nameof(argument));;
            act.Should().Throw<ArgumentException>();
        }

        [Fact]
        public void
            ArgumentBooleanGuardTest_ThrowIfTrue_When_argument_is_False_Then_Should_not_Throw_ArgumentException()
        {
            const bool argument = false;
            Action act = () => argument.ThrowIfTrue(nameof(argument));;
            act.Should().NotThrow<ArgumentException>();
        }

        [Fact]
        public void
            ArgumentBooleanGuardTest_ThrowIfFalse_When_argument_is_True_Then_Should_not_Throw_ArgumentException()
        {
            const bool argument = true;
            Action act = () => argument.ThrowIfFalse(nameof(argument));;
            act.Should().NotThrow<ArgumentException>();
        }
    }
}