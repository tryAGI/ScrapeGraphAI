
#nullable enable

namespace ScrapeGraphAI
{
    /// <summary>
    /// Paginated response for scheduled jobs
    /// </summary>
    public sealed partial class ScheduledJobListResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Total { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Page { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page_size")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PageSize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("jobs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ScrapeGraphAI.ScheduledJobResponse> Jobs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduledJobListResponse" /> class.
        /// </summary>
        /// <param name="total"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="jobs"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ScheduledJobListResponse(
            int total,
            int page,
            int pageSize,
            global::System.Collections.Generic.IList<global::ScrapeGraphAI.ScheduledJobResponse> jobs)
        {
            this.Total = total;
            this.Page = page;
            this.PageSize = pageSize;
            this.Jobs = jobs ?? throw new global::System.ArgumentNullException(nameof(jobs));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduledJobListResponse" /> class.
        /// </summary>
        public ScheduledJobListResponse()
        {
        }

    }
}