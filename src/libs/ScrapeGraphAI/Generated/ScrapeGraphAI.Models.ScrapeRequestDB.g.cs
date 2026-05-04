
#nullable enable

namespace ScrapeGraphAI
{
    /// <summary>
    /// DynamoDB model for scrape requests.
    /// </summary>
    public sealed partial class ScrapeRequestDB
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid RequestId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        public global::System.Guid? UserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("website_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WebsiteUrl { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("render_heavy_js")]
        public bool? RenderHeavyJs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        public string? Result { get; set; }

        /// <summary>
        /// Status of a scrape request.<br/>
        /// Default Value: queued
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ScrapeGraphAI.JsonConverters.ScrapeStatusJsonConverter))]
        public global::ScrapeGraphAI.ScrapeStatus? Status { get; set; }

        /// <summary>
        /// Default Value: {}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finished_at")]
        public global::System.DateTime? FinishedAt { get; set; }

        /// <summary>
        /// Default Value: 2026-04-21T20:25:14.846158
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requested_at")]
        public global::System.DateTime? RequestedAt { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost")]
        public int? Cost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_params")]
        public object? RequestParams { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScrapeRequestDB" /> class.
        /// </summary>
        /// <param name="requestId"></param>
        /// <param name="websiteUrl"></param>
        /// <param name="userId"></param>
        /// <param name="renderHeavyJs">
        /// Default Value: false
        /// </param>
        /// <param name="result"></param>
        /// <param name="status">
        /// Status of a scrape request.<br/>
        /// Default Value: queued
        /// </param>
        /// <param name="metadata">
        /// Default Value: {}
        /// </param>
        /// <param name="error"></param>
        /// <param name="finishedAt"></param>
        /// <param name="requestedAt">
        /// Default Value: 2026-04-21T20:25:14.846158
        /// </param>
        /// <param name="cost">
        /// Default Value: 0
        /// </param>
        /// <param name="requestParams"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ScrapeRequestDB(
            global::System.Guid requestId,
            string websiteUrl,
            global::System.Guid? userId,
            bool? renderHeavyJs,
            string? result,
            global::ScrapeGraphAI.ScrapeStatus? status,
            object? metadata,
            string? error,
            global::System.DateTime? finishedAt,
            global::System.DateTime? requestedAt,
            int? cost,
            object? requestParams)
        {
            this.RequestId = requestId;
            this.UserId = userId;
            this.WebsiteUrl = websiteUrl ?? throw new global::System.ArgumentNullException(nameof(websiteUrl));
            this.RenderHeavyJs = renderHeavyJs;
            this.Result = result;
            this.Status = status;
            this.Metadata = metadata;
            this.Error = error;
            this.FinishedAt = finishedAt;
            this.RequestedAt = requestedAt;
            this.Cost = cost;
            this.RequestParams = requestParams;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScrapeRequestDB" /> class.
        /// </summary>
        public ScrapeRequestDB()
        {
        }
    }
}