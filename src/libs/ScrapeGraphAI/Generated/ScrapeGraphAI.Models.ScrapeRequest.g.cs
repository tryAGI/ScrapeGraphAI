
#nullable enable

namespace ScrapeGraphAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ScrapeRequest
    {
        /// <summary>
        /// The URL of the website to scrape
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("website_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WebsiteUrl { get; set; }

        /// <summary>
        /// Whether to render heavy JS<br/>
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScrapeRequest" /> class.
        /// </summary>
        /// <param name="websiteUrl">
        /// The URL of the website to scrape
        /// </param>
        /// <param name="renderHeavyJs">
        /// Whether to render heavy JS<br/>
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ScrapeRequest(
            string websiteUrl,
            bool? renderHeavyJs,
            bool? mock,
            bool? stealth,
            bool? branding,
            bool? stream,
            string? countryCode,
            int? waitMs)
        {
            this.WebsiteUrl = websiteUrl ?? throw new global::System.ArgumentNullException(nameof(websiteUrl));
            this.RenderHeavyJs = renderHeavyJs;
            this.Mock = mock;
            this.Stealth = stealth;
            this.Branding = branding;
            this.Stream = stream;
            this.CountryCode = countryCode;
            this.WaitMs = waitMs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScrapeRequest" /> class.
        /// </summary>
        public ScrapeRequest()
        {
        }

    }
}