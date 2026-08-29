
#nullable enable

namespace ScrapeGraphAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ProductFeedback
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("feedback_id")]
        public global::System.Guid? FeedbackId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("company")]
        public string? Company { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("how_discovered")]
        public string? HowDiscovered { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage_frequency")]
        public string? UsageFrequency { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("use_cases")]
        public global::System.Collections.Generic.IList<string>? UseCases { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rating")]
        public int? Rating { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("liked_most")]
        public string? LikedMost { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disliked")]
        public string? Disliked { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requested_features")]
        public string? RequestedFeatures { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("setup_easy")]
        public bool? SetupEasy { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issues")]
        public string? Issues { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recommend_score")]
        public int? RecommendScore { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("improvement_suggestions")]
        public string? ImprovementSuggestions { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("can_contact")]
        public bool? CanContact { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contact_method")]
        public string? ContactMethod { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductFeedback" /> class.
        /// </summary>
        /// <param name="feedbackId"></param>
        /// <param name="name"></param>
        /// <param name="email"></param>
        /// <param name="company"></param>
        /// <param name="howDiscovered"></param>
        /// <param name="usageFrequency"></param>
        /// <param name="useCases"></param>
        /// <param name="rating"></param>
        /// <param name="likedMost"></param>
        /// <param name="disliked"></param>
        /// <param name="requestedFeatures"></param>
        /// <param name="setupEasy"></param>
        /// <param name="issues"></param>
        /// <param name="recommendScore"></param>
        /// <param name="improvementSuggestions"></param>
        /// <param name="canContact"></param>
        /// <param name="contactMethod"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProductFeedback(
            global::System.Guid? feedbackId,
            string? name,
            string? email,
            string? company,
            string? howDiscovered,
            string? usageFrequency,
            global::System.Collections.Generic.IList<string>? useCases,
            int? rating,
            string? likedMost,
            string? disliked,
            string? requestedFeatures,
            bool? setupEasy,
            string? issues,
            int? recommendScore,
            string? improvementSuggestions,
            bool? canContact,
            string? contactMethod)
        {
            this.FeedbackId = feedbackId;
            this.Name = name;
            this.Email = email;
            this.Company = company;
            this.HowDiscovered = howDiscovered;
            this.UsageFrequency = usageFrequency;
            this.UseCases = useCases;
            this.Rating = rating;
            this.LikedMost = likedMost;
            this.Disliked = disliked;
            this.RequestedFeatures = requestedFeatures;
            this.SetupEasy = setupEasy;
            this.Issues = issues;
            this.RecommendScore = recommendScore;
            this.ImprovementSuggestions = improvementSuggestions;
            this.CanContact = canContact;
            this.ContactMethod = contactMethod;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductFeedback" /> class.
        /// </summary>
        public ProductFeedback()
        {
        }

    }
}