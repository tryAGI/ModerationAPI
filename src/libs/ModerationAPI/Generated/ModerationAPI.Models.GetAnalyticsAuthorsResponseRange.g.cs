
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// The time window of the numbers.
    /// </summary>
    public enum GetAnalyticsAuthorsResponseRange
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
    public static class GetAnalyticsAuthorsResponseRangeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAnalyticsAuthorsResponseRange value)
        {
            return value switch
            {
                GetAnalyticsAuthorsResponseRange.x24h => "24h",
                GetAnalyticsAuthorsResponseRange.x30d => "30d",
                GetAnalyticsAuthorsResponseRange.x7d => "7d",
                GetAnalyticsAuthorsResponseRange.x90d => "90d",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAnalyticsAuthorsResponseRange? ToEnum(string value)
        {
            return value switch
            {
                "24h" => GetAnalyticsAuthorsResponseRange.x24h,
                "30d" => GetAnalyticsAuthorsResponseRange.x30d,
                "7d" => GetAnalyticsAuthorsResponseRange.x7d,
                "90d" => GetAnalyticsAuthorsResponseRange.x90d,
                _ => null,
            };
        }
    }
}