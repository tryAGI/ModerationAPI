#nullable enable

namespace ModerationAPI
{
    public partial interface IAuthorClient
    {
        /// <summary>
        /// Get author details<br/>
        /// Get detailed information about a specific author including historical data and analysis
        /// </summary>
        /// <param name="id">
        /// Either external ID or the ID assigned by moderation API.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ModerationAPI.ApiException"></exception>
        /// <remarks>
        /// using System;<br/>
        /// using ModerationApi;<br/>
        /// using ModerationApi.Models.Authors;<br/>
        /// ModerationApiClient client = new();<br/>
        /// AuthorRetrieveParams parameters = new() { ID = "id" };<br/>
        /// var author = await client.Authors.Retrieve(parameters);<br/>
        /// Console.WriteLine(author);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::ModerationAPI.PublicAuthor> AuthorOpenGetAuthorDetailsAsync(
            string id,
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get author details<br/>
        /// Get detailed information about a specific author including historical data and analysis
        /// </summary>
        /// <param name="id">
        /// Either external ID or the ID assigned by moderation API.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ModerationAPI.ApiException"></exception>
        /// <remarks>
        /// using System;<br/>
        /// using ModerationApi;<br/>
        /// using ModerationApi.Models.Authors;<br/>
        /// ModerationApiClient client = new();<br/>
        /// AuthorRetrieveParams parameters = new() { ID = "id" };<br/>
        /// var author = await client.Authors.Retrieve(parameters);<br/>
        /// Console.WriteLine(author);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::ModerationAPI.AutoSDKHttpResponse<global::ModerationAPI.PublicAuthor>> AuthorOpenGetAuthorDetailsAsResponseAsync(
            string id,
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}