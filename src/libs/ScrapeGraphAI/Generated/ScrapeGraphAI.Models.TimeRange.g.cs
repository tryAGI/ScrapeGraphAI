
#nullable enable

namespace ScrapeGraphAI
{
    /// <summary>
    ///
    /// </summary>
    public enum TimeRange
    {
        /// <summary>
        ///
        /// </summary>
        Past24Hours,
        /// <summary>
        ///
        /// </summary>
        PastHour,
        /// <summary>
        ///
        /// </summary>
        PastMonth,
        /// <summary>
        ///
        /// </summary>
        PastWeek,
        /// <summary>
        ///
        /// </summary>
        PastYear,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TimeRangeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TimeRange value)
        {
            return value switch
            {
                TimeRange.Past24Hours => "past_24_hours",
                TimeRange.PastHour => "past_hour",
                TimeRange.PastMonth => "past_month",
                TimeRange.PastWeek => "past_week",
                TimeRange.PastYear => "past_year",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TimeRange? ToEnum(string value)
        {
            return value switch
            {
                "past_24_hours" => TimeRange.Past24Hours,
                "past_hour" => TimeRange.PastHour,
                "past_month" => TimeRange.PastMonth,
                "past_week" => TimeRange.PastWeek,
                "past_year" => TimeRange.PastYear,
                _ => null,
            };
        }
    }
}