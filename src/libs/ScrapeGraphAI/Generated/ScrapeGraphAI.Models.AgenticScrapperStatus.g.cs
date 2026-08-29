
#nullable enable

namespace ScrapeGraphAI
{
    /// <summary>
    /// Status enum for agentic scraper requests.
    /// </summary>
    public enum AgenticScrapperStatus
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
        Processedhtml,
        /// <summary>
        ///
        /// </summary>
        Processing,
        /// <summary>
        ///
        /// </summary>
        Processinghtml,
        /// <summary>
        ///
        /// </summary>
        Queued,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgenticScrapperStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgenticScrapperStatus value)
        {
            return value switch
            {
                AgenticScrapperStatus.Completed => "completed",
                AgenticScrapperStatus.Failed => "failed",
                AgenticScrapperStatus.Processedhtml => "processedhtml",
                AgenticScrapperStatus.Processing => "processing",
                AgenticScrapperStatus.Processinghtml => "processinghtml",
                AgenticScrapperStatus.Queued => "queued",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgenticScrapperStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => AgenticScrapperStatus.Completed,
                "failed" => AgenticScrapperStatus.Failed,
                "processedhtml" => AgenticScrapperStatus.Processedhtml,
                "processing" => AgenticScrapperStatus.Processing,
                "processinghtml" => AgenticScrapperStatus.Processinghtml,
                "queued" => AgenticScrapperStatus.Queued,
                _ => null,
            };
        }
    }
}