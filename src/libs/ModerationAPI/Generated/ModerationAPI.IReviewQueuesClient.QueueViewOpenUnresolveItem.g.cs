#nullable enable

namespace ModerationAPI
{
    public partial interface IReviewQueuesClient
    {
        /// <summary>
        /// Unresolve a queue item<br/>
        /// Mark a previously resolved queue item as unresolved/pending
        /// </summary>
        /// <param name="id">
        /// The queue ID
        /// </param>
        /// <param name="itemId">
        /// The item ID to unresolve
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ModerationAPI.ApiException"></exception>
        /// <remarks>
        /// import ModerationAPI from '@moderation-api/sdk';<br/>
        /// const client = new ModerationAPI({<br/>
        ///   secretKey: process.env['MODAPI_SECRET_KEY'], // This is the default and can be omitted<br/>
        /// });<br/>
        /// const response = await client.queue.items.unresolve('itemId', { id: 'id' });<br/>
        /// console.log(response.status);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::ModerationAPI.QueueViewOpenUnresolveItemResponse> QueueViewOpenUnresolveItemAsync(
            string id,
            string itemId,

            global::ModerationAPI.QueueViewOpenUnresolveItemRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Unresolve a queue item<br/>
        /// Mark a previously resolved queue item as unresolved/pending
        /// </summary>
        /// <param name="id">
        /// The queue ID
        /// </param>
        /// <param name="itemId">
        /// The item ID to unresolve
        /// </param>
        /// <param name="comment">
        /// Optional reason for unresolving the item
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ModerationAPI.QueueViewOpenUnresolveItemResponse> QueueViewOpenUnresolveItemAsync(
            string id,
            string itemId,
            string? comment = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}