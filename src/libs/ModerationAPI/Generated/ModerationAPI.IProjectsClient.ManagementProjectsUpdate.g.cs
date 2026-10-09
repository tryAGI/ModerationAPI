#nullable enable

namespace ModerationAPI
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Update a project<br/>
        /// Update a project. Fields you leave out keep their value. Needs the `projects:write` permission.
        /// </summary>
        /// <param name="id">
        /// The ID of the project to update.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ModerationAPI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ModerationAPI.Project> ManagementProjectsUpdateAsync(
            string id,

            global::ModerationAPI.ManagementProjectsUpdateRequest request,
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a project<br/>
        /// Update a project. Fields you leave out keep their value. Needs the `projects:write` permission.
        /// </summary>
        /// <param name="id">
        /// The ID of the project to update.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ModerationAPI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ModerationAPI.AutoSDKHttpResponse<global::ModerationAPI.Project>> ManagementProjectsUpdateAsResponseAsync(
            string id,

            global::ModerationAPI.ManagementProjectsUpdateRequest request,
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a project<br/>
        /// Update a project. Fields you leave out keep their value. Needs the `projects:write` permission.
        /// </summary>
        /// <param name="id">
        /// The ID of the project to update.
        /// </param>
        /// <param name="name">
        /// The project's name.
        /// </param>
        /// <param name="description">
        /// The project's description.
        /// </param>
        /// <param name="domain">
        /// The website or app the project moderates content for. Setting it on a project without context writes one.
        /// </param>
        /// <param name="context">
        /// What the platform is and who uses it.
        /// </param>
        /// <param name="globalFlaggingMode">
        /// `ACTIVE` flags content. `DRY_RUN` evaluates without flagging.
        /// </param>
        /// <param name="enableRequestLogging">
        /// Whether moderated content is stored and shown in the dashboard.
        /// </param>
        /// <param name="casebookEnabled">
        /// Whether review queue decisions are recorded in the casebook.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ModerationAPI.Project> ManagementProjectsUpdateAsync(
            string id,
            string? name = default,
            string? description = default,
            string? domain = default,
            string? context = default,
            global::ModerationAPI.ManagementProjectsUpdateRequestGlobalFlaggingMode? globalFlaggingMode = default,
            bool? enableRequestLogging = default,
            bool? casebookEnabled = default,
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}