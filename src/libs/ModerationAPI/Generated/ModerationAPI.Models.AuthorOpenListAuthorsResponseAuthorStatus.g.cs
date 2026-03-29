
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// Current author status
    /// </summary>
    public enum AuthorOpenListAuthorsResponseAuthorStatus
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
    public static class AuthorOpenListAuthorsResponseAuthorStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AuthorOpenListAuthorsResponseAuthorStatus value)
        {
            return value switch
            {
                AuthorOpenListAuthorsResponseAuthorStatus.Blocked => "blocked",
                AuthorOpenListAuthorsResponseAuthorStatus.Enabled => "enabled",
                AuthorOpenListAuthorsResponseAuthorStatus.Suspended => "suspended",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AuthorOpenListAuthorsResponseAuthorStatus? ToEnum(string value)
        {
            return value switch
            {
                "blocked" => AuthorOpenListAuthorsResponseAuthorStatus.Blocked,
                "enabled" => AuthorOpenListAuthorsResponseAuthorStatus.Enabled,
                "suspended" => AuthorOpenListAuthorsResponseAuthorStatus.Suspended,
                _ => null,
            };
        }
    }
}