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
        /// <param name="projectId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ModerationAPI.ApiException"></exception>
        /// <remarks>
        /// import { ModerationApi } from "@moderation-api/sdk";<br/>
        /// const moderationApi = new ModerationApi({<br/>
        ///   secretKey: process.env["MODAPI_SECRET_KEY"] ?? "",<br/>
        /// });<br/>
        /// async function run() {<br/>
        ///   const result = await moderationApi.wordlist.words.add({<br/>
        ///     id: "&lt;id&gt;",<br/>
        ///     body: {<br/>
        ///       words: [<br/>
        ///         "free money",<br/>
        ///         "click here",<br/>
        ///       ],<br/>
        ///     },<br/>
        ///   });<br/>
        ///   console.log(result);<br/>
        /// }<br/>
        /// run();
        /// </remarks>
        global::System.Threading.Tasks.Task<global::ModerationAPI.WordlistAddWordsResponse> WordlistAddWordsAsync(
            string id,

            global::ModerationAPI.WordlistAddWordsRequest request,
            string? projectId = default,
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add words to wordlist<br/>
        /// Add words to an existing wordlist
        /// </summary>
        /// <param name="id">
        /// ID of the wordlist to add words to
        /// </param>
        /// <param name="projectId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ModerationAPI.ApiException"></exception>
        /// <remarks>
        /// import { ModerationApi } from "@moderation-api/sdk";<br/>
        /// const moderationApi = new ModerationApi({<br/>
        ///   secretKey: process.env["MODAPI_SECRET_KEY"] ?? "",<br/>
        /// });<br/>
        /// async function run() {<br/>
        ///   const result = await moderationApi.wordlist.words.add({<br/>
        ///     id: "&lt;id&gt;",<br/>
        ///     body: {<br/>
        ///       words: [<br/>
        ///         "free money",<br/>
        ///         "click here",<br/>
        ///       ],<br/>
        ///     },<br/>
        ///   });<br/>
        ///   console.log(result);<br/>
        /// }<br/>
        /// run();
        /// </remarks>
        global::System.Threading.Tasks.Task<global::ModerationAPI.AutoSDKHttpResponse<global::ModerationAPI.WordlistAddWordsResponse>> WordlistAddWordsAsResponseAsync(
            string id,

            global::ModerationAPI.WordlistAddWordsRequest request,
            string? projectId = default,
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add words to wordlist<br/>
        /// Add words to an existing wordlist
        /// </summary>
        /// <param name="id">
        /// ID of the wordlist to add words to
        /// </param>
        /// <param name="projectId"></param>
        /// <param name="words">
        /// Array of words to add to the wordlist. Duplicate words will be ignored.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ModerationAPI.WordlistAddWordsResponse> WordlistAddWordsAsync(
            string id,
            global::System.Collections.Generic.IList<string> words,
            string? projectId = default,
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}