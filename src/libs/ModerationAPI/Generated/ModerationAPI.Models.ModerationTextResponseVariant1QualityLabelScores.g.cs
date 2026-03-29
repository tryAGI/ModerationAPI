
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// The confidence of all labels
    /// </summary>
    public sealed partial class ModerationTextResponseVariant1QualityLabelScores
    {
        /// <summary>
        /// Trivial or short content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("UNSUBSTANTIAL")]
        public double? Unsubstantial { get; set; }

        /// <summary>
        /// Difficult to understand, nonsensical.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("INCOHERENT")]
        public double? Incoherent { get; set; }

        /// <summary>
        /// Irrelevant and unsolicited commercial content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("SPAM")]
        public double? Spam { get; set; }

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
        /// Initializes a new instance of the <see cref="ModerationTextResponseVariant1QualityLabelScores" /> class.
        /// </summary>
        /// <param name="unsubstantial">
        /// Trivial or short content.
        /// </param>
        /// <param name="incoherent">
        /// Difficult to understand, nonsensical.
        /// </param>
        /// <param name="spam">
        /// Irrelevant and unsolicited commercial content.
        /// </param>
        /// <param name="neutral"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModerationTextResponseVariant1QualityLabelScores(
            double? unsubstantial,
            double? incoherent,
            double? spam,
            double? neutral)
        {
            this.Unsubstantial = unsubstantial;
            this.Incoherent = incoherent;
            this.Spam = spam;
            this.Neutral = neutral;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModerationTextResponseVariant1QualityLabelScores" /> class.
        /// </summary>
        public ModerationTextResponseVariant1QualityLabelScores()
        {
        }
    }
}