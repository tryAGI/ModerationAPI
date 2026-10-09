#nullable enable

namespace ModerationAPI
{
    public partial interface IWebhooksClient
    {
        /// <summary>
        /// Get the webhook signing secret<br/>
        /// Get the signing secret used to sign webhook deliveries for this project, creating one if none exists yet. Verify deliveries by comparing the `modapi-signature` header to HMAC-SHA256(raw request body, secret) hex-encoded.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ModerationAPI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ModerationAPI.WebhooksPublicGetSecretResponse> WebhooksPublicGetSecretAsync(
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get the webhook signing secret<br/>
        /// Get the signing secret used to sign webhook deliveries for this project, creating one if none exists yet. Verify deliveries by comparing the `modapi-signature` header to HMAC-SHA256(raw request body, secret) hex-encoded.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ModerationAPI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ModerationAPI.AutoSDKHttpResponse<global::ModerationAPI.WebhooksPublicGetSecretResponse>> WebhooksPublicGetSecretAsResponseAsync(
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}