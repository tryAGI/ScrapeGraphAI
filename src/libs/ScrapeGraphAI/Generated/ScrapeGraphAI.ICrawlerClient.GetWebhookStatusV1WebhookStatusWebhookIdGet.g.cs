#nullable enable

namespace ScrapeGraphAI
{
    public partial interface ICrawlerClient
    {
        /// <summary>
        /// Get Webhook Status<br/>
        /// Get status of a specific webhook delivery.
        /// </summary>
        /// <param name="webhookId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ScrapeGraphAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetWebhookStatusV1WebhookStatusWebhookIdGetAsync(
            string webhookId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}