
#nullable enable

namespace ScrapeGraphAI
{
    /// <summary>
    /// Request body for updating a site monitor (partial).
    /// </summary>
    public sealed partial class SiteMonitorUpdate
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_url")]
        public string? WebhookUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cron_expression")]
        public string? CronExpression { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extraction_config")]
        public global::ScrapeGraphAI.SiteMonitorExtractionConfig? ExtractionConfig { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_active")]
        public bool? IsActive { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SiteMonitorUpdate" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="webhookUrl"></param>
        /// <param name="cronExpression"></param>
        /// <param name="extractionConfig"></param>
        /// <param name="isActive"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SiteMonitorUpdate(
            string? name,
            string? webhookUrl,
            string? cronExpression,
            global::ScrapeGraphAI.SiteMonitorExtractionConfig? extractionConfig,
            bool? isActive)
        {
            this.Name = name;
            this.WebhookUrl = webhookUrl;
            this.CronExpression = cronExpression;
            this.ExtractionConfig = extractionConfig;
            this.IsActive = isActive;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SiteMonitorUpdate" /> class.
        /// </summary>
        public SiteMonitorUpdate()
        {
        }

    }
}