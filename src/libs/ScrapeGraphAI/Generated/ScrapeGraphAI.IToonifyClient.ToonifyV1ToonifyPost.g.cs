#nullable enable

namespace ScrapeGraphAI
{
    public partial interface IToonifyClient
    {
        /// <summary>
        /// Toonify
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ScrapeGraphAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ToonifyV1ToonifyPostAsync(

            object request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Toonify
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> ToonifyV1ToonifyPostAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}