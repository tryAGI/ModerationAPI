
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ResolveQueueItemsRequest
    {
        /// <summary>
        /// The items to resolve, up to 100. Each is the item `id` from `GET /queue/{id}/items`, or the `contentId` you sent to `POST /moderate` (webhooks send it as `item.id`). For a content ID, the newest submission with that content ID is used, as the queue shows it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("itemIds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> ItemIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResolveQueueItemsRequest" /> class.
        /// </summary>
        /// <param name="itemIds">
        /// The items to resolve, up to 100. Each is the item `id` from `GET /queue/{id}/items`, or the `contentId` you sent to `POST /moderate` (webhooks send it as `item.id`). For a content ID, the newest submission with that content ID is used, as the queue shows it.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResolveQueueItemsRequest(
            global::System.Collections.Generic.IList<string> itemIds)
        {
            this.ItemIds = itemIds ?? throw new global::System.ArgumentNullException(nameof(itemIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResolveQueueItemsRequest" /> class.
        /// </summary>
        public ResolveQueueItemsRequest()
        {
        }

    }
}