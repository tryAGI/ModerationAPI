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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ModerationAPI.ApiException"></exception>
        /// <remarks>
        /// using System;<br/>
        /// using ModerationApi;<br/>
        /// using ModerationApi.Models.Wordlist.Words;<br/>
        /// ModerationApiClient client = new();<br/>
        /// WordAddParams parameters = new()<br/>
        /// {<br/>
        ///     ID = "id",<br/>
        ///     Words =<br/>
        ///     [<br/>
        ///         "string"<br/>
        ///     ],<br/>
        /// };<br/>
        /// var response = await client.Wordlist.Words.Add(parameters);<br/>
        /// Console.WriteLine(response);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::ModerationAPI.WordlistAddWordsResponse> WordlistAddWordsAsync(
            string id,

            global::ModerationAPI.WordlistAddWordsRequest request,
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add words to wordlist<br/>
        /// Add words to an existing wordlist
        /// </summary>
        /// <param name="id">
        /// ID of the wordlist to add words to
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ModerationAPI.ApiException"></exception>
        /// <remarks>
        /// using System;<br/>
        /// using ModerationApi;<br/>
        /// using ModerationApi.Models.Wordlist.Words;<br/>
        /// ModerationApiClient client = new();<br/>
        /// WordAddParams parameters = new()<br/>
        /// {<br/>
        ///     ID = "id",<br/>
        ///     Words =<br/>
        ///     [<br/>
        ///         "string"<br/>
        ///     ],<br/>
        /// };<br/>
        /// var response = await client.Wordlist.Words.Add(parameters);<br/>
        /// Console.WriteLine(response);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::ModerationAPI.AutoSDKHttpResponse<global::ModerationAPI.WordlistAddWordsResponse>> WordlistAddWordsAsResponseAsync(
            string id,

            global::ModerationAPI.WordlistAddWordsRequest request,
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ModerationAPI.WordlistAddWordsResponse> WordlistAddWordsAsync(
            string id,
            global::System.Collections.Generic.IList<string> words,
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}