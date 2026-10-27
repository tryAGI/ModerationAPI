
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    ///
    /// </summary>
    public enum AuthorBlockedWebhookVersion
    {
        /// <summary>
        ///
        /// </summary>
        V2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AuthorBlockedWebhookVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AuthorBlockedWebhookVersion value)
        {
            return value switch
            {
                AuthorBlockedWebhookVersion.V2 => "v2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AuthorBlockedWebhookVersion? ToEnum(string value)
        {
            return value switch
            {
                "v2" => AuthorBlockedWebhookVersion.V2,
                _ => null,
            };
        }
    }
}