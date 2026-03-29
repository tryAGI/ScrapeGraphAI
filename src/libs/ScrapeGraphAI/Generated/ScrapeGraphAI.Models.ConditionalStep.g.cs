
#nullable enable

namespace ScrapeGraphAI
{
    /// <summary>
    /// Conditional execution (if/else)
    /// </summary>
    public sealed partial class ConditionalStep
    {
        /// <summary>
        /// Types of workflow steps<br/>
        /// Default Value: conditional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ScrapeGraphAI.JsonConverters.StepTypeJsonConverter))]
        public global::ScrapeGraphAI.StepType? Type { get; set; }

        /// <summary>
        /// Condition to evaluate (e.g., '{{index}} &lt; 10', '{{item}} != null')
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("condition")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Condition { get; set; }

        /// <summary>
        /// Steps to execute if condition is true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("if_steps")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ScrapeGraphAI.AnyOf<global::ScrapeGraphAI.NavigationStep, global::ScrapeGraphAI.ActionStep, global::ScrapeGraphAI.ExtractionStep, global::ScrapeGraphAI.MarkdownExtractionStep, global::ScrapeGraphAI.LoopStep, global::ScrapeGraphAI.ConditionalStep, global::ScrapeGraphAI.SubWorkflowStep, global::ScrapeGraphAI.WaitStep>> IfSteps { get; set; }

        /// <summary>
        /// Steps to execute if condition is false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("else_steps")]
        public global::System.Collections.Generic.IList<global::ScrapeGraphAI.AnyOf<global::ScrapeGraphAI.NavigationStep, global::ScrapeGraphAI.ActionStep, global::ScrapeGraphAI.ExtractionStep, global::ScrapeGraphAI.MarkdownExtractionStep, global::ScrapeGraphAI.LoopStep, global::ScrapeGraphAI.ConditionalStep, global::ScrapeGraphAI.SubWorkflowStep, global::ScrapeGraphAI.WaitStep>>? ElseSteps { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConditionalStep" /> class.
        /// </summary>
        /// <param name="condition">
        /// Condition to evaluate (e.g., '{{index}} &lt; 10', '{{item}} != null')
        /// </param>
        /// <param name="ifSteps">
        /// Steps to execute if condition is true
        /// </param>
        /// <param name="type">
        /// Types of workflow steps<br/>
        /// Default Value: conditional
        /// </param>
        /// <param name="elseSteps">
        /// Steps to execute if condition is false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConditionalStep(
            string condition,
            global::System.Collections.Generic.IList<global::ScrapeGraphAI.AnyOf<global::ScrapeGraphAI.NavigationStep, global::ScrapeGraphAI.ActionStep, global::ScrapeGraphAI.ExtractionStep, global::ScrapeGraphAI.MarkdownExtractionStep, global::ScrapeGraphAI.LoopStep, global::ScrapeGraphAI.ConditionalStep, global::ScrapeGraphAI.SubWorkflowStep, global::ScrapeGraphAI.WaitStep>> ifSteps,
            global::ScrapeGraphAI.StepType? type,
            global::System.Collections.Generic.IList<global::ScrapeGraphAI.AnyOf<global::ScrapeGraphAI.NavigationStep, global::ScrapeGraphAI.ActionStep, global::ScrapeGraphAI.ExtractionStep, global::ScrapeGraphAI.MarkdownExtractionStep, global::ScrapeGraphAI.LoopStep, global::ScrapeGraphAI.ConditionalStep, global::ScrapeGraphAI.SubWorkflowStep, global::ScrapeGraphAI.WaitStep>>? elseSteps)
        {
            this.Type = type;
            this.Condition = condition ?? throw new global::System.ArgumentNullException(nameof(condition));
            this.IfSteps = ifSteps ?? throw new global::System.ArgumentNullException(nameof(ifSteps));
            this.ElseSteps = elseSteps;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConditionalStep" /> class.
        /// </summary>
        public ConditionalStep()
        {
        }
    }
}