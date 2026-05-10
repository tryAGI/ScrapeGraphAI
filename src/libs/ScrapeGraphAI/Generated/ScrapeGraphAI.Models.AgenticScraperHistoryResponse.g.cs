
#nullable enable

namespace ScrapeGraphAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgenticScraperHistoryResponse
    {
        /// <summary>
        /// List of agentic scraper requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requests")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ScrapeGraphAI.AgenticScraperRequestDB> Requests { get; set; }

        /// <summary>
        /// Key for next page
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_key")]
        public object? NextKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgenticScraperHistoryResponse" /> class.
        /// </summary>
        /// <param name="requests">
        /// List of agentic scraper requests
        /// </param>
        /// <param name="nextKey">
        /// Key for next page
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgenticScraperHistoryResponse(
            global::System.Collections.Generic.IList<global::ScrapeGraphAI.AgenticScraperRequestDB> requests,
            object? nextKey)
        {
            this.Requests = requests ?? throw new global::System.ArgumentNullException(nameof(requests));
            this.NextKey = nextKey;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgenticScraperHistoryResponse" /> class.
        /// </summary>
        public AgenticScraperHistoryResponse()
        {
        }

    }
}