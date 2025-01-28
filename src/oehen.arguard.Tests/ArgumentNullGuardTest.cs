using System;
// ReSharper disable UnusedVariable
// ReSharper disable UnusedMember.Local

namespace oehen.arguard;

public class ArgumentNullGuardTest
{
    [Fact]
    public void ThrowArgumentNullException_If_Enum_Is_Default()
    {
        const ArgumentTestEnum argument = default;

        // ReSharper disable once ExpressionIsAlwaysNull
        var result = argument.ThrowIfNull(nameof(argument));

        result.ShouldBe(argument);
    }

    [Fact]
    public void ThrowArgumentNullException_If_Nullable_Enum_Is_Default()
    {
        ArgumentTestEnum? argument = default(ArgumentTestEnum);

        // ReSharper disable once ExpressionIsAlwaysNull
        var result = argument.ThrowIfNull(nameof(argument));

        result.ShouldBe(argument);
    }

    [Fact]
    public void ThrowArgumentNullException_If_Nullable_Enum_Is_Null()
    {
        ArgumentTestEnum? argument = null;

        var exception = Assert.Throws<ArgumentNullException>(() =>
        {
            // ReSharper disable once ExpressionIsAlwaysNull
            argument.ThrowIfNull(nameof(argument));
        });
#if NET472
#elif NET48
            exception.Message.ShouldBe("Value cannot be null." + Environment.NewLine + "Parameter name: argument");
#else
            exception.Message.ShouldBe("Value cannot be null. (Parameter 'argument')");
#endif
    }

    [Fact]
    public void ThrowArgumentNullException_If_ObjectArgumentIsNull()
    {
        object argument = null;
        var exception = Assert.Throws<ArgumentNullException>(() =>
        {
            // ReSharper disable once ExpressionIsAlwaysNull
            argument.ThrowIfNull(nameof(argument));
        });
#if NET472
#elif NET48
            exception.Message.ShouldBe("Value cannot be null." + Environment.NewLine + "Parameter name: argument");
#else
            exception.Message.ShouldBe("Value cannot be null. (Parameter 'argument')");
#endif
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
#if NET472
#elif NET48
            exception.Message.ShouldBe("Value cannot be null." + Environment.NewLine + "Parameter name: argument");
#else
            exception.Message.ShouldBe("Value cannot be null. (Parameter 'argument')");
#endif
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
#if NET472
#elif NET48
            exception.Message.ShouldBe("Value cannot be null." + Environment.NewLine + "Parameter name: argument");
#else
            exception.Message.ShouldBe("Value cannot be null. (Parameter 'argument')");
#endif
    }

    [Fact]
    public void NotThrowIfIsLessOrEqualThanZero_ShouldNotThrowArgumentOutOfRangeException_IfArgumentIsNotNull()
    {
        const string argument = "Hello";
        var exception = Record.Exception(() => { argument.ThrowIfNull(nameof(argument)); });
        Assert.Null(exception);
    }

    private enum ArgumentTestEnum
    {
        None,
        Green,
        Blau
    }
}