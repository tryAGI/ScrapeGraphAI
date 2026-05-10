
#nullable enable

namespace ScrapeGraphAI
{
    /// <summary>
    /// Perform an action on the page
    /// </summary>
    public sealed partial class ActionStep
    {
        /// <summary>
        /// Types of workflow steps<br/>
        /// Default Value: action
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ScrapeGraphAI.JsonConverters.StepTypeJsonConverter))]
        public global::ScrapeGraphAI.StepType? Type { get; set; }

        /// <summary>
        /// Natural language action description (e.g., 'Click login button', 'Fill email with {{email}}')
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Action { get; set; }

        /// <summary>
        /// Whether to observe elements before acting<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("observe_first")]
        public bool? ObserveFirst { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionStep" /> class.
        /// </summary>
        /// <param name="action">
        /// Natural language action description (e.g., 'Click login button', 'Fill email with {{email}}')
        /// </param>
        /// <param name="type">
        /// Types of workflow steps<br/>
        /// Default Value: action
        /// </param>
        /// <param name="observeFirst">
        /// Whether to observe elements before acting<br/>
        /// Default Value: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ActionStep(
            string action,
            global::ScrapeGraphAI.StepType? type,
            bool? observeFirst)
        {
            this.Type = type;
            this.Action = action ?? throw new global::System.ArgumentNullException(nameof(action));
            this.ObserveFirst = observeFirst;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionStep" /> class.
        /// </summary>
        public ActionStep()
        {
        }

    }
}