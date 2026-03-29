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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ModerationAPI.ApiException"></exception>
        /// <remarks>
        /// import ModerationAPI from '@moderation-api/sdk';<br/>
        /// const client = new ModerationAPI({<br/>
        ///   secretKey: process.env['MODAPI_SECRET_KEY'], // This is the default and can be omitted<br/>
        /// });<br/>
        /// const author = await client.authors.update('id');<br/>
        /// console.log(author.id);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::ModerationAPI.AuthorOpenUpdateResponse> AuthorOpenUpdateAsync(
            string id,

            global::ModerationAPI.AuthorOpenUpdateRequest request,
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ModerationAPI.AuthorOpenUpdateResponse> AuthorOpenUpdateAsync(
            string id,
            string? profilePicture = default,
            string? externalLink = default,
            string? name = default,
            string? email = default,
            global::ModerationAPI.AuthorOpenUpdateRequestMetadata? metadata = default,
            double? firstSeen = default,
            double? lastSeen = default,
            double? manualTrustLevel = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}