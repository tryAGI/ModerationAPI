#nullable enable

namespace ModerationAPI
{
    public partial interface IAnalyticsClient
    {
        /// <summary>
        /// Get volumes over time<br/>
        /// Get requests, flags, rejections and reviews per hour (24h) or per day (7d, 30d, 90d), oldest first.
        /// </summary>
        /// <param name="range">
        /// The time window. `24h` is the last 24 hours, in hourly buckets. `7d`, `30d` and `90d` are whole UTC days that end with today, in daily buckets.<br/>
        /// Default Value: 30d
        /// </param>
        /// <param name="channel">
        /// A channel ID or key. Only count content from this channel. Leave out to count all channels.
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
        ///   const result = await moderationApi.analytics.volumes();<br/>
        ///   console.log(result);<br/>
        /// }<br/>
        /// run();
        /// </remarks>
        global::System.Threading.Tasks.Task<global::ModerationAPI.GetAnalyticsVolumesResponse> VolumesAsync(
            global::ModerationAPI.GetAnalyticsVolumesRange? range = default,
            string? channel = default,
            string? projectId = default,
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get volumes over time<br/>
        /// Get requests, flags, rejections and reviews per hour (24h) or per day (7d, 30d, 90d), oldest first.
        /// </summary>
        /// <param name="range">
        /// The time window. `24h` is the last 24 hours, in hourly buckets. `7d`, `30d` and `90d` are whole UTC days that end with today, in daily buckets.<br/>
        /// Default Value: 30d
        /// </param>
        /// <param name="channel">
        /// A channel ID or key. Only count content from this channel. Leave out to count all channels.
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
        ///   const result = await moderationApi.analytics.volumes();<br/>
        ///   console.log(result);<br/>
        /// }<br/>
        /// run();
        /// </remarks>
        global::System.Threading.Tasks.Task<global::ModerationAPI.AutoSDKHttpResponse<global::ModerationAPI.GetAnalyticsVolumesResponse>> VolumesAsResponseAsync(
            global::ModerationAPI.GetAnalyticsVolumesRange? range = default,
            string? channel = default,
            string? projectId = default,
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}