#nullable enable

namespace ModerationAPI
{
    public partial interface IActionsClient
    {
        /// <summary>
        /// List moderation actions<br/>
        /// List all available moderation actions for the authenticated organization.
        /// </summary>
        /// <param name="queueId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ModerationAPI.ApiException"></exception>
        /// <remarks>
        /// using System;<br/>
        /// using ModerationApi;<br/>
        /// using ModerationApi.Models.Actions;<br/>
        /// ModerationApiClient client = new();<br/>
        /// ActionListParams parameters = new();<br/>
        /// var actions = await client.Actions.List(parameters);<br/>
        /// Console.WriteLine(actions);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::ModerationAPI.ActionsListResponseItem>> ActionsListAsync(
            string? queueId = default,
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List moderation actions<br/>
        /// List all available moderation actions for the authenticated organization.
        /// </summary>
        /// <param name="queueId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ModerationAPI.ApiException"></exception>
        /// <remarks>
        /// using System;<br/>
        /// using ModerationApi;<br/>
        /// using ModerationApi.Models.Actions;<br/>
        /// ModerationApiClient client = new();<br/>
        /// ActionListParams parameters = new();<br/>
        /// var actions = await client.Actions.List(parameters);<br/>
        /// Console.WriteLine(actions);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::ModerationAPI.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::ModerationAPI.ActionsListResponseItem>>> ActionsListAsResponseAsync(
            string? queueId = default,
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}