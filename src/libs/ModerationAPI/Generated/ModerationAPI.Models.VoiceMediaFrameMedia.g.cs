
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VoiceMediaFrameMedia
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("track")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ModerationAPI.JsonConverters.VoiceMediaFrameMediaTrackJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ModerationAPI.VoiceMediaFrameMediaTrack Track { get; set; }

        /// <summary>
        /// Base64-encoded audio in the declared format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("payload")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Payload { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceMediaFrameMedia" /> class.
        /// </summary>
        /// <param name="track"></param>
        /// <param name="payload">
        /// Base64-encoded audio in the declared format.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VoiceMediaFrameMedia(
            global::ModerationAPI.VoiceMediaFrameMediaTrack track,
            string payload)
        {
            this.Track = track;
            this.Payload = payload ?? throw new global::System.ArgumentNullException(nameof(payload));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceMediaFrameMedia" /> class.
        /// </summary>
        public VoiceMediaFrameMedia()
        {
        }

    }
}