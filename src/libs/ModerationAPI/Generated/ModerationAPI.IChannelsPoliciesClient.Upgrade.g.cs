#nullable enable

namespace ModerationAPI
{
    public partial interface IChannelsPoliciesClient
    {
        /// <summary>
        /// Upgrade a channel policy<br/>
        /// Move the channel off a legacy policy onto the policy that replaces it (`upgradeTo` in Get channel policies). The new policy keeps the settings, scores the same, and the channel's rules read the new policy. Needs the `channels:write` permission.
        /// </summary>
        /// <param name="id">
        /// The ID of the channel.
        /// </param>
        /// <param name="policyId">
        /// The ID of the legacy policy, for example `illicit_alcohol`. Policies with an `upgradeTo` can be upgraded.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ModerationAPI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ModerationAPI.UpgradeChannelPolicyResponse> UpgradeAsync(
            string id,
            global::ModerationAPI.UpgradeChannelPolicyPolicyId policyId,
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upgrade a channel policy<br/>
        /// Move the channel off a legacy policy onto the policy that replaces it (`upgradeTo` in Get channel policies). The new policy keeps the settings, scores the same, and the channel's rules read the new policy. Needs the `channels:write` permission.
        /// </summary>
        /// <param name="id">
        /// The ID of the channel.
        /// </param>
        /// <param name="policyId">
        /// The ID of the legacy policy, for example `illicit_alcohol`. Policies with an `upgradeTo` can be upgraded.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ModerationAPI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ModerationAPI.AutoSDKHttpResponse<global::ModerationAPI.UpgradeChannelPolicyResponse>> UpgradeAsResponseAsync(
            string id,
            global::ModerationAPI.UpgradeChannelPolicyPolicyId policyId,
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}