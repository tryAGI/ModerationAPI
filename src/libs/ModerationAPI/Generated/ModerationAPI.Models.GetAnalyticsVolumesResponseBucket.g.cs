
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// The size of each entry in `volumes`.
    /// </summary>
    public enum GetAnalyticsVolumesResponseBucket
    {
        /// <summary>
        ///
        /// </summary>
        Day,
        /// <summary>
        ///
        /// </summary>
        Hour,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetAnalyticsVolumesResponseBucketExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAnalyticsVolumesResponseBucket value)
        {
            return value switch
            {
                GetAnalyticsVolumesResponseBucket.Day => "day",
                GetAnalyticsVolumesResponseBucket.Hour => "hour",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAnalyticsVolumesResponseBucket? ToEnum(string value)
        {
            return value switch
            {
                "day" => GetAnalyticsVolumesResponseBucket.Day,
                "hour" => GetAnalyticsVolumesResponseBucket.Hour,
                _ => null,
            };
        }
    }
}