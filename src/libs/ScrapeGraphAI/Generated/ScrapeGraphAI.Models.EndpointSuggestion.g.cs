
#nullable enable

namespace ScrapeGraphAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EndpointSuggestion
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpoint")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Endpoint { get; set; }

        /// <summary>
        /// Default Value: POST
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("method")]
        public string? Method { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TargetUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameters")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ScrapeGraphAI.EndpointParameter> Parameters { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pydantic_schema")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object PydanticSchema { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extraction_prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ExtractionPrompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("interaction_steps")]
        public global::System.Collections.Generic.IList<string>? InteractionSteps { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EndpointSuggestion" /> class.
        /// </summary>
        /// <param name="endpoint"></param>
        /// <param name="description"></param>
        /// <param name="targetUrl"></param>
        /// <param name="parameters"></param>
        /// <param name="pydanticSchema"></param>
        /// <param name="extractionPrompt"></param>
        /// <param name="method">
        /// Default Value: POST
        /// </param>
        /// <param name="interactionSteps"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EndpointSuggestion(
            string endpoint,
            string description,
            string targetUrl,
            global::System.Collections.Generic.IList<global::ScrapeGraphAI.EndpointParameter> parameters,
            object pydanticSchema,
            string extractionPrompt,
            string? method,
            global::System.Collections.Generic.IList<string>? interactionSteps)
        {
            this.Endpoint = endpoint ?? throw new global::System.ArgumentNullException(nameof(endpoint));
            this.Method = method;
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.TargetUrl = targetUrl ?? throw new global::System.ArgumentNullException(nameof(targetUrl));
            this.Parameters = parameters ?? throw new global::System.ArgumentNullException(nameof(parameters));
            this.PydanticSchema = pydanticSchema ?? throw new global::System.ArgumentNullException(nameof(pydanticSchema));
            this.ExtractionPrompt = extractionPrompt ?? throw new global::System.ArgumentNullException(nameof(extractionPrompt));
            this.InteractionSteps = interactionSteps;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EndpointSuggestion" /> class.
        /// </summary>
        public EndpointSuggestion()
        {
        }
    }
}