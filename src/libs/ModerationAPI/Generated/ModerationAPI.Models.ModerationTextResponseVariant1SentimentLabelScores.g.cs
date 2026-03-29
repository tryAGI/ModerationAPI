
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// The confidence of all labels
    /// </summary>
    public sealed partial class ModerationTextResponseVariant1SentimentLabelScores
    {
        /// <summary>
        /// Positive sentiment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("POSITIVE")]
        public double? Positive { get; set; }

        /// <summary>
        /// Negative sentiment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("NEGATIVE")]
        public double? Negative { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("NEUTRAL")]
        public double? Neutral { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModerationTextResponseVariant1SentimentLabelScores" /> class.
        /// </summary>
        /// <param name="positive">
        /// Positive sentiment.
        /// </param>
        /// <param name="negative">
        /// Negative sentiment.
        /// </param>
        /// <param name="neutral"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModerationTextResponseVariant1SentimentLabelScores(
            double? positive,
            double? negative,
            double? neutral)
        {
            this.Positive = positive;
            this.Negative = negative;
            this.Neutral = neutral;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModerationTextResponseVariant1SentimentLabelScores" /> class.
        /// </summary>
        public ModerationTextResponseVariant1SentimentLabelScores()
        {
        }
    }
}