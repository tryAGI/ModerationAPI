
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// 
    /// </summary>
    public enum VoiceUtteranceFinalRecommendationAction
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
    public static class VoiceUtteranceFinalRecommendationActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VoiceUtteranceFinalRecommendationAction value)
        {
            return value switch
            {
                VoiceUtteranceFinalRecommendationAction.Allow => "allow",
                VoiceUtteranceFinalRecommendationAction.Reject => "reject",
                VoiceUtteranceFinalRecommendationAction.Review => "review",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VoiceUtteranceFinalRecommendationAction? ToEnum(string value)
        {
            return value switch
            {
                "allow" => VoiceUtteranceFinalRecommendationAction.Allow,
                "reject" => VoiceUtteranceFinalRecommendationAction.Reject,
                "review" => VoiceUtteranceFinalRecommendationAction.Review,
                _ => null,
            };
        }
    }
}