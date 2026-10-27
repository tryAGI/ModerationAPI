
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    ///
    /// </summary>
    public enum QueueItemAllowedWebhookVersion
    {
        /// <summary>
        ///
        /// </summary>
        V2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class QueueItemAllowedWebhookVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this QueueItemAllowedWebhookVersion value)
        {
            return value switch
            {
                QueueItemAllowedWebhookVersion.V2 => "v2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static QueueItemAllowedWebhookVersion? ToEnum(string value)
        {
            return value switch
            {
                "v2" => QueueItemAllowedWebhookVersion.V2,
                _ => null,
            };
        }
    }
}