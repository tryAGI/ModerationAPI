#nullable enable

namespace ModerationAPI
{
    public partial interface IChannelsWordlistsClient
    {
        /// <summary>
        /// Update channel wordlists<br/>
        /// Make the channel use wordlists or stop using them, and set how each one matches. Only the wordlists you send change. All changes are saved together, or none when one fails. Needs the `channels:write` permission.
        /// </summary>
        /// <param name="id">
        /// The ID of the channel.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ModerationAPI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ModerationAPI.UpdateChannelWordlistsResponse> Update3Async(
            string id,

            global::ModerationAPI.UpdateChannelWordlistsRequest request,
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update channel wordlists<br/>
        /// Make the channel use wordlists or stop using them, and set how each one matches. Only the wordlists you send change. All changes are saved together, or none when one fails. Needs the `channels:write` permission.
        /// </summary>
        /// <param name="id">
        /// The ID of the channel.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ModerationAPI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ModerationAPI.AutoSDKHttpResponse<global::ModerationAPI.UpdateChannelWordlistsResponse>> Update3AsResponseAsync(
            string id,

            global::ModerationAPI.UpdateChannelWordlistsRequest request,
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update channel wordlists<br/>
        /// Make the channel use wordlists or stop using them, and set how each one matches. Only the wordlists you send change. All changes are saved together, or none when one fails. Needs the `channels:write` permission.
        /// </summary>
        /// <param name="id">
        /// The ID of the channel.
        /// </param>
        /// <param name="wordlists">
        /// The wordlists to change. Wordlists you leave out keep their state. All changes are saved together, or none when one fails.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ModerationAPI.UpdateChannelWordlistsResponse> Update3Async(
            string id,
            global::System.Collections.Generic.IList<global::ModerationAPI.UpdateChannelWordlistsRequestWordlist> wordlists,
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}