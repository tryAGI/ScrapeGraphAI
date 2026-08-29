
#nullable enable

namespace ScrapeGraphAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class FeedbackCreate
    {
        /// <summary>
        /// ID of the request/session this feedback is for
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid RequestId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rating")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Rating { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("feedback_text")]
        public string? FeedbackText { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedbackCreate" /> class.
        /// </summary>
        /// <param name="requestId">
        /// ID of the request/session this feedback is for
        /// </param>
        /// <param name="rating"></param>
        /// <param name="feedbackText"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FeedbackCreate(
            global::System.Guid requestId,
            int rating,
            string? feedbackText)
        {
            this.RequestId = requestId;
            this.Rating = rating;
            this.FeedbackText = feedbackText;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedbackCreate" /> class.
        /// </summary>
        public FeedbackCreate()
        {
        }

    }
}