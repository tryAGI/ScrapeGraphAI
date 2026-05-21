
#nullable enable

namespace ScrapeGraphAI
{
    /// <summary>
    /// Database model for smart scraper requests.
    /// </summary>
    public sealed partial class SmartscraperRequestDB
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid RequestId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        public global::System.Guid? UserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webpage_id")]
        public global::System.Guid? WebpageId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("website_url")]
        public string? WebsiteUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserPrompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_schema")]
        public object? OutputSchema { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        public object? Result { get; set; }

        /// <summary>
        /// Default Value: processing
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ScrapeGraphAI.JsonConverters.SmartscraperStatusJsonConverter))]
        public global::ScrapeGraphAI.SmartscraperStatus? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requested_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime RequestedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finished_at")]
        public global::System.DateTime? FinishedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

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
        /// Initializes a new instance of the <see cref="SmartscraperRequestDB" /> class.
        /// </summary>
        /// <param name="requestId"></param>
        /// <param name="userPrompt"></param>
        /// <param name="requestedAt"></param>
        /// <param name="userId"></param>
        /// <param name="webpageId"></param>
        /// <param name="websiteUrl"></param>
        /// <param name="outputSchema"></param>
        /// <param name="result"></param>
        /// <param name="status">
        /// Default Value: processing
        /// </param>
        /// <param name="finishedAt"></param>
        /// <param name="error"></param>
        /// <param name="metadata"></param>
        /// <param name="requestParams"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SmartscraperRequestDB(
            global::System.Guid requestId,
            string userPrompt,
            global::System.DateTime requestedAt,
            global::System.Guid? userId,
            global::System.Guid? webpageId,
            string? websiteUrl,
            object? outputSchema,
            object? result,
            global::ScrapeGraphAI.SmartscraperStatus? status,
            global::System.DateTime? finishedAt,
            string? error,
            object? metadata,
            object? requestParams)
        {
            this.RequestId = requestId;
            this.UserId = userId;
            this.WebpageId = webpageId;
            this.WebsiteUrl = websiteUrl;
            this.UserPrompt = userPrompt ?? throw new global::System.ArgumentNullException(nameof(userPrompt));
            this.OutputSchema = outputSchema;
            this.Result = result;
            this.Status = status;
            this.RequestedAt = requestedAt;
            this.FinishedAt = finishedAt;
            this.Error = error;
            this.Metadata = metadata;
            this.RequestParams = requestParams;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SmartscraperRequestDB" /> class.
        /// </summary>
        public SmartscraperRequestDB()
        {
        }

    }
}