#nullable enable

namespace ScrapeGraphAI
{
    public partial interface IEndpointPocClient
    {
        /// <summary>
        /// Get Suggestions
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ScrapeGraphAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ScrapeGraphAI.EndPointSuggestionsResponse> GetSuggestionsV1EndpointGetSuggestionsPostAsync(

            global::ScrapeGraphAI.EndPointSuggestionRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Suggestions
        /// </summary>
        /// <param name="websiteUrl"></param>
        /// <param name="prompt"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ScrapeGraphAI.EndPointSuggestionsResponse> GetSuggestionsV1EndpointGetSuggestionsPostAsync(
            string websiteUrl,
            string prompt,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}