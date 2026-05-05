#nullable enable

namespace ScrapeGraphAI
{
    public partial interface ISiteMonitorsClient
    {
        /// <summary>
        /// List Monitors<br/>
        /// List site monitors for the current user.
        /// </summary>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="pageSize">
        /// Default Value: 20
        /// </param>
        /// <param name="isActive"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ScrapeGraphAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ScrapeGraphAI.SiteMonitorListResponse> ListMonitorsV1SiteMonitorsGetAsync(
            int? page = default,
            int? pageSize = default,
            bool? isActive = default,
            global::ScrapeGraphAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Monitors<br/>
        /// List site monitors for the current user.
        /// </summary>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="pageSize">
        /// Default Value: 20
        /// </param>
        /// <param name="isActive"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ScrapeGraphAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ScrapeGraphAI.AutoSDKHttpResponse<global::ScrapeGraphAI.SiteMonitorListResponse>> ListMonitorsV1SiteMonitorsGetAsResponseAsync(
            int? page = default,
            int? pageSize = default,
            bool? isActive = default,
            global::ScrapeGraphAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}