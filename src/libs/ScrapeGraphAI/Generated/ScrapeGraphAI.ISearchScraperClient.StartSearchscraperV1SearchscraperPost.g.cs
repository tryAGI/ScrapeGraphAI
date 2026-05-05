#nullable enable

namespace ScrapeGraphAI
{
    public partial interface ISearchScraperClient
    {
        /// <summary>
        /// Start Searchscraper
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ScrapeGraphAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ScrapeGraphAI.CompletedSearchScraperResponse> StartSearchscraperV1SearchscraperPostAsync(

            global::ScrapeGraphAI.SearchScraperRequest request,
            global::ScrapeGraphAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Start Searchscraper
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ScrapeGraphAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ScrapeGraphAI.AutoSDKHttpResponse<global::ScrapeGraphAI.CompletedSearchScraperResponse>> StartSearchscraperV1SearchscraperPostAsResponseAsync(

            global::ScrapeGraphAI.SearchScraperRequest request,
            global::ScrapeGraphAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Start Searchscraper
        /// </summary>
        /// <param name="userPrompt">
        /// Example: What is the latest version of Python?
        /// </param>
        /// <param name="numResults">
        /// Number of websites to scrape (3-20). Default is 3.<br/>
        /// Default Value: 3<br/>
        /// Example: 5
        /// </param>
        /// <param name="headers">
        /// Optional headers to send with the request, including cookies and user agent<br/>
        /// Example: {"Cookie":"cookie1=value1; cookie2=value2","User-Agent":"Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36"}
        /// </param>
        /// <param name="outputSchema"></param>
        /// <param name="extractionMode">
        /// True for AI extraction mode, False for markdown conversion only<br/>
        /// Default Value: true
        /// </param>
        /// <param name="markdownMode">
        /// True for markdown conversion mode, False for raw mode<br/>
        /// Default Value: true
        /// </param>
        /// <param name="stealth">
        /// Enable stealth mode to avoid bot detection<br/>
        /// Default Value: false
        /// </param>
        /// <param name="mock">
        /// Default Value: false
        /// </param>
        /// <param name="stream">
        /// Whether to return streaming response<br/>
        /// Default Value: false
        /// </param>
        /// <param name="webhookUrl">
        /// Webhook URL to send the job result to
        /// </param>
        /// <param name="locationGeoCode">
        /// The geo code of the location to search in
        /// </param>
        /// <param name="timeRange">
        /// The date range to search in
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ScrapeGraphAI.CompletedSearchScraperResponse> StartSearchscraperV1SearchscraperPostAsync(
            string userPrompt,
            int? numResults = default,
            global::System.Collections.Generic.Dictionary<string, string>? headers = default,
            object? outputSchema = default,
            bool? extractionMode = default,
            bool? markdownMode = default,
            bool? stealth = default,
            bool? mock = default,
            bool? stream = default,
            string? webhookUrl = default,
            string? locationGeoCode = default,
            global::ScrapeGraphAI.TimeRange? timeRange = default,
            global::ScrapeGraphAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}