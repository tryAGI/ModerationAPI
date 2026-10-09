#nullable enable

namespace ModerationAPI
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Create a project<br/>
        /// Create a project with one channel, a review queue inbox and a secret API key. Give a domain or context and the project suggests policies for the platform. Needs the `projects:write` permission and a key that reaches all projects.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ModerationAPI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ModerationAPI.ProjectWithKey> ManagementProjectsCreateAsync(

            global::ModerationAPI.ManagementProjectsCreateRequest request,
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a project<br/>
        /// Create a project with one channel, a review queue inbox and a secret API key. Give a domain or context and the project suggests policies for the platform. Needs the `projects:write` permission and a key that reaches all projects.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ModerationAPI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ModerationAPI.AutoSDKHttpResponse<global::ModerationAPI.ProjectWithKey>> ManagementProjectsCreateAsResponseAsync(

            global::ModerationAPI.ManagementProjectsCreateRequest request,
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a project<br/>
        /// Create a project with one channel, a review queue inbox and a secret API key. Give a domain or context and the project suggests policies for the platform. Needs the `projects:write` permission and a key that reaches all projects.
        /// </summary>
        /// <param name="name">
        /// The project's name.
        /// </param>
        /// <param name="domain">
        /// The website or app the project moderates content for. Used to write the context when none is given.
        /// </param>
        /// <param name="context">
        /// What the platform is and who uses it.
        /// </param>
        /// <param name="brief">
        /// What you moderate, the problems you see and your guidelines.
        /// </param>
        /// <param name="usedByMinors">
        /// Whether children use the platform.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ModerationAPI.ProjectWithKey> ManagementProjectsCreateAsync(
            string name,
            string? domain = default,
            string? context = default,
            string? brief = default,
            bool? usedByMinors = default,
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}