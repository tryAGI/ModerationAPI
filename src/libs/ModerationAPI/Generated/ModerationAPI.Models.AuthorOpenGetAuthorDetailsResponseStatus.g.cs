
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// Current author status
    /// </summary>
    public enum AuthorOpenGetAuthorDetailsResponseStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Blocked,
        /// <summary>
        /// 
        /// </summary>
        Enabled,
        /// <summary>
        /// 
        /// </summary>
        Suspended,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AuthorOpenGetAuthorDetailsResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AuthorOpenGetAuthorDetailsResponseStatus value)
        {
            return value switch
            {
                AuthorOpenGetAuthorDetailsResponseStatus.Blocked => "blocked",
                AuthorOpenGetAuthorDetailsResponseStatus.Enabled => "enabled",
                AuthorOpenGetAuthorDetailsResponseStatus.Suspended => "suspended",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AuthorOpenGetAuthorDetailsResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "blocked" => AuthorOpenGetAuthorDetailsResponseStatus.Blocked,
                "enabled" => AuthorOpenGetAuthorDetailsResponseStatus.Enabled,
                "suspended" => AuthorOpenGetAuthorDetailsResponseStatus.Suspended,
                _ => null,
            };
        }
    }
}