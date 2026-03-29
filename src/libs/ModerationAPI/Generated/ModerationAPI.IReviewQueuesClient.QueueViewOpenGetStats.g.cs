#nullable enable

namespace ModerationAPI
{
    public partial interface IReviewQueuesClient
    {
        /// <summary>
        /// Get queue statistics<br/>
        /// Get detailed statistics about a moderation queue including review times, action counts, and trends
        /// </summary>
        /// <param name="id">
        /// The queue ID
        /// </param>
        /// <param name="withinDays">
        /// Number of days to analyze statistics for<br/>
        /// Default Value: 30
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ModerationAPI.ApiException"></exception>
        /// <remarks>
        /// import ModerationAPI from '@moderation-api/sdk';<br/>
        /// const client = new ModerationAPI({<br/>
        ///   secretKey: process.env['MODAPI_SECRET_KEY'], // This is the default and can be omitted<br/>
        /// });<br/>
        /// const response = await client.queue.getStats('id');<br/>
        /// console.log(response.actionStats);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::ModerationAPI.QueueViewOpenGetStatsResponse> QueueViewOpenGetStatsAsync(
            string id,
            string? withinDays = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}