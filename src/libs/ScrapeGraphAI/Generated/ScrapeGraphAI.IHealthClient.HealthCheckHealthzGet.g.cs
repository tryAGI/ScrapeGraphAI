#nullable enable

namespace ScrapeGraphAI
{
    public partial interface IHealthClient
    {
        /// <summary>
        /// Health Check<br/>
        /// Health check endpoint that includes memory monitoring
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ScrapeGraphAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> HealthCheckHealthzGetAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}