
#nullable enable

namespace ScrapeGraphAI
{
    /// <summary>
    /// Maximum number of links to crawl per depth level. If None, unlimited (default). Ignored when sitemap=True.
    /// </summary>
    public sealed partial class CrawlJobBreadth
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}