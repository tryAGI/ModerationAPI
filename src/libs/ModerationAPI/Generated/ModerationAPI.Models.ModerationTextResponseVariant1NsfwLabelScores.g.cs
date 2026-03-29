
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// The confidence of all labels
    /// </summary>
    public sealed partial class ModerationTextResponseVariant1NsfwLabelScores
    {
        /// <summary>
        /// Mentions religion, politics, race, etc., but is neutral or positive.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("SENSITIVE")]
        public double? Sensitive { get; set; }

        /// <summary>
        /// Sexual, hateful, profane, and inappropriate content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("UNSAFE")]
        public double? Unsafe { get; set; }

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
        /// Initializes a new instance of the <see cref="ModerationTextResponseVariant1NsfwLabelScores" /> class.
        /// </summary>
        /// <param name="sensitive">
        /// Mentions religion, politics, race, etc., but is neutral or positive.
        /// </param>
        /// <param name="unsafe">
        /// Sexual, hateful, profane, and inappropriate content.
        /// </param>
        /// <param name="neutral"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModerationTextResponseVariant1NsfwLabelScores(
            double? sensitive,
            double? @unsafe,
            double? neutral)
        {
            this.Sensitive = sensitive;
            this.Unsafe = @unsafe;
            this.Neutral = neutral;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModerationTextResponseVariant1NsfwLabelScores" /> class.
        /// </summary>
        public ModerationTextResponseVariant1NsfwLabelScores()
        {
        }
    }
}