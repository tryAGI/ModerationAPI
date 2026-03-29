
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// The evaluation of the content after running the channel policies.
    /// </summary>
    public sealed partial class NewModerateModerateResponseEvaluation
    {
        /// <summary>
        /// Whether the content was flagged by any policy.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("flagged")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Flagged { get; set; }

        /// <summary>
        /// The probability that the content should be flagged.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("flag_probability")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double FlagProbability { get; set; }

        /// <summary>
        /// The severity score of the content. A higher score indicates more severe content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("severity_score")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double SeverityScore { get; set; }

        /// <summary>
        /// Whether the content was flagged for Unicode spoofing.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unicode_spoofed")]
        public bool? UnicodeSpoofed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NewModerateModerateResponseEvaluation" /> class.
        /// </summary>
        /// <param name="flagged">
        /// Whether the content was flagged by any policy.
        /// </param>
        /// <param name="flagProbability">
        /// The probability that the content should be flagged.
        /// </param>
        /// <param name="severityScore">
        /// The severity score of the content. A higher score indicates more severe content.
        /// </param>
        /// <param name="unicodeSpoofed">
        /// Whether the content was flagged for Unicode spoofing.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NewModerateModerateResponseEvaluation(
            bool flagged,
            double flagProbability,
            double severityScore,
            bool? unicodeSpoofed)
        {
            this.Flagged = flagged;
            this.FlagProbability = flagProbability;
            this.SeverityScore = severityScore;
            this.UnicodeSpoofed = unicodeSpoofed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NewModerateModerateResponseEvaluation" /> class.
        /// </summary>
        public NewModerateModerateResponseEvaluation()
        {
        }
    }
}