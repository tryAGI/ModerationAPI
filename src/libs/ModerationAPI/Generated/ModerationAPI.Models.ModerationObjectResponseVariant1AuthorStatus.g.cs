
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// Current author status
    /// </summary>
    public enum ModerationObjectResponseVariant1AuthorStatus
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
    public static class ModerationObjectResponseVariant1AuthorStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModerationObjectResponseVariant1AuthorStatus value)
        {
            return value switch
            {
                ModerationObjectResponseVariant1AuthorStatus.Blocked => "blocked",
                ModerationObjectResponseVariant1AuthorStatus.Enabled => "enabled",
                ModerationObjectResponseVariant1AuthorStatus.Suspended => "suspended",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModerationObjectResponseVariant1AuthorStatus? ToEnum(string value)
        {
            return value switch
            {
                "blocked" => ModerationObjectResponseVariant1AuthorStatus.Blocked,
                "enabled" => ModerationObjectResponseVariant1AuthorStatus.Enabled,
                "suspended" => ModerationObjectResponseVariant1AuthorStatus.Suspended,
                _ => null,
            };
        }
    }
}