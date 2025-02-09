using System;
using System.IO;

namespace oehen.arguard.Filesystem;

public class ArgumentDirectoryPathGuardTest
{
    [Fact]
    public void
        ArgumentDirectoryPathGuardTest_ThrowIfDirectoryNotExists_When_DirectoryPath_Is_StringEmpty_Then_Should_Throw_FileNotFoundException()
    {
        const string argument = "";
        Action act = () => argument.ThrowIfDirectoryNotExists(nameof(argument));
        act.ShouldThrow<DirectoryNotFoundException>();
    }

    [Fact]
    public void
        ArgumentDirectoryPathGuardTest_ThrowIfDirectoryNotExists_When_DirectoryPath_Is_Null_Then_Should_Throw_FileNotFoundException()
    {
        const string argument = null;
        Action act = () => argument.ThrowIfDirectoryNotExists(nameof(argument));
        act.ShouldThrow<DirectoryNotFoundException>();
    }

    [Fact]
    public void
        ArgumentDirectoryPathGuardTest_ThrowIfDirectoryNotExists_When_DirectoryPath_Is_FilePath_Then_Should_Throw_FileNotFoundException()
    {
        const string argument = @"./testfiles/ArgumentFilePathTestFile.txt";
        Action act = () => argument.ThrowIfDirectoryNotExists(nameof(argument));
        act.ShouldThrow<DirectoryNotFoundException>();
    }

    [Fact]
    public void
        ArgumentDirectoryPathGuardTest_ThrowIfDirectoryNotExists_When_DirectoryPath_Not_Exists_Then_Should_Throw_FileNotFoundException()
    {
        const string argument = @"./testfilesNotExists/";
        Action act = () => argument.ThrowIfDirectoryNotExists(nameof(argument));
        act.ShouldThrow<DirectoryNotFoundException>();
    }

    [Fact]
    public void
        ArgumentDirectoryPathGuardTest_ThrowIfDirectoryNotExists_When_DirectoryPath_Exists_Then_Should_Not_Throw_FileNotFoundException()
    {
        const string argument = @"./testfiles";
        Action act = () => argument.ThrowIfDirectoryNotExists(nameof(argument));
        act.ShouldNotThrow();
    }

    [Fact]
    public void
        ArgumentDirectoryPathGuardTest_ThrowIfDirectoryNotExists_When_DirectoryPath_Exists_Then_Should_Return_ArgumentValue()
    {
        const string argument = @"./testfiles";
        var result = argument.ThrowIfDirectoryNotExists(nameof(argument));
        result.ShouldBe(argument);
    }
}