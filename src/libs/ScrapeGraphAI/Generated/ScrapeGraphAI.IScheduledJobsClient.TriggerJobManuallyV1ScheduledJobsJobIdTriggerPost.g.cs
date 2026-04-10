#nullable enable

namespace ScrapeGraphAI
{
    public partial interface IScheduledJobsClient
    {
        /// <summary>
        /// Trigger Job Manually<br/>
        /// Manually trigger a scheduled job<br/>
        /// Rate limited to 10 triggers per minute per user to prevent abuse.
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ScrapeGraphAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ScrapeGraphAI.JobTriggerResponse> TriggerJobManuallyV1ScheduledJobsJobIdTriggerPostAsync(
            string jobId,
            global::ScrapeGraphAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}