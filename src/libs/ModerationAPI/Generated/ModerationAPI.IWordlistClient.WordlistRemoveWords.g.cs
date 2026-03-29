#nullable enable

namespace ModerationAPI
{
    public partial interface IWordlistClient
    {
        /// <summary>
        /// Remove words from wordlist<br/>
        /// Remove words from an existing wordlist
        /// </summary>
        /// <param name="id">
        /// ID of the wordlist to remove words from
        /// </param>
        /// <param name="words">
        /// Array of words to remove from the wordlist
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ModerationAPI.ApiException"></exception>
        /// <remarks>
        /// import ModerationAPI from '@moderation-api/sdk';<br/>
        /// const client = new ModerationAPI({<br/>
        ///   secretKey: process.env['MODAPI_SECRET_KEY'], // This is the default and can be omitted<br/>
        /// });<br/>
        /// const word = await client.wordlist.words.remove('id', { words: ['string'] });<br/>
        /// console.log(word.removedCount);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::ModerationAPI.WordlistRemoveWordsResponse> WordlistRemoveWordsAsync(
            string id,
            global::System.Collections.Generic.IList<string> words,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}