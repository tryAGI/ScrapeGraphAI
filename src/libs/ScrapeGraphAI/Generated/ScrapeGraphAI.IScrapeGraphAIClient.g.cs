
#nullable enable

namespace ScrapeGraphAI
{
    /// <summary>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface IScrapeGraphAIClient : global::System.IDisposable
    {
        /// <summary>
        /// The HttpClient instance.
        /// </summary>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <summary>
        /// The base URL for the API.
        /// </summary>
        public System.Uri? BaseUri { get; }

        /// <summary>
        /// The authorizations to use for the requests.
        /// </summary>
        public global::System.Collections.Generic.List<global::ScrapeGraphAI.EndPointAuthorization> Authorizations { get; }

        /// <summary>
        /// Gets or sets a value indicating whether the response content should be read as a string.
        /// True by default in debug builds, false otherwise.
        /// When false, successful responses are deserialized directly from the response stream for better performance.
        /// Error responses are always read as strings regardless of this setting,
        /// ensuring <see cref="ApiException.ResponseBody"/> is populated.
        /// </summary>
        public bool ReadResponseAsString { get; set; }
        /// <summary>
        /// Client-wide request defaults such as headers, query parameters, retries, and timeout.
        /// </summary>
        public global::ScrapeGraphAI.AutoSDKClientOptions Options { get; }


        /// <summary>
        /// 
        /// </summary>
        global::System.Text.Json.Serialization.JsonSerializerContext JsonSerializerContext { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public AdminClient Admin { get; }

        /// <summary>
        /// 
        /// </summary>
        public AgenticScrapperClient AgenticScrapper { get; }

        /// <summary>
        /// 
        /// </summary>
        public CrawlerClient Crawler { get; }

        /// <summary>
        /// 
        /// </summary>
        public EndpointPocClient EndpointPoc { get; }

        /// <summary>
        /// 
        /// </summary>
        public HealthClient Health { get; }

        /// <summary>
        /// 
        /// </summary>
        public HistoryClient History { get; }

        /// <summary>
        /// 
        /// </summary>
        public MarkdownifyClient Markdownify { get; }

        /// <summary>
        /// 
        /// </summary>
        public OrthogonalClient Orthogonal { get; }

        /// <summary>
        /// 
        /// </summary>
        public ScheduledJobsClient ScheduledJobs { get; }

        /// <summary>
        /// 
        /// </summary>
        public SchemaGeneratorClient SchemaGenerator { get; }

        /// <summary>
        /// 
        /// </summary>
        public ScrapeClient Scrape { get; }

        /// <summary>
        /// 
        /// </summary>
        public SearchScraperClient SearchScraper { get; }

        /// <summary>
        /// 
        /// </summary>
        public SiteMonitorsClient SiteMonitors { get; }

        /// <summary>
        /// 
        /// </summary>
        public SitemapClient Sitemap { get; }

        /// <summary>
        /// 
        /// </summary>
        public SmartScraperClient SmartScraper { get; }

        /// <summary>
        /// 
        /// </summary>
        public ToonifyClient Toonify { get; }

        /// <summary>
        /// 
        /// </summary>
        public UsageClient Usage { get; }

        /// <summary>
        /// 
        /// </summary>
        public UserClient User { get; }

    }
}