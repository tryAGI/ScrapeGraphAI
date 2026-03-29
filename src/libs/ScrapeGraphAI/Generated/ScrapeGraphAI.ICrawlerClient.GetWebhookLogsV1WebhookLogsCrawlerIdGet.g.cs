#nullable enable

namespace ScrapeGraphAI
{
    public partial interface ICrawlerClient
    {
        /// <summary>
        /// Get Webhook Logs<br/>
        /// Get webhook delivery logs for a crawler job.
        /// </summary>
        /// <param name="crawlerId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ScrapeGraphAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetWebhookLogsV1WebhookLogsCrawlerIdGetAsync(
            string crawlerId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}