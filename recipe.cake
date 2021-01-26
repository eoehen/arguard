#load nuget:https://pkgs.dev.azure.com/cake-contrib/Home/_packaging/addins%40Local/nuget/v3/index.json?package=Cake.Recipe&version=2.2.0-alpha0044&prerelease

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
    shouldRunDotNetCorePack: true);

BuildParameters.PrintParameters(Context);

ToolSettings.SetToolSettings(
    context: Context,
    dupFinderExcludePattern: new string[] 
    {
        BuildParameters.RootDirectoryPath + "/src/oehen.arguard.Tests/*.cs",
        BuildParameters.RootDirectoryPath + "/src/oehen.arguard/**/*.AssemblyInfo.cs" 
    },
    testCoverageFilter: "+[*]* -[xunit.*]* -[FluentAssertions]* -[Cake.Core]* -[*.Tests]*",
    testCoverageExcludeByAttribute: "*.ExcludeFromCodeCoverage*",
    testCoverageExcludeByFile: "*/*Designer.cs;*/*.g.cs;*/*.g.i.cs"
);

Task("Verify-Publish-Documentation")
    .IsDependeeOf("Clean-Documentation")
    .Does(() => {

    Information($"WyamAccessTokenVariable : {Context.EnvironmentVariable(Environment.WyamAccessTokenVariable)}");
    Information($"WyamDeployRemoteVariable : {Context.EnvironmentVariable(Environment.WyamDeployRemoteVariable)}");
    Information($"WyamDeployBranchVariable : {Context.EnvironmentVariable(Environment.WyamDeployBranchVariable)}");

    Information($"shouldGenerateDocumentation: {BuildParameters.ShouldGenerateDocumentation}");
    Information($"CanUseWyam : {BuildParameters.CanUseWyam}");

});

Build.RunDotNetCore();
