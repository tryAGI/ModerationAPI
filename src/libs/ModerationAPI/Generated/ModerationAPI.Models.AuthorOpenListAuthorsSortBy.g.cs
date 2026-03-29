
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// 
    /// </summary>
    public enum AuthorOpenListAuthorsSortBy
    {
        /// <summary>
        /// 
        /// </summary>
        AverageSentiment,
        /// <summary>
        /// 
        /// </summary>
        ContentCount,
        /// <summary>
        /// 
        /// </summary>
        FlaggedContentRatio,
        /// <summary>
        /// 
        /// </summary>
        LastActive,
        /// <summary>
        /// 
        /// </summary>
        MemberSince,
        /// <summary>
        /// 
        /// </summary>
        ReportCount,
        /// <summary>
        /// 
        /// </summary>
        TrustLevel,
        /// <summary>
        /// 
        /// </summary>
        ViolationCount,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AuthorOpenListAuthorsSortByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AuthorOpenListAuthorsSortBy value)
        {
            return value switch
            {
                AuthorOpenListAuthorsSortBy.AverageSentiment => "averageSentiment",
                AuthorOpenListAuthorsSortBy.ContentCount => "contentCount",
                AuthorOpenListAuthorsSortBy.FlaggedContentRatio => "flaggedContentRatio",
                AuthorOpenListAuthorsSortBy.LastActive => "lastActive",
                AuthorOpenListAuthorsSortBy.MemberSince => "memberSince",
                AuthorOpenListAuthorsSortBy.ReportCount => "reportCount",
                AuthorOpenListAuthorsSortBy.TrustLevel => "trustLevel",
                AuthorOpenListAuthorsSortBy.ViolationCount => "violationCount",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AuthorOpenListAuthorsSortBy? ToEnum(string value)
        {
            return value switch
            {
                "averageSentiment" => AuthorOpenListAuthorsSortBy.AverageSentiment,
                "contentCount" => AuthorOpenListAuthorsSortBy.ContentCount,
                "flaggedContentRatio" => AuthorOpenListAuthorsSortBy.FlaggedContentRatio,
                "lastActive" => AuthorOpenListAuthorsSortBy.LastActive,
                "memberSince" => AuthorOpenListAuthorsSortBy.MemberSince,
                "reportCount" => AuthorOpenListAuthorsSortBy.ReportCount,
                "trustLevel" => AuthorOpenListAuthorsSortBy.TrustLevel,
                "violationCount" => AuthorOpenListAuthorsSortBy.ViolationCount,
                _ => null,
            };
        }
    }
}