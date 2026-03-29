
#nullable enable

namespace ScrapeGraphAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CrawlJobRules2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exclude")]
        public global::System.Collections.Generic.IList<string>? Exclude { get; set; }

        /// <summary>
        /// List of path patterns to include (e.g., ['/products/*', '/blog/*']). If empty, all paths are included.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_paths")]
        public global::System.Collections.Generic.IList<string>? IncludePaths { get; set; }

        /// <summary>
        /// List of path patterns to exclude (e.g., ['/admin/*', '/api/*']). Takes precedence over include_paths.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exclude_paths")]
        public global::System.Collections.Generic.IList<string>? ExcludePaths { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("same_domain")]
        public bool? SameDomain { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CrawlJobRules2" /> class.
        /// </summary>
        /// <param name="exclude"></param>
        /// <param name="includePaths">
        /// List of path patterns to include (e.g., ['/products/*', '/blog/*']). If empty, all paths are included.
        /// </param>
        /// <param name="excludePaths">
        /// List of path patterns to exclude (e.g., ['/admin/*', '/api/*']). Takes precedence over include_paths.
        /// </param>
        /// <param name="sameDomain">
        /// Default Value: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CrawlJobRules2(
            global::System.Collections.Generic.IList<string>? exclude,
            global::System.Collections.Generic.IList<string>? includePaths,
            global::System.Collections.Generic.IList<string>? excludePaths,
            bool? sameDomain)
        {
            this.Exclude = exclude;
            this.IncludePaths = includePaths;
            this.ExcludePaths = excludePaths;
            this.SameDomain = sameDomain;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CrawlJobRules2" /> class.
        /// </summary>
        public CrawlJobRules2()
        {
        }
    }
}