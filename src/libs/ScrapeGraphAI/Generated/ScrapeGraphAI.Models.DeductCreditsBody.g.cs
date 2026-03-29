
#nullable enable

namespace ScrapeGraphAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeductCreditsBody
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credits_to_deduct")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CreditsToDeduct { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeductCreditsBody" /> class.
        /// </summary>
        /// <param name="creditsToDeduct"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeductCreditsBody(
            int creditsToDeduct)
        {
            this.CreditsToDeduct = creditsToDeduct;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeductCreditsBody" /> class.
        /// </summary>
        public DeductCreditsBody()
        {
        }
    }
}