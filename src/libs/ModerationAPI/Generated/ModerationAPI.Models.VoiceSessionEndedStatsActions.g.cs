
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VoiceSessionEndedStatsActions
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow")]
        public int? Allow { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("review")]
        public int? Review { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reject")]
        public int? Reject { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceSessionEndedStatsActions" /> class.
        /// </summary>
        /// <param name="allow"></param>
        /// <param name="review"></param>
        /// <param name="reject"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VoiceSessionEndedStatsActions(
            int? allow,
            int? review,
            int? reject)
        {
            this.Allow = allow;
            this.Review = review;
            this.Reject = reject;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceSessionEndedStatsActions" /> class.
        /// </summary>
        public VoiceSessionEndedStatsActions()
        {
        }

    }
}