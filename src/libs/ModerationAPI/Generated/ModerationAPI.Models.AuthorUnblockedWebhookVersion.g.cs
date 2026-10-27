
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    ///
    /// </summary>
    public enum AuthorUnblockedWebhookVersion
    {
        /// <summary>
        ///
        /// </summary>
        V2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AuthorUnblockedWebhookVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AuthorUnblockedWebhookVersion value)
        {
            return value switch
            {
                AuthorUnblockedWebhookVersion.V2 => "v2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AuthorUnblockedWebhookVersion? ToEnum(string value)
        {
            return value switch
            {
                "v2" => AuthorUnblockedWebhookVersion.V2,
                _ => null,
            };
        }
    }
}