#nullable enable

namespace ScrapeGraphAI
{
    public partial interface IScheduledJobsClient
    {
        /// <summary>
        /// Delete Scheduled Job<br/>
        /// Delete a scheduled job
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ScrapeGraphAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteScheduledJobV1ScheduledJobsJobIdDeleteAsync(
            string jobId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}