#load nuget:?package=Cake.Recipe&version=3.1.1

//*************************************************************************************************
// Settings
//*************************************************************************************************

Environment.SetVariableNames();

BuildParameters.SetParameters(
    context: Context,
    buildSystem: BuildSystem,
    sourceDirectoryPath: "./src",
    title: "oehen.arguard",
    repositoryOwner: "eoehen",
    repositoryName: "arguard",
    shouldRunDotNetCorePack: true,
    shouldRunCoveralls: false, // Disabled because it's currently failing
    preferredBuildProviderType: BuildProviderType.GitHubActions,
    preferredBuildAgentOperatingSystem: PlatformFamily.Linux
    );

BuildParameters.PrintParameters(Context);

//*************************************************************************************************
// Extensions
//*************************************************************************************************

ToolSettings.SetToolSettings(
    context: Context,
    testCoverageFilter: "+[*]* -[xunit.*]* -[FluentAssertions]* -[Cake.Core]* -[*.Tests]* -[*.example]*",
    testCoverageExcludeByAttribute: "*.ExcludeFromCodeCoverage*",
    testCoverageExcludeByFile: "*/*Designer.cs;*/*.g.cs;*/*.g.i.cs"
);

//*************************************************************************************************
// Execution
//*************************************************************************************************

Build.RunDotNetCore();
