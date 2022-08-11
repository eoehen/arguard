#load nuget:?package=Cake.Recipe&version=3.0.0

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
    shouldRunCoveralls: false, // Disabled because it's currently failing
    shouldRunDotNetCorePack: true);

BuildParameters.PrintParameters(Context);

ToolSettings.SetToolSettings(
    context: Context,
    testCoverageFilter: "+[*]* -[xunit.*]* -[FluentAssertions]* -[Cake.Core]* -[*.Tests]* -[*.example]*",
    testCoverageExcludeByAttribute: "*.ExcludeFromCodeCoverage*",
    testCoverageExcludeByFile: "*/*Designer.cs;*/*.g.cs;*/*.g.i.cs"
);

Build.RunDotNetCore();
