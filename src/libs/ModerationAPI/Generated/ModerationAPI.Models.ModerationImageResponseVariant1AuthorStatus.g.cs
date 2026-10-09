
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// Current author status
    /// </summary>
    public enum ModerationImageResponseVariant1AuthorStatus
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
    public static class ModerationImageResponseVariant1AuthorStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModerationImageResponseVariant1AuthorStatus value)
        {
            return value switch
            {
                ModerationImageResponseVariant1AuthorStatus.Blocked => "blocked",
                ModerationImageResponseVariant1AuthorStatus.Enabled => "enabled",
                ModerationImageResponseVariant1AuthorStatus.Suspended => "suspended",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModerationImageResponseVariant1AuthorStatus? ToEnum(string value)
        {
            return value switch
            {
                "blocked" => ModerationImageResponseVariant1AuthorStatus.Blocked,
                "enabled" => ModerationImageResponseVariant1AuthorStatus.Enabled,
                "suspended" => ModerationImageResponseVariant1AuthorStatus.Suspended,
                _ => null,
            };
        }
    }
}