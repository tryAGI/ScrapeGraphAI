
#nullable enable

namespace ScrapeGraphAI
{
    /// <summary>
    /// Map subworkflow output variables back to parent context
    /// </summary>
    public sealed partial class SubWorkflowStepOutputMapping
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}