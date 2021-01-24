#load nuget:?package=Cake.Recipe&version=2.1.0

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
    dupFinderExcludePattern: new string[] 
    {
        BuildParameters.RootDirectoryPath + "/src/oehen.arguard.test/*.cs",
        BuildParameters.RootDirectoryPath + "/src/oehen.arguard/**/*.AssemblyInfo.cs" 
    },
    testCoverageFilter: "+[*]* -[xunit.*]* -[FluentAssertions]* -[Cake.Core]* -[*.tests]*",
    testCoverageExcludeByAttribute: "*.ExcludeFromCodeCoverage*",
    testCoverageExcludeByFile: "*/*Designer.cs;*/*.g.cs;*/*.g.i.cs"
);

Task("Verify-Publish-Documentation")
    .IsDependeeOf("Clean-Documentation")
    .Does(() => {

    Information(Context.EnvironmentVariable(Environment.WyamAccessTokenVariable));
    Information(Context.EnvironmentVariable(Environment.WyamDeployRemoteVariable));
    Information(Context.EnvironmentVariable(Environment.WyamDeployBranchVariable));

    Information($"CanUseWyam : {BuildParameters.CanUseWyam}");

});

Build.RunDotNetCore();
