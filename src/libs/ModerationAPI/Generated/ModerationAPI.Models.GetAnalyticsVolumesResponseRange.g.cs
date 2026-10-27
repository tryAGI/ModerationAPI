
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// The time window of the numbers.
    /// </summary>
    public enum GetAnalyticsVolumesResponseRange
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
    public static class GetAnalyticsVolumesResponseRangeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAnalyticsVolumesResponseRange value)
        {
            return value switch
            {
                GetAnalyticsVolumesResponseRange.x24h => "24h",
                GetAnalyticsVolumesResponseRange.x30d => "30d",
                GetAnalyticsVolumesResponseRange.x7d => "7d",
                GetAnalyticsVolumesResponseRange.x90d => "90d",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAnalyticsVolumesResponseRange? ToEnum(string value)
        {
            return value switch
            {
                "24h" => GetAnalyticsVolumesResponseRange.x24h,
                "30d" => GetAnalyticsVolumesResponseRange.x30d,
                "7d" => GetAnalyticsVolumesResponseRange.x7d,
                "90d" => GetAnalyticsVolumesResponseRange.x90d,
                _ => null,
            };
        }
    }
}