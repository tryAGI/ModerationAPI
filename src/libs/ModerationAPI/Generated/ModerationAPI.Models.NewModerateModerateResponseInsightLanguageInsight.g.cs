
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// Language insight
    /// </summary>
    public sealed partial class NewModerateModerateResponseInsightLanguageInsight
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"language"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string Id { get; set; } = "language";

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
        public string? Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NewModerateModerateResponseInsightLanguageInsight" /> class.
        /// </summary>
        /// <param name="probability"></param>
        /// <param name="value"></param>
        /// <param name="id"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NewModerateModerateResponseInsightLanguageInsight(
            double probability,
            string? value,
            string id = "language",
            string type = "insight")
        {
            this.Id = id;
            this.Type = type;
            this.Probability = probability;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NewModerateModerateResponseInsightLanguageInsight" /> class.
        /// </summary>
        public NewModerateModerateResponseInsightLanguageInsight()
        {
        }
    }
}