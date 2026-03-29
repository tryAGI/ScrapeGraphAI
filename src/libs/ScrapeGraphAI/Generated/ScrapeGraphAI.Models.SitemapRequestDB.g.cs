
#nullable enable

namespace ScrapeGraphAI
{
    /// <summary>
    /// Model for storing sitemap request history in DynamoDB.
    /// </summary>
    public sealed partial class SitemapRequestDB
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
        [global::System.Text.Json.Serialization.JsonPropertyName("website_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WebsiteUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ApiKeyId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid UserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requested_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime RequestedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("urls_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int UrlsCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_message")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SitemapRequestDB" /> class.
        /// </summary>
        /// <param name="requestId"></param>
        /// <param name="websiteUrl"></param>
        /// <param name="apiKeyId"></param>
        /// <param name="userId"></param>
        /// <param name="requestedAt"></param>
        /// <param name="status"></param>
        /// <param name="urlsCount"></param>
        /// <param name="errorMessage"></param>
        /// <param name="metadata"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SitemapRequestDB(
            string requestId,
            string websiteUrl,
            global::System.Guid apiKeyId,
            global::System.Guid userId,
            global::System.DateTime requestedAt,
            string status,
            int urlsCount,
            string? errorMessage,
            object? metadata)
        {
            this.RequestId = requestId ?? throw new global::System.ArgumentNullException(nameof(requestId));
            this.WebsiteUrl = websiteUrl ?? throw new global::System.ArgumentNullException(nameof(websiteUrl));
            this.ApiKeyId = apiKeyId;
            this.UserId = userId;
            this.RequestedAt = requestedAt;
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.UrlsCount = urlsCount;
            this.ErrorMessage = errorMessage;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SitemapRequestDB" /> class.
        /// </summary>
        public SitemapRequestDB()
        {
        }
    }
}