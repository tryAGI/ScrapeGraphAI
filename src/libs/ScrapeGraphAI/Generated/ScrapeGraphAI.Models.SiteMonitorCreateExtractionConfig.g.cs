
#nullable enable

namespace ScrapeGraphAI
{
    /// <summary>
    /// Optional: user_prompt and output_schema for structured extraction and diff<br/>
    /// Default Value: {"user_prompt":"Extract all main content and key data as structured JSON."}
    /// </summary>
    public sealed partial class SiteMonitorCreateExtractionConfig
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}