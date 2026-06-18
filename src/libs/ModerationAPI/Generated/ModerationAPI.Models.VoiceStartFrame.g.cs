
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// First frame the client sends. Declares the conversation, audio format, and tracks.
    /// </summary>
    public sealed partial class VoiceStartFrame
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ModerationAPI.JsonConverters.VoiceStartFrameEventJsonConverter))]
        public global::ModerationAPI.VoiceStartFrameEvent Event { get; set; }

        /// <summary>
        /// Your external conversation id. Omit to have one generated and returned in `session.started`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversationId")]
        public string? ConversationId { get; set; }

        /// <summary>
        /// Your identifier for this stream.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("streamSid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string StreamSid { get; set; }

        /// <summary>
        /// Optional. Selects which channel's policy configuration applies.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("channel")]
        public string? Channel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mediaFormat")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ModerationAPI.VoiceStartFrameMediaFormat MediaFormat { get; set; }

        /// <summary>
        /// One or both tracks. Stream only the track(s) you have.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tracks")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ModerationAPI.VoiceStartFrameTrack> Tracks { get; set; }

        /// <summary>
        /// Set true to also receive interim, non-final transcripts.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("emitPartials")]
        public bool? EmitPartials { get; set; }

        /// <summary>
        /// Arbitrary JSON attached to the conversation. Stored as-is and not interpreted by moderation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceStartFrame" /> class.
        /// </summary>
        /// <param name="streamSid">
        /// Your identifier for this stream.
        /// </param>
        /// <param name="mediaFormat"></param>
        /// <param name="tracks">
        /// One or both tracks. Stream only the track(s) you have.
        /// </param>
        /// <param name="event"></param>
        /// <param name="conversationId">
        /// Your external conversation id. Omit to have one generated and returned in `session.started`.
        /// </param>
        /// <param name="channel">
        /// Optional. Selects which channel's policy configuration applies.
        /// </param>
        /// <param name="emitPartials">
        /// Set true to also receive interim, non-final transcripts.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="metadata">
        /// Arbitrary JSON attached to the conversation. Stored as-is and not interpreted by moderation.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VoiceStartFrame(
            string streamSid,
            global::ModerationAPI.VoiceStartFrameMediaFormat mediaFormat,
            global::System.Collections.Generic.IList<global::ModerationAPI.VoiceStartFrameTrack> tracks,
            global::ModerationAPI.VoiceStartFrameEvent @event,
            string? conversationId,
            string? channel,
            bool? emitPartials,
            object? metadata)
        {
            this.Event = @event;
            this.ConversationId = conversationId;
            this.StreamSid = streamSid ?? throw new global::System.ArgumentNullException(nameof(streamSid));
            this.Channel = channel;
            this.MediaFormat = mediaFormat ?? throw new global::System.ArgumentNullException(nameof(mediaFormat));
            this.Tracks = tracks ?? throw new global::System.ArgumentNullException(nameof(tracks));
            this.EmitPartials = emitPartials;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceStartFrame" /> class.
        /// </summary>
        public VoiceStartFrame()
        {
        }

    }
}