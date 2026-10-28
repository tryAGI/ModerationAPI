#nullable enable

namespace ModerationAPI
{
    public partial interface IQueueItemsClient
    {
        /// <summary>
        /// Resolve queue items<br/>
        /// Mark up to 100 items of a queue as resolved in one request. Each item is resolved the same as with `POST /queue/{id}/items/{itemId}/resolve`. IDs that do not exist in the project are skipped and returned in `notFoundIds`.
        /// </summary>
        /// <param name="id">
        /// The queue ID.
        /// </param>
        /// <param name="projectId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ModerationAPI.ApiException"></exception>
        /// <remarks>
        /// import { ModerationApi } from "@moderation-api/sdk";<br/>
        /// const moderationApi = new ModerationApi({<br/>
        ///   secretKey: process.env["MODAPI_SECRET_KEY"] ?? "",<br/>
        /// });<br/>
        /// async function run() {<br/>
        ///   const result = await moderationApi.queue.items.resolveMany("&lt;id&gt;", {<br/>
        ///     itemIds: [<br/>
        ///       "clx8k2v0e000108l4a9bz3f7q",<br/>
        ///       "clx8k2v0e000208l4h2mc6d1r",<br/>
        ///     ],<br/>
        ///   });<br/>
        ///   console.log(result);<br/>
        /// }<br/>
        /// run();
        /// </remarks>
        global::System.Threading.Tasks.Task<global::ModerationAPI.ResolveQueueItemsResponse> ResolveManyAsync(
            string id,

            global::ModerationAPI.ResolveQueueItemsRequest request,
            string? projectId = default,
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Resolve queue items<br/>
        /// Mark up to 100 items of a queue as resolved in one request. Each item is resolved the same as with `POST /queue/{id}/items/{itemId}/resolve`. IDs that do not exist in the project are skipped and returned in `notFoundIds`.
        /// </summary>
        /// <param name="id">
        /// The queue ID.
        /// </param>
        /// <param name="projectId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ModerationAPI.ApiException"></exception>
        /// <remarks>
        /// import { ModerationApi } from "@moderation-api/sdk";<br/>
        /// const moderationApi = new ModerationApi({<br/>
        ///   secretKey: process.env["MODAPI_SECRET_KEY"] ?? "",<br/>
        /// });<br/>
        /// async function run() {<br/>
        ///   const result = await moderationApi.queue.items.resolveMany("&lt;id&gt;", {<br/>
        ///     itemIds: [<br/>
        ///       "clx8k2v0e000108l4a9bz3f7q",<br/>
        ///       "clx8k2v0e000208l4h2mc6d1r",<br/>
        ///     ],<br/>
        ///   });<br/>
        ///   console.log(result);<br/>
        /// }<br/>
        /// run();
        /// </remarks>
        global::System.Threading.Tasks.Task<global::ModerationAPI.AutoSDKHttpResponse<global::ModerationAPI.ResolveQueueItemsResponse>> ResolveManyAsResponseAsync(
            string id,

            global::ModerationAPI.ResolveQueueItemsRequest request,
            string? projectId = default,
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Resolve queue items<br/>
        /// Mark up to 100 items of a queue as resolved in one request. Each item is resolved the same as with `POST /queue/{id}/items/{itemId}/resolve`. IDs that do not exist in the project are skipped and returned in `notFoundIds`.
        /// </summary>
        /// <param name="id">
        /// The queue ID.
        /// </param>
        /// <param name="projectId"></param>
        /// <param name="itemIds">
        /// The item IDs to resolve. Up to 100.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ModerationAPI.ResolveQueueItemsResponse> ResolveManyAsync(
            string id,
            global::System.Collections.Generic.IList<string> itemIds,
            string? projectId = default,
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}