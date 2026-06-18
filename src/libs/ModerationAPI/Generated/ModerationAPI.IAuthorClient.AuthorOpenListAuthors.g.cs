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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ModerationAPI.ApiException"></exception>
        /// <remarks>
        /// using System;<br/>
        /// using ModerationApi;<br/>
        /// using ModerationApi.Models.Authors;<br/>
        /// ModerationApiClient client = new();<br/>
        /// AuthorListParams parameters = new();<br/>
        /// var authors = await client.Authors.List(parameters);<br/>
        /// Console.WriteLine(authors);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::ModerationAPI.AuthorOpenListAuthorsResponse> AuthorOpenListAuthorsAsync(
            double? pageSize = default,
            double? pageNumber = default,
            global::ModerationAPI.AuthorOpenListAuthorsSortBy? sortBy = default,
            global::ModerationAPI.AuthorOpenListAuthorsSortDirection? sortDirection = default,
            string? memberSinceDate = default,
            string? lastActiveDate = default,
            string? contentTypes = default,
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ModerationAPI.ApiException"></exception>
        /// <remarks>
        /// using System;<br/>
        /// using ModerationApi;<br/>
        /// using ModerationApi.Models.Authors;<br/>
        /// ModerationApiClient client = new();<br/>
        /// AuthorListParams parameters = new();<br/>
        /// var authors = await client.Authors.List(parameters);<br/>
        /// Console.WriteLine(authors);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::ModerationAPI.AutoSDKHttpResponse<global::ModerationAPI.AuthorOpenListAuthorsResponse>> AuthorOpenListAuthorsAsResponseAsync(
            double? pageSize = default,
            double? pageNumber = default,
            global::ModerationAPI.AuthorOpenListAuthorsSortBy? sortBy = default,
            global::ModerationAPI.AuthorOpenListAuthorsSortDirection? sortDirection = default,
            string? memberSinceDate = default,
            string? lastActiveDate = default,
            string? contentTypes = default,
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}