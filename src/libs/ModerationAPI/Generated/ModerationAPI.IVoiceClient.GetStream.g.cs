#nullable enable

namespace ModerationAPI
{
    public partial interface IVoiceClient
    {
        /// <summary>
        /// Real-time voice moderation stream (WebSocket)<br/>
        /// Open a WebSocket to moderate live voice/call audio in real time. Speech is transcribed and each finalized utterance is moderated by your enabled text policies; you receive a verdict per utterance as it's spoken.<br/>
        /// **This is a WebSocket upgrade, not a regular HTTP call.** The request body below documents the frames you *send* over the socket; the `101` response documents the events you *receive*.<br/>
        /// - **Auth:** `Authorization: Bearer &lt;api_key&gt;` on the upgrade. A missing/invalid key closes `4401`; voice not enabled on the plan/channel closes `4403`.<br/>
        /// - **Subprotocol:** request `moderationapi.v1`.<br/>
        /// - **Flow:** send one `start` frame, then `media` frames as audio arrives, then `stop` (or disconnect). You receive `session.started`, `utterance.final` per utterance, optional `utterance.partial`/`warning`, and `session.ended`.<br/>
        /// - **Close codes:** `1000` normal · `1011` server error · `4400` bad request · `4401` auth failed · `4403` voice not enabled · `4429` concurrency limit.<br/>
        /// See the [Real-time voice guide](https://docs.moderationapi.com/content-moderation/real-time-voice) for the full walkthrough and code examples.
        /// </summary>
        /// <param name="secWebSocketProtocol"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ModerationAPI.ApiException"></exception>
        global::System.Threading.Tasks.Task GetStreamAsync(
            global::ModerationAPI.GetStreamSecWebSocketProtocol secWebSocketProtocol,

            global::ModerationAPI.GetStreamRequest request,
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Real-time voice moderation stream (WebSocket)<br/>
        /// Open a WebSocket to moderate live voice/call audio in real time. Speech is transcribed and each finalized utterance is moderated by your enabled text policies; you receive a verdict per utterance as it's spoken.<br/>
        /// **This is a WebSocket upgrade, not a regular HTTP call.** The request body below documents the frames you *send* over the socket; the `101` response documents the events you *receive*.<br/>
        /// - **Auth:** `Authorization: Bearer &lt;api_key&gt;` on the upgrade. A missing/invalid key closes `4401`; voice not enabled on the plan/channel closes `4403`.<br/>
        /// - **Subprotocol:** request `moderationapi.v1`.<br/>
        /// - **Flow:** send one `start` frame, then `media` frames as audio arrives, then `stop` (or disconnect). You receive `session.started`, `utterance.final` per utterance, optional `utterance.partial`/`warning`, and `session.ended`.<br/>
        /// - **Close codes:** `1000` normal · `1011` server error · `4400` bad request · `4401` auth failed · `4403` voice not enabled · `4429` concurrency limit.<br/>
        /// See the [Real-time voice guide](https://docs.moderationapi.com/content-moderation/real-time-voice) for the full walkthrough and code examples.
        /// </summary>
        /// <param name="secWebSocketProtocol"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ModerationAPI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ModerationAPI.AutoSDKHttpResponse> GetStreamAsResponseAsync(
            global::ModerationAPI.GetStreamSecWebSocketProtocol secWebSocketProtocol,

            global::ModerationAPI.GetStreamRequest request,
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Real-time voice moderation stream (WebSocket)<br/>
        /// Open a WebSocket to moderate live voice/call audio in real time. Speech is transcribed and each finalized utterance is moderated by your enabled text policies; you receive a verdict per utterance as it's spoken.<br/>
        /// **This is a WebSocket upgrade, not a regular HTTP call.** The request body below documents the frames you *send* over the socket; the `101` response documents the events you *receive*.<br/>
        /// - **Auth:** `Authorization: Bearer &lt;api_key&gt;` on the upgrade. A missing/invalid key closes `4401`; voice not enabled on the plan/channel closes `4403`.<br/>
        /// - **Subprotocol:** request `moderationapi.v1`.<br/>
        /// - **Flow:** send one `start` frame, then `media` frames as audio arrives, then `stop` (or disconnect). You receive `session.started`, `utterance.final` per utterance, optional `utterance.partial`/`warning`, and `session.ended`.<br/>
        /// - **Close codes:** `1000` normal · `1011` server error · `4400` bad request · `4401` auth failed · `4403` voice not enabled · `4429` concurrency limit.<br/>
        /// See the [Real-time voice guide](https://docs.moderationapi.com/content-moderation/real-time-voice) for the full walkthrough and code examples.
        /// </summary>
        /// <param name="secWebSocketProtocol"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task GetStreamAsync(
            global::ModerationAPI.GetStreamSecWebSocketProtocol secWebSocketProtocol,
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}