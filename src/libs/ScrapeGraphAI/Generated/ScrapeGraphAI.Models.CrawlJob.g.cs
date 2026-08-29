
#nullable enable

namespace ScrapeGraphAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CrawlJob
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("depth")]
        public int? Depth { get; set; }

        /// <summary>
        /// Maximum number of links to crawl per depth level. If None, unlimited (default). Ignored when sitemap=True.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("breadth")]
        public int? Breadth { get; set; }

        /// <summary>
        /// Default Value: 10
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_pages")]
        public int? MaxPages { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schema")]
        public object? Schema { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rules")]
        public global::ScrapeGraphAI.CrawlJobRules2? Rules { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sitemap")]
        public bool? Sitemap { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("render_heavy_js")]
        public bool? RenderHeavyJs { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extraction_mode")]
        public bool? ExtractionMode { get; set; }

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
        /// Webhook URL to send the job result to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_url")]
        public string? WebhookUrl { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reader_mode")]
        public bool? ReaderMode { get; set; }

        /// <summary>
        /// Default Value: 3000
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("wait_ms")]
        public int? WaitMs { get; set; }

        /// <summary>
        /// The country code to use for fetching (e.g. US, GB)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("country_code")]
        public string? CountryCode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CrawlJob" /> class.
        /// </summary>
        /// <param name="url"></param>
        /// <param name="depth">
        /// Default Value: 1
        /// </param>
        /// <param name="breadth">
        /// Maximum number of links to crawl per depth level. If None, unlimited (default). Ignored when sitemap=True.
        /// </param>
        /// <param name="maxPages">
        /// Default Value: 10
        /// </param>
        /// <param name="prompt"></param>
        /// <param name="schema"></param>
        /// <param name="rules"></param>
        /// <param name="sitemap">
        /// Default Value: true
        /// </param>
        /// <param name="renderHeavyJs">
        /// Default Value: false
        /// </param>
        /// <param name="extractionMode">
        /// Default Value: true
        /// </param>
        /// <param name="stealth">
        /// Enable stealth mode to avoid bot detection<br/>
        /// Default Value: false
        /// </param>
        /// <param name="mock">
        /// Default Value: false
        /// </param>
        /// <param name="webhookUrl">
        /// Webhook URL to send the job result to
        /// </param>
        /// <param name="readerMode">
        /// Default Value: false
        /// </param>
        /// <param name="waitMs">
        /// Default Value: 3000
        /// </param>
        /// <param name="countryCode">
        /// The country code to use for fetching (e.g. US, GB)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CrawlJob(
            string url,
            int? depth,
            int? breadth,
            int? maxPages,
            string? prompt,
            object? schema,
            global::ScrapeGraphAI.CrawlJobRules2? rules,
            bool? sitemap,
            bool? renderHeavyJs,
            bool? extractionMode,
            bool? stealth,
            bool? mock,
            string? webhookUrl,
            bool? readerMode,
            int? waitMs,
            string? countryCode)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Depth = depth;
            this.Breadth = breadth;
            this.MaxPages = maxPages;
            this.Prompt = prompt;
            this.Schema = schema;
            this.Rules = rules;
            this.Sitemap = sitemap;
            this.RenderHeavyJs = renderHeavyJs;
            this.ExtractionMode = extractionMode;
            this.Stealth = stealth;
            this.Mock = mock;
            this.WebhookUrl = webhookUrl;
            this.ReaderMode = readerMode;
            this.WaitMs = waitMs;
            this.CountryCode = countryCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CrawlJob" /> class.
        /// </summary>
        public CrawlJob()
        {
        }

    }
}