#nullable enable

namespace ScrapeGraphAI
{
    public partial interface IUserClient
    {
        /// <summary>
        /// Submit Product Feedback
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ScrapeGraphAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ScrapeGraphAI.ProductFeedbackResponse> SubmitProductFeedbackV1ProductFeedbackPostAsync(

            global::ScrapeGraphAI.ProductFeedback request,
            global::ScrapeGraphAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Submit Product Feedback
        /// </summary>
        /// <param name="feedbackId"></param>
        /// <param name="name"></param>
        /// <param name="email"></param>
        /// <param name="company"></param>
        /// <param name="howDiscovered"></param>
        /// <param name="usageFrequency"></param>
        /// <param name="useCases"></param>
        /// <param name="rating"></param>
        /// <param name="likedMost"></param>
        /// <param name="disliked"></param>
        /// <param name="requestedFeatures"></param>
        /// <param name="setupEasy"></param>
        /// <param name="issues"></param>
        /// <param name="recommendScore"></param>
        /// <param name="improvementSuggestions"></param>
        /// <param name="canContact"></param>
        /// <param name="contactMethod"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ScrapeGraphAI.ProductFeedbackResponse> SubmitProductFeedbackV1ProductFeedbackPostAsync(
            global::System.Guid? feedbackId = default,
            string? name = default,
            string? email = default,
            string? company = default,
            string? howDiscovered = default,
            string? usageFrequency = default,
            global::System.Collections.Generic.IList<string>? useCases = default,
            int? rating = default,
            string? likedMost = default,
            string? disliked = default,
            string? requestedFeatures = default,
            bool? setupEasy = default,
            string? issues = default,
            int? recommendScore = default,
            string? improvementSuggestions = default,
            bool? canContact = default,
            string? contactMethod = default,
            global::ScrapeGraphAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}