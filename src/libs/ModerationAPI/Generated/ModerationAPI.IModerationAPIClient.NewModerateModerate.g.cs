#nullable enable

namespace ModerationAPI
{
    public partial interface IModerationAPIClient
    {
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
        global::System.Threading.Tasks.Task<global::ModerationAPI.NewModerateModerateResponse> NewModerateModerateAsync(

            global::ModerationAPI.NewModerateModerateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

    }
}