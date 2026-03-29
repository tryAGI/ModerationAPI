#nullable enable

namespace ModerationAPI
{
    public partial interface IWordlistClient
    {
        /// <summary>
        /// List wordlists<br/>
        /// List all wordlists for the authenticated organization
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ModerationAPI.ApiException"></exception>
        /// <remarks>
        /// import ModerationAPI from '@moderation-api/sdk';<br/>
        /// const client = new ModerationAPI({<br/>
        ///   secretKey: process.env['MODAPI_SECRET_KEY'], // This is the default and can be omitted<br/>
        /// });<br/>
        /// const wordlists = await client.wordlist.list();<br/>
        /// console.log(wordlists);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::ModerationAPI.WordlistListResponseItem>> WordlistListAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}