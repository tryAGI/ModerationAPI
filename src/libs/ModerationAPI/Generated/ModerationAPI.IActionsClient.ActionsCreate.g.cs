#nullable enable

namespace ModerationAPI
{
    public partial interface IActionsClient
    {
        /// <summary>
        /// Create an action<br/>
        /// Create an action.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ModerationAPI.ApiException"></exception>
        /// <remarks>
        /// using System;<br/>
        /// using ModerationApi;<br/>
        /// using ModerationApi.Models.Actions;<br/>
        /// ModerationApiClient client = new();<br/>
        /// ActionCreateParams parameters = new() { Name = "name" };<br/>
        /// var action = await client.Actions.Create(parameters);<br/>
        /// Console.WriteLine(action);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::ModerationAPI.ActionsCreateResponse> ActionsCreateAsync(

            global::ModerationAPI.ActionsCreateRequest request,
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an action<br/>
        /// Create an action.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ModerationAPI.ApiException"></exception>
        /// <remarks>
        /// using System;<br/>
        /// using ModerationApi;<br/>
        /// using ModerationApi.Models.Actions;<br/>
        /// ModerationApiClient client = new();<br/>
        /// ActionCreateParams parameters = new() { Name = "name" };<br/>
        /// var action = await client.Actions.Create(parameters);<br/>
        /// Console.WriteLine(action);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::ModerationAPI.AutoSDKHttpResponse<global::ModerationAPI.ActionsCreateResponse>> ActionsCreateAsResponseAsync(

            global::ModerationAPI.ActionsCreateRequest request,
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an action<br/>
        /// Create an action.
        /// </summary>
        /// <param name="key">
        /// User defined key of the action.
        /// </param>
        /// <param name="name">
        /// The name of the action.
        /// </param>
        /// <param name="description">
        /// The description of the action.
        /// </param>
        /// <param name="type">
        /// The type of the action.
        /// </param>
        /// <param name="builtIn">
        /// Whether the action is a built-in action or a custom one.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="queueBehaviour">
        /// Whether the action resolves and removes the item, unresolves and re-add it to the queue, or does not change the resolve status.<br/>
        /// Default Value: NO_CHANGE
        /// </param>
        /// <param name="filterInQueueIds">
        /// The IDs of the queues the action is available in.<br/>
        /// Default Value: []
        /// </param>
        /// <param name="position">
        /// Show the action in all queues, selected queues or no queues (to use via API only).<br/>
        /// Default Value: ALL_QUEUES
        /// </param>
        /// <param name="possibleValues">
        /// The possible values of the action. The user will be prompted to select one of these values when executing the action.<br/>
        /// Default Value: []
        /// </param>
        /// <param name="valueRequired">
        /// Whether the action requires a value to be executed.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="freeText">
        /// Whether the action allows any text to be entered as a value or if it must be one of the possible values.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ModerationAPI.ActionsCreateResponse> ActionsCreateAsync(
            string name,
            string? key = default,
            string? description = default,
            global::ModerationAPI.ActionsCreateRequestType2? type = default,
            bool? builtIn = default,
            global::ModerationAPI.ActionsCreateRequestQueueBehaviour? queueBehaviour = default,
            global::System.Collections.Generic.IList<string>? filterInQueueIds = default,
            global::ModerationAPI.ActionsCreateRequestPosition? position = default,
            global::System.Collections.Generic.IList<global::ModerationAPI.ActionsCreateRequestPossibleValue>? possibleValues = default,
            bool? valueRequired = default,
            bool? freeText = default,
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}