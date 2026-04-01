
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NewModerateModerateRequest
    {
        /// <summary>
        /// The content sent for moderation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ModerationAPI.JsonConverters.OneOfJsonConverter<global::ModerationAPI.NewModerateModerateRequestContentText, global::ModerationAPI.NewModerateModerateRequestContentImage, global::ModerationAPI.NewModerateModerateRequestContentVideo, global::ModerationAPI.NewModerateModerateRequestContentAudio, global::ModerationAPI.NewModerateModerateRequestContentObject>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ModerationAPI.OneOf<global::ModerationAPI.NewModerateModerateRequestContentText, global::ModerationAPI.NewModerateModerateRequestContentImage, global::ModerationAPI.NewModerateModerateRequestContentVideo, global::ModerationAPI.NewModerateModerateRequestContentAudio, global::ModerationAPI.NewModerateModerateRequestContentObject> Content { get; set; }

        /// <summary>
        /// Unix timestamp (in milliseconds) of when the content was created. Use if content is not submitted in real-time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        public double? Timestamp { get; set; }

        /// <summary>
        /// Provide a channel ID or key. Will use the project's default channel if not provided.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("channel")]
        public string? Channel { get; set; }

        /// <summary>
        /// The unique ID of the content in your database.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contentId")]
        public string? ContentId { get; set; }

        /// <summary>
        /// The meta type of content being moderated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metaType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ModerationAPI.JsonConverters.NewModerateModerateRequestMetaTypeJsonConverter))]
        public global::ModerationAPI.NewModerateModerateRequestMetaType? MetaType { get; set; }

        /// <summary>
        /// The author of the content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authorId")]
        public string? AuthorId { get; set; }

        /// <summary>
        /// For example the ID of a chat room or a post
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversationId")]
        public string? ConversationId { get; set; }

        /// <summary>
        /// Any metadata you want to store with the content
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Do not store the content. The content won't enter the review queue
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("doNotStore")]
        public bool? DoNotStore { get; set; }

        /// <summary>
        /// (Enterprise) override the channel policies for this moderation request only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("policies")]
        public global::System.Collections.Generic.IList<global::ModerationAPI.OneOf<global::ModerationAPI.NewModerateModerateRequestPolicieToxicity, global::ModerationAPI.NewModerateModerateRequestPoliciePersonalInformation, global::ModerationAPI.NewModerateModerateRequestPolicieToxicitySevere, global::ModerationAPI.NewModerateModerateRequestPolicieHate, global::ModerationAPI.NewModerateModerateRequestPolicieIllicit, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitDrugs, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitAlcohol, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitFirearms, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitTobacco, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitGambling, global::ModerationAPI.NewModerateModerateRequestPolicieCannabis, global::ModerationAPI.NewModerateModerateRequestPolicieAdult, global::ModerationAPI.NewModerateModerateRequestPolicieCrypto, global::ModerationAPI.NewModerateModerateRequestPolicieSexual, global::ModerationAPI.NewModerateModerateRequestPolicieFlirtation, global::ModerationAPI.NewModerateModerateRequestPolicieProfanity, global::ModerationAPI.NewModerateModerateRequestPolicieViolence, global::ModerationAPI.NewModerateModerateRequestPolicieSelfHarm, global::ModerationAPI.NewModerateModerateRequestPolicieSpam, global::ModerationAPI.NewModerateModerateRequestPolicieSelfPromotion, global::ModerationAPI.NewModerateModerateRequestPoliciePolitical, global::ModerationAPI.NewModerateModerateRequestPolicieReligion, global::ModerationAPI.NewModerateModerateRequestPolicieCodeAbuse, global::ModerationAPI.NewModerateModerateRequestPoliciePiiMasking, global::ModerationAPI.NewModerateModerateRequestPolicieUrlMasking, global::ModerationAPI.NewModerateModerateRequestPolicieGuideline>>? Policies { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();



        /// <summary>
        /// Initializes a new instance of the <see cref="NewModerateModerateRequest" /> class.
        /// </summary>
        public NewModerateModerateRequest()
        {
        }
    }
}