
#nullable enable

namespace ScrapeGraphAI
{
    /// <summary>
    /// Main workflow definition
    /// </summary>
    public sealed partial class WorkflowDefinition
    {
        /// <summary>
        /// Unique workflow identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflow_id")]
        public string? WorkflowId { get; set; }

        /// <summary>
        /// Human-readable workflow name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Workflow description
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Initial URL to navigate to (can be overridden)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_url")]
        public string? StartUrl { get; set; }

        /// <summary>
        /// Whether to use persistent browser session<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("use_session")]
        public bool? UseSession { get; set; }

        /// <summary>
        /// Ordered list of workflow steps
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("steps")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ScrapeGraphAI.AnyOf<global::ScrapeGraphAI.NavigationStep, global::ScrapeGraphAI.ActionStep, global::ScrapeGraphAI.ExtractionStep, global::ScrapeGraphAI.MarkdownExtractionStep, global::ScrapeGraphAI.LoopStep, global::ScrapeGraphAI.ConditionalStep, global::ScrapeGraphAI.SubWorkflowStep, global::ScrapeGraphAI.WaitStep>> Steps { get; set; }

        /// <summary>
        /// Initial variables/context (e.g., {'email': 'user@example.com', 'password': 'secret'})
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("initial_context")]
        public object? InitialContext { get; set; }

        /// <summary>
        /// List of variables to include in final output
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_variables")]
        public global::System.Collections.Generic.IList<string>? OutputVariables { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowDefinition" /> class.
        /// </summary>
        /// <param name="name">
        /// Human-readable workflow name
        /// </param>
        /// <param name="steps">
        /// Ordered list of workflow steps
        /// </param>
        /// <param name="workflowId">
        /// Unique workflow identifier
        /// </param>
        /// <param name="description">
        /// Workflow description
        /// </param>
        /// <param name="startUrl">
        /// Initial URL to navigate to (can be overridden)
        /// </param>
        /// <param name="useSession">
        /// Whether to use persistent browser session<br/>
        /// Default Value: false
        /// </param>
        /// <param name="initialContext">
        /// Initial variables/context (e.g., {'email': 'user@example.com', 'password': 'secret'})
        /// </param>
        /// <param name="outputVariables">
        /// List of variables to include in final output
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkflowDefinition(
            string name,
            global::System.Collections.Generic.IList<global::ScrapeGraphAI.AnyOf<global::ScrapeGraphAI.NavigationStep, global::ScrapeGraphAI.ActionStep, global::ScrapeGraphAI.ExtractionStep, global::ScrapeGraphAI.MarkdownExtractionStep, global::ScrapeGraphAI.LoopStep, global::ScrapeGraphAI.ConditionalStep, global::ScrapeGraphAI.SubWorkflowStep, global::ScrapeGraphAI.WaitStep>> steps,
            string? workflowId,
            string? description,
            string? startUrl,
            bool? useSession,
            object? initialContext,
            global::System.Collections.Generic.IList<string>? outputVariables)
        {
            this.WorkflowId = workflowId;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.StartUrl = startUrl;
            this.UseSession = useSession;
            this.Steps = steps ?? throw new global::System.ArgumentNullException(nameof(steps));
            this.InitialContext = initialContext;
            this.OutputVariables = outputVariables;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowDefinition" /> class.
        /// </summary>
        public WorkflowDefinition()
        {
        }
    }
}