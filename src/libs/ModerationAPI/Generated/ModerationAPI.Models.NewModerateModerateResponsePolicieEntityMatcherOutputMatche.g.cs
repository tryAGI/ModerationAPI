
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NewModerateModerateResponsePolicieEntityMatcherOutputMatche(
            double probability,
            string match,
            global::System.Collections.Generic.IList<int> span)
        {
            this.Probability = probability;
            this.Match = match ?? throw new global::System.ArgumentNullException(nameof(match));
            this.Span = span ?? throw new global::System.ArgumentNullException(nameof(span));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NewModerateModerateResponsePolicieEntityMatcherOutputMatche" /> class.
        /// </summary>
        public NewModerateModerateResponsePolicieEntityMatcherOutputMatche()
        {
        }
    }
}