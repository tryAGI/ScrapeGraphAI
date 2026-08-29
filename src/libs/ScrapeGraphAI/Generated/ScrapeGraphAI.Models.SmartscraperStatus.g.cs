
#nullable enable

namespace ScrapeGraphAI
{
    /// <summary>
    ///
    /// </summary>
    public enum SmartscraperStatus
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
    public static class SmartscraperStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SmartscraperStatus value)
        {
            return value switch
            {
                SmartscraperStatus.Completed => "completed",
                SmartscraperStatus.Failed => "failed",
                SmartscraperStatus.Processing => "processing",
                SmartscraperStatus.Queued => "queued",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SmartscraperStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => SmartscraperStatus.Completed,
                "failed" => SmartscraperStatus.Failed,
                "processing" => SmartscraperStatus.Processing,
                "queued" => SmartscraperStatus.Queued,
                _ => null,
            };
        }
    }
}