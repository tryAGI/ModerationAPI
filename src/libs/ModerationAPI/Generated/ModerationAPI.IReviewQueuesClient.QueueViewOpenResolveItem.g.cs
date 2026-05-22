#nullable enable

namespace ModerationAPI
{
    public partial interface IReviewQueuesClient
    {
        /// <summary>
        /// Resolve a queue item<br/>
        /// Mark a queue item as resolved with a specific moderation action
        /// </summary>
        /// <param name="id">
        /// The queue ID
        /// </param>
        /// <param name="itemId">
        /// The item ID to resolve
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ModerationAPI.ApiException"></exception>
        /// <remarks>
        /// import ModerationAPI from '@moderation-api/sdk';<br/>
        /// const client = new ModerationAPI({<br/>
        ///   secretKey: process.env['MODAPI_SECRET_KEY'], // This is the default and can be omitted<br/>
        /// });<br/>
        /// const response = await client.queue.items.resolve('itemId', { id: 'id' });<br/>
        /// console.log(response.resolvedAt);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::ModerationAPI.QueueViewOpenResolveItemResponse> QueueViewOpenResolveItemAsync(
            string id,
            string itemId,

            global::ModerationAPI.QueueViewOpenResolveItemRequest request,
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Resolve a queue item<br/>
        /// Mark a queue item as resolved with a specific moderation action
        /// </summary>
        /// <param name="id">
        /// The queue ID
        /// </param>
        /// <param name="itemId">
        /// The item ID to resolve
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ModerationAPI.ApiException"></exception>
        /// <remarks>
        /// import ModerationAPI from '@moderation-api/sdk';<br/>
        /// const client = new ModerationAPI({<br/>
        ///   secretKey: process.env['MODAPI_SECRET_KEY'], // This is the default and can be omitted<br/>
        /// });<br/>
        /// const response = await client.queue.items.resolve('itemId', { id: 'id' });<br/>
        /// console.log(response.resolvedAt);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::ModerationAPI.AutoSDKHttpResponse<global::ModerationAPI.QueueViewOpenResolveItemResponse>> QueueViewOpenResolveItemAsResponseAsync(
            string id,
            string itemId,

            global::ModerationAPI.QueueViewOpenResolveItemRequest request,
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Resolve a queue item<br/>
        /// Mark a queue item as resolved with a specific moderation action
        /// </summary>
        /// <param name="id">
        /// The queue ID
        /// </param>
        /// <param name="itemId">
        /// The item ID to resolve
        /// </param>
        /// <param name="comment">
        /// Optional comment
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ModerationAPI.QueueViewOpenResolveItemResponse> QueueViewOpenResolveItemAsync(
            string id,
            string itemId,
            string? comment = default,
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}