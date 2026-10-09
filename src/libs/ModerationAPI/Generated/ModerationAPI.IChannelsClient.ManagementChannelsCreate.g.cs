#nullable enable

namespace ModerationAPI
{
    public partial interface IChannelsClient
    {
        /// <summary>
        /// Create a channel<br/>
        /// Create a channel in a project, with the default rules. The project's first channel becomes its default. Needs the `channels:write` permission.
        /// </summary>
        /// <param name="projectId">
        /// The ID of the project to add the channel to.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ModerationAPI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ModerationAPI.Channel> ManagementChannelsCreateAsync(
            string projectId,

            global::ModerationAPI.ManagementChannelsCreateRequest request,
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a channel<br/>
        /// Create a channel in a project, with the default rules. The project's first channel becomes its default. Needs the `channels:write` permission.
        /// </summary>
        /// <param name="projectId">
        /// The ID of the project to add the channel to.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ModerationAPI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ModerationAPI.AutoSDKHttpResponse<global::ModerationAPI.Channel>> ManagementChannelsCreateAsResponseAsync(
            string projectId,

            global::ModerationAPI.ManagementChannelsCreateRequest request,
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a channel<br/>
        /// Create a channel in a project, with the default rules. The project's first channel becomes its default. Needs the `channels:write` permission.
        /// </summary>
        /// <param name="projectId">
        /// The ID of the project to add the channel to.
        /// </param>
        /// <param name="name">
        /// The channel's name.
        /// </param>
        /// <param name="key">
        /// The key you pass as `channel` when you moderate content. Defaults to the name in lowercase with dashes. Must be unique in the project.
        /// </param>
        /// <param name="description">
        /// The channel's description.
        /// </param>
        /// <param name="contentType">
        /// The kind of content the channel moderates.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ModerationAPI.Channel> ManagementChannelsCreateAsync(
            string projectId,
            string name,
            string? key = default,
            string? description = default,
            global::ModerationAPI.ManagementChannelsCreateRequestContentType? contentType = default,
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}