#nullable enable

namespace ScrapeGraphAI
{
    public partial interface IHistoryClient
    {
        /// <summary>
        /// Get Searchscraper History<br/>
        /// Get paginated history of search scraper requests.<br/>
        /// Args:<br/>
        ///     request: The FastAPI request object<br/>
        ///     page: Page number (default: 1)<br/>
        ///     page_size: Number of items per page (default: 10)<br/>
        /// Returns:<br/>
        ///     SearchscraperHistoryResponse containing the list of requests and next page key
        /// </summary>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="pageSize">
        /// Default Value: 10
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ScrapeGraphAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ScrapeGraphAI.SearchscraperHistoryResponse> GetSearchscraperHistoryV1HistorySearchscraperGetAsync(

            object request,
            int? page = default,
            int? pageSize = default,
            global::ScrapeGraphAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Searchscraper History<br/>
        /// Get paginated history of search scraper requests.<br/>
        /// Args:<br/>
        ///     request: The FastAPI request object<br/>
        ///     page: Page number (default: 1)<br/>
        ///     page_size: Number of items per page (default: 10)<br/>
        /// Returns:<br/>
        ///     SearchscraperHistoryResponse containing the list of requests and next page key
        /// </summary>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="pageSize">
        /// Default Value: 10
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ScrapeGraphAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ScrapeGraphAI.AutoSDKHttpResponse<global::ScrapeGraphAI.SearchscraperHistoryResponse>> GetSearchscraperHistoryV1HistorySearchscraperGetAsResponseAsync(

            object request,
            int? page = default,
            int? pageSize = default,
            global::ScrapeGraphAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Searchscraper History<br/>
        /// Get paginated history of search scraper requests.<br/>
        /// Args:<br/>
        ///     request: The FastAPI request object<br/>
        ///     page: Page number (default: 1)<br/>
        ///     page_size: Number of items per page (default: 10)<br/>
        /// Returns:<br/>
        ///     SearchscraperHistoryResponse containing the list of requests and next page key
        /// </summary>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="pageSize">
        /// Default Value: 10
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ScrapeGraphAI.SearchscraperHistoryResponse> GetSearchscraperHistoryV1HistorySearchscraperGetAsync(
            int? page = default,
            int? pageSize = default,
            global::ScrapeGraphAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}