
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class Channel
    {
        /// <summary>
        /// The ID of the channel.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The ID of the project the channel is in.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// The key you pass as `channel` when you moderate content. Unique in the project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

        /// <summary>
        /// The channel's name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The channel's description.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Whether requests that name no channel use this one. Each project has one default channel.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isDefault")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsDefault { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contentType")]
        public global::ModerationAPI.ChannelContentType? ContentType { get; set; }

        /// <summary>
        /// `ACTIVE` flags content. `DRY_RUN` evaluates content without flagging it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("flaggingMode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ModerationAPI.JsonConverters.ChannelFlaggingModeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ModerationAPI.ChannelFlaggingMode FlaggingMode { get; set; }

        /// <summary>
        /// Whether earlier messages in the conversation are read when moderating a message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contextEnabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool ContextEnabled { get; set; }

        /// <summary>
        /// Whether images are moderated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enableImageModeration")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool EnableImageModeration { get; set; }

        /// <summary>
        /// Whether videos are moderated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enableVideoModeration")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool EnableVideoModeration { get; set; }

        /// <summary>
        /// Whether audio is moderated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enableAudioModeration")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool EnableAudioModeration { get; set; }

        /// <summary>
        /// Whether real-time voice streams are moderated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enableVoiceModeration")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool EnableVoiceModeration { get; set; }

        /// <summary>
        /// Whether audio and video transcripts are returned in responses.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("includeTranscriptInResponse")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IncludeTranscriptInResponse { get; set; }

        /// <summary>
        /// Trade-off between transcription speed and accuracy.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcriptionQuality")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ModerationAPI.JsonConverters.ChannelTranscriptionQualityJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ModerationAPI.ChannelTranscriptionQuality TranscriptionQuality { get; set; }

        /// <summary>
        /// Whether look-alike Unicode characters are normalized before moderation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unicodeSpoofDetectionEnabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool UnicodeSpoofDetectionEnabled { get; set; }

        /// <summary>
        /// Seconds between frames captured from a video.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("frameCaptureInterval")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double FrameCaptureInterval { get; set; }

        /// <summary>
        /// The most frames moderated per video.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxFramesPerVideo")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxFramesPerVideo { get; set; }

        /// <summary>
        /// Whether frames are spread evenly across the whole video.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spreadFrames")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool SpreadFrames { get; set; }

        /// <summary>
        /// When the channel was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// When the channel was last changed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Channel" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the channel.
        /// </param>
        /// <param name="projectId">
        /// The ID of the project the channel is in.
        /// </param>
        /// <param name="key">
        /// The key you pass as `channel` when you moderate content. Unique in the project.
        /// </param>
        /// <param name="name">
        /// The channel's name.
        /// </param>
        /// <param name="isDefault">
        /// Whether requests that name no channel use this one. Each project has one default channel.
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
        /// <param name="createdAt">
        /// When the channel was created.
        /// </param>
        /// <param name="updatedAt">
        /// When the channel was last changed.
        /// </param>
        /// <param name="description">
        /// The channel's description.
        /// </param>
        /// <param name="contentType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Channel(
            string id,
            string projectId,
            string key,
            string name,
            bool isDefault,
            global::ModerationAPI.ChannelFlaggingMode flaggingMode,
            bool contextEnabled,
            bool enableImageModeration,
            bool enableVideoModeration,
            bool enableAudioModeration,
            bool enableVoiceModeration,
            bool includeTranscriptInResponse,
            global::ModerationAPI.ChannelTranscriptionQuality transcriptionQuality,
            bool unicodeSpoofDetectionEnabled,
            double frameCaptureInterval,
            int maxFramesPerVideo,
            bool spreadFrames,
            string createdAt,
            string updatedAt,
            string? description,
            global::ModerationAPI.ChannelContentType? contentType)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.IsDefault = isDefault;
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
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.UpdatedAt = updatedAt ?? throw new global::System.ArgumentNullException(nameof(updatedAt));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Channel" /> class.
        /// </summary>
        public Channel()
        {
        }

    }
}