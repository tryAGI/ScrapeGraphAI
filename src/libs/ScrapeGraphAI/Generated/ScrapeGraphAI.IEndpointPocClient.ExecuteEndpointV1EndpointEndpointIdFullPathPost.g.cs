#nullable enable

namespace ScrapeGraphAI
{
    public partial interface IEndpointPocClient
    {
        /// <summary>
        /// Execute Endpoint
        /// </summary>
        /// <param name="endpointId"></param>
        /// <param name="fullPath"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ScrapeGraphAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ExecuteEndpointV1EndpointEndpointIdFullPathPostAsync(
            string endpointId,
            string fullPath,

            object request,
            global::ScrapeGraphAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Execute Endpoint
        /// </summary>
        /// <param name="endpointId"></param>
        /// <param name="fullPath"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ScrapeGraphAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ScrapeGraphAI.AutoSDKHttpResponse<string>> ExecuteEndpointV1EndpointEndpointIdFullPathPostAsResponseAsync(
            string endpointId,
            string fullPath,

            object request,
            global::ScrapeGraphAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Execute Endpoint
        /// </summary>
        /// <param name="endpointId"></param>
        /// <param name="fullPath"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> ExecuteEndpointV1EndpointEndpointIdFullPathPostAsync(
            string endpointId,
            string fullPath,
            global::ScrapeGraphAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}