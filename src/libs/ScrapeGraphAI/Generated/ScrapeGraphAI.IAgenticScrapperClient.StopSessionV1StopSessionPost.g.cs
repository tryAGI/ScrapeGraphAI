#nullable enable

namespace ScrapeGraphAI
{
    public partial interface IAgenticScrapperClient
    {
        /// <summary>
        /// Stop Session
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ScrapeGraphAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> StopSessionV1StopSessionPostAsync(

            global::ScrapeGraphAI.AgenticScrapperStopSessionRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Stop Session
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> StopSessionV1StopSessionPostAsync(
            string sessionId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}