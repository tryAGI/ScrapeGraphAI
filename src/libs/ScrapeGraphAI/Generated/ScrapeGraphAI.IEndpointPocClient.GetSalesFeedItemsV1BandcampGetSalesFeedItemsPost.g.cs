#nullable enable

namespace ScrapeGraphAI
{
    public partial interface IEndpointPocClient
    {
        /// <summary>
        /// Get Sales Feed Items
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ScrapeGraphAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetSalesFeedItemsV1BandcampGetSalesFeedItemsPostAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}