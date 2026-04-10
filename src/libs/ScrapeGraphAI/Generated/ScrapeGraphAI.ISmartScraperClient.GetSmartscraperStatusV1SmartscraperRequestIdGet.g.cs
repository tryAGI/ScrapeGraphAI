#nullable enable

namespace ScrapeGraphAI
{
    public partial interface ISmartScraperClient
    {
        /// <summary>
        /// Get Smartscraper Status
        /// </summary>
        /// <param name="requestId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ScrapeGraphAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetSmartscraperStatusV1SmartscraperRequestIdGetAsync(
            string requestId,
            global::ScrapeGraphAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}