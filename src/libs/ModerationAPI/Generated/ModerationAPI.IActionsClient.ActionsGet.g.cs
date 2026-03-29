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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ModerationAPI.ApiException"></exception>
        /// <remarks>
        /// import ModerationAPI from '@moderation-api/sdk';<br/>
        /// const client = new ModerationAPI({<br/>
        ///   secretKey: process.env['MODAPI_SECRET_KEY'], // This is the default and can be omitted<br/>
        /// });<br/>
        /// const action = await client.actions.retrieve('id');<br/>
        /// console.log(action.id);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::ModerationAPI.ActionsGetResponse> ActionsGetAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}