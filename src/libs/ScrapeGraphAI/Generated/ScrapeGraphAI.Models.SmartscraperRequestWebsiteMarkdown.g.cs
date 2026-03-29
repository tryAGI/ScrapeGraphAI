
#nullable enable

namespace ScrapeGraphAI
{
    /// <summary>
    /// Markdown content, maximum size 2MB<br/>
    /// Example: # Title<br/>
    /// This is some content in markdown format.
    /// </summary>
    public sealed partial class SmartscraperRequestWebsiteMarkdown
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}