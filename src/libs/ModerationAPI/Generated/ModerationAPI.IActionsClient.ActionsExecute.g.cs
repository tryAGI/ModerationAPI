#nullable enable

namespace ModerationAPI
{
    public partial interface IActionsClient
    {
        /// <summary>
        /// Execute moderation action<br/>
        /// Execute a moderation action on one or more content items.
        /// </summary>
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
        ///   const result = await moderationApi.actions.execute({<br/>
        ///     body: {<br/>
        ///       actionKey: "suspend-24h",<br/>
        ///       authorIds: [<br/>
        ///         "user-1092",<br/>
        ///       ],<br/>
        ///     },<br/>
        ///   });<br/>
        ///   console.log(result);<br/>
        /// }<br/>
        /// run();
        /// </remarks>
        global::System.Threading.Tasks.Task<global::ModerationAPI.ActionsExecuteResponse> ActionsExecuteAsync(

            global::ModerationAPI.ActionsExecuteRequest request,
            string? projectId = default,
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Execute moderation action<br/>
        /// Execute a moderation action on one or more content items.
        /// </summary>
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
        ///   const result = await moderationApi.actions.execute({<br/>
        ///     body: {<br/>
        ///       actionKey: "suspend-24h",<br/>
        ///       authorIds: [<br/>
        ///         "user-1092",<br/>
        ///       ],<br/>
        ///     },<br/>
        ///   });<br/>
        ///   console.log(result);<br/>
        /// }<br/>
        /// run();
        /// </remarks>
        global::System.Threading.Tasks.Task<global::ModerationAPI.AutoSDKHttpResponse<global::ModerationAPI.ActionsExecuteResponse>> ActionsExecuteAsResponseAsync(

            global::ModerationAPI.ActionsExecuteRequest request,
            string? projectId = default,
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Execute moderation action<br/>
        /// Execute a moderation action on one or more content items.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="actionKey">
        /// ID or key of the action to execute
        /// </param>
        /// <param name="contentIds">
        /// IDs of the content items to apply the action to. Provide this or authorIds.
        /// </param>
        /// <param name="authorIds">
        /// IDs of the authors to apply the action to. Provide this or contentIds.
        /// </param>
        /// <param name="value">
        /// Optional value to provide with the action
        /// </param>
        /// <param name="queueId">
        /// Optional queue ID if the action is queue-specific
        /// </param>
        /// <param name="duration">
        /// Optional duration in milliseconds for actions with timeouts
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ModerationAPI.ActionsExecuteResponse> ActionsExecuteAsync(
            string actionKey,
            string? projectId = default,
            global::System.Collections.Generic.IList<string>? contentIds = default,
            global::System.Collections.Generic.IList<string>? authorIds = default,
            string? value = default,
            string? queueId = default,
            double? duration = default,
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}