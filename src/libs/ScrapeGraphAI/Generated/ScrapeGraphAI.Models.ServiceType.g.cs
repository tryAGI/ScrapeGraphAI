
#nullable enable

namespace ScrapeGraphAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum ServiceType
    {
        /// <summary>
        /// 
        /// </summary>
        Agenticscrapper,
        /// <summary>
        /// 
        /// </summary>
        Markdownify,
        /// <summary>
        /// 
        /// </summary>
        Searchscraper,
        /// <summary>
        /// 
        /// </summary>
        SiteMonitor,
        /// <summary>
        /// 
        /// </summary>
        Smartcrawler,
        /// <summary>
        /// 
        /// </summary>
        Smartscraper,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ServiceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServiceType value)
        {
            return value switch
            {
                ServiceType.Agenticscrapper => "agenticscrapper",
                ServiceType.Markdownify => "markdownify",
                ServiceType.Searchscraper => "searchscraper",
                ServiceType.SiteMonitor => "site_monitor",
                ServiceType.Smartcrawler => "smartcrawler",
                ServiceType.Smartscraper => "smartscraper",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServiceType? ToEnum(string value)
        {
            return value switch
            {
                "agenticscrapper" => ServiceType.Agenticscrapper,
                "markdownify" => ServiceType.Markdownify,
                "searchscraper" => ServiceType.Searchscraper,
                "site_monitor" => ServiceType.SiteMonitor,
                "smartcrawler" => ServiceType.Smartcrawler,
                "smartscraper" => ServiceType.Smartscraper,
                _ => null,
            };
        }
    }
}