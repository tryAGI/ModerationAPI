#nullable enable

namespace ModerationAPI
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// List projects<br/>
        /// List the projects in the organization. The list is paginated. Needs the `projects:read` permission.
        /// </summary>
        /// <param name="page">
        /// Page number, starting at 1.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="pageSize">
        /// Number of items per page. Maximum 100.<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ModerationAPI.ApiException"></exception>
        /// <remarks>
        /// import { ModerationApi } from "@moderation-api/sdk";<br/>
        /// const moderationApi = new ModerationApi({<br/>
        ///   secretKey: process.env["MODAPI_SECRET_KEY"] ?? "",<br/>
        /// });<br/>
        /// async function run() {<br/>
        ///   const result = await moderationApi.projects.list();<br/>
        ///   for await (const page of result) {<br/>
        ///     console.log(page);<br/>
        ///   }<br/>
        /// }<br/>
        /// run();
        /// </remarks>
        global::System.Threading.Tasks.Task<global::ModerationAPI.ManagementProjectsListResponse> ManagementProjectsListAsync(
            int? page = default,
            int? pageSize = default,
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List projects<br/>
        /// List the projects in the organization. The list is paginated. Needs the `projects:read` permission.
        /// </summary>
        /// <param name="page">
        /// Page number, starting at 1.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="pageSize">
        /// Number of items per page. Maximum 100.<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ModerationAPI.ApiException"></exception>
        /// <remarks>
        /// import { ModerationApi } from "@moderation-api/sdk";<br/>
        /// const moderationApi = new ModerationApi({<br/>
        ///   secretKey: process.env["MODAPI_SECRET_KEY"] ?? "",<br/>
        /// });<br/>
        /// async function run() {<br/>
        ///   const result = await moderationApi.projects.list();<br/>
        ///   for await (const page of result) {<br/>
        ///     console.log(page);<br/>
        ///   }<br/>
        /// }<br/>
        /// run();
        /// </remarks>
        global::System.Threading.Tasks.Task<global::ModerationAPI.AutoSDKHttpResponse<global::ModerationAPI.ManagementProjectsListResponse>> ManagementProjectsListAsResponseAsync(
            int? page = default,
            int? pageSize = default,
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}