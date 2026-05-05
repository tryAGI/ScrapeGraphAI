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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ScrapeGraphAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetWebhookLogsV1WebhookLogsCrawlerIdGetAsync(
            string crawlerId,
            global::ScrapeGraphAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Webhook Logs<br/>
        /// Get webhook delivery logs for a crawler job.
        /// </summary>
        /// <param name="crawlerId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ScrapeGraphAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ScrapeGraphAI.AutoSDKHttpResponse<string>> GetWebhookLogsV1WebhookLogsCrawlerIdGetAsResponseAsync(
            string crawlerId,
            global::ScrapeGraphAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}