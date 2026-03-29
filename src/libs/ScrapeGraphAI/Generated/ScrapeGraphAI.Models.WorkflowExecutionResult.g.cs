
#nullable enable

namespace ScrapeGraphAI
{
    /// <summary>
    /// Result of workflow execution
    /// </summary>
    public sealed partial class WorkflowExecutionResult
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RequestId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflow_id")]
        public string? WorkflowId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Success { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("steps_executed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ScrapeGraphAI.StepResult> StepsExecuted { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_duration_seconds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TotalDurationSeconds { get; set; }

        /// <summary>
        /// Final workflow context with all variables
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("final_context")]
        public object? FinalContext { get; set; }

        /// <summary>
        /// Filtered output based on output_variables
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        public object? Output { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("final_url")]
        public string? FinalUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("final_html")]
        public string? FinalHtml { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        public string? SessionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowExecutionResult" /> class.
        /// </summary>
        /// <param name="requestId"></param>
        /// <param name="success"></param>
        /// <param name="stepsExecuted"></param>
        /// <param name="totalDurationSeconds"></param>
        /// <param name="workflowId"></param>
        /// <param name="finalContext">
        /// Final workflow context with all variables
        /// </param>
        /// <param name="output">
        /// Filtered output based on output_variables
        /// </param>
        /// <param name="finalUrl"></param>
        /// <param name="finalHtml"></param>
        /// <param name="sessionId"></param>
        /// <param name="error"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkflowExecutionResult(
            string requestId,
            bool success,
            global::System.Collections.Generic.IList<global::ScrapeGraphAI.StepResult> stepsExecuted,
            double totalDurationSeconds,
            string? workflowId,
            object? finalContext,
            object? output,
            string? finalUrl,
            string? finalHtml,
            string? sessionId,
            string? error)
        {
            this.RequestId = requestId ?? throw new global::System.ArgumentNullException(nameof(requestId));
            this.WorkflowId = workflowId;
            this.Success = success;
            this.StepsExecuted = stepsExecuted ?? throw new global::System.ArgumentNullException(nameof(stepsExecuted));
            this.TotalDurationSeconds = totalDurationSeconds;
            this.FinalContext = finalContext;
            this.Output = output;
            this.FinalUrl = finalUrl;
            this.FinalHtml = finalHtml;
            this.SessionId = sessionId;
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowExecutionResult" /> class.
        /// </summary>
        public WorkflowExecutionResult()
        {
        }
    }
}