
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class QueueViewOpenGetQueueResponseQueue
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ModerationAPI.QueueViewOpenGetQueueResponseQueueFilter Filter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unresolvedItemsCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double UnresolvedItemsCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolvedItemsCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ResolvedItemsCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalItemsCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TotalItemsCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QueueViewOpenGetQueueResponseQueue" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="filter"></param>
        /// <param name="unresolvedItemsCount"></param>
        /// <param name="resolvedItemsCount"></param>
        /// <param name="totalItemsCount"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QueueViewOpenGetQueueResponseQueue(
            string id,
            string name,
            string description,
            global::ModerationAPI.QueueViewOpenGetQueueResponseQueueFilter filter,
            double unresolvedItemsCount,
            double resolvedItemsCount,
            double totalItemsCount)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Filter = filter ?? throw new global::System.ArgumentNullException(nameof(filter));
            this.UnresolvedItemsCount = unresolvedItemsCount;
            this.ResolvedItemsCount = resolvedItemsCount;
            this.TotalItemsCount = totalItemsCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueueViewOpenGetQueueResponseQueue" /> class.
        /// </summary>
        public QueueViewOpenGetQueueResponseQueue()
        {
        }
    }
}