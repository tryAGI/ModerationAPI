#nullable enable

namespace ModerationAPI
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Duplicate a project<br/>
        /// Copy a project's configuration into a new project: its settings, every channel with its policies, rules and wordlists, its moderation actions and its review queues. The copy gets its own secret API key. Webhooks, integrations, API keys and content are not copied. Needs the `projects:write` permission and a key that reaches all projects.
        /// </summary>
        /// <param name="id">
        /// The ID of the project to copy.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ModerationAPI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ModerationAPI.ProjectWithKey> ManagementProjectsDuplicateAsync(
            string id,

            global::ModerationAPI.ManagementProjectsDuplicateRequest request,
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Duplicate a project<br/>
        /// Copy a project's configuration into a new project: its settings, every channel with its policies, rules and wordlists, its moderation actions and its review queues. The copy gets its own secret API key. Webhooks, integrations, API keys and content are not copied. Needs the `projects:write` permission and a key that reaches all projects.
        /// </summary>
        /// <param name="id">
        /// The ID of the project to copy.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ModerationAPI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ModerationAPI.AutoSDKHttpResponse<global::ModerationAPI.ProjectWithKey>> ManagementProjectsDuplicateAsResponseAsync(
            string id,

            global::ModerationAPI.ManagementProjectsDuplicateRequest request,
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Duplicate a project<br/>
        /// Copy a project's configuration into a new project: its settings, every channel with its policies, rules and wordlists, its moderation actions and its review queues. The copy gets its own secret API key. Webhooks, integrations, API keys and content are not copied. Needs the `projects:write` permission and a key that reaches all projects.
        /// </summary>
        /// <param name="id">
        /// The ID of the project to copy.
        /// </param>
        /// <param name="name">
        /// Name of the copy. Defaults to the original name with "(copy)".
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ModerationAPI.ProjectWithKey> ManagementProjectsDuplicateAsync(
            string id,
            string? name = default,
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}