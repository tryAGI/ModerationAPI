
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// The action to take based on the recommendation
    /// </summary>
    public enum NewModerateModerateResponseRecommendationAction
    {
        /// <summary>
        /// 
        /// </summary>
        Allow,
        /// <summary>
        /// 
        /// </summary>
        Reject,
        /// <summary>
        /// 
        /// </summary>
        Review,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NewModerateModerateResponseRecommendationActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NewModerateModerateResponseRecommendationAction value)
        {
            return value switch
            {
                NewModerateModerateResponseRecommendationAction.Allow => "allow",
                NewModerateModerateResponseRecommendationAction.Reject => "reject",
                NewModerateModerateResponseRecommendationAction.Review => "review",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NewModerateModerateResponseRecommendationAction? ToEnum(string value)
        {
            return value switch
            {
                "allow" => NewModerateModerateResponseRecommendationAction.Allow,
                "reject" => NewModerateModerateResponseRecommendationAction.Reject,
                "review" => NewModerateModerateResponseRecommendationAction.Review,
                _ => null,
            };
        }
    }
}