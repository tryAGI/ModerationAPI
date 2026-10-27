
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// The time window of the numbers.
    /// </summary>
    public enum GetAnalyticsAutomationResponseRange
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
    public static class GetAnalyticsAutomationResponseRangeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAnalyticsAutomationResponseRange value)
        {
            return value switch
            {
                GetAnalyticsAutomationResponseRange.x24h => "24h",
                GetAnalyticsAutomationResponseRange.x30d => "30d",
                GetAnalyticsAutomationResponseRange.x7d => "7d",
                GetAnalyticsAutomationResponseRange.x90d => "90d",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAnalyticsAutomationResponseRange? ToEnum(string value)
        {
            return value switch
            {
                "24h" => GetAnalyticsAutomationResponseRange.x24h,
                "30d" => GetAnalyticsAutomationResponseRange.x30d,
                "7d" => GetAnalyticsAutomationResponseRange.x7d,
                "90d" => GetAnalyticsAutomationResponseRange.x90d,
                _ => null,
            };
        }
    }
}