
#nullable enable

namespace ScrapeGraphAI
{
    /// <summary>
    /// Map parent context variables to subworkflow variables (e.g., {'url': '{{current_link}}'})
    /// </summary>
    public sealed partial class SubWorkflowStepInputMapping
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}