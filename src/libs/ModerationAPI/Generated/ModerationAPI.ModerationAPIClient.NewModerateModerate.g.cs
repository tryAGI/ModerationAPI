
#nullable enable

namespace ModerationAPI
{
    public partial class ModerationAPIClient
    {
        partial void PrepareNewModerateModerateArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::ModerationAPI.NewModerateModerateRequest request);
        partial void PrepareNewModerateModerateRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::ModerationAPI.NewModerateModerateRequest request);
        partial void ProcessNewModerateModerateResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessNewModerateModerateResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ModerationAPI.ApiException"></exception>
        /// <remarks>
        /// import ModerationAPI from '@moderation-api/sdk';<br/>
        /// const client = new ModerationAPI({<br/>
        ///   secretKey: process.env['MODAPI_SECRET_KEY'], // This is the default and can be omitted<br/>
        /// });<br/>
        /// const response = await client.content.submit({ content: { text: 'x', type: 'text' } });<br/>
        /// console.log(response.author);
        /// </remarks>
        public async global::System.Threading.Tasks.Task<global::ModerationAPI.NewModerateModerateResponse> NewModerateModerateAsync(

            global::ModerationAPI.NewModerateModerateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareNewModerateModerateArguments(
                httpClient: HttpClient,
                request: request);

            var __pathBuilder = new global::ModerationAPI.PathBuilder(
                path: "/moderate",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in Authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2")
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
            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareNewModerateModerateRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessNewModerateModerateResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Invalid input data
            if ((int)__response.StatusCode == 400)
            {
                string? __content_400 = null;
                global::System.Exception? __exception_400 = null;
                global::ModerationAPI.ErrorBadRequest? __value_400 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_400 = global::ModerationAPI.ErrorBadRequest.FromJson(__content_400, JsonSerializerContext);
                    }
                    else
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_400 = global::ModerationAPI.ErrorBadRequest.FromJson(__content_400, JsonSerializerContext);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_400 = __ex;
                }

                throw new global::ModerationAPI.ApiException<global::ModerationAPI.ErrorBadRequest>(
                    message: __content_400 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_400,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_400,
                    ResponseObject = __value_400,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // Authorization not provided
            if ((int)__response.StatusCode == 401)
            {
                string? __content_401 = null;
                global::System.Exception? __exception_401 = null;
                global::ModerationAPI.ErrorUnauthorized? __value_401 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_401 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_401 = global::ModerationAPI.ErrorUnauthorized.FromJson(__content_401, JsonSerializerContext);
                    }
                    else
                    {
                        __content_401 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_401 = global::ModerationAPI.ErrorUnauthorized.FromJson(__content_401, JsonSerializerContext);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_401 = __ex;
                }

                throw new global::ModerationAPI.ApiException<global::ModerationAPI.ErrorUnauthorized>(
                    message: __content_401 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_401,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_401,
                    ResponseObject = __value_401,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // Insufficient access
            if ((int)__response.StatusCode == 403)
            {
                string? __content_403 = null;
                global::System.Exception? __exception_403 = null;
                global::ModerationAPI.ErrorForbidden? __value_403 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_403 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_403 = global::ModerationAPI.ErrorForbidden.FromJson(__content_403, JsonSerializerContext);
                    }
                    else
                    {
                        __content_403 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_403 = global::ModerationAPI.ErrorForbidden.FromJson(__content_403, JsonSerializerContext);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_403 = __ex;
                }

                throw new global::ModerationAPI.ApiException<global::ModerationAPI.ErrorForbidden>(
                    message: __content_403 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_403,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_403,
                    ResponseObject = __value_403,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // Internal server error
            if ((int)__response.StatusCode == 500)
            {
                string? __content_500 = null;
                global::System.Exception? __exception_500 = null;
                global::ModerationAPI.ErrorInternalServerError? __value_500 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_500 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_500 = global::ModerationAPI.ErrorInternalServerError.FromJson(__content_500, JsonSerializerContext);
                    }
                    else
                    {
                        __content_500 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_500 = global::ModerationAPI.ErrorInternalServerError.FromJson(__content_500, JsonSerializerContext);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_500 = __ex;
                }

                throw new global::ModerationAPI.ApiException<global::ModerationAPI.ErrorInternalServerError>(
                    message: __content_500 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_500,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_500,
                    ResponseObject = __value_500,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessNewModerateModerateResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::ModerationAPI.NewModerateModerateResponse.FromJson(__content, JsonSerializerContext) ??
                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                }
                catch (global::System.Exception __ex)
                {
                    throw new global::ModerationAPI.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();

                    using var __content = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                    return
                        await global::ModerationAPI.NewModerateModerateResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                }
                catch (global::System.Exception __ex)
                {
                    string? __content = null;
                    try
                    {
                        __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                            cancellationToken
#endif
                        ).ConfigureAwait(false);
                    }
                    catch (global::System.Exception)
                    {
                    }

                    throw new global::ModerationAPI.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="content">
        /// The content sent for moderation
        /// </param>
        /// <param name="timestamp">
        /// Unix timestamp (in milliseconds) of when the content was created. Use if content is not submitted in real-time.
        /// </param>
        /// <param name="channel">
        /// Provide a channel ID or key. Will use the project's default channel if not provided.
        /// </param>
        /// <param name="contentId">
        /// The unique ID of the content in your database.
        /// </param>
        /// <param name="metaType">
        /// The meta type of content being moderated
        /// </param>
        /// <param name="authorId">
        /// The author of the content.
        /// </param>
        /// <param name="conversationId">
        /// For example the ID of a chat room or a post
        /// </param>
        /// <param name="metadata">
        /// Any metadata you want to store with the content
        /// </param>
        /// <param name="doNotStore">
        /// Do not store the content. The content won't enter the review queue
        /// </param>
        /// <param name="policies">
        /// (Enterprise) override the channel policies for this moderation request only.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::ModerationAPI.NewModerateModerateResponse> NewModerateModerateAsync(
            global::ModerationAPI.OneOf<global::ModerationAPI.NewModerateModerateRequestContentText, global::ModerationAPI.NewModerateModerateRequestContentImage, global::ModerationAPI.NewModerateModerateRequestContentVideo, global::ModerationAPI.NewModerateModerateRequestContentAudio, global::ModerationAPI.NewModerateModerateRequestContentObject> content,
            double? timestamp = default,
            string? channel = default,
            string? contentId = default,
            global::ModerationAPI.NewModerateModerateRequestMetaType? metaType = default,
            string? authorId = default,
            string? conversationId = default,
            object? metadata = default,
            bool? doNotStore = default,
            global::System.Collections.Generic.IList<global::ModerationAPI.OneOf<global::ModerationAPI.NewModerateModerateRequestPolicieToxicity, global::ModerationAPI.NewModerateModerateRequestPoliciePersonalInformation, global::ModerationAPI.NewModerateModerateRequestPolicieToxicitySevere, global::ModerationAPI.NewModerateModerateRequestPolicieHate, global::ModerationAPI.NewModerateModerateRequestPolicieIllicit, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitDrugs, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitAlcohol, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitFirearms, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitTobacco, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitGambling, global::ModerationAPI.NewModerateModerateRequestPolicieCannabis, global::ModerationAPI.NewModerateModerateRequestPolicieAdult, global::ModerationAPI.NewModerateModerateRequestPolicieCrypto, global::ModerationAPI.NewModerateModerateRequestPolicieSexual, global::ModerationAPI.NewModerateModerateRequestPolicieFlirtation, global::ModerationAPI.NewModerateModerateRequestPolicieProfanity, global::ModerationAPI.NewModerateModerateRequestPolicieViolence, global::ModerationAPI.NewModerateModerateRequestPolicieSelfHarm, global::ModerationAPI.NewModerateModerateRequestPolicieSpam, global::ModerationAPI.NewModerateModerateRequestPolicieSelfPromotion, global::ModerationAPI.NewModerateModerateRequestPoliciePolitical, global::ModerationAPI.NewModerateModerateRequestPolicieReligion, global::ModerationAPI.NewModerateModerateRequestPolicieCodeAbuse, global::ModerationAPI.NewModerateModerateRequestPoliciePiiMasking, global::ModerationAPI.NewModerateModerateRequestPolicieUrlMasking, global::ModerationAPI.NewModerateModerateRequestPolicieGuideline>>? policies = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {

            var __request = new global::ModerationAPI.NewModerateModerateRequest
            {
                Content = content,
                Timestamp = timestamp,
                Channel = channel,
                ContentId = contentId,
                MetaType = metaType,
                AuthorId = authorId,
                ConversationId = conversationId,
                Metadata = metadata,
                DoNotStore = doNotStore,
                Policies = policies,
            };

            return await NewModerateModerateAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}