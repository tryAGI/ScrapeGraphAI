#nullable enable

namespace ScrapeGraphAI
{
    public partial interface IScheduledJobsClient
    {
        /// <summary>
        /// Fetch Scheduled Jobs<br/>
        /// Get user's scheduled jobs with pagination
        /// </summary>
        /// <param name="page">
        /// Page number<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="pageSize">
        /// Number of jobs per page<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="serviceType">
        /// Filter by service type
        /// </param>
        /// <param name="isActive">
        /// Filter by active status
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ScrapeGraphAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ScrapeGraphAI.ScheduledJobListResponse> FetchScheduledJobsV1ScheduledJobsGetAsync(
            int? page = default,
            int? pageSize = default,
            global::ScrapeGraphAI.ServiceType? serviceType = default,
            bool? isActive = default,
            global::ScrapeGraphAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}