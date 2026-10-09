#nullable enable

namespace ModerationAPI
{
    public partial interface IWebhooksClient
    {
        /// <summary>
        /// List webhooks<br/>
        /// List all webhooks for the authenticated project.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ModerationAPI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::ModerationAPI.WebhooksPublicListResponseItem>> WebhooksPublicListAsync(
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List webhooks<br/>
        /// List all webhooks for the authenticated project.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ModerationAPI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ModerationAPI.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::ModerationAPI.WebhooksPublicListResponseItem>>> WebhooksPublicListAsResponseAsync(
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}