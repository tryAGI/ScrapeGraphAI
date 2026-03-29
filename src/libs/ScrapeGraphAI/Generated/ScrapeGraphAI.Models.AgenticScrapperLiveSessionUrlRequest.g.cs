
#nullable enable

namespace ScrapeGraphAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgenticScrapperLiveSessionUrlRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Timeout for the live session<br/>
        /// Default Value: 300
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeout")]
        public int? Timeout { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgenticScrapperLiveSessionUrlRequest" /> class.
        /// </summary>
        /// <param name="url"></param>
        /// <param name="timeout">
        /// Timeout for the live session<br/>
        /// Default Value: 300
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgenticScrapperLiveSessionUrlRequest(
            string url,
            int? timeout)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Timeout = timeout;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgenticScrapperLiveSessionUrlRequest" /> class.
        /// </summary>
        public AgenticScrapperLiveSessionUrlRequest()
        {
        }
    }
}