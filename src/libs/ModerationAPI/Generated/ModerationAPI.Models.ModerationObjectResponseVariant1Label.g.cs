
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModerationObjectResponseVariant1Label
    {
        /// <summary>
        /// The label of the model
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Label { get; set; }

        /// <summary>
        /// The model that found the label
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

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
        /// Initializes a new instance of the <see cref="ModerationObjectResponseVariant1Label" /> class.
        /// </summary>
        /// <param name="label">
        /// The label of the model
        /// </param>
        /// <param name="model">
        /// The model that found the label
        /// </param>
        /// <param name="score">
        /// The confidence of the model
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModerationObjectResponseVariant1Label(
            string label,
            string model,
            double score)
        {
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Score = score;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModerationObjectResponseVariant1Label" /> class.
        /// </summary>
        public ModerationObjectResponseVariant1Label()
        {
        }
    }
}