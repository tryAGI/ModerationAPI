
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class QueueWithCounts
    {
        /// <summary>
        /// The queue ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The queue name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The queue description.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Whether this is the default queue of the project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isDefault")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsDefault { get; set; }

        /// <summary>
        /// Number of items that wait for review.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unresolvedItemsCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int UnresolvedItemsCount { get; set; }

        /// <summary>
        /// Number of items that are resolved.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolvedItemsCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ResolvedItemsCount { get; set; }

        /// <summary>
        /// Number of items in the queue, resolved and unresolved.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalItemsCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalItemsCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QueueWithCounts" /> class.
        /// </summary>
        /// <param name="id">
        /// The queue ID.
        /// </param>
        /// <param name="name">
        /// The queue name.
        /// </param>
        /// <param name="isDefault">
        /// Whether this is the default queue of the project.
        /// </param>
        /// <param name="unresolvedItemsCount">
        /// Number of items that wait for review.
        /// </param>
        /// <param name="resolvedItemsCount">
        /// Number of items that are resolved.
        /// </param>
        /// <param name="totalItemsCount">
        /// Number of items in the queue, resolved and unresolved.
        /// </param>
        /// <param name="description">
        /// The queue description.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QueueWithCounts(
            string id,
            string name,
            bool isDefault,
            int unresolvedItemsCount,
            int resolvedItemsCount,
            int totalItemsCount,
            string? description)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.IsDefault = isDefault;
            this.UnresolvedItemsCount = unresolvedItemsCount;
            this.ResolvedItemsCount = resolvedItemsCount;
            this.TotalItemsCount = totalItemsCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueueWithCounts" /> class.
        /// </summary>
        public QueueWithCounts()
        {
        }

    }
}