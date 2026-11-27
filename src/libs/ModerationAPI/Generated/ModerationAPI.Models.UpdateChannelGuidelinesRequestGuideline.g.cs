
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpdateChannelGuidelinesRequestGuideline
    {
        /// <summary>
        /// The guideline key. A new key adds a guideline; an existing key changes it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

        /// <summary>
        /// True adds or keeps the guideline. False deletes it, with its instructions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Enabled { get; set; }

        /// <summary>
        /// What the guideline flags. Needed for a new guideline.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        public string? Instructions { get; set; }

        /// <summary>
        /// Whether the policy flags content. When false, the policy only scores it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("flag")]
        public bool? Flag { get; set; }

        /// <summary>
        /// The score (0 to 1) at which it flags. Null goes back to the model default.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("threshold")]
        public double? Threshold { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateChannelGuidelinesRequestGuideline" /> class.
        /// </summary>
        /// <param name="key">
        /// The guideline key. A new key adds a guideline; an existing key changes it.
        /// </param>
        /// <param name="enabled">
        /// True adds or keeps the guideline. False deletes it, with its instructions.
        /// </param>
        /// <param name="instructions">
        /// What the guideline flags. Needed for a new guideline.
        /// </param>
        /// <param name="flag">
        /// Whether the policy flags content. When false, the policy only scores it.
        /// </param>
        /// <param name="threshold">
        /// The score (0 to 1) at which it flags. Null goes back to the model default.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateChannelGuidelinesRequestGuideline(
            string key,
            bool enabled,
            string? instructions,
            bool? flag,
            double? threshold)
        {
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.Enabled = enabled;
            this.Instructions = instructions;
            this.Flag = flag;
            this.Threshold = threshold;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateChannelGuidelinesRequestGuideline" /> class.
        /// </summary>
        public UpdateChannelGuidelinesRequestGuideline()
        {
        }

    }
}