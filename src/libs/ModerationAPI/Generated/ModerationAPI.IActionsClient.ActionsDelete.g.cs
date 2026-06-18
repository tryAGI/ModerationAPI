#nullable enable

namespace ModerationAPI
{
    public partial interface IActionsClient
    {
        /// <summary>
        /// Delete an action<br/>
        /// Delete an action and all of its webhooks.
        /// </summary>
        /// <param name="id">
        /// The ID of the action to delete.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ModerationAPI.ApiException"></exception>
        /// <remarks>
        /// using System;<br/>
        /// using ModerationApi;<br/>
        /// using ModerationApi.Models.Actions;<br/>
        /// ModerationApiClient client = new();<br/>
        /// ActionDeleteParams parameters = new() { ID = "id" };<br/>
        /// var action = await client.Actions.Delete(parameters);<br/>
        /// Console.WriteLine(action);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::ModerationAPI.ActionsDeleteResponse> ActionsDeleteAsync(
            string id,
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete an action<br/>
        /// Delete an action and all of its webhooks.
        /// </summary>
        /// <param name="id">
        /// The ID of the action to delete.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ModerationAPI.ApiException"></exception>
        /// <remarks>
        /// using System;<br/>
        /// using ModerationApi;<br/>
        /// using ModerationApi.Models.Actions;<br/>
        /// ModerationApiClient client = new();<br/>
        /// ActionDeleteParams parameters = new() { ID = "id" };<br/>
        /// var action = await client.Actions.Delete(parameters);<br/>
        /// Console.WriteLine(action);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::ModerationAPI.AutoSDKHttpResponse<global::ModerationAPI.ActionsDeleteResponse>> ActionsDeleteAsResponseAsync(
            string id,
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}