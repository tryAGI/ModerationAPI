
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class QueueViewOpenGetItemsResponseItemLabel
    {
        /// <summary>
        /// Label name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Label { get; set; }

        /// <summary>
        /// Confidence score of the label
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Score { get; set; }

        /// <summary>
        /// Whether this label caused a flag
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("flagged")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Flagged { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QueueViewOpenGetItemsResponseItemLabel" /> class.
        /// </summary>
        /// <param name="label">
        /// Label name
        /// </param>
        /// <param name="score">
        /// Confidence score of the label
        /// </param>
        /// <param name="flagged">
        /// Whether this label caused a flag
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QueueViewOpenGetItemsResponseItemLabel(
            string label,
            double score,
            bool flagged)
        {
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
            this.Score = score;
            this.Flagged = flagged;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueueViewOpenGetItemsResponseItemLabel" /> class.
        /// </summary>
        public QueueViewOpenGetItemsResponseItemLabel()
        {
        }
    }
}