#nullable enable

namespace ModerationAPI
{
    public partial interface IChannelsPoliciesClient
    {
        /// <summary>
        /// Get channel policies<br/>
        /// List every policy the channel can use, on and off, with its settings. Call this first: each policy's `key` is what Update channel policies takes, and `available` says whether the plan and channel let it be turned on. `enabled` means the channel runs the policy; `flag` means its result can flag content (when false it only scores). Guidelines and wordlists have their own endpoints. Needs the `channels:read` permission.
        /// </summary>
        /// <param name="id">
        /// The ID of the channel.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ModerationAPI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ModerationAPI.GetChannelPoliciesResponse> RetrieveAsync(
            string id,
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get channel policies<br/>
        /// List every policy the channel can use, on and off, with its settings. Call this first: each policy's `key` is what Update channel policies takes, and `available` says whether the plan and channel let it be turned on. `enabled` means the channel runs the policy; `flag` means its result can flag content (when false it only scores). Guidelines and wordlists have their own endpoints. Needs the `channels:read` permission.
        /// </summary>
        /// <param name="id">
        /// The ID of the channel.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ModerationAPI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ModerationAPI.AutoSDKHttpResponse<global::ModerationAPI.GetChannelPoliciesResponse>> RetrieveAsResponseAsync(
            string id,
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}