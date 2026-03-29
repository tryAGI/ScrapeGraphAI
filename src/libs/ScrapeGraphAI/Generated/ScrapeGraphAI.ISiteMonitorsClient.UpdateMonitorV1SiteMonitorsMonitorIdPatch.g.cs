#nullable enable

namespace ScrapeGraphAI
{
    public partial interface ISiteMonitorsClient
    {
        /// <summary>
        /// Update Monitor<br/>
        /// Update a site monitor. Schedule is updated if cron or config changed.
        /// </summary>
        /// <param name="monitorId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ScrapeGraphAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ScrapeGraphAI.SiteMonitorResponse> UpdateMonitorV1SiteMonitorsMonitorIdPatchAsync(
            string monitorId,

            global::ScrapeGraphAI.SiteMonitorUpdate request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Monitor<br/>
        /// Update a site monitor. Schedule is updated if cron or config changed.
        /// </summary>
        /// <param name="monitorId"></param>
        /// <param name="name"></param>
        /// <param name="webhookUrl"></param>
        /// <param name="cronExpression"></param>
        /// <param name="extractionConfig"></param>
        /// <param name="isActive"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ScrapeGraphAI.SiteMonitorResponse> UpdateMonitorV1SiteMonitorsMonitorIdPatchAsync(
            string monitorId,
            string? name = default,
            string? webhookUrl = default,
            string? cronExpression = default,
            global::ScrapeGraphAI.SiteMonitorExtractionConfig? extractionConfig = default,
            bool? isActive = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}