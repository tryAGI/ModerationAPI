#nullable enable

namespace ModerationAPI
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Get a project<br/>
        /// Get a project by ID. Needs the `projects:read` permission.
        /// </summary>
        /// <param name="id">
        /// The ID of the project.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ModerationAPI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ModerationAPI.Project> ManagementProjectsGetAsync(
            string id,
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get a project<br/>
        /// Get a project by ID. Needs the `projects:read` permission.
        /// </summary>
        /// <param name="id">
        /// The ID of the project.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ModerationAPI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ModerationAPI.AutoSDKHttpResponse<global::ModerationAPI.Project>> ManagementProjectsGetAsResponseAsync(
            string id,
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}