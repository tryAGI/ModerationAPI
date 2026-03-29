
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// Sort direction<br/>
    /// Default Value: desc
    /// </summary>
    public enum AuthorOpenListAuthorsSortDirection
    {
        /// <summary>
        /// 
        /// </summary>
        Asc,
        /// <summary>
        /// 
        /// </summary>
        Desc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AuthorOpenListAuthorsSortDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AuthorOpenListAuthorsSortDirection value)
        {
            return value switch
            {
                AuthorOpenListAuthorsSortDirection.Asc => "asc",
                AuthorOpenListAuthorsSortDirection.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AuthorOpenListAuthorsSortDirection? ToEnum(string value)
        {
            return value switch
            {
                "asc" => AuthorOpenListAuthorsSortDirection.Asc,
                "desc" => AuthorOpenListAuthorsSortDirection.Desc,
                _ => null,
            };
        }
    }
}