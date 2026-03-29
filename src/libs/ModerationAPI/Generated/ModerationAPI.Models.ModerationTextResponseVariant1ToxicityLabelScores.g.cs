
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// The confidence of all labels
    /// </summary>
    public sealed partial class ModerationTextResponseVariant1ToxicityLabelScores
    {
        /// <summary>
        /// Rude or disrespectful content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("TOXICITY")]
        public double? Toxicity { get; set; }

        /// <summary>
        /// Swearing, curse words, and other obscene language.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("PROFANITY")]
        public double? Profanity { get; set; }

        /// <summary>
        /// Discrimination of race, religion, gender, etc.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("DISCRIMINATION")]
        public double? Discrimination { get; set; }

        /// <summary>
        /// Very hateful and aggressive content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("SEVERE_TOXICITY")]
        public double? SevereToxicity { get; set; }

        /// <summary>
        /// Negative comments about looks or personality etc.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("INSULT")]
        public double? Insult { get; set; }

        /// <summary>
        /// Content containing intention to harm or violence.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("THREAT")]
        public double? Threat { get; set; }

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
        /// Initializes a new instance of the <see cref="ModerationTextResponseVariant1ToxicityLabelScores" /> class.
        /// </summary>
        /// <param name="toxicity">
        /// Rude or disrespectful content.
        /// </param>
        /// <param name="profanity">
        /// Swearing, curse words, and other obscene language.
        /// </param>
        /// <param name="discrimination">
        /// Discrimination of race, religion, gender, etc.
        /// </param>
        /// <param name="severeToxicity">
        /// Very hateful and aggressive content.
        /// </param>
        /// <param name="insult">
        /// Negative comments about looks or personality etc.
        /// </param>
        /// <param name="threat">
        /// Content containing intention to harm or violence.
        /// </param>
        /// <param name="neutral"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModerationTextResponseVariant1ToxicityLabelScores(
            double? toxicity,
            double? profanity,
            double? discrimination,
            double? severeToxicity,
            double? insult,
            double? threat,
            double? neutral)
        {
            this.Toxicity = toxicity;
            this.Profanity = profanity;
            this.Discrimination = discrimination;
            this.SevereToxicity = severeToxicity;
            this.Insult = insult;
            this.Threat = threat;
            this.Neutral = neutral;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModerationTextResponseVariant1ToxicityLabelScores" /> class.
        /// </summary>
        public ModerationTextResponseVariant1ToxicityLabelScores()
        {
        }
    }
}