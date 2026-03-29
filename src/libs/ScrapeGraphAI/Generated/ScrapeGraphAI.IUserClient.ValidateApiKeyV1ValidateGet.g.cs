#nullable enable

namespace ScrapeGraphAI
{
    public partial interface IUserClient
    {
        /// <summary>
        /// Validate Api Key
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ScrapeGraphAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ValidateApiKeyV1ValidateGetAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}