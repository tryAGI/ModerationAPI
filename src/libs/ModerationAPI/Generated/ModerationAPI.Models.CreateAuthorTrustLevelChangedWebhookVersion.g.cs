
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateAuthorTrustLevelChangedWebhookVersion
    {
        /// <summary>
        /// 
        /// </summary>
        V2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateAuthorTrustLevelChangedWebhookVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAuthorTrustLevelChangedWebhookVersion value)
        {
            return value switch
            {
                CreateAuthorTrustLevelChangedWebhookVersion.V2 => "v2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAuthorTrustLevelChangedWebhookVersion? ToEnum(string value)
        {
            return value switch
            {
                "v2" => CreateAuthorTrustLevelChangedWebhookVersion.V2,
                _ => null,
            };
        }
    }
}