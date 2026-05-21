
#nullable enable

namespace ScrapeGraphAI
{
    /// <summary>
    /// Wait for a condition or time
    /// </summary>
    public sealed partial class WaitStep
    {
        /// <summary>
        /// Types of workflow steps<br/>
        /// Default Value: wait
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ScrapeGraphAI.JsonConverters.StepTypeJsonConverter))]
        public global::ScrapeGraphAI.StepType? Type { get; set; }

        /// <summary>
        /// Seconds to wait
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public double? Duration { get; set; }

        /// <summary>
        /// CSS selector to wait for
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("for_selector")]
        public string? ForSelector { get; set; }

        /// <summary>
        /// JavaScript condition to wait for
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("for_condition")]
        public string? ForCondition { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WaitStep" /> class.
        /// </summary>
        /// <param name="type">
        /// Types of workflow steps<br/>
        /// Default Value: wait
        /// </param>
        /// <param name="duration">
        /// Seconds to wait
        /// </param>
        /// <param name="forSelector">
        /// CSS selector to wait for
        /// </param>
        /// <param name="forCondition">
        /// JavaScript condition to wait for
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WaitStep(
            global::ScrapeGraphAI.StepType? type,
            double? duration,
            string? forSelector,
            string? forCondition)
        {
            this.Type = type;
            this.Duration = duration;
            this.ForSelector = forSelector;
            this.ForCondition = forCondition;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WaitStep" /> class.
        /// </summary>
        public WaitStep()
        {
        }

    }
}