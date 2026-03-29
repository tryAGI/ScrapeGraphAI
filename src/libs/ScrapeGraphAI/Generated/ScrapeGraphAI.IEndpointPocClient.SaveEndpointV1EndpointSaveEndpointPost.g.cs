#nullable enable

namespace ScrapeGraphAI
{
    public partial interface IEndpointPocClient
    {
        /// <summary>
        /// Save Endpoint
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ScrapeGraphAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> SaveEndpointV1EndpointSaveEndpointPostAsync(

            global::ScrapeGraphAI.EndPointSuggestions request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Save Endpoint
        /// </summary>
        /// <param name="suggestions"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> SaveEndpointV1EndpointSaveEndpointPostAsync(
            global::System.Collections.Generic.IList<global::ScrapeGraphAI.EndpointSuggestion> suggestions,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}