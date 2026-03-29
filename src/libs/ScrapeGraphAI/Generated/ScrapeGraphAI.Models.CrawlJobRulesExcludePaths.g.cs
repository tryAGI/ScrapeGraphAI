
#nullable enable

namespace ScrapeGraphAI
{
    /// <summary>
    /// List of path patterns to exclude (e.g., ['/admin/*', '/api/*']). Takes precedence over include_paths.
    /// </summary>
    public sealed partial class CrawlJobRulesExcludePaths
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}