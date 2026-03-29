
#nullable enable

namespace ScrapeGraphAI
{
    /// <summary>
    /// Extract markdown from the page
    /// </summary>
    public sealed partial class MarkdownExtractionStep
    {
        /// <summary>
        /// Types of workflow steps<br/>
        /// Default Value: extract_markdown
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ScrapeGraphAI.JsonConverters.StepTypeJsonConverter))]
        public global::ScrapeGraphAI.StepType? Type { get; set; }

        /// <summary>
        /// Variable name to save extracted markdown to (e.g., 'markdown')
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("save_to")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SaveTo { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MarkdownExtractionStep" /> class.
        /// </summary>
        /// <param name="saveTo">
        /// Variable name to save extracted markdown to (e.g., 'markdown')
        /// </param>
        /// <param name="type">
        /// Types of workflow steps<br/>
        /// Default Value: extract_markdown
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MarkdownExtractionStep(
            string saveTo,
            global::ScrapeGraphAI.StepType? type)
        {
            this.Type = type;
            this.SaveTo = saveTo ?? throw new global::System.ArgumentNullException(nameof(saveTo));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MarkdownExtractionStep" /> class.
        /// </summary>
        public MarkdownExtractionStep()
        {
        }
    }
}