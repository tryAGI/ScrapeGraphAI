#nullable enable

namespace ScrapeGraphAI
{
    public partial interface ISiteMonitorsClient
    {
        /// <summary>
        /// Delete Monitor<br/>
        /// Delete a site monitor and its schedule.
        /// </summary>
        /// <param name="monitorId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ScrapeGraphAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteMonitorV1SiteMonitorsMonitorIdDeleteAsync(
            string monitorId,
            global::ScrapeGraphAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete Monitor<br/>
        /// Delete a site monitor and its schedule.
        /// </summary>
        /// <param name="monitorId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ScrapeGraphAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ScrapeGraphAI.AutoSDKHttpResponse<string>> DeleteMonitorV1SiteMonitorsMonitorIdDeleteAsResponseAsync(
            string monitorId,
            global::ScrapeGraphAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}