#nullable enable

namespace ScrapeGraphAI
{
    public partial interface IScheduledJobsClient
    {
        /// <summary>
        /// Resume Scheduled Job
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ScrapeGraphAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ResumeScheduledJobV1ScheduledJobsJobIdResumePostAsync(
            string jobId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}