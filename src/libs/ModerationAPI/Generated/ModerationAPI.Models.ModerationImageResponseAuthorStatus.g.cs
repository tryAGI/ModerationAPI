
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// Current author status
    /// </summary>
    public enum ModerationImageResponseAuthorStatus
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
    public static class ModerationImageResponseAuthorStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModerationImageResponseAuthorStatus value)
        {
            return value switch
            {
                ModerationImageResponseAuthorStatus.Blocked => "blocked",
                ModerationImageResponseAuthorStatus.Enabled => "enabled",
                ModerationImageResponseAuthorStatus.Suspended => "suspended",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModerationImageResponseAuthorStatus? ToEnum(string value)
        {
            return value switch
            {
                "blocked" => ModerationImageResponseAuthorStatus.Blocked,
                "enabled" => ModerationImageResponseAuthorStatus.Enabled,
                "suspended" => ModerationImageResponseAuthorStatus.Suspended,
                _ => null,
            };
        }
    }
}