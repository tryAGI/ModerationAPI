#nullable enable

namespace ModerationAPI
{
    public partial interface IReviewQueuesClient
    {
        /// <summary>
        /// Unresolve a queue item<br/>
        /// Mark a resolved item of a queue as pending again. It is the same as removing a check-off in the dashboard: the item comes back in the pending list.
        /// </summary>
        /// <param name="id">
        /// The queue ID.
        /// </param>
        /// <param name="itemId">
        /// The item ID to unresolve.
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
        ///   const result = await moderationApi.queue.items.unresolve("&lt;id&gt;", "&lt;id&gt;");<br/>
        ///   console.log(result);<br/>
        /// }<br/>
        /// run();
        /// </remarks>
        global::System.Threading.Tasks.Task<global::ModerationAPI.QueueViewOpenUnresolveItemResponse> QueueViewOpenUnresolveItemAsync(
            string id,
            string itemId,
            string? projectId = default,
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Unresolve a queue item<br/>
        /// Mark a resolved item of a queue as pending again. It is the same as removing a check-off in the dashboard: the item comes back in the pending list.
        /// </summary>
        /// <param name="id">
        /// The queue ID.
        /// </param>
        /// <param name="itemId">
        /// The item ID to unresolve.
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
        ///   const result = await moderationApi.queue.items.unresolve("&lt;id&gt;", "&lt;id&gt;");<br/>
        ///   console.log(result);<br/>
        /// }<br/>
        /// run();
        /// </remarks>
        global::System.Threading.Tasks.Task<global::ModerationAPI.AutoSDKHttpResponse<global::ModerationAPI.QueueViewOpenUnresolveItemResponse>> QueueViewOpenUnresolveItemAsResponseAsync(
            string id,
            string itemId,
            string? projectId = default,
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}