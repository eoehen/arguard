return await Bootstrapper
  .Factory
  .CreateDocs(args)
  .AddSetting(Docable.SiteKeys.Logo, "/assets/images/Icon.png")
  .AddSetting(Keys.Host, "eoehen.github.io/arguard")
  .AddSetting(Keys.LinksUseHttps, true)
  .AddSetting(Docable.SiteKeys.RightSidebarHeadingLevel, 2)
  .AddSetting(WebKeys.GenerateSearchIndex, true)
  .AddSetting(WebKeys.AdditionalSearchResultFields, new List<string> { Keys.Excerpt })
  .AddSetting(Statiq.Markdown.MarkdownKeys.MarkdownExtensions, "bootstrap")
  .RunAsync();