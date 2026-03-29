#nullable enable

namespace ScrapeGraphAI
{
    public partial interface ISmartScraperClient
    {
        /// <summary>
        /// Get Smartscraper Status
        /// </summary>
        /// <param name="requestId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ScrapeGraphAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetSmartscraperStatusV1SmartscraperRequestIdGetAsync(
            string requestId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}