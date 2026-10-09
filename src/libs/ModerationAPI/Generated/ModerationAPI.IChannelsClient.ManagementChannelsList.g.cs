#nullable enable

namespace ModerationAPI
{
    public partial interface IChannelsClient
    {
        /// <summary>
        /// List channels<br/>
        /// List the channels in a project. Needs the `channels:read` permission.
        /// </summary>
        /// <param name="projectId">
        /// The ID of the project.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ModerationAPI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::ModerationAPI.Channel>> ManagementChannelsListAsync(
            string projectId,
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List channels<br/>
        /// List the channels in a project. Needs the `channels:read` permission.
        /// </summary>
        /// <param name="projectId">
        /// The ID of the project.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ModerationAPI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ModerationAPI.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::ModerationAPI.Channel>>> ManagementChannelsListAsResponseAsync(
            string projectId,
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}