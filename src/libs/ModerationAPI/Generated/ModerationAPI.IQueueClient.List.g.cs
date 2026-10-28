#nullable enable

namespace ModerationAPI
{
    public partial interface IQueueClient
    {
        /// <summary>
        /// List queues<br/>
        /// List the review queues of the project. The default queue comes first. The list is paginated. To get the item counts of a queue, use `GET /queue/{id}`.
        /// </summary>
        /// <param name="page">
        /// Page number, starting at 1.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="pageSize">
        /// Number of items per page. Maximum 100.<br/>
        /// Default Value: 20
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
        ///   const result = await moderationApi.queue.list();<br/>
        ///   for await (const page of result) {<br/>
        ///     console.log(page);<br/>
        ///   }<br/>
        /// }<br/>
        /// run();
        /// </remarks>
        global::System.Threading.Tasks.Task<global::ModerationAPI.ListQueuesResponse> ListAsync(
            int? page = default,
            int? pageSize = default,
            string? projectId = default,
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List queues<br/>
        /// List the review queues of the project. The default queue comes first. The list is paginated. To get the item counts of a queue, use `GET /queue/{id}`.
        /// </summary>
        /// <param name="page">
        /// Page number, starting at 1.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="pageSize">
        /// Number of items per page. Maximum 100.<br/>
        /// Default Value: 20
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
        ///   const result = await moderationApi.queue.list();<br/>
        ///   for await (const page of result) {<br/>
        ///     console.log(page);<br/>
        ///   }<br/>
        /// }<br/>
        /// run();
        /// </remarks>
        global::System.Threading.Tasks.Task<global::ModerationAPI.AutoSDKHttpResponse<global::ModerationAPI.ListQueuesResponse>> ListAsResponseAsync(
            int? page = default,
            int? pageSize = default,
            string? projectId = default,
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}