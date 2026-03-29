#nullable enable

namespace ModerationAPI
{
    public partial interface IWordlistClient
    {
        /// <summary>
        /// Add words to wordlist<br/>
        /// Add words to an existing wordlist
        /// </summary>
        /// <param name="id">
        /// ID of the wordlist to add words to
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ModerationAPI.ApiException"></exception>
        /// <remarks>
        /// import ModerationAPI from '@moderation-api/sdk';<br/>
        /// const client = new ModerationAPI({<br/>
        ///   secretKey: process.env['MODAPI_SECRET_KEY'], // This is the default and can be omitted<br/>
        /// });<br/>
        /// const response = await client.wordlist.words.add('id', { words: ['string'] });<br/>
        /// console.log(response.addedCount);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::ModerationAPI.WordlistAddWordsResponse> WordlistAddWordsAsync(
            string id,

            global::ModerationAPI.WordlistAddWordsRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add words to wordlist<br/>
        /// Add words to an existing wordlist
        /// </summary>
        /// <param name="id">
        /// ID of the wordlist to add words to
        /// </param>
        /// <param name="words">
        /// Array of words to add to the wordlist. Duplicate words will be ignored.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ModerationAPI.WordlistAddWordsResponse> WordlistAddWordsAsync(
            string id,
            global::System.Collections.Generic.IList<string> words,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}