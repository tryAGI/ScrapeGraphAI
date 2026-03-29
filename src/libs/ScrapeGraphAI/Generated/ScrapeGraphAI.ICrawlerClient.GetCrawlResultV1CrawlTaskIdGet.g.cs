#nullable enable

namespace ScrapeGraphAI
{
    public partial interface ICrawlerClient
    {
        /// <summary>
        /// Get Crawl Result<br/>
        /// Get the result of a crawl job by task ID.
        /// </summary>
        /// <param name="taskId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ScrapeGraphAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetCrawlResultV1CrawlTaskIdGetAsync(
            string taskId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}