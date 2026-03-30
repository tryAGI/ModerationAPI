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
        global::System.Threading.Tasks.Task<global::ModerationAPI.NewModerateModerateResponse> NewModerateModerateAsync(
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
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}