
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// Current author status
    /// </summary>
    public enum ModerationVideoResponseVariant1AuthorStatus
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
    public static class ModerationVideoResponseVariant1AuthorStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModerationVideoResponseVariant1AuthorStatus value)
        {
            return value switch
            {
                ModerationVideoResponseVariant1AuthorStatus.Blocked => "blocked",
                ModerationVideoResponseVariant1AuthorStatus.Enabled => "enabled",
                ModerationVideoResponseVariant1AuthorStatus.Suspended => "suspended",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModerationVideoResponseVariant1AuthorStatus? ToEnum(string value)
        {
            return value switch
            {
                "blocked" => ModerationVideoResponseVariant1AuthorStatus.Blocked,
                "enabled" => ModerationVideoResponseVariant1AuthorStatus.Enabled,
                "suspended" => ModerationVideoResponseVariant1AuthorStatus.Suspended,
                _ => null,
            };
        }
    }
}