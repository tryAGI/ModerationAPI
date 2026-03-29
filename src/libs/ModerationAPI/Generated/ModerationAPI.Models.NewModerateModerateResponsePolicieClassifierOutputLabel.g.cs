
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NewModerateModerateResponsePolicieClassifierOutputLabel
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NewModerateModerateResponsePolicieClassifierOutputLabel" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="probability"></param>
        /// <param name="flagged"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NewModerateModerateResponsePolicieClassifierOutputLabel(
            string id,
            double probability,
            bool flagged)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Probability = probability;
            this.Flagged = flagged;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NewModerateModerateResponsePolicieClassifierOutputLabel" /> class.
        /// </summary>
        public NewModerateModerateResponsePolicieClassifierOutputLabel()
        {
        }
    }
}