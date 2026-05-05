#nullable enable

namespace ScrapeGraphAI
{
    public partial interface ISmartScraperClient
    {
        /// <summary>
        /// Start Smartscraper
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ScrapeGraphAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ScrapeGraphAI.CompletedSmartscraperResponse> StartSmartscraperV1SmartscraperPostAsync(

            global::ScrapeGraphAI.SmartscraperRequest request,
            global::ScrapeGraphAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Start Smartscraper
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ScrapeGraphAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ScrapeGraphAI.AutoSDKHttpResponse<global::ScrapeGraphAI.CompletedSmartscraperResponse>> StartSmartscraperV1SmartscraperPostAsResponseAsync(

            global::ScrapeGraphAI.SmartscraperRequest request,
            global::ScrapeGraphAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Start Smartscraper
        /// </summary>
        /// <param name="websiteUrl">
        /// The URL of the website to scrape (optional for Smartscraper)
        /// </param>
        /// <param name="renderHeavyJs">
        /// Whether to render heavy JS<br/>
        /// Default Value: false
        /// </param>
        /// <param name="mock">
        /// Default Value: false
        /// </param>
        /// <param name="stealth">
        /// Default Value: false
        /// </param>
        /// <param name="branding">
        /// Default Value: false
        /// </param>
        /// <param name="stream">
        /// Whether to return streaming response<br/>
        /// Default Value: false
        /// </param>
        /// <param name="countryCode">
        /// The country code to use for the scrape
        /// </param>
        /// <param name="waitMs">
        /// The number of milliseconds to wait before scraping the website<br/>
        /// Default Value: 3000
        /// </param>
        /// <param name="userPrompt">
        /// Example: Extract info about the company
        /// </param>
        /// <param name="websiteHtml">
        /// HTML content, maximum size 2MB<br/>
        /// Example: &lt;html&gt;&lt;body&gt;&lt;h1&gt;Title&lt;/h1&gt;&lt;p&gt;Content&lt;/p&gt;&lt;/body&gt;&lt;/html&gt;
        /// </param>
        /// <param name="websiteMarkdown">
        /// Markdown content, maximum size 2MB<br/>
        /// Example: # Title<br/>
        /// This is some content in markdown format.
        /// </param>
        /// <param name="outputSchema"></param>
        /// <param name="headers">
        /// Optional headers to send with the request, including cookies and user agent<br/>
        /// Example: {"Cookie":"cookie1=value1; cookie2=value2","User-Agent":"Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36"}
        /// </param>
        /// <param name="numberOfScrolls">
        /// Number of scroll operations to perform for infinite scrolling (0 = disabled, range: 1-100). Values between 1-9 will be automatically set to 10.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="totalPages">
        /// Total number of pages to scrape if pagination enabled<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="steps">
        /// List of steps to actions to perform on the website
        /// </param>
        /// <param name="cookies">
        /// Cookies to send with the request<br/>
        /// Default Value: {}
        /// </param>
        /// <param name="plainText">
        /// Default Value: false
        /// </param>
        /// <param name="webhookUrl">
        /// Webhook URL to send the job result to
        /// </param>
        /// <param name="offset">
        /// Offset to start scraping from<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="isMultipageChild">
        /// Whether this is a multi-page child request<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ScrapeGraphAI.CompletedSmartscraperResponse> StartSmartscraperV1SmartscraperPostAsync(
            string userPrompt,
            string? websiteUrl = default,
            bool? renderHeavyJs = default,
            bool? mock = default,
            bool? stealth = default,
            bool? branding = default,
            bool? stream = default,
            string? countryCode = default,
            int? waitMs = default,
            string? websiteHtml = default,
            string? websiteMarkdown = default,
            object? outputSchema = default,
            global::System.Collections.Generic.Dictionary<string, string>? headers = default,
            int? numberOfScrolls = default,
            int? totalPages = default,
            global::System.Collections.Generic.IList<string>? steps = default,
            global::System.Collections.Generic.Dictionary<string, string>? cookies = default,
            bool? plainText = default,
            string? webhookUrl = default,
            int? offset = default,
            bool? isMultipageChild = default,
            global::ScrapeGraphAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}