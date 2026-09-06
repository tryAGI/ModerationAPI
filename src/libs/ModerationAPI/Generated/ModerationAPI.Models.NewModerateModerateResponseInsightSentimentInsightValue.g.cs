
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    ///
    /// </summary>
    public enum NewModerateModerateResponseInsightSentimentInsightValue
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
    public static class NewModerateModerateResponseInsightSentimentInsightValueExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NewModerateModerateResponseInsightSentimentInsightValue value)
        {
            return value switch
            {
                NewModerateModerateResponseInsightSentimentInsightValue.Negative => "negative",
                NewModerateModerateResponseInsightSentimentInsightValue.Neutral => "neutral",
                NewModerateModerateResponseInsightSentimentInsightValue.Positive => "positive",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NewModerateModerateResponseInsightSentimentInsightValue? ToEnum(string value)
        {
            return value switch
            {
                "negative" => NewModerateModerateResponseInsightSentimentInsightValue.Negative,
                "neutral" => NewModerateModerateResponseInsightSentimentInsightValue.Neutral,
                "positive" => NewModerateModerateResponseInsightSentimentInsightValue.Positive,
                _ => null,
            };
        }
    }
}