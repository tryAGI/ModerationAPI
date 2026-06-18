
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VoiceUtteranceFinalRecommendation
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ModerationAPI.JsonConverters.VoiceUtteranceFinalRecommendationActionJsonConverter))]
        public global::ModerationAPI.VoiceUtteranceFinalRecommendationAction? Action { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceUtteranceFinalRecommendation" /> class.
        /// </summary>
        /// <param name="action"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VoiceUtteranceFinalRecommendation(
            global::ModerationAPI.VoiceUtteranceFinalRecommendationAction? action)
        {
            this.Action = action;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceUtteranceFinalRecommendation" /> class.
        /// </summary>
        public VoiceUtteranceFinalRecommendation()
        {
        }

    }
}