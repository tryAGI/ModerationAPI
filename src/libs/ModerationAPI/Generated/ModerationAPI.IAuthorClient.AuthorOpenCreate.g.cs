#nullable enable

namespace ModerationAPI
{
    public partial interface IAuthorClient
    {
        /// <summary>
        /// Create a new author<br/>
        /// Create a new author. Typically not needed as authors are created automatically when content is moderated.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ModerationAPI.ApiException"></exception>
        /// <remarks>
        /// using System;<br/>
        /// using ModerationApi;<br/>
        /// using ModerationApi.Models.Authors;<br/>
        /// ModerationApiClient client = new();<br/>
        /// AuthorCreateParams parameters = new() { ExternalID = "external_id" };<br/>
        /// var author = await client.Authors.Create(parameters);<br/>
        /// Console.WriteLine(author);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::ModerationAPI.PublicAuthor> AuthorOpenCreateAsync(

            global::ModerationAPI.AuthorOpenCreateRequest request,
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new author<br/>
        /// Create a new author. Typically not needed as authors are created automatically when content is moderated.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ModerationAPI.ApiException"></exception>
        /// <remarks>
        /// using System;<br/>
        /// using ModerationApi;<br/>
        /// using ModerationApi.Models.Authors;<br/>
        /// ModerationApiClient client = new();<br/>
        /// AuthorCreateParams parameters = new() { ExternalID = "external_id" };<br/>
        /// var author = await client.Authors.Create(parameters);<br/>
        /// Console.WriteLine(author);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::ModerationAPI.AutoSDKHttpResponse<global::ModerationAPI.PublicAuthor>> AuthorOpenCreateAsResponseAsync(

            global::ModerationAPI.AuthorOpenCreateRequest request,
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new author<br/>
        /// Create a new author. Typically not needed as authors are created automatically when content is moderated.
        /// </summary>
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
        /// <param name="externalId">
        /// External ID of the user, typically the ID of the author in your database.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ModerationAPI.PublicAuthor> AuthorOpenCreateAsync(
            string externalId,
            string? profilePicture = default,
            string? externalLink = default,
            string? name = default,
            string? email = default,
            string? company = default,
            global::ModerationAPI.AuthorOpenCreateRequestMetadata? metadata = default,
            double? firstSeen = default,
            double? lastSeen = default,
            double? manualTrustLevel = default,
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}