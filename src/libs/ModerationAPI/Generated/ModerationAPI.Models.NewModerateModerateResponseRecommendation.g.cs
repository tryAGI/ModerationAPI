
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// The recommendation for the content based on the evaluation.
    /// </summary>
    public sealed partial class NewModerateModerateResponseRecommendation
    {
        /// <summary>
        /// The action to take based on the recommendation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ModerationAPI.JsonConverters.NewModerateModerateResponseRecommendationActionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ModerationAPI.NewModerateModerateResponseRecommendationAction Action { get; set; }

        /// <summary>
        /// The reason code for the recommendation. Can be used to display a reason to the user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason_codes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ModerationAPI.NewModerateModerateResponseRecommendationReasonCode> ReasonCodes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NewModerateModerateResponseRecommendation" /> class.
        /// </summary>
        /// <param name="action">
        /// The action to take based on the recommendation
        /// </param>
        /// <param name="reasonCodes">
        /// The reason code for the recommendation. Can be used to display a reason to the user.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NewModerateModerateResponseRecommendation(
            global::ModerationAPI.NewModerateModerateResponseRecommendationAction action,
            global::System.Collections.Generic.IList<global::ModerationAPI.NewModerateModerateResponseRecommendationReasonCode> reasonCodes)
        {
            this.Action = action;
            this.ReasonCodes = reasonCodes ?? throw new global::System.ArgumentNullException(nameof(reasonCodes));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NewModerateModerateResponseRecommendation" /> class.
        /// </summary>
        public NewModerateModerateResponseRecommendation()
        {
        }
    }
}