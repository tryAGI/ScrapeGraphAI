
#nullable enable

namespace ScrapeGraphAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MarkdownifyRequest
    {
        /// <summary>
        /// The URL of the website to scrape
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("website_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WebsiteUrl { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("render_heavy_js")]
        public bool? RenderHeavyJs { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mock")]
        public bool? Mock { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stealth")]
        public bool? Stealth { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("branding")]
        public bool? Branding { get; set; }

        /// <summary>
        /// Whether to return streaming response<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream")]
        public bool? Stream { get; set; }

        /// <summary>
        /// The country code to use for the scrape
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("country_code")]
        public string? CountryCode { get; set; }

        /// <summary>
        /// The number of milliseconds to wait before scraping the website<br/>
        /// Default Value: 3000
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("wait_ms")]
        public int? WaitMs { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("steps")]
        public global::System.Collections.Generic.IList<string>? Steps { get; set; }

        /// <summary>
        /// Webhook URL to send the job result to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_url")]
        public string? WebhookUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MarkdownifyRequest" /> class.
        /// </summary>
        /// <param name="websiteUrl">
        /// The URL of the website to scrape
        /// </param>
        /// <param name="renderHeavyJs">
        /// Default Value: false
        /// </param>
        /// <param name="mock">
        /// Default Value: false
        /// </param>
        /// <param name="stealth">
        /// Default Value: false
        /// </param>
        /// <param name="branding">
        /// Default Value: false
        /// </param>
        /// <param name="stream">
        /// Whether to return streaming response<br/>
        /// Default Value: false
        /// </param>
        /// <param name="countryCode">
        /// The country code to use for the scrape
        /// </param>
        /// <param name="waitMs">
        /// The number of milliseconds to wait before scraping the website<br/>
        /// Default Value: 3000
        /// </param>
        /// <param name="headers">
        /// Optional headers to send with the request, including cookies and user agent<br/>
        /// Example: {"Cookie":"cookie1=value1; cookie2=value2","User-Agent":"Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36"}
        /// </param>
        /// <param name="steps"></param>
        /// <param name="webhookUrl">
        /// Webhook URL to send the job result to
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MarkdownifyRequest(
            string websiteUrl,
            bool? renderHeavyJs,
            bool? mock,
            bool? stealth,
            bool? branding,
            bool? stream,
            string? countryCode,
            int? waitMs,
            global::System.Collections.Generic.Dictionary<string, string>? headers,
            global::System.Collections.Generic.IList<string>? steps,
            string? webhookUrl)
        {
            this.WebsiteUrl = websiteUrl ?? throw new global::System.ArgumentNullException(nameof(websiteUrl));
            this.RenderHeavyJs = renderHeavyJs;
            this.Mock = mock;
            this.Stealth = stealth;
            this.Branding = branding;
            this.Stream = stream;
            this.CountryCode = countryCode;
            this.WaitMs = waitMs;
            this.Headers = headers;
            this.Steps = steps;
            this.WebhookUrl = webhookUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MarkdownifyRequest" /> class.
        /// </summary>
        public MarkdownifyRequest()
        {
        }

    }
}