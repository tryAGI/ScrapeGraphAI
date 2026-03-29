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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ScrapeGraphAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ExecuteEndpointV1EndpointEndpointIdFullPathPostAsync(
            string endpointId,
            string fullPath,

            object request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Execute Endpoint
        /// </summary>
        /// <param name="endpointId"></param>
        /// <param name="fullPath"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> ExecuteEndpointV1EndpointEndpointIdFullPathPostAsync(
            string endpointId,
            string fullPath,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}