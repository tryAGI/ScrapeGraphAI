
#nullable enable

namespace ScrapeGraphAI
{
    /// <summary>
    /// Result of a single step execution
    /// </summary>
    public sealed partial class StepResult
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("step_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int StepIndex { get; set; }

        /// <summary>
        /// Types of workflow steps
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("step_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ScrapeGraphAI.JsonConverters.StepTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ScrapeGraphAI.StepType StepType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Success { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public object? Data { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration_seconds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double DurationSeconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StepResult" /> class.
        /// </summary>
        /// <param name="stepIndex"></param>
        /// <param name="stepType">
        /// Types of workflow steps
        /// </param>
        /// <param name="success"></param>
        /// <param name="durationSeconds"></param>
        /// <param name="error"></param>
        /// <param name="data"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StepResult(
            int stepIndex,
            global::ScrapeGraphAI.StepType stepType,
            bool success,
            double durationSeconds,
            string? error,
            object? data)
        {
            this.StepIndex = stepIndex;
            this.StepType = stepType;
            this.Success = success;
            this.Error = error;
            this.Data = data;
            this.DurationSeconds = durationSeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StepResult" /> class.
        /// </summary>
        public StepResult()
        {
        }

    }
}