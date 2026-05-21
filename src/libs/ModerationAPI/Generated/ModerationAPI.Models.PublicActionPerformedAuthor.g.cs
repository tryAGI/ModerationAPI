
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PublicActionPerformedAuthor
    {
        /// <summary>
        /// Moderation action ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Customer-defined key identifying this action
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        public string? Key { get; set; }

        /// <summary>
        /// Display name of the action
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The value passed to the action when it ran
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public string? Value { get; set; }

        /// <summary>
        /// ISO 8601 timestamp of when the action was performed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// The queue the item belongs to, if any
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("queue")]
        public global::ModerationAPI.PublicActionPerformedAuthorQueue? Queue { get; set; }

        /// <summary>
        /// The author the action was performed on
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("author")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ModerationAPI.PublicAuthor Author { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicActionPerformedAuthor" /> class.
        /// </summary>
        /// <param name="id">
        /// Moderation action ID
        /// </param>
        /// <param name="createdAt">
        /// ISO 8601 timestamp of when the action was performed
        /// </param>
        /// <param name="author">
        /// The author the action was performed on
        /// </param>
        /// <param name="key">
        /// Customer-defined key identifying this action
        /// </param>
        /// <param name="name">
        /// Display name of the action
        /// </param>
        /// <param name="value">
        /// The value passed to the action when it ran
        /// </param>
        /// <param name="queue">
        /// The queue the item belongs to, if any
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PublicActionPerformedAuthor(
            string id,
            global::System.DateTime createdAt,
            global::ModerationAPI.PublicAuthor author,
            string? key,
            string? name,
            string? value,
            global::ModerationAPI.PublicActionPerformedAuthorQueue? queue)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Key = key;
            this.Name = name;
            this.Value = value;
            this.CreatedAt = createdAt;
            this.Queue = queue;
            this.Author = author ?? throw new global::System.ArgumentNullException(nameof(author));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicActionPerformedAuthor" /> class.
        /// </summary>
        public PublicActionPerformedAuthor()
        {
        }
    }
}