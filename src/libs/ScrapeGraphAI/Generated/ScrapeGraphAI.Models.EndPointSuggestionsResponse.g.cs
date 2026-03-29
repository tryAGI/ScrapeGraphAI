
#nullable enable

namespace ScrapeGraphAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EndPointSuggestionsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("suggestions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ScrapeGraphAI.EndpointSuggestion> Suggestions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("html_with_markdowns")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object HtmlWithMarkdowns { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EndPointSuggestionsResponse" /> class.
        /// </summary>
        /// <param name="suggestions"></param>
        /// <param name="htmlWithMarkdowns"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EndPointSuggestionsResponse(
            global::System.Collections.Generic.IList<global::ScrapeGraphAI.EndpointSuggestion> suggestions,
            object htmlWithMarkdowns)
        {
            this.Suggestions = suggestions ?? throw new global::System.ArgumentNullException(nameof(suggestions));
            this.HtmlWithMarkdowns = htmlWithMarkdowns ?? throw new global::System.ArgumentNullException(nameof(htmlWithMarkdowns));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EndPointSuggestionsResponse" /> class.
        /// </summary>
        public EndPointSuggestionsResponse()
        {
        }
    }
}