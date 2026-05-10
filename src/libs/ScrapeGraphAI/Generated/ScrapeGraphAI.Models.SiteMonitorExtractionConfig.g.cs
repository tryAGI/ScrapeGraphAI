
#nullable enable

namespace ScrapeGraphAI
{
    /// <summary>
    /// Optional extraction config for monitored page (smartscraper-style).
    /// </summary>
    public sealed partial class SiteMonitorExtractionConfig
    {
        /// <summary>
        /// Prompt for extracting structured data from the page
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_prompt")]
        public string? UserPrompt { get; set; }

        /// <summary>
        /// JSON schema for extracted fields (enables structured diff)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_schema")]
        public object? OutputSchema { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SiteMonitorExtractionConfig" /> class.
        /// </summary>
        /// <param name="userPrompt">
        /// Prompt for extracting structured data from the page
        /// </param>
        /// <param name="outputSchema">
        /// JSON schema for extracted fields (enables structured diff)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SiteMonitorExtractionConfig(
            string? userPrompt,
            object? outputSchema)
        {
            this.UserPrompt = userPrompt;
            this.OutputSchema = outputSchema;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SiteMonitorExtractionConfig" /> class.
        /// </summary>
        public SiteMonitorExtractionConfig()
        {
        }

    }
}