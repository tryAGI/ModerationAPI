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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ModerationAPI.ApiException"></exception>
        /// <remarks>
        /// using System;<br/>
        /// using ModerationApi;<br/>
        /// using ModerationApi.Models.Wordlist;<br/>
        /// ModerationApiClient client = new();<br/>
        /// WordlistGetEmbeddingStatusParams parameters = new() { ID = "id" };<br/>
        /// var response = await client.Wordlist.GetEmbeddingStatus(parameters);<br/>
        /// Console.WriteLine(response);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::ModerationAPI.WordlistWordlistEmbeddingStatusResponse> WordlistWordlistEmbeddingStatusAsync(
            string id,
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get embedding status<br/>
        /// Get the current embedding progress status for a wordlist
        /// </summary>
        /// <param name="id">
        /// ID of the wordlist to check embedding status for
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ModerationAPI.ApiException"></exception>
        /// <remarks>
        /// using System;<br/>
        /// using ModerationApi;<br/>
        /// using ModerationApi.Models.Wordlist;<br/>
        /// ModerationApiClient client = new();<br/>
        /// WordlistGetEmbeddingStatusParams parameters = new() { ID = "id" };<br/>
        /// var response = await client.Wordlist.GetEmbeddingStatus(parameters);<br/>
        /// Console.WriteLine(response);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::ModerationAPI.AutoSDKHttpResponse<global::ModerationAPI.WordlistWordlistEmbeddingStatusResponse>> WordlistWordlistEmbeddingStatusAsResponseAsync(
            string id,
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}