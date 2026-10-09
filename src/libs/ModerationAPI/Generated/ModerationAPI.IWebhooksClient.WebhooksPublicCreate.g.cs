#nullable enable

namespace ModerationAPI
{
    public partial interface IWebhooksClient
    {
        /// <summary>
        /// Create a webhook<br/>
        /// Create a webhook subscribed to one or more event types. Deliveries use the v2 envelope and are signed with the project signing secret (see the signing secret endpoint).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ModerationAPI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ModerationAPI.WebhooksPublicCreateResponse> WebhooksPublicCreateAsync(

            global::ModerationAPI.WebhooksPublicCreateRequest request,
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a webhook<br/>
        /// Create a webhook subscribed to one or more event types. Deliveries use the v2 envelope and are signed with the project signing secret (see the signing secret endpoint).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ModerationAPI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ModerationAPI.AutoSDKHttpResponse<global::ModerationAPI.WebhooksPublicCreateResponse>> WebhooksPublicCreateAsResponseAsync(

            global::ModerationAPI.WebhooksPublicCreateRequest request,
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a webhook<br/>
        /// Create a webhook subscribed to one or more event types. Deliveries use the v2 envelope and are signed with the project signing secret (see the signing secret endpoint).
        /// </summary>
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
        global::System.Threading.Tasks.Task<global::ModerationAPI.WebhooksPublicCreateResponse> WebhooksPublicCreateAsync(
            string name,
            string url,
            global::System.Collections.Generic.IList<global::ModerationAPI.WebhooksPublicCreateRequestEventType> eventTypes,
            string? description = default,
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}