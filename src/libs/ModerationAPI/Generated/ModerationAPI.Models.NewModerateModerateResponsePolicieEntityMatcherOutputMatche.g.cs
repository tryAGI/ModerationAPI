
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NewModerateModerateResponsePolicieEntityMatcherOutputMatche
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("probability")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Probability { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("match")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Match { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("span")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<int> Span { get; set; }

        /// <summary>
        /// Stable codes explaining why a URL was flagged (URL Risk only).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasons")]
        public global::System.Collections.Generic.IList<string>? Reasons { get; set; }

        /// <summary>
        /// Observable properties of a URL (URL Risk only). Absent for allow/block list matches.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("signals")]
        public global::ModerationAPI.NewModerateModerateResponsePolicieEntityMatcherOutputMatcheSignals? Signals { get; set; }

        /// <summary>
        /// Sub-type of the entity match — e.g. the NER key (email, phone, name, …) for PII matches. Absent for URL Risk and wordlist matches where the type is already encoded in the parent label.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entity_type")]
        public string? EntityType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NewModerateModerateResponsePolicieEntityMatcherOutputMatche" /> class.
        /// </summary>
        /// <param name="probability"></param>
        /// <param name="match"></param>
        /// <param name="span"></param>
        /// <param name="reasons">
        /// Stable codes explaining why a URL was flagged (URL Risk only).
        /// </param>
        /// <param name="signals">
        /// Observable properties of a URL (URL Risk only). Absent for allow/block list matches.
        /// </param>
        /// <param name="entityType">
        /// Sub-type of the entity match — e.g. the NER key (email, phone, name, …) for PII matches. Absent for URL Risk and wordlist matches where the type is already encoded in the parent label.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NewModerateModerateResponsePolicieEntityMatcherOutputMatche(
            double probability,
            string match,
            global::System.Collections.Generic.IList<int> span,
            global::System.Collections.Generic.IList<string>? reasons,
            global::ModerationAPI.NewModerateModerateResponsePolicieEntityMatcherOutputMatcheSignals? signals,
            string? entityType)
        {
            this.Probability = probability;
            this.Match = match ?? throw new global::System.ArgumentNullException(nameof(match));
            this.Span = span ?? throw new global::System.ArgumentNullException(nameof(span));
            this.Reasons = reasons;
            this.Signals = signals;
            this.EntityType = entityType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NewModerateModerateResponsePolicieEntityMatcherOutputMatche" /> class.
        /// </summary>
        public NewModerateModerateResponsePolicieEntityMatcherOutputMatche()
        {
        }

    }
}