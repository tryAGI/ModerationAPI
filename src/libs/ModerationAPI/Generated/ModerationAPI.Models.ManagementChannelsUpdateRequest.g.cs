
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ManagementChannelsUpdateRequest
    {
        /// <summary>
        /// The channel's name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The key you pass as `channel` when you moderate content. Changing it breaks integrations that send the old key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        public string? Key { get; set; }

        /// <summary>
        /// The channel's description.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The kind of content the channel moderates.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contentType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ModerationAPI.JsonConverters.ManagementChannelsUpdateRequestContentTypeJsonConverter))]
        public global::ModerationAPI.ManagementChannelsUpdateRequestContentType? ContentType { get; set; }

        /// <summary>
        /// `ACTIVE` flags content. `DRY_RUN` evaluates content without flagging it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("flaggingMode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ModerationAPI.JsonConverters.ManagementChannelsUpdateRequestFlaggingModeJsonConverter))]
        public global::ModerationAPI.ManagementChannelsUpdateRequestFlaggingMode? FlaggingMode { get; set; }

        /// <summary>
        /// Whether earlier messages in the conversation are read when moderating a message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contextEnabled")]
        public bool? ContextEnabled { get; set; }

        /// <summary>
        /// Whether images are moderated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enableImageModeration")]
        public bool? EnableImageModeration { get; set; }

        /// <summary>
        /// Whether videos are moderated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enableVideoModeration")]
        public bool? EnableVideoModeration { get; set; }

        /// <summary>
        /// Whether audio is moderated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enableAudioModeration")]
        public bool? EnableAudioModeration { get; set; }

        /// <summary>
        /// Whether real-time voice streams are moderated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enableVoiceModeration")]
        public bool? EnableVoiceModeration { get; set; }

        /// <summary>
        /// Whether audio and video transcripts are returned in responses.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("includeTranscriptInResponse")]
        public bool? IncludeTranscriptInResponse { get; set; }

        /// <summary>
        /// Trade-off between transcription speed and accuracy.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcriptionQuality")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ModerationAPI.JsonConverters.ManagementChannelsUpdateRequestTranscriptionQualityJsonConverter))]
        public global::ModerationAPI.ManagementChannelsUpdateRequestTranscriptionQuality? TranscriptionQuality { get; set; }

        /// <summary>
        /// Whether look-alike Unicode characters are normalized before moderation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unicodeSpoofDetectionEnabled")]
        public bool? UnicodeSpoofDetectionEnabled { get; set; }

        /// <summary>
        /// Seconds between frames captured from a video.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("frameCaptureInterval")]
        public double? FrameCaptureInterval { get; set; }

        /// <summary>
        /// The most frames moderated per video.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxFramesPerVideo")]
        public int? MaxFramesPerVideo { get; set; }

        /// <summary>
        /// Whether frames are spread evenly across the whole video.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spreadFrames")]
        public bool? SpreadFrames { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ManagementChannelsUpdateRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// The channel's name.
        /// </param>
        /// <param name="key">
        /// The key you pass as `channel` when you moderate content. Changing it breaks integrations that send the old key.
        /// </param>
        /// <param name="description">
        /// The channel's description.
        /// </param>
        /// <param name="contentType">
        /// The kind of content the channel moderates.
        /// </param>
        /// <param name="flaggingMode">
        /// `ACTIVE` flags content. `DRY_RUN` evaluates content without flagging it.
        /// </param>
        /// <param name="contextEnabled">
        /// Whether earlier messages in the conversation are read when moderating a message.
        /// </param>
        /// <param name="enableImageModeration">
        /// Whether images are moderated.
        /// </param>
        /// <param name="enableVideoModeration">
        /// Whether videos are moderated.
        /// </param>
        /// <param name="enableAudioModeration">
        /// Whether audio is moderated.
        /// </param>
        /// <param name="enableVoiceModeration">
        /// Whether real-time voice streams are moderated.
        /// </param>
        /// <param name="includeTranscriptInResponse">
        /// Whether audio and video transcripts are returned in responses.
        /// </param>
        /// <param name="transcriptionQuality">
        /// Trade-off between transcription speed and accuracy.
        /// </param>
        /// <param name="unicodeSpoofDetectionEnabled">
        /// Whether look-alike Unicode characters are normalized before moderation.
        /// </param>
        /// <param name="frameCaptureInterval">
        /// Seconds between frames captured from a video.
        /// </param>
        /// <param name="maxFramesPerVideo">
        /// The most frames moderated per video.
        /// </param>
        /// <param name="spreadFrames">
        /// Whether frames are spread evenly across the whole video.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ManagementChannelsUpdateRequest(
            string? name,
            string? key,
            string? description,
            global::ModerationAPI.ManagementChannelsUpdateRequestContentType? contentType,
            global::ModerationAPI.ManagementChannelsUpdateRequestFlaggingMode? flaggingMode,
            bool? contextEnabled,
            bool? enableImageModeration,
            bool? enableVideoModeration,
            bool? enableAudioModeration,
            bool? enableVoiceModeration,
            bool? includeTranscriptInResponse,
            global::ModerationAPI.ManagementChannelsUpdateRequestTranscriptionQuality? transcriptionQuality,
            bool? unicodeSpoofDetectionEnabled,
            double? frameCaptureInterval,
            int? maxFramesPerVideo,
            bool? spreadFrames)
        {
            this.Name = name;
            this.Key = key;
            this.Description = description;
            this.ContentType = contentType;
            this.FlaggingMode = flaggingMode;
            this.ContextEnabled = contextEnabled;
            this.EnableImageModeration = enableImageModeration;
            this.EnableVideoModeration = enableVideoModeration;
            this.EnableAudioModeration = enableAudioModeration;
            this.EnableVoiceModeration = enableVoiceModeration;
            this.IncludeTranscriptInResponse = includeTranscriptInResponse;
            this.TranscriptionQuality = transcriptionQuality;
            this.UnicodeSpoofDetectionEnabled = unicodeSpoofDetectionEnabled;
            this.FrameCaptureInterval = frameCaptureInterval;
            this.MaxFramesPerVideo = maxFramesPerVideo;
            this.SpreadFrames = spreadFrames;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ManagementChannelsUpdateRequest" /> class.
        /// </summary>
        public ManagementChannelsUpdateRequest()
        {
        }

    }
}