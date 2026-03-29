#nullable enable

namespace ScrapeGraphAI
{
    public partial interface IScheduledJobsClient
    {
        /// <summary>
        /// Get Scheduled Job<br/>
        /// Get a specific scheduled job
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ScrapeGraphAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ScrapeGraphAI.ScheduledJobResponse> GetScheduledJobV1ScheduledJobsJobIdGetAsync(
            string jobId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}