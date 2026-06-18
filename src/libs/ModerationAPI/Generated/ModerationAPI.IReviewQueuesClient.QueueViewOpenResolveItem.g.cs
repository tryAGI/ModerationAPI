#nullable enable

namespace ModerationAPI
{
    public partial interface IReviewQueuesClient
    {
        /// <summary>
        /// Resolve a queue item<br/>
        /// Mark a queue item as resolved with a specific moderation action
        /// </summary>
        /// <param name="id">
        /// The queue ID
        /// </param>
        /// <param name="itemId">
        /// The item ID to resolve
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ModerationAPI.ApiException"></exception>
        /// <remarks>
        /// using System;<br/>
        /// using ModerationApi;<br/>
        /// using ModerationApi.Models.Queue.Items;<br/>
        /// ModerationApiClient client = new();<br/>
        /// ItemResolveParams parameters = new()<br/>
        /// {<br/>
        ///     ID = "id",<br/>
        ///     ItemID = "itemId",<br/>
        /// };<br/>
        /// var response = await client.Queue.Items.Resolve(parameters);<br/>
        /// Console.WriteLine(response);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::ModerationAPI.QueueViewOpenResolveItemResponse> QueueViewOpenResolveItemAsync(
            string id,
            string itemId,

            global::ModerationAPI.QueueViewOpenResolveItemRequest request,
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Resolve a queue item<br/>
        /// Mark a queue item as resolved with a specific moderation action
        /// </summary>
        /// <param name="id">
        /// The queue ID
        /// </param>
        /// <param name="itemId">
        /// The item ID to resolve
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ModerationAPI.ApiException"></exception>
        /// <remarks>
        /// using System;<br/>
        /// using ModerationApi;<br/>
        /// using ModerationApi.Models.Queue.Items;<br/>
        /// ModerationApiClient client = new();<br/>
        /// ItemResolveParams parameters = new()<br/>
        /// {<br/>
        ///     ID = "id",<br/>
        ///     ItemID = "itemId",<br/>
        /// };<br/>
        /// var response = await client.Queue.Items.Resolve(parameters);<br/>
        /// Console.WriteLine(response);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::ModerationAPI.AutoSDKHttpResponse<global::ModerationAPI.QueueViewOpenResolveItemResponse>> QueueViewOpenResolveItemAsResponseAsync(
            string id,
            string itemId,

            global::ModerationAPI.QueueViewOpenResolveItemRequest request,
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Resolve a queue item<br/>
        /// Mark a queue item as resolved with a specific moderation action
        /// </summary>
        /// <param name="id">
        /// The queue ID
        /// </param>
        /// <param name="itemId">
        /// The item ID to resolve
        /// </param>
        /// <param name="comment">
        /// Optional comment
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ModerationAPI.QueueViewOpenResolveItemResponse> QueueViewOpenResolveItemAsync(
            string id,
            string itemId,
            string? comment = default,
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}