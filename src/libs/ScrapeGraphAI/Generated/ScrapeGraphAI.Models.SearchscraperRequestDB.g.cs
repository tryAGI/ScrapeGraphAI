
#nullable enable

namespace ScrapeGraphAI
{
    /// <summary>
    /// Database model for search scraper requests.
    /// </summary>
    public sealed partial class SearchscraperRequestDB
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        public global::System.Guid? RequestId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        public global::System.Guid? UserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserPrompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("search_query")]
        public string? SearchQuery { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extraction_query")]
        public string? ExtractionQuery { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("references_urls")]
        public global::System.Collections.Generic.IList<string>? ReferencesUrls { get; set; }

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
        /// Default Value: queued
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ScrapeGraphAI.JsonConverters.SearchScraperStatusJsonConverter))]
        public global::ScrapeGraphAI.SearchScraperStatus? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requested_at")]
        public global::System.DateTime? RequestedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finished_at")]
        public global::System.DateTime? FinishedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchscraperRequestDB" /> class.
        /// </summary>
        /// <param name="userPrompt"></param>
        /// <param name="requestId"></param>
        /// <param name="userId"></param>
        /// <param name="searchQuery"></param>
        /// <param name="extractionQuery"></param>
        /// <param name="referencesUrls"></param>
        /// <param name="outputSchema"></param>
        /// <param name="result"></param>
        /// <param name="status">
        /// Default Value: queued
        /// </param>
        /// <param name="metadata"></param>
        /// <param name="error"></param>
        /// <param name="requestedAt"></param>
        /// <param name="finishedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchscraperRequestDB(
            string userPrompt,
            global::System.Guid? requestId,
            global::System.Guid? userId,
            string? searchQuery,
            string? extractionQuery,
            global::System.Collections.Generic.IList<string>? referencesUrls,
            object? outputSchema,
            object? result,
            global::ScrapeGraphAI.SearchScraperStatus? status,
            object? metadata,
            string? error,
            global::System.DateTime? requestedAt,
            global::System.DateTime? finishedAt)
        {
            this.RequestId = requestId;
            this.UserId = userId;
            this.UserPrompt = userPrompt ?? throw new global::System.ArgumentNullException(nameof(userPrompt));
            this.SearchQuery = searchQuery;
            this.ExtractionQuery = extractionQuery;
            this.ReferencesUrls = referencesUrls;
            this.OutputSchema = outputSchema;
            this.Result = result;
            this.Status = status;
            this.Metadata = metadata;
            this.Error = error;
            this.RequestedAt = requestedAt;
            this.FinishedAt = finishedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchscraperRequestDB" /> class.
        /// </summary>
        public SearchscraperRequestDB()
        {
        }

    }
}