
#nullable enable

namespace ScrapeGraphAI
{
    /// <summary>
    /// Pydantic model representing the markdownify_requests database table.
    /// </summary>
    public sealed partial class MarkdownifyRequestDB
    {
        /// <summary>
        /// Unique identifier for the request
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        public global::System.Guid? RequestId { get; set; }

        /// <summary>
        /// ID of the user who made the request
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        public global::System.Guid? UserId { get; set; }

        /// <summary>
        /// ID of the associated webpage
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webpage_id")]
        public global::System.Guid? WebpageId { get; set; }

        /// <summary>
        /// Timestamp when the request was made
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requested_at")]
        public global::System.DateTime? RequestedAt { get; set; }

        /// <summary>
        /// Current status of the request
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ScrapeGraphAI.JsonConverters.MarkdownifyRequestStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ScrapeGraphAI.MarkdownifyRequestStatus Status { get; set; }

        /// <summary>
        /// Error message if the request failed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// URL of the website to be markdownified
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("website_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WebsiteUrl { get; set; }

        /// <summary>
        /// Timestamp when the request was completed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finished_at")]
        public global::System.DateTime? FinishedAt { get; set; }

        /// <summary>
        /// Additional metadata about the request
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// ID of the associated LLM usage record
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage_id")]
        public global::System.Guid? UsageId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_params")]
        public object? RequestParams { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MarkdownifyRequestDB" /> class.
        /// </summary>
        /// <param name="status">
        /// Current status of the request
        /// </param>
        /// <param name="websiteUrl">
        /// URL of the website to be markdownified
        /// </param>
        /// <param name="requestId">
        /// Unique identifier for the request
        /// </param>
        /// <param name="userId">
        /// ID of the user who made the request
        /// </param>
        /// <param name="webpageId">
        /// ID of the associated webpage
        /// </param>
        /// <param name="requestedAt">
        /// Timestamp when the request was made
        /// </param>
        /// <param name="error">
        /// Error message if the request failed
        /// </param>
        /// <param name="finishedAt">
        /// Timestamp when the request was completed
        /// </param>
        /// <param name="metadata">
        /// Additional metadata about the request
        /// </param>
        /// <param name="usageId">
        /// ID of the associated LLM usage record
        /// </param>
        /// <param name="requestParams"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MarkdownifyRequestDB(
            global::ScrapeGraphAI.MarkdownifyRequestStatus status,
            string websiteUrl,
            global::System.Guid? requestId,
            global::System.Guid? userId,
            global::System.Guid? webpageId,
            global::System.DateTime? requestedAt,
            string? error,
            global::System.DateTime? finishedAt,
            object? metadata,
            global::System.Guid? usageId,
            object? requestParams)
        {
            this.RequestId = requestId;
            this.UserId = userId;
            this.WebpageId = webpageId;
            this.RequestedAt = requestedAt;
            this.Status = status;
            this.Error = error;
            this.WebsiteUrl = websiteUrl ?? throw new global::System.ArgumentNullException(nameof(websiteUrl));
            this.FinishedAt = finishedAt;
            this.Metadata = metadata;
            this.UsageId = usageId;
            this.RequestParams = requestParams;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MarkdownifyRequestDB" /> class.
        /// </summary>
        public MarkdownifyRequestDB()
        {
        }

    }
}