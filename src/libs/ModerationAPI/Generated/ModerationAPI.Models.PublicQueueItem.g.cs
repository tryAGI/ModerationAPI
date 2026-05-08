
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PublicQueueItem
    {
        /// <summary>
        /// Content ID from your system
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Whether the content was flagged by moderation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("flagged")]
        public bool? Flagged { get; set; }

        /// <summary>
        /// Moderation labels applied to the content
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("labels")]
        public global::System.Collections.Generic.IList<global::ModerationAPI.PublicQueueItemLabelsVariant1Item>? Labels { get; set; }

        /// <summary>
        /// Detected ISO language code, if available
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// The original content payload
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ModerationAPI.JsonConverters.OneOfJsonConverter<global::ModerationAPI.PublicQueueItemContentText, global::ModerationAPI.PublicQueueItemContentImage, global::ModerationAPI.PublicQueueItemContentVideo, global::ModerationAPI.PublicQueueItemContentAudio, global::ModerationAPI.PublicQueueItemContentObject>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ModerationAPI.OneOf<global::ModerationAPI.PublicQueueItemContentText, global::ModerationAPI.PublicQueueItemContentImage, global::ModerationAPI.PublicQueueItemContentVideo, global::ModerationAPI.PublicQueueItemContentAudio, global::ModerationAPI.PublicQueueItemContentObject> Content { get; set; }

        /// <summary>
        /// ISO 8601 timestamp of when the content was submitted
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Timestamp { get; set; }

        /// <summary>
        /// Customer-supplied metadata attached to the content (same shape as the moderation API `metadata` input).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Conversation grouping ID, if any
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation_id")]
        public string? ConversationId { get; set; }

        /// <summary>
        /// External author ID (the customer's identifier, not Moderation API's internal id)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("author_id")]
        public string? AuthorId { get; set; }

        /// <summary>
        /// The channel the content was submitted to, identified by your customer-defined channel key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("channel_key")]
        public string? ChannelKey { get; set; }

        /// <summary>
        /// High-level content type (e.g. message, post, comment). Defaults to the channel's configured content type but can be overridden per request via the moderation API `type` field.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("meta_type")]
        public global::ModerationAPI.PublicQueueItemMetaType2? MetaType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicQueueItem" /> class.
        /// </summary>
        /// <param name="id">
        /// Content ID from your system
        /// </param>
        /// <param name="content">
        /// The original content payload
        /// </param>
        /// <param name="timestamp">
        /// ISO 8601 timestamp of when the content was submitted
        /// </param>
        /// <param name="flagged">
        /// Whether the content was flagged by moderation
        /// </param>
        /// <param name="labels">
        /// Moderation labels applied to the content
        /// </param>
        /// <param name="language">
        /// Detected ISO language code, if available
        /// </param>
        /// <param name="metadata">
        /// Customer-supplied metadata attached to the content (same shape as the moderation API `metadata` input).
        /// </param>
        /// <param name="conversationId">
        /// Conversation grouping ID, if any
        /// </param>
        /// <param name="authorId">
        /// External author ID (the customer's identifier, not Moderation API's internal id)
        /// </param>
        /// <param name="channelKey">
        /// The channel the content was submitted to, identified by your customer-defined channel key.
        /// </param>
        /// <param name="metaType">
        /// High-level content type (e.g. message, post, comment). Defaults to the channel's configured content type but can be overridden per request via the moderation API `type` field.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PublicQueueItem(
            string id,
            global::ModerationAPI.OneOf<global::ModerationAPI.PublicQueueItemContentText, global::ModerationAPI.PublicQueueItemContentImage, global::ModerationAPI.PublicQueueItemContentVideo, global::ModerationAPI.PublicQueueItemContentAudio, global::ModerationAPI.PublicQueueItemContentObject> content,
            global::System.DateTime timestamp,
            bool? flagged,
            global::System.Collections.Generic.IList<global::ModerationAPI.PublicQueueItemLabelsVariant1Item>? labels,
            string? language,
            object? metadata,
            string? conversationId,
            string? authorId,
            string? channelKey,
            global::ModerationAPI.PublicQueueItemMetaType2? metaType)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Flagged = flagged;
            this.Labels = labels;
            this.Language = language;
            this.Content = content;
            this.Timestamp = timestamp;
            this.Metadata = metadata;
            this.ConversationId = conversationId;
            this.AuthorId = authorId;
            this.ChannelKey = channelKey;
            this.MetaType = metaType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicQueueItem" /> class.
        /// </summary>
        public PublicQueueItem()
        {
        }
    }
}