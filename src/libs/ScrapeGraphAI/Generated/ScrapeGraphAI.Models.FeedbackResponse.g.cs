
#nullable enable

namespace ScrapeGraphAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FeedbackResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("feedback_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid FeedbackId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid RequestId { get; set; }

        /// <summary>
        /// Default Value: Feedback submitted successfully
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("feedback_timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime FeedbackTimestamp { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedbackResponse" /> class.
        /// </summary>
        /// <param name="feedbackId"></param>
        /// <param name="requestId"></param>
        /// <param name="feedbackTimestamp"></param>
        /// <param name="message">
        /// Default Value: Feedback submitted successfully
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FeedbackResponse(
            global::System.Guid feedbackId,
            global::System.Guid requestId,
            global::System.DateTime feedbackTimestamp,
            string? message)
        {
            this.FeedbackId = feedbackId;
            this.RequestId = requestId;
            this.Message = message;
            this.FeedbackTimestamp = feedbackTimestamp;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedbackResponse" /> class.
        /// </summary>
        public FeedbackResponse()
        {
        }

    }
}