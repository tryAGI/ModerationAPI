
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    ///
    /// </summary>
    public enum QueueItemResolvedWebhookVersion
    {
        /// <summary>
        ///
        /// </summary>
        V2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class QueueItemResolvedWebhookVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this QueueItemResolvedWebhookVersion value)
        {
            return value switch
            {
                QueueItemResolvedWebhookVersion.V2 => "v2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static QueueItemResolvedWebhookVersion? ToEnum(string value)
        {
            return value switch
            {
                "v2" => QueueItemResolvedWebhookVersion.V2,
                _ => null,
            };
        }
    }
}