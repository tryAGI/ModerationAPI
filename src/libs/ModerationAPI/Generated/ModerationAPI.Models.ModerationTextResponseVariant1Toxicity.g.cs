
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// The toxicity model output if enabled in your project. Read more at https://docs.moderationapi.com/models/toxicity
    /// </summary>
    public sealed partial class ModerationTextResponseVariant1Toxicity
    {
        /// <summary>
        /// The label of the model
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        public string? Label { get; set; }

        /// <summary>
        /// The confidence of the model
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        public double? Score { get; set; }

        /// <summary>
        /// Indicates an error with the model
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// Indicates a warning from the model, e.g. if the text is too short or long and the model might not be accurate
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("warning")]
        public string? Warning { get; set; }

        /// <summary>
        /// The confidence of all labels
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label_scores")]
        public global::ModerationAPI.ModerationTextResponseVariant1ToxicityLabelScores? LabelScores { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModerationTextResponseVariant1Toxicity" /> class.
        /// </summary>
        /// <param name="label">
        /// The label of the model
        /// </param>
        /// <param name="score">
        /// The confidence of the model
        /// </param>
        /// <param name="error">
        /// Indicates an error with the model
        /// </param>
        /// <param name="warning">
        /// Indicates a warning from the model, e.g. if the text is too short or long and the model might not be accurate
        /// </param>
        /// <param name="labelScores">
        /// The confidence of all labels
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModerationTextResponseVariant1Toxicity(
            string? label,
            double? score,
            string? error,
            string? warning,
            global::ModerationAPI.ModerationTextResponseVariant1ToxicityLabelScores? labelScores)
        {
            this.Label = label;
            this.Score = score;
            this.Error = error;
            this.Warning = warning;
            this.LabelScores = labelScores;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModerationTextResponseVariant1Toxicity" /> class.
        /// </summary>
        public ModerationTextResponseVariant1Toxicity()
        {
        }
    }
}