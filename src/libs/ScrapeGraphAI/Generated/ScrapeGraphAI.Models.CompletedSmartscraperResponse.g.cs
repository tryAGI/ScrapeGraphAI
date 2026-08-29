
#nullable enable

namespace ScrapeGraphAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CompletedSmartscraperResponse
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
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ScrapeGraphAI.JsonConverters.SmartscraperStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ScrapeGraphAI.SmartscraperStatus Status { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ScrapeGraphAI.JsonConverters.AnyOfJsonConverter<object, string, object>))]
        public global::ScrapeGraphAI.AnyOf<object, string, object>? Result { get; set; }

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
        /// Initializes a new instance of the <see cref="CompletedSmartscraperResponse" /> class.
        /// </summary>
        /// <param name="requestId"></param>
        /// <param name="status"></param>
        /// <param name="userPrompt"></param>
        /// <param name="websiteUrl"></param>
        /// <param name="result"></param>
        /// <param name="error"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CompletedSmartscraperResponse(
            string requestId,
            global::ScrapeGraphAI.SmartscraperStatus status,
            string userPrompt,
            string? websiteUrl,
            global::ScrapeGraphAI.AnyOf<object, string, object>? result,
            string? error)
        {
            this.RequestId = requestId ?? throw new global::System.ArgumentNullException(nameof(requestId));
            this.Status = status;
            this.WebsiteUrl = websiteUrl;
            this.UserPrompt = userPrompt ?? throw new global::System.ArgumentNullException(nameof(userPrompt));
            this.Result = result;
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompletedSmartscraperResponse" /> class.
        /// </summary>
        public CompletedSmartscraperResponse()
        {
        }

    }
}