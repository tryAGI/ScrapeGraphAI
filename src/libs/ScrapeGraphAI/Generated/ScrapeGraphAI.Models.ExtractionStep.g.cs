
#nullable enable

namespace ScrapeGraphAI
{
    /// <summary>
    /// Extract data from the page
    /// </summary>
    public sealed partial class ExtractionStep
    {
        /// <summary>
        /// Types of workflow steps<br/>
        /// Default Value: extract
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ScrapeGraphAI.JsonConverters.StepTypeJsonConverter))]
        public global::ScrapeGraphAI.StepType? Type { get; set; }

        /// <summary>
        /// What to extract (e.g., 'Extract all product links from the page')
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instruction")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Instruction { get; set; }

        /// <summary>
        /// Optional schema for structured extraction
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schema")]
        public object? Schema { get; set; }

        /// <summary>
        /// Variable name to save extracted data to (e.g., 'product_links')
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
        /// Initializes a new instance of the <see cref="ExtractionStep" /> class.
        /// </summary>
        /// <param name="instruction">
        /// What to extract (e.g., 'Extract all product links from the page')
        /// </param>
        /// <param name="saveTo">
        /// Variable name to save extracted data to (e.g., 'product_links')
        /// </param>
        /// <param name="type">
        /// Types of workflow steps<br/>
        /// Default Value: extract
        /// </param>
        /// <param name="schema">
        /// Optional schema for structured extraction
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExtractionStep(
            string instruction,
            string saveTo,
            global::ScrapeGraphAI.StepType? type,
            object? schema)
        {
            this.Type = type;
            this.Instruction = instruction ?? throw new global::System.ArgumentNullException(nameof(instruction));
            this.Schema = schema;
            this.SaveTo = saveTo ?? throw new global::System.ArgumentNullException(nameof(saveTo));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractionStep" /> class.
        /// </summary>
        public ExtractionStep()
        {
        }
    }
}