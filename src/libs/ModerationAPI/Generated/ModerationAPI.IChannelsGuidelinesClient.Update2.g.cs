#nullable enable

namespace ModerationAPI
{
    public partial interface IChannelsGuidelinesClient
    {
        /// <summary>
        /// Update channel guidelines<br/>
        /// Add, change or delete guidelines by key. A new key adds a guideline and needs `instructions`; an existing key changes it; `enabled: false` deletes it with its instructions. Write instructions as one or two plain sentences that say what to flag. The key shows in results and rules, so use a short name such as `sales_pitch`. Only the guidelines you send change. All changes are saved together, or none when one fails. Needs the `channels:write` permission.
        /// </summary>
        /// <param name="id">
        /// The ID of the channel.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ModerationAPI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ModerationAPI.UpdateChannelGuidelinesResponse> Update2Async(
            string id,

            global::ModerationAPI.UpdateChannelGuidelinesRequest request,
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update channel guidelines<br/>
        /// Add, change or delete guidelines by key. A new key adds a guideline and needs `instructions`; an existing key changes it; `enabled: false` deletes it with its instructions. Write instructions as one or two plain sentences that say what to flag. The key shows in results and rules, so use a short name such as `sales_pitch`. Only the guidelines you send change. All changes are saved together, or none when one fails. Needs the `channels:write` permission.
        /// </summary>
        /// <param name="id">
        /// The ID of the channel.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ModerationAPI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ModerationAPI.AutoSDKHttpResponse<global::ModerationAPI.UpdateChannelGuidelinesResponse>> Update2AsResponseAsync(
            string id,

            global::ModerationAPI.UpdateChannelGuidelinesRequest request,
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update channel guidelines<br/>
        /// Add, change or delete guidelines by key. A new key adds a guideline and needs `instructions`; an existing key changes it; `enabled: false` deletes it with its instructions. Write instructions as one or two plain sentences that say what to flag. The key shows in results and rules, so use a short name such as `sales_pitch`. Only the guidelines you send change. All changes are saved together, or none when one fails. Needs the `channels:write` permission.
        /// </summary>
        /// <param name="id">
        /// The ID of the channel.
        /// </param>
        /// <param name="guidelines">
        /// The guidelines to add, change or delete. Guidelines you leave out stay as they are. All changes are saved together, or none when one fails.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ModerationAPI.UpdateChannelGuidelinesResponse> Update2Async(
            string id,
            global::System.Collections.Generic.IList<global::ModerationAPI.UpdateChannelGuidelinesRequestGuideline> guidelines,
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}