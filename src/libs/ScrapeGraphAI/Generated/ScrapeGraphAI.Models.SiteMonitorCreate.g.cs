
#nullable enable

namespace ScrapeGraphAI
{
    /// <summary>
    /// Request body for registering a new site monitor.
    /// </summary>
    public sealed partial class SiteMonitorCreate
    {
        /// <summary>
        /// Human-readable name for the monitor
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// URL to monitor
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("website_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WebsiteUrl { get; set; }

        /// <summary>
        /// URL to POST webhook events to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WebhookUrl { get; set; }

        /// <summary>
        /// Cron schedule (5 fields, UTC), e.g. '*/15 * * * *' for every 15 min
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cron_expression")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CronExpression { get; set; }

        /// <summary>
        /// Optional: user_prompt and output_schema for structured extraction and diff<br/>
        /// Default Value: {"user_prompt":"Extract all main content and key data as structured JSON."}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extraction_config")]
        public global::ScrapeGraphAI.SiteMonitorExtractionConfig? ExtractionConfig { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SiteMonitorCreate" /> class.
        /// </summary>
        /// <param name="websiteUrl">
        /// URL to monitor
        /// </param>
        /// <param name="webhookUrl">
        /// URL to POST webhook events to
        /// </param>
        /// <param name="cronExpression">
        /// Cron schedule (5 fields, UTC), e.g. '*/15 * * * *' for every 15 min
        /// </param>
        /// <param name="name">
        /// Human-readable name for the monitor
        /// </param>
        /// <param name="extractionConfig">
        /// Optional: user_prompt and output_schema for structured extraction and diff<br/>
        /// Default Value: {"user_prompt":"Extract all main content and key data as structured JSON."}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SiteMonitorCreate(
            string websiteUrl,
            string webhookUrl,
            string cronExpression,
            string? name,
            global::ScrapeGraphAI.SiteMonitorExtractionConfig? extractionConfig)
        {
            this.Name = name;
            this.WebsiteUrl = websiteUrl ?? throw new global::System.ArgumentNullException(nameof(websiteUrl));
            this.WebhookUrl = webhookUrl ?? throw new global::System.ArgumentNullException(nameof(webhookUrl));
            this.CronExpression = cronExpression ?? throw new global::System.ArgumentNullException(nameof(cronExpression));
            this.ExtractionConfig = extractionConfig;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SiteMonitorCreate" /> class.
        /// </summary>
        public SiteMonitorCreate()
        {
        }
    }
}