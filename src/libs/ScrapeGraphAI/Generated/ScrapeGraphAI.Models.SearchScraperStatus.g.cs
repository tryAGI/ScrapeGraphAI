
#nullable enable

namespace ScrapeGraphAI
{
    /// <summary>
    ///
    /// </summary>
    public enum SearchScraperStatus
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
    public static class SearchScraperStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchScraperStatus value)
        {
            return value switch
            {
                SearchScraperStatus.Completed => "completed",
                SearchScraperStatus.Failed => "failed",
                SearchScraperStatus.Processing => "processing",
                SearchScraperStatus.Queued => "queued",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchScraperStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => SearchScraperStatus.Completed,
                "failed" => SearchScraperStatus.Failed,
                "processing" => SearchScraperStatus.Processing,
                "queued" => SearchScraperStatus.Queued,
                _ => null,
            };
        }
    }
}