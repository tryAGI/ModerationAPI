#nullable enable

namespace ModerationAPI
{
    public partial interface IContentClient
    {
        /// <summary>
        /// Allow content<br/>
        /// Allow a content item with the built-in allow action, and resolve it in the review queue.
        /// </summary>
        /// <param name="id">
        /// The content ID you sent when you submitted the content, or the ID Moderation API assigned.
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
        ///   const result = await moderationApi.content.allow("&lt;id&gt;", {});<br/>
        ///   console.log(result);<br/>
        /// }<br/>
        /// run();
        /// </remarks>
        global::System.Threading.Tasks.Task<global::ModerationAPI.AllowContentResponse> AllowAsync(
            string id,

            global::ModerationAPI.AllowContentRequest request,
            string? projectId = default,
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Allow content<br/>
        /// Allow a content item with the built-in allow action, and resolve it in the review queue.
        /// </summary>
        /// <param name="id">
        /// The content ID you sent when you submitted the content, or the ID Moderation API assigned.
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
        ///   const result = await moderationApi.content.allow("&lt;id&gt;", {});<br/>
        ///   console.log(result);<br/>
        /// }<br/>
        /// run();
        /// </remarks>
        global::System.Threading.Tasks.Task<global::ModerationAPI.AutoSDKHttpResponse<global::ModerationAPI.AllowContentResponse>> AllowAsResponseAsync(
            string id,

            global::ModerationAPI.AllowContentRequest request,
            string? projectId = default,
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Allow content<br/>
        /// Allow a content item with the built-in allow action, and resolve it in the review queue.
        /// </summary>
        /// <param name="id">
        /// The content ID you sent when you submitted the content, or the ID Moderation API assigned.
        /// </param>
        /// <param name="projectId"></param>
        /// <param name="reason">
        /// Why the action was taken. Saved with the action and sent in the webhook event.
        /// </param>
        /// <param name="queueId">
        /// The queue the content is reviewed in. Defaults to the project's default queue.
        /// </param>
        /// <param name="moderator">
        /// The user ID or email of the organization member who made the decision. The action is recorded as theirs.
        /// </param>
        /// <param name="createCasebookCase">
        /// Record an allow or reject decision as a casebook case. Defaults to true when `moderator` is set, else false. Without `moderator`, the case is recorded as System.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ModerationAPI.AllowContentResponse> AllowAsync(
            string id,
            string? projectId = default,
            string? reason = default,
            string? queueId = default,
            string? moderator = default,
            bool? createCasebookCase = default,
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}