#nullable enable

namespace ModerationAPI
{
    public partial interface IReviewQueuesClient
    {
        /// <summary>
        /// Unresolve a queue item<br/>
        /// Mark a previously resolved queue item as unresolved/pending
        /// </summary>
        /// <param name="id">
        /// The queue ID
        /// </param>
        /// <param name="itemId">
        /// The item ID to unresolve
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
        /// ItemUnresolveParams parameters = new()<br/>
        /// {<br/>
        ///     ID = "id",<br/>
        ///     ItemID = "itemId",<br/>
        /// };<br/>
        /// var response = await client.Queue.Items.Unresolve(parameters);<br/>
        /// Console.WriteLine(response);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::ModerationAPI.QueueViewOpenUnresolveItemResponse> QueueViewOpenUnresolveItemAsync(
            string id,
            string itemId,

            global::ModerationAPI.QueueViewOpenUnresolveItemRequest request,
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Unresolve a queue item<br/>
        /// Mark a previously resolved queue item as unresolved/pending
        /// </summary>
        /// <param name="id">
        /// The queue ID
        /// </param>
        /// <param name="itemId">
        /// The item ID to unresolve
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
        /// ItemUnresolveParams parameters = new()<br/>
        /// {<br/>
        ///     ID = "id",<br/>
        ///     ItemID = "itemId",<br/>
        /// };<br/>
        /// var response = await client.Queue.Items.Unresolve(parameters);<br/>
        /// Console.WriteLine(response);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::ModerationAPI.AutoSDKHttpResponse<global::ModerationAPI.QueueViewOpenUnresolveItemResponse>> QueueViewOpenUnresolveItemAsResponseAsync(
            string id,
            string itemId,

            global::ModerationAPI.QueueViewOpenUnresolveItemRequest request,
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Unresolve a queue item<br/>
        /// Mark a previously resolved queue item as unresolved/pending
        /// </summary>
        /// <param name="id">
        /// The queue ID
        /// </param>
        /// <param name="itemId">
        /// The item ID to unresolve
        /// </param>
        /// <param name="comment">
        /// Optional reason for unresolving the item
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ModerationAPI.QueueViewOpenUnresolveItemResponse> QueueViewOpenUnresolveItemAsync(
            string id,
            string itemId,
            string? comment = default,
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}