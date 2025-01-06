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
// Task overrides
//*************************************************************************************************

// Cake.Recipe uses Wyam for documentation 
((CakeTask)BuildParameters.Tasks.PreviewDocumentationTask.Task).Actions.Clear();
BuildParameters.Tasks.PreviewDocumentationTask.Does<IssuesData>((data) => {
    var argumentBuilder =
        new ProcessArgumentBuilder()
            .Append("preview")
            .Append("--output \"{0}\"", data.RepositoryRootDirectory.Combine(BuildParameters.Paths.Directories.PublishedDocumentation));

    if (Context.Log.Verbosity == Verbosity.Verbose || Context.Log.Verbosity == Verbosity.Diagnostic)
    {
        string statiqVerbosity;
        switch (Context.Log.Verbosity)
        {
            case Verbosity.Quiet:
                statiqVerbosity = "None";
                break;
            case Verbosity.Minimal:
                statiqVerbosity = "Error";
                break;
            case Verbosity.Normal:
                statiqVerbosity = "Warning";
                break;
            case Verbosity.Verbose:
                statiqVerbosity = "Debug";
                break;
            case Verbosity.Diagnostic:
                statiqVerbosity = "Trace";
                break;
            default:
                statiqVerbosity = "Warning";
                break;
        }

        argumentBuilder.Append("-l {0}", statiqVerbosity);
    }

    DotNetCoreRun(
        BuildParameters.WyamRootDirectoryPath.CombineWithFilePath("Documentation.csproj").FullPath,
        argumentBuilder);
});

//*************************************************************************************************
// Execution
//*************************************************************************************************

Build.RunDotNetCore();
