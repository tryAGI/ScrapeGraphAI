#nullable enable

namespace ScrapeGraphAI
{
    public partial interface ISitemapClient
    {
        /// <summary>
        /// Generate Sitemap
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ScrapeGraphAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ScrapeGraphAI.SitemapResponse> GenerateSitemapV1SitemapPostAsync(

            global::ScrapeGraphAI.SitemapRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate Sitemap
        /// </summary>
        /// <param name="websiteUrl">
        /// The URL of the website to generate a sitemap for
        /// </param>
        /// <param name="stream">
        /// Whether to return streaming response<br/>
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ScrapeGraphAI.SitemapResponse> GenerateSitemapV1SitemapPostAsync(
            string websiteUrl,
            bool? stream = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}