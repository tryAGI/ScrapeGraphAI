
#nullable enable

namespace ScrapeGraphAI
{
    /// <summary>
    /// Iterate over an array
    /// </summary>
    public sealed partial class LoopStep
    {
        /// <summary>
        /// Types of workflow steps<br/>
        /// Default Value: loop
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ScrapeGraphAI.JsonConverters.StepTypeJsonConverter))]
        public global::ScrapeGraphAI.StepType? Type { get; set; }

        /// <summary>
        /// Variable name containing array to iterate over (e.g., 'product_links')
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("iterate_over")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string IterateOver { get; set; }

        /// <summary>
        /// Variable name for current item in loop (e.g., 'current_link')<br/>
        /// Default Value: item
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item_name")]
        public string? ItemName { get; set; }

        /// <summary>
        /// Variable name for current index (e.g., 'i')<br/>
        /// Default Value: index
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index_name")]
        public string? IndexName { get; set; }

        /// <summary>
        /// Steps to execute for each item
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("steps")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ScrapeGraphAI.AnyOf<global::ScrapeGraphAI.NavigationStep, global::ScrapeGraphAI.ActionStep, global::ScrapeGraphAI.ExtractionStep, global::ScrapeGraphAI.MarkdownExtractionStep, global::ScrapeGraphAI.LoopStep, global::ScrapeGraphAI.ConditionalStep, global::ScrapeGraphAI.SubWorkflowStep, global::ScrapeGraphAI.WaitStep>> Steps { get; set; }

        /// <summary>
        /// Maximum number of iterations (safety limit)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_iterations")]
        public int? MaxIterations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LoopStep" /> class.
        /// </summary>
        /// <param name="iterateOver">
        /// Variable name containing array to iterate over (e.g., 'product_links')
        /// </param>
        /// <param name="steps">
        /// Steps to execute for each item
        /// </param>
        /// <param name="type">
        /// Types of workflow steps<br/>
        /// Default Value: loop
        /// </param>
        /// <param name="itemName">
        /// Variable name for current item in loop (e.g., 'current_link')<br/>
        /// Default Value: item
        /// </param>
        /// <param name="indexName">
        /// Variable name for current index (e.g., 'i')<br/>
        /// Default Value: index
        /// </param>
        /// <param name="maxIterations">
        /// Maximum number of iterations (safety limit)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LoopStep(
            string iterateOver,
            global::System.Collections.Generic.IList<global::ScrapeGraphAI.AnyOf<global::ScrapeGraphAI.NavigationStep, global::ScrapeGraphAI.ActionStep, global::ScrapeGraphAI.ExtractionStep, global::ScrapeGraphAI.MarkdownExtractionStep, global::ScrapeGraphAI.LoopStep, global::ScrapeGraphAI.ConditionalStep, global::ScrapeGraphAI.SubWorkflowStep, global::ScrapeGraphAI.WaitStep>> steps,
            global::ScrapeGraphAI.StepType? type,
            string? itemName,
            string? indexName,
            int? maxIterations)
        {
            this.Type = type;
            this.IterateOver = iterateOver ?? throw new global::System.ArgumentNullException(nameof(iterateOver));
            this.ItemName = itemName;
            this.IndexName = indexName;
            this.Steps = steps ?? throw new global::System.ArgumentNullException(nameof(steps));
            this.MaxIterations = maxIterations;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LoopStep" /> class.
        /// </summary>
        public LoopStep()
        {
        }

    }
}