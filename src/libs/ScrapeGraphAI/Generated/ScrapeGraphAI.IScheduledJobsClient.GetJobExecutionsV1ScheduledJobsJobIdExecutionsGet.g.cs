#nullable enable

namespace ScrapeGraphAI
{
    public partial interface IScheduledJobsClient
    {
        /// <summary>
        /// Get Job Executions<br/>
        /// Get execution history for a scheduled job
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="page">
        /// Page number<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="pageSize">
        /// Number of executions per page<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="status">
        /// Filter by execution status
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ScrapeGraphAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ScrapeGraphAI.JobExecutionListResponse> GetJobExecutionsV1ScheduledJobsJobIdExecutionsGetAsync(
            string jobId,
            int? page = default,
            int? pageSize = default,
            string? status = default,
            global::ScrapeGraphAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Job Executions<br/>
        /// Get execution history for a scheduled job
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="page">
        /// Page number<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="pageSize">
        /// Number of executions per page<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="status">
        /// Filter by execution status
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ScrapeGraphAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ScrapeGraphAI.AutoSDKHttpResponse<global::ScrapeGraphAI.JobExecutionListResponse>> GetJobExecutionsV1ScheduledJobsJobIdExecutionsGetAsResponseAsync(
            string jobId,
            int? page = default,
            int? pageSize = default,
            string? status = default,
            global::ScrapeGraphAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}