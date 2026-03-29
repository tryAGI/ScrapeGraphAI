/*
order: 10
title: Web Scraping
slug: web-scraping

Examples showing how to use ScrapeGraphAI for AI-powered web scraping.
*/

namespace ScrapeGraphAI.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task SmartScraper_ExtractData()
    {
        //// Use SmartScraper to extract structured data from a website
        //// using a natural language prompt.
        using var client = GetAuthenticatedClient();

        var response = await client.SmartScraper.StartSmartscraperV1SmartscraperPostAsync(
            userPrompt: "Extract the page title and main heading",
            websiteUrl: "https://example.com");

        response.RequestId.Should().NotBeNullOrEmpty();
    }

    [TestMethod]
    public async Task SearchScraper_SearchAndExtract()
    {
        //// Use SearchScraper to perform an AI-powered web search
        //// and extract structured results.
        using var client = GetAuthenticatedClient();

        var response = await client.SearchScraper.StartSearchscraperV1SearchscraperPostAsync(
            userPrompt: "What is the latest version of .NET?",
            numResults: 3);

        response.RequestId.Should().NotBeEmpty();
    }

    [TestMethod]
    public async Task Markdownify_ConvertToMarkdown()
    {
        //// Use Markdownify to convert a webpage to clean markdown format.
        using var client = GetAuthenticatedClient();

        var response = await client.Markdownify.StartMarkdownifyV1MarkdownifyPostAsync(
            websiteUrl: "https://example.com");

        response.RequestId.Should().NotBeNullOrEmpty();
    }

    [TestMethod]
    public async Task Sitemap_ExtractUrls()
    {
        //// Use Sitemap to extract all URLs from a website's sitemap.
        using var client = GetAuthenticatedClient();

        var response = await client.Sitemap.GenerateSitemapV1SitemapPostAsync(
            websiteUrl: "https://example.com");

        response.RequestId.Should().NotBeNullOrEmpty();
    }

    [TestMethod]
    public async Task Credits_GetBalance()
    {
        //// Check the remaining credit balance and total usage.
        using var client = GetAuthenticatedClient();

        var credits = await client.User.GetCreditsV1CreditsGetAsync();

        credits.RemainingCredits.Should().BeGreaterThanOrEqualTo(0);
    }
}
