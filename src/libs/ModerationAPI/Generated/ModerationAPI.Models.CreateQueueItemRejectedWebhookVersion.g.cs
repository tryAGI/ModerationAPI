
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateQueueItemRejectedWebhookVersion
    {
        /// <summary>
        /// 
        /// </summary>
        V2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateQueueItemRejectedWebhookVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateQueueItemRejectedWebhookVersion value)
        {
            return value switch
            {
                CreateQueueItemRejectedWebhookVersion.V2 => "v2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateQueueItemRejectedWebhookVersion? ToEnum(string value)
        {
            return value switch
            {
                "v2" => CreateQueueItemRejectedWebhookVersion.V2,
                _ => null,
            };
        }
    }
}