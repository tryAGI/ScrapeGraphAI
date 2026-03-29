
#nullable enable

namespace ScrapeGraphAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum MarkdownifyStatus
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
    public static class MarkdownifyStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MarkdownifyStatus value)
        {
            return value switch
            {
                MarkdownifyStatus.Completed => "completed",
                MarkdownifyStatus.Failed => "failed",
                MarkdownifyStatus.Processing => "processing",
                MarkdownifyStatus.Queued => "queued",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MarkdownifyStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => MarkdownifyStatus.Completed,
                "failed" => MarkdownifyStatus.Failed,
                "processing" => MarkdownifyStatus.Processing,
                "queued" => MarkdownifyStatus.Queued,
                _ => null,
            };
        }
    }
}