
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// Current author status
    /// </summary>
    public enum ModerationAudioResponseAuthorStatus
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
    public static class ModerationAudioResponseAuthorStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModerationAudioResponseAuthorStatus value)
        {
            return value switch
            {
                ModerationAudioResponseAuthorStatus.Blocked => "blocked",
                ModerationAudioResponseAuthorStatus.Enabled => "enabled",
                ModerationAudioResponseAuthorStatus.Suspended => "suspended",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModerationAudioResponseAuthorStatus? ToEnum(string value)
        {
            return value switch
            {
                "blocked" => ModerationAudioResponseAuthorStatus.Blocked,
                "enabled" => ModerationAudioResponseAuthorStatus.Enabled,
                "suspended" => ModerationAudioResponseAuthorStatus.Suspended,
                _ => null,
            };
        }
    }
}