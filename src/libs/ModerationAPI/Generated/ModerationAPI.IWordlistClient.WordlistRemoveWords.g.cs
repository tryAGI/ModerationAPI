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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ModerationAPI.ApiException"></exception>
        /// <remarks>
        /// using System;<br/>
        /// using ModerationApi;<br/>
        /// using ModerationApi.Models.Wordlist.Words;<br/>
        /// ModerationApiClient client = new();<br/>
        /// WordRemoveParams parameters = new()<br/>
        /// {<br/>
        ///     ID = "id",<br/>
        ///     Words =<br/>
        ///     [<br/>
        ///         "string"<br/>
        ///     ],<br/>
        /// };<br/>
        /// var word = await client.Wordlist.Words.Remove(parameters);<br/>
        /// Console.WriteLine(word);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::ModerationAPI.WordlistRemoveWordsResponse> WordlistRemoveWordsAsync(
            string id,
            global::System.Collections.Generic.IList<string> words,
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ModerationAPI.ApiException"></exception>
        /// <remarks>
        /// using System;<br/>
        /// using ModerationApi;<br/>
        /// using ModerationApi.Models.Wordlist.Words;<br/>
        /// ModerationApiClient client = new();<br/>
        /// WordRemoveParams parameters = new()<br/>
        /// {<br/>
        ///     ID = "id",<br/>
        ///     Words =<br/>
        ///     [<br/>
        ///         "string"<br/>
        ///     ],<br/>
        /// };<br/>
        /// var word = await client.Wordlist.Words.Remove(parameters);<br/>
        /// Console.WriteLine(word);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::ModerationAPI.AutoSDKHttpResponse<global::ModerationAPI.WordlistRemoveWordsResponse>> WordlistRemoveWordsAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<string> words,
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}