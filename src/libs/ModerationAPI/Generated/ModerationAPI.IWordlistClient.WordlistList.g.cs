#nullable enable

namespace ModerationAPI
{
    public partial interface IWordlistClient
    {
        /// <summary>
        /// List wordlists<br/>
        /// List all wordlists for the authenticated organization
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ModerationAPI.ApiException"></exception>
        /// <remarks>
        /// using System;<br/>
        /// using ModerationApi;<br/>
        /// using ModerationApi.Models.Wordlist;<br/>
        /// ModerationApiClient client = new();<br/>
        /// WordlistListParams parameters = new();<br/>
        /// var wordlists = await client.Wordlist.List(parameters);<br/>
        /// Console.WriteLine(wordlists);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::ModerationAPI.WordlistListResponseItem>> WordlistListAsync(
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List wordlists<br/>
        /// List all wordlists for the authenticated organization
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ModerationAPI.ApiException"></exception>
        /// <remarks>
        /// using System;<br/>
        /// using ModerationApi;<br/>
        /// using ModerationApi.Models.Wordlist;<br/>
        /// ModerationApiClient client = new();<br/>
        /// WordlistListParams parameters = new();<br/>
        /// var wordlists = await client.Wordlist.List(parameters);<br/>
        /// Console.WriteLine(wordlists);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::ModerationAPI.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::ModerationAPI.WordlistListResponseItem>>> WordlistListAsResponseAsync(
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}