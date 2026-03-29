#nullable enable

namespace ScrapeGraphAI
{
    public partial interface IScheduledJobsClient
    {
        /// <summary>
        /// Update Scheduled Job<br/>
        /// Update a scheduled job
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ScrapeGraphAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ScrapeGraphAI.ScheduledJobResponse> UpdateScheduledJobV1ScheduledJobsJobIdPatchAsync(
            string jobId,

            object request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Scheduled Job<br/>
        /// Update a scheduled job
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ScrapeGraphAI.ScheduledJobResponse> UpdateScheduledJobV1ScheduledJobsJobIdPatchAsync(
            string jobId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}