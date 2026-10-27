#nullable enable

namespace ModerationAPI
{
    public partial interface IAnalyticsClient
    {
        /// <summary>
        /// Get the most flagged authors<br/>
        /// Get the authors with the most flagged content in a time window, largest first.
        /// </summary>
        /// <param name="range">
        /// The time window. `24h` is the last 24 hours, in hourly buckets. `7d`, `30d` and `90d` are whole UTC days that end with today, in daily buckets.<br/>
        /// Default Value: 30d
        /// </param>
        /// <param name="channel">
        /// A channel ID or key. Only count content from this channel. Leave out to count all channels.
        /// </param>
        /// <param name="limit">
        /// How many entries to return, largest first. 1 to 50.<br/>
        /// Default Value: 6
        /// </param>
        /// <param name="projectId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ModerationAPI.ApiException"></exception>
        /// <remarks>
        /// import { ModerationApi } from "@moderation-api/sdk";<br/>
        /// const moderationApi = new ModerationApi({<br/>
        ///   secretKey: process.env["MODAPI_SECRET_KEY"] ?? "",<br/>
        /// });<br/>
        /// async function run() {<br/>
        ///   const result = await moderationApi.analytics.authors({});<br/>
        ///   console.log(result);<br/>
        /// }<br/>
        /// run();
        /// </remarks>
        global::System.Threading.Tasks.Task<global::ModerationAPI.GetAnalyticsAuthorsResponse> AuthorsAsync(
            global::ModerationAPI.GetAnalyticsAuthorsRange? range = default,
            string? channel = default,
            int? limit = default,
            string? projectId = default,
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get the most flagged authors<br/>
        /// Get the authors with the most flagged content in a time window, largest first.
        /// </summary>
        /// <param name="range">
        /// The time window. `24h` is the last 24 hours, in hourly buckets. `7d`, `30d` and `90d` are whole UTC days that end with today, in daily buckets.<br/>
        /// Default Value: 30d
        /// </param>
        /// <param name="channel">
        /// A channel ID or key. Only count content from this channel. Leave out to count all channels.
        /// </param>
        /// <param name="limit">
        /// How many entries to return, largest first. 1 to 50.<br/>
        /// Default Value: 6
        /// </param>
        /// <param name="projectId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ModerationAPI.ApiException"></exception>
        /// <remarks>
        /// import { ModerationApi } from "@moderation-api/sdk";<br/>
        /// const moderationApi = new ModerationApi({<br/>
        ///   secretKey: process.env["MODAPI_SECRET_KEY"] ?? "",<br/>
        /// });<br/>
        /// async function run() {<br/>
        ///   const result = await moderationApi.analytics.authors({});<br/>
        ///   console.log(result);<br/>
        /// }<br/>
        /// run();
        /// </remarks>
        global::System.Threading.Tasks.Task<global::ModerationAPI.AutoSDKHttpResponse<global::ModerationAPI.GetAnalyticsAuthorsResponse>> AuthorsAsResponseAsync(
            global::ModerationAPI.GetAnalyticsAuthorsRange? range = default,
            string? channel = default,
            int? limit = default,
            string? projectId = default,
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}