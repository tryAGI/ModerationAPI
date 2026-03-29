
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// 
    /// </summary>
    public enum NewModerateModerateResponseInsightSentimentInsightValue2
    {
        /// <summary>
        /// 
        /// </summary>
        Negative,
        /// <summary>
        /// 
        /// </summary>
        Neutral,
        /// <summary>
        /// 
        /// </summary>
        Positive,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NewModerateModerateResponseInsightSentimentInsightValue2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NewModerateModerateResponseInsightSentimentInsightValue2 value)
        {
            return value switch
            {
                NewModerateModerateResponseInsightSentimentInsightValue2.Negative => "negative",
                NewModerateModerateResponseInsightSentimentInsightValue2.Neutral => "neutral",
                NewModerateModerateResponseInsightSentimentInsightValue2.Positive => "positive",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NewModerateModerateResponseInsightSentimentInsightValue2? ToEnum(string value)
        {
            return value switch
            {
                "negative" => NewModerateModerateResponseInsightSentimentInsightValue2.Negative,
                "neutral" => NewModerateModerateResponseInsightSentimentInsightValue2.Neutral,
                "positive" => NewModerateModerateResponseInsightSentimentInsightValue2.Positive,
                _ => null,
            };
        }
    }
}