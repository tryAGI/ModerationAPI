
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// Sentiment insight
    /// </summary>
    public sealed partial class NewModerateModerateResponseInsightSentimentInsight
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"sentiment"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string Id { get; set; } = "sentiment";

        /// <summary>
        /// 
        /// </summary>
        /// <default>"insight"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "insight";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("probability")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Probability { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public global::ModerationAPI.NewModerateModerateResponseInsightSentimentInsightValue2? Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NewModerateModerateResponseInsightSentimentInsight" /> class.
        /// </summary>
        /// <param name="probability"></param>
        /// <param name="value"></param>
        /// <param name="id"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NewModerateModerateResponseInsightSentimentInsight(
            double probability,
            global::ModerationAPI.NewModerateModerateResponseInsightSentimentInsightValue2? value,
            string id = "sentiment",
            string type = "insight")
        {
            this.Id = id;
            this.Type = type;
            this.Probability = probability;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NewModerateModerateResponseInsightSentimentInsight" /> class.
        /// </summary>
        public NewModerateModerateResponseInsightSentimentInsight()
        {
        }
    }
}