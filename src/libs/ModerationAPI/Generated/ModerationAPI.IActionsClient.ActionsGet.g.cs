#nullable enable

namespace ModerationAPI
{
    public partial interface IActionsClient
    {
        /// <summary>
        /// Get an action<br/>
        /// Get an action by ID.
        /// </summary>
        /// <param name="id">
        /// The ID of the action to get.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ModerationAPI.ApiException"></exception>
        /// <remarks>
        /// using System;<br/>
        /// using ModerationApi;<br/>
        /// using ModerationApi.Models.Actions;<br/>
        /// ModerationApiClient client = new();<br/>
        /// ActionRetrieveParams parameters = new() { ID = "id" };<br/>
        /// var action = await client.Actions.Retrieve(parameters);<br/>
        /// Console.WriteLine(action);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::ModerationAPI.ActionsGetResponse> ActionsGetAsync(
            string id,
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get an action<br/>
        /// Get an action by ID.
        /// </summary>
        /// <param name="id">
        /// The ID of the action to get.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ModerationAPI.ApiException"></exception>
        /// <remarks>
        /// using System;<br/>
        /// using ModerationApi;<br/>
        /// using ModerationApi.Models.Actions;<br/>
        /// ModerationApiClient client = new();<br/>
        /// ActionRetrieveParams parameters = new() { ID = "id" };<br/>
        /// var action = await client.Actions.Retrieve(parameters);<br/>
        /// Console.WriteLine(action);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::ModerationAPI.AutoSDKHttpResponse<global::ModerationAPI.ActionsGetResponse>> ActionsGetAsResponseAsync(
            string id,
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}