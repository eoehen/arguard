using System;
using System.IO;
using FluentAssertions;
using Xunit;

namespace oehen.arguard
{
    public class ArgumentFilePathGuardTest
    {
        [Fact]
        public void
            ArgumentFilePathGuardTest_ThrowIfFileNotExists_When_FilePath_Is_StringEmpty_Then_Should_Throw_FileNotFoundException()
        {
            const string argument = "";
            Action act = () => argument.ThrowIfFileNotExists(nameof(argument));
            act.Should().Throw<FileNotFoundException>();
        }

        [Fact]
        public void
            ArgumentFilePathGuardTest_ThrowIfFileNotExists_When_FilePath_Is_Null_Then_Should_Throw_FileNotFoundException()
        {
            const string argument = null;
            Action act = () => argument.ThrowIfFileNotExists(nameof(argument));
            act.Should().Throw<FileNotFoundException>();
        }

        [Fact]
        public void
            ArgumentFilePathGuardTest_ThrowIfFileNotExists_When_FilePath_Not_Exists_Then_Should_Throw_FileNotFoundException()
        {
            const string argument = @"./testfiles/ArgumentFilePathTestFileNotExists.txt";
            Action act = () => argument.ThrowIfFileNotExists(nameof(argument));
            act.Should().Throw<FileNotFoundException>();
        }

        [Fact]
        public void
            ArgumentFilePathGuardTest_ThrowIfFileNotExists_When_FilePath_Exists_Then_Should_Not_Throw_FileNotFoundException()
        {
            const string argument = @"./testfiles/ArgumentFilePathTestFile.txt";
            Action act = () => argument.ThrowIfFileNotExists(nameof(argument));
            act.Should().NotThrow<FileNotFoundException>();
        }
        
        [Fact]
        public void
            ArgumentFilePathGuardTest_ThrowIfFileNotExists_When_FilePath_Exists_Then_Should_Return_ArgumentValue()
        {
            const string argument = @"./testfiles/ArgumentFilePathTestFile.txt";
            var result = argument.ThrowIfFileNotExists(nameof(argument));
            result.Should().Be(argument);
        }
    }
}