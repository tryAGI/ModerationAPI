
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// Personal story insight. Includes a personal experience or story as a source of support for the statements made in the comment.
    /// </summary>
    public sealed partial class NewModerateModerateResponseInsightPersonalStoryInsight
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"personal_story"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string Id { get; set; } = "personal_story";

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
        /// Whether the content shows personal story.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public bool? Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NewModerateModerateResponseInsightPersonalStoryInsight" /> class.
        /// </summary>
        /// <param name="probability"></param>
        /// <param name="value">
        /// Whether the content shows personal story.
        /// </param>
        /// <param name="id"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NewModerateModerateResponseInsightPersonalStoryInsight(
            double probability,
            bool? value,
            string id = "personal_story",
            string type = "insight")
        {
            this.Id = id;
            this.Type = type;
            this.Probability = probability;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NewModerateModerateResponseInsightPersonalStoryInsight" /> class.
        /// </summary>
        public NewModerateModerateResponseInsightPersonalStoryInsight()
        {
        }

        /// <summary>
        /// Creates a new <see cref="NewModerateModerateResponseInsightPersonalStoryInsight"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static NewModerateModerateResponseInsightPersonalStoryInsight FromProbability(double probability)
        {
            return new NewModerateModerateResponseInsightPersonalStoryInsight
            {
                Probability = probability,
            };
        }

    }
}