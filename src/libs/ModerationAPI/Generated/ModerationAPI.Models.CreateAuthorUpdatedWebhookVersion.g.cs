
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateAuthorUpdatedWebhookVersion
    {
        /// <summary>
        /// 
        /// </summary>
        V2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateAuthorUpdatedWebhookVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAuthorUpdatedWebhookVersion value)
        {
            return value switch
            {
                CreateAuthorUpdatedWebhookVersion.V2 => "v2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAuthorUpdatedWebhookVersion? ToEnum(string value)
        {
            return value switch
            {
                "v2" => CreateAuthorUpdatedWebhookVersion.V2,
                _ => null,
            };
        }
    }
}