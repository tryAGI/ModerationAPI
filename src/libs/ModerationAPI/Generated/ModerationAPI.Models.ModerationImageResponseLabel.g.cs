
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModerationImageResponseLabel
    {
        /// <summary>
        /// The label of the model
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ModerationAPI.JsonConverters.ModerationImageResponseLabelLabelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ModerationAPI.ModerationImageResponseLabelLabel Label { get; set; }

        /// <summary>
        /// The confidence of the model
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Score { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModerationImageResponseLabel" /> class.
        /// </summary>
        /// <param name="label">
        /// The label of the model
        /// </param>
        /// <param name="score">
        /// The confidence of the model
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModerationImageResponseLabel(
            global::ModerationAPI.ModerationImageResponseLabelLabel label,
            double score)
        {
            this.Label = label;
            this.Score = score;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModerationImageResponseLabel" /> class.
        /// </summary>
        public ModerationImageResponseLabel()
        {
        }
    }
}