
#nullable enable

namespace ScrapeGraphAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AgenticScrapperRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_prompt")]
        public string? UserPrompt { get; set; }

        /// <summary>
        /// Default Value: {}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_schema")]
        public object? OutputSchema { get; set; }

        /// <summary>
        /// List of steps to actions to perform on the website<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("steps")]
        public global::System.Collections.Generic.IList<string>? Steps { get; set; }

        /// <summary>
        /// Whether to use a session to scrape the website<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("use_session")]
        public bool? UseSession { get; set; }

        /// <summary>
        /// Whether to use AI extraction to extract the information<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ai_extraction")]
        public bool? AiExtraction { get; set; }

        /// <summary>
        /// Whether to return streaming response<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream")]
        public bool? Stream { get; set; }

        /// <summary>
        /// Webhook URL to send the job result to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_url")]
        public string? WebhookUrl { get; set; }

        /// <summary>
        /// The country code to use for the scrape (e.g. US, GB)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("country_code")]
        public string? CountryCode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgenticScrapperRequest" /> class.
        /// </summary>
        /// <param name="url"></param>
        /// <param name="userPrompt"></param>
        /// <param name="outputSchema">
        /// Default Value: {}
        /// </param>
        /// <param name="steps">
        /// List of steps to actions to perform on the website<br/>
        /// Default Value: []
        /// </param>
        /// <param name="useSession">
        /// Whether to use a session to scrape the website<br/>
        /// Default Value: false
        /// </param>
        /// <param name="aiExtraction">
        /// Whether to use AI extraction to extract the information<br/>
        /// Default Value: false
        /// </param>
        /// <param name="stream">
        /// Whether to return streaming response<br/>
        /// Default Value: false
        /// </param>
        /// <param name="webhookUrl">
        /// Webhook URL to send the job result to
        /// </param>
        /// <param name="countryCode">
        /// The country code to use for the scrape (e.g. US, GB)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgenticScrapperRequest(
            string url,
            string? userPrompt,
            object? outputSchema,
            global::System.Collections.Generic.IList<string>? steps,
            bool? useSession,
            bool? aiExtraction,
            bool? stream,
            string? webhookUrl,
            string? countryCode)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.UserPrompt = userPrompt;
            this.OutputSchema = outputSchema;
            this.Steps = steps;
            this.UseSession = useSession;
            this.AiExtraction = aiExtraction;
            this.Stream = stream;
            this.WebhookUrl = webhookUrl;
            this.CountryCode = countryCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgenticScrapperRequest" /> class.
        /// </summary>
        public AgenticScrapperRequest()
        {
        }

    }
}