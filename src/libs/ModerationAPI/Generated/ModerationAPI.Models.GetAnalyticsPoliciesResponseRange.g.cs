
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// The time window of the numbers.
    /// </summary>
    public enum GetAnalyticsPoliciesResponseRange
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
    public static class GetAnalyticsPoliciesResponseRangeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAnalyticsPoliciesResponseRange value)
        {
            return value switch
            {
                GetAnalyticsPoliciesResponseRange.x24h => "24h",
                GetAnalyticsPoliciesResponseRange.x30d => "30d",
                GetAnalyticsPoliciesResponseRange.x7d => "7d",
                GetAnalyticsPoliciesResponseRange.x90d => "90d",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAnalyticsPoliciesResponseRange? ToEnum(string value)
        {
            return value switch
            {
                "24h" => GetAnalyticsPoliciesResponseRange.x24h,
                "30d" => GetAnalyticsPoliciesResponseRange.x30d,
                "7d" => GetAnalyticsPoliciesResponseRange.x7d,
                "90d" => GetAnalyticsPoliciesResponseRange.x90d,
                _ => null,
            };
        }
    }
}