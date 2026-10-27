
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    ///
    /// </summary>
    public enum AuthorTrustLevelChangedWebhookVersion
    {
        /// <summary>
        ///
        /// </summary>
        V2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AuthorTrustLevelChangedWebhookVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AuthorTrustLevelChangedWebhookVersion value)
        {
            return value switch
            {
                AuthorTrustLevelChangedWebhookVersion.V2 => "v2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AuthorTrustLevelChangedWebhookVersion? ToEnum(string value)
        {
            return value switch
            {
                "v2" => AuthorTrustLevelChangedWebhookVersion.V2,
                _ => null,
            };
        }
    }
}