
#nullable enable

namespace ScrapeGraphAI
{
    /// <summary>
    /// Request model for schema generation
    /// </summary>
    public sealed partial class SchemaGenerationRequest
    {
        /// <summary>
        /// The user's search query to be refined
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserPrompt { get; set; }

        /// <summary>
        /// Optional existing JSON schema to modify/extend
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("existing_schema")]
        public object? ExistingSchema { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SchemaGenerationRequest" /> class.
        /// </summary>
        /// <param name="userPrompt">
        /// The user's search query to be refined
        /// </param>
        /// <param name="existingSchema">
        /// Optional existing JSON schema to modify/extend
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SchemaGenerationRequest(
            string userPrompt,
            object? existingSchema)
        {
            this.UserPrompt = userPrompt ?? throw new global::System.ArgumentNullException(nameof(userPrompt));
            this.ExistingSchema = existingSchema;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SchemaGenerationRequest" /> class.
        /// </summary>
        public SchemaGenerationRequest()
        {
        }
    }
}