
#nullable enable

namespace ScrapeGraphAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SitemapRequest
    {
        /// <summary>
        /// The URL of the website to generate a sitemap for
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("website_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WebsiteUrl { get; set; }

        /// <summary>
        /// Whether to return streaming response<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream")]
        public bool? Stream { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SitemapRequest" /> class.
        /// </summary>
        /// <param name="websiteUrl">
        /// The URL of the website to generate a sitemap for
        /// </param>
        /// <param name="stream">
        /// Whether to return streaming response<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SitemapRequest(
            string websiteUrl,
            bool? stream)
        {
            this.WebsiteUrl = websiteUrl ?? throw new global::System.ArgumentNullException(nameof(websiteUrl));
            this.Stream = stream;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SitemapRequest" /> class.
        /// </summary>
        public SitemapRequest()
        {
        }

    }
}