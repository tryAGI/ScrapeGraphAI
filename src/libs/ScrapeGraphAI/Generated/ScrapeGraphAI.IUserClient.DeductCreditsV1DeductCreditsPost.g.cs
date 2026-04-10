#nullable enable

namespace ScrapeGraphAI
{
    public partial interface IUserClient
    {
        /// <summary>
        /// Deduct Credits
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ScrapeGraphAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ScrapeGraphAI.DeductCreditsResponse> DeductCreditsV1DeductCreditsPostAsync(

            global::ScrapeGraphAI.DeductCreditsBody request,
            global::ScrapeGraphAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Deduct Credits
        /// </summary>
        /// <param name="creditsToDeduct"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ScrapeGraphAI.DeductCreditsResponse> DeductCreditsV1DeductCreditsPostAsync(
            int creditsToDeduct,
            global::ScrapeGraphAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}