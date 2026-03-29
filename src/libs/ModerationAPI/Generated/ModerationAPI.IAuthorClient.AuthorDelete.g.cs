#nullable enable

namespace ModerationAPI
{
    public partial interface IAuthorClient
    {
        /// <summary>
        /// Delete an author<br/>
        /// Delete a specific author
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ModerationAPI.ApiException"></exception>
        /// <remarks>
        /// import ModerationAPI from '@moderation-api/sdk';<br/>
        /// const client = new ModerationAPI({<br/>
        ///   secretKey: process.env['MODAPI_SECRET_KEY'], // This is the default and can be omitted<br/>
        /// });<br/>
        /// const author = await client.authors.delete('id');<br/>
        /// console.log(author.success);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::ModerationAPI.AuthorDeleteResponse> AuthorDeleteAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}