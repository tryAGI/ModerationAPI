
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// 
    /// </summary>
    public enum NewModerateModerateResponseMetaStatus
    {
        /// <summary>
        /// 
        /// </summary>
        PartialSuccess,
        /// <summary>
        /// 
        /// </summary>
        Success,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NewModerateModerateResponseMetaStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NewModerateModerateResponseMetaStatus value)
        {
            return value switch
            {
                NewModerateModerateResponseMetaStatus.PartialSuccess => "partial_success",
                NewModerateModerateResponseMetaStatus.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NewModerateModerateResponseMetaStatus? ToEnum(string value)
        {
            return value switch
            {
                "partial_success" => NewModerateModerateResponseMetaStatus.PartialSuccess,
                "success" => NewModerateModerateResponseMetaStatus.Success,
                _ => null,
            };
        }
    }
}