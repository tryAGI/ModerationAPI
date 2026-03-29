#nullable enable

namespace ModerationAPI
{
    public partial interface IWordlistClient
    {
        /// <summary>
        /// Get wordlist<br/>
        /// Get a specific wordlist by ID
        /// </summary>
        /// <param name="id">
        /// ID of the wordlist to get
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ModerationAPI.ApiException"></exception>
        /// <remarks>
        /// import ModerationAPI from '@moderation-api/sdk';<br/>
        /// const client = new ModerationAPI({<br/>
        ///   secretKey: process.env['MODAPI_SECRET_KEY'], // This is the default and can be omitted<br/>
        /// });<br/>
        /// const wordlist = await client.wordlist.retrieve('id');<br/>
        /// console.log(wordlist.id);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::ModerationAPI.WordlistGetWordlistPublicResponse> WordlistGetWordlistPublicAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}