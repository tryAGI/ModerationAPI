#nullable enable

namespace ModerationAPI
{
    public partial interface IChannelsWordlistsClient
    {
        /// <summary>
        /// Get channel wordlists<br/>
        /// List every wordlist in the organization, with whether the channel uses it and how it matches. To create a wordlist or add and remove its words, use the wordlist endpoints; then turn it on for the channel with Update channel wordlists. Needs the `channels:read` permission.
        /// </summary>
        /// <param name="id">
        /// The ID of the channel.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ModerationAPI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ModerationAPI.GetChannelWordlistsResponse> Retrieve3Async(
            string id,
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get channel wordlists<br/>
        /// List every wordlist in the organization, with whether the channel uses it and how it matches. To create a wordlist or add and remove its words, use the wordlist endpoints; then turn it on for the channel with Update channel wordlists. Needs the `channels:read` permission.
        /// </summary>
        /// <param name="id">
        /// The ID of the channel.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ModerationAPI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ModerationAPI.AutoSDKHttpResponse<global::ModerationAPI.GetChannelWordlistsResponse>> Retrieve3AsResponseAsync(
            string id,
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}