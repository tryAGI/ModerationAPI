
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// The time window of the numbers.
    /// </summary>
    public enum GetAnalyticsSummaryResponseRange
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
    public static class GetAnalyticsSummaryResponseRangeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAnalyticsSummaryResponseRange value)
        {
            return value switch
            {
                GetAnalyticsSummaryResponseRange.x24h => "24h",
                GetAnalyticsSummaryResponseRange.x30d => "30d",
                GetAnalyticsSummaryResponseRange.x7d => "7d",
                GetAnalyticsSummaryResponseRange.x90d => "90d",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAnalyticsSummaryResponseRange? ToEnum(string value)
        {
            return value switch
            {
                "24h" => GetAnalyticsSummaryResponseRange.x24h,
                "30d" => GetAnalyticsSummaryResponseRange.x30d,
                "7d" => GetAnalyticsSummaryResponseRange.x7d,
                "90d" => GetAnalyticsSummaryResponseRange.x90d,
                _ => null,
            };
        }
    }
}