
#nullable enable

namespace ScrapeGraphAI
{
    /// <summary>
    /// Response model for manual job trigger
    /// </summary>
    public sealed partial class JobTriggerResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("execution_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ExecutionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scheduled_job_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ScheduledJobId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("triggered_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime TriggeredAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="JobTriggerResponse" /> class.
        /// </summary>
        /// <param name="executionId"></param>
        /// <param name="message"></param>
        /// <param name="scheduledJobId"></param>
        /// <param name="triggeredAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public JobTriggerResponse(
            string executionId,
            string message,
            global::System.Guid scheduledJobId,
            global::System.DateTime triggeredAt)
        {
            this.ExecutionId = executionId ?? throw new global::System.ArgumentNullException(nameof(executionId));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.ScheduledJobId = scheduledJobId;
            this.TriggeredAt = triggeredAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JobTriggerResponse" /> class.
        /// </summary>
        public JobTriggerResponse()
        {
        }

    }
}