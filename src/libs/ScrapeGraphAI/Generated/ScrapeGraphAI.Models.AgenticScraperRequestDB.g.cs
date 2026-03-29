
#nullable enable

namespace ScrapeGraphAI
{
    /// <summary>
    /// DynamoDB model for agentic scraper requests.
    /// </summary>
    public sealed partial class AgenticScraperRequestDB
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RequestId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webpage_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WebpageId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("website_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WebsiteUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_prompt")]
        public string? UserPrompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_schema")]
        public object? OutputSchema { get; set; }

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
        /// Status enum for agentic scraper requests.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ScrapeGraphAI.JsonConverters.AgenticScrapperStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ScrapeGraphAI.AgenticScrapperStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        public object? Result { get; set; }

        /// <summary>
        /// Default Value: 0F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_cost")]
        public double? TotalCost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage_id")]
        public string? UsageId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgenticScraperRequestDB" /> class.
        /// </summary>
        /// <param name="requestId"></param>
        /// <param name="userId"></param>
        /// <param name="webpageId"></param>
        /// <param name="websiteUrl"></param>
        /// <param name="requestedAt"></param>
        /// <param name="status">
        /// Status enum for agentic scraper requests.
        /// </param>
        /// <param name="userPrompt"></param>
        /// <param name="outputSchema"></param>
        /// <param name="finishedAt"></param>
        /// <param name="metadata"></param>
        /// <param name="result"></param>
        /// <param name="totalCost">
        /// Default Value: 0F
        /// </param>
        /// <param name="usageId"></param>
        /// <param name="error"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgenticScraperRequestDB(
            string requestId,
            string userId,
            string webpageId,
            string websiteUrl,
            global::System.DateTime requestedAt,
            global::ScrapeGraphAI.AgenticScrapperStatus status,
            string? userPrompt,
            object? outputSchema,
            global::System.DateTime? finishedAt,
            object? metadata,
            object? result,
            double? totalCost,
            string? usageId,
            string? error)
        {
            this.RequestId = requestId ?? throw new global::System.ArgumentNullException(nameof(requestId));
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.WebpageId = webpageId ?? throw new global::System.ArgumentNullException(nameof(webpageId));
            this.WebsiteUrl = websiteUrl ?? throw new global::System.ArgumentNullException(nameof(websiteUrl));
            this.UserPrompt = userPrompt;
            this.OutputSchema = outputSchema;
            this.RequestedAt = requestedAt;
            this.FinishedAt = finishedAt;
            this.Status = status;
            this.Metadata = metadata;
            this.Result = result;
            this.TotalCost = totalCost;
            this.UsageId = usageId;
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgenticScraperRequestDB" /> class.
        /// </summary>
        public AgenticScraperRequestDB()
        {
        }
    }
}