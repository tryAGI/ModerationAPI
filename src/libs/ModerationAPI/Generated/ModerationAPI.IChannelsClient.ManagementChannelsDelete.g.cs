#nullable enable

namespace ModerationAPI
{
    public partial interface IChannelsClient
    {
        /// <summary>
        /// Delete a channel<br/>
        /// Delete a channel. Its key is freed for a new channel. When it was the default, the oldest remaining channel becomes the default. A channel that still moderates a Slack workspace must be disconnected first. Needs the `channels:write` permission.
        /// </summary>
        /// <param name="id">
        /// The ID of the channel.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ModerationAPI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ModerationAPI.ManagementChannelsDeleteResponse> ManagementChannelsDeleteAsync(
            string id,
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete a channel<br/>
        /// Delete a channel. Its key is freed for a new channel. When it was the default, the oldest remaining channel becomes the default. A channel that still moderates a Slack workspace must be disconnected first. Needs the `channels:write` permission.
        /// </summary>
        /// <param name="id">
        /// The ID of the channel.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ModerationAPI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ModerationAPI.AutoSDKHttpResponse<global::ModerationAPI.ManagementChannelsDeleteResponse>> ManagementChannelsDeleteAsResponseAsync(
            string id,
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}