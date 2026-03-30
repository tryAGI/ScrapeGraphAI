# CLAUDE.md -- ScrapeGraphAI SDK

## Overview

Auto-generated C# SDK for [ScrapeGraphAI](https://scrapegraphai.com/) -- AI-powered web scraping with natural language prompts and structured data extraction.
OpenAPI spec from the public `https://api.scrapegraphai.com/openapi.json`.

## Build & Test

```bash
dotnet build ScrapeGraphAI.slnx
dotnet test src/tests/IntegrationTests/
```

## Auth

API key auth via `SGAI-APIKEY` header (native via `--security-scheme`):

```csharp
var client = new ScrapeGraphAIClient(apiKey); // SGAI_API_KEY env var
```

## Key Files

- `src/libs/ScrapeGraphAI/openapi.yaml` -- OpenAPI spec (downloaded from api.scrapegraphai.com)
- `src/libs/ScrapeGraphAI/generate.sh` -- Downloads spec, runs autosdk with `--security-scheme` and `--base-url`
- `src/libs/ScrapeGraphAI/Generated/` -- **Never edit** -- auto-generated code
- `src/libs/ScrapeGraphAI/Extensions/ScrapeGraphAIClientExtensions.Tools.cs` -- MEAI AIFunction tools
- `src/tests/IntegrationTests/Tests.cs` -- Test helper with bearer auth
- `src/tests/IntegrationTests/Examples/` -- Example tests (also generate docs)

## Sub-client Pattern

ScrapeGraphAI uses sub-client accessors:
- `client.SmartScraper.StartSmartscraperV1SmartscraperPostAsync(...)` -- AI data extraction from URL
- `client.SearchScraper.StartSearchscraperV1SearchscraperPostAsync(...)` -- AI-powered web search
- `client.Markdownify.StartMarkdownifyV1MarkdownifyPostAsync(...)` -- Convert URL to markdown
- `client.Sitemap.GenerateSitemapV1SitemapPostAsync(...)` -- Extract sitemap URLs
- `client.Crawler.StartCrawlV1CrawlPostAsync(...)` -- Multi-page crawling
- `client.User.GetCreditsV1CreditsGetAsync()` -- Credit balance
- `client.User.SubmitFeedbackV1FeedbackPostAsync(...)` -- Submit feedback
- `client.SchemaGenerator.*` -- Auto-generate output schemas
- `client.ScheduledJobs.*` -- Scheduled scraping jobs
- `client.SiteMonitors.*` -- Site monitoring

## MEAI Integration

AIFunction tools for use with any IChatClient:
- `AsSmartScraperTool()` -- Extract structured data from URL with NL prompt
- `AsSearchScraperTool()` -- AI-powered web search with structured results
- `AsMarkdownifyTool()` -- Convert URL to markdown
- `AsGetCreditsTool()` -- Check credit balance
- `AsGetSitemapTool()` -- Extract sitemap URLs
