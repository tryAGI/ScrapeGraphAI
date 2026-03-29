#nullable enable

namespace ScrapeGraphAI
{
    public partial interface IHistoryClient
    {
        /// <summary>
        /// Get Crawler History<br/>
        /// Get paginated history of crawler requests.<br/>
        /// Args:<br/>
        ///     request: The FastAPI request object<br/>
        ///     page: Page number (default: 1)<br/>
        ///     page_size: Number of items per page (default: 10)<br/>
        /// Returns:<br/>
        ///     CrawlerHistoryResponse containing the list of requests and next page key
        /// </summary>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="pageSize">
        /// Default Value: 10
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ScrapeGraphAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ScrapeGraphAI.CrawlerHistoryResponse> GetCrawlerHistoryV1HistoryCrawlGetAsync(

            object request,
            int? page = default,
            int? pageSize = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Crawler History<br/>
        /// Get paginated history of crawler requests.<br/>
        /// Args:<br/>
        ///     request: The FastAPI request object<br/>
        ///     page: Page number (default: 1)<br/>
        ///     page_size: Number of items per page (default: 10)<br/>
        /// Returns:<br/>
        ///     CrawlerHistoryResponse containing the list of requests and next page key
        /// </summary>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="pageSize">
        /// Default Value: 10
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ScrapeGraphAI.CrawlerHistoryResponse> GetCrawlerHistoryV1HistoryCrawlGetAsync(
            int? page = default,
            int? pageSize = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}