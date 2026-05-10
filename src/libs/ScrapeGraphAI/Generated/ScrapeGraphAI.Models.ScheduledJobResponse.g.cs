
#nullable enable

namespace ScrapeGraphAI
{
    /// <summary>
    /// Response model for scheduled job operations
    /// </summary>
    public sealed partial class ScheduledJobResponse
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
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid UserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("job_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string JobName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ScrapeGraphAI.JsonConverters.ServiceTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ScrapeGraphAI.ServiceType ServiceType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cron_expression")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CronExpression { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("job_config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object JobConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_active")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsActive { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_run_at")]
        public global::System.DateTime? LastRunAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_run_at")]
        public global::System.DateTime? NextRunAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduledJobResponse" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="userId"></param>
        /// <param name="jobName"></param>
        /// <param name="serviceType"></param>
        /// <param name="cronExpression"></param>
        /// <param name="jobConfig"></param>
        /// <param name="isActive"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="lastRunAt"></param>
        /// <param name="nextRunAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ScheduledJobResponse(
            global::System.Guid id,
            global::System.Guid userId,
            string jobName,
            global::ScrapeGraphAI.ServiceType serviceType,
            string cronExpression,
            object jobConfig,
            bool isActive,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            global::System.DateTime? lastRunAt,
            global::System.DateTime? nextRunAt)
        {
            this.Id = id;
            this.UserId = userId;
            this.JobName = jobName ?? throw new global::System.ArgumentNullException(nameof(jobName));
            this.ServiceType = serviceType;
            this.CronExpression = cronExpression ?? throw new global::System.ArgumentNullException(nameof(cronExpression));
            this.JobConfig = jobConfig ?? throw new global::System.ArgumentNullException(nameof(jobConfig));
            this.IsActive = isActive;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.LastRunAt = lastRunAt;
            this.NextRunAt = nextRunAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduledJobResponse" /> class.
        /// </summary>
        public ScheduledJobResponse()
        {
        }

    }
}