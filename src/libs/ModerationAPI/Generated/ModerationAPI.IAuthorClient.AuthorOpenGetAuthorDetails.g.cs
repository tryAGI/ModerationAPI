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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ModerationAPI.ApiException"></exception>
        /// <remarks>
        /// import ModerationAPI from '@moderation-api/sdk';<br/>
        /// const client = new ModerationAPI({<br/>
        ///   secretKey: process.env['MODAPI_SECRET_KEY'], // This is the default and can be omitted<br/>
        /// });<br/>
        /// const author = await client.authors.retrieve('id');<br/>
        /// console.log(author.id);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::ModerationAPI.AuthorOpenGetAuthorDetailsResponse> AuthorOpenGetAuthorDetailsAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}