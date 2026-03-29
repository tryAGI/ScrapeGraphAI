
#nullable enable

namespace ScrapeGraphAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum CrawlStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Processing,
        /// <summary>
        /// 
        /// </summary>
        Queued,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CrawlStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CrawlStatus value)
        {
            return value switch
            {
                CrawlStatus.Completed => "completed",
                CrawlStatus.Failed => "failed",
                CrawlStatus.Processing => "processing",
                CrawlStatus.Queued => "queued",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CrawlStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => CrawlStatus.Completed,
                "failed" => CrawlStatus.Failed,
                "processing" => CrawlStatus.Processing,
                "queued" => CrawlStatus.Queued,
                _ => null,
            };
        }
    }
}