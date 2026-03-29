
#nullable enable

namespace ScrapeGraphAI
{
    /// <summary>
    /// HTML content, maximum size 2MB<br/>
    /// Example: &lt;html&gt;&lt;body&gt;&lt;h1&gt;Title&lt;/h1&gt;&lt;p&gt;Content&lt;/p&gt;&lt;/body&gt;&lt;/html&gt;
    /// </summary>
    public sealed partial class SmartscraperRequestWebsiteHtml
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}