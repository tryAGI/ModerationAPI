#nullable enable

namespace ModerationAPI
{
    public partial interface IActionsClient
    {
        /// <summary>
        /// Execute moderation action<br/>
        /// Execute a moderation action on one or more content items.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ModerationAPI.ApiException"></exception>
        /// <remarks>
        /// import ModerationAPI from '@moderation-api/sdk';<br/>
        /// const client = new ModerationAPI({<br/>
        ///   secretKey: process.env['MODAPI_SECRET_KEY'], // This is the default and can be omitted<br/>
        /// });<br/>
        /// const response = await client.actions.execute.execute({ actionKey: 'actionKey' });<br/>
        /// console.log(response.success);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::ModerationAPI.ActionsExecuteResponse> ActionsExecuteAsync(

            global::ModerationAPI.ActionsExecuteRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Execute moderation action<br/>
        /// Execute a moderation action on one or more content items.
        /// </summary>
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ModerationAPI.ActionsExecuteResponse> ActionsExecuteAsync(
            string actionKey,
            global::System.Collections.Generic.IList<string>? contentIds = default,
            global::System.Collections.Generic.IList<string>? authorIds = default,
            string? value = default,
            string? queueId = default,
            double? duration = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}