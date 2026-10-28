#nullable enable

namespace ModerationAPI
{
    public partial interface IAuthorsClient
    {
        /// <summary>
        /// Block author<br/>
        /// Block an author with the built-in block action. A blocked author cannot post new content until unblocked.
        /// </summary>
        /// <param name="id">
        /// Either external ID or the ID assigned by moderation API.
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
        ///   const result = await moderationApi.authors.block("&lt;id&gt;", {});<br/>
        ///   console.log(result);<br/>
        /// }<br/>
        /// run();
        /// </remarks>
        global::System.Threading.Tasks.Task<global::ModerationAPI.BlockAuthorResponse> BlockAsync(
            string id,

            global::ModerationAPI.BlockAuthorRequest request,
            string? projectId = default,
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Block author<br/>
        /// Block an author with the built-in block action. A blocked author cannot post new content until unblocked.
        /// </summary>
        /// <param name="id">
        /// Either external ID or the ID assigned by moderation API.
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
        ///   const result = await moderationApi.authors.block("&lt;id&gt;", {});<br/>
        ///   console.log(result);<br/>
        /// }<br/>
        /// run();
        /// </remarks>
        global::System.Threading.Tasks.Task<global::ModerationAPI.AutoSDKHttpResponse<global::ModerationAPI.BlockAuthorResponse>> BlockAsResponseAsync(
            string id,

            global::ModerationAPI.BlockAuthorRequest request,
            string? projectId = default,
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Block author<br/>
        /// Block an author with the built-in block action. A blocked author cannot post new content until unblocked.
        /// </summary>
        /// <param name="id">
        /// Either external ID or the ID assigned by moderation API.
        /// </param>
        /// <param name="projectId"></param>
        /// <param name="reason">
        /// Why the action was taken. Saved with the action and sent in the webhook event.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ModerationAPI.BlockAuthorResponse> BlockAsync(
            string id,
            string? projectId = default,
            string? reason = default,
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}