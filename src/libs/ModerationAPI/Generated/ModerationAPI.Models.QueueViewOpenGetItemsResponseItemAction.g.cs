
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class QueueViewOpenGetItemsResponseItemAction
    {
        /// <summary>
        /// Action ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Action name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Action comment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("comment")]
        public string? Comment { get; set; }

        /// <summary>
        /// Unix timestamp of when the action was taken
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Timestamp { get; set; }

        /// <summary>
        /// Moderator userID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reviewer")]
        public string? Reviewer { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QueueViewOpenGetItemsResponseItemAction" /> class.
        /// </summary>
        /// <param name="id">
        /// Action ID
        /// </param>
        /// <param name="name">
        /// Action name
        /// </param>
        /// <param name="timestamp">
        /// Unix timestamp of when the action was taken
        /// </param>
        /// <param name="comment">
        /// Action comment
        /// </param>
        /// <param name="reviewer">
        /// Moderator userID
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QueueViewOpenGetItemsResponseItemAction(
            string id,
            string name,
            double timestamp,
            string? comment,
            string? reviewer)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Comment = comment;
            this.Timestamp = timestamp;
            this.Reviewer = reviewer;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueueViewOpenGetItemsResponseItemAction" /> class.
        /// </summary>
        public QueueViewOpenGetItemsResponseItemAction()
        {
        }
    }
}