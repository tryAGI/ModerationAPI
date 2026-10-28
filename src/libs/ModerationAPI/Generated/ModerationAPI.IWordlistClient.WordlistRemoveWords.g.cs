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
        /// <param name="projectId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ModerationAPI.ApiException"></exception>
        /// <remarks>
        /// import { ModerationApi } from "@moderation-api/sdk";<br/>
        /// const moderationApi = new ModerationApi({<br/>
        ///   secretKey: process.env["MODAPI_SECRET_KEY"] ?? "",<br/>
        /// });<br/>
        /// async function run() {<br/>
        ///   const result = await moderationApi.wordlist.words.remove("&lt;id&gt;", [<br/>
        ///     "&lt;value 1&gt;",<br/>
        ///     "&lt;value 2&gt;",<br/>
        ///     "&lt;value 3&gt;",<br/>
        ///   ]);<br/>
        ///   console.log(result);<br/>
        /// }<br/>
        /// run();
        /// </remarks>
        global::System.Threading.Tasks.Task<global::ModerationAPI.WordlistRemoveWordsResponse> WordlistRemoveWordsAsync(
            string id,
            global::System.Collections.Generic.IList<string> words,
            string? projectId = default,
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
        /// <param name="projectId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ModerationAPI.ApiException"></exception>
        /// <remarks>
        /// import { ModerationApi } from "@moderation-api/sdk";<br/>
        /// const moderationApi = new ModerationApi({<br/>
        ///   secretKey: process.env["MODAPI_SECRET_KEY"] ?? "",<br/>
        /// });<br/>
        /// async function run() {<br/>
        ///   const result = await moderationApi.wordlist.words.remove("&lt;id&gt;", [<br/>
        ///     "&lt;value 1&gt;",<br/>
        ///     "&lt;value 2&gt;",<br/>
        ///     "&lt;value 3&gt;",<br/>
        ///   ]);<br/>
        ///   console.log(result);<br/>
        /// }<br/>
        /// run();
        /// </remarks>
        global::System.Threading.Tasks.Task<global::ModerationAPI.AutoSDKHttpResponse<global::ModerationAPI.WordlistRemoveWordsResponse>> WordlistRemoveWordsAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<string> words,
            string? projectId = default,
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}