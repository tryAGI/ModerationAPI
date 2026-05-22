
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateQueueItemActionWebhookVersion
    {
        /// <summary>
        /// 
        /// </summary>
        V2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateQueueItemActionWebhookVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateQueueItemActionWebhookVersion value)
        {
            return value switch
            {
                CreateQueueItemActionWebhookVersion.V2 => "v2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateQueueItemActionWebhookVersion? ToEnum(string value)
        {
            return value switch
            {
                "v2" => CreateQueueItemActionWebhookVersion.V2,
                _ => null,
            };
        }
    }
}