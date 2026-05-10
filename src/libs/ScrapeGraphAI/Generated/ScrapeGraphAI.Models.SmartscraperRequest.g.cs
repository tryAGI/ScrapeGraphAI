
#nullable enable

namespace ScrapeGraphAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SmartscraperRequest
    {
        /// <summary>
        /// The URL of the website to scrape (optional for Smartscraper)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("website_url")]
        public string? WebsiteUrl { get; set; }

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
        /// Example: Extract info about the company
        /// </summary>
        /// <example>Extract info about the company</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserPrompt { get; set; }

        /// <summary>
        /// HTML content, maximum size 2MB<br/>
        /// Example: &lt;html&gt;&lt;body&gt;&lt;h1&gt;Title&lt;/h1&gt;&lt;p&gt;Content&lt;/p&gt;&lt;/body&gt;&lt;/html&gt;
        /// </summary>
        /// <example>&lt;html&gt;&lt;body&gt;&lt;h1&gt;Title&lt;/h1&gt;&lt;p&gt;Content&lt;/p&gt;&lt;/body&gt;&lt;/html&gt;</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("website_html")]
        public string? WebsiteHtml { get; set; }

        /// <summary>
        /// Markdown content, maximum size 2MB<br/>
        /// Example: # Title<br/>
        /// This is some content in markdown format.
        /// </summary>
        /// <example>
        /// # Title<br/>
        /// This is some content in markdown format.
        /// </example>
        [global::System.Text.Json.Serialization.JsonPropertyName("website_markdown")]
        public string? WebsiteMarkdown { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_schema")]
        public object? OutputSchema { get; set; }

        /// <summary>
        /// Optional headers to send with the request, including cookies and user agent<br/>
        /// Example: {"Cookie":"cookie1=value1; cookie2=value2","User-Agent":"Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36"}
        /// </summary>
        /// <example>{"Cookie":"cookie1=value1; cookie2=value2","User-Agent":"Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("headers")]
        public global::System.Collections.Generic.Dictionary<string, string>? Headers { get; set; }

        /// <summary>
        /// Number of scroll operations to perform for infinite scrolling (0 = disabled, range: 1-100). Values between 1-9 will be automatically set to 10.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("number_of_scrolls")]
        public int? NumberOfScrolls { get; set; }

        /// <summary>
        /// Total number of pages to scrape if pagination enabled<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_pages")]
        public int? TotalPages { get; set; }

        /// <summary>
        /// List of steps to actions to perform on the website
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("steps")]
        public global::System.Collections.Generic.IList<string>? Steps { get; set; }

        /// <summary>
        /// Cookies to send with the request<br/>
        /// Default Value: {}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cookies")]
        public global::System.Collections.Generic.Dictionary<string, string>? Cookies { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("plain_text")]
        public bool? PlainText { get; set; }

        /// <summary>
        /// Webhook URL to send the job result to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_url")]
        public string? WebhookUrl { get; set; }

        /// <summary>
        /// Offset to start scraping from<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("offset")]
        public int? Offset { get; set; }

        /// <summary>
        /// Whether this is a multi-page child request<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_multipage_child")]
        public bool? IsMultipageChild { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SmartscraperRequest" /> class.
        /// </summary>
        /// <param name="userPrompt">
        /// Example: Extract info about the company
        /// </param>
        /// <param name="websiteUrl">
        /// The URL of the website to scrape (optional for Smartscraper)
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
        /// <param name="websiteHtml">
        /// HTML content, maximum size 2MB<br/>
        /// Example: &lt;html&gt;&lt;body&gt;&lt;h1&gt;Title&lt;/h1&gt;&lt;p&gt;Content&lt;/p&gt;&lt;/body&gt;&lt;/html&gt;
        /// </param>
        /// <param name="websiteMarkdown">
        /// Markdown content, maximum size 2MB<br/>
        /// Example: # Title<br/>
        /// This is some content in markdown format.
        /// </param>
        /// <param name="outputSchema"></param>
        /// <param name="headers">
        /// Optional headers to send with the request, including cookies and user agent<br/>
        /// Example: {"Cookie":"cookie1=value1; cookie2=value2","User-Agent":"Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36"}
        /// </param>
        /// <param name="numberOfScrolls">
        /// Number of scroll operations to perform for infinite scrolling (0 = disabled, range: 1-100). Values between 1-9 will be automatically set to 10.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="totalPages">
        /// Total number of pages to scrape if pagination enabled<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="steps">
        /// List of steps to actions to perform on the website
        /// </param>
        /// <param name="cookies">
        /// Cookies to send with the request<br/>
        /// Default Value: {}
        /// </param>
        /// <param name="plainText">
        /// Default Value: false
        /// </param>
        /// <param name="webhookUrl">
        /// Webhook URL to send the job result to
        /// </param>
        /// <param name="offset">
        /// Offset to start scraping from<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="isMultipageChild">
        /// Whether this is a multi-page child request<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SmartscraperRequest(
            string userPrompt,
            string? websiteUrl,
            bool? renderHeavyJs,
            bool? mock,
            bool? stealth,
            bool? branding,
            bool? stream,
            string? countryCode,
            int? waitMs,
            string? websiteHtml,
            string? websiteMarkdown,
            object? outputSchema,
            global::System.Collections.Generic.Dictionary<string, string>? headers,
            int? numberOfScrolls,
            int? totalPages,
            global::System.Collections.Generic.IList<string>? steps,
            global::System.Collections.Generic.Dictionary<string, string>? cookies,
            bool? plainText,
            string? webhookUrl,
            int? offset,
            bool? isMultipageChild)
        {
            this.WebsiteUrl = websiteUrl;
            this.RenderHeavyJs = renderHeavyJs;
            this.Mock = mock;
            this.Stealth = stealth;
            this.Branding = branding;
            this.Stream = stream;
            this.CountryCode = countryCode;
            this.WaitMs = waitMs;
            this.UserPrompt = userPrompt ?? throw new global::System.ArgumentNullException(nameof(userPrompt));
            this.WebsiteHtml = websiteHtml;
            this.WebsiteMarkdown = websiteMarkdown;
            this.OutputSchema = outputSchema;
            this.Headers = headers;
            this.NumberOfScrolls = numberOfScrolls;
            this.TotalPages = totalPages;
            this.Steps = steps;
            this.Cookies = cookies;
            this.PlainText = plainText;
            this.WebhookUrl = webhookUrl;
            this.Offset = offset;
            this.IsMultipageChild = isMultipageChild;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SmartscraperRequest" /> class.
        /// </summary>
        public SmartscraperRequest()
        {
        }

    }
}