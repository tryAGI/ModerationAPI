
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// The time window of the numbers.
    /// </summary>
    public enum GetAnalyticsChannelsResponseRange
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
    public static class GetAnalyticsChannelsResponseRangeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAnalyticsChannelsResponseRange value)
        {
            return value switch
            {
                GetAnalyticsChannelsResponseRange.x24h => "24h",
                GetAnalyticsChannelsResponseRange.x30d => "30d",
                GetAnalyticsChannelsResponseRange.x7d => "7d",
                GetAnalyticsChannelsResponseRange.x90d => "90d",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAnalyticsChannelsResponseRange? ToEnum(string value)
        {
            return value switch
            {
                "24h" => GetAnalyticsChannelsResponseRange.x24h,
                "30d" => GetAnalyticsChannelsResponseRange.x30d,
                "7d" => GetAnalyticsChannelsResponseRange.x7d,
                "90d" => GetAnalyticsChannelsResponseRange.x90d,
                _ => null,
            };
        }
    }
}