
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class QueueViewOpenGetItemsResponseItem
    {
        /// <summary>
        /// Content ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The content to be moderated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Content { get; set; }

        /// <summary>
        /// Content language
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("labels")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ModerationAPI.QueueViewOpenGetItemsResponseItemLabel> Labels { get; set; }

        /// <summary>
        /// Conversation ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversationId")]
        public string? ConversationId { get; set; }

        /// <summary>
        /// Author ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authorId")]
        public string? AuthorId { get; set; }

        /// <summary>
        /// Action IDs taken on this item
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actions")]
        public global::System.Collections.Generic.IList<global::ModerationAPI.QueueViewOpenGetItemsResponseItemAction>? Actions { get; set; }

        /// <summary>
        /// Whether the item is flagged by any label
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("flagged")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Flagged { get; set; }

        /// <summary>
        /// Status of the item
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ModerationAPI.JsonConverters.QueueViewOpenGetItemsResponseItemStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ModerationAPI.QueueViewOpenGetItemsResponseItemStatus Status { get; set; }

        /// <summary>
        /// Unix timestamp of when the item was created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Timestamp { get; set; }

        /// <summary>
        /// Type of the content object
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contentType")]
        public string? ContentType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QueueViewOpenGetItemsResponseItem" /> class.
        /// </summary>
        /// <param name="id">
        /// Content ID
        /// </param>
        /// <param name="content">
        /// The content to be moderated
        /// </param>
        /// <param name="labels"></param>
        /// <param name="flagged">
        /// Whether the item is flagged by any label
        /// </param>
        /// <param name="status">
        /// Status of the item
        /// </param>
        /// <param name="timestamp">
        /// Unix timestamp of when the item was created
        /// </param>
        /// <param name="language">
        /// Content language
        /// </param>
        /// <param name="conversationId">
        /// Conversation ID
        /// </param>
        /// <param name="authorId">
        /// Author ID
        /// </param>
        /// <param name="actions">
        /// Action IDs taken on this item
        /// </param>
        /// <param name="contentType">
        /// Type of the content object
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QueueViewOpenGetItemsResponseItem(
            string id,
            string content,
            global::System.Collections.Generic.IList<global::ModerationAPI.QueueViewOpenGetItemsResponseItemLabel> labels,
            bool flagged,
            global::ModerationAPI.QueueViewOpenGetItemsResponseItemStatus status,
            double timestamp,
            string? language,
            string? conversationId,
            string? authorId,
            global::System.Collections.Generic.IList<global::ModerationAPI.QueueViewOpenGetItemsResponseItemAction>? actions,
            string? contentType)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.Language = language;
            this.Labels = labels ?? throw new global::System.ArgumentNullException(nameof(labels));
            this.ConversationId = conversationId;
            this.AuthorId = authorId;
            this.Actions = actions;
            this.Flagged = flagged;
            this.Status = status;
            this.Timestamp = timestamp;
            this.ContentType = contentType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueueViewOpenGetItemsResponseItem" /> class.
        /// </summary>
        public QueueViewOpenGetItemsResponseItem()
        {
        }
    }
}