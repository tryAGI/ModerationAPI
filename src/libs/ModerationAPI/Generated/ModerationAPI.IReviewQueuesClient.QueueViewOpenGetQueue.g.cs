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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ModerationAPI.ApiException"></exception>
        /// <remarks>
        /// using System;<br/>
        /// using ModerationApi;<br/>
        /// using ModerationApi.Models.Queue;<br/>
        /// ModerationApiClient client = new();<br/>
        /// QueueRetrieveParams parameters = new() { ID = "id" };<br/>
        /// var queue = await client.Queue.Retrieve(parameters);<br/>
        /// Console.WriteLine(queue);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::ModerationAPI.QueueViewOpenGetQueueResponse> QueueViewOpenGetQueueAsync(
            string id,
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get a queue<br/>
        /// Get a queue
        /// </summary>
        /// <param name="id">
        /// The queue ID
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ModerationAPI.ApiException"></exception>
        /// <remarks>
        /// using System;<br/>
        /// using ModerationApi;<br/>
        /// using ModerationApi.Models.Queue;<br/>
        /// ModerationApiClient client = new();<br/>
        /// QueueRetrieveParams parameters = new() { ID = "id" };<br/>
        /// var queue = await client.Queue.Retrieve(parameters);<br/>
        /// Console.WriteLine(queue);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::ModerationAPI.AutoSDKHttpResponse<global::ModerationAPI.QueueViewOpenGetQueueResponse>> QueueViewOpenGetQueueAsResponseAsync(
            string id,
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}