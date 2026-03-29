
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace ModerationAPI
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::ModerationAPI.JsonConverters.ActionsCreateRequestType2JsonConverter),

            typeof(global::ModerationAPI.JsonConverters.ActionsCreateRequestType2NullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.ActionsCreateRequestQueueBehaviourJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.ActionsCreateRequestQueueBehaviourNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.ActionsCreateRequestPositionJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.ActionsCreateRequestPositionNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.ActionsUpdateRequestType2JsonConverter),

            typeof(global::ModerationAPI.JsonConverters.ActionsUpdateRequestType2NullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.ActionsUpdateRequestQueueBehaviourJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.ActionsUpdateRequestQueueBehaviourNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.ActionsUpdateRequestPositionJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.ActionsUpdateRequestPositionNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.ModerationObjectRequestValueTypeJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.ModerationObjectRequestValueTypeNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.ModerationObjectRequestValueDataTypeJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.ModerationObjectRequestValueDataTypeNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.NewModerateModerateRequestMetaTypeJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.NewModerateModerateRequestMetaTypeNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.NewModerateModerateRequestPoliciePiiMaskingEntitiesIdJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.NewModerateModerateRequestPoliciePiiMaskingEntitiesIdNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.NewModerateModerateRequestPolicieUrlMaskingEntitiesIdJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.NewModerateModerateRequestPolicieUrlMaskingEntitiesIdNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.AuthorOpenListAuthorsSortByJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.AuthorOpenListAuthorsSortByNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.AuthorOpenListAuthorsSortDirectionJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.AuthorOpenListAuthorsSortDirectionNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.QueueViewOpenGetItemsSortFieldJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.QueueViewOpenGetItemsSortFieldNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.QueueViewOpenGetItemsSortDirectionJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.QueueViewOpenGetItemsSortDirectionNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.AuthorOpenListAuthorsResponseAuthorStatusJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.AuthorOpenListAuthorsResponseAuthorStatusNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.AuthorOpenCreateResponseStatusJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.AuthorOpenCreateResponseStatusNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.AuthorOpenGetAuthorDetailsResponseStatusJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.AuthorOpenGetAuthorDetailsResponseStatusNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.AuthorOpenUpdateResponseStatusJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.AuthorOpenUpdateResponseStatusNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.QueueViewOpenGetQueueResponseQueueFilterFilterLabelTypeJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.QueueViewOpenGetQueueResponseQueueFilterFilterLabelTypeNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.QueueViewOpenGetQueueResponseQueueFilterRecommendationActionJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.QueueViewOpenGetQueueResponseQueueFilterRecommendationActionNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.QueueViewOpenGetItemsResponseItemStatusJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.QueueViewOpenGetItemsResponseItemStatusNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.ActionsListResponseItemType2JsonConverter),

            typeof(global::ModerationAPI.JsonConverters.ActionsListResponseItemType2NullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.ActionsListResponseItemQueueBehaviourJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.ActionsListResponseItemQueueBehaviourNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.ActionsListResponseItemPositionJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.ActionsListResponseItemPositionNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.ActionsCreateResponseType2JsonConverter),

            typeof(global::ModerationAPI.JsonConverters.ActionsCreateResponseType2NullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.ActionsCreateResponseQueueBehaviourJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.ActionsCreateResponseQueueBehaviourNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.ActionsCreateResponsePositionJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.ActionsCreateResponsePositionNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.ActionsGetResponseType2JsonConverter),

            typeof(global::ModerationAPI.JsonConverters.ActionsGetResponseType2NullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.ActionsGetResponseQueueBehaviourJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.ActionsGetResponseQueueBehaviourNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.ActionsGetResponsePositionJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.ActionsGetResponsePositionNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.ActionsUpdateResponseType2JsonConverter),

            typeof(global::ModerationAPI.JsonConverters.ActionsUpdateResponseType2NullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.ActionsUpdateResponseQueueBehaviourJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.ActionsUpdateResponseQueueBehaviourNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.ActionsUpdateResponsePositionJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.ActionsUpdateResponsePositionNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.ModerationTextResponseVariant1AuthorStatusJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.ModerationTextResponseVariant1AuthorStatusNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.ModerationTextResponseVariant1EmailModeJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.ModerationTextResponseVariant1EmailModeNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.ModerationTextResponseVariant1PhoneModeJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.ModerationTextResponseVariant1PhoneModeNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.ModerationTextResponseVariant1UrlModeJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.ModerationTextResponseVariant1UrlModeNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.ModerationTextResponseVariant1AddressModeJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.ModerationTextResponseVariant1AddressModeNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.ModerationTextResponseVariant1NameModeJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.ModerationTextResponseVariant1NameModeNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.ModerationTextResponseVariant1UsernameModeJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.ModerationTextResponseVariant1UsernameModeNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.ModerationTextResponseVariant1ProfanityModeJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.ModerationTextResponseVariant1ProfanityModeNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.ModerationTextResponseVariant1SensitiveModeJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.ModerationTextResponseVariant1SensitiveModeNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.ModerationTextResponseVariant1WordlistModeJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.ModerationTextResponseVariant1WordlistModeNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.ModerationTextResponseVariant1WordlistMode2JsonConverter),

            typeof(global::ModerationAPI.JsonConverters.ModerationTextResponseVariant1WordlistMode2NullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.ModerationObjectResponseVariant1AuthorStatusJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.ModerationObjectResponseVariant1AuthorStatusNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.ModerationObjectResponseVariant1WordlistModeJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.ModerationObjectResponseVariant1WordlistModeNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.ModerationImageResponseAuthorStatusJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.ModerationImageResponseAuthorStatusNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.ModerationImageResponseLabelLabelJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.ModerationImageResponseLabelLabelNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.ModerationVideoResponseVariant1AuthorStatusJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.ModerationVideoResponseVariant1AuthorStatusNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.ModerationAudioResponseAuthorStatusJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.ModerationAudioResponseAuthorStatusNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.NewModerateModerateResponseAuthorStatusJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.NewModerateModerateResponseAuthorStatusNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.NewModerateModerateResponseRecommendationActionJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.NewModerateModerateResponseRecommendationActionNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.NewModerateModerateResponseRecommendationReasonCodeJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.NewModerateModerateResponseRecommendationReasonCodeNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.NewModerateModerateResponseInsightSentimentInsightValue2JsonConverter),

            typeof(global::ModerationAPI.JsonConverters.NewModerateModerateResponseInsightSentimentInsightValue2NullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.NewModerateModerateResponseMetaStatusJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.NewModerateModerateResponseMetaStatusNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.OneOfJsonConverter<global::ModerationAPI.OneOf<global::ModerationAPI.NewModerateModerateRequestContentContentLeafText, global::ModerationAPI.NewModerateModerateRequestContentContentLeafImage, global::ModerationAPI.NewModerateModerateRequestContentContentLeafVideo, global::ModerationAPI.NewModerateModerateRequestContentContentLeafAudio>?, global::ModerationAPI.NewModerateModerateRequestContentObject>),

            typeof(global::ModerationAPI.JsonConverters.OneOfJsonConverter<global::ModerationAPI.NewModerateModerateRequestContentContentLeafText, global::ModerationAPI.NewModerateModerateRequestContentContentLeafImage, global::ModerationAPI.NewModerateModerateRequestContentContentLeafVideo, global::ModerationAPI.NewModerateModerateRequestContentContentLeafAudio>),

            typeof(global::ModerationAPI.JsonConverters.OneOfJsonConverter<global::ModerationAPI.NewModerateModerateRequestContentObjectDataText, global::ModerationAPI.NewModerateModerateRequestContentObjectDataImage, global::ModerationAPI.NewModerateModerateRequestContentObjectDataVideo, global::ModerationAPI.NewModerateModerateRequestContentObjectDataAudio>),

            typeof(global::ModerationAPI.JsonConverters.OneOfJsonConverter<global::ModerationAPI.NewModerateModerateRequestPolicieToxicity, global::ModerationAPI.NewModerateModerateRequestPoliciePersonalInformation, global::ModerationAPI.NewModerateModerateRequestPolicieToxicitySevere, global::ModerationAPI.NewModerateModerateRequestPolicieHate, global::ModerationAPI.NewModerateModerateRequestPolicieIllicit, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitDrugs, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitAlcohol, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitFirearms, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitTobacco, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitGambling, global::ModerationAPI.NewModerateModerateRequestPolicieSexual, global::ModerationAPI.NewModerateModerateRequestPolicieFlirtation, global::ModerationAPI.NewModerateModerateRequestPolicieProfanity, global::ModerationAPI.NewModerateModerateRequestPolicieViolence, global::ModerationAPI.NewModerateModerateRequestPolicieSelfHarm, global::ModerationAPI.NewModerateModerateRequestPolicieSpam, global::ModerationAPI.NewModerateModerateRequestPolicieSelfPromotion, global::ModerationAPI.NewModerateModerateRequestPoliciePolitical, global::ModerationAPI.NewModerateModerateRequestPolicieReligion, global::ModerationAPI.NewModerateModerateRequestPolicieCodeAbuse, global::ModerationAPI.NewModerateModerateRequestPoliciePiiMasking, global::ModerationAPI.NewModerateModerateRequestPolicieUrlMasking, global::ModerationAPI.NewModerateModerateRequestPolicieGuideline>),

            typeof(global::ModerationAPI.JsonConverters.AllOfJsonConverter<global::ModerationAPI.ModerationTextResponseVariant1, object>),

            typeof(global::ModerationAPI.JsonConverters.AllOfJsonConverter<global::ModerationAPI.ModerationObjectResponseVariant1, object>),

            typeof(global::ModerationAPI.JsonConverters.AllOfJsonConverter<global::ModerationAPI.ModerationVideoResponseVariant1, object>),

            typeof(global::ModerationAPI.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.Dictionary<string, global::ModerationAPI.OneOf<global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1Text, global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1Image, global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1Video, global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1Audio>>>),

            typeof(global::ModerationAPI.JsonConverters.OneOfJsonConverter<global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1Text, global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1Image, global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1Video, global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1Audio>),

            typeof(global::ModerationAPI.JsonConverters.OneOfJsonConverter<global::ModerationAPI.NewModerateModerateResponsePolicieClassifierOutput, global::ModerationAPI.NewModerateModerateResponsePolicieEntityMatcherOutput>),

            typeof(global::ModerationAPI.JsonConverters.OneOfJsonConverter<global::ModerationAPI.NewModerateModerateResponseInsightSentimentInsight, global::ModerationAPI.NewModerateModerateResponseInsightLanguageInsight>),

            typeof(global::ModerationAPI.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ErrorBadRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ModerationAPI.ErrorBadRequestIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ErrorBadRequestIssue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ErrorUnauthorized))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ModerationAPI.ErrorUnauthorizedIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ErrorUnauthorizedIssue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ErrorForbidden))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ModerationAPI.ErrorForbiddenIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ErrorForbiddenIssue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ErrorNotFound))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ModerationAPI.ErrorNotFoundIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ErrorNotFoundIssue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ErrorInternalServerError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ModerationAPI.ErrorInternalServerErrorIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ErrorInternalServerErrorIssue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ErrorConflict))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ModerationAPI.ErrorConflictIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ErrorConflictIssue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.AuthorOpenCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.AuthorOpenCreateRequestMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.AuthorOpenUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.AuthorOpenUpdateRequestMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.QueueViewOpenResolveItemRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.QueueViewOpenUnresolveItemRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsCreateRequestType2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsCreateRequestQueueBehaviour), TypeInfoPropertyName = "ActionsCreateRequestQueueBehaviour2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsCreateRequestPosition), TypeInfoPropertyName = "ActionsCreateRequestPosition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ModerationAPI.ActionsCreateRequestPossibleValue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsCreateRequestPossibleValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ModerationAPI.ActionsCreateRequestWebhook>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsCreateRequestWebhook))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsUpdateRequestType2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsUpdateRequestQueueBehaviour), TypeInfoPropertyName = "ActionsUpdateRequestQueueBehaviour2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsUpdateRequestPosition), TypeInfoPropertyName = "ActionsUpdateRequestPosition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ModerationAPI.ActionsUpdateRequestPossibleValue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsUpdateRequestPossibleValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ModerationAPI.ActionsUpdateRequestWebhook>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsUpdateRequestWebhook))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsExecuteRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsExecuteDeprecatedRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ModerationTextRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ModerationObjectRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ModerationObjectRequestValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ModerationObjectRequestValueType), TypeInfoPropertyName = "ModerationObjectRequestValueType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::ModerationAPI.ModerationObjectRequestValueData2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ModerationObjectRequestValueData2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ModerationObjectRequestValueDataType), TypeInfoPropertyName = "ModerationObjectRequestValueDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ModerationImageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ModerationVideoRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ModerationAudioRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.WordlistUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.WordlistAddWordsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.OneOf<global::ModerationAPI.OneOf<global::ModerationAPI.NewModerateModerateRequestContentContentLeafText, global::ModerationAPI.NewModerateModerateRequestContentContentLeafImage, global::ModerationAPI.NewModerateModerateRequestContentContentLeafVideo, global::ModerationAPI.NewModerateModerateRequestContentContentLeafAudio>?, global::ModerationAPI.NewModerateModerateRequestContentObject>), TypeInfoPropertyName = "OneOfOneOfNewModerateModerateRequestContentContentLeafTextNewModerateModerateRequestContentContentLeafImageNewModerateModerateRequestContentContentLeafVideoNewModerateModerateRequestContentContentLeafAudioNewModerateModerateRequestContentObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.OneOf<global::ModerationAPI.NewModerateModerateRequestContentContentLeafText, global::ModerationAPI.NewModerateModerateRequestContentContentLeafImage, global::ModerationAPI.NewModerateModerateRequestContentContentLeafVideo, global::ModerationAPI.NewModerateModerateRequestContentContentLeafAudio>), TypeInfoPropertyName = "OneOfNewModerateModerateRequestContentContentLeafTextNewModerateModerateRequestContentContentLeafImageNewModerateModerateRequestContentContentLeafVideoNewModerateModerateRequestContentContentLeafAudio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateRequestContentContentLeafText))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateRequestContentContentLeafImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateRequestContentContentLeafVideo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateRequestContentContentLeafAudio))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateRequestContentObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::ModerationAPI.OneOf<global::ModerationAPI.NewModerateModerateRequestContentObjectDataText, global::ModerationAPI.NewModerateModerateRequestContentObjectDataImage, global::ModerationAPI.NewModerateModerateRequestContentObjectDataVideo, global::ModerationAPI.NewModerateModerateRequestContentObjectDataAudio>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.OneOf<global::ModerationAPI.NewModerateModerateRequestContentObjectDataText, global::ModerationAPI.NewModerateModerateRequestContentObjectDataImage, global::ModerationAPI.NewModerateModerateRequestContentObjectDataVideo, global::ModerationAPI.NewModerateModerateRequestContentObjectDataAudio>), TypeInfoPropertyName = "OneOfNewModerateModerateRequestContentObjectDataTextNewModerateModerateRequestContentObjectDataImageNewModerateModerateRequestContentObjectDataVideoNewModerateModerateRequestContentObjectDataAudio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateRequestContentObjectDataText))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateRequestContentObjectDataImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateRequestContentObjectDataVideo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateRequestContentObjectDataAudio))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateRequestMetaType), TypeInfoPropertyName = "NewModerateModerateRequestMetaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ModerationAPI.OneOf<global::ModerationAPI.NewModerateModerateRequestPolicieToxicity, global::ModerationAPI.NewModerateModerateRequestPoliciePersonalInformation, global::ModerationAPI.NewModerateModerateRequestPolicieToxicitySevere, global::ModerationAPI.NewModerateModerateRequestPolicieHate, global::ModerationAPI.NewModerateModerateRequestPolicieIllicit, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitDrugs, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitAlcohol, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitFirearms, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitTobacco, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitGambling, global::ModerationAPI.NewModerateModerateRequestPolicieSexual, global::ModerationAPI.NewModerateModerateRequestPolicieFlirtation, global::ModerationAPI.NewModerateModerateRequestPolicieProfanity, global::ModerationAPI.NewModerateModerateRequestPolicieViolence, global::ModerationAPI.NewModerateModerateRequestPolicieSelfHarm, global::ModerationAPI.NewModerateModerateRequestPolicieSpam, global::ModerationAPI.NewModerateModerateRequestPolicieSelfPromotion, global::ModerationAPI.NewModerateModerateRequestPoliciePolitical, global::ModerationAPI.NewModerateModerateRequestPolicieReligion, global::ModerationAPI.NewModerateModerateRequestPolicieCodeAbuse, global::ModerationAPI.NewModerateModerateRequestPoliciePiiMasking, global::ModerationAPI.NewModerateModerateRequestPolicieUrlMasking, global::ModerationAPI.NewModerateModerateRequestPolicieGuideline>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.OneOf<global::ModerationAPI.NewModerateModerateRequestPolicieToxicity, global::ModerationAPI.NewModerateModerateRequestPoliciePersonalInformation, global::ModerationAPI.NewModerateModerateRequestPolicieToxicitySevere, global::ModerationAPI.NewModerateModerateRequestPolicieHate, global::ModerationAPI.NewModerateModerateRequestPolicieIllicit, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitDrugs, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitAlcohol, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitFirearms, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitTobacco, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitGambling, global::ModerationAPI.NewModerateModerateRequestPolicieSexual, global::ModerationAPI.NewModerateModerateRequestPolicieFlirtation, global::ModerationAPI.NewModerateModerateRequestPolicieProfanity, global::ModerationAPI.NewModerateModerateRequestPolicieViolence, global::ModerationAPI.NewModerateModerateRequestPolicieSelfHarm, global::ModerationAPI.NewModerateModerateRequestPolicieSpam, global::ModerationAPI.NewModerateModerateRequestPolicieSelfPromotion, global::ModerationAPI.NewModerateModerateRequestPoliciePolitical, global::ModerationAPI.NewModerateModerateRequestPolicieReligion, global::ModerationAPI.NewModerateModerateRequestPolicieCodeAbuse, global::ModerationAPI.NewModerateModerateRequestPoliciePiiMasking, global::ModerationAPI.NewModerateModerateRequestPolicieUrlMasking, global::ModerationAPI.NewModerateModerateRequestPolicieGuideline>), TypeInfoPropertyName = "OneOfNewModerateModerateRequestPolicieToxicityNewModerateModerateRequestPoliciePersonalInformationNewModerateModerateRequestPolicieToxicitySevereNewModerateModerateRequestPolicieHateNewModerateModerateRequestPolicieIllicitNewModerateModerateRequestPolicieIllicitDrugsNewModerateModerateRequestPolicieIllicitAlcoholNewModerateModerateRequestPolicieIllicitFirearmsNewModerateModerateRequestPolicieIllicitTobaccoNewModerateModerateRequestPolicieIllicitGamblingNewModerateModerateRequestPolicieSexualNewModerateModerateRequestPolicieFlirtationNewModerateModerateRequestPolicieProfanityNewModerateModerateRequestPolicieViolenceNewModerateModerateRequestPolicieSelfHarmNewModerateModerateRequestPolicieSpamNewModerateModerateRequestPolicieSelfPromotionNewModerateModerateRequestPoliciePoliticalNewModerateModerateRequestPolicieReligionNewModerateModerateRequestPolicieCodeAbuseNewModerateModerateRequestPoliciePiiMaskingNewModerateModerateRequestPolicieUrlMaskingNewModerateModerateRequestPolicieGuideline2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateRequestPolicieToxicity))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateRequestPoliciePersonalInformation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateRequestPolicieToxicitySevere))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateRequestPolicieHate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateRequestPolicieIllicit))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateRequestPolicieIllicitDrugs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateRequestPolicieIllicitAlcohol))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateRequestPolicieIllicitFirearms))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateRequestPolicieIllicitTobacco))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateRequestPolicieIllicitGambling))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateRequestPolicieSexual))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateRequestPolicieFlirtation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateRequestPolicieProfanity))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateRequestPolicieViolence))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateRequestPolicieSelfHarm))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateRequestPolicieSpam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateRequestPolicieSelfPromotion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateRequestPoliciePolitical))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateRequestPolicieReligion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateRequestPolicieCodeAbuse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateRequestPoliciePiiMasking))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::ModerationAPI.NewModerateModerateRequestPoliciePiiMaskingEntities2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateRequestPoliciePiiMaskingEntities2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateRequestPoliciePiiMaskingEntitiesId), TypeInfoPropertyName = "NewModerateModerateRequestPoliciePiiMaskingEntitiesId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateRequestPolicieUrlMasking))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::ModerationAPI.NewModerateModerateRequestPolicieUrlMaskingEntities2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateRequestPolicieUrlMaskingEntities2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateRequestPolicieUrlMaskingEntitiesId), TypeInfoPropertyName = "NewModerateModerateRequestPolicieUrlMaskingEntitiesId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateRequestPolicieGuideline))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.AuthorOpenListAuthorsSortBy), TypeInfoPropertyName = "AuthorOpenListAuthorsSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.AuthorOpenListAuthorsSortDirection), TypeInfoPropertyName = "AuthorOpenListAuthorsSortDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.QueueViewOpenGetItemsSortField), TypeInfoPropertyName = "QueueViewOpenGetItemsSortField2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.QueueViewOpenGetItemsSortDirection), TypeInfoPropertyName = "QueueViewOpenGetItemsSortDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.AuthorOpenListAuthorsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ModerationAPI.AuthorOpenListAuthorsResponseAuthor>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.AuthorOpenListAuthorsResponseAuthor))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.AuthorOpenListAuthorsResponseAuthorStatus), TypeInfoPropertyName = "AuthorOpenListAuthorsResponseAuthorStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.AuthorOpenListAuthorsResponseAuthorTrustLevel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.AuthorOpenListAuthorsResponseAuthorBlock2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.AuthorOpenListAuthorsResponseAuthorRiskEvaluation2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.AuthorOpenListAuthorsResponseAuthorMetrics))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.AuthorOpenListAuthorsResponseAuthorMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.AuthorOpenListAuthorsResponsePagination))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.AuthorOpenCreateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.AuthorOpenCreateResponseStatus), TypeInfoPropertyName = "AuthorOpenCreateResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.AuthorOpenCreateResponseTrustLevel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.AuthorOpenCreateResponseBlock2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.AuthorOpenCreateResponseRiskEvaluation2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.AuthorOpenCreateResponseMetrics))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.AuthorOpenCreateResponseMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.AuthorOpenGetAuthorDetailsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.AuthorOpenGetAuthorDetailsResponseStatus), TypeInfoPropertyName = "AuthorOpenGetAuthorDetailsResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.AuthorOpenGetAuthorDetailsResponseTrustLevel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.AuthorOpenGetAuthorDetailsResponseBlock2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.AuthorOpenGetAuthorDetailsResponseRiskEvaluation2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.AuthorOpenGetAuthorDetailsResponseMetrics))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.AuthorOpenGetAuthorDetailsResponseMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.AuthorOpenUpdateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.AuthorOpenUpdateResponseStatus), TypeInfoPropertyName = "AuthorOpenUpdateResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.AuthorOpenUpdateResponseTrustLevel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.AuthorOpenUpdateResponseBlock2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.AuthorOpenUpdateResponseRiskEvaluation2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.AuthorOpenUpdateResponseMetrics))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.AuthorOpenUpdateResponseMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.AuthorDeleteResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.QueueViewOpenGetQueueResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.QueueViewOpenGetQueueResponseQueue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.QueueViewOpenGetQueueResponseQueueFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ModerationAPI.QueueViewOpenGetQueueResponseQueueFilterFilterLabel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.QueueViewOpenGetQueueResponseQueueFilterFilterLabel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.QueueViewOpenGetQueueResponseQueueFilterFilterLabelType), TypeInfoPropertyName = "QueueViewOpenGetQueueResponseQueueFilterFilterLabelType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ModerationAPI.QueueViewOpenGetQueueResponseQueueFilterRecommendationAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.QueueViewOpenGetQueueResponseQueueFilterRecommendationAction), TypeInfoPropertyName = "QueueViewOpenGetQueueResponseQueueFilterRecommendationAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.QueueViewOpenGetStatsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.QueueViewOpenGetStatsResponseReviewStats))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ModerationAPI.QueueViewOpenGetStatsResponseActionStat>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.QueueViewOpenGetStatsResponseActionStat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ModerationAPI.QueueViewOpenGetStatsResponseTopReviewer>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.QueueViewOpenGetStatsResponseTopReviewer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ModerationAPI.QueueViewOpenGetStatsResponseTopReviewerTopAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.QueueViewOpenGetStatsResponseTopReviewerTopAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.QueueViewOpenGetStatsResponseTrends))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ModerationAPI.QueueViewOpenGetStatsResponseTrendsDailyReviewCount>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.QueueViewOpenGetStatsResponseTrendsDailyReviewCount))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ModerationAPI.QueueViewOpenGetStatsResponseTrendsFlaggedContentTrend>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.QueueViewOpenGetStatsResponseTrendsFlaggedContentTrend))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.QueueViewOpenGetItemsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ModerationAPI.QueueViewOpenGetItemsResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.QueueViewOpenGetItemsResponseItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ModerationAPI.QueueViewOpenGetItemsResponseItemLabel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.QueueViewOpenGetItemsResponseItemLabel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ModerationAPI.QueueViewOpenGetItemsResponseItemAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.QueueViewOpenGetItemsResponseItemAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.QueueViewOpenGetItemsResponseItemStatus), TypeInfoPropertyName = "QueueViewOpenGetItemsResponseItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.QueueViewOpenGetItemsResponsePagination))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.QueueViewOpenResolveItemResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.QueueViewOpenUnresolveItemResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ModerationAPI.ActionsListResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsListResponseItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsListResponseItemType2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsListResponseItemQueueBehaviour), TypeInfoPropertyName = "ActionsListResponseItemQueueBehaviour2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsListResponseItemPosition), TypeInfoPropertyName = "ActionsListResponseItemPosition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ModerationAPI.ActionsListResponseItemPossibleValue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsListResponseItemPossibleValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ModerationAPI.ActionsListResponseItemWebhook>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsListResponseItemWebhook))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsCreateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsCreateResponseType2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsCreateResponseQueueBehaviour), TypeInfoPropertyName = "ActionsCreateResponseQueueBehaviour2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsCreateResponsePosition), TypeInfoPropertyName = "ActionsCreateResponsePosition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ModerationAPI.ActionsCreateResponsePossibleValue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsCreateResponsePossibleValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsGetResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsGetResponseType2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsGetResponseQueueBehaviour), TypeInfoPropertyName = "ActionsGetResponseQueueBehaviour2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsGetResponsePosition), TypeInfoPropertyName = "ActionsGetResponsePosition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ModerationAPI.ActionsGetResponsePossibleValue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsGetResponsePossibleValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ModerationAPI.ActionsGetResponseWebhook>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsGetResponseWebhook))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsUpdateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsUpdateResponseType2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsUpdateResponseQueueBehaviour), TypeInfoPropertyName = "ActionsUpdateResponseQueueBehaviour2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsUpdateResponsePosition), TypeInfoPropertyName = "ActionsUpdateResponsePosition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ModerationAPI.ActionsUpdateResponsePossibleValue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsUpdateResponsePossibleValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsDeleteResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsExecuteResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsExecuteDeprecatedResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.AllOf<global::ModerationAPI.ModerationTextResponseVariant1, object>), TypeInfoPropertyName = "AllOfModerationTextResponseVariant1Object2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ModerationTextResponseVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ModerationTextResponseVariant1Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ModerationTextResponseVariant1Author2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ModerationTextResponseVariant1AuthorBlock2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ModerationTextResponseVariant1AuthorStatus), TypeInfoPropertyName = "ModerationTextResponseVariant1AuthorStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ModerationTextResponseVariant1AuthorTrustLevel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ModerationTextResponseVariant1Nsfw))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ModerationTextResponseVariant1NsfwLabelScores))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ModerationTextResponseVariant1Toxicity))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ModerationTextResponseVariant1ToxicityLabelScores))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ModerationTextResponseVariant1Quality))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ModerationTextResponseVariant1QualityLabelScores))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ModerationTextResponseVariant1Sentiment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ModerationTextResponseVariant1SentimentLabelScores))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ModerationTextResponseVariant1Propriety))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ModerationTextResponseVariant1ProprietyLabelScores))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ModerationTextResponseVariant1Email))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ModerationTextResponseVariant1EmailMode), TypeInfoPropertyName = "ModerationTextResponseVariant1EmailMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ModerationTextResponseVariant1Phone))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ModerationTextResponseVariant1PhoneMode), TypeInfoPropertyName = "ModerationTextResponseVariant1PhoneMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ModerationTextResponseVariant1Url))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ModerationTextResponseVariant1UrlMode), TypeInfoPropertyName = "ModerationTextResponseVariant1UrlMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ModerationTextResponseVariant1Address))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ModerationTextResponseVariant1AddressMode), TypeInfoPropertyName = "ModerationTextResponseVariant1AddressMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ModerationTextResponseVariant1Name))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ModerationTextResponseVariant1NameMode), TypeInfoPropertyName = "ModerationTextResponseVariant1NameMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ModerationTextResponseVariant1Username))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ModerationTextResponseVariant1UsernameMode), TypeInfoPropertyName = "ModerationTextResponseVariant1UsernameMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ModerationTextResponseVariant1Profanity))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ModerationTextResponseVariant1ProfanityMode), TypeInfoPropertyName = "ModerationTextResponseVariant1ProfanityMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ModerationTextResponseVariant1Sensitive))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ModerationTextResponseVariant1SensitiveMode), TypeInfoPropertyName = "ModerationTextResponseVariant1SensitiveMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ModerationTextResponseVariant1Wordlist))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ModerationTextResponseVariant1WordlistMode), TypeInfoPropertyName = "ModerationTextResponseVariant1WordlistMode3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ModerationAPI.ModerationTextResponseVariant1Wordlist2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ModerationTextResponseVariant1Wordlist2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ModerationTextResponseVariant1WordlistMode2), TypeInfoPropertyName = "ModerationTextResponseVariant1WordlistMode22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.AllOf<global::ModerationAPI.ModerationObjectResponseVariant1, object>), TypeInfoPropertyName = "AllOfModerationObjectResponseVariant1Object2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ModerationObjectResponseVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ModerationObjectResponseVariant1Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ModerationObjectResponseVariant1Author2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ModerationObjectResponseVariant1AuthorBlock2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ModerationObjectResponseVariant1AuthorStatus), TypeInfoPropertyName = "ModerationObjectResponseVariant1AuthorStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ModerationObjectResponseVariant1AuthorTrustLevel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ModerationAPI.ModerationObjectResponseVariant1Label>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ModerationObjectResponseVariant1Label))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ModerationAPI.ModerationObjectResponseVariant1Entitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ModerationObjectResponseVariant1Entitie))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ModerationAPI.ModerationObjectResponseVariant1Wordlist>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ModerationObjectResponseVariant1Wordlist))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ModerationObjectResponseVariant1WordlistMode), TypeInfoPropertyName = "ModerationObjectResponseVariant1WordlistMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ModerationAPI.ModerationObjectResponseVariant1Field>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ModerationObjectResponseVariant1Field))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ModerationImageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ModerationImageResponseRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ModerationImageResponseAuthor2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ModerationImageResponseAuthorBlock2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ModerationImageResponseAuthorStatus), TypeInfoPropertyName = "ModerationImageResponseAuthorStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ModerationImageResponseAuthorTrustLevel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ModerationAPI.ModerationImageResponseLabel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ModerationImageResponseLabel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ModerationImageResponseLabelLabel), TypeInfoPropertyName = "ModerationImageResponseLabelLabel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.AllOf<global::ModerationAPI.ModerationVideoResponseVariant1, object>), TypeInfoPropertyName = "AllOfModerationVideoResponseVariant1Object2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ModerationVideoResponseVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ModerationVideoResponseVariant1Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ModerationVideoResponseVariant1Author2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ModerationVideoResponseVariant1AuthorBlock2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ModerationVideoResponseVariant1AuthorStatus), TypeInfoPropertyName = "ModerationVideoResponseVariant1AuthorStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ModerationVideoResponseVariant1AuthorTrustLevel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ModerationAudioResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ModerationAudioResponseRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ModerationAudioResponseAuthor2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ModerationAudioResponseAuthorBlock2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ModerationAudioResponseAuthorStatus), TypeInfoPropertyName = "ModerationAudioResponseAuthorStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ModerationAudioResponseAuthorTrustLevel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.AccountGetResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.AccountGetResponseCurrentProject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.AccountLegacyAuthGetResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.AccountLegacyAuthPostResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ModerationAPI.WordlistListResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.WordlistListResponseItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.WordlistGetWordlistPublicResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.WordlistUpdateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.WordlistWordlistEmbeddingStatusResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.WordlistAddWordsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.WordlistRemoveWordsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateResponseContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.AnyOf<string, global::System.Collections.Generic.Dictionary<string, global::ModerationAPI.OneOf<global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1Text, global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1Image, global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1Video, global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1Audio>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::ModerationAPI.OneOf<global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1Text, global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1Image, global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1Video, global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1Audio>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.OneOf<global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1Text, global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1Image, global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1Video, global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1Audio>), TypeInfoPropertyName = "OneOfNewModerateModerateResponseContentModifiedVariant1TextNewModerateModerateResponseContentModifiedVariant1ImageNewModerateModerateResponseContentModifiedVariant1VideoNewModerateModerateResponseContentModifiedVariant1Audio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1Text))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1Image))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1Video))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1Audio))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateResponseAuthor2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateResponseAuthorBlock2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateResponseAuthorStatus), TypeInfoPropertyName = "NewModerateModerateResponseAuthorStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateResponseAuthorTrustLevel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateResponseEvaluation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateResponseRecommendation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateResponseRecommendationAction), TypeInfoPropertyName = "NewModerateModerateResponseRecommendationAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ModerationAPI.NewModerateModerateResponseRecommendationReasonCode>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateResponseRecommendationReasonCode), TypeInfoPropertyName = "NewModerateModerateResponseRecommendationReasonCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ModerationAPI.OneOf<global::ModerationAPI.NewModerateModerateResponsePolicieClassifierOutput, global::ModerationAPI.NewModerateModerateResponsePolicieEntityMatcherOutput>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.OneOf<global::ModerationAPI.NewModerateModerateResponsePolicieClassifierOutput, global::ModerationAPI.NewModerateModerateResponsePolicieEntityMatcherOutput>), TypeInfoPropertyName = "OneOfNewModerateModerateResponsePolicieClassifierOutputNewModerateModerateResponsePolicieEntityMatcherOutput2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateResponsePolicieClassifierOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ModerationAPI.NewModerateModerateResponsePolicieClassifierOutputLabel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateResponsePolicieClassifierOutputLabel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateResponsePolicieEntityMatcherOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ModerationAPI.NewModerateModerateResponsePolicieEntityMatcherOutputMatche>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateResponsePolicieEntityMatcherOutputMatche))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ModerationAPI.OneOf<global::ModerationAPI.NewModerateModerateResponseInsightSentimentInsight, global::ModerationAPI.NewModerateModerateResponseInsightLanguageInsight>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.OneOf<global::ModerationAPI.NewModerateModerateResponseInsightSentimentInsight, global::ModerationAPI.NewModerateModerateResponseInsightLanguageInsight>), TypeInfoPropertyName = "OneOfNewModerateModerateResponseInsightSentimentInsightNewModerateModerateResponseInsightLanguageInsight2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateResponseInsightSentimentInsight))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateResponseInsightSentimentInsightValue2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateResponseInsightLanguageInsight))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateResponseMeta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateResponseMetaStatus), TypeInfoPropertyName = "NewModerateModerateResponseMetaStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ModerationAPI.NewModerateModerateResponseError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.ErrorBadRequestIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.ErrorUnauthorizedIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.ErrorForbiddenIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.ErrorNotFoundIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.ErrorInternalServerErrorIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.ErrorConflictIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.ActionsCreateRequestPossibleValue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.ActionsCreateRequestWebhook>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.ActionsUpdateRequestPossibleValue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.ActionsUpdateRequestWebhook>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.OneOf<global::ModerationAPI.NewModerateModerateRequestPolicieToxicity, global::ModerationAPI.NewModerateModerateRequestPoliciePersonalInformation, global::ModerationAPI.NewModerateModerateRequestPolicieToxicitySevere, global::ModerationAPI.NewModerateModerateRequestPolicieHate, global::ModerationAPI.NewModerateModerateRequestPolicieIllicit, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitDrugs, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitAlcohol, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitFirearms, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitTobacco, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitGambling, global::ModerationAPI.NewModerateModerateRequestPolicieSexual, global::ModerationAPI.NewModerateModerateRequestPolicieFlirtation, global::ModerationAPI.NewModerateModerateRequestPolicieProfanity, global::ModerationAPI.NewModerateModerateRequestPolicieViolence, global::ModerationAPI.NewModerateModerateRequestPolicieSelfHarm, global::ModerationAPI.NewModerateModerateRequestPolicieSpam, global::ModerationAPI.NewModerateModerateRequestPolicieSelfPromotion, global::ModerationAPI.NewModerateModerateRequestPoliciePolitical, global::ModerationAPI.NewModerateModerateRequestPolicieReligion, global::ModerationAPI.NewModerateModerateRequestPolicieCodeAbuse, global::ModerationAPI.NewModerateModerateRequestPoliciePiiMasking, global::ModerationAPI.NewModerateModerateRequestPolicieUrlMasking, global::ModerationAPI.NewModerateModerateRequestPolicieGuideline>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.AuthorOpenListAuthorsResponseAuthor>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.QueueViewOpenGetQueueResponseQueueFilterFilterLabel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.QueueViewOpenGetQueueResponseQueueFilterRecommendationAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.QueueViewOpenGetStatsResponseActionStat>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.QueueViewOpenGetStatsResponseTopReviewer>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.QueueViewOpenGetStatsResponseTopReviewerTopAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.QueueViewOpenGetStatsResponseTrendsDailyReviewCount>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.QueueViewOpenGetStatsResponseTrendsFlaggedContentTrend>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.QueueViewOpenGetItemsResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.QueueViewOpenGetItemsResponseItemLabel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.QueueViewOpenGetItemsResponseItemAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.ActionsListResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.ActionsListResponseItemPossibleValue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.ActionsListResponseItemWebhook>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.ActionsCreateResponsePossibleValue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.ActionsGetResponsePossibleValue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.ActionsGetResponseWebhook>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.ActionsUpdateResponsePossibleValue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.ModerationTextResponseVariant1Wordlist2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.ModerationObjectResponseVariant1Label>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.ModerationObjectResponseVariant1Entitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.ModerationObjectResponseVariant1Wordlist>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.ModerationObjectResponseVariant1Field>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.ModerationImageResponseLabel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.WordlistListResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.NewModerateModerateResponseRecommendationReasonCode>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.OneOf<global::ModerationAPI.NewModerateModerateResponsePolicieClassifierOutput, global::ModerationAPI.NewModerateModerateResponsePolicieEntityMatcherOutput>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.NewModerateModerateResponsePolicieClassifierOutputLabel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.NewModerateModerateResponsePolicieEntityMatcherOutputMatche>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.OneOf<global::ModerationAPI.NewModerateModerateResponseInsightSentimentInsight, global::ModerationAPI.NewModerateModerateResponseInsightLanguageInsight>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.NewModerateModerateResponseError>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}