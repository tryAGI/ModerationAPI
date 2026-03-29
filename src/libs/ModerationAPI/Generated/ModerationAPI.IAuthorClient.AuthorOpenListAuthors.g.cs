#nullable enable

namespace ModerationAPI
{
    public partial interface IAuthorClient
    {
        /// <summary>
        /// List authors<br/>
        /// Get a paginated list of authors with their activity metrics and reputation
        /// </summary>
        /// <param name="pageSize">
        /// Number of authors per page<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="pageNumber">
        /// Page number to fetch<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="sortBy"></param>
        /// <param name="sortDirection">
        /// Sort direction<br/>
        /// Default Value: desc
        /// </param>
        /// <param name="memberSinceDate"></param>
        /// <param name="lastActiveDate"></param>
        /// <param name="contentTypes"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ModerationAPI.ApiException"></exception>
        /// <remarks>
        /// import ModerationAPI from '@moderation-api/sdk';<br/>
        /// const client = new ModerationAPI({<br/>
        ///   secretKey: process.env['MODAPI_SECRET_KEY'], // This is the default and can be omitted<br/>
        /// });<br/>
        /// const authors = await client.authors.list();<br/>
        /// console.log(authors.authors);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::ModerationAPI.AuthorOpenListAuthorsResponse> AuthorOpenListAuthorsAsync(
            double? pageSize = default,
            double? pageNumber = default,
            global::ModerationAPI.AuthorOpenListAuthorsSortBy? sortBy = default,
            global::ModerationAPI.AuthorOpenListAuthorsSortDirection? sortDirection = default,
            string? memberSinceDate = default,
            string? lastActiveDate = default,
            string? contentTypes = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}