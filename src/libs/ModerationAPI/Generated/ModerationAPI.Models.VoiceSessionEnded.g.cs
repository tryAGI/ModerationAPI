
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// Sent when the call ends, with summary stats.
    /// </summary>
    public sealed partial class VoiceSessionEnded
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("v")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int V { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ModerationAPI.JsonConverters.VoiceSessionEndedEventJsonConverter))]
        public global::ModerationAPI.VoiceSessionEndedEvent Event { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversationId")]
        public string? ConversationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sessionId")]
        public string? SessionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stats")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ModerationAPI.VoiceSessionEndedStats Stats { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceSessionEnded" /> class.
        /// </summary>
        /// <param name="v"></param>
        /// <param name="stats"></param>
        /// <param name="event"></param>
        /// <param name="conversationId"></param>
        /// <param name="sessionId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VoiceSessionEnded(
            int v,
            global::ModerationAPI.VoiceSessionEndedStats stats,
            global::ModerationAPI.VoiceSessionEndedEvent @event,
            string? conversationId,
            string? sessionId)
        {
            this.V = v;
            this.Event = @event;
            this.ConversationId = conversationId;
            this.SessionId = sessionId;
            this.Stats = stats ?? throw new global::System.ArgumentNullException(nameof(stats));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceSessionEnded" /> class.
        /// </summary>
        public VoiceSessionEnded()
        {
        }

    }
}