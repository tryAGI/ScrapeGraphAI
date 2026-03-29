# Microsoft.Extensions.AI Integration

!!! tip "Cross-SDK comparison"
    See the [centralized MEAI documentation](https://tryagi.github.io/docs/meai/) for feature matrices and comparisons across all tryAGI SDKs.

The ScrapeGraphAI SDK provides `AIFunction` tool wrappers compatible with [Microsoft.Extensions.AI](https://learn.microsoft.com/en-us/dotnet/ai/microsoft-extensions-ai). These tools can be used with any `IChatClient` to give AI models access to ScrapeGraphAI's smart web scraping, AI-powered search, markdown conversion, sitemap extraction, and credit management.

## Installation

```bash
dotnet add package ScrapeGraphAI
```

## Available Tools

| Method | Tool Name | Description |
|--------|-----------|-------------|
| `AsSmartScraperTool()` | `SmartScraper` | Extract structured data from a URL using natural language prompts |
| `AsSearchScraperTool()` | `SearchScraper` | AI-powered web search with structured results |
| `AsMarkdownifyTool()` | `Markdownify` | Convert a webpage to clean, readable markdown |
| `AsGetCreditsTool()` | `GetCredits` | Check remaining API credits and total usage |
| `AsGetSitemapTool()` | `GetSitemap` | Extract all URLs from a website's sitemap |

## Usage

```csharp
using ScrapeGraphAI;
using Microsoft.Extensions.AI;

var scrapeClient = new ScrapeGraphAIClient(
    apiKey: Environment.GetEnvironmentVariable("SGAI_API_KEY")!);

var options = new ChatOptions
{
    Tools =
    [
        scrapeClient.AsSmartScraperTool(),
        scrapeClient.AsSearchScraperTool(),
        scrapeClient.AsMarkdownifyTool(),
        scrapeClient.AsGetCreditsTool(),
        scrapeClient.AsGetSitemapTool(),
    ],
};

IChatClient chatClient = /* your chat client */;

var messages = new List<ChatMessage>
{
    new(ChatRole.User, "Extract the pricing information from https://example.com/pricing"),
};

while (true)
{
    var response = await chatClient.GetResponseAsync(messages, options);
    messages.AddRange(response.ToChatMessages());

    if (response.FinishReason == ChatFinishReason.ToolCalls)
    {
        var results = await response.CallToolsAsync(options);
        messages.AddRange(results);
        continue;
    }

    Console.WriteLine(response.Text);
    break;
}
```
