#nullable enable

namespace ModerationAPI
{
    public partial interface IReviewQueuesClient
    {
        /// <summary>
        /// Get a queue<br/>
        /// Get a queue
        /// </summary>
        /// <param name="id">
        /// The queue ID
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ModerationAPI.ApiException"></exception>
        /// <remarks>
        /// import ModerationAPI from '@moderation-api/sdk';<br/>
        /// const client = new ModerationAPI({<br/>
        ///   secretKey: process.env['MODAPI_SECRET_KEY'], // This is the default and can be omitted<br/>
        /// });<br/>
        /// const queue = await client.queue.retrieve('id');<br/>
        /// console.log(queue.queue);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::ModerationAPI.QueueViewOpenGetQueueResponse> QueueViewOpenGetQueueAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}