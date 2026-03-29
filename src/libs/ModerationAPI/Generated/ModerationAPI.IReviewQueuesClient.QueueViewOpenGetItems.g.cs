#nullable enable

namespace ModerationAPI
{
    public partial interface IReviewQueuesClient
    {
        /// <summary>
        /// Get queue items<br/>
        /// Get paginated list of items in a moderation queue with filtering options
        /// </summary>
        /// <param name="id">
        /// The queue ID
        /// </param>
        /// <param name="pageSize">
        /// Number of items per page<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="pageNumber">
        /// Page number to fetch<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="sortField"></param>
        /// <param name="sortDirection">
        /// Sort direction<br/>
        /// Default Value: desc
        /// </param>
        /// <param name="conversationIds"></param>
        /// <param name="labels"></param>
        /// <param name="afterDate"></param>
        /// <param name="beforeDate"></param>
        /// <param name="includeResolved"></param>
        /// <param name="authorId"></param>
        /// <param name="filteredActionIds"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ModerationAPI.ApiException"></exception>
        /// <remarks>
        /// import ModerationAPI from '@moderation-api/sdk';<br/>
        /// const client = new ModerationAPI({<br/>
        ///   secretKey: process.env['MODAPI_SECRET_KEY'], // This is the default and can be omitted<br/>
        /// });<br/>
        /// const items = await client.queue.items.list('id');<br/>
        /// console.log(items.items);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::ModerationAPI.QueueViewOpenGetItemsResponse> QueueViewOpenGetItemsAsync(
            string id,
            double? pageSize = default,
            double? pageNumber = default,
            global::ModerationAPI.QueueViewOpenGetItemsSortField? sortField = default,
            global::ModerationAPI.QueueViewOpenGetItemsSortDirection? sortDirection = default,
            string? conversationIds = default,
            string? labels = default,
            string? afterDate = default,
            string? beforeDate = default,
            string? includeResolved = default,
            string? authorId = default,
            string? filteredActionIds = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}