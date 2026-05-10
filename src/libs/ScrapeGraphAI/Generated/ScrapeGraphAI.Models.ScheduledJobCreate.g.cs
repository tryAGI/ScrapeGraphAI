
#nullable enable

namespace ScrapeGraphAI
{
    /// <summary>
    /// Model for creating scheduled jobs (required fields enforced)
    /// </summary>
    public sealed partial class ScheduledJobCreate
    {
        /// <summary>
        /// Human-readable name for the scheduled job
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("job_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string JobName { get; set; }

        /// <summary>
        /// Type of service to run: smartscraper, searchscraper, markdownify, or smartcrawler
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ScrapeGraphAI.JsonConverters.ServiceTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ScrapeGraphAI.ServiceType ServiceType { get; set; }

        /// <summary>
        /// Standard 5-field cron expression (minute hour day month day_of_week) in UTC timezone. All times are interpreted as UTC (e.g., '0 9 * * 1' for 9 AM UTC every Monday)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cron_expression")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CronExpression { get; set; }

        /// <summary>
        /// Service-specific configuration that matches the service's request schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("job_config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object JobConfig { get; set; }

        /// <summary>
        /// Whether the job is active and should be scheduled<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_active")]
        public bool? IsActive { get; set; }

        /// <summary>
        /// Webhook URL to send the job result to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_url")]
        public string? WebhookUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduledJobCreate" /> class.
        /// </summary>
        /// <param name="jobName">
        /// Human-readable name for the scheduled job
        /// </param>
        /// <param name="serviceType">
        /// Type of service to run: smartscraper, searchscraper, markdownify, or smartcrawler
        /// </param>
        /// <param name="cronExpression">
        /// Standard 5-field cron expression (minute hour day month day_of_week) in UTC timezone. All times are interpreted as UTC (e.g., '0 9 * * 1' for 9 AM UTC every Monday)
        /// </param>
        /// <param name="jobConfig">
        /// Service-specific configuration that matches the service's request schema
        /// </param>
        /// <param name="isActive">
        /// Whether the job is active and should be scheduled<br/>
        /// Default Value: true
        /// </param>
        /// <param name="webhookUrl">
        /// Webhook URL to send the job result to
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ScheduledJobCreate(
            string jobName,
            global::ScrapeGraphAI.ServiceType serviceType,
            string cronExpression,
            object jobConfig,
            bool? isActive,
            string? webhookUrl)
        {
            this.JobName = jobName ?? throw new global::System.ArgumentNullException(nameof(jobName));
            this.ServiceType = serviceType;
            this.CronExpression = cronExpression ?? throw new global::System.ArgumentNullException(nameof(cronExpression));
            this.JobConfig = jobConfig ?? throw new global::System.ArgumentNullException(nameof(jobConfig));
            this.IsActive = isActive;
            this.WebhookUrl = webhookUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduledJobCreate" /> class.
        /// </summary>
        public ScheduledJobCreate()
        {
        }

    }
}