#load nuget:?package=Cake.Recipe&version=2.0.1

Environment.SetVariableNames();

BuildParameters.SetParameters(
    context: Context,
    buildSystem: BuildSystem,
    preferredBuildProviderType: BuildProviderType.GitHubActions,
    preferredBuildAgentOperatingSystem: PlatformFamily.Linux,
    sourceDirectoryPath: "./src",
    title: "oehen.arguard",
    repositoryOwner: "eoehen",
    repositoryName: "arguard",
    shouldRunDotNetCorePack: true,
    shouldRunCodecov: true,
    shouldRunDupFinder: true,
    shouldRunInspectCode: true,
    testFilePattern: "/**/*.test.csproj");

BuildParameters.PrintParameters(Context);

ToolSettings.SetToolSettings(
    context: Context,
    dupFinderExcludePattern: new string[] {
        BuildParameters.RootDirectoryPath + "/src/oehen.arguard.test/*.cs",
        BuildParameters.RootDirectoryPath + "/src/oehen.arguard/**/*.AssemblyInfo.cs" },
    testCoverageFilter: "+[*]* -[xunit.*]* -[FluentAssertions]* -[Cake.Core]* -[*.tests]*" );

Build.RunDotNetCore();
