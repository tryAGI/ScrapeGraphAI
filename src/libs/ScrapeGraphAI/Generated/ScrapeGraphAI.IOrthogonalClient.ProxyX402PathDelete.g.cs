#nullable enable

namespace ScrapeGraphAI
{
    public partial interface IOrthogonalClient
    {
        /// <summary>
        /// Proxy<br/>
        /// Proxy endpoint for Orthogonal API integration.<br/>
        /// Forwards requests to https://api.orth.sh/pay/{ORTHOGONHAL_API_KEY}/{path}
        /// </summary>
        /// <param name="path"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ScrapeGraphAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ProxyX402PathDeleteAsync(
            string path,
            global::ScrapeGraphAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Proxy<br/>
        /// Proxy endpoint for Orthogonal API integration.<br/>
        /// Forwards requests to https://api.orth.sh/pay/{ORTHOGONHAL_API_KEY}/{path}
        /// </summary>
        /// <param name="path"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ScrapeGraphAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ScrapeGraphAI.AutoSDKHttpResponse<string>> ProxyX402PathDeleteAsResponseAsync(
            string path,
            global::ScrapeGraphAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}