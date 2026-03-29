#nullable enable

namespace ScrapeGraphAI
{
    public partial interface IEndpointPocClient
    {
        /// <summary>
        /// Get Sales Feed Items Details
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ScrapeGraphAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetSalesFeedItemsDetailsV1BandcampGetItemDetailsPostAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}