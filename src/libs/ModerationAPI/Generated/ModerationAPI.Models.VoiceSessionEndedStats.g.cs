
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VoiceSessionEndedStats
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("durationMs")]
        public int? DurationMs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("utterances")]
        public int? Utterances { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actions")]
        public global::ModerationAPI.VoiceSessionEndedStatsActions? Actions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceSessionEndedStats" /> class.
        /// </summary>
        /// <param name="durationMs"></param>
        /// <param name="utterances"></param>
        /// <param name="actions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VoiceSessionEndedStats(
            int? durationMs,
            int? utterances,
            global::ModerationAPI.VoiceSessionEndedStatsActions? actions)
        {
            this.DurationMs = durationMs;
            this.Utterances = utterances;
            this.Actions = actions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceSessionEndedStats" /> class.
        /// </summary>
        public VoiceSessionEndedStats()
        {
        }

    }
}