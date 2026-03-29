#nullable enable

namespace ScrapeGraphAI
{
    public partial interface IAgenticScrapperClient
    {
        /// <summary>
        /// Get Live Session Url
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ScrapeGraphAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ScrapeGraphAI.AgenticScrapperLiveSessionUrlResponse> GetLiveSessionUrlV1GetLiveSessionUrlPostAsync(

            global::ScrapeGraphAI.AgenticScrapperLiveSessionUrlRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Live Session Url
        /// </summary>
        /// <param name="url"></param>
        /// <param name="timeout">
        /// Timeout for the live session<br/>
        /// Default Value: 300
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ScrapeGraphAI.AgenticScrapperLiveSessionUrlResponse> GetLiveSessionUrlV1GetLiveSessionUrlPostAsync(
            string url,
            int? timeout = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}