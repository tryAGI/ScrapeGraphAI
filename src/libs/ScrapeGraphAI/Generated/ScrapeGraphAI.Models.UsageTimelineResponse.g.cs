
#nullable enable

namespace ScrapeGraphAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UsageTimelineResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeline")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ScrapeGraphAI.TimelineEntry> Timeline { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageTimelineResponse" /> class.
        /// </summary>
        /// <param name="timeline"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UsageTimelineResponse(
            global::System.Collections.Generic.IList<global::ScrapeGraphAI.TimelineEntry> timeline)
        {
            this.Timeline = timeline ?? throw new global::System.ArgumentNullException(nameof(timeline));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageTimelineResponse" /> class.
        /// </summary>
        public UsageTimelineResponse()
        {
        }

    }
}