
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// Current author status
    /// </summary>
    public enum NewModerateModerateResponseAuthorStatus
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
    public static class NewModerateModerateResponseAuthorStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NewModerateModerateResponseAuthorStatus value)
        {
            return value switch
            {
                NewModerateModerateResponseAuthorStatus.Blocked => "blocked",
                NewModerateModerateResponseAuthorStatus.Enabled => "enabled",
                NewModerateModerateResponseAuthorStatus.Suspended => "suspended",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NewModerateModerateResponseAuthorStatus? ToEnum(string value)
        {
            return value switch
            {
                "blocked" => NewModerateModerateResponseAuthorStatus.Blocked,
                "enabled" => NewModerateModerateResponseAuthorStatus.Enabled,
                "suspended" => NewModerateModerateResponseAuthorStatus.Suspended,
                _ => null,
            };
        }
    }
}