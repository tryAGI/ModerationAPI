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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ModerationAPI.ApiException"></exception>
        /// <remarks>
        /// import ModerationAPI from '@moderation-api/sdk';<br/>
        /// const client = new ModerationAPI({<br/>
        ///   secretKey: process.env['MODAPI_SECRET_KEY'], // This is the default and can be omitted<br/>
        /// });<br/>
        /// const actions = await client.actions.list();<br/>
        /// console.log(actions);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::ModerationAPI.ActionsListResponseItem>> ActionsListAsync(
            string? queueId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}