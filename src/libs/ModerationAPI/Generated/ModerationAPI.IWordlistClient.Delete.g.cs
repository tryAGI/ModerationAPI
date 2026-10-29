#nullable enable

namespace ModerationAPI
{
    public partial interface IWordlistClient
    {
        /// <summary>
        /// Delete wordlist<br/>
        /// Delete a wordlist and its words. Channels that use the wordlist do not block the delete: the wordlist is removed from their policies. `detachedChannelIds` lists those channels. This cannot be undone.
        /// </summary>
        /// <param name="id">
        /// ID of the wordlist to delete
        /// </param>
        /// <param name="projectId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ModerationAPI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ModerationAPI.DeleteWordlistResponse> DeleteAsync(
            string id,
            string? projectId = default,
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete wordlist<br/>
        /// Delete a wordlist and its words. Channels that use the wordlist do not block the delete: the wordlist is removed from their policies. `detachedChannelIds` lists those channels. This cannot be undone.
        /// </summary>
        /// <param name="id">
        /// ID of the wordlist to delete
        /// </param>
        /// <param name="projectId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ModerationAPI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ModerationAPI.AutoSDKHttpResponse<global::ModerationAPI.DeleteWordlistResponse>> DeleteAsResponseAsync(
            string id,
            string? projectId = default,
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}