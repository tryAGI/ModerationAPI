
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// Current author status
    /// </summary>
    public enum PublicAuthorStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Blocked,
        /// <summary>
        /// 
        /// </summary>
        Enabled,
        /// <summary>
        /// 
        /// </summary>
        Suspended,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PublicAuthorStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PublicAuthorStatus value)
        {
            return value switch
            {
                PublicAuthorStatus.Blocked => "blocked",
                PublicAuthorStatus.Enabled => "enabled",
                PublicAuthorStatus.Suspended => "suspended",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PublicAuthorStatus? ToEnum(string value)
        {
            return value switch
            {
                "blocked" => PublicAuthorStatus.Blocked,
                "enabled" => PublicAuthorStatus.Enabled,
                "suspended" => PublicAuthorStatus.Suspended,
                _ => null,
            };
        }
    }
}