
#nullable enable

namespace ScrapeGraphAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgenticScrapperLiveSessionUrlResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SessionUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SessionId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgenticScrapperLiveSessionUrlResponse" /> class.
        /// </summary>
        /// <param name="sessionUrl"></param>
        /// <param name="sessionId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgenticScrapperLiveSessionUrlResponse(
            string sessionUrl,
            string sessionId)
        {
            this.SessionUrl = sessionUrl ?? throw new global::System.ArgumentNullException(nameof(sessionUrl));
            this.SessionId = sessionId ?? throw new global::System.ArgumentNullException(nameof(sessionId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgenticScrapperLiveSessionUrlResponse" /> class.
        /// </summary>
        public AgenticScrapperLiveSessionUrlResponse()
        {
        }
    }
}