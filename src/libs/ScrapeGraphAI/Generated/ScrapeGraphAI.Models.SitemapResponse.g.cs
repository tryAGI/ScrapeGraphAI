
#nullable enable

namespace ScrapeGraphAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SitemapResponse
    {
        /// <summary>
        /// The URLs found in the sitemap
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("urls")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Urls { get; set; }

        /// <summary>
        /// The ID of the sitemap request for tracking
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RequestId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SitemapResponse" /> class.
        /// </summary>
        /// <param name="urls">
        /// The URLs found in the sitemap
        /// </param>
        /// <param name="requestId">
        /// The ID of the sitemap request for tracking
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SitemapResponse(
            global::System.Collections.Generic.IList<string> urls,
            string requestId)
        {
            this.Urls = urls ?? throw new global::System.ArgumentNullException(nameof(urls));
            this.RequestId = requestId ?? throw new global::System.ArgumentNullException(nameof(requestId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SitemapResponse" /> class.
        /// </summary>
        public SitemapResponse()
        {
        }

    }
}