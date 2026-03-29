
#nullable enable

namespace ScrapeGraphAI
{
    /// <summary>
    /// Paginated response for job executions
    /// </summary>
    public sealed partial class JobExecutionListResponse
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
        [global::System.Text.Json.Serialization.JsonPropertyName("executions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ScrapeGraphAI.JobExecutionResponse> Executions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="JobExecutionListResponse" /> class.
        /// </summary>
        /// <param name="total"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="executions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public JobExecutionListResponse(
            int total,
            int page,
            int pageSize,
            global::System.Collections.Generic.IList<global::ScrapeGraphAI.JobExecutionResponse> executions)
        {
            this.Total = total;
            this.Page = page;
            this.PageSize = pageSize;
            this.Executions = executions ?? throw new global::System.ArgumentNullException(nameof(executions));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JobExecutionListResponse" /> class.
        /// </summary>
        public JobExecutionListResponse()
        {
        }
    }
}