
#nullable enable

namespace ScrapeGraphAI
{
    /// <summary>
    /// DynamoDB model for crawler requests
    /// </summary>
    public sealed partial class CrawlerRequestDB
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
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid UserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_pages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxPages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ScrapeGraphAI.JsonConverters.CrawlStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ScrapeGraphAI.CrawlStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requested_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime RequestedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finished_at")]
        public global::System.DateTime? FinishedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_cost")]
        public double? TotalCost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credits_used")]
        public int? CreditsUsed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pages_processed")]
        public int? PagesProcessed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("crawled_urls")]
        public global::System.Collections.Generic.IList<string>? CrawledUrls { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task_id")]
        public string? TaskId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        public object? Result { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result_url")]
        public string? ResultUrl { get; set; }

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
        /// Initializes a new instance of the <see cref="CrawlerRequestDB" /> class.
        /// </summary>
        /// <param name="requestId"></param>
        /// <param name="userId"></param>
        /// <param name="url"></param>
        /// <param name="maxPages"></param>
        /// <param name="status"></param>
        /// <param name="requestedAt"></param>
        /// <param name="prompt"></param>
        /// <param name="error"></param>
        /// <param name="metadata"></param>
        /// <param name="finishedAt"></param>
        /// <param name="totalCost"></param>
        /// <param name="creditsUsed"></param>
        /// <param name="pagesProcessed"></param>
        /// <param name="crawledUrls"></param>
        /// <param name="taskId"></param>
        /// <param name="result"></param>
        /// <param name="resultUrl"></param>
        /// <param name="requestParams"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CrawlerRequestDB(
            global::System.Guid requestId,
            global::System.Guid userId,
            string url,
            int maxPages,
            global::ScrapeGraphAI.CrawlStatus status,
            global::System.DateTime requestedAt,
            string? prompt,
            string? error,
            object? metadata,
            global::System.DateTime? finishedAt,
            double? totalCost,
            int? creditsUsed,
            int? pagesProcessed,
            global::System.Collections.Generic.IList<string>? crawledUrls,
            string? taskId,
            object? result,
            string? resultUrl,
            object? requestParams)
        {
            this.RequestId = requestId;
            this.UserId = userId;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Prompt = prompt;
            this.MaxPages = maxPages;
            this.Status = status;
            this.Error = error;
            this.Metadata = metadata;
            this.RequestedAt = requestedAt;
            this.FinishedAt = finishedAt;
            this.TotalCost = totalCost;
            this.CreditsUsed = creditsUsed;
            this.PagesProcessed = pagesProcessed;
            this.CrawledUrls = crawledUrls;
            this.TaskId = taskId;
            this.Result = result;
            this.ResultUrl = resultUrl;
            this.RequestParams = requestParams;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CrawlerRequestDB" /> class.
        /// </summary>
        public CrawlerRequestDB()
        {
        }
    }
}