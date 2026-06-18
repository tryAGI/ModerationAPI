#nullable enable

namespace ModerationAPI
{
    public partial interface IAuthorClient
    {
        /// <summary>
        /// Update author details<br/>
        /// Update the details of a specific author
        /// </summary>
        /// <param name="id">
        /// Either external ID or the ID assigned by moderation API.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ModerationAPI.ApiException"></exception>
        /// <remarks>
        /// using System;<br/>
        /// using ModerationApi;<br/>
        /// using ModerationApi.Models.Authors;<br/>
        /// ModerationApiClient client = new();<br/>
        /// AuthorUpdateParams parameters = new() { ID = "id" };<br/>
        /// var author = await client.Authors.Update(parameters);<br/>
        /// Console.WriteLine(author);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::ModerationAPI.PublicAuthor> AuthorOpenUpdateAsync(
            string id,

            global::ModerationAPI.AuthorOpenUpdateRequest request,
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update author details<br/>
        /// Update the details of a specific author
        /// </summary>
        /// <param name="id">
        /// Either external ID or the ID assigned by moderation API.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ModerationAPI.ApiException"></exception>
        /// <remarks>
        /// using System;<br/>
        /// using ModerationApi;<br/>
        /// using ModerationApi.Models.Authors;<br/>
        /// ModerationApiClient client = new();<br/>
        /// AuthorUpdateParams parameters = new() { ID = "id" };<br/>
        /// var author = await client.Authors.Update(parameters);<br/>
        /// Console.WriteLine(author);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::ModerationAPI.AutoSDKHttpResponse<global::ModerationAPI.PublicAuthor>> AuthorOpenUpdateAsResponseAsync(
            string id,

            global::ModerationAPI.AuthorOpenUpdateRequest request,
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update author details<br/>
        /// Update the details of a specific author
        /// </summary>
        /// <param name="id">
        /// Either external ID or the ID assigned by moderation API.
        /// </param>
        /// <param name="profilePicture">
        /// URL of the author's profile picture
        /// </param>
        /// <param name="externalLink">
        /// URL of the author's external profile
        /// </param>
        /// <param name="name">
        /// Author name or identifier
        /// </param>
        /// <param name="email">
        /// Author email address
        /// </param>
        /// <param name="company">
        /// The author's company or organization
        /// </param>
        /// <param name="metadata">
        /// Additional metadata provided by your system. We recommend including any relevant information that may assist in the moderation process.
        /// </param>
        /// <param name="firstSeen">
        /// Timestamp when author first appeared
        /// </param>
        /// <param name="lastSeen">
        /// Timestamp of last activity
        /// </param>
        /// <param name="manualTrustLevel"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ModerationAPI.PublicAuthor> AuthorOpenUpdateAsync(
            string id,
            string? profilePicture = default,
            string? externalLink = default,
            string? name = default,
            string? email = default,
            string? company = default,
            global::ModerationAPI.AuthorOpenUpdateRequestMetadata? metadata = default,
            double? firstSeen = default,
            double? lastSeen = default,
            double? manualTrustLevel = default,
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}