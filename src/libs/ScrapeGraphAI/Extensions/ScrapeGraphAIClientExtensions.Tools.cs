#nullable enable

using System.Text.Json;
using Microsoft.Extensions.AI;

namespace ScrapeGraphAI;

/// <summary>
/// Extensions for using ScrapeGraphAIClient as MEAI tools with any IChatClient.
/// </summary>
public static class ScrapeGraphAIToolExtensions
{
    /// <summary>
    /// Creates an <see cref="AIFunction"/> that extracts structured data from a URL
    /// using a natural language prompt via ScrapeGraphAI's SmartScraper.
    /// </summary>
    /// <param name="client">The ScrapeGraphAI client.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    [CLSCompliant(false)]
    public static AIFunction AsSmartScraperTool(this ScrapeGraphAIClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (string websiteUrl, string userPrompt, CancellationToken cancellationToken) =>
            {
                var response = await client.SmartScraper.StartSmartscraperV1SmartscraperPostAsync(
                    userPrompt: userPrompt,
                    websiteUrl: websiteUrl,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return FormatSmartScraperResponse(response);
            },
            name: "SmartScraper",
            description: "Extracts structured data from a website URL using AI. Provide a URL and a natural language prompt describing what information to extract.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that performs AI-powered web search
    /// and returns structured results via ScrapeGraphAI's SearchScraper.
    /// </summary>
    /// <param name="client">The ScrapeGraphAI client.</param>
    /// <param name="numResults">Number of websites to scrape (3-20, default: 3).</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    [CLSCompliant(false)]
    public static AIFunction AsSearchScraperTool(
        this ScrapeGraphAIClient client,
        int numResults = 3)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (string query, CancellationToken cancellationToken) =>
            {
                var response = await client.SearchScraper.StartSearchscraperV1SearchscraperPostAsync(
                    userPrompt: query,
                    numResults: numResults,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return FormatSearchScraperResponse(response);
            },
            name: "SearchScraper",
            description: "Performs an AI-powered web search with structured results. Provide a search query or question to find and extract relevant information from the web.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that converts a webpage to clean markdown
    /// via ScrapeGraphAI's Markdownify service.
    /// </summary>
    /// <param name="client">The ScrapeGraphAI client.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    [CLSCompliant(false)]
    public static AIFunction AsMarkdownifyTool(this ScrapeGraphAIClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (string websiteUrl, CancellationToken cancellationToken) =>
            {
                var response = await client.Markdownify.StartMarkdownifyV1MarkdownifyPostAsync(
                    websiteUrl: websiteUrl,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return FormatMarkdownifyResponse(response);
            },
            name: "Markdownify",
            description: "Converts a webpage URL to clean, readable markdown. Useful for extracting page content in a structured text format.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that retrieves the current credit balance
    /// and total usage from ScrapeGraphAI.
    /// </summary>
    /// <param name="client">The ScrapeGraphAI client.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    [CLSCompliant(false)]
    public static AIFunction AsGetCreditsTool(this ScrapeGraphAIClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (CancellationToken cancellationToken) =>
            {
                var response = await client.User.GetCreditsV1CreditsGetAsync(
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return JsonSerializer.Serialize(new
                {
                    remaining_credits = response.RemainingCredits,
                    total_credits_used = response.TotalCreditsUsed,
                });
            },
            name: "GetCredits",
            description: "Retrieves the current ScrapeGraphAI API credit balance and total credits used.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that extracts all URLs from a website's sitemap
    /// via ScrapeGraphAI's Sitemap service.
    /// </summary>
    /// <param name="client">The ScrapeGraphAI client.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    [CLSCompliant(false)]
    public static AIFunction AsGetSitemapTool(this ScrapeGraphAIClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (string websiteUrl, CancellationToken cancellationToken) =>
            {
                var response = await client.Sitemap.GenerateSitemapV1SitemapPostAsync(
                    websiteUrl: websiteUrl,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return JsonSerializer.Serialize(new
                {
                    request_id = response.RequestId,
                    url_count = response.Urls.Count,
                    urls = response.Urls,
                });
            },
            name: "GetSitemap",
            description: "Extracts all URLs from a website's sitemap. Returns a list of discovered URLs for the given domain.");
    }

    private static string FormatSmartScraperResponse(CompletedSmartscraperResponse response)
    {
        var parts = new List<string>
        {
            $"Request ID: {response.RequestId}",
            $"Status: {response.Status}",
        };

        if (!string.IsNullOrEmpty(response.WebsiteUrl))
        {
            parts.Add($"URL: {response.WebsiteUrl}");
        }

        if (response.Result is { } result)
        {
            parts.Add($"Result: {JsonSerializer.Serialize(result)}");
        }

        if (!string.IsNullOrEmpty(response.Error))
        {
            parts.Add($"Error: {response.Error}");
        }

        return string.Join("\n", parts);
    }

    private static string FormatSearchScraperResponse(CompletedSearchScraperResponse response)
    {
        var parts = new List<string>
        {
            $"Request ID: {response.RequestId}",
            $"Status: {response.Status}",
            $"Query: {response.UserPrompt}",
        };

        if (response.Result is { } result)
        {
            parts.Add($"Result: {JsonSerializer.Serialize(result)}");
        }

        if (response.ReferenceUrls is { Count: > 0 } urls)
        {
            parts.Add("Reference URLs:");
            foreach (var url in urls)
            {
                parts.Add($"  - {url}");
            }
        }

        if (!string.IsNullOrEmpty(response.Error))
        {
            parts.Add($"Error: {response.Error}");
        }

        return string.Join("\n", parts);
    }

    private static string FormatMarkdownifyResponse(CompletedMarkdownifyResponse response)
    {
        var parts = new List<string>
        {
            $"Request ID: {response.RequestId}",
            $"Status: {response.Status}",
            $"URL: {response.WebsiteUrl}",
        };

        if (!string.IsNullOrEmpty(response.Result))
        {
            parts.Add($"Markdown:\n{response.Result}");
        }

        if (!string.IsNullOrEmpty(response.Error))
        {
            parts.Add($"Error: {response.Error}");
        }

        return string.Join("\n", parts);
    }
}
