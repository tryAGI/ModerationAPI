
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// The time window. `24h` is the last 24 hours, in hourly buckets. `7d`, `30d` and `90d` are whole UTC days that end with today, in daily buckets.<br/>
    /// Default Value: 30d
    /// </summary>
    public enum GetAnalyticsSummaryRange
    {
        /// <summary>
        ///
        /// </summary>
        x24h,
        /// <summary>
        ///
        /// </summary>
        x30d,
        /// <summary>
        ///
        /// </summary>
        x7d,
        /// <summary>
        ///
        /// </summary>
        x90d,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetAnalyticsSummaryRangeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAnalyticsSummaryRange value)
        {
            return value switch
            {
                GetAnalyticsSummaryRange.x24h => "24h",
                GetAnalyticsSummaryRange.x30d => "30d",
                GetAnalyticsSummaryRange.x7d => "7d",
                GetAnalyticsSummaryRange.x90d => "90d",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAnalyticsSummaryRange? ToEnum(string value)
        {
            return value switch
            {
                "24h" => GetAnalyticsSummaryRange.x24h,
                "30d" => GetAnalyticsSummaryRange.x30d,
                "7d" => GetAnalyticsSummaryRange.x7d,
                "90d" => GetAnalyticsSummaryRange.x90d,
                _ => null,
            };
        }
    }
}