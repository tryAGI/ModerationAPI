
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    ///
    /// </summary>
    public enum AuthorUpdatedWebhookVersion
    {
        /// <summary>
        ///
        /// </summary>
        V2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AuthorUpdatedWebhookVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AuthorUpdatedWebhookVersion value)
        {
            return value switch
            {
                AuthorUpdatedWebhookVersion.V2 => "v2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AuthorUpdatedWebhookVersion? ToEnum(string value)
        {
            return value switch
            {
                "v2" => AuthorUpdatedWebhookVersion.V2,
                _ => null,
            };
        }
    }
}