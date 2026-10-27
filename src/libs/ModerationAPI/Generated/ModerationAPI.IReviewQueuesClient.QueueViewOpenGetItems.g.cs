#nullable enable

namespace ModerationAPI
{
    public partial interface IReviewQueuesClient
    {
        /// <summary>
        /// List queue items<br/>
        /// List the items of a review queue, with the filters and the date window of the queue applied. By default only pending items. The list is paginated. Use the item `id` to resolve or unresolve an item.
        /// </summary>
        /// <param name="id">
        /// The queue ID.
        /// </param>
        /// <param name="page">
        /// Page number, starting at 1.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="pageSize">
        /// Number of items per page. Maximum 100.<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="sort"></param>
        /// <param name="includeResolved"></param>
        /// <param name="conversationIds"></param>
        /// <param name="labels"></param>
        /// <param name="authorId"></param>
        /// <param name="filteredActionIds"></param>
        /// <param name="afterDate"></param>
        /// <param name="beforeDate"></param>
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
        ///   const result = await moderationApi.queue.items.list({<br/>
        ///     id: "&lt;id&gt;",<br/>
        ///   });<br/>
        ///   for await (const page of result) {<br/>
        ///     console.log(page);<br/>
        ///   }<br/>
        /// }<br/>
        /// run();
        /// </remarks>
        global::System.Threading.Tasks.Task<global::ModerationAPI.QueueViewOpenGetItemsResponse> QueueViewOpenGetItemsAsync(
            string id,
            int? page = default,
            int? pageSize = default,
            global::ModerationAPI.QueueViewOpenGetItemsSort? sort = default,
            bool? includeResolved = default,
            global::System.Collections.Generic.IList<string>? conversationIds = default,
            global::System.Collections.Generic.IList<string>? labels = default,
            string? authorId = default,
            global::System.Collections.Generic.IList<string>? filteredActionIds = default,
            string? afterDate = default,
            string? beforeDate = default,
            string? projectId = default,
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List queue items<br/>
        /// List the items of a review queue, with the filters and the date window of the queue applied. By default only pending items. The list is paginated. Use the item `id` to resolve or unresolve an item.
        /// </summary>
        /// <param name="id">
        /// The queue ID.
        /// </param>
        /// <param name="page">
        /// Page number, starting at 1.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="pageSize">
        /// Number of items per page. Maximum 100.<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="sort"></param>
        /// <param name="includeResolved"></param>
        /// <param name="conversationIds"></param>
        /// <param name="labels"></param>
        /// <param name="authorId"></param>
        /// <param name="filteredActionIds"></param>
        /// <param name="afterDate"></param>
        /// <param name="beforeDate"></param>
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
        ///   const result = await moderationApi.queue.items.list({<br/>
        ///     id: "&lt;id&gt;",<br/>
        ///   });<br/>
        ///   for await (const page of result) {<br/>
        ///     console.log(page);<br/>
        ///   }<br/>
        /// }<br/>
        /// run();
        /// </remarks>
        global::System.Threading.Tasks.Task<global::ModerationAPI.AutoSDKHttpResponse<global::ModerationAPI.QueueViewOpenGetItemsResponse>> QueueViewOpenGetItemsAsResponseAsync(
            string id,
            int? page = default,
            int? pageSize = default,
            global::ModerationAPI.QueueViewOpenGetItemsSort? sort = default,
            bool? includeResolved = default,
            global::System.Collections.Generic.IList<string>? conversationIds = default,
            global::System.Collections.Generic.IList<string>? labels = default,
            string? authorId = default,
            global::System.Collections.Generic.IList<string>? filteredActionIds = default,
            string? afterDate = default,
            string? beforeDate = default,
            string? projectId = default,
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}