
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// Entity matcher policy.
    /// </summary>
    public sealed partial class NewModerateModerateResponsePolicieEntityMatcherOutput
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <default>"entity_matcher"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "entity_matcher";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("probability")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Probability { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("flagged")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Flagged { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("flagged_fields")]
        public global::System.Collections.Generic.IList<string>? FlaggedFields { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("matches")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ModerationAPI.NewModerateModerateResponsePolicieEntityMatcherOutputMatche> Matches { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NewModerateModerateResponsePolicieEntityMatcherOutput" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="probability"></param>
        /// <param name="flagged"></param>
        /// <param name="matches"></param>
        /// <param name="flaggedFields"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NewModerateModerateResponsePolicieEntityMatcherOutput(
            string id,
            double probability,
            bool flagged,
            global::System.Collections.Generic.IList<global::ModerationAPI.NewModerateModerateResponsePolicieEntityMatcherOutputMatche> matches,
            global::System.Collections.Generic.IList<string>? flaggedFields,
            string type = "entity_matcher")
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Type = type;
            this.Probability = probability;
            this.Flagged = flagged;
            this.FlaggedFields = flaggedFields;
            this.Matches = matches ?? throw new global::System.ArgumentNullException(nameof(matches));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NewModerateModerateResponsePolicieEntityMatcherOutput" /> class.
        /// </summary>
        public NewModerateModerateResponsePolicieEntityMatcherOutput()
        {
        }
    }
}