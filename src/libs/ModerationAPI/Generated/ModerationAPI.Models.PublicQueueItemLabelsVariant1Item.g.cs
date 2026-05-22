
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PublicQueueItemLabelsVariant1Item
    {
        /// <summary>
        /// The label name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Label { get; set; }

        /// <summary>
        /// Confidence score between 0 and 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Score { get; set; }

        /// <summary>
        /// True if the label was applied manually by a moderator
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("manual")]
        public bool? Manual { get; set; }

        /// <summary>
        /// Whether this label crossed its flagging threshold
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("flagged")]
        public bool? Flagged { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("matches")]
        public global::System.Collections.Generic.IList<global::ModerationAPI.PublicQueueItemLabelsVariant1ItemMatche>? Matches { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicQueueItemLabelsVariant1Item" /> class.
        /// </summary>
        /// <param name="label">
        /// The label name
        /// </param>
        /// <param name="score">
        /// Confidence score between 0 and 1
        /// </param>
        /// <param name="manual">
        /// True if the label was applied manually by a moderator
        /// </param>
        /// <param name="flagged">
        /// Whether this label crossed its flagging threshold
        /// </param>
        /// <param name="matches"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PublicQueueItemLabelsVariant1Item(
            string label,
            double score,
            bool? manual,
            bool? flagged,
            global::System.Collections.Generic.IList<global::ModerationAPI.PublicQueueItemLabelsVariant1ItemMatche>? matches)
        {
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
            this.Score = score;
            this.Manual = manual;
            this.Flagged = flagged;
            this.Matches = matches;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicQueueItemLabelsVariant1Item" /> class.
        /// </summary>
        public PublicQueueItemLabelsVariant1Item()
        {
        }

    }
}