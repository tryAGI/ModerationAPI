
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// The time window. `24h` is the last 24 hours, in hourly buckets. `7d`, `30d` and `90d` are whole UTC days that end with today, in daily buckets.<br/>
    /// Default Value: 30d
    /// </summary>
    public enum GetAnalyticsVolumesRange
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
    public static class GetAnalyticsVolumesRangeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAnalyticsVolumesRange value)
        {
            return value switch
            {
                GetAnalyticsVolumesRange.x24h => "24h",
                GetAnalyticsVolumesRange.x30d => "30d",
                GetAnalyticsVolumesRange.x7d => "7d",
                GetAnalyticsVolumesRange.x90d => "90d",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAnalyticsVolumesRange? ToEnum(string value)
        {
            return value switch
            {
                "24h" => GetAnalyticsVolumesRange.x24h,
                "30d" => GetAnalyticsVolumesRange.x30d,
                "7d" => GetAnalyticsVolumesRange.x7d,
                "90d" => GetAnalyticsVolumesRange.x90d,
                _ => null,
            };
        }
    }
}