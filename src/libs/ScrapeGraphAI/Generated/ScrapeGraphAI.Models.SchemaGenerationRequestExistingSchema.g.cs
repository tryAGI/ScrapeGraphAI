
#nullable enable

namespace ScrapeGraphAI
{
    /// <summary>
    /// Optional existing JSON schema to modify/extend
    /// </summary>
    public sealed partial class SchemaGenerationRequestExistingSchema
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}