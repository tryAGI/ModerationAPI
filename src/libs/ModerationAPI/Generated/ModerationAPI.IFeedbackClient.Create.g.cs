#nullable enable

namespace ModerationAPI
{
    public partial interface IFeedbackClient
    {
        /// <summary>
        /// Send feedback<br/>
        /// Sends a feature request, bug report or other feedback to the Moderation API team. The team reads every request and can reply by email. Limited to 5 requests per minute per organization.
        /// </summary>
        /// <param name="projectId"></param>
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
        ///   const result = await moderationApi.feedback.create({<br/>
        ///     body: {<br/>
        ///       title: "Filter queue items by author trust level",<br/>
        ///       description: "We review queue items by hand. We want to see items from new authors first, so we need a filter for trust level on the queue items list.",<br/>
        ///       source: "mcp",<br/>
        ///     },<br/>
        ///   });<br/>
        ///   console.log(result);<br/>
        /// }<br/>
        /// run();
        /// </remarks>
        global::System.Threading.Tasks.Task<global::ModerationAPI.CreateFeedbackResponse> CreateAsync(

            global::ModerationAPI.CreateFeedbackRequest request,
            string? projectId = default,
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Send feedback<br/>
        /// Sends a feature request, bug report or other feedback to the Moderation API team. The team reads every request and can reply by email. Limited to 5 requests per minute per organization.
        /// </summary>
        /// <param name="projectId"></param>
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
        ///   const result = await moderationApi.feedback.create({<br/>
        ///     body: {<br/>
        ///       title: "Filter queue items by author trust level",<br/>
        ///       description: "We review queue items by hand. We want to see items from new authors first, so we need a filter for trust level on the queue items list.",<br/>
        ///       source: "mcp",<br/>
        ///     },<br/>
        ///   });<br/>
        ///   console.log(result);<br/>
        /// }<br/>
        /// run();
        /// </remarks>
        global::System.Threading.Tasks.Task<global::ModerationAPI.AutoSDKHttpResponse<global::ModerationAPI.CreateFeedbackResponse>> CreateAsResponseAsync(

            global::ModerationAPI.CreateFeedbackRequest request,
            string? projectId = default,
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Send feedback<br/>
        /// Sends a feature request, bug report or other feedback to the Moderation API team. The team reads every request and can reply by email. Limited to 5 requests per minute per organization.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="title">
        /// A short summary of the request.
        /// </param>
        /// <param name="description">
        /// What you tried to do, why, and what is missing or does not work. Plain text. Blank lines start new paragraphs.
        /// </param>
        /// <param name="type">
        /// The kind of feedback.<br/>
        /// Default Value: feature_request
        /// </param>
        /// <param name="source">
        /// Where the feedback was written: MCP server, agent skill, CLI or API.<br/>
        /// Default Value: api
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ModerationAPI.CreateFeedbackResponse> CreateAsync(
            string title,
            string description,
            string? projectId = default,
            global::ModerationAPI.CreateFeedbackRequestType? type = default,
            global::ModerationAPI.CreateFeedbackRequestSource? source = default,
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}