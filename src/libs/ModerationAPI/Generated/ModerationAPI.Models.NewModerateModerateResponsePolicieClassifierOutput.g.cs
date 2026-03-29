
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// Classifier policy.
    /// </summary>
    public sealed partial class NewModerateModerateResponsePolicieClassifierOutput
    {
        /// <summary>
        /// The unique identifier for the classifier output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <default>"classifier"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "classifier";

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
        /// The keys of the flagged fields if submitting an object.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("flagged_fields")]
        public global::System.Collections.Generic.IList<string>? FlaggedFields { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("labels")]
        public global::System.Collections.Generic.IList<global::ModerationAPI.NewModerateModerateResponsePolicieClassifierOutputLabel>? Labels { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NewModerateModerateResponsePolicieClassifierOutput" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier for the classifier output.
        /// </param>
        /// <param name="probability"></param>
        /// <param name="flagged"></param>
        /// <param name="flaggedFields">
        /// The keys of the flagged fields if submitting an object.
        /// </param>
        /// <param name="labels"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NewModerateModerateResponsePolicieClassifierOutput(
            string id,
            double probability,
            bool flagged,
            global::System.Collections.Generic.IList<string>? flaggedFields,
            global::System.Collections.Generic.IList<global::ModerationAPI.NewModerateModerateResponsePolicieClassifierOutputLabel>? labels,
            string type = "classifier")
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Type = type;
            this.Probability = probability;
            this.Flagged = flagged;
            this.FlaggedFields = flaggedFields;
            this.Labels = labels;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NewModerateModerateResponsePolicieClassifierOutput" /> class.
        /// </summary>
        public NewModerateModerateResponsePolicieClassifierOutput()
        {
        }
    }
}