
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AuthorOpenCreateResponseRiskEvaluation2
    {
        /// <summary>
        /// Calculated risk level based on more than 10 behavioral signals.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("risk_level")]
        public double? RiskLevel { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthorOpenCreateResponseRiskEvaluation2" /> class.
        /// </summary>
        /// <param name="riskLevel">
        /// Calculated risk level based on more than 10 behavioral signals.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuthorOpenCreateResponseRiskEvaluation2(
            double? riskLevel)
        {
            this.RiskLevel = riskLevel;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthorOpenCreateResponseRiskEvaluation2" /> class.
        /// </summary>
        public AuthorOpenCreateResponseRiskEvaluation2()
        {
        }
    }
}