
#nullable enable

namespace ScrapeGraphAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CompletedSearchScraperResponse
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
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ScrapeGraphAI.JsonConverters.SearchScraperStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ScrapeGraphAI.SearchScraperStatus Status { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserPrompt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_results")]
        public int? NumResults { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Result { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reference_urls")]
        public global::System.Collections.Generic.IList<string>? ReferenceUrls { get; set; }

        /// <summary>
        /// Raw markdown content when extraction_mode is False
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("markdown_content")]
        public string? MarkdownContent { get; set; }

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
        /// Initializes a new instance of the <see cref="CompletedSearchScraperResponse" /> class.
        /// </summary>
        /// <param name="requestId"></param>
        /// <param name="status"></param>
        /// <param name="userPrompt"></param>
        /// <param name="result"></param>
        /// <param name="numResults"></param>
        /// <param name="referenceUrls"></param>
        /// <param name="markdownContent">
        /// Raw markdown content when extraction_mode is False
        /// </param>
        /// <param name="error"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CompletedSearchScraperResponse(
            global::System.Guid requestId,
            global::ScrapeGraphAI.SearchScraperStatus status,
            string userPrompt,
            object result,
            int? numResults,
            global::System.Collections.Generic.IList<string>? referenceUrls,
            string? markdownContent,
            string? error)
        {
            this.RequestId = requestId;
            this.Status = status;
            this.UserPrompt = userPrompt ?? throw new global::System.ArgumentNullException(nameof(userPrompt));
            this.NumResults = numResults;
            this.Result = result;
            this.ReferenceUrls = referenceUrls;
            this.MarkdownContent = markdownContent;
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompletedSearchScraperResponse" /> class.
        /// </summary>
        public CompletedSearchScraperResponse()
        {
        }

    }
}