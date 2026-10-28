#nullable enable

namespace ModerationAPI
{
    public partial interface IWordlistClient
    {
        /// <summary>
        /// Update wordlist<br/>
        /// Update a wordlist. Fields that you do not send stay the same. If you send words, they replace all existing words, and the embeddings are updated in the background.
        /// </summary>
        /// <param name="id">
        /// ID of the wordlist to update
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
        ///   const result = await moderationApi.wordlist.update("&lt;id&gt;", {});<br/>
        ///   console.log(result);<br/>
        /// }<br/>
        /// run();
        /// </remarks>
        global::System.Threading.Tasks.Task<global::ModerationAPI.WordlistUpdateResponse> WordlistUpdateAsync(
            string id,

            global::ModerationAPI.WordlistUpdateRequest request,
            string? projectId = default,
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update wordlist<br/>
        /// Update a wordlist. Fields that you do not send stay the same. If you send words, they replace all existing words, and the embeddings are updated in the background.
        /// </summary>
        /// <param name="id">
        /// ID of the wordlist to update
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
        ///   const result = await moderationApi.wordlist.update("&lt;id&gt;", {});<br/>
        ///   console.log(result);<br/>
        /// }<br/>
        /// run();
        /// </remarks>
        global::System.Threading.Tasks.Task<global::ModerationAPI.AutoSDKHttpResponse<global::ModerationAPI.WordlistUpdateResponse>> WordlistUpdateAsResponseAsync(
            string id,

            global::ModerationAPI.WordlistUpdateRequest request,
            string? projectId = default,
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update wordlist<br/>
        /// Update a wordlist. Fields that you do not send stay the same. If you send words, they replace all existing words, and the embeddings are updated in the background.
        /// </summary>
        /// <param name="id">
        /// ID of the wordlist to update
        /// </param>
        /// <param name="projectId"></param>
        /// <param name="name">
        /// New name for the wordlist
        /// </param>
        /// <param name="key">
        /// New key for the wordlist
        /// </param>
        /// <param name="description">
        /// New description for the wordlist
        /// </param>
        /// <param name="words">
        /// New words for the wordlist. Replace the existing words with these new ones. Words are converted to lowercase. Duplicate and empty words are ignored. Maximum 5000 words.
        /// </param>
        /// <param name="strict">
        /// Deprecated. Now using threshold in project settings.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ModerationAPI.WordlistUpdateResponse> WordlistUpdateAsync(
            string id,
            string? projectId = default,
            string? name = default,
            string? key = default,
            string? description = default,
            global::System.Collections.Generic.IList<string>? words = default,
            bool? strict = default,
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}