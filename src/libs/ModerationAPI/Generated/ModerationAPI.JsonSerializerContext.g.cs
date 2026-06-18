
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
            typeof(global::ModerationAPI.JsonConverters.PublicAuthorStatusJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.PublicAuthorStatusNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.PublicQueueItemClientActionActionJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.PublicQueueItemClientActionActionNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.PublicQueueItemClientActionBehaviorJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.PublicQueueItemClientActionBehaviorNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.PublicQueueItemMetaType2JsonConverter),

            typeof(global::ModerationAPI.JsonConverters.PublicQueueItemMetaType2NullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.WebhookEventDiscriminatorTypeJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.WebhookEventDiscriminatorTypeNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.VoiceStartFrameEventJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.VoiceStartFrameEventNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.VoiceStartFrameTrackNameJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.VoiceStartFrameTrackNameNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.VoiceMediaFrameEventJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.VoiceMediaFrameEventNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.VoiceMediaFrameMediaTrackJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.VoiceMediaFrameMediaTrackNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.VoiceStopFrameEventJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.VoiceStopFrameEventNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.VoiceSessionStartedEventJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.VoiceSessionStartedEventNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.VoiceUtteranceFinalEventJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.VoiceUtteranceFinalEventNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.VoiceUtteranceFinalTrackJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.VoiceUtteranceFinalTrackNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.VoiceUtteranceFinalRecommendationActionJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.VoiceUtteranceFinalRecommendationActionNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.VoiceSessionEndedEventJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.VoiceSessionEndedEventNullableJsonConverter),

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

            typeof(global::ModerationAPI.JsonConverters.NewModerateModerateRequestClientActionActionJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.NewModerateModerateRequestClientActionActionNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.NewModerateModerateRequestClientActionBehaviorJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.NewModerateModerateRequestClientActionBehaviorNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.NewModerateModerateRequestPolicieFaceDetectionComparatorJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.NewModerateModerateRequestPolicieFaceDetectionComparatorNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.GetStreamRequestDiscriminatorEventJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.GetStreamRequestDiscriminatorEventNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.AuthorOpenListAuthorsSortByJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.AuthorOpenListAuthorsSortByNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.AuthorOpenListAuthorsSortDirectionJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.AuthorOpenListAuthorsSortDirectionNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.QueueViewOpenGetItemsSortFieldJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.QueueViewOpenGetItemsSortFieldNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.QueueViewOpenGetItemsSortDirectionJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.QueueViewOpenGetItemsSortDirectionNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.GetStreamSecWebSocketProtocolJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.GetStreamSecWebSocketProtocolNullableJsonConverter),

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

            typeof(global::ModerationAPI.JsonConverters.NewModerateModerateResponsePolicieEntityMatcherOutputMatcheSignalsBrandImpersonationMethodJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.NewModerateModerateResponsePolicieEntityMatcherOutputMatcheSignalsBrandImpersonationMethodNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.NewModerateModerateResponseInsightSentimentInsightValue2JsonConverter),

            typeof(global::ModerationAPI.JsonConverters.NewModerateModerateResponseInsightSentimentInsightValue2NullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.NewModerateModerateResponseMetaStatusJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.NewModerateModerateResponseMetaStatusNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.GetStreamResponseDiscriminatorEventJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.GetStreamResponseDiscriminatorEventNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.CreateAuthorBlockedWebhookVersionJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.CreateAuthorBlockedWebhookVersionNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.CreateAuthorUnblockedWebhookVersionJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.CreateAuthorUnblockedWebhookVersionNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.CreateAuthorSuspendedWebhookVersionJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.CreateAuthorSuspendedWebhookVersionNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.CreateAuthorUpdatedWebhookVersionJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.CreateAuthorUpdatedWebhookVersionNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.CreateAuthorTrustLevelChangedWebhookVersionJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.CreateAuthorTrustLevelChangedWebhookVersionNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.CreateAuthorActionWebhookVersionJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.CreateAuthorActionWebhookVersionNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.CreateQueueItemResolvedWebhookVersionJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.CreateQueueItemResolvedWebhookVersionNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.CreateQueueItemActionWebhookVersionJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.CreateQueueItemActionWebhookVersionNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.CreateQueueItemRejectedWebhookVersionJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.CreateQueueItemRejectedWebhookVersionNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.CreateQueueItemAllowedWebhookVersionJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.CreateQueueItemAllowedWebhookVersionNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.WebhookEventJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.GetStreamRequestJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.GetStreamResponseJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.OneOfJsonConverter<global::ModerationAPI.PublicQueueItemContentText, global::ModerationAPI.PublicQueueItemContentImage, global::ModerationAPI.PublicQueueItemContentVideo, global::ModerationAPI.PublicQueueItemContentAudio, global::ModerationAPI.PublicQueueItemContentObject>),

            typeof(global::ModerationAPI.JsonConverters.OneOfJsonConverter<global::ModerationAPI.PublicQueueItemContentObjectDataText, global::ModerationAPI.PublicQueueItemContentObjectDataImage, global::ModerationAPI.PublicQueueItemContentObjectDataVideo, global::ModerationAPI.PublicQueueItemContentObjectDataAudio>),

            typeof(global::ModerationAPI.JsonConverters.OneOfJsonConverter<global::ModerationAPI.NewModerateModerateRequestContentText, global::ModerationAPI.NewModerateModerateRequestContentImage, global::ModerationAPI.NewModerateModerateRequestContentVideo, global::ModerationAPI.NewModerateModerateRequestContentAudio, global::ModerationAPI.NewModerateModerateRequestContentObject>),

            typeof(global::ModerationAPI.JsonConverters.OneOfJsonConverter<global::ModerationAPI.NewModerateModerateRequestContentObjectDataText, global::ModerationAPI.NewModerateModerateRequestContentObjectDataImage, global::ModerationAPI.NewModerateModerateRequestContentObjectDataVideo, global::ModerationAPI.NewModerateModerateRequestContentObjectDataAudio>),

            typeof(global::ModerationAPI.JsonConverters.OneOfJsonConverter<global::ModerationAPI.NewModerateModerateRequestPolicieToxicity, global::ModerationAPI.NewModerateModerateRequestPoliciePersonalInformation, global::ModerationAPI.NewModerateModerateRequestPolicieToxicitySevere, global::ModerationAPI.NewModerateModerateRequestPolicieHate, global::ModerationAPI.NewModerateModerateRequestPolicieIllicit, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitDrugs, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitAlcohol, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitFirearms, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitTobacco, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitGambling, global::ModerationAPI.NewModerateModerateRequestPolicieCannabis, global::ModerationAPI.NewModerateModerateRequestPolicieAdult, global::ModerationAPI.NewModerateModerateRequestPolicieCrypto, global::ModerationAPI.NewModerateModerateRequestPolicieSexual, global::ModerationAPI.NewModerateModerateRequestPolicieFlirtation, global::ModerationAPI.NewModerateModerateRequestPolicieProfanity, global::ModerationAPI.NewModerateModerateRequestPolicieViolence, global::ModerationAPI.NewModerateModerateRequestPolicieSelfHarm, global::ModerationAPI.NewModerateModerateRequestPolicieSpam, global::ModerationAPI.NewModerateModerateRequestPolicieLowQualityContent, global::ModerationAPI.NewModerateModerateRequestPolicieFaceDetection, global::ModerationAPI.NewModerateModerateRequestPolicieSelfPromotion, global::ModerationAPI.NewModerateModerateRequestPoliciePolitical, global::ModerationAPI.NewModerateModerateRequestPolicieReligion, global::ModerationAPI.NewModerateModerateRequestPolicieCodeAbuse, global::ModerationAPI.NewModerateModerateRequestPoliciePiiMasking, global::ModerationAPI.NewModerateModerateRequestPolicieUrlMasking, global::ModerationAPI.NewModerateModerateRequestPolicieUrlRisk, global::ModerationAPI.NewModerateModerateRequestPolicieGuideline>),

            typeof(global::ModerationAPI.JsonConverters.AllOfJsonConverter<global::ModerationAPI.ModerationTextResponseVariant1, object>),

            typeof(global::ModerationAPI.JsonConverters.AllOfJsonConverter<global::ModerationAPI.ModerationObjectResponseVariant1, object>),

            typeof(global::ModerationAPI.JsonConverters.AllOfJsonConverter<global::ModerationAPI.ModerationVideoResponseVariant1, object>),

            typeof(global::ModerationAPI.JsonConverters.AnyOfJsonConverter<string, object, global::System.Collections.Generic.Dictionary<string, global::ModerationAPI.OneOf<global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentText, global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentImage, global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentVideo, global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentAudio>>>),

            typeof(global::ModerationAPI.JsonConverters.OneOfJsonConverter<global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentText, global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentImage, global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentVideo, global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentAudio>),

            typeof(global::ModerationAPI.JsonConverters.OneOfJsonConverter<global::ModerationAPI.NewModerateModerateResponsePolicieClassifierOutput, global::ModerationAPI.NewModerateModerateResponsePolicieEntityMatcherOutput>),

            typeof(global::ModerationAPI.JsonConverters.OneOfJsonConverter<global::ModerationAPI.NewModerateModerateResponseInsightSentimentInsight, global::ModerationAPI.NewModerateModerateResponseInsightLanguageInsight>),

            typeof(global::ModerationAPI.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.PublicAuthor))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.PublicAuthorStatus), TypeInfoPropertyName = "PublicAuthorStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.PublicAuthorTrustLevel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.PublicAuthorBlock2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.PublicAuthorRiskEvaluation2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.PublicAuthorMetrics))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.PublicAuthorMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ErrorBadRequest))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.AuthorBlockedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.AuthorBlockedEventData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.PublicActionPerformedAuthor))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.PublicActionPerformedAuthorQueue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.AuthorUnblockedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.AuthorUnblockedEventData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.AuthorSuspendedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.AuthorSuspendedEventData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.AuthorUpdatedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.AuthorUpdatedEventData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.AuthorTrustLevelChangedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.AuthorTrustLevelChangedEventData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.AuthorActionEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.AuthorActionEventData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.QueueItemCompletedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.QueueItemCompletedEventData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.PublicQueueItemEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.PublicQueueItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.PublicQueueItemEventQueue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ModerationAPI.PublicQueueItemLabelsVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.PublicQueueItemLabelsVariant1Item))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ModerationAPI.PublicQueueItemLabelsVariant1ItemMatche>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.PublicQueueItemLabelsVariant1ItemMatche))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.PublicQueueItemLabelsVariant1ItemMatcheSignals))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.PublicQueueItemLabelsVariant1ItemMatcheSignalsBrandImpersonation2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.OneOf<global::ModerationAPI.PublicQueueItemContentText, global::ModerationAPI.PublicQueueItemContentImage, global::ModerationAPI.PublicQueueItemContentVideo, global::ModerationAPI.PublicQueueItemContentAudio, global::ModerationAPI.PublicQueueItemContentObject>), TypeInfoPropertyName = "PublicQueueItemContentObject_a5b10a16560a2a90")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.PublicQueueItemContentText))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.PublicQueueItemContentImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.PublicQueueItemContentVideo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.PublicQueueItemContentAudio))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.PublicQueueItemContentObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::ModerationAPI.OneOf<global::ModerationAPI.PublicQueueItemContentObjectDataText, global::ModerationAPI.PublicQueueItemContentObjectDataImage, global::ModerationAPI.PublicQueueItemContentObjectDataVideo, global::ModerationAPI.PublicQueueItemContentObjectDataAudio>>), TypeInfoPropertyName = "PublicQueueItemContentObjectDataAudio_9fba358e4ede806b")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.OneOf<global::ModerationAPI.PublicQueueItemContentObjectDataText, global::ModerationAPI.PublicQueueItemContentObjectDataImage, global::ModerationAPI.PublicQueueItemContentObjectDataVideo, global::ModerationAPI.PublicQueueItemContentObjectDataAudio>), TypeInfoPropertyName = "PublicQueueItemContentObjectDataAudio_f4551668b35ad437")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.PublicQueueItemContentObjectDataText))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.PublicQueueItemContentObjectDataImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.PublicQueueItemContentObjectDataVideo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.PublicQueueItemContentObjectDataAudio))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.PublicQueueItemClientAction2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.PublicQueueItemClientActionAction), TypeInfoPropertyName = "PublicQueueItemClientActionAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.PublicQueueItemClientActionBehavior), TypeInfoPropertyName = "PublicQueueItemClientActionBehavior2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.PublicQueueItemMetaType2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.QueueItemActionEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.QueueItemActionEventData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.PublicActionPerformed))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.PublicActionPerformedQueue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.QueueItemRejectedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.QueueItemRejectedEventData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.QueueItemAllowedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.QueueItemAllowedEventData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.WebhookEvent), TypeInfoPropertyName = "WebhookEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.WebhookEventDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.WebhookEventDiscriminatorType), TypeInfoPropertyName = "WebhookEventDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.VoiceStartFrame))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.VoiceStartFrameEvent), TypeInfoPropertyName = "VoiceStartFrameEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.VoiceStartFrameMediaFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ModerationAPI.VoiceStartFrameTrack>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.VoiceStartFrameTrack))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.VoiceStartFrameTrackName), TypeInfoPropertyName = "VoiceStartFrameTrackName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.VoiceMediaFrame))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.VoiceMediaFrameEvent), TypeInfoPropertyName = "VoiceMediaFrameEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.VoiceMediaFrameMedia))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.VoiceMediaFrameMediaTrack), TypeInfoPropertyName = "VoiceMediaFrameMediaTrack2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.VoiceStopFrame))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.VoiceStopFrameEvent), TypeInfoPropertyName = "VoiceStopFrameEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.VoiceSessionStarted))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.VoiceSessionStartedEvent), TypeInfoPropertyName = "VoiceSessionStartedEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.VoiceUtteranceFinal))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.VoiceUtteranceFinalEvent), TypeInfoPropertyName = "VoiceUtteranceFinalEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.VoiceUtteranceFinalTrack), TypeInfoPropertyName = "VoiceUtteranceFinalTrack2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.VoiceUtteranceFinalRecommendation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.VoiceUtteranceFinalRecommendationAction), TypeInfoPropertyName = "VoiceUtteranceFinalRecommendationAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.VoiceSessionEnded))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.VoiceSessionEndedEvent), TypeInfoPropertyName = "VoiceSessionEndedEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.VoiceSessionEndedStats))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.VoiceSessionEndedStatsActions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.AuthorOpenCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.AuthorOpenCreateRequestMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.AuthorOpenUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.AuthorOpenUpdateRequestMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.QueueViewOpenResolveItemRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.QueueViewOpenUnresolveItemRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsCreateRequestType2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsCreateRequestQueueBehaviour), TypeInfoPropertyName = "ActionsCreateRequestQueueBehaviour2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsCreateRequestPosition), TypeInfoPropertyName = "ActionsCreateRequestPosition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ModerationAPI.ActionsCreateRequestPossibleValue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsCreateRequestPossibleValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsUpdateRequestType2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsUpdateRequestQueueBehaviour), TypeInfoPropertyName = "ActionsUpdateRequestQueueBehaviour2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsUpdateRequestPosition), TypeInfoPropertyName = "ActionsUpdateRequestPosition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ModerationAPI.ActionsUpdateRequestPossibleValue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsUpdateRequestPossibleValue))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.OneOf<global::ModerationAPI.NewModerateModerateRequestContentText, global::ModerationAPI.NewModerateModerateRequestContentImage, global::ModerationAPI.NewModerateModerateRequestContentVideo, global::ModerationAPI.NewModerateModerateRequestContentAudio, global::ModerationAPI.NewModerateModerateRequestContentObject>), TypeInfoPropertyName = "NewModerateModerateRequestContentObject_c77db83f9aa266b5")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateRequestContentText))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateRequestContentImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateRequestContentVideo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateRequestContentAudio))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateRequestContentObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::ModerationAPI.OneOf<global::ModerationAPI.NewModerateModerateRequestContentObjectDataText, global::ModerationAPI.NewModerateModerateRequestContentObjectDataImage, global::ModerationAPI.NewModerateModerateRequestContentObjectDataVideo, global::ModerationAPI.NewModerateModerateRequestContentObjectDataAudio>>), TypeInfoPropertyName = "NewModerateModerateRequestContentObjectDataAudio_3ecd4df47b6afadc")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.OneOf<global::ModerationAPI.NewModerateModerateRequestContentObjectDataText, global::ModerationAPI.NewModerateModerateRequestContentObjectDataImage, global::ModerationAPI.NewModerateModerateRequestContentObjectDataVideo, global::ModerationAPI.NewModerateModerateRequestContentObjectDataAudio>), TypeInfoPropertyName = "NewModerateModerateRequestContentObjectDataAudio_a7076b050589a568")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateRequestContentObjectDataText))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateRequestContentObjectDataImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateRequestContentObjectDataVideo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateRequestContentObjectDataAudio))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateRequestMetaType), TypeInfoPropertyName = "NewModerateModerateRequestMetaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateRequestClientAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateRequestClientActionAction), TypeInfoPropertyName = "NewModerateModerateRequestClientActionAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateRequestClientActionBehavior), TypeInfoPropertyName = "NewModerateModerateRequestClientActionBehavior2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ModerationAPI.OneOf<global::ModerationAPI.NewModerateModerateRequestPolicieToxicity, global::ModerationAPI.NewModerateModerateRequestPoliciePersonalInformation, global::ModerationAPI.NewModerateModerateRequestPolicieToxicitySevere, global::ModerationAPI.NewModerateModerateRequestPolicieHate, global::ModerationAPI.NewModerateModerateRequestPolicieIllicit, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitDrugs, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitAlcohol, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitFirearms, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitTobacco, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitGambling, global::ModerationAPI.NewModerateModerateRequestPolicieCannabis, global::ModerationAPI.NewModerateModerateRequestPolicieAdult, global::ModerationAPI.NewModerateModerateRequestPolicieCrypto, global::ModerationAPI.NewModerateModerateRequestPolicieSexual, global::ModerationAPI.NewModerateModerateRequestPolicieFlirtation, global::ModerationAPI.NewModerateModerateRequestPolicieProfanity, global::ModerationAPI.NewModerateModerateRequestPolicieViolence, global::ModerationAPI.NewModerateModerateRequestPolicieSelfHarm, global::ModerationAPI.NewModerateModerateRequestPolicieSpam, global::ModerationAPI.NewModerateModerateRequestPolicieLowQualityContent, global::ModerationAPI.NewModerateModerateRequestPolicieFaceDetection, global::ModerationAPI.NewModerateModerateRequestPolicieSelfPromotion, global::ModerationAPI.NewModerateModerateRequestPoliciePolitical, global::ModerationAPI.NewModerateModerateRequestPolicieReligion, global::ModerationAPI.NewModerateModerateRequestPolicieCodeAbuse, global::ModerationAPI.NewModerateModerateRequestPoliciePiiMasking, global::ModerationAPI.NewModerateModerateRequestPolicieUrlMasking, global::ModerationAPI.NewModerateModerateRequestPolicieUrlRisk, global::ModerationAPI.NewModerateModerateRequestPolicieGuideline>>), TypeInfoPropertyName = "NewModerateModerateRequestPolicieGuideline_d0eb5495177f1379")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.OneOf<global::ModerationAPI.NewModerateModerateRequestPolicieToxicity, global::ModerationAPI.NewModerateModerateRequestPoliciePersonalInformation, global::ModerationAPI.NewModerateModerateRequestPolicieToxicitySevere, global::ModerationAPI.NewModerateModerateRequestPolicieHate, global::ModerationAPI.NewModerateModerateRequestPolicieIllicit, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitDrugs, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitAlcohol, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitFirearms, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitTobacco, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitGambling, global::ModerationAPI.NewModerateModerateRequestPolicieCannabis, global::ModerationAPI.NewModerateModerateRequestPolicieAdult, global::ModerationAPI.NewModerateModerateRequestPolicieCrypto, global::ModerationAPI.NewModerateModerateRequestPolicieSexual, global::ModerationAPI.NewModerateModerateRequestPolicieFlirtation, global::ModerationAPI.NewModerateModerateRequestPolicieProfanity, global::ModerationAPI.NewModerateModerateRequestPolicieViolence, global::ModerationAPI.NewModerateModerateRequestPolicieSelfHarm, global::ModerationAPI.NewModerateModerateRequestPolicieSpam, global::ModerationAPI.NewModerateModerateRequestPolicieLowQualityContent, global::ModerationAPI.NewModerateModerateRequestPolicieFaceDetection, global::ModerationAPI.NewModerateModerateRequestPolicieSelfPromotion, global::ModerationAPI.NewModerateModerateRequestPoliciePolitical, global::ModerationAPI.NewModerateModerateRequestPolicieReligion, global::ModerationAPI.NewModerateModerateRequestPolicieCodeAbuse, global::ModerationAPI.NewModerateModerateRequestPoliciePiiMasking, global::ModerationAPI.NewModerateModerateRequestPolicieUrlMasking, global::ModerationAPI.NewModerateModerateRequestPolicieUrlRisk, global::ModerationAPI.NewModerateModerateRequestPolicieGuideline>), TypeInfoPropertyName = "NewModerateModerateRequestPolicieGuideline_b9fa603267e85329")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateRequestPolicieCannabis))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateRequestPolicieAdult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateRequestPolicieCrypto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateRequestPolicieSexual))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateRequestPolicieFlirtation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateRequestPolicieProfanity))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateRequestPolicieViolence))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateRequestPolicieSelfHarm))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateRequestPolicieSpam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateRequestPolicieLowQualityContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateRequestPolicieFaceDetection))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateRequestPolicieFaceDetectionComparator), TypeInfoPropertyName = "NewModerateModerateRequestPolicieFaceDetectionComparator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateRequestPolicieSelfPromotion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateRequestPoliciePolitical))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateRequestPolicieReligion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateRequestPolicieCodeAbuse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateRequestPoliciePiiMasking))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::ModerationAPI.NewModerateModerateRequestPoliciePiiMaskingEntities2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateRequestPoliciePiiMaskingEntities2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateRequestPolicieUrlMasking))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::ModerationAPI.NewModerateModerateRequestPolicieUrlMaskingEntities2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateRequestPolicieUrlMaskingEntities2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateRequestPolicieUrlRisk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateRequestPolicieGuideline))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.GetStreamRequest), TypeInfoPropertyName = "GetStreamRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.GetStreamRequestDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.GetStreamRequestDiscriminatorEvent), TypeInfoPropertyName = "GetStreamRequestDiscriminatorEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.AuthorOpenListAuthorsSortBy), TypeInfoPropertyName = "AuthorOpenListAuthorsSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.AuthorOpenListAuthorsSortDirection), TypeInfoPropertyName = "AuthorOpenListAuthorsSortDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.QueueViewOpenGetItemsSortField), TypeInfoPropertyName = "QueueViewOpenGetItemsSortField2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.QueueViewOpenGetItemsSortDirection), TypeInfoPropertyName = "QueueViewOpenGetItemsSortDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.GetStreamSecWebSocketProtocol), TypeInfoPropertyName = "GetStreamSecWebSocketProtocol2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.AuthorOpenListAuthorsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ModerationAPI.PublicAuthor>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.AuthorOpenListAuthorsResponsePagination))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ModerationTextResponseVariant1WordlistMode), TypeInfoPropertyName = "ModerationTextResponseVariant1WordlistMode2_3")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.AnyOf<string, object, global::System.Collections.Generic.Dictionary<string, global::ModerationAPI.OneOf<global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentText, global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentImage, global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentVideo, global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentAudio>>>), TypeInfoPropertyName = "NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentAudio_91a38b75dbf4ea1b")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::ModerationAPI.OneOf<global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentText, global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentImage, global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentVideo, global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentAudio>>), TypeInfoPropertyName = "NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentAudio_090383758cc97c36")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.OneOf<global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentText, global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentImage, global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentVideo, global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentAudio>), TypeInfoPropertyName = "NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentAudio_f8254bf745cf9a73")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentText))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentVideo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentAudio))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateResponseAuthor2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateResponseAuthorBlock2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateResponseAuthorStatus), TypeInfoPropertyName = "NewModerateModerateResponseAuthorStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateResponseAuthorTrustLevel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateResponseEvaluation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateResponseRecommendation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateResponseRecommendationAction), TypeInfoPropertyName = "NewModerateModerateResponseRecommendationAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ModerationAPI.NewModerateModerateResponseRecommendationReasonCode>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateResponseRecommendationReasonCode), TypeInfoPropertyName = "NewModerateModerateResponseRecommendationReasonCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ModerationAPI.NewModerateModerateResponseRecommendationMatchedRule>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateResponseRecommendationMatchedRule))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ModerationAPI.OneOf<global::ModerationAPI.NewModerateModerateResponsePolicieClassifierOutput, global::ModerationAPI.NewModerateModerateResponsePolicieEntityMatcherOutput>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.OneOf<global::ModerationAPI.NewModerateModerateResponsePolicieClassifierOutput, global::ModerationAPI.NewModerateModerateResponsePolicieEntityMatcherOutput>), TypeInfoPropertyName = "OneOfNewModerateModerateResponsePolicieClassifierOutputNewModerateModerateResponsePolicieEntityMatcherOutput2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateResponsePolicieClassifierOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ModerationAPI.NewModerateModerateResponsePolicieClassifierOutputLabel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateResponsePolicieClassifierOutputLabel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateResponsePolicieEntityMatcherOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ModerationAPI.NewModerateModerateResponsePolicieEntityMatcherOutputMatche>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateResponsePolicieEntityMatcherOutputMatche))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateResponsePolicieEntityMatcherOutputMatcheSignals))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateResponsePolicieEntityMatcherOutputMatcheSignalsBrandImpersonation2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateResponsePolicieEntityMatcherOutputMatcheSignalsBrandImpersonationMethod), TypeInfoPropertyName = "NewModerateModerateResponsePolicieEntityMatcherOutputMatcheSignalsBrandImpersonationMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ModerationAPI.OneOf<global::ModerationAPI.NewModerateModerateResponseInsightSentimentInsight, global::ModerationAPI.NewModerateModerateResponseInsightLanguageInsight>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.OneOf<global::ModerationAPI.NewModerateModerateResponseInsightSentimentInsight, global::ModerationAPI.NewModerateModerateResponseInsightLanguageInsight>), TypeInfoPropertyName = "OneOfNewModerateModerateResponseInsightSentimentInsightNewModerateModerateResponseInsightLanguageInsight2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateResponseInsightSentimentInsight))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateResponseInsightSentimentInsightValue2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateResponseInsightLanguageInsight))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateResponseMeta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateResponseMetaStatus), TypeInfoPropertyName = "NewModerateModerateResponseMetaStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ModerationAPI.NewModerateModerateResponseError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.GetStreamResponse), TypeInfoPropertyName = "GetStreamResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.GetStreamResponseDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.GetStreamResponseDiscriminatorEvent), TypeInfoPropertyName = "GetStreamResponseDiscriminatorEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.CreateAuthorBlockedWebhookVersion), TypeInfoPropertyName = "CreateAuthorBlockedWebhookVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.CreateAuthorUnblockedWebhookVersion), TypeInfoPropertyName = "CreateAuthorUnblockedWebhookVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.CreateAuthorSuspendedWebhookVersion), TypeInfoPropertyName = "CreateAuthorSuspendedWebhookVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.CreateAuthorUpdatedWebhookVersion), TypeInfoPropertyName = "CreateAuthorUpdatedWebhookVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.CreateAuthorTrustLevelChangedWebhookVersion), TypeInfoPropertyName = "CreateAuthorTrustLevelChangedWebhookVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.CreateAuthorActionWebhookVersion), TypeInfoPropertyName = "CreateAuthorActionWebhookVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.CreateQueueItemResolvedWebhookVersion), TypeInfoPropertyName = "CreateQueueItemResolvedWebhookVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.CreateQueueItemActionWebhookVersion), TypeInfoPropertyName = "CreateQueueItemActionWebhookVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.CreateQueueItemRejectedWebhookVersion), TypeInfoPropertyName = "CreateQueueItemRejectedWebhookVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.CreateQueueItemAllowedWebhookVersion), TypeInfoPropertyName = "CreateQueueItemAllowedWebhookVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.OneOf<global::ModerationAPI.PublicQueueItemContentText, global::ModerationAPI.PublicQueueItemContentImage, global::ModerationAPI.PublicQueueItemContentVideo, global::ModerationAPI.PublicQueueItemContentAudio, global::ModerationAPI.PublicQueueItemContentObject>?), TypeInfoPropertyName = "PublicQueueItemContentObject_0f6ae51d7c9aeddc")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.OneOf<global::ModerationAPI.PublicQueueItemContentObjectDataText, global::ModerationAPI.PublicQueueItemContentObjectDataImage, global::ModerationAPI.PublicQueueItemContentObjectDataVideo, global::ModerationAPI.PublicQueueItemContentObjectDataAudio>?), TypeInfoPropertyName = "PublicQueueItemContentObjectDataAudio_6d0dbf1252fb5aa2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.OneOf<global::ModerationAPI.NewModerateModerateRequestContentText, global::ModerationAPI.NewModerateModerateRequestContentImage, global::ModerationAPI.NewModerateModerateRequestContentVideo, global::ModerationAPI.NewModerateModerateRequestContentAudio, global::ModerationAPI.NewModerateModerateRequestContentObject>?), TypeInfoPropertyName = "NewModerateModerateRequestContentObject_1ce3d97371b2fe4b")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.OneOf<global::ModerationAPI.NewModerateModerateRequestContentObjectDataText, global::ModerationAPI.NewModerateModerateRequestContentObjectDataImage, global::ModerationAPI.NewModerateModerateRequestContentObjectDataVideo, global::ModerationAPI.NewModerateModerateRequestContentObjectDataAudio>?), TypeInfoPropertyName = "NewModerateModerateRequestContentObjectDataAudio_8997c1844e8527ae")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.OneOf<global::ModerationAPI.NewModerateModerateRequestPolicieToxicity, global::ModerationAPI.NewModerateModerateRequestPoliciePersonalInformation, global::ModerationAPI.NewModerateModerateRequestPolicieToxicitySevere, global::ModerationAPI.NewModerateModerateRequestPolicieHate, global::ModerationAPI.NewModerateModerateRequestPolicieIllicit, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitDrugs, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitAlcohol, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitFirearms, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitTobacco, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitGambling, global::ModerationAPI.NewModerateModerateRequestPolicieCannabis, global::ModerationAPI.NewModerateModerateRequestPolicieAdult, global::ModerationAPI.NewModerateModerateRequestPolicieCrypto, global::ModerationAPI.NewModerateModerateRequestPolicieSexual, global::ModerationAPI.NewModerateModerateRequestPolicieFlirtation, global::ModerationAPI.NewModerateModerateRequestPolicieProfanity, global::ModerationAPI.NewModerateModerateRequestPolicieViolence, global::ModerationAPI.NewModerateModerateRequestPolicieSelfHarm, global::ModerationAPI.NewModerateModerateRequestPolicieSpam, global::ModerationAPI.NewModerateModerateRequestPolicieLowQualityContent, global::ModerationAPI.NewModerateModerateRequestPolicieFaceDetection, global::ModerationAPI.NewModerateModerateRequestPolicieSelfPromotion, global::ModerationAPI.NewModerateModerateRequestPoliciePolitical, global::ModerationAPI.NewModerateModerateRequestPolicieReligion, global::ModerationAPI.NewModerateModerateRequestPolicieCodeAbuse, global::ModerationAPI.NewModerateModerateRequestPoliciePiiMasking, global::ModerationAPI.NewModerateModerateRequestPolicieUrlMasking, global::ModerationAPI.NewModerateModerateRequestPolicieUrlRisk, global::ModerationAPI.NewModerateModerateRequestPolicieGuideline>?), TypeInfoPropertyName = "NewModerateModerateRequestPolicieGuideline_27d68f053178e486")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.OneOf<global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentText, global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentImage, global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentVideo, global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentAudio>?), TypeInfoPropertyName = "NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentAudio_2070a92914ebe6c9")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.ErrorBadRequestIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.ErrorUnauthorizedIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.ErrorForbiddenIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.ErrorNotFoundIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.ErrorInternalServerErrorIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.ErrorConflictIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.PublicQueueItemLabelsVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.PublicQueueItemLabelsVariant1ItemMatche>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.VoiceStartFrameTrack>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.ActionsCreateRequestPossibleValue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.ActionsUpdateRequestPossibleValue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.OneOf<global::ModerationAPI.NewModerateModerateRequestPolicieToxicity, global::ModerationAPI.NewModerateModerateRequestPoliciePersonalInformation, global::ModerationAPI.NewModerateModerateRequestPolicieToxicitySevere, global::ModerationAPI.NewModerateModerateRequestPolicieHate, global::ModerationAPI.NewModerateModerateRequestPolicieIllicit, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitDrugs, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitAlcohol, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitFirearms, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitTobacco, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitGambling, global::ModerationAPI.NewModerateModerateRequestPolicieCannabis, global::ModerationAPI.NewModerateModerateRequestPolicieAdult, global::ModerationAPI.NewModerateModerateRequestPolicieCrypto, global::ModerationAPI.NewModerateModerateRequestPolicieSexual, global::ModerationAPI.NewModerateModerateRequestPolicieFlirtation, global::ModerationAPI.NewModerateModerateRequestPolicieProfanity, global::ModerationAPI.NewModerateModerateRequestPolicieViolence, global::ModerationAPI.NewModerateModerateRequestPolicieSelfHarm, global::ModerationAPI.NewModerateModerateRequestPolicieSpam, global::ModerationAPI.NewModerateModerateRequestPolicieLowQualityContent, global::ModerationAPI.NewModerateModerateRequestPolicieFaceDetection, global::ModerationAPI.NewModerateModerateRequestPolicieSelfPromotion, global::ModerationAPI.NewModerateModerateRequestPoliciePolitical, global::ModerationAPI.NewModerateModerateRequestPolicieReligion, global::ModerationAPI.NewModerateModerateRequestPolicieCodeAbuse, global::ModerationAPI.NewModerateModerateRequestPoliciePiiMasking, global::ModerationAPI.NewModerateModerateRequestPolicieUrlMasking, global::ModerationAPI.NewModerateModerateRequestPolicieUrlRisk, global::ModerationAPI.NewModerateModerateRequestPolicieGuideline>>), TypeInfoPropertyName = "NewModerateModerateRequestPolicieGuideline_04f5af6f80588c35")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.PublicAuthor>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.ActionsCreateResponsePossibleValue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.ActionsGetResponsePossibleValue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.ActionsUpdateResponsePossibleValue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.ModerationTextResponseVariant1Wordlist2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.ModerationObjectResponseVariant1Label>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.ModerationObjectResponseVariant1Entitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.ModerationObjectResponseVariant1Wordlist>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.ModerationObjectResponseVariant1Field>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.ModerationImageResponseLabel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.WordlistListResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.NewModerateModerateResponseRecommendationReasonCode>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.NewModerateModerateResponseRecommendationMatchedRule>))]
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