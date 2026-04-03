
#nullable enable

namespace ModerationAPI
{
    public partial class ReviewQueuesClient
    {
        partial void PrepareQueueViewOpenGetItemsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string id,
            ref double? pageSize,
            ref double? pageNumber,
            ref global::ModerationAPI.QueueViewOpenGetItemsSortField? sortField,
            ref global::ModerationAPI.QueueViewOpenGetItemsSortDirection? sortDirection,
            ref string? conversationIds,
            ref string? labels,
            ref string? afterDate,
            ref string? beforeDate,
            ref string? includeResolved,
            ref string? authorId,
            ref string? filteredActionIds);
        partial void PrepareQueueViewOpenGetItemsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string id,
            double? pageSize,
            double? pageNumber,
            global::ModerationAPI.QueueViewOpenGetItemsSortField? sortField,
            global::ModerationAPI.QueueViewOpenGetItemsSortDirection? sortDirection,
            string? conversationIds,
            string? labels,
            string? afterDate,
            string? beforeDate,
            string? includeResolved,
            string? authorId,
            string? filteredActionIds);
        partial void ProcessQueueViewOpenGetItemsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessQueueViewOpenGetItemsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get queue items<br/>
        /// Get paginated list of items in a moderation queue with filtering options
        /// </summary>
        /// <param name="id">
        /// The queue ID
        /// </param>
        /// <param name="pageSize">
        /// Number of items per page<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="pageNumber">
        /// Page number to fetch<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="sortField"></param>
        /// <param name="sortDirection">
        /// Sort direction<br/>
        /// Default Value: desc
        /// </param>
        /// <param name="conversationIds"></param>
        /// <param name="labels"></param>
        /// <param name="afterDate"></param>
        /// <param name="beforeDate"></param>
        /// <param name="includeResolved"></param>
        /// <param name="authorId"></param>
        /// <param name="filteredActionIds"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ModerationAPI.ApiException"></exception>
        /// <remarks>
        /// import ModerationAPI from '@moderation-api/sdk';<br/>
        /// const client = new ModerationAPI({<br/>
        ///   secretKey: process.env['MODAPI_SECRET_KEY'], // This is the default and can be omitted<br/>
        /// });<br/>
        /// const items = await client.queue.items.list('id');<br/>
        /// console.log(items.items);
        /// </remarks>
        public async global::System.Threading.Tasks.Task<global::ModerationAPI.QueueViewOpenGetItemsResponse> QueueViewOpenGetItemsAsync(
            string id,
            double? pageSize = default,
            double? pageNumber = default,
            global::ModerationAPI.QueueViewOpenGetItemsSortField? sortField = default,
            global::ModerationAPI.QueueViewOpenGetItemsSortDirection? sortDirection = default,
            string? conversationIds = default,
            string? labels = default,
            string? afterDate = default,
            string? beforeDate = default,
            string? includeResolved = default,
            string? authorId = default,
            string? filteredActionIds = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareQueueViewOpenGetItemsArguments(
                httpClient: HttpClient,
                id: ref id,
                pageSize: ref pageSize,
                pageNumber: ref pageNumber,
                sortField: ref sortField,
                sortDirection: ref sortDirection,
                conversationIds: ref conversationIds,
                labels: ref labels,
                afterDate: ref afterDate,
                beforeDate: ref beforeDate,
                includeResolved: ref includeResolved,
                authorId: ref authorId,
                filteredActionIds: ref filteredActionIds);

            var __pathBuilder = new global::ModerationAPI.PathBuilder(
                path: $"/queue/{id}/items",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("pageSize", pageSize?.ToString())
                .AddOptionalParameter("pageNumber", pageNumber?.ToString())
                .AddOptionalParameter("sortField", sortField?.ToValueString())
                .AddOptionalParameter("sortDirection", sortDirection?.ToValueString())
                .AddOptionalParameter("conversationIds", conversationIds)
                .AddOptionalParameter("labels", labels)
                .AddOptionalParameter("afterDate", afterDate)
                .AddOptionalParameter("beforeDate", beforeDate)
                .AddOptionalParameter("includeResolved", includeResolved)
                .AddOptionalParameter("authorId", authorId)
                .AddOptionalParameter("filteredActionIds", filteredActionIds) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
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

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareQueueViewOpenGetItemsRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                id: id,
                pageSize: pageSize,
                pageNumber: pageNumber,
                sortField: sortField,
                sortDirection: sortDirection,
                conversationIds: conversationIds,
                labels: labels,
                afterDate: afterDate,
                beforeDate: beforeDate,
                includeResolved: includeResolved,
                authorId: authorId,
                filteredActionIds: filteredActionIds);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessQueueViewOpenGetItemsResponse(
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
            // Not found
            if ((int)__response.StatusCode == 404)
            {
                string? __content_404 = null;
                global::System.Exception? __exception_404 = null;
                global::ModerationAPI.ErrorNotFound? __value_404 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_404 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_404 = global::ModerationAPI.ErrorNotFound.FromJson(__content_404, JsonSerializerContext);
                    }
                    else
                    {
                        __content_404 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_404 = global::ModerationAPI.ErrorNotFound.FromJson(__content_404, JsonSerializerContext);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_404 = __ex;
                }

                throw new global::ModerationAPI.ApiException<global::ModerationAPI.ErrorNotFound>(
                    message: __content_404 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_404,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_404,
                    ResponseObject = __value_404,
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
                ProcessQueueViewOpenGetItemsResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::ModerationAPI.QueueViewOpenGetItemsResponse.FromJson(__content, JsonSerializerContext) ??
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
                        await global::ModerationAPI.QueueViewOpenGetItemsResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
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
    }
}