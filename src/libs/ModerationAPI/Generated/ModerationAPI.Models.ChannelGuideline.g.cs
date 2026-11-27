
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ChannelGuideline
    {
        /// <summary>
        /// The guideline key. It names the guideline in results and rules.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

        /// <summary>
        /// What the guideline flags, in plain words.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Instructions { get; set; }

        /// <summary>
        /// Whether the policy flags content. When false, the policy only scores it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("flag")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Flag { get; set; }

        /// <summary>
        /// The score (0 to 1) at which the guideline flags. Null uses the model default.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("threshold")]
        public double? Threshold { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelGuideline" /> class.
        /// </summary>
        /// <param name="key">
        /// The guideline key. It names the guideline in results and rules.
        /// </param>
        /// <param name="instructions">
        /// What the guideline flags, in plain words.
        /// </param>
        /// <param name="flag">
        /// Whether the policy flags content. When false, the policy only scores it.
        /// </param>
        /// <param name="threshold">
        /// The score (0 to 1) at which the guideline flags. Null uses the model default.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChannelGuideline(
            string key,
            string instructions,
            bool flag,
            double? threshold)
        {
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.Instructions = instructions ?? throw new global::System.ArgumentNullException(nameof(instructions));
            this.Flag = flag;
            this.Threshold = threshold;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelGuideline" /> class.
        /// </summary>
        public ChannelGuideline()
        {
        }

    }
}