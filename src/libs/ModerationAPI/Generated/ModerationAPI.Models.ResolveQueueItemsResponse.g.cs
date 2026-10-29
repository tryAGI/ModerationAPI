
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ResolveQueueItemsResponse
    {
        /// <summary>
        /// Number of items resolved.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolved")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Resolved { get; set; }

        /// <summary>
        /// IDs from `itemIds` that match no item or content ID in the project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("notFoundIds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> NotFoundIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResolveQueueItemsResponse" /> class.
        /// </summary>
        /// <param name="resolved">
        /// Number of items resolved.
        /// </param>
        /// <param name="notFoundIds">
        /// IDs from `itemIds` that match no item or content ID in the project.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResolveQueueItemsResponse(
            int resolved,
            global::System.Collections.Generic.IList<string> notFoundIds)
        {
            this.Resolved = resolved;
            this.NotFoundIds = notFoundIds ?? throw new global::System.ArgumentNullException(nameof(notFoundIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResolveQueueItemsResponse" /> class.
        /// </summary>
        public ResolveQueueItemsResponse()
        {
        }

    }
}