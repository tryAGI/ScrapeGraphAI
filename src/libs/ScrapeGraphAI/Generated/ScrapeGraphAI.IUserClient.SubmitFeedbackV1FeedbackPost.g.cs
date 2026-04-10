#nullable enable

namespace ScrapeGraphAI
{
    public partial interface IUserClient
    {
        /// <summary>
        /// Submit Feedback
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ScrapeGraphAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ScrapeGraphAI.FeedbackResponse> SubmitFeedbackV1FeedbackPostAsync(

            global::ScrapeGraphAI.FeedbackCreate request,
            global::ScrapeGraphAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Submit Feedback
        /// </summary>
        /// <param name="requestId">
        /// ID of the request/session this feedback is for
        /// </param>
        /// <param name="rating"></param>
        /// <param name="feedbackText"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ScrapeGraphAI.FeedbackResponse> SubmitFeedbackV1FeedbackPostAsync(
            global::System.Guid requestId,
            int rating,
            string? feedbackText = default,
            global::ScrapeGraphAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}