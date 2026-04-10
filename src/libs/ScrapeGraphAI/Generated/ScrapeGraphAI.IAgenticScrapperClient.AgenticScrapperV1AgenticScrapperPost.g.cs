#nullable enable

namespace ScrapeGraphAI
{
    public partial interface IAgenticScrapperClient
    {
        /// <summary>
        /// Agentic Scrapper
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ScrapeGraphAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ScrapeGraphAI.AgenticScrapperResponse> AgenticScrapperV1AgenticScrapperPostAsync(

            global::ScrapeGraphAI.AgenticScrapperRequest request,
            global::ScrapeGraphAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Agentic Scrapper
        /// </summary>
        /// <param name="url"></param>
        /// <param name="userPrompt"></param>
        /// <param name="outputSchema">
        /// Default Value: {}
        /// </param>
        /// <param name="steps">
        /// List of steps to actions to perform on the website<br/>
        /// Default Value: []
        /// </param>
        /// <param name="useSession">
        /// Whether to use a session to scrape the website<br/>
        /// Default Value: false
        /// </param>
        /// <param name="aiExtraction">
        /// Whether to use AI extraction to extract the information<br/>
        /// Default Value: false
        /// </param>
        /// <param name="stream">
        /// Whether to return streaming response<br/>
        /// Default Value: false
        /// </param>
        /// <param name="webhookUrl">
        /// Webhook URL to send the job result to
        /// </param>
        /// <param name="countryCode">
        /// The country code to use for the scrape (e.g. US, GB)
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ScrapeGraphAI.AgenticScrapperResponse> AgenticScrapperV1AgenticScrapperPostAsync(
            string url,
            string? userPrompt = default,
            object? outputSchema = default,
            global::System.Collections.Generic.IList<string>? steps = default,
            bool? useSession = default,
            bool? aiExtraction = default,
            bool? stream = default,
            string? webhookUrl = default,
            string? countryCode = default,
            global::ScrapeGraphAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}