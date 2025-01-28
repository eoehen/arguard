using System;


namespace oehen.arguard
{
    public class ArgumentTypeGuardTest
    {
        [Fact]
        public void ThrowIfNotTypeOf_When_String_Argument_Is_Not_TypeOf_Int_Should_Throw_InvalidOperationException()
        {
            const string argument = "England";
            Action act = () => argument.ThrowIfNotTypeOf<int>(nameof(argument));
            act.ShouldThrow<InvalidOperationException>();
        }

        [Fact]
        public void ThrowIfNotTypeOf_When_String_Argument_Is_TypeOf_String_Should_Not_Throw_InvalidOperationException()
        {
            const string argument = "England";
            Action act = () => argument.ThrowIfNotTypeOf<string>(nameof(argument));
            act.ShouldNotThrow();
        }

        [Fact]
        public void
            ThrowIfNotTypeOf_When_String_Argument_Is_Not_TypeOf_Int_CompareType_Should_Throw_InvalidOperationException()
        {
            const string argument = "England";
            Action act = () => argument.ThrowIfNotTypeOf(typeof(int), nameof(argument));
            act.ShouldThrow<InvalidOperationException>();
        }

        [Fact]
        public void
            ThrowIfNotTypeOf_When_String_Argument_Is_TypeOf_String_CompareType_Should_Not_Throw_InvalidOperationException()
        {
            const string argument = "England";
            Action act = () => argument.ThrowIfNotTypeOf(typeof(string), nameof(argument));
            act.ShouldNotThrow();
        }
    }
}