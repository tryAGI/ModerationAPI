#nullable enable

namespace ModerationAPI
{
    public partial interface IProjectsApiKeysClient
    {
        /// <summary>
        /// Create a project API key<br/>
        /// Create a new secret API key for a project and return it. Give each app or computer its own key, so you can revoke one without breaking the others. The project's existing keys keep working. Needs the `projects:write` permission.
        /// </summary>
        /// <param name="id">
        /// The ID of the project.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ModerationAPI.ApiException"></exception>
        /// <remarks>
        /// import { ModerationApi } from "@moderation-api/sdk";<br/>
        /// const moderationApi = new ModerationApi({<br/>
        ///   secretKey: process.env["MODAPI_SECRET_KEY"] ?? "",<br/>
        /// });<br/>
        /// async function run() {<br/>
        ///   const result = await moderationApi.projects.apiKeys.create("&lt;id&gt;", {});<br/>
        ///   console.log(result);<br/>
        /// }<br/>
        /// run();
        /// </remarks>
        global::System.Threading.Tasks.Task<global::ModerationAPI.ProjectApiKey> CreateAsync(
            string id,

            global::ModerationAPI.CreateProjectApiKeyRequest request,
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a project API key<br/>
        /// Create a new secret API key for a project and return it. Give each app or computer its own key, so you can revoke one without breaking the others. The project's existing keys keep working. Needs the `projects:write` permission.
        /// </summary>
        /// <param name="id">
        /// The ID of the project.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ModerationAPI.ApiException"></exception>
        /// <remarks>
        /// import { ModerationApi } from "@moderation-api/sdk";<br/>
        /// const moderationApi = new ModerationApi({<br/>
        ///   secretKey: process.env["MODAPI_SECRET_KEY"] ?? "",<br/>
        /// });<br/>
        /// async function run() {<br/>
        ///   const result = await moderationApi.projects.apiKeys.create("&lt;id&gt;", {});<br/>
        ///   console.log(result);<br/>
        /// }<br/>
        /// run();
        /// </remarks>
        global::System.Threading.Tasks.Task<global::ModerationAPI.AutoSDKHttpResponse<global::ModerationAPI.ProjectApiKey>> CreateAsResponseAsync(
            string id,

            global::ModerationAPI.CreateProjectApiKeyRequest request,
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a project API key<br/>
        /// Create a new secret API key for a project and return it. Give each app or computer its own key, so you can revoke one without breaking the others. The project's existing keys keep working. Needs the `projects:write` permission.
        /// </summary>
        /// <param name="id">
        /// The ID of the project.
        /// </param>
        /// <param name="name">
        /// A name for the key, shown on the API keys page of the dashboard. Name it after where the key is used, for example the app or the computer.<br/>
        /// Default Value: API key
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ModerationAPI.ProjectApiKey> CreateAsync(
            string id,
            string? name = default,
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}