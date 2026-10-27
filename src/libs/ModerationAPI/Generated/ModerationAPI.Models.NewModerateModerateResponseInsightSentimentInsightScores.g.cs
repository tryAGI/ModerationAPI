
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// Positive and negative scored independently: mixed content scores high on both. Present whenever `value` is set.
    /// </summary>
    public sealed partial class NewModerateModerateResponseInsightSentimentInsightScores
    {
        /// <summary>
        /// How positive the content is, 0 to 1.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("positive")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Positive { get; set; }

        /// <summary>
        /// How negative the content is, 0 to 1.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("negative")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Negative { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NewModerateModerateResponseInsightSentimentInsightScores" /> class.
        /// </summary>
        /// <param name="positive">
        /// How positive the content is, 0 to 1.
        /// </param>
        /// <param name="negative">
        /// How negative the content is, 0 to 1.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NewModerateModerateResponseInsightSentimentInsightScores(
            double positive,
            double negative)
        {
            this.Positive = positive;
            this.Negative = negative;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NewModerateModerateResponseInsightSentimentInsightScores" /> class.
        /// </summary>
        public NewModerateModerateResponseInsightSentimentInsightScores()
        {
        }

    }
}