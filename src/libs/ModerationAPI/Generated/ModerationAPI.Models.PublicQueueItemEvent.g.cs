
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PublicQueueItemEvent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ModerationAPI.PublicQueueItem Item { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("author")]
        public global::ModerationAPI.PublicAuthor? Author { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("queue")]
        public global::ModerationAPI.PublicQueueItemEventQueue? Queue { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicQueueItemEvent" /> class.
        /// </summary>
        /// <param name="item"></param>
        /// <param name="author"></param>
        /// <param name="queue"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PublicQueueItemEvent(
            global::ModerationAPI.PublicQueueItem item,
            global::ModerationAPI.PublicAuthor? author,
            global::ModerationAPI.PublicQueueItemEventQueue? queue)
        {
            this.Item = item ?? throw new global::System.ArgumentNullException(nameof(item));
            this.Author = author;
            this.Queue = queue;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicQueueItemEvent" /> class.
        /// </summary>
        public PublicQueueItemEvent()
        {
        }

    }
}