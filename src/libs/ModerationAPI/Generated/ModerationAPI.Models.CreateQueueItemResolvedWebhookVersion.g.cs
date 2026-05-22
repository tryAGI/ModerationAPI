
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateQueueItemResolvedWebhookVersion
    {
        /// <summary>
        /// 
        /// </summary>
        V2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateQueueItemResolvedWebhookVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateQueueItemResolvedWebhookVersion value)
        {
            return value switch
            {
                CreateQueueItemResolvedWebhookVersion.V2 => "v2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateQueueItemResolvedWebhookVersion? ToEnum(string value)
        {
            return value switch
            {
                "v2" => CreateQueueItemResolvedWebhookVersion.V2,
                _ => null,
            };
        }
    }
}