#nullable enable

namespace ModerationAPI
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Delete a project<br/>
        /// Delete a project with everything in it: channels, queues, API keys and stored content. This can't be undone. The project's API keys stop working at once. Needs the `projects:write` permission.
        /// </summary>
        /// <param name="id">
        /// The ID of the project.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ModerationAPI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ModerationAPI.ManagementProjectsDeleteResponse> ManagementProjectsDeleteAsync(
            string id,
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete a project<br/>
        /// Delete a project with everything in it: channels, queues, API keys and stored content. This can't be undone. The project's API keys stop working at once. Needs the `projects:write` permission.
        /// </summary>
        /// <param name="id">
        /// The ID of the project.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ModerationAPI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ModerationAPI.AutoSDKHttpResponse<global::ModerationAPI.ManagementProjectsDeleteResponse>> ManagementProjectsDeleteAsResponseAsync(
            string id,
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}