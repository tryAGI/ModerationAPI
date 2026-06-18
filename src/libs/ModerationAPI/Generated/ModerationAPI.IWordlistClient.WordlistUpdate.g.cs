#nullable enable

namespace ModerationAPI
{
    public partial interface IWordlistClient
    {
        /// <summary>
        /// Update wordlist<br/>
        /// Update a wordlist
        /// </summary>
        /// <param name="id">
        /// ID of the wordlist to update
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ModerationAPI.ApiException"></exception>
        /// <remarks>
        /// using System;<br/>
        /// using ModerationApi;<br/>
        /// using ModerationApi.Models.Wordlist;<br/>
        /// ModerationApiClient client = new();<br/>
        /// WordlistUpdateParams parameters = new() { ID = "id" };<br/>
        /// var wordlist = await client.Wordlist.Update(parameters);<br/>
        /// Console.WriteLine(wordlist);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::ModerationAPI.WordlistUpdateResponse> WordlistUpdateAsync(
            string id,

            global::ModerationAPI.WordlistUpdateRequest request,
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update wordlist<br/>
        /// Update a wordlist
        /// </summary>
        /// <param name="id">
        /// ID of the wordlist to update
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ModerationAPI.ApiException"></exception>
        /// <remarks>
        /// using System;<br/>
        /// using ModerationApi;<br/>
        /// using ModerationApi.Models.Wordlist;<br/>
        /// ModerationApiClient client = new();<br/>
        /// WordlistUpdateParams parameters = new() { ID = "id" };<br/>
        /// var wordlist = await client.Wordlist.Update(parameters);<br/>
        /// Console.WriteLine(wordlist);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::ModerationAPI.AutoSDKHttpResponse<global::ModerationAPI.WordlistUpdateResponse>> WordlistUpdateAsResponseAsync(
            string id,

            global::ModerationAPI.WordlistUpdateRequest request,
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update wordlist<br/>
        /// Update a wordlist
        /// </summary>
        /// <param name="id">
        /// ID of the wordlist to update
        /// </param>
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
        /// New words for the wordlist. Replace the existing words with these new ones. Duplicate words will be ignored.
        /// </param>
        /// <param name="strict">
        /// Deprecated. Now using threshold in project settings.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ModerationAPI.WordlistUpdateResponse> WordlistUpdateAsync(
            string id,
            string? name = default,
            string? key = default,
            string? description = default,
            global::System.Collections.Generic.IList<string>? words = default,
            bool? strict = default,
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}