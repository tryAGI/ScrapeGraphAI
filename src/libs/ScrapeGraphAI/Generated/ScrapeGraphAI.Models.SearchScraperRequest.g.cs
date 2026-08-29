
#nullable enable

namespace ScrapeGraphAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SearchScraperRequest
    {
        /// <summary>
        /// Example: What is the latest version of Python?
        /// </summary>
        /// <example>What is the latest version of Python?</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserPrompt { get; set; }

        /// <summary>
        /// Number of websites to scrape (3-20). Default is 3.<br/>
        /// Default Value: 3<br/>
        /// Example: 5
        /// </summary>
        /// <example>5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_results")]
        public int? NumResults { get; set; }

        /// <summary>
        /// Optional headers to send with the request, including cookies and user agent<br/>
        /// Example: {"Cookie":"cookie1=value1; cookie2=value2","User-Agent":"Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36"}
        /// </summary>
        /// <example>{"Cookie":"cookie1=value1; cookie2=value2","User-Agent":"Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("headers")]
        public global::System.Collections.Generic.Dictionary<string, string>? Headers { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_schema")]
        public object? OutputSchema { get; set; }

        /// <summary>
        /// True for AI extraction mode, False for markdown conversion only<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extraction_mode")]
        public bool? ExtractionMode { get; set; }

        /// <summary>
        /// True for markdown conversion mode, False for raw mode<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("markdown_mode")]
        public bool? MarkdownMode { get; set; }

        /// <summary>
        /// Enable stealth mode to avoid bot detection<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stealth")]
        public bool? Stealth { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mock")]
        public bool? Mock { get; set; }

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
        /// The geo code of the location to search in
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("location_geo_code")]
        public string? LocationGeoCode { get; set; }

        /// <summary>
        /// The date range to search in
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("time_range")]
        public global::ScrapeGraphAI.TimeRange? TimeRange { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchScraperRequest" /> class.
        /// </summary>
        /// <param name="userPrompt">
        /// Example: What is the latest version of Python?
        /// </param>
        /// <param name="numResults">
        /// Number of websites to scrape (3-20). Default is 3.<br/>
        /// Default Value: 3<br/>
        /// Example: 5
        /// </param>
        /// <param name="headers">
        /// Optional headers to send with the request, including cookies and user agent<br/>
        /// Example: {"Cookie":"cookie1=value1; cookie2=value2","User-Agent":"Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36"}
        /// </param>
        /// <param name="outputSchema"></param>
        /// <param name="extractionMode">
        /// True for AI extraction mode, False for markdown conversion only<br/>
        /// Default Value: true
        /// </param>
        /// <param name="markdownMode">
        /// True for markdown conversion mode, False for raw mode<br/>
        /// Default Value: true
        /// </param>
        /// <param name="stealth">
        /// Enable stealth mode to avoid bot detection<br/>
        /// Default Value: false
        /// </param>
        /// <param name="mock">
        /// Default Value: false
        /// </param>
        /// <param name="stream">
        /// Whether to return streaming response<br/>
        /// Default Value: false
        /// </param>
        /// <param name="webhookUrl">
        /// Webhook URL to send the job result to
        /// </param>
        /// <param name="locationGeoCode">
        /// The geo code of the location to search in
        /// </param>
        /// <param name="timeRange">
        /// The date range to search in
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchScraperRequest(
            string userPrompt,
            int? numResults,
            global::System.Collections.Generic.Dictionary<string, string>? headers,
            object? outputSchema,
            bool? extractionMode,
            bool? markdownMode,
            bool? stealth,
            bool? mock,
            bool? stream,
            string? webhookUrl,
            string? locationGeoCode,
            global::ScrapeGraphAI.TimeRange? timeRange)
        {
            this.UserPrompt = userPrompt ?? throw new global::System.ArgumentNullException(nameof(userPrompt));
            this.NumResults = numResults;
            this.Headers = headers;
            this.OutputSchema = outputSchema;
            this.ExtractionMode = extractionMode;
            this.MarkdownMode = markdownMode;
            this.Stealth = stealth;
            this.Mock = mock;
            this.Stream = stream;
            this.WebhookUrl = webhookUrl;
            this.LocationGeoCode = locationGeoCode;
            this.TimeRange = timeRange;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchScraperRequest" /> class.
        /// </summary>
        public SearchScraperRequest()
        {
        }

    }
}