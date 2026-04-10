#nullable enable

namespace ScrapeGraphAI
{
    public partial interface IAdminClient
    {
        /// <summary>
        /// Query Redis Cache By Pattern
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ScrapeGraphAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> QueryRedisCacheByPatternV1AdminQueryRedisCacheByPatternPostAsync(

            global::ScrapeGraphAI.QueryRedisCacheByPatternRequest request,
            global::ScrapeGraphAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Query Redis Cache By Pattern
        /// </summary>
        /// <param name="cursor">
        /// Default Value: 0
        /// </param>
        /// <param name="pageSize">
        /// Default Value: 100
        /// </param>
        /// <param name="pattern">
        /// Default Value: providers_order:*
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> QueryRedisCacheByPatternV1AdminQueryRedisCacheByPatternPostAsync(
            int? cursor = default,
            int? pageSize = default,
            string? pattern = default,
            global::ScrapeGraphAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}