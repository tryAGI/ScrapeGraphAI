
#nullable enable

namespace ScrapeGraphAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum MarkdownifyRequestStatus
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
    public static class MarkdownifyRequestStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MarkdownifyRequestStatus value)
        {
            return value switch
            {
                MarkdownifyRequestStatus.Completed => "completed",
                MarkdownifyRequestStatus.Failed => "failed",
                MarkdownifyRequestStatus.Processing => "processing",
                MarkdownifyRequestStatus.Queued => "queued",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MarkdownifyRequestStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => MarkdownifyRequestStatus.Completed,
                "failed" => MarkdownifyRequestStatus.Failed,
                "processing" => MarkdownifyRequestStatus.Processing,
                "queued" => MarkdownifyRequestStatus.Queued,
                _ => null,
            };
        }
    }
}