
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// Current author status
    /// </summary>
    public enum ModerationTextResponseVariant1AuthorStatus
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
    public static class ModerationTextResponseVariant1AuthorStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModerationTextResponseVariant1AuthorStatus value)
        {
            return value switch
            {
                ModerationTextResponseVariant1AuthorStatus.Blocked => "blocked",
                ModerationTextResponseVariant1AuthorStatus.Enabled => "enabled",
                ModerationTextResponseVariant1AuthorStatus.Suspended => "suspended",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModerationTextResponseVariant1AuthorStatus? ToEnum(string value)
        {
            return value switch
            {
                "blocked" => ModerationTextResponseVariant1AuthorStatus.Blocked,
                "enabled" => ModerationTextResponseVariant1AuthorStatus.Enabled,
                "suspended" => ModerationTextResponseVariant1AuthorStatus.Suspended,
                _ => null,
            };
        }
    }
}