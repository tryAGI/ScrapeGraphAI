#nullable enable

namespace ScrapeGraphAI
{
    public partial interface IHealthClient
    {
        /// <summary>
        /// Health Check<br/>
        /// Health check endpoint that includes memory monitoring
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ScrapeGraphAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> HealthCheckHealthzGetAsync(
            global::ScrapeGraphAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}