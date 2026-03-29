
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// Current author status
    /// </summary>
    public enum AuthorOpenUpdateResponseStatus
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
    public static class AuthorOpenUpdateResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AuthorOpenUpdateResponseStatus value)
        {
            return value switch
            {
                AuthorOpenUpdateResponseStatus.Blocked => "blocked",
                AuthorOpenUpdateResponseStatus.Enabled => "enabled",
                AuthorOpenUpdateResponseStatus.Suspended => "suspended",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AuthorOpenUpdateResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "blocked" => AuthorOpenUpdateResponseStatus.Blocked,
                "enabled" => AuthorOpenUpdateResponseStatus.Enabled,
                "suspended" => AuthorOpenUpdateResponseStatus.Suspended,
                _ => null,
            };
        }
    }
}