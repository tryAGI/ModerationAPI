#nullable enable

namespace ModerationAPI
{
    public partial interface IChannelsClient
    {
        /// <summary>
        /// Duplicate a channel<br/>
        /// Copy a channel in its project, with every setting, policy, rule and wordlist. Integrations (Discord, Slack, WordPress) are not copied. Needs the `channels:write` permission.
        /// </summary>
        /// <param name="id">
        /// The ID of the channel to copy.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ModerationAPI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ModerationAPI.Channel> ManagementChannelsDuplicateAsync(
            string id,

            global::ModerationAPI.ManagementChannelsDuplicateRequest request,
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Duplicate a channel<br/>
        /// Copy a channel in its project, with every setting, policy, rule and wordlist. Integrations (Discord, Slack, WordPress) are not copied. Needs the `channels:write` permission.
        /// </summary>
        /// <param name="id">
        /// The ID of the channel to copy.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ModerationAPI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ModerationAPI.AutoSDKHttpResponse<global::ModerationAPI.Channel>> ManagementChannelsDuplicateAsResponseAsync(
            string id,

            global::ModerationAPI.ManagementChannelsDuplicateRequest request,
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Duplicate a channel<br/>
        /// Copy a channel in its project, with every setting, policy, rule and wordlist. Integrations (Discord, Slack, WordPress) are not copied. Needs the `channels:write` permission.
        /// </summary>
        /// <param name="id">
        /// The ID of the channel to copy.
        /// </param>
        /// <param name="name">
        /// Name of the copy. Defaults to the original name with "(copy)".
        /// </param>
        /// <param name="key">
        /// Key of the copy. Defaults to the original key with a timestamp. Must be unique in the project.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ModerationAPI.Channel> ManagementChannelsDuplicateAsync(
            string id,
            string? name = default,
            string? key = default,
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}