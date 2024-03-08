using System;
using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace oehen.arguard
{
    [UseCulture("en-US")]
    public class ArgumentEnumerableGuardTest
    {
        [Fact]
        public void ThrowArgumentNullException_If_IEnumerableIsEmpty()
        {
            IEnumerable<string> argument = new List<string>();
            var exception = Assert.Throws<ArgumentNullException>(() =>
            {
                argument.ThrowIfIsNullOrEmpty(nameof(argument));
            });
#if NET472
#elif NET48
            exception.Message.Should().Be("Argument is null or empty." + Environment.NewLine + "Parameter name: argument");
#else
            exception.Message.Should().Be("Argument is null or empty. (Parameter 'argument')");
#endif
        }

        [Fact]
        public void ThrowIfIsNullOrEmpty_When_IEnumerable_Has_One_Entry_Should_Not_Throw_ArgumentException()
        {
            IEnumerable<string> argument = new List<string>
            {
                "entry one"
            };
            var exception = Record.Exception(() => { argument.ThrowIfIsNullOrEmpty(nameof(argument)); });
            Assert.Null(exception);
        }

        [Fact]
        public void ThrowIfIsNullOrEmpty_When_IEnumerable_Has_One_Entry_Should_Return_ArgumentValue()
        {
            IEnumerable<string> argument = new List<string>
            {
                "entry one"
            };
            var result = argument.ThrowIfIsNullOrEmpty(nameof(argument));
            result.Should().BeEquivalentTo(argument);
        }
        
        [Fact]
        public void ThrowIfIsNullOrEmpty_When_IEnumerable_Has_Many_Entries_Should_Not_Throw_ArgumentException()
        {
            IEnumerable<string> argument = new List<string>
            {
                "entry one",
                "entry two",
                "entry three"
            };
            var exception = Record.Exception(() => { argument.ThrowIfIsNullOrEmpty(nameof(argument)); });
            Assert.Null(exception);
        }
        
        [Fact]
        public void ThrowIfIsNullOrEmpty_When_IEnumerable_Has_Many_Entries_Should_Return_ArgumentValue()
        {
            IEnumerable<string> argument = new List<string>
            {
                "entry one",
                "entry two",
                "entry three"
            };
            var result = argument.ThrowIfIsNullOrEmpty(nameof(argument));
            result.Should().BeEquivalentTo(argument);
        }
    }
}