
#nullable enable

namespace ScrapeGraphAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class QueryRedisCacheByPatternRequest
    {
        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cursor")]
        public int? Cursor { get; set; }

        /// <summary>
        /// Default Value: 100
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page_size")]
        public int? PageSize { get; set; }

        /// <summary>
        /// Default Value: providers_order:*
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pattern")]
        public string? Pattern { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryRedisCacheByPatternRequest" /> class.
        /// </summary>
        /// <param name="cursor">
        /// Default Value: 0
        /// </param>
        /// <param name="pageSize">
        /// Default Value: 100
        /// </param>
        /// <param name="pattern">
        /// Default Value: providers_order:*
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QueryRedisCacheByPatternRequest(
            int? cursor,
            int? pageSize,
            string? pattern)
        {
            this.Cursor = cursor;
            this.PageSize = pageSize;
            this.Pattern = pattern;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryRedisCacheByPatternRequest" /> class.
        /// </summary>
        public QueryRedisCacheByPatternRequest()
        {
        }
    }
}