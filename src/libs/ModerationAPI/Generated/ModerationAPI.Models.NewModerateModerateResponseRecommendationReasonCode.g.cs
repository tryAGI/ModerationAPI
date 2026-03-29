
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// 
    /// </summary>
    public enum NewModerateModerateResponseRecommendationReasonCode
    {
        /// <summary>
        /// 
        /// </summary>
        AuthorBlock,
        /// <summary>
        /// 
        /// </summary>
        DryRun,
        /// <summary>
        /// 
        /// </summary>
        SeverityReject,
        /// <summary>
        /// 
        /// </summary>
        SeverityReview,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NewModerateModerateResponseRecommendationReasonCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NewModerateModerateResponseRecommendationReasonCode value)
        {
            return value switch
            {
                NewModerateModerateResponseRecommendationReasonCode.AuthorBlock => "author_block",
                NewModerateModerateResponseRecommendationReasonCode.DryRun => "dry_run",
                NewModerateModerateResponseRecommendationReasonCode.SeverityReject => "severity_reject",
                NewModerateModerateResponseRecommendationReasonCode.SeverityReview => "severity_review",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NewModerateModerateResponseRecommendationReasonCode? ToEnum(string value)
        {
            return value switch
            {
                "author_block" => NewModerateModerateResponseRecommendationReasonCode.AuthorBlock,
                "dry_run" => NewModerateModerateResponseRecommendationReasonCode.DryRun,
                "severity_reject" => NewModerateModerateResponseRecommendationReasonCode.SeverityReject,
                "severity_review" => NewModerateModerateResponseRecommendationReasonCode.SeverityReview,
                _ => null,
            };
        }
    }
}