#nullable enable

namespace ScrapeGraphAI
{
    public partial interface IScheduledJobsClient
    {
        /// <summary>
        /// Replace Scheduled Job
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ScrapeGraphAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ScrapeGraphAI.ScheduledJobResponse> ReplaceScheduledJobV1ScheduledJobsJobIdPutAsync(
            string jobId,

            global::ScrapeGraphAI.ScheduledJobCreate request,
            global::ScrapeGraphAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Replace Scheduled Job
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ScrapeGraphAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ScrapeGraphAI.AutoSDKHttpResponse<global::ScrapeGraphAI.ScheduledJobResponse>> ReplaceScheduledJobV1ScheduledJobsJobIdPutAsResponseAsync(
            string jobId,

            global::ScrapeGraphAI.ScheduledJobCreate request,
            global::ScrapeGraphAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Replace Scheduled Job
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="jobName">
        /// Human-readable name for the scheduled job
        /// </param>
        /// <param name="serviceType">
        /// Type of service to run: smartscraper, searchscraper, markdownify, or smartcrawler
        /// </param>
        /// <param name="cronExpression">
        /// Standard 5-field cron expression (minute hour day month day_of_week) in UTC timezone. All times are interpreted as UTC (e.g., '0 9 * * 1' for 9 AM UTC every Monday)
        /// </param>
        /// <param name="jobConfig">
        /// Service-specific configuration that matches the service's request schema
        /// </param>
        /// <param name="isActive">
        /// Whether the job is active and should be scheduled<br/>
        /// Default Value: true
        /// </param>
        /// <param name="webhookUrl">
        /// Webhook URL to send the job result to
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ScrapeGraphAI.ScheduledJobResponse> ReplaceScheduledJobV1ScheduledJobsJobIdPutAsync(
            string jobId,
            string jobName,
            global::ScrapeGraphAI.ServiceType serviceType,
            string cronExpression,
            object jobConfig,
            bool? isActive = default,
            string? webhookUrl = default,
            global::ScrapeGraphAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}