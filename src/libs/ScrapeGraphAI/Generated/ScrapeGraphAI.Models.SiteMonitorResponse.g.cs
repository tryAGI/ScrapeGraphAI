
#nullable enable

namespace ScrapeGraphAI
{
    /// <summary>
    /// Response for a single site monitor.
    /// </summary>
    public sealed partial class SiteMonitorResponse
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
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ApiKeyId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("website_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WebsiteUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WebhookUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cron_expression")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CronExpression { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extraction_config")]
        public object? ExtractionConfig { get; set; }

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
        /// Initializes a new instance of the <see cref="SiteMonitorResponse" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="userId"></param>
        /// <param name="apiKeyId"></param>
        /// <param name="websiteUrl"></param>
        /// <param name="webhookUrl"></param>
        /// <param name="cronExpression"></param>
        /// <param name="isActive"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="name"></param>
        /// <param name="extractionConfig"></param>
        /// <param name="lastRunAt"></param>
        /// <param name="nextRunAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SiteMonitorResponse(
            global::System.Guid id,
            global::System.Guid userId,
            global::System.Guid apiKeyId,
            string websiteUrl,
            string webhookUrl,
            string cronExpression,
            bool isActive,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string? name,
            object? extractionConfig,
            global::System.DateTime? lastRunAt,
            global::System.DateTime? nextRunAt)
        {
            this.Id = id;
            this.UserId = userId;
            this.ApiKeyId = apiKeyId;
            this.Name = name;
            this.WebsiteUrl = websiteUrl ?? throw new global::System.ArgumentNullException(nameof(websiteUrl));
            this.WebhookUrl = webhookUrl ?? throw new global::System.ArgumentNullException(nameof(webhookUrl));
            this.CronExpression = cronExpression ?? throw new global::System.ArgumentNullException(nameof(cronExpression));
            this.ExtractionConfig = extractionConfig;
            this.IsActive = isActive;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.LastRunAt = lastRunAt;
            this.NextRunAt = nextRunAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SiteMonitorResponse" /> class.
        /// </summary>
        public SiteMonitorResponse()
        {
        }

    }
}