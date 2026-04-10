#nullable enable

namespace ScrapeGraphAI
{
    public partial interface ISiteMonitorsClient
    {
        /// <summary>
        /// Create Monitor<br/>
        /// Register a website for monitoring. We will check on the given cron schedule and POST webhook events on content change.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ScrapeGraphAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ScrapeGraphAI.SiteMonitorResponse> CreateMonitorV1SiteMonitorsPostAsync(

            global::ScrapeGraphAI.SiteMonitorCreate request,
            global::ScrapeGraphAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Monitor<br/>
        /// Register a website for monitoring. We will check on the given cron schedule and POST webhook events on content change.
        /// </summary>
        /// <param name="name">
        /// Human-readable name for the monitor
        /// </param>
        /// <param name="websiteUrl">
        /// URL to monitor
        /// </param>
        /// <param name="webhookUrl">
        /// URL to POST webhook events to
        /// </param>
        /// <param name="cronExpression">
        /// Cron schedule (5 fields, UTC), e.g. '*/15 * * * *' for every 15 min
        /// </param>
        /// <param name="extractionConfig">
        /// Optional: user_prompt and output_schema for structured extraction and diff<br/>
        /// Default Value: {"user_prompt":"Extract all main content and key data as structured JSON."}
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ScrapeGraphAI.SiteMonitorResponse> CreateMonitorV1SiteMonitorsPostAsync(
            string websiteUrl,
            string webhookUrl,
            string cronExpression,
            string? name = default,
            global::ScrapeGraphAI.SiteMonitorExtractionConfig? extractionConfig = default,
            global::ScrapeGraphAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}