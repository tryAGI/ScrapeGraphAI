#nullable enable

namespace ScrapeGraphAI
{
    public partial interface ICrawlerClient
    {
        /// <summary>
        /// Start Crawl<br/>
        /// Start a new crawl job.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ScrapeGraphAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> StartCrawlV1CrawlPostAsync(

            global::ScrapeGraphAI.CrawlJob request,
            global::ScrapeGraphAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Start Crawl<br/>
        /// Start a new crawl job.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ScrapeGraphAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ScrapeGraphAI.AutoSDKHttpResponse<string>> StartCrawlV1CrawlPostAsResponseAsync(

            global::ScrapeGraphAI.CrawlJob request,
            global::ScrapeGraphAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Start Crawl<br/>
        /// Start a new crawl job.
        /// </summary>
        /// <param name="url"></param>
        /// <param name="depth">
        /// Default Value: 1
        /// </param>
        /// <param name="breadth">
        /// Maximum number of links to crawl per depth level. If None, unlimited (default). Ignored when sitemap=True.
        /// </param>
        /// <param name="maxPages">
        /// Default Value: 10
        /// </param>
        /// <param name="prompt"></param>
        /// <param name="schema"></param>
        /// <param name="rules"></param>
        /// <param name="sitemap">
        /// Default Value: true
        /// </param>
        /// <param name="renderHeavyJs">
        /// Default Value: false
        /// </param>
        /// <param name="extractionMode">
        /// Default Value: true
        /// </param>
        /// <param name="stealth">
        /// Enable stealth mode to avoid bot detection<br/>
        /// Default Value: false
        /// </param>
        /// <param name="mock">
        /// Default Value: false
        /// </param>
        /// <param name="webhookUrl">
        /// Webhook URL to send the job result to
        /// </param>
        /// <param name="readerMode">
        /// Default Value: false
        /// </param>
        /// <param name="waitMs">
        /// Default Value: 3000
        /// </param>
        /// <param name="countryCode">
        /// The country code to use for fetching (e.g. US, GB)
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> StartCrawlV1CrawlPostAsync(
            string url,
            int? depth = default,
            int? breadth = default,
            int? maxPages = default,
            string? prompt = default,
            object? schema = default,
            global::ScrapeGraphAI.CrawlJobRules2? rules = default,
            bool? sitemap = default,
            bool? renderHeavyJs = default,
            bool? extractionMode = default,
            bool? stealth = default,
            bool? mock = default,
            string? webhookUrl = default,
            bool? readerMode = default,
            int? waitMs = default,
            string? countryCode = default,
            global::ScrapeGraphAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}