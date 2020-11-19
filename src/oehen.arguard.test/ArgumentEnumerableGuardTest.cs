using System;
using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace oehen.arguard
{
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
            exception.Message.Should().Be("Argument is null or empty. (Parameter 'argument')");
        }

        [Fact]
        public void NotThrowException_If_IEnumerableHasOneEntry()
        {
            IEnumerable<string> argument = new List<string>
            {
                "entry one"
            };
            var exception = Record.Exception(() =>
            {
                argument.ThrowIfIsNullOrEmpty(nameof(argument));
            });
            Assert.Null(exception);
        }

        [Fact]
        public void NotThrowException_If_IEnumerableHasManyEntry()
        {
            IEnumerable<string> argument = new List<string>
            {
                "entry one",
                "entry two",
                "entry three"
            };
            var exception = Record.Exception(() =>
            {
                argument.ThrowIfIsNullOrEmpty(nameof(argument));
            });
            Assert.Null(exception);
        }

    }
}
