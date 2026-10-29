
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class QueueItem
    {
        /// <summary>
        /// The item ID: the ID of this submission. Use it, or `contentId`, to resolve or unresolve the item in this queue.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Your content ID, as you sent it to `POST /moderate`. Webhooks send it as `item.id`. The resolve endpoints accept it in place of `id`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contentId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ContentId { get; set; }

        /// <summary>
        /// The submitted content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public global::ModerationAPI.OneOf<global::ModerationAPI.QueueItemContentText, global::ModerationAPI.QueueItemContentImage, global::ModerationAPI.QueueItemContentVideo, global::ModerationAPI.QueueItemContentAudio, global::ModerationAPI.QueueItemContentObject>? Content { get; set; }

        /// <summary>
        /// The moderation labels of the content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("labels")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ModerationAPI.QueueItemLabel> Labels { get; set; }

        /// <summary>
        /// Whether moderation flagged the content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("flagged")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Flagged { get; set; }

        /// <summary>
        /// Severity score from 0 to 1, if available.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("severity")]
        public double? Severity { get; set; }

        /// <summary>
        /// `pending` waits for review. `resolved` is reviewed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ModerationAPI.JsonConverters.QueueItemStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ModerationAPI.QueueItemStatus Status { get; set; }

        /// <summary>
        /// When the content was submitted, as Unix time in milliseconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Timestamp { get; set; }

        /// <summary>
        /// Detected ISO language code.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// Conversation ID, if any.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversationId")]
        public string? ConversationId { get; set; }

        /// <summary>
        /// Your author ID, if any.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authorId")]
        public string? AuthorId { get; set; }

        /// <summary>
        /// Content type, for example `message` or `profile`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contentType")]
        public string? ContentType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QueueItem" /> class.
        /// </summary>
        /// <param name="id">
        /// The item ID: the ID of this submission. Use it, or `contentId`, to resolve or unresolve the item in this queue.
        /// </param>
        /// <param name="contentId">
        /// Your content ID, as you sent it to `POST /moderate`. Webhooks send it as `item.id`. The resolve endpoints accept it in place of `id`.
        /// </param>
        /// <param name="labels">
        /// The moderation labels of the content.
        /// </param>
        /// <param name="flagged">
        /// Whether moderation flagged the content.
        /// </param>
        /// <param name="status">
        /// `pending` waits for review. `resolved` is reviewed.
        /// </param>
        /// <param name="timestamp">
        /// When the content was submitted, as Unix time in milliseconds.
        /// </param>
        /// <param name="content">
        /// The submitted content.
        /// </param>
        /// <param name="severity">
        /// Severity score from 0 to 1, if available.
        /// </param>
        /// <param name="language">
        /// Detected ISO language code.
        /// </param>
        /// <param name="conversationId">
        /// Conversation ID, if any.
        /// </param>
        /// <param name="authorId">
        /// Your author ID, if any.
        /// </param>
        /// <param name="contentType">
        /// Content type, for example `message` or `profile`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QueueItem(
            string id,
            string contentId,
            global::System.Collections.Generic.IList<global::ModerationAPI.QueueItemLabel> labels,
            bool flagged,
            global::ModerationAPI.QueueItemStatus status,
            double timestamp,
            global::ModerationAPI.OneOf<global::ModerationAPI.QueueItemContentText, global::ModerationAPI.QueueItemContentImage, global::ModerationAPI.QueueItemContentVideo, global::ModerationAPI.QueueItemContentAudio, global::ModerationAPI.QueueItemContentObject>? content,
            double? severity,
            string? language,
            string? conversationId,
            string? authorId,
            string? contentType)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.ContentId = contentId ?? throw new global::System.ArgumentNullException(nameof(contentId));
            this.Content = content;
            this.Labels = labels ?? throw new global::System.ArgumentNullException(nameof(labels));
            this.Flagged = flagged;
            this.Severity = severity;
            this.Status = status;
            this.Timestamp = timestamp;
            this.Language = language;
            this.ConversationId = conversationId;
            this.AuthorId = authorId;
            this.ContentType = contentType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueueItem" /> class.
        /// </summary>
        public QueueItem()
        {
        }

    }
}