#nullable enable

namespace ModerationAPI
{
    public partial interface IAuthorClient
    {
        /// <summary>
        /// Delete an author<br/>
        /// Delete a specific author. This resets the author: status, blocks, trust level, metrics and action history are removed. The author is created again with a clean record the next time content is moderated for the same ID.
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
        /// AuthorDeleteParams parameters = new() { ID = "id" };<br/>
        /// var author = await client.Authors.Delete(parameters);<br/>
        /// Console.WriteLine(author);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::ModerationAPI.AuthorDeleteResponse> AuthorDeleteAsync(
            string id,
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete an author<br/>
        /// Delete a specific author. This resets the author: status, blocks, trust level, metrics and action history are removed. The author is created again with a clean record the next time content is moderated for the same ID.
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
        /// AuthorDeleteParams parameters = new() { ID = "id" };<br/>
        /// var author = await client.Authors.Delete(parameters);<br/>
        /// Console.WriteLine(author);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::ModerationAPI.AutoSDKHttpResponse<global::ModerationAPI.AuthorDeleteResponse>> AuthorDeleteAsResponseAsync(
            string id,
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}