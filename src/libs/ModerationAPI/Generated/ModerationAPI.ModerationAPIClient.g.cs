
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// API for automated content moderation<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class ModerationAPIClient : global::ModerationAPI.IModerationAPIClient, global::System.IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        public const string DefaultBaseUrl = "https://api.moderationapi.com/v1";

        private bool _disposeHttpClient = true;

        /// <inheritdoc/>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <inheritdoc/>
        public System.Uri? BaseUri => HttpClient.BaseAddress;

        /// <inheritdoc/>
        public global::System.Collections.Generic.List<global::ModerationAPI.EndPointAuthorization> Authorizations { get; }

        /// <inheritdoc/>
        public bool ReadResponseAsString { get; set; }
#if DEBUG
            = true;
#endif
        /// <summary>
        /// 
        /// </summary>
        #pragma warning disable CS0618 // Type or member is obsolete
        public global::System.Text.Json.JsonSerializerOptions JsonSerializerOptions { get; set; } = new global::System.Text.Json.JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                Converters =
                {
                    new global::ModerationAPI.JsonConverters.ActionsCreateRequestType2JsonConverter(),
                    new global::ModerationAPI.JsonConverters.ActionsCreateRequestType2NullableJsonConverter(),
                    new global::ModerationAPI.JsonConverters.ActionsCreateRequestQueueBehaviourJsonConverter(),
                    new global::ModerationAPI.JsonConverters.ActionsCreateRequestQueueBehaviourNullableJsonConverter(),
                    new global::ModerationAPI.JsonConverters.ActionsCreateRequestPositionJsonConverter(),
                    new global::ModerationAPI.JsonConverters.ActionsCreateRequestPositionNullableJsonConverter(),
                    new global::ModerationAPI.JsonConverters.ActionsUpdateRequestType2JsonConverter(),
                    new global::ModerationAPI.JsonConverters.ActionsUpdateRequestType2NullableJsonConverter(),
                    new global::ModerationAPI.JsonConverters.ActionsUpdateRequestQueueBehaviourJsonConverter(),
                    new global::ModerationAPI.JsonConverters.ActionsUpdateRequestQueueBehaviourNullableJsonConverter(),
                    new global::ModerationAPI.JsonConverters.ActionsUpdateRequestPositionJsonConverter(),
                    new global::ModerationAPI.JsonConverters.ActionsUpdateRequestPositionNullableJsonConverter(),
                    new global::ModerationAPI.JsonConverters.ModerationObjectRequestValueTypeJsonConverter(),
                    new global::ModerationAPI.JsonConverters.ModerationObjectRequestValueTypeNullableJsonConverter(),
                    new global::ModerationAPI.JsonConverters.ModerationObjectRequestValueDataTypeJsonConverter(),
                    new global::ModerationAPI.JsonConverters.ModerationObjectRequestValueDataTypeNullableJsonConverter(),
                    new global::ModerationAPI.JsonConverters.NewModerateModerateRequestMetaTypeJsonConverter(),
                    new global::ModerationAPI.JsonConverters.NewModerateModerateRequestMetaTypeNullableJsonConverter(),
                    new global::ModerationAPI.JsonConverters.AuthorOpenListAuthorsSortByJsonConverter(),
                    new global::ModerationAPI.JsonConverters.AuthorOpenListAuthorsSortByNullableJsonConverter(),
                    new global::ModerationAPI.JsonConverters.AuthorOpenListAuthorsSortDirectionJsonConverter(),
                    new global::ModerationAPI.JsonConverters.AuthorOpenListAuthorsSortDirectionNullableJsonConverter(),
                    new global::ModerationAPI.JsonConverters.QueueViewOpenGetItemsSortFieldJsonConverter(),
                    new global::ModerationAPI.JsonConverters.QueueViewOpenGetItemsSortFieldNullableJsonConverter(),
                    new global::ModerationAPI.JsonConverters.QueueViewOpenGetItemsSortDirectionJsonConverter(),
                    new global::ModerationAPI.JsonConverters.QueueViewOpenGetItemsSortDirectionNullableJsonConverter(),
                    new global::ModerationAPI.JsonConverters.AuthorOpenListAuthorsResponseAuthorStatusJsonConverter(),
                    new global::ModerationAPI.JsonConverters.AuthorOpenListAuthorsResponseAuthorStatusNullableJsonConverter(),
                    new global::ModerationAPI.JsonConverters.AuthorOpenCreateResponseStatusJsonConverter(),
                    new global::ModerationAPI.JsonConverters.AuthorOpenCreateResponseStatusNullableJsonConverter(),
                    new global::ModerationAPI.JsonConverters.AuthorOpenGetAuthorDetailsResponseStatusJsonConverter(),
                    new global::ModerationAPI.JsonConverters.AuthorOpenGetAuthorDetailsResponseStatusNullableJsonConverter(),
                    new global::ModerationAPI.JsonConverters.AuthorOpenUpdateResponseStatusJsonConverter(),
                    new global::ModerationAPI.JsonConverters.AuthorOpenUpdateResponseStatusNullableJsonConverter(),
                    new global::ModerationAPI.JsonConverters.QueueViewOpenGetQueueResponseQueueFilterFilterLabelTypeJsonConverter(),
                    new global::ModerationAPI.JsonConverters.QueueViewOpenGetQueueResponseQueueFilterFilterLabelTypeNullableJsonConverter(),
                    new global::ModerationAPI.JsonConverters.QueueViewOpenGetQueueResponseQueueFilterRecommendationActionJsonConverter(),
                    new global::ModerationAPI.JsonConverters.QueueViewOpenGetQueueResponseQueueFilterRecommendationActionNullableJsonConverter(),
                    new global::ModerationAPI.JsonConverters.QueueViewOpenGetItemsResponseItemStatusJsonConverter(),
                    new global::ModerationAPI.JsonConverters.QueueViewOpenGetItemsResponseItemStatusNullableJsonConverter(),
                    new global::ModerationAPI.JsonConverters.ActionsListResponseItemType2JsonConverter(),
                    new global::ModerationAPI.JsonConverters.ActionsListResponseItemType2NullableJsonConverter(),
                    new global::ModerationAPI.JsonConverters.ActionsListResponseItemQueueBehaviourJsonConverter(),
                    new global::ModerationAPI.JsonConverters.ActionsListResponseItemQueueBehaviourNullableJsonConverter(),
                    new global::ModerationAPI.JsonConverters.ActionsListResponseItemPositionJsonConverter(),
                    new global::ModerationAPI.JsonConverters.ActionsListResponseItemPositionNullableJsonConverter(),
                    new global::ModerationAPI.JsonConverters.ActionsCreateResponseType2JsonConverter(),
                    new global::ModerationAPI.JsonConverters.ActionsCreateResponseType2NullableJsonConverter(),
                    new global::ModerationAPI.JsonConverters.ActionsCreateResponseQueueBehaviourJsonConverter(),
                    new global::ModerationAPI.JsonConverters.ActionsCreateResponseQueueBehaviourNullableJsonConverter(),
                    new global::ModerationAPI.JsonConverters.ActionsCreateResponsePositionJsonConverter(),
                    new global::ModerationAPI.JsonConverters.ActionsCreateResponsePositionNullableJsonConverter(),
                    new global::ModerationAPI.JsonConverters.ActionsGetResponseType2JsonConverter(),
                    new global::ModerationAPI.JsonConverters.ActionsGetResponseType2NullableJsonConverter(),
                    new global::ModerationAPI.JsonConverters.ActionsGetResponseQueueBehaviourJsonConverter(),
                    new global::ModerationAPI.JsonConverters.ActionsGetResponseQueueBehaviourNullableJsonConverter(),
                    new global::ModerationAPI.JsonConverters.ActionsGetResponsePositionJsonConverter(),
                    new global::ModerationAPI.JsonConverters.ActionsGetResponsePositionNullableJsonConverter(),
                    new global::ModerationAPI.JsonConverters.ActionsUpdateResponseType2JsonConverter(),
                    new global::ModerationAPI.JsonConverters.ActionsUpdateResponseType2NullableJsonConverter(),
                    new global::ModerationAPI.JsonConverters.ActionsUpdateResponseQueueBehaviourJsonConverter(),
                    new global::ModerationAPI.JsonConverters.ActionsUpdateResponseQueueBehaviourNullableJsonConverter(),
                    new global::ModerationAPI.JsonConverters.ActionsUpdateResponsePositionJsonConverter(),
                    new global::ModerationAPI.JsonConverters.ActionsUpdateResponsePositionNullableJsonConverter(),
                    new global::ModerationAPI.JsonConverters.ModerationTextResponseVariant1AuthorStatusJsonConverter(),
                    new global::ModerationAPI.JsonConverters.ModerationTextResponseVariant1AuthorStatusNullableJsonConverter(),
                    new global::ModerationAPI.JsonConverters.ModerationTextResponseVariant1EmailModeJsonConverter(),
                    new global::ModerationAPI.JsonConverters.ModerationTextResponseVariant1EmailModeNullableJsonConverter(),
                    new global::ModerationAPI.JsonConverters.ModerationTextResponseVariant1PhoneModeJsonConverter(),
                    new global::ModerationAPI.JsonConverters.ModerationTextResponseVariant1PhoneModeNullableJsonConverter(),
                    new global::ModerationAPI.JsonConverters.ModerationTextResponseVariant1UrlModeJsonConverter(),
                    new global::ModerationAPI.JsonConverters.ModerationTextResponseVariant1UrlModeNullableJsonConverter(),
                    new global::ModerationAPI.JsonConverters.ModerationTextResponseVariant1AddressModeJsonConverter(),
                    new global::ModerationAPI.JsonConverters.ModerationTextResponseVariant1AddressModeNullableJsonConverter(),
                    new global::ModerationAPI.JsonConverters.ModerationTextResponseVariant1NameModeJsonConverter(),
                    new global::ModerationAPI.JsonConverters.ModerationTextResponseVariant1NameModeNullableJsonConverter(),
                    new global::ModerationAPI.JsonConverters.ModerationTextResponseVariant1UsernameModeJsonConverter(),
                    new global::ModerationAPI.JsonConverters.ModerationTextResponseVariant1UsernameModeNullableJsonConverter(),
                    new global::ModerationAPI.JsonConverters.ModerationTextResponseVariant1ProfanityModeJsonConverter(),
                    new global::ModerationAPI.JsonConverters.ModerationTextResponseVariant1ProfanityModeNullableJsonConverter(),
                    new global::ModerationAPI.JsonConverters.ModerationTextResponseVariant1SensitiveModeJsonConverter(),
                    new global::ModerationAPI.JsonConverters.ModerationTextResponseVariant1SensitiveModeNullableJsonConverter(),
                    new global::ModerationAPI.JsonConverters.ModerationTextResponseVariant1WordlistModeJsonConverter(),
                    new global::ModerationAPI.JsonConverters.ModerationTextResponseVariant1WordlistModeNullableJsonConverter(),
                    new global::ModerationAPI.JsonConverters.ModerationTextResponseVariant1WordlistMode2JsonConverter(),
                    new global::ModerationAPI.JsonConverters.ModerationTextResponseVariant1WordlistMode2NullableJsonConverter(),
                    new global::ModerationAPI.JsonConverters.ModerationObjectResponseVariant1AuthorStatusJsonConverter(),
                    new global::ModerationAPI.JsonConverters.ModerationObjectResponseVariant1AuthorStatusNullableJsonConverter(),
                    new global::ModerationAPI.JsonConverters.ModerationObjectResponseVariant1WordlistModeJsonConverter(),
                    new global::ModerationAPI.JsonConverters.ModerationObjectResponseVariant1WordlistModeNullableJsonConverter(),
                    new global::ModerationAPI.JsonConverters.ModerationImageResponseAuthorStatusJsonConverter(),
                    new global::ModerationAPI.JsonConverters.ModerationImageResponseAuthorStatusNullableJsonConverter(),
                    new global::ModerationAPI.JsonConverters.ModerationImageResponseLabelLabelJsonConverter(),
                    new global::ModerationAPI.JsonConverters.ModerationImageResponseLabelLabelNullableJsonConverter(),
                    new global::ModerationAPI.JsonConverters.ModerationVideoResponseVariant1AuthorStatusJsonConverter(),
                    new global::ModerationAPI.JsonConverters.ModerationVideoResponseVariant1AuthorStatusNullableJsonConverter(),
                    new global::ModerationAPI.JsonConverters.ModerationAudioResponseAuthorStatusJsonConverter(),
                    new global::ModerationAPI.JsonConverters.ModerationAudioResponseAuthorStatusNullableJsonConverter(),
                    new global::ModerationAPI.JsonConverters.NewModerateModerateResponseAuthorStatusJsonConverter(),
                    new global::ModerationAPI.JsonConverters.NewModerateModerateResponseAuthorStatusNullableJsonConverter(),
                    new global::ModerationAPI.JsonConverters.NewModerateModerateResponseRecommendationActionJsonConverter(),
                    new global::ModerationAPI.JsonConverters.NewModerateModerateResponseRecommendationActionNullableJsonConverter(),
                    new global::ModerationAPI.JsonConverters.NewModerateModerateResponseRecommendationReasonCodeJsonConverter(),
                    new global::ModerationAPI.JsonConverters.NewModerateModerateResponseRecommendationReasonCodeNullableJsonConverter(),
                    new global::ModerationAPI.JsonConverters.NewModerateModerateResponseInsightSentimentInsightValue2JsonConverter(),
                    new global::ModerationAPI.JsonConverters.NewModerateModerateResponseInsightSentimentInsightValue2NullableJsonConverter(),
                    new global::ModerationAPI.JsonConverters.NewModerateModerateResponseMetaStatusJsonConverter(),
                    new global::ModerationAPI.JsonConverters.NewModerateModerateResponseMetaStatusNullableJsonConverter(),
                    new global::ModerationAPI.JsonConverters.OneOfJsonConverter<global::ModerationAPI.NewModerateModerateRequestContentText, global::ModerationAPI.NewModerateModerateRequestContentImage, global::ModerationAPI.NewModerateModerateRequestContentVideo, global::ModerationAPI.NewModerateModerateRequestContentAudio, global::ModerationAPI.NewModerateModerateRequestContentObject>(),
                    new global::ModerationAPI.JsonConverters.OneOfJsonConverter<global::ModerationAPI.NewModerateModerateRequestContentObjectDataText, global::ModerationAPI.NewModerateModerateRequestContentObjectDataImage, global::ModerationAPI.NewModerateModerateRequestContentObjectDataVideo, global::ModerationAPI.NewModerateModerateRequestContentObjectDataAudio>(),
                    new global::ModerationAPI.JsonConverters.OneOfJsonConverter<global::ModerationAPI.NewModerateModerateRequestPolicieToxicity, global::ModerationAPI.NewModerateModerateRequestPoliciePersonalInformation, global::ModerationAPI.NewModerateModerateRequestPolicieToxicitySevere, global::ModerationAPI.NewModerateModerateRequestPolicieHate, global::ModerationAPI.NewModerateModerateRequestPolicieIllicit, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitDrugs, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitAlcohol, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitFirearms, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitTobacco, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitGambling, global::ModerationAPI.NewModerateModerateRequestPolicieCannabis, global::ModerationAPI.NewModerateModerateRequestPolicieAdult, global::ModerationAPI.NewModerateModerateRequestPolicieCrypto, global::ModerationAPI.NewModerateModerateRequestPolicieSexual, global::ModerationAPI.NewModerateModerateRequestPolicieFlirtation, global::ModerationAPI.NewModerateModerateRequestPolicieProfanity, global::ModerationAPI.NewModerateModerateRequestPolicieViolence, global::ModerationAPI.NewModerateModerateRequestPolicieSelfHarm, global::ModerationAPI.NewModerateModerateRequestPolicieSpam, global::ModerationAPI.NewModerateModerateRequestPolicieSelfPromotion, global::ModerationAPI.NewModerateModerateRequestPoliciePolitical, global::ModerationAPI.NewModerateModerateRequestPolicieReligion, global::ModerationAPI.NewModerateModerateRequestPolicieCodeAbuse, global::ModerationAPI.NewModerateModerateRequestPoliciePiiMasking, global::ModerationAPI.NewModerateModerateRequestPolicieUrlMasking, global::ModerationAPI.NewModerateModerateRequestPolicieGuideline>(),
                    new global::ModerationAPI.JsonConverters.AllOfJsonConverter<global::ModerationAPI.ModerationTextResponseVariant1, object>(),
                    new global::ModerationAPI.JsonConverters.AllOfJsonConverter<global::ModerationAPI.ModerationObjectResponseVariant1, object>(),
                    new global::ModerationAPI.JsonConverters.AllOfJsonConverter<global::ModerationAPI.ModerationVideoResponseVariant1, object>(),
                    new global::ModerationAPI.JsonConverters.AnyOfJsonConverter<string, object, global::System.Collections.Generic.Dictionary<string, global::ModerationAPI.OneOf<global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentText, global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentImage, global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentVideo, global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentAudio>>>(),
                    new global::ModerationAPI.JsonConverters.OneOfJsonConverter<global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentText, global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentImage, global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentVideo, global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentAudio>(),
                    new global::ModerationAPI.JsonConverters.OneOfJsonConverter<global::ModerationAPI.NewModerateModerateResponsePolicieClassifierOutput, global::ModerationAPI.NewModerateModerateResponsePolicieEntityMatcherOutput>(),
                    new global::ModerationAPI.JsonConverters.OneOfJsonConverter<global::ModerationAPI.NewModerateModerateResponseInsightSentimentInsight, global::ModerationAPI.NewModerateModerateResponseInsightLanguageInsight>(),
                    new global::ModerationAPI.JsonConverters.UnixTimestampJsonConverter(),
                }
            };
        #pragma warning restore CS0618 // Type or member is obsolete


        /// <summary>
        /// 
        /// </summary>
        public AccountClient Account => new AccountClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ActionsClient Actions => new ActionsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public AuthorClient Author => new AuthorClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ReviewQueuesClient ReviewQueues => new ReviewQueuesClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public WordlistClient Wordlist => new WordlistClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Creates a new instance of the ModerationAPIClient.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name="httpClient">The HttpClient instance. If not provided, a new one will be created.</param>
        /// <param name="baseUri">The base URL for the API. If not provided, the default baseUri from OpenAPI spec will be used.</param>
        /// <param name="authorizations">The authorizations to use for the requests.</param>
        /// <param name="disposeHttpClient">Dispose the HttpClient when the instance is disposed. True by default.</param>
        public ModerationAPIClient(
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null,
            global::System.Collections.Generic.List<global::ModerationAPI.EndPointAuthorization>? authorizations = null,
            bool disposeHttpClient = true)
        {
            HttpClient = httpClient ?? new global::System.Net.Http.HttpClient();
            HttpClient.BaseAddress ??= baseUri ?? new global::System.Uri(DefaultBaseUrl);
            Authorizations = authorizations ?? new global::System.Collections.Generic.List<global::ModerationAPI.EndPointAuthorization>();
            _disposeHttpClient = disposeHttpClient;

            Initialized(HttpClient);
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            if (_disposeHttpClient)
            {
                HttpClient.Dispose();
            }
        }

        partial void Initialized(
            global::System.Net.Http.HttpClient client);
        partial void PrepareArguments(
            global::System.Net.Http.HttpClient client);
        partial void PrepareRequest(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpRequestMessage request);
        partial void ProcessResponse(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response);
        partial void ProcessResponseContent(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response,
            ref string content);
    }
}