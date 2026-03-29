
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// 
    /// </summary>
    public enum QueueViewOpenGetQueueResponseQueueFilterRecommendationAction
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
    public static class QueueViewOpenGetQueueResponseQueueFilterRecommendationActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this QueueViewOpenGetQueueResponseQueueFilterRecommendationAction value)
        {
            return value switch
            {
                QueueViewOpenGetQueueResponseQueueFilterRecommendationAction.Allow => "allow",
                QueueViewOpenGetQueueResponseQueueFilterRecommendationAction.Reject => "reject",
                QueueViewOpenGetQueueResponseQueueFilterRecommendationAction.Review => "review",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static QueueViewOpenGetQueueResponseQueueFilterRecommendationAction? ToEnum(string value)
        {
            return value switch
            {
                "allow" => QueueViewOpenGetQueueResponseQueueFilterRecommendationAction.Allow,
                "reject" => QueueViewOpenGetQueueResponseQueueFilterRecommendationAction.Reject,
                "review" => QueueViewOpenGetQueueResponseQueueFilterRecommendationAction.Review,
                _ => null,
            };
        }
    }
}