
#nullable enable

namespace ScrapeGraphAI
{
    /// <summary>
    ///
    /// </summary>
    public enum GetUsageTimelineV1UsageTimelineGetDays
    {
        /// <summary>
        ///
        /// </summary>
        x14,
        /// <summary>
        ///
        /// </summary>
        x30,
        /// <summary>
        ///
        /// </summary>
        x7,
        /// <summary>
        ///
        /// </summary>
        All,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetUsageTimelineV1UsageTimelineGetDaysExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetUsageTimelineV1UsageTimelineGetDays value)
        {
            return value switch
            {
                GetUsageTimelineV1UsageTimelineGetDays.x14 => "14",
                GetUsageTimelineV1UsageTimelineGetDays.x30 => "30",
                GetUsageTimelineV1UsageTimelineGetDays.x7 => "7",
                GetUsageTimelineV1UsageTimelineGetDays.All => "all",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetUsageTimelineV1UsageTimelineGetDays? ToEnum(string value)
        {
            return value switch
            {
                "14" => GetUsageTimelineV1UsageTimelineGetDays.x14,
                "30" => GetUsageTimelineV1UsageTimelineGetDays.x30,
                "7" => GetUsageTimelineV1UsageTimelineGetDays.x7,
                "all" => GetUsageTimelineV1UsageTimelineGetDays.All,
                _ => null,
            };
        }
    }
}