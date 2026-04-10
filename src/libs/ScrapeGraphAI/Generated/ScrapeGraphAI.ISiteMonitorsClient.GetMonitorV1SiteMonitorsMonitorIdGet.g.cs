#nullable enable

namespace ScrapeGraphAI
{
    public partial interface ISiteMonitorsClient
    {
        /// <summary>
        /// Get Monitor<br/>
        /// Get a site monitor by id.
        /// </summary>
        /// <param name="monitorId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ScrapeGraphAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ScrapeGraphAI.SiteMonitorResponse> GetMonitorV1SiteMonitorsMonitorIdGetAsync(
            string monitorId,
            global::ScrapeGraphAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}