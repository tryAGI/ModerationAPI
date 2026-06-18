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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ModerationAPI.ApiException"></exception>
        /// <remarks>
        /// using System;<br/>
        /// using ModerationApi;<br/>
        /// using ModerationApi.Models.Queue;<br/>
        /// ModerationApiClient client = new();<br/>
        /// QueueGetStatsParams parameters = new() { ID = "id" };<br/>
        /// var response = await client.Queue.GetStats(parameters);<br/>
        /// Console.WriteLine(response);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::ModerationAPI.QueueViewOpenGetStatsResponse> QueueViewOpenGetStatsAsync(
            string id,
            string? withinDays = default,
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ModerationAPI.ApiException"></exception>
        /// <remarks>
        /// using System;<br/>
        /// using ModerationApi;<br/>
        /// using ModerationApi.Models.Queue;<br/>
        /// ModerationApiClient client = new();<br/>
        /// QueueGetStatsParams parameters = new() { ID = "id" };<br/>
        /// var response = await client.Queue.GetStats(parameters);<br/>
        /// Console.WriteLine(response);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::ModerationAPI.AutoSDKHttpResponse<global::ModerationAPI.QueueViewOpenGetStatsResponse>> QueueViewOpenGetStatsAsResponseAsync(
            string id,
            string? withinDays = default,
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}