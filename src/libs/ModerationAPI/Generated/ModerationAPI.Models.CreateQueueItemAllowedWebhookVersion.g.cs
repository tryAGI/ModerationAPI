
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateQueueItemAllowedWebhookVersion
    {
        /// <summary>
        /// 
        /// </summary>
        V2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateQueueItemAllowedWebhookVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateQueueItemAllowedWebhookVersion value)
        {
            return value switch
            {
                CreateQueueItemAllowedWebhookVersion.V2 => "v2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateQueueItemAllowedWebhookVersion? ToEnum(string value)
        {
            return value switch
            {
                "v2" => CreateQueueItemAllowedWebhookVersion.V2,
                _ => null,
            };
        }
    }
}