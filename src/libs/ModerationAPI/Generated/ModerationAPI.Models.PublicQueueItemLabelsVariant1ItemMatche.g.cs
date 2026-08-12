
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PublicQueueItemLabelsVariant1ItemMatche
    {
        /// <summary>
        /// The matched substring
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("match")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Match { get; set; }

        /// <summary>
        /// Match confidence between 0 and 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("probability")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Probability { get; set; }

        /// <summary>
        /// [start, end] character offsets in the source text
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("span")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] Span { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mask")]
        public string? Mask { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasons")]
        public global::System.Collections.Generic.IList<string>? Reasons { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("signals")]
        public global::ModerationAPI.PublicQueueItemLabelsVariant1ItemMatcheSignals? Signals { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entity_type")]
        public string? EntityType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicQueueItemLabelsVariant1ItemMatche" /> class.
        /// </summary>
        /// <param name="match">
        /// The matched substring
        /// </param>
        /// <param name="probability">
        /// Match confidence between 0 and 1
        /// </param>
        /// <param name="span">
        /// [start, end] character offsets in the source text
        /// </param>
        /// <param name="mask"></param>
        /// <param name="reasons"></param>
        /// <param name="signals"></param>
        /// <param name="entityType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PublicQueueItemLabelsVariant1ItemMatche(
            string match,
            double probability,
            byte[] span,
            string? mask,
            global::System.Collections.Generic.IList<string>? reasons,
            global::ModerationAPI.PublicQueueItemLabelsVariant1ItemMatcheSignals? signals,
            string? entityType)
        {
            this.Match = match ?? throw new global::System.ArgumentNullException(nameof(match));
            this.Probability = probability;
            this.Span = span ?? throw new global::System.ArgumentNullException(nameof(span));
            this.Mask = mask;
            this.Reasons = reasons;
            this.Signals = signals;
            this.EntityType = entityType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicQueueItemLabelsVariant1ItemMatche" /> class.
        /// </summary>
        public PublicQueueItemLabelsVariant1ItemMatche()
        {
        }

    }
}