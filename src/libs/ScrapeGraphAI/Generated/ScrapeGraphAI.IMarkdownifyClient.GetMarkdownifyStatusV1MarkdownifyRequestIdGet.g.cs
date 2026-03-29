#nullable enable

namespace ScrapeGraphAI
{
    public partial interface IMarkdownifyClient
    {
        /// <summary>
        /// Get Markdownify Status
        /// </summary>
        /// <param name="requestId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ScrapeGraphAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetMarkdownifyStatusV1MarkdownifyRequestIdGetAsync(
            string requestId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}