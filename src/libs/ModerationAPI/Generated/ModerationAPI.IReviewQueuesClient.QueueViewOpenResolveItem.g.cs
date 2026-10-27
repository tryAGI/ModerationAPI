#nullable enable

namespace ModerationAPI
{
    public partial interface IReviewQueuesClient
    {
        /// <summary>
        /// Resolve a queue item<br/>
        /// Mark an item of a queue as resolved. It is the same as a check-off in the dashboard: the item leaves the pending list and a QUEUE_ITEM_COMPLETED webhook is sent. To also take a moderation action, use `POST /actions/execute`.
        /// </summary>
        /// <param name="id">
        /// The queue ID.
        /// </param>
        /// <param name="itemId">
        /// The item ID to resolve.
        /// </param>
        /// <param name="projectId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ModerationAPI.ApiException"></exception>
        /// <remarks>
        /// import { ModerationApi } from "@moderation-api/sdk";<br/>
        /// const moderationApi = new ModerationApi({<br/>
        ///   secretKey: process.env["MODAPI_SECRET_KEY"] ?? "",<br/>
        /// });<br/>
        /// async function run() {<br/>
        ///   const result = await moderationApi.queue.items.resolve({<br/>
        ///     id: "&lt;id&gt;",<br/>
        ///     itemId: "&lt;id&gt;",<br/>
        ///   });<br/>
        ///   console.log(result);<br/>
        /// }<br/>
        /// run();
        /// </remarks>
        global::System.Threading.Tasks.Task<global::ModerationAPI.QueueViewOpenResolveItemResponse> QueueViewOpenResolveItemAsync(
            string id,
            string itemId,
            string? projectId = default,
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Resolve a queue item<br/>
        /// Mark an item of a queue as resolved. It is the same as a check-off in the dashboard: the item leaves the pending list and a QUEUE_ITEM_COMPLETED webhook is sent. To also take a moderation action, use `POST /actions/execute`.
        /// </summary>
        /// <param name="id">
        /// The queue ID.
        /// </param>
        /// <param name="itemId">
        /// The item ID to resolve.
        /// </param>
        /// <param name="projectId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ModerationAPI.ApiException"></exception>
        /// <remarks>
        /// import { ModerationApi } from "@moderation-api/sdk";<br/>
        /// const moderationApi = new ModerationApi({<br/>
        ///   secretKey: process.env["MODAPI_SECRET_KEY"] ?? "",<br/>
        /// });<br/>
        /// async function run() {<br/>
        ///   const result = await moderationApi.queue.items.resolve({<br/>
        ///     id: "&lt;id&gt;",<br/>
        ///     itemId: "&lt;id&gt;",<br/>
        ///   });<br/>
        ///   console.log(result);<br/>
        /// }<br/>
        /// run();
        /// </remarks>
        global::System.Threading.Tasks.Task<global::ModerationAPI.AutoSDKHttpResponse<global::ModerationAPI.QueueViewOpenResolveItemResponse>> QueueViewOpenResolveItemAsResponseAsync(
            string id,
            string itemId,
            string? projectId = default,
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}