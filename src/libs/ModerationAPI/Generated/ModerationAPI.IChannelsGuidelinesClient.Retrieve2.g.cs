#nullable enable

namespace ModerationAPI
{
    public partial interface IChannelsGuidelinesClient
    {
        /// <summary>
        /// Get channel guidelines<br/>
        /// List the channel's guidelines. A guideline is a custom policy written in plain words: an AI model checks each message against its instructions and flags it when it matches. Needs the `channels:read` permission.
        /// </summary>
        /// <param name="id">
        /// The ID of the channel.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ModerationAPI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ModerationAPI.GetChannelGuidelinesResponse> Retrieve2Async(
            string id,
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get channel guidelines<br/>
        /// List the channel's guidelines. A guideline is a custom policy written in plain words: an AI model checks each message against its instructions and flags it when it matches. Needs the `channels:read` permission.
        /// </summary>
        /// <param name="id">
        /// The ID of the channel.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ModerationAPI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ModerationAPI.AutoSDKHttpResponse<global::ModerationAPI.GetChannelGuidelinesResponse>> Retrieve2AsResponseAsync(
            string id,
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}