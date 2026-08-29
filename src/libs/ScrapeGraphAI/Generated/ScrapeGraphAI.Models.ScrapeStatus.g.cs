
#nullable enable

namespace ScrapeGraphAI
{
    /// <summary>
    /// Status of a scrape request.
    /// </summary>
    public enum ScrapeStatus
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
    public static class ScrapeStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScrapeStatus value)
        {
            return value switch
            {
                ScrapeStatus.Completed => "completed",
                ScrapeStatus.Failed => "failed",
                ScrapeStatus.Processing => "processing",
                ScrapeStatus.Queued => "queued",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScrapeStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => ScrapeStatus.Completed,
                "failed" => ScrapeStatus.Failed,
                "processing" => ScrapeStatus.Processing,
                "queued" => ScrapeStatus.Queued,
                _ => null,
            };
        }
    }
}