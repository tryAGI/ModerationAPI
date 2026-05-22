
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateAuthorUnblockedWebhookVersion
    {
        /// <summary>
        /// 
        /// </summary>
        V2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateAuthorUnblockedWebhookVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAuthorUnblockedWebhookVersion value)
        {
            return value switch
            {
                CreateAuthorUnblockedWebhookVersion.V2 => "v2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAuthorUnblockedWebhookVersion? ToEnum(string value)
        {
            return value switch
            {
                "v2" => CreateAuthorUnblockedWebhookVersion.V2,
                _ => null,
            };
        }
    }
}