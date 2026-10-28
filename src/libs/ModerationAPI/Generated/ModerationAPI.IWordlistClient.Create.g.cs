#nullable enable

namespace ModerationAPI
{
    public partial interface IWordlistClient
    {
        /// <summary>
        /// Create wordlist<br/>
        /// Create a wordlist in the organization. You can add words now or later. Each word is embedded in the background for similarity matching. Use the embedding status endpoint to follow the progress. To use the wordlist in moderation, add it to a policy.
        /// </summary>
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
        ///   const result = await moderationApi.wordlist.create({<br/>
        ///     name: "&lt;value&gt;",<br/>
        ///   });<br/>
        ///   console.log(result);<br/>
        /// }<br/>
        /// run();
        /// </remarks>
        global::System.Threading.Tasks.Task<global::ModerationAPI.CreateWordlistResponse> CreateAsync(

            global::ModerationAPI.CreateWordlistRequest request,
            string? projectId = default,
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create wordlist<br/>
        /// Create a wordlist in the organization. You can add words now or later. Each word is embedded in the background for similarity matching. Use the embedding status endpoint to follow the progress. To use the wordlist in moderation, add it to a policy.
        /// </summary>
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
        ///   const result = await moderationApi.wordlist.create({<br/>
        ///     name: "&lt;value&gt;",<br/>
        ///   });<br/>
        ///   console.log(result);<br/>
        /// }<br/>
        /// run();
        /// </remarks>
        global::System.Threading.Tasks.Task<global::ModerationAPI.AutoSDKHttpResponse<global::ModerationAPI.CreateWordlistResponse>> CreateAsResponseAsync(

            global::ModerationAPI.CreateWordlistRequest request,
            string? projectId = default,
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create wordlist<br/>
        /// Create a wordlist in the organization. You can add words now or later. Each word is embedded in the background for similarity matching. Use the embedding status endpoint to follow the progress. To use the wordlist in moderation, add it to a policy.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="name">
        /// Name of the wordlist
        /// </param>
        /// <param name="key">
        /// Key of the wordlist. Default: made from the name. If the key is already in use, a suffix is added.
        /// </param>
        /// <param name="description">
        /// Description of the wordlist
        /// </param>
        /// <param name="words">
        /// Words to add to the wordlist. Words are converted to lowercase. Duplicate and empty words are ignored. Maximum 5000 words.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ModerationAPI.CreateWordlistResponse> CreateAsync(
            string name,
            string? projectId = default,
            string? key = default,
            string? description = default,
            global::System.Collections.Generic.IList<string>? words = default,
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}