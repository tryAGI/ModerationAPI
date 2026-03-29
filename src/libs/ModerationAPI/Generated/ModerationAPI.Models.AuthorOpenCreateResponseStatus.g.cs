
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// Current author status
    /// </summary>
    public enum AuthorOpenCreateResponseStatus
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
    public static class AuthorOpenCreateResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AuthorOpenCreateResponseStatus value)
        {
            return value switch
            {
                AuthorOpenCreateResponseStatus.Blocked => "blocked",
                AuthorOpenCreateResponseStatus.Enabled => "enabled",
                AuthorOpenCreateResponseStatus.Suspended => "suspended",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AuthorOpenCreateResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "blocked" => AuthorOpenCreateResponseStatus.Blocked,
                "enabled" => AuthorOpenCreateResponseStatus.Enabled,
                "suspended" => AuthorOpenCreateResponseStatus.Suspended,
                _ => null,
            };
        }
    }
}