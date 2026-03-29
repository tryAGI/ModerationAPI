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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ModerationAPI.ApiException"></exception>
        /// <remarks>
        /// import ModerationAPI from '@moderation-api/sdk';<br/>
        /// const client = new ModerationAPI({<br/>
        ///   secretKey: process.env['MODAPI_SECRET_KEY'], // This is the default and can be omitted<br/>
        /// });<br/>
        /// const author = await client.authors.create({ external_id: 'external_id' });<br/>
        /// console.log(author.id);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::ModerationAPI.AuthorOpenCreateResponse> AuthorOpenCreateAsync(

            global::ModerationAPI.AuthorOpenCreateRequest request,
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ModerationAPI.AuthorOpenCreateResponse> AuthorOpenCreateAsync(
            string externalId,
            string? profilePicture = default,
            string? externalLink = default,
            string? name = default,
            string? email = default,
            global::ModerationAPI.AuthorOpenCreateRequestMetadata? metadata = default,
            double? firstSeen = default,
            double? lastSeen = default,
            double? manualTrustLevel = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}