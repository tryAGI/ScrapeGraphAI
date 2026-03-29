/*
order: 20
title: MEAI Tools
slug: meai-tools

Examples showing how to use ScrapeGraphAI as MEAI AIFunction tools with any IChatClient.
*/

using Microsoft.Extensions.AI;

namespace ScrapeGraphAI.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public void CreateSmartScraperTool()
    {
        //// Create an AIFunction tool for SmartScraper that can be used with any IChatClient.
        using var client = GetAuthenticatedClient();

        var tool = client.AsSmartScraperTool();

        tool.Name.Should().Be("SmartScraper");
        tool.Description.Should().NotBeNullOrEmpty();
    }

    [TestMethod]
    public void CreateSearchScraperTool()
    {
        //// Create an AIFunction tool for SearchScraper that can be used with any IChatClient.
        using var client = GetAuthenticatedClient();

        var tool = client.AsSearchScraperTool();

        tool.Name.Should().Be("SearchScraper");
        tool.Description.Should().NotBeNullOrEmpty();
    }

    [TestMethod]
    public void CreateMarkdownifyTool()
    {
        //// Create an AIFunction tool for Markdownify that can be used with any IChatClient.
        using var client = GetAuthenticatedClient();

        var tool = client.AsMarkdownifyTool();

        tool.Name.Should().Be("Markdownify");
        tool.Description.Should().NotBeNullOrEmpty();
    }

    [TestMethod]
    public void CreateGetCreditsTool()
    {
        //// Create an AIFunction tool for getting credit balance.
        using var client = GetAuthenticatedClient();

        var tool = client.AsGetCreditsTool();

        tool.Name.Should().Be("GetCredits");
        tool.Description.Should().NotBeNullOrEmpty();
    }

    [TestMethod]
    public void CreateGetSitemapTool()
    {
        //// Create an AIFunction tool for extracting sitemaps.
        using var client = GetAuthenticatedClient();

        var tool = client.AsGetSitemapTool();

        tool.Name.Should().Be("GetSitemap");
        tool.Description.Should().NotBeNullOrEmpty();
    }
}
