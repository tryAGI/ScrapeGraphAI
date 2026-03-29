
#nullable enable

namespace ScrapeGraphAI
{
    /// <summary>
    /// Execute a subworkflow
    /// </summary>
    public sealed partial class SubWorkflowStep
    {
        /// <summary>
        /// Types of workflow steps<br/>
        /// Default Value: subworkflow
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ScrapeGraphAI.JsonConverters.StepTypeJsonConverter))]
        public global::ScrapeGraphAI.StepType? Type { get; set; }

        /// <summary>
        /// ID of saved workflow to execute
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflow_id")]
        public string? WorkflowId { get; set; }

        /// <summary>
        /// Inline workflow definition
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflow")]
        public global::ScrapeGraphAI.WorkflowDefinition? Workflow { get; set; }

        /// <summary>
        /// Map parent context variables to subworkflow variables (e.g., {'url': '{{current_link}}'})
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_mapping")]
        public global::System.Collections.Generic.Dictionary<string, string>? InputMapping { get; set; }

        /// <summary>
        /// Map subworkflow output variables back to parent context
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_mapping")]
        public global::System.Collections.Generic.Dictionary<string, string>? OutputMapping { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubWorkflowStep" /> class.
        /// </summary>
        /// <param name="type">
        /// Types of workflow steps<br/>
        /// Default Value: subworkflow
        /// </param>
        /// <param name="workflowId">
        /// ID of saved workflow to execute
        /// </param>
        /// <param name="workflow">
        /// Inline workflow definition
        /// </param>
        /// <param name="inputMapping">
        /// Map parent context variables to subworkflow variables (e.g., {'url': '{{current_link}}'})
        /// </param>
        /// <param name="outputMapping">
        /// Map subworkflow output variables back to parent context
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SubWorkflowStep(
            global::ScrapeGraphAI.StepType? type,
            string? workflowId,
            global::ScrapeGraphAI.WorkflowDefinition? workflow,
            global::System.Collections.Generic.Dictionary<string, string>? inputMapping,
            global::System.Collections.Generic.Dictionary<string, string>? outputMapping)
        {
            this.Type = type;
            this.WorkflowId = workflowId;
            this.Workflow = workflow;
            this.InputMapping = inputMapping;
            this.OutputMapping = outputMapping;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubWorkflowStep" /> class.
        /// </summary>
        public SubWorkflowStep()
        {
        }
    }
}