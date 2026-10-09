#nullable enable

namespace ModerationAPI
{
    public partial interface IWebhooksClient
    {
        /// <summary>
        /// Update a webhook<br/>
        /// Update a webhook. Legacy v1 webhooks are read-only: delete them and create a new webhook instead.
        /// </summary>
        /// <param name="id">
        /// The ID of the webhook to update.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ModerationAPI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ModerationAPI.WebhooksPublicUpdateResponse> WebhooksPublicUpdateAsync(
            string id,

            global::ModerationAPI.WebhooksPublicUpdateRequest request,
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a webhook<br/>
        /// Update a webhook. Legacy v1 webhooks are read-only: delete them and create a new webhook instead.
        /// </summary>
        /// <param name="id">
        /// The ID of the webhook to update.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ModerationAPI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ModerationAPI.AutoSDKHttpResponse<global::ModerationAPI.WebhooksPublicUpdateResponse>> WebhooksPublicUpdateAsResponseAsync(
            string id,

            global::ModerationAPI.WebhooksPublicUpdateRequest request,
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a webhook<br/>
        /// Update a webhook. Legacy v1 webhooks are read-only: delete them and create a new webhook instead.
        /// </summary>
        /// <param name="id">
        /// The ID of the webhook to update.
        /// </param>
        /// <param name="name">
        /// The webhook's name, used to identify it in the dashboard
        /// </param>
        /// <param name="description">
        /// The webhook's description
        /// </param>
        /// <param name="url">
        /// The webhook's URL. We'll call this URL when an event occurs.
        /// </param>
        /// <param name="eventTypes">
        /// Event types this webhook subscribes to. One webhook URL receives all events you list here.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ModerationAPI.WebhooksPublicUpdateResponse> WebhooksPublicUpdateAsync(
            string id,
            string? name = default,
            string? description = default,
            string? url = default,
            global::System.Collections.Generic.IList<global::ModerationAPI.WebhooksPublicUpdateRequestEventType>? eventTypes = default,
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}