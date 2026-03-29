#nullable enable

namespace ModerationAPI
{
    public partial interface IAccountClient
    {
        /// <summary>
        /// Get account details<br/>
        /// Get account details
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ModerationAPI.ApiException"></exception>
        /// <remarks>
        /// import ModerationAPI from '@moderation-api/sdk';<br/>
        /// const client = new ModerationAPI({<br/>
        ///   secretKey: process.env['MODAPI_SECRET_KEY'], // This is the default and can be omitted<br/>
        /// });<br/>
        /// const accounts = await client.account.list();<br/>
        /// console.log(accounts.id);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::ModerationAPI.AccountGetResponse> AccountGetAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}