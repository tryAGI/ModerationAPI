
#nullable enable

namespace ModerationAPI
{
    public partial class VoiceClient
    {


        private static readonly global::ModerationAPI.EndPointSecurityRequirement s_GetStreamSecurityRequirement0 =
            new global::ModerationAPI.EndPointSecurityRequirement
            {
                Authorizations = new global::ModerationAPI.EndPointAuthorizationRequirement[]
                {                    new global::ModerationAPI.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        SchemeId = "HttpBearer",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::ModerationAPI.EndPointSecurityRequirement[] s_GetStreamSecurityRequirements =
            new global::ModerationAPI.EndPointSecurityRequirement[]
            {                s_GetStreamSecurityRequirement0,
            };
        partial void PrepareGetStreamArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::ModerationAPI.GetStreamSecWebSocketProtocol secWebSocketProtocol,
            global::ModerationAPI.GetStreamRequest request);
        partial void PrepareGetStreamRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::ModerationAPI.GetStreamSecWebSocketProtocol secWebSocketProtocol,
            global::ModerationAPI.GetStreamRequest request);
        partial void ProcessGetStreamResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

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
        public async global::System.Threading.Tasks.Task GetStreamAsync(
            global::ModerationAPI.GetStreamSecWebSocketProtocol secWebSocketProtocol,

            global::ModerationAPI.GetStreamRequest request,
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            await GetStreamAsResponseAsync(
                secWebSocketProtocol: secWebSocketProtocol,

                request: request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);
        }
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
        public async global::System.Threading.Tasks.Task<global::ModerationAPI.AutoSDKHttpResponse> GetStreamAsResponseAsync(
            global::ModerationAPI.GetStreamSecWebSocketProtocol secWebSocketProtocol,

            global::ModerationAPI.GetStreamRequest request,
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareGetStreamArguments(
                httpClient: HttpClient,
                secWebSocketProtocol: ref secWebSocketProtocol,
                request: request);


            var __authorizations = global::ModerationAPI.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_GetStreamSecurityRequirements,
                operationName: "GetStreamAsync");

            using var __timeoutCancellationTokenSource = global::ModerationAPI.AutoSDKRequestOptionsSupport.CreateTimeoutCancellationTokenSource(
                clientOptions: Options,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken);
            var __effectiveCancellationToken = __timeoutCancellationTokenSource?.Token ?? cancellationToken;
            var __effectiveReadResponseAsString = global::ModerationAPI.AutoSDKRequestOptionsSupport.GetReadResponseAsString(
                clientOptions: Options,
                requestOptions: requestOptions,
                fallbackValue: ReadResponseAsString);
            var __maxAttempts = global::ModerationAPI.AutoSDKRequestOptionsSupport.GetMaxAttempts(
                clientOptions: Options,
                requestOptions: requestOptions,
                supportsRetry: true);

            global::System.Net.Http.HttpRequestMessage __CreateHttpRequest()
            {

                            var __pathBuilder = new global::ModerationAPI.PathBuilder(
                                path: "/stream",
                                baseUri: HttpClient.BaseAddress ?? new global::System.Uri("wss://voice.moderationapi.com/v1", global::System.UriKind.RelativeOrAbsolute));
                            var __path = __pathBuilder.ToString();
                __path = global::ModerationAPI.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Get,
                    requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
                __httpRequest.Version = global::System.Net.HttpVersion.Version11;
                __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2" ||
                    __authorization.Type == "OpenIdConnect")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                } 
            }

                __httpRequest.Headers.TryAddWithoutValidation("Sec-WebSocket-Protocol", secWebSocketProtocol.ToValueString());

                            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
                            var __httpRequestContent = new global::System.Net.Http.StringContent(
                                content: __httpRequestContentBody,
                                encoding: global::System.Text.Encoding.UTF8,
                                mediaType: "application/json");
                            __httpRequest.Content = __httpRequestContent;
                global::ModerationAPI.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareGetStreamRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    secWebSocketProtocol: secWebSocketProtocol!,
                    request: request);

                return __httpRequest;
            }

            global::System.Net.Http.HttpRequestMessage? __httpRequest = null;
            global::System.Net.Http.HttpResponseMessage? __response = null;
            var __attemptNumber = 0;
            try
            {
                for (var __attempt = 1; __attempt <= __maxAttempts; __attempt++)
                {
                    __attemptNumber = __attempt;
                    __httpRequest = __CreateHttpRequest();
                    await global::ModerationAPI.AutoSDKRequestOptionsSupport.OnBeforeRequestAsync(
                            clientOptions: Options,
                            context: global::ModerationAPI.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "getStream",
                                methodName: "GetStreamAsync",
                                pathTemplate: "\"/stream\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                    try
                    {
                        __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                    }
                    catch (global::System.Net.Http.HttpRequestException __exception)
                    {
                        var __retryDelay = global::ModerationAPI.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: null,
                            attempt: __attempt);
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::ModerationAPI.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::ModerationAPI.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "getStream",
                                methodName: "GetStreamAsync",
                                pathTemplate: "\"/stream\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: __exception,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: __willRetry,
                                retryDelay: __willRetry ? __retryDelay : (global::System.TimeSpan?)null,
                                retryReason: "exception",
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::ModerationAPI.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::ModerationAPI.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        var __retryDelay = global::ModerationAPI.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: __response,
                            attempt: __attempt);
                        await global::ModerationAPI.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::ModerationAPI.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "getStream",
                                methodName: "GetStreamAsync",
                                pathTemplate: "\"/stream\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: true,
                                retryDelay: __retryDelay,
                                retryReason: "status:" + ((int)__response.StatusCode).ToString(global::System.Globalization.CultureInfo.InvariantCulture),
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::ModerationAPI.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    break;
                }

                if (__response == null)
                {
                    throw new global::System.InvalidOperationException("No response received.");
                }

                using (__response)
                {

                ProcessResponse(
                    client: HttpClient,
                    response: __response);
                ProcessGetStreamResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::ModerationAPI.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::ModerationAPI.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "getStream",
                                methodName: "GetStreamAsync",
                                pathTemplate: "\"/stream\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::ModerationAPI.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::ModerationAPI.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "getStream",
                                methodName: "GetStreamAsync",
                                pathTemplate: "\"/stream\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                            // Switching Protocols. The server then streams event frames over the socket; the key one is `utterance.final`.
                            if ((int)__response.StatusCode == 101)
                            {
                                string? __content_101 = null;
                                global::System.Exception? __exception_101 = null;
                                global::ModerationAPI.GetStreamResponse? __value_101 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_101 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_101 = global::ModerationAPI.GetStreamResponse.FromJson(__content_101, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_101 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_101 = global::ModerationAPI.GetStreamResponse.FromJson(__content_101, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_101 = __ex;
                                }


                                throw global::ModerationAPI.ApiException<global::ModerationAPI.GetStreamResponse?>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_101 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_101,
                                    responseBody: __content_101,
                                    responseObject: __value_101,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }

                            if (__effectiveReadResponseAsString)
                            {
                                var __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                    __effectiveCancellationToken
                #endif
                                ).ConfigureAwait(false);

                                ProcessResponseContent(
                                    client: HttpClient,
                                    response: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                return new global::ModerationAPI.AutoSDKHttpResponse(
                                        statusCode: __response.StatusCode,
                                        headers: global::ModerationAPI.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    throw global::ModerationAPI.ApiException.Create(
                                        statusCode: __response.StatusCode,
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        responseBody: __content,
                                        responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value));
                                }
                            }
                            else
                            {
                                try
                                {
                                    __response.EnsureSuccessStatusCode();
                                    return new global::ModerationAPI.AutoSDKHttpResponse(
                                        statusCode: __response.StatusCode,
                                        headers: global::ModerationAPI.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    string? __content = null;
                                    try
                                    {
                                        __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                            __effectiveCancellationToken
                #endif
                                        ).ConfigureAwait(false);
                                    }
                                    catch (global::System.Exception)
                                    {
                                    }

                                    throw global::ModerationAPI.ApiException.Create(
                                        statusCode: __response.StatusCode,
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        responseBody: __content,
                                        responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value));
                                }
                            }

                }
            }
            finally
            {
                __httpRequest?.Dispose();
            }
        }
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
        public async global::System.Threading.Tasks.Task GetStreamAsync(
            global::ModerationAPI.GetStreamSecWebSocketProtocol secWebSocketProtocol,
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::ModerationAPI.GetStreamRequest
            {
            };

            await GetStreamAsync(
                secWebSocketProtocol: secWebSocketProtocol,
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}