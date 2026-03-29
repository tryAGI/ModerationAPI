#nullable enable

namespace ModerationAPI
{
    public partial interface IActionsClient
    {
        /// <summary>
        /// Update an action<br/>
        /// Update an action.
        /// </summary>
        /// <param name="id">
        /// The ID of the action to update.
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ModerationAPI.ApiException"></exception>
        /// <remarks>
        /// import ModerationAPI from '@moderation-api/sdk';<br/>
        /// const client = new ModerationAPI({<br/>
        ///   secretKey: process.env['MODAPI_SECRET_KEY'], // This is the default and can be omitted<br/>
        /// });<br/>
        /// const action = await client.actions.update('id');<br/>
        /// console.log(action.id);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::ModerationAPI.ActionsUpdateResponse> ActionsUpdateAsync(
            string id,

            global::ModerationAPI.ActionsUpdateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an action<br/>
        /// Update an action.
        /// </summary>
        /// <param name="id">
        /// The ID of the action to update.
        /// </param>
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
        /// <param name="webhooks">
        /// The action's webhooks.<br/>
        /// Default Value: []
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ModerationAPI.ActionsUpdateResponse> ActionsUpdateAsync(
            string id,
            string? key = default,
            string? name = default,
            string? description = default,
            global::ModerationAPI.ActionsUpdateRequestType2? type = default,
            bool? builtIn = default,
            global::ModerationAPI.ActionsUpdateRequestQueueBehaviour? queueBehaviour = default,
            global::System.Collections.Generic.IList<string>? filterInQueueIds = default,
            global::ModerationAPI.ActionsUpdateRequestPosition? position = default,
            global::System.Collections.Generic.IList<global::ModerationAPI.ActionsUpdateRequestPossibleValue>? possibleValues = default,
            bool? valueRequired = default,
            bool? freeText = default,
            global::System.Collections.Generic.IList<global::ModerationAPI.ActionsUpdateRequestWebhook>? webhooks = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}