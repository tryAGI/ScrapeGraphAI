
#nullable enable

namespace ScrapeGraphAI
{
    /// <summary>
    /// Navigate to a URL
    /// </summary>
    public sealed partial class NavigationStep
    {
        /// <summary>
        /// Types of workflow steps<br/>
        /// Default Value: navigate
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ScrapeGraphAI.JsonConverters.StepTypeJsonConverter))]
        public global::ScrapeGraphAI.StepType? Type { get; set; }

        /// <summary>
        /// URL to navigate to. Supports variable interpolation: {{variable_name}}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Optional selector to wait for after navigation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("wait_for")]
        public string? WaitFor { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NavigationStep" /> class.
        /// </summary>
        /// <param name="url">
        /// URL to navigate to. Supports variable interpolation: {{variable_name}}
        /// </param>
        /// <param name="type">
        /// Types of workflow steps<br/>
        /// Default Value: navigate
        /// </param>
        /// <param name="waitFor">
        /// Optional selector to wait for after navigation
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NavigationStep(
            string url,
            global::ScrapeGraphAI.StepType? type,
            string? waitFor)
        {
            this.Type = type;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.WaitFor = waitFor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NavigationStep" /> class.
        /// </summary>
        public NavigationStep()
        {
        }
    }
}