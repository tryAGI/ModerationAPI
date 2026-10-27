#nullable enable

namespace ModerationAPI
{
    public partial interface IAuthorClient
    {
        /// <summary>
        /// List authors<br/>
        /// List the authors of the project, with their status, trust level and content metrics. The list is paginated. By default, the authors that were active most recently come first.
        /// </summary>
        /// <param name="page">
        /// Page number, starting at 1.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="pageSize">
        /// Number of items per page. Maximum 100.<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="sortBy"></param>
        /// <param name="sortDirection">
        /// Sort direction<br/>
        /// Default Value: desc
        /// </param>
        /// <param name="memberSinceDate"></param>
        /// <param name="lastActiveDate"></param>
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
        ///   const result = await moderationApi.authors.list({});<br/>
        ///   for await (const page of result) {<br/>
        ///     console.log(page);<br/>
        ///   }<br/>
        /// }<br/>
        /// run();
        /// </remarks>
        global::System.Threading.Tasks.Task<global::ModerationAPI.AuthorOpenListAuthorsResponse> AuthorOpenListAuthorsAsync(
            int? page = default,
            int? pageSize = default,
            global::ModerationAPI.AuthorOpenListAuthorsSortBy? sortBy = default,
            global::ModerationAPI.AuthorOpenListAuthorsSortDirection? sortDirection = default,
            string? memberSinceDate = default,
            string? lastActiveDate = default,
            string? projectId = default,
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List authors<br/>
        /// List the authors of the project, with their status, trust level and content metrics. The list is paginated. By default, the authors that were active most recently come first.
        /// </summary>
        /// <param name="page">
        /// Page number, starting at 1.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="pageSize">
        /// Number of items per page. Maximum 100.<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="sortBy"></param>
        /// <param name="sortDirection">
        /// Sort direction<br/>
        /// Default Value: desc
        /// </param>
        /// <param name="memberSinceDate"></param>
        /// <param name="lastActiveDate"></param>
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
        ///   const result = await moderationApi.authors.list({});<br/>
        ///   for await (const page of result) {<br/>
        ///     console.log(page);<br/>
        ///   }<br/>
        /// }<br/>
        /// run();
        /// </remarks>
        global::System.Threading.Tasks.Task<global::ModerationAPI.AutoSDKHttpResponse<global::ModerationAPI.AuthorOpenListAuthorsResponse>> AuthorOpenListAuthorsAsResponseAsync(
            int? page = default,
            int? pageSize = default,
            global::ModerationAPI.AuthorOpenListAuthorsSortBy? sortBy = default,
            global::ModerationAPI.AuthorOpenListAuthorsSortDirection? sortDirection = default,
            string? memberSinceDate = default,
            string? lastActiveDate = default,
            string? projectId = default,
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}