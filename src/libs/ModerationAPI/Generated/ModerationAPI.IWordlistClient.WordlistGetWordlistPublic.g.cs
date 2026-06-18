#nullable enable

namespace ModerationAPI
{
    public partial interface IWordlistClient
    {
        /// <summary>
        /// Get wordlist<br/>
        /// Get a specific wordlist by ID
        /// </summary>
        /// <param name="id">
        /// ID of the wordlist to get
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ModerationAPI.ApiException"></exception>
        /// <remarks>
        /// using System;<br/>
        /// using ModerationApi;<br/>
        /// using ModerationApi.Models.Wordlist;<br/>
        /// ModerationApiClient client = new();<br/>
        /// WordlistRetrieveParams parameters = new() { ID = "id" };<br/>
        /// var wordlist = await client.Wordlist.Retrieve(parameters);<br/>
        /// Console.WriteLine(wordlist);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::ModerationAPI.WordlistGetWordlistPublicResponse> WordlistGetWordlistPublicAsync(
            string id,
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get wordlist<br/>
        /// Get a specific wordlist by ID
        /// </summary>
        /// <param name="id">
        /// ID of the wordlist to get
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ModerationAPI.ApiException"></exception>
        /// <remarks>
        /// using System;<br/>
        /// using ModerationApi;<br/>
        /// using ModerationApi.Models.Wordlist;<br/>
        /// ModerationApiClient client = new();<br/>
        /// WordlistRetrieveParams parameters = new() { ID = "id" };<br/>
        /// var wordlist = await client.Wordlist.Retrieve(parameters);<br/>
        /// Console.WriteLine(wordlist);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::ModerationAPI.AutoSDKHttpResponse<global::ModerationAPI.WordlistGetWordlistPublicResponse>> WordlistGetWordlistPublicAsResponseAsync(
            string id,
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}