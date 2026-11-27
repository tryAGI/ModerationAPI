#nullable enable

namespace ModerationAPI
{
    public partial interface IChannelsPoliciesClient
    {
        /// <summary>
        /// Update channel policies<br/>
        /// Turn policies on or off and change their flag, threshold and settings, by `key` from Get channel policies. Only the policies you send change; settings you leave out keep their value. All changes are saved together, or none when one fails. To make a channel run only a custom guideline, turn the other policies off here and add the guideline with Update channel guidelines. Returns the full list as Get channel policies does. Needs the `channels:write` permission.
        /// </summary>
        /// <param name="id">
        /// The ID of the channel.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ModerationAPI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ModerationAPI.UpdateChannelPoliciesResponse> UpdateAsync(
            string id,

            global::ModerationAPI.UpdateChannelPoliciesRequest request,
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update channel policies<br/>
        /// Turn policies on or off and change their flag, threshold and settings, by `key` from Get channel policies. Only the policies you send change; settings you leave out keep their value. All changes are saved together, or none when one fails. To make a channel run only a custom guideline, turn the other policies off here and add the guideline with Update channel guidelines. Returns the full list as Get channel policies does. Needs the `channels:write` permission.
        /// </summary>
        /// <param name="id">
        /// The ID of the channel.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ModerationAPI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ModerationAPI.AutoSDKHttpResponse<global::ModerationAPI.UpdateChannelPoliciesResponse>> UpdateAsResponseAsync(
            string id,

            global::ModerationAPI.UpdateChannelPoliciesRequest request,
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update channel policies<br/>
        /// Turn policies on or off and change their flag, threshold and settings, by `key` from Get channel policies. Only the policies you send change; settings you leave out keep their value. All changes are saved together, or none when one fails. To make a channel run only a custom guideline, turn the other policies off here and add the guideline with Update channel guidelines. Returns the full list as Get channel policies does. Needs the `channels:write` permission.
        /// </summary>
        /// <param name="id">
        /// The ID of the channel.
        /// </param>
        /// <param name="policies">
        /// The policies to change. Policies you leave out keep their state. All changes are saved together, or none when one fails.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ModerationAPI.UpdateChannelPoliciesResponse> UpdateAsync(
            string id,
            global::System.Collections.Generic.IList<global::ModerationAPI.UpdateChannelPoliciesRequestPolicie> policies,
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}