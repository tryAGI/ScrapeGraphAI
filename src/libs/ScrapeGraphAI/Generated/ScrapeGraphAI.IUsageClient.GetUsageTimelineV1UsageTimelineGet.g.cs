#nullable enable

namespace ScrapeGraphAI
{
    public partial interface IUsageClient
    {
        /// <summary>
        /// Get Usage Timeline<br/>
        /// Get usage timeline with only timestamps for chart rendering.
        /// </summary>
        /// <param name="days">
        /// Default Value: all
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ScrapeGraphAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ScrapeGraphAI.UsageTimelineResponse> GetUsageTimelineV1UsageTimelineGetAsync(
            global::ScrapeGraphAI.GetUsageTimelineV1UsageTimelineGetDays2? days = default,
            global::ScrapeGraphAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}