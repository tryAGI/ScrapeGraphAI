
#nullable enable

namespace ScrapeGraphAI
{
    /// <summary>
    /// Response model for schema generation
    /// </summary>
    public sealed partial class SchemaGenerationResponse
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
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserPrompt { get; set; }

        /// <summary>
        /// The refined search query
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("refined_prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RefinedPrompt { get; set; }

        /// <summary>
        /// The generated JSON schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generated_schema")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object GeneratedSchema { get; set; }

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
        /// Initializes a new instance of the <see cref="SchemaGenerationResponse" /> class.
        /// </summary>
        /// <param name="requestId"></param>
        /// <param name="status"></param>
        /// <param name="userPrompt"></param>
        /// <param name="refinedPrompt">
        /// The refined search query
        /// </param>
        /// <param name="generatedSchema">
        /// The generated JSON schema
        /// </param>
        /// <param name="error"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SchemaGenerationResponse(
            global::System.Guid requestId,
            string status,
            string userPrompt,
            string refinedPrompt,
            object generatedSchema,
            string? error)
        {
            this.RequestId = requestId;
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.UserPrompt = userPrompt ?? throw new global::System.ArgumentNullException(nameof(userPrompt));
            this.RefinedPrompt = refinedPrompt ?? throw new global::System.ArgumentNullException(nameof(refinedPrompt));
            this.GeneratedSchema = generatedSchema ?? throw new global::System.ArgumentNullException(nameof(generatedSchema));
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SchemaGenerationResponse" /> class.
        /// </summary>
        public SchemaGenerationResponse()
        {
        }
    }
}