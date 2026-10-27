
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// Curiosity insight. Attempts to clarify or ask follow-up questions to better understand another person or idea.
    /// </summary>
    public sealed partial class NewModerateModerateResponseInsightCuriosityInsight
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"curiosity"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string Id { get; set; } = "curiosity";

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
        /// Whether the content shows curiosity.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public bool? Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NewModerateModerateResponseInsightCuriosityInsight" /> class.
        /// </summary>
        /// <param name="probability"></param>
        /// <param name="value">
        /// Whether the content shows curiosity.
        /// </param>
        /// <param name="id"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NewModerateModerateResponseInsightCuriosityInsight(
            double probability,
            bool? value,
            string id = "curiosity",
            string type = "insight")
        {
            this.Id = id;
            this.Type = type;
            this.Probability = probability;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NewModerateModerateResponseInsightCuriosityInsight" /> class.
        /// </summary>
        public NewModerateModerateResponseInsightCuriosityInsight()
        {
        }

        /// <summary>
        /// Creates a new <see cref="NewModerateModerateResponseInsightCuriosityInsight"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static NewModerateModerateResponseInsightCuriosityInsight FromProbability(double probability)
        {
            return new NewModerateModerateResponseInsightCuriosityInsight
            {
                Probability = probability,
            };
        }

    }
}