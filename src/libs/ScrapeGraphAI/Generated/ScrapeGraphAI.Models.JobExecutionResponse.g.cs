
#nullable enable

namespace ScrapeGraphAI
{
    /// <summary>
    /// Response model for job execution details
    /// </summary>
    public sealed partial class JobExecutionResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scheduled_job_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ScheduledJobId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("execution_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ExecutionId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Status { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("started_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime StartedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed_at")]
        public global::System.DateTime? CompletedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        public object? Result { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_message")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credits_used")]
        public int? CreditsUsed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="JobExecutionResponse" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="scheduledJobId"></param>
        /// <param name="executionId"></param>
        /// <param name="status"></param>
        /// <param name="startedAt"></param>
        /// <param name="completedAt"></param>
        /// <param name="result"></param>
        /// <param name="errorMessage"></param>
        /// <param name="creditsUsed">
        /// Default Value: 0
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public JobExecutionResponse(
            global::System.Guid id,
            global::System.Guid scheduledJobId,
            string executionId,
            string status,
            global::System.DateTime startedAt,
            global::System.DateTime? completedAt,
            object? result,
            string? errorMessage,
            int? creditsUsed)
        {
            this.Id = id;
            this.ScheduledJobId = scheduledJobId;
            this.ExecutionId = executionId ?? throw new global::System.ArgumentNullException(nameof(executionId));
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.StartedAt = startedAt;
            this.CompletedAt = completedAt;
            this.Result = result;
            this.ErrorMessage = errorMessage;
            this.CreditsUsed = creditsUsed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JobExecutionResponse" /> class.
        /// </summary>
        public JobExecutionResponse()
        {
        }

    }
}