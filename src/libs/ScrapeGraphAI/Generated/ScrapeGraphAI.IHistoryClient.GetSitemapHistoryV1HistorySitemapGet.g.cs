#nullable enable

namespace ScrapeGraphAI
{
    public partial interface IHistoryClient
    {
        /// <summary>
        /// Get Sitemap History<br/>
        /// Get sitemap request history for the current API key.
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
        global::System.Threading.Tasks.Task<global::ScrapeGraphAI.SitemapHistoryResponse> GetSitemapHistoryV1HistorySitemapGetAsync(

            object request,
            int? page = default,
            int? pageSize = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Sitemap History<br/>
        /// Get sitemap request history for the current API key.
        /// </summary>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="pageSize">
        /// Default Value: 10
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ScrapeGraphAI.SitemapHistoryResponse> GetSitemapHistoryV1HistorySitemapGetAsync(
            int? page = default,
            int? pageSize = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}