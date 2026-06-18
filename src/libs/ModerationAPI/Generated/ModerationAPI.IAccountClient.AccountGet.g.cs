#nullable enable

namespace ModerationAPI
{
    public partial interface IAccountClient
    {
        /// <summary>
        /// Get account details<br/>
        /// Get account details
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ModerationAPI.ApiException"></exception>
        /// <remarks>
        /// using System;<br/>
        /// using ModerationApi;<br/>
        /// using ModerationApi.Models.Account;<br/>
        /// ModerationApiClient client = new();<br/>
        /// AccountListParams parameters = new();<br/>
        /// var accounts = await client.Account.List(parameters);<br/>
        /// Console.WriteLine(accounts);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::ModerationAPI.AccountGetResponse> AccountGetAsync(
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get account details<br/>
        /// Get account details
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ModerationAPI.ApiException"></exception>
        /// <remarks>
        /// using System;<br/>
        /// using ModerationApi;<br/>
        /// using ModerationApi.Models.Account;<br/>
        /// ModerationApiClient client = new();<br/>
        /// AccountListParams parameters = new();<br/>
        /// var accounts = await client.Account.List(parameters);<br/>
        /// Console.WriteLine(accounts);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::ModerationAPI.AutoSDKHttpResponse<global::ModerationAPI.AccountGetResponse>> AccountGetAsResponseAsync(
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}