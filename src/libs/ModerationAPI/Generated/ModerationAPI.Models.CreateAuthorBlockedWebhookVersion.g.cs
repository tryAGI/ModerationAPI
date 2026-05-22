
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateAuthorBlockedWebhookVersion
    {
        /// <summary>
        /// 
        /// </summary>
        V2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateAuthorBlockedWebhookVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAuthorBlockedWebhookVersion value)
        {
            return value switch
            {
                CreateAuthorBlockedWebhookVersion.V2 => "v2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAuthorBlockedWebhookVersion? ToEnum(string value)
        {
            return value switch
            {
                "v2" => CreateAuthorBlockedWebhookVersion.V2,
                _ => null,
            };
        }
    }
}