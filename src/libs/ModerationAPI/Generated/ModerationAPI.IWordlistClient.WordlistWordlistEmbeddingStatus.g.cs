#nullable enable

namespace ModerationAPI
{
    public partial interface IWordlistClient
    {
        /// <summary>
        /// Get embedding status<br/>
        /// Get the current embedding progress status for a wordlist
        /// </summary>
        /// <param name="id">
        /// ID of the wordlist to check embedding status for
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ModerationAPI.ApiException"></exception>
        /// <remarks>
        /// import ModerationAPI from '@moderation-api/sdk';<br/>
        /// const client = new ModerationAPI({<br/>
        ///   secretKey: process.env['MODAPI_SECRET_KEY'], // This is the default and can be omitted<br/>
        /// });<br/>
        /// const response = await client.wordlist.getEmbeddingStatus('id');<br/>
        /// console.log(response.progress);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::ModerationAPI.WordlistWordlistEmbeddingStatusResponse> WordlistWordlistEmbeddingStatusAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}