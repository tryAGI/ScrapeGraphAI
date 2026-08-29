
#nullable enable

namespace ScrapeGraphAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SmartscraperHistoryResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requests")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ScrapeGraphAI.SmartscraperRequestDB> Requests { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_key")]
        public object? NextKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SmartscraperHistoryResponse" /> class.
        /// </summary>
        /// <param name="requests"></param>
        /// <param name="nextKey"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SmartscraperHistoryResponse(
            global::System.Collections.Generic.IList<global::ScrapeGraphAI.SmartscraperRequestDB> requests,
            object? nextKey)
        {
            this.Requests = requests ?? throw new global::System.ArgumentNullException(nameof(requests));
            this.NextKey = nextKey;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SmartscraperHistoryResponse" /> class.
        /// </summary>
        public SmartscraperHistoryResponse()
        {
        }

    }
}