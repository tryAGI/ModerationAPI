
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
        ClientOverride,
        /// <summary>
        /// 
        /// </summary>
        DryRun,
        /// <summary>
        /// 
        /// </summary>
        RuleDefault,
        /// <summary>
        /// 
        /// </summary>
        RuleFallback,
        /// <summary>
        /// 
        /// </summary>
        RuleMatch,
        /// <summary>
        /// 
        /// </summary>
        SeverityReject,
        /// <summary>
        /// 
        /// </summary>
        SeverityReview,
        /// <summary>
        /// 
        /// </summary>
        TrustedAllow,
        /// <summary>
        /// 
        /// </summary>
        UntrustedSeverity,
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
                NewModerateModerateResponseRecommendationReasonCode.ClientOverride => "client_override",
                NewModerateModerateResponseRecommendationReasonCode.DryRun => "dry_run",
                NewModerateModerateResponseRecommendationReasonCode.RuleDefault => "rule_default",
                NewModerateModerateResponseRecommendationReasonCode.RuleFallback => "rule_fallback",
                NewModerateModerateResponseRecommendationReasonCode.RuleMatch => "rule_match",
                NewModerateModerateResponseRecommendationReasonCode.SeverityReject => "severity_reject",
                NewModerateModerateResponseRecommendationReasonCode.SeverityReview => "severity_review",
                NewModerateModerateResponseRecommendationReasonCode.TrustedAllow => "trusted_allow",
                NewModerateModerateResponseRecommendationReasonCode.UntrustedSeverity => "untrusted_severity",
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
                "client_override" => NewModerateModerateResponseRecommendationReasonCode.ClientOverride,
                "dry_run" => NewModerateModerateResponseRecommendationReasonCode.DryRun,
                "rule_default" => NewModerateModerateResponseRecommendationReasonCode.RuleDefault,
                "rule_fallback" => NewModerateModerateResponseRecommendationReasonCode.RuleFallback,
                "rule_match" => NewModerateModerateResponseRecommendationReasonCode.RuleMatch,
                "severity_reject" => NewModerateModerateResponseRecommendationReasonCode.SeverityReject,
                "severity_review" => NewModerateModerateResponseRecommendationReasonCode.SeverityReview,
                "trusted_allow" => NewModerateModerateResponseRecommendationReasonCode.TrustedAllow,
                "untrusted_severity" => NewModerateModerateResponseRecommendationReasonCode.UntrustedSeverity,
                _ => null,
            };
        }
    }
}