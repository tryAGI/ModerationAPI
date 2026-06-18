
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// Flag images that contain "at least" or "fewer than" the configured number of faces. Defaults to at_least.
    /// </summary>
    public enum NewModerateModerateRequestPolicieFaceDetectionComparator
    {
        /// <summary>
        /// 
        /// </summary>
        AtLeast,
        /// <summary>
        /// 
        /// </summary>
        FewerThan,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NewModerateModerateRequestPolicieFaceDetectionComparatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NewModerateModerateRequestPolicieFaceDetectionComparator value)
        {
            return value switch
            {
                NewModerateModerateRequestPolicieFaceDetectionComparator.AtLeast => "at_least",
                NewModerateModerateRequestPolicieFaceDetectionComparator.FewerThan => "fewer_than",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NewModerateModerateRequestPolicieFaceDetectionComparator? ToEnum(string value)
        {
            return value switch
            {
                "at_least" => NewModerateModerateRequestPolicieFaceDetectionComparator.AtLeast,
                "fewer_than" => NewModerateModerateRequestPolicieFaceDetectionComparator.FewerThan,
                _ => null,
            };
        }
    }
}