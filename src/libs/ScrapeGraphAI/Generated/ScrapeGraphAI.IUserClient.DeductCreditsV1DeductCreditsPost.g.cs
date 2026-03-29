#nullable enable

namespace ScrapeGraphAI
{
    public partial interface IUserClient
    {
        /// <summary>
        /// Deduct Credits
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ScrapeGraphAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ScrapeGraphAI.DeductCreditsResponse> DeductCreditsV1DeductCreditsPostAsync(

            global::ScrapeGraphAI.DeductCreditsBody request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Deduct Credits
        /// </summary>
        /// <param name="creditsToDeduct"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ScrapeGraphAI.DeductCreditsResponse> DeductCreditsV1DeductCreditsPostAsync(
            int creditsToDeduct,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}