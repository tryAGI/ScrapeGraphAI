# Microsoft.Extensions.AI Integration

ScrapeGraphAI provides `AIFunction` tools for seamless integration with any `IChatClient` via [Microsoft.Extensions.AI](https://devblogs.microsoft.com/dotnet/introducing-microsoft-extensions-ai-preview/).

## Available Tools

| Tool | Method | Description |
|------|--------|-------------|
| SmartScraper | `AsSmartScraperTool()` | Extract structured data from a URL using a natural language prompt |
| SearchScraper | `AsSearchScraperTool()` | AI-powered web search with structured results |
| Markdownify | `AsMarkdownifyTool()` | Convert a webpage to clean markdown |
| GetCredits | `AsGetCreditsTool()` | Check remaining API credit balance |
| GetSitemap | `AsGetSitemapTool()` | Extract all URLs from a website's sitemap |

## Usage Example

```csharp
using Microsoft.Extensions.AI;
using ScrapeGraphAI;

// Create the ScrapeGraphAI client
using var scraper = new ScrapeGraphAIClient(apiKey);

// Create tools
var tools = new[]
{
    scraper.AsSmartScraperTool(),
    scraper.AsSearchScraperTool(),
    scraper.AsMarkdownifyTool(),
};

// Use with any IChatClient
IChatClient chatClient = /* your chat client */;
var response = await chatClient.GetResponseAsync(
    "Extract the main heading from https://example.com",
    new ChatOptions { Tools = tools });
```

## Tool Details

### SmartScraper

Extracts structured data from any website using AI. Requires a URL and a natural language prompt describing what to extract.

```csharp
var tool = client.AsSmartScraperTool();
```

### SearchScraper

Performs an AI-powered web search and returns structured results. Optionally configure the number of results (3-20).

```csharp
var tool = client.AsSearchScraperTool(numResults: 5);
```

### Markdownify

Converts a webpage to clean, readable markdown format.

```csharp
var tool = client.AsMarkdownifyTool();
```

### GetCredits

Retrieves the current credit balance and total credits used.

```csharp
var tool = client.AsGetCreditsTool();
```

### GetSitemap

Extracts all URLs from a website's sitemap.

```csharp
var tool = client.AsGetSitemapTool();
```
