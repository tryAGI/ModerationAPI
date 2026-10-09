
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class NewModerateModerateResponseCasebook
    {
        /// <summary>
        /// The ruling your past decisions point to for this content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("verdict")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ModerationAPI.JsonConverters.NewModerateModerateResponseCasebookVerdictJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ModerationAPI.NewModerateModerateResponseCasebookVerdict Verdict { get; set; }

        /// <summary>
        /// How close the nearest matching case is, from 0 to 1. 1 means the content is identical to something you have already decided.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("similarity")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Similarity { get; set; }

        /// <summary>
        /// How unanimous the matching cases are, from 0 to 1: the share of them that decided this way, ignoring how many there are. Always at least 0.8 when a ruling is returned — below that the casebook reports a disagreement instead of picking a side — so it tells you how clean the consensus was, and is not a threshold to re-apply yourself.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agreement")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Agreement { get; set; }

        /// <summary>
        /// How strongly the casebook holds this ruling, from 0 to 1: the agreement scaled by how much evidence backs it, so a handful of close, recent cases outweighs one distant one. Older cases count for less, halving in weight roughly every 180 days. This is the number to use in rules when you want a strength condition.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Confidence { get; set; }

        /// <summary>
        /// How many of your past cases backed this ruling.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("case_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CaseCount { get; set; }

        /// <summary>
        /// The topic the closest matching case is filed under, or null when it has not been grouped into one yet.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("topic")]
        public global::ModerationAPI.NewModerateModerateResponseCasebookTopic? Topic { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NewModerateModerateResponseCasebook" /> class.
        /// </summary>
        /// <param name="verdict">
        /// The ruling your past decisions point to for this content.
        /// </param>
        /// <param name="similarity">
        /// How close the nearest matching case is, from 0 to 1. 1 means the content is identical to something you have already decided.
        /// </param>
        /// <param name="agreement">
        /// How unanimous the matching cases are, from 0 to 1: the share of them that decided this way, ignoring how many there are. Always at least 0.8 when a ruling is returned — below that the casebook reports a disagreement instead of picking a side — so it tells you how clean the consensus was, and is not a threshold to re-apply yourself.
        /// </param>
        /// <param name="confidence">
        /// How strongly the casebook holds this ruling, from 0 to 1: the agreement scaled by how much evidence backs it, so a handful of close, recent cases outweighs one distant one. Older cases count for less, halving in weight roughly every 180 days. This is the number to use in rules when you want a strength condition.
        /// </param>
        /// <param name="caseCount">
        /// How many of your past cases backed this ruling.
        /// </param>
        /// <param name="topic">
        /// The topic the closest matching case is filed under, or null when it has not been grouped into one yet.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NewModerateModerateResponseCasebook(
            global::ModerationAPI.NewModerateModerateResponseCasebookVerdict verdict,
            double similarity,
            double agreement,
            double confidence,
            double caseCount,
            global::ModerationAPI.NewModerateModerateResponseCasebookTopic? topic)
        {
            this.Verdict = verdict;
            this.Similarity = similarity;
            this.Agreement = agreement;
            this.Confidence = confidence;
            this.CaseCount = caseCount;
            this.Topic = topic;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NewModerateModerateResponseCasebook" /> class.
        /// </summary>
        public NewModerateModerateResponseCasebook()
        {
        }

    }
}