
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// Sent after the start frame is accepted.
    /// </summary>
    public sealed partial class VoiceSessionStarted
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ModerationAPI.JsonConverters.VoiceSessionStartedEventJsonConverter))]
        public global::ModerationAPI.VoiceSessionStartedEvent Event { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversationId")]
        public string? ConversationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sessionId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SessionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tracks")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Tracks { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceSessionStarted" /> class.
        /// </summary>
        /// <param name="v"></param>
        /// <param name="sessionId"></param>
        /// <param name="tracks"></param>
        /// <param name="event"></param>
        /// <param name="conversationId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VoiceSessionStarted(
            int v,
            string sessionId,
            global::System.Collections.Generic.IList<string> tracks,
            global::ModerationAPI.VoiceSessionStartedEvent @event,
            string? conversationId)
        {
            this.V = v;
            this.Event = @event;
            this.ConversationId = conversationId;
            this.SessionId = sessionId ?? throw new global::System.ArgumentNullException(nameof(sessionId));
            this.Tracks = tracks ?? throw new global::System.ArgumentNullException(nameof(tracks));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceSessionStarted" /> class.
        /// </summary>
        public VoiceSessionStarted()
        {
        }

    }
}