
#nullable enable

namespace ScrapeGraphAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreditsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("remaining_credits")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int RemainingCredits { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_credits_used")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalCreditsUsed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreditsResponse" /> class.
        /// </summary>
        /// <param name="remainingCredits"></param>
        /// <param name="totalCreditsUsed"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreditsResponse(
            int remainingCredits,
            int totalCreditsUsed)
        {
            this.RemainingCredits = remainingCredits;
            this.TotalCreditsUsed = totalCreditsUsed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreditsResponse" /> class.
        /// </summary>
        public CreditsResponse()
        {
        }

    }
}