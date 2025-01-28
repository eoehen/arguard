using System;


namespace oehen.arguard
{
    public class ArgumentEqualGuardTest
    {
        [Fact]
        public void
            ThrowIfNotEqual_When_String_Argument_Is_Same_As_CompareArgument_Should_Not_Throw_InvalidOperationException()
        {
            var argument = "xxxxx";
            var compareValue = argument;
            Action act = () => argument.ThrowIfNotEqual(compareValue, nameof(argument));
            act.ShouldNotThrow();
        }
        
        [Fact]
        public void
            ThrowIfNotEqual_When_String_Argument_Is_Same_As_CompareArgument_Should_Return_ArgumentValue()
        {
            var argument = "xxxxx";
            var compareValue = argument;
            var result = argument.ThrowIfNotEqual(compareValue, nameof(argument));
            result.ShouldBe(argument);
        }
        
        [Fact]
        public void
            ThrowIfNotEqual_When_String_Argument_Is_Not_Same_As_CompareArgument_Should_Throw_InvalidOperationException()
        {
            var argument = "xxxxx";
            var compareValue = "aaaaa";
            Action act = () => argument.ThrowIfNotEqual(compareValue, nameof(argument));
            act.ShouldThrow<InvalidOperationException>();
        }
    }
}