
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// The confidence of all labels
    /// </summary>
    public sealed partial class ModerationTextResponseVariant1ProprietyLabelScores
    {
        /// <summary>
        /// Pickup lines, compliments on appearance, etc.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("FLIRTATION")]
        public double? Flirtation { get; set; }

        /// <summary>
        /// References to sexual acts, body parts, etc.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("SEXUALLY_EXPLICIT")]
        public double? SexuallyExplicit { get; set; }

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
        /// Initializes a new instance of the <see cref="ModerationTextResponseVariant1ProprietyLabelScores" /> class.
        /// </summary>
        /// <param name="flirtation">
        /// Pickup lines, compliments on appearance, etc.
        /// </param>
        /// <param name="sexuallyExplicit">
        /// References to sexual acts, body parts, etc.
        /// </param>
        /// <param name="neutral"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModerationTextResponseVariant1ProprietyLabelScores(
            double? flirtation,
            double? sexuallyExplicit,
            double? neutral)
        {
            this.Flirtation = flirtation;
            this.SexuallyExplicit = sexuallyExplicit;
            this.Neutral = neutral;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModerationTextResponseVariant1ProprietyLabelScores" /> class.
        /// </summary>
        public ModerationTextResponseVariant1ProprietyLabelScores()
        {
        }
    }
}