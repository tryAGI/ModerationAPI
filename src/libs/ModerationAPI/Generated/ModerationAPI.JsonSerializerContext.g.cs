
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    ///
    /// </summary>
    #pragma warning disable CS3016 // Converter type array in this attribute is not CLS-compliant.
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::ModerationAPI.JsonConverters.PublicAuthorStatusJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.PublicAuthorStatusNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.QueueItemStatusJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.QueueItemStatusNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.ProjectGlobalFlaggingModeJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.ProjectGlobalFlaggingModeNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.ProjectWithKeyGlobalFlaggingModeJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.ProjectWithKeyGlobalFlaggingModeNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.ChannelContentTypeJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.ChannelContentTypeNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.ChannelFlaggingModeJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.ChannelFlaggingModeNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.ChannelTranscriptionQualityJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.ChannelTranscriptionQualityNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.PublicQueueItemClientActionActionJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.PublicQueueItemClientActionActionNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.PublicQueueItemClientActionBehaviorJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.PublicQueueItemClientActionBehaviorNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.PublicQueueItemMetaTypeJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.PublicQueueItemMetaTypeNullableJsonConverter),

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

            typeof(global::ModerationAPI.JsonConverters.BadRequestErrorCodeJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.BadRequestErrorCodeNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.AuthenticationErrorCodeJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.AuthenticationErrorCodeNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.PermissionDeniedErrorCodeJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.PermissionDeniedErrorCodeNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.NotFoundErrorCodeJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.NotFoundErrorCodeNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.ConflictErrorCodeJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.ConflictErrorCodeNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.UnprocessableEntityErrorCodeJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.UnprocessableEntityErrorCodeNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.RateLimitErrorCodeJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.RateLimitErrorCodeNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.InternalServerErrorCodeJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.InternalServerErrorCodeNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.CreateFeedbackRequestTypeJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.CreateFeedbackRequestTypeNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.CreateFeedbackRequestSourceJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.CreateFeedbackRequestSourceNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.ActionsCreateRequestTypeJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.ActionsCreateRequestTypeNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.ActionsCreateRequestQueueBehaviourJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.ActionsCreateRequestQueueBehaviourNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.ActionsCreateRequestPositionJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.ActionsCreateRequestPositionNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.ActionsUpdateRequestTypeJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.ActionsUpdateRequestTypeNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.ActionsUpdateRequestQueueBehaviourJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.ActionsUpdateRequestQueueBehaviourNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.ActionsUpdateRequestPositionJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.ActionsUpdateRequestPositionNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.WebhooksPublicCreateRequestEventTypeJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.WebhooksPublicCreateRequestEventTypeNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.WebhooksPublicUpdateRequestEventTypeJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.WebhooksPublicUpdateRequestEventTypeNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.NewModerateModerateRequestMetaTypeJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.NewModerateModerateRequestMetaTypeNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.NewModerateModerateRequestClientActionActionJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.NewModerateModerateRequestClientActionActionNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.NewModerateModerateRequestClientActionBehaviorJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.NewModerateModerateRequestClientActionBehaviorNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.NewModerateModerateRequestPolicieFaceDetectionComparatorJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.NewModerateModerateRequestPolicieFaceDetectionComparatorNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.ManagementProjectsUpdateRequestGlobalFlaggingModeJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.ManagementProjectsUpdateRequestGlobalFlaggingModeNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.ManagementChannelsCreateRequestContentTypeJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.ManagementChannelsCreateRequestContentTypeNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.ManagementChannelsUpdateRequestContentTypeJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.ManagementChannelsUpdateRequestContentTypeNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.ManagementChannelsUpdateRequestFlaggingModeJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.ManagementChannelsUpdateRequestFlaggingModeNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.ManagementChannelsUpdateRequestTranscriptionQualityJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.ManagementChannelsUpdateRequestTranscriptionQualityNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.GetAnalyticsSummaryRangeJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.GetAnalyticsSummaryRangeNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.GetAnalyticsPoliciesRangeJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.GetAnalyticsPoliciesRangeNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.GetAnalyticsAuthorsRangeJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.GetAnalyticsAuthorsRangeNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.GetAnalyticsChannelsRangeJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.GetAnalyticsChannelsRangeNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.GetAnalyticsVolumesRangeJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.GetAnalyticsVolumesRangeNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.GetAnalyticsAutomationRangeJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.GetAnalyticsAutomationRangeNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.AuthorOpenListAuthorsSortByJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.AuthorOpenListAuthorsSortByNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.AuthorOpenListAuthorsSortDirectionJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.AuthorOpenListAuthorsSortDirectionNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.QueueViewOpenGetItemsSortJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.QueueViewOpenGetItemsSortNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.GetAnalyticsSummaryResponseRangeJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.GetAnalyticsSummaryResponseRangeNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.GetAnalyticsPoliciesResponseRangeJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.GetAnalyticsPoliciesResponseRangeNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.GetAnalyticsAuthorsResponseRangeJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.GetAnalyticsAuthorsResponseRangeNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.GetAnalyticsChannelsResponseRangeJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.GetAnalyticsChannelsResponseRangeNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.GetAnalyticsVolumesResponseRangeJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.GetAnalyticsVolumesResponseRangeNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.GetAnalyticsVolumesResponseBucketJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.GetAnalyticsVolumesResponseBucketNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.GetAnalyticsAutomationResponseRangeJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.GetAnalyticsAutomationResponseRangeNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.QueueViewOpenUnresolveItemResponseStatusJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.QueueViewOpenUnresolveItemResponseStatusNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.ActionsListResponseDataItemTypeJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.ActionsListResponseDataItemTypeNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.ActionsListResponseDataItemQueueBehaviourJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.ActionsListResponseDataItemQueueBehaviourNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.ActionsListResponseDataItemPositionJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.ActionsListResponseDataItemPositionNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.ActionsCreateResponseTypeJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.ActionsCreateResponseTypeNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.ActionsCreateResponseQueueBehaviourJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.ActionsCreateResponseQueueBehaviourNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.ActionsCreateResponsePositionJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.ActionsCreateResponsePositionNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.ActionsGetResponseTypeJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.ActionsGetResponseTypeNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.ActionsGetResponseQueueBehaviourJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.ActionsGetResponseQueueBehaviourNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.ActionsGetResponsePositionJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.ActionsGetResponsePositionNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.ActionsUpdateResponseTypeJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.ActionsUpdateResponseTypeNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.ActionsUpdateResponseQueueBehaviourJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.ActionsUpdateResponseQueueBehaviourNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.ActionsUpdateResponsePositionJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.ActionsUpdateResponsePositionNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.WebhooksPublicListResponseDataItemEventTypeJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.WebhooksPublicListResponseDataItemEventTypeNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.WebhooksPublicListResponseDataItemPayloadVersionJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.WebhooksPublicListResponseDataItemPayloadVersionNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.WebhooksPublicCreateResponseEventTypeJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.WebhooksPublicCreateResponseEventTypeNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.WebhooksPublicCreateResponsePayloadVersionJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.WebhooksPublicCreateResponsePayloadVersionNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.WebhooksPublicGetResponseEventTypeJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.WebhooksPublicGetResponseEventTypeNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.WebhooksPublicGetResponsePayloadVersionJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.WebhooksPublicGetResponsePayloadVersionNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.WebhooksPublicUpdateResponseEventTypeJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.WebhooksPublicUpdateResponseEventTypeNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.WebhooksPublicUpdateResponsePayloadVersionJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.WebhooksPublicUpdateResponsePayloadVersionNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.NewModerateModerateResponseAuthorStatusJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.NewModerateModerateResponseAuthorStatusNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.NewModerateModerateResponseRecommendationActionJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.NewModerateModerateResponseRecommendationActionNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.NewModerateModerateResponseRecommendationReasonCodeJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.NewModerateModerateResponseRecommendationReasonCodeNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.NewModerateModerateResponseCasebookVerdictJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.NewModerateModerateResponseCasebookVerdictNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.NewModerateModerateResponsePolicieEntityMatcherOutputMatcheSignalsBrandImpersonationMethodJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.NewModerateModerateResponsePolicieEntityMatcherOutputMatcheSignalsBrandImpersonationMethodNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.NewModerateModerateResponseInsightSentimentInsightValueJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.NewModerateModerateResponseInsightSentimentInsightValueNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.NewModerateModerateResponseMetaStatusJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.NewModerateModerateResponseMetaStatusNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.AuthorBlockedWebhookVersionJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.AuthorBlockedWebhookVersionNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.AuthorUnblockedWebhookVersionJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.AuthorUnblockedWebhookVersionNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.AuthorSuspendedWebhookVersionJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.AuthorSuspendedWebhookVersionNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.AuthorUpdatedWebhookVersionJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.AuthorUpdatedWebhookVersionNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.AuthorTrustLevelChangedWebhookVersionJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.AuthorTrustLevelChangedWebhookVersionNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.AuthorActionWebhookVersionJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.AuthorActionWebhookVersionNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.QueueItemResolvedWebhookVersionJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.QueueItemResolvedWebhookVersionNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.QueueItemActionWebhookVersionJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.QueueItemActionWebhookVersionNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.QueueItemRejectedWebhookVersionJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.QueueItemRejectedWebhookVersionNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.QueueItemAllowedWebhookVersionJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.QueueItemAllowedWebhookVersionNullableJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.WebhookEventJsonConverter),

            typeof(global::ModerationAPI.JsonConverters.OneOfJsonConverter<global::ModerationAPI.QueueItemContentText, global::ModerationAPI.QueueItemContentImage, global::ModerationAPI.QueueItemContentVideo, global::ModerationAPI.QueueItemContentAudio, global::ModerationAPI.QueueItemContentObject>),

            typeof(global::ModerationAPI.JsonConverters.OneOfJsonConverter<global::ModerationAPI.QueueItemContentObjectDataText, global::ModerationAPI.QueueItemContentObjectDataImage, global::ModerationAPI.QueueItemContentObjectDataVideo, global::ModerationAPI.QueueItemContentObjectDataAudio>),

            typeof(global::ModerationAPI.JsonConverters.OneOfJsonConverter<global::ModerationAPI.PublicQueueItemContentText, global::ModerationAPI.PublicQueueItemContentImage, global::ModerationAPI.PublicQueueItemContentVideo, global::ModerationAPI.PublicQueueItemContentAudio, global::ModerationAPI.PublicQueueItemContentObject>),

            typeof(global::ModerationAPI.JsonConverters.OneOfJsonConverter<global::ModerationAPI.PublicQueueItemContentObjectDataText, global::ModerationAPI.PublicQueueItemContentObjectDataImage, global::ModerationAPI.PublicQueueItemContentObjectDataVideo, global::ModerationAPI.PublicQueueItemContentObjectDataAudio>),

            typeof(global::ModerationAPI.JsonConverters.AnyOfJsonConverter<string, double?>),

            typeof(global::ModerationAPI.JsonConverters.OneOfJsonConverter<global::ModerationAPI.NewModerateModerateRequestContentText, global::ModerationAPI.NewModerateModerateRequestContentImage, global::ModerationAPI.NewModerateModerateRequestContentVideo, global::ModerationAPI.NewModerateModerateRequestContentAudio, global::ModerationAPI.NewModerateModerateRequestContentObject>),

            typeof(global::ModerationAPI.JsonConverters.OneOfJsonConverter<global::ModerationAPI.NewModerateModerateRequestContentObjectDataText, global::ModerationAPI.NewModerateModerateRequestContentObjectDataImage, global::ModerationAPI.NewModerateModerateRequestContentObjectDataVideo, global::ModerationAPI.NewModerateModerateRequestContentObjectDataAudio>),

            typeof(global::ModerationAPI.JsonConverters.OneOfJsonConverter<global::ModerationAPI.NewModerateModerateRequestPolicieToxicity, global::ModerationAPI.NewModerateModerateRequestPoliciePersonalInformation, global::ModerationAPI.NewModerateModerateRequestPolicieHate, global::ModerationAPI.NewModerateModerateRequestPolicieIllicit, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitDrugs, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitAlcohol, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitFirearms, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitTobacco, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitGambling, global::ModerationAPI.NewModerateModerateRequestPolicieCannabis, global::ModerationAPI.NewModerateModerateRequestPolicieAdult, global::ModerationAPI.NewModerateModerateRequestPolicieCrypto, global::ModerationAPI.NewModerateModerateRequestPolicieSexual, global::ModerationAPI.NewModerateModerateRequestPolicieSexualMinors, global::ModerationAPI.NewModerateModerateRequestPolicieProfanity, global::ModerationAPI.NewModerateModerateRequestPolicieViolence, global::ModerationAPI.NewModerateModerateRequestPolicieSelfHarm, global::ModerationAPI.NewModerateModerateRequestPolicieSpam, global::ModerationAPI.NewModerateModerateRequestPolicieLowQualityContent, global::ModerationAPI.NewModerateModerateRequestPolicieFaceDetection, global::ModerationAPI.NewModerateModerateRequestPolicieSelfPromotion, global::ModerationAPI.NewModerateModerateRequestPoliciePolitical, global::ModerationAPI.NewModerateModerateRequestPolicieReligion, global::ModerationAPI.NewModerateModerateRequestPolicieThreat, global::ModerationAPI.NewModerateModerateRequestPolicieSexualSolicitation, global::ModerationAPI.NewModerateModerateRequestPolicieChannelCircumvention, global::ModerationAPI.NewModerateModerateRequestPolicieIllegalTrade, global::ModerationAPI.NewModerateModerateRequestPolicieAlcohol, global::ModerationAPI.NewModerateModerateRequestPolicieDrugs, global::ModerationAPI.NewModerateModerateRequestPolicieGambling, global::ModerationAPI.NewModerateModerateRequestPolicieTobacco, global::ModerationAPI.NewModerateModerateRequestPolicieWeapons, global::ModerationAPI.NewModerateModerateRequestPoliciePromotion, global::ModerationAPI.NewModerateModerateRequestPolicieExtremism, global::ModerationAPI.NewModerateModerateRequestPolicieCodeAbuse, global::ModerationAPI.NewModerateModerateRequestPolicieUnicodeSpoofing, global::ModerationAPI.NewModerateModerateRequestPoliciePiiMasking, global::ModerationAPI.NewModerateModerateRequestPolicieUrlMasking, global::ModerationAPI.NewModerateModerateRequestPolicieUrlRisk, global::ModerationAPI.NewModerateModerateRequestPolicieGuideline>),

            typeof(global::ModerationAPI.JsonConverters.AnyOfJsonConverter<string, object, global::System.Collections.Generic.Dictionary<string, global::ModerationAPI.OneOf<global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentText, global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentImage, global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentVideo, global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentAudio>>>),

            typeof(global::ModerationAPI.JsonConverters.OneOfJsonConverter<global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentText, global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentImage, global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentVideo, global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentAudio>),

            typeof(global::ModerationAPI.JsonConverters.AnyOfJsonConverter<global::ModerationAPI.NewModerateModerateResponseRecommendationReasonCode?, string>),

            typeof(global::ModerationAPI.JsonConverters.OneOfJsonConverter<global::ModerationAPI.NewModerateModerateResponsePolicieClassifierOutput, global::ModerationAPI.NewModerateModerateResponsePolicieEntityMatcherOutput>),

            typeof(global::ModerationAPI.JsonConverters.OneOfJsonConverter<global::ModerationAPI.NewModerateModerateResponseInsightSentimentInsight, global::ModerationAPI.NewModerateModerateResponseInsightLanguageInsight, global::ModerationAPI.NewModerateModerateResponseInsightCuriosityInsight, global::ModerationAPI.NewModerateModerateResponseInsightRespectInsight, global::ModerationAPI.NewModerateModerateResponseInsightPersonalStoryInsight, global::ModerationAPI.NewModerateModerateResponseInsightCompassionInsight>),

            typeof(global::ModerationAPI.JsonConverters.UnixTimestampJsonConverter),
        })]
    #pragma warning restore CS3016
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.PublicAuthor))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.PublicAuthorStatus), TypeInfoPropertyName = "PublicAuthorStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.PublicAuthorTrustLevel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.PublicAuthorBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.PublicAuthorRiskEvaluation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.PublicAuthorMetrics))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.PublicAuthorMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.Queue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.QueueWithCounts))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.QueueItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.OneOf<global::ModerationAPI.QueueItemContentText, global::ModerationAPI.QueueItemContentImage, global::ModerationAPI.QueueItemContentVideo, global::ModerationAPI.QueueItemContentAudio, global::ModerationAPI.QueueItemContentObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.QueueItemContentText))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.QueueItemContentImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.QueueItemContentVideo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.QueueItemContentAudio))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.QueueItemContentObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::ModerationAPI.OneOf<global::ModerationAPI.QueueItemContentObjectDataText, global::ModerationAPI.QueueItemContentObjectDataImage, global::ModerationAPI.QueueItemContentObjectDataVideo, global::ModerationAPI.QueueItemContentObjectDataAudio>>), TypeInfoPropertyName = "QueueItemContentObjectDataAudio_8553da6e2cecbbbb")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.OneOf<global::ModerationAPI.QueueItemContentObjectDataText, global::ModerationAPI.QueueItemContentObjectDataImage, global::ModerationAPI.QueueItemContentObjectDataVideo, global::ModerationAPI.QueueItemContentObjectDataAudio>), TypeInfoPropertyName = "QueueItemContentObjectDataAudio_aa3397d2851ed486")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.QueueItemContentObjectDataText))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.QueueItemContentObjectDataImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.QueueItemContentObjectDataVideo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.QueueItemContentObjectDataAudio))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ModerationAPI.QueueItemLabel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.QueueItemLabel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ModerationAPI.QueueItemLabelMatche>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.QueueItemLabelMatche))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.QueueItemLabelMatcheSignals))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.QueueItemLabelMatcheSignalsBrandImpersonation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.QueueItemStatus), TypeInfoPropertyName = "QueueItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.Project))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ProjectGlobalFlaggingMode), TypeInfoPropertyName = "ProjectGlobalFlaggingMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ProjectWithKey))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ProjectWithKeyGlobalFlaggingMode), TypeInfoPropertyName = "ProjectWithKeyGlobalFlaggingMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ProjectApiKey))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.Channel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ChannelContentType), TypeInfoPropertyName = "ChannelContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ChannelFlaggingMode), TypeInfoPropertyName = "ChannelFlaggingMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ChannelTranscriptionQuality), TypeInfoPropertyName = "ChannelTranscriptionQuality2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.PublicQueueItemLabelsVariant1ItemMatcheSignals))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.PublicQueueItemLabelsVariant1ItemMatcheSignalsBrandImpersonation))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.PublicQueueItemClientAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.PublicQueueItemClientActionAction), TypeInfoPropertyName = "PublicQueueItemClientActionAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.PublicQueueItemClientActionBehavior), TypeInfoPropertyName = "PublicQueueItemClientActionBehavior2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.PublicQueueItemMetaType), TypeInfoPropertyName = "PublicQueueItemMetaType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.Pagination))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ErrorIssue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ModerationAPI.AnyOf<string, double?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.AnyOf<string, double?>), TypeInfoPropertyName = "AnyOfStringDouble2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.BadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.BadRequestErrorCode), TypeInfoPropertyName = "BadRequestErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ModerationAPI.ErrorIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.AuthenticationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.AuthenticationErrorCode), TypeInfoPropertyName = "AuthenticationErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.PermissionDeniedError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.PermissionDeniedErrorCode), TypeInfoPropertyName = "PermissionDeniedErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NotFoundError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NotFoundErrorCode), TypeInfoPropertyName = "NotFoundErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ConflictError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ConflictErrorCode), TypeInfoPropertyName = "ConflictErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.UnprocessableEntityError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.UnprocessableEntityErrorCode), TypeInfoPropertyName = "UnprocessableEntityErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.RateLimitError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.RateLimitErrorCode), TypeInfoPropertyName = "RateLimitErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.InternalServerError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.InternalServerErrorCode), TypeInfoPropertyName = "InternalServerErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.AuthorOpenCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.AuthorOpenCreateRequestMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.AuthorOpenUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.AuthorOpenUpdateRequestMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.CreateFeedbackRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.CreateFeedbackRequestType), TypeInfoPropertyName = "CreateFeedbackRequestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.CreateFeedbackRequestSource), TypeInfoPropertyName = "CreateFeedbackRequestSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ResolveQueueItemsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsCreateRequestType), TypeInfoPropertyName = "ActionsCreateRequestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsCreateRequestQueueBehaviour), TypeInfoPropertyName = "ActionsCreateRequestQueueBehaviour2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsCreateRequestPosition), TypeInfoPropertyName = "ActionsCreateRequestPosition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ModerationAPI.ActionsCreateRequestPossibleValue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsCreateRequestPossibleValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsUpdateRequestType), TypeInfoPropertyName = "ActionsUpdateRequestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsUpdateRequestQueueBehaviour), TypeInfoPropertyName = "ActionsUpdateRequestQueueBehaviour2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsUpdateRequestPosition), TypeInfoPropertyName = "ActionsUpdateRequestPosition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ModerationAPI.ActionsUpdateRequestPossibleValue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsUpdateRequestPossibleValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsExecuteRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.RejectContentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.AllowContentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.BlockAuthorRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.SuspendAuthorRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.UnblockAuthorRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.WebhooksPublicCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ModerationAPI.WebhooksPublicCreateRequestEventType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.WebhooksPublicCreateRequestEventType), TypeInfoPropertyName = "WebhooksPublicCreateRequestEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.WebhooksPublicUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ModerationAPI.WebhooksPublicUpdateRequestEventType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.WebhooksPublicUpdateRequestEventType), TypeInfoPropertyName = "WebhooksPublicUpdateRequestEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.CreateWordlistRequest))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ModerationAPI.OneOf<global::ModerationAPI.NewModerateModerateRequestPolicieToxicity, global::ModerationAPI.NewModerateModerateRequestPoliciePersonalInformation, global::ModerationAPI.NewModerateModerateRequestPolicieHate, global::ModerationAPI.NewModerateModerateRequestPolicieIllicit, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitDrugs, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitAlcohol, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitFirearms, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitTobacco, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitGambling, global::ModerationAPI.NewModerateModerateRequestPolicieCannabis, global::ModerationAPI.NewModerateModerateRequestPolicieAdult, global::ModerationAPI.NewModerateModerateRequestPolicieCrypto, global::ModerationAPI.NewModerateModerateRequestPolicieSexual, global::ModerationAPI.NewModerateModerateRequestPolicieSexualMinors, global::ModerationAPI.NewModerateModerateRequestPolicieProfanity, global::ModerationAPI.NewModerateModerateRequestPolicieViolence, global::ModerationAPI.NewModerateModerateRequestPolicieSelfHarm, global::ModerationAPI.NewModerateModerateRequestPolicieSpam, global::ModerationAPI.NewModerateModerateRequestPolicieLowQualityContent, global::ModerationAPI.NewModerateModerateRequestPolicieFaceDetection, global::ModerationAPI.NewModerateModerateRequestPolicieSelfPromotion, global::ModerationAPI.NewModerateModerateRequestPoliciePolitical, global::ModerationAPI.NewModerateModerateRequestPolicieReligion, global::ModerationAPI.NewModerateModerateRequestPolicieThreat, global::ModerationAPI.NewModerateModerateRequestPolicieSexualSolicitation, global::ModerationAPI.NewModerateModerateRequestPolicieChannelCircumvention, global::ModerationAPI.NewModerateModerateRequestPolicieIllegalTrade, global::ModerationAPI.NewModerateModerateRequestPolicieAlcohol, global::ModerationAPI.NewModerateModerateRequestPolicieDrugs, global::ModerationAPI.NewModerateModerateRequestPolicieGambling, global::ModerationAPI.NewModerateModerateRequestPolicieTobacco, global::ModerationAPI.NewModerateModerateRequestPolicieWeapons, global::ModerationAPI.NewModerateModerateRequestPoliciePromotion, global::ModerationAPI.NewModerateModerateRequestPolicieExtremism, global::ModerationAPI.NewModerateModerateRequestPolicieCodeAbuse, global::ModerationAPI.NewModerateModerateRequestPolicieUnicodeSpoofing, global::ModerationAPI.NewModerateModerateRequestPoliciePiiMasking, global::ModerationAPI.NewModerateModerateRequestPolicieUrlMasking, global::ModerationAPI.NewModerateModerateRequestPolicieUrlRisk, global::ModerationAPI.NewModerateModerateRequestPolicieGuideline>>), TypeInfoPropertyName = "NewModerateModerateRequestPolicieGuideline_4f41f5791e0537bc")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.OneOf<global::ModerationAPI.NewModerateModerateRequestPolicieToxicity, global::ModerationAPI.NewModerateModerateRequestPoliciePersonalInformation, global::ModerationAPI.NewModerateModerateRequestPolicieHate, global::ModerationAPI.NewModerateModerateRequestPolicieIllicit, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitDrugs, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitAlcohol, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitFirearms, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitTobacco, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitGambling, global::ModerationAPI.NewModerateModerateRequestPolicieCannabis, global::ModerationAPI.NewModerateModerateRequestPolicieAdult, global::ModerationAPI.NewModerateModerateRequestPolicieCrypto, global::ModerationAPI.NewModerateModerateRequestPolicieSexual, global::ModerationAPI.NewModerateModerateRequestPolicieSexualMinors, global::ModerationAPI.NewModerateModerateRequestPolicieProfanity, global::ModerationAPI.NewModerateModerateRequestPolicieViolence, global::ModerationAPI.NewModerateModerateRequestPolicieSelfHarm, global::ModerationAPI.NewModerateModerateRequestPolicieSpam, global::ModerationAPI.NewModerateModerateRequestPolicieLowQualityContent, global::ModerationAPI.NewModerateModerateRequestPolicieFaceDetection, global::ModerationAPI.NewModerateModerateRequestPolicieSelfPromotion, global::ModerationAPI.NewModerateModerateRequestPoliciePolitical, global::ModerationAPI.NewModerateModerateRequestPolicieReligion, global::ModerationAPI.NewModerateModerateRequestPolicieThreat, global::ModerationAPI.NewModerateModerateRequestPolicieSexualSolicitation, global::ModerationAPI.NewModerateModerateRequestPolicieChannelCircumvention, global::ModerationAPI.NewModerateModerateRequestPolicieIllegalTrade, global::ModerationAPI.NewModerateModerateRequestPolicieAlcohol, global::ModerationAPI.NewModerateModerateRequestPolicieDrugs, global::ModerationAPI.NewModerateModerateRequestPolicieGambling, global::ModerationAPI.NewModerateModerateRequestPolicieTobacco, global::ModerationAPI.NewModerateModerateRequestPolicieWeapons, global::ModerationAPI.NewModerateModerateRequestPoliciePromotion, global::ModerationAPI.NewModerateModerateRequestPolicieExtremism, global::ModerationAPI.NewModerateModerateRequestPolicieCodeAbuse, global::ModerationAPI.NewModerateModerateRequestPolicieUnicodeSpoofing, global::ModerationAPI.NewModerateModerateRequestPoliciePiiMasking, global::ModerationAPI.NewModerateModerateRequestPolicieUrlMasking, global::ModerationAPI.NewModerateModerateRequestPolicieUrlRisk, global::ModerationAPI.NewModerateModerateRequestPolicieGuideline>), TypeInfoPropertyName = "NewModerateModerateRequestPolicieGuideline_54567719dd6a6b3a")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateRequestPolicieToxicity))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateRequestPoliciePersonalInformation))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateRequestPolicieSexualMinors))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateRequestPolicieThreat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateRequestPolicieSexualSolicitation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateRequestPolicieChannelCircumvention))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateRequestPolicieIllegalTrade))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateRequestPolicieAlcohol))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateRequestPolicieDrugs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateRequestPolicieGambling))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateRequestPolicieTobacco))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateRequestPolicieWeapons))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateRequestPoliciePromotion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateRequestPolicieExtremism))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateRequestPolicieCodeAbuse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateRequestPolicieUnicodeSpoofing))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::ModerationAPI.NewModerateModerateRequestPolicieUnicodeSpoofingSignals2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateRequestPolicieUnicodeSpoofingSignals2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateRequestPoliciePiiMasking))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::ModerationAPI.NewModerateModerateRequestPoliciePiiMaskingEntities2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateRequestPoliciePiiMaskingEntities2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateRequestPolicieUrlMasking))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::ModerationAPI.NewModerateModerateRequestPolicieUrlMaskingEntities2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateRequestPolicieUrlMaskingEntities2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateRequestPolicieUrlRisk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateRequestPolicieGuideline))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ManagementProjectsCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ManagementProjectsUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ManagementProjectsUpdateRequestGlobalFlaggingMode), TypeInfoPropertyName = "ManagementProjectsUpdateRequestGlobalFlaggingMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ManagementProjectsDuplicateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.CreateProjectApiKeyRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ManagementChannelsCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ManagementChannelsCreateRequestContentType), TypeInfoPropertyName = "ManagementChannelsCreateRequestContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ManagementChannelsUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ManagementChannelsUpdateRequestContentType), TypeInfoPropertyName = "ManagementChannelsUpdateRequestContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ManagementChannelsUpdateRequestFlaggingMode), TypeInfoPropertyName = "ManagementChannelsUpdateRequestFlaggingMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ManagementChannelsUpdateRequestTranscriptionQuality), TypeInfoPropertyName = "ManagementChannelsUpdateRequestTranscriptionQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ManagementChannelsDuplicateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.GetAnalyticsSummaryRange), TypeInfoPropertyName = "GetAnalyticsSummaryRange2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.GetAnalyticsPoliciesRange), TypeInfoPropertyName = "GetAnalyticsPoliciesRange2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.GetAnalyticsAuthorsRange), TypeInfoPropertyName = "GetAnalyticsAuthorsRange2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.GetAnalyticsChannelsRange), TypeInfoPropertyName = "GetAnalyticsChannelsRange2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.GetAnalyticsVolumesRange), TypeInfoPropertyName = "GetAnalyticsVolumesRange2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.GetAnalyticsAutomationRange), TypeInfoPropertyName = "GetAnalyticsAutomationRange2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.AuthorOpenListAuthorsSortBy), TypeInfoPropertyName = "AuthorOpenListAuthorsSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.AuthorOpenListAuthorsSortDirection), TypeInfoPropertyName = "AuthorOpenListAuthorsSortDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.QueueViewOpenGetItemsSort), TypeInfoPropertyName = "QueueViewOpenGetItemsSort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.GetAnalyticsSummaryResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.GetAnalyticsSummaryResponseRange), TypeInfoPropertyName = "GetAnalyticsSummaryResponseRange2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.GetAnalyticsSummaryResponseTotals))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.GetAnalyticsSummaryResponsePreviousPeriod))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.GetAnalyticsSummaryResponseFlagRateSpike))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.GetAnalyticsPoliciesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.GetAnalyticsPoliciesResponseRange), TypeInfoPropertyName = "GetAnalyticsPoliciesResponseRange2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ModerationAPI.GetAnalyticsPoliciesResponsePolicie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.GetAnalyticsPoliciesResponsePolicie))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.GetAnalyticsAuthorsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.GetAnalyticsAuthorsResponseRange), TypeInfoPropertyName = "GetAnalyticsAuthorsResponseRange2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ModerationAPI.GetAnalyticsAuthorsResponseAuthor>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.GetAnalyticsAuthorsResponseAuthor))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.GetAnalyticsChannelsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.GetAnalyticsChannelsResponseRange), TypeInfoPropertyName = "GetAnalyticsChannelsResponseRange2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ModerationAPI.GetAnalyticsChannelsResponseChannel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.GetAnalyticsChannelsResponseChannel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.GetAnalyticsVolumesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.GetAnalyticsVolumesResponseRange), TypeInfoPropertyName = "GetAnalyticsVolumesResponseRange2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.GetAnalyticsVolumesResponseBucket), TypeInfoPropertyName = "GetAnalyticsVolumesResponseBucket2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ModerationAPI.GetAnalyticsVolumesResponseVolume>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.GetAnalyticsVolumesResponseVolume))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.GetAnalyticsAutomationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.GetAnalyticsAutomationResponseRange), TypeInfoPropertyName = "GetAnalyticsAutomationResponseRange2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ModerationAPI.GetAnalyticsAutomationResponseRule>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.GetAnalyticsAutomationResponseRule))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.AuthorOpenListAuthorsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ModerationAPI.PublicAuthor>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.AuthorDeleteResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.CreateFeedbackResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ListQueuesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ModerationAPI.Queue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.QueueViewOpenGetQueueResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.QueueViewOpenGetStatsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.QueueViewOpenGetStatsResponseReviewStats))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ModerationAPI.QueueViewOpenGetStatsResponseTopReviewer>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.QueueViewOpenGetStatsResponseTopReviewer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.QueueViewOpenGetStatsResponseTrends))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ModerationAPI.QueueViewOpenGetStatsResponseTrendsDailyReviewCount>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.QueueViewOpenGetStatsResponseTrendsDailyReviewCount))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.QueueViewOpenGetItemsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ModerationAPI.QueueItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.QueueViewOpenResolveItemResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ResolveQueueItemsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.QueueViewOpenUnresolveItemResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.QueueViewOpenUnresolveItemResponseStatus), TypeInfoPropertyName = "QueueViewOpenUnresolveItemResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ModerationAPI.ActionsListResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsListResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsListResponseDataItemType), TypeInfoPropertyName = "ActionsListResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsListResponseDataItemQueueBehaviour), TypeInfoPropertyName = "ActionsListResponseDataItemQueueBehaviour2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsListResponseDataItemPosition), TypeInfoPropertyName = "ActionsListResponseDataItemPosition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ModerationAPI.ActionsListResponseDataItemPossibleValue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsListResponseDataItemPossibleValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsCreateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsCreateResponseType), TypeInfoPropertyName = "ActionsCreateResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsCreateResponseQueueBehaviour), TypeInfoPropertyName = "ActionsCreateResponseQueueBehaviour2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsCreateResponsePosition), TypeInfoPropertyName = "ActionsCreateResponsePosition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ModerationAPI.ActionsCreateResponsePossibleValue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsCreateResponsePossibleValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsGetResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsGetResponseType), TypeInfoPropertyName = "ActionsGetResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsGetResponseQueueBehaviour), TypeInfoPropertyName = "ActionsGetResponseQueueBehaviour2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsGetResponsePosition), TypeInfoPropertyName = "ActionsGetResponsePosition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ModerationAPI.ActionsGetResponsePossibleValue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsGetResponsePossibleValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsUpdateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsUpdateResponseType), TypeInfoPropertyName = "ActionsUpdateResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsUpdateResponseQueueBehaviour), TypeInfoPropertyName = "ActionsUpdateResponseQueueBehaviour2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsUpdateResponsePosition), TypeInfoPropertyName = "ActionsUpdateResponsePosition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ModerationAPI.ActionsUpdateResponsePossibleValue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsUpdateResponsePossibleValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsDeleteResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsExecuteResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.RejectContentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.AllowContentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.BlockAuthorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.SuspendAuthorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.UnblockAuthorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.WebhooksPublicListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ModerationAPI.WebhooksPublicListResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.WebhooksPublicListResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ModerationAPI.WebhooksPublicListResponseDataItemEventType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.WebhooksPublicListResponseDataItemEventType), TypeInfoPropertyName = "WebhooksPublicListResponseDataItemEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.WebhooksPublicListResponseDataItemPayloadVersion), TypeInfoPropertyName = "WebhooksPublicListResponseDataItemPayloadVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.WebhooksPublicCreateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ModerationAPI.WebhooksPublicCreateResponseEventType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.WebhooksPublicCreateResponseEventType), TypeInfoPropertyName = "WebhooksPublicCreateResponseEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.WebhooksPublicCreateResponsePayloadVersion), TypeInfoPropertyName = "WebhooksPublicCreateResponsePayloadVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.WebhooksPublicGetResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ModerationAPI.WebhooksPublicGetResponseEventType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.WebhooksPublicGetResponseEventType), TypeInfoPropertyName = "WebhooksPublicGetResponseEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.WebhooksPublicGetResponsePayloadVersion), TypeInfoPropertyName = "WebhooksPublicGetResponsePayloadVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.WebhooksPublicUpdateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ModerationAPI.WebhooksPublicUpdateResponseEventType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.WebhooksPublicUpdateResponseEventType), TypeInfoPropertyName = "WebhooksPublicUpdateResponseEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.WebhooksPublicUpdateResponsePayloadVersion), TypeInfoPropertyName = "WebhooksPublicUpdateResponsePayloadVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.WebhooksPublicDeleteResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.WebhooksPublicGetSecretResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.AccountGetResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.AccountGetResponseCurrentProject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.WordlistListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ModerationAPI.WordlistListResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.WordlistListResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.CreateWordlistResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.WordlistGetWordlistPublicResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.WordlistUpdateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.DeleteWordlistResponse))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateResponseAuthor))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateResponseAuthorBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateResponseAuthorStatus), TypeInfoPropertyName = "NewModerateModerateResponseAuthorStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateResponseAuthorTrustLevel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateResponseEvaluation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateResponseRecommendation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateResponseRecommendationAction), TypeInfoPropertyName = "NewModerateModerateResponseRecommendationAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ModerationAPI.AnyOf<global::ModerationAPI.NewModerateModerateResponseRecommendationReasonCode?, string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.AnyOf<global::ModerationAPI.NewModerateModerateResponseRecommendationReasonCode?, string>), TypeInfoPropertyName = "AnyOfNewModerateModerateResponseRecommendationReasonCodeString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateResponseRecommendationReasonCode), TypeInfoPropertyName = "NewModerateModerateResponseRecommendationReasonCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ModerationAPI.NewModerateModerateResponseRecommendationMatchedRule>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateResponseRecommendationMatchedRule))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateResponseCasebook))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateResponseCasebookVerdict), TypeInfoPropertyName = "NewModerateModerateResponseCasebookVerdict2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateResponseCasebookTopic))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateResponsePolicieEntityMatcherOutputMatcheSignalsBrandImpersonation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateResponsePolicieEntityMatcherOutputMatcheSignalsBrandImpersonationMethod), TypeInfoPropertyName = "NewModerateModerateResponsePolicieEntityMatcherOutputMatcheSignalsBrandImpersonationMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ModerationAPI.OneOf<global::ModerationAPI.NewModerateModerateResponseInsightSentimentInsight, global::ModerationAPI.NewModerateModerateResponseInsightLanguageInsight, global::ModerationAPI.NewModerateModerateResponseInsightCuriosityInsight, global::ModerationAPI.NewModerateModerateResponseInsightRespectInsight, global::ModerationAPI.NewModerateModerateResponseInsightPersonalStoryInsight, global::ModerationAPI.NewModerateModerateResponseInsightCompassionInsight>>), TypeInfoPropertyName = "NewModerateModerateResponseInsightCompassionInsight_bbc8f2b751f130ff")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.OneOf<global::ModerationAPI.NewModerateModerateResponseInsightSentimentInsight, global::ModerationAPI.NewModerateModerateResponseInsightLanguageInsight, global::ModerationAPI.NewModerateModerateResponseInsightCuriosityInsight, global::ModerationAPI.NewModerateModerateResponseInsightRespectInsight, global::ModerationAPI.NewModerateModerateResponseInsightPersonalStoryInsight, global::ModerationAPI.NewModerateModerateResponseInsightCompassionInsight>), TypeInfoPropertyName = "NewModerateModerateResponseInsightCompassionInsight_b15949f21de9d079")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateResponseInsightSentimentInsight))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateResponseInsightSentimentInsightValue), TypeInfoPropertyName = "NewModerateModerateResponseInsightSentimentInsightValue2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateResponseInsightSentimentInsightScores))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateResponseInsightLanguageInsight))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateResponseInsightCuriosityInsight))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateResponseInsightRespectInsight))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateResponseInsightPersonalStoryInsight))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateResponseInsightCompassionInsight))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateResponseMeta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateResponseMetaStatus), TypeInfoPropertyName = "NewModerateModerateResponseMetaStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ModerationAPI.NewModerateModerateResponseError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ManagementProjectsListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ModerationAPI.Project>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ManagementProjectsDeleteResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ManagementChannelsListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ModerationAPI.Channel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ManagementChannelsDeleteResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.AuthorBlockedWebhookVersion), TypeInfoPropertyName = "AuthorBlockedWebhookVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.AuthorUnblockedWebhookVersion), TypeInfoPropertyName = "AuthorUnblockedWebhookVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.AuthorSuspendedWebhookVersion), TypeInfoPropertyName = "AuthorSuspendedWebhookVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.AuthorUpdatedWebhookVersion), TypeInfoPropertyName = "AuthorUpdatedWebhookVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.AuthorTrustLevelChangedWebhookVersion), TypeInfoPropertyName = "AuthorTrustLevelChangedWebhookVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.AuthorActionWebhookVersion), TypeInfoPropertyName = "AuthorActionWebhookVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.QueueItemResolvedWebhookVersion), TypeInfoPropertyName = "QueueItemResolvedWebhookVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.QueueItemActionWebhookVersion), TypeInfoPropertyName = "QueueItemActionWebhookVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.QueueItemRejectedWebhookVersion), TypeInfoPropertyName = "QueueItemRejectedWebhookVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.QueueItemAllowedWebhookVersion), TypeInfoPropertyName = "QueueItemAllowedWebhookVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.OneOf<global::ModerationAPI.QueueItemContentObjectDataText, global::ModerationAPI.QueueItemContentObjectDataImage, global::ModerationAPI.QueueItemContentObjectDataVideo, global::ModerationAPI.QueueItemContentObjectDataAudio>?), TypeInfoPropertyName = "QueueItemContentObjectDataAudio_f7ddcff4010421f0")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.OneOf<global::ModerationAPI.PublicQueueItemContentText, global::ModerationAPI.PublicQueueItemContentImage, global::ModerationAPI.PublicQueueItemContentVideo, global::ModerationAPI.PublicQueueItemContentAudio, global::ModerationAPI.PublicQueueItemContentObject>?), TypeInfoPropertyName = "PublicQueueItemContentObject_0f6ae51d7c9aeddc")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.OneOf<global::ModerationAPI.PublicQueueItemContentObjectDataText, global::ModerationAPI.PublicQueueItemContentObjectDataImage, global::ModerationAPI.PublicQueueItemContentObjectDataVideo, global::ModerationAPI.PublicQueueItemContentObjectDataAudio>?), TypeInfoPropertyName = "PublicQueueItemContentObjectDataAudio_6d0dbf1252fb5aa2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.OneOf<global::ModerationAPI.NewModerateModerateRequestContentText, global::ModerationAPI.NewModerateModerateRequestContentImage, global::ModerationAPI.NewModerateModerateRequestContentVideo, global::ModerationAPI.NewModerateModerateRequestContentAudio, global::ModerationAPI.NewModerateModerateRequestContentObject>?), TypeInfoPropertyName = "NewModerateModerateRequestContentObject_1ce3d97371b2fe4b")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.OneOf<global::ModerationAPI.NewModerateModerateRequestContentObjectDataText, global::ModerationAPI.NewModerateModerateRequestContentObjectDataImage, global::ModerationAPI.NewModerateModerateRequestContentObjectDataVideo, global::ModerationAPI.NewModerateModerateRequestContentObjectDataAudio>?), TypeInfoPropertyName = "NewModerateModerateRequestContentObjectDataAudio_8997c1844e8527ae")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.OneOf<global::ModerationAPI.NewModerateModerateRequestPolicieToxicity, global::ModerationAPI.NewModerateModerateRequestPoliciePersonalInformation, global::ModerationAPI.NewModerateModerateRequestPolicieHate, global::ModerationAPI.NewModerateModerateRequestPolicieIllicit, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitDrugs, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitAlcohol, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitFirearms, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitTobacco, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitGambling, global::ModerationAPI.NewModerateModerateRequestPolicieCannabis, global::ModerationAPI.NewModerateModerateRequestPolicieAdult, global::ModerationAPI.NewModerateModerateRequestPolicieCrypto, global::ModerationAPI.NewModerateModerateRequestPolicieSexual, global::ModerationAPI.NewModerateModerateRequestPolicieSexualMinors, global::ModerationAPI.NewModerateModerateRequestPolicieProfanity, global::ModerationAPI.NewModerateModerateRequestPolicieViolence, global::ModerationAPI.NewModerateModerateRequestPolicieSelfHarm, global::ModerationAPI.NewModerateModerateRequestPolicieSpam, global::ModerationAPI.NewModerateModerateRequestPolicieLowQualityContent, global::ModerationAPI.NewModerateModerateRequestPolicieFaceDetection, global::ModerationAPI.NewModerateModerateRequestPolicieSelfPromotion, global::ModerationAPI.NewModerateModerateRequestPoliciePolitical, global::ModerationAPI.NewModerateModerateRequestPolicieReligion, global::ModerationAPI.NewModerateModerateRequestPolicieThreat, global::ModerationAPI.NewModerateModerateRequestPolicieSexualSolicitation, global::ModerationAPI.NewModerateModerateRequestPolicieChannelCircumvention, global::ModerationAPI.NewModerateModerateRequestPolicieIllegalTrade, global::ModerationAPI.NewModerateModerateRequestPolicieAlcohol, global::ModerationAPI.NewModerateModerateRequestPolicieDrugs, global::ModerationAPI.NewModerateModerateRequestPolicieGambling, global::ModerationAPI.NewModerateModerateRequestPolicieTobacco, global::ModerationAPI.NewModerateModerateRequestPolicieWeapons, global::ModerationAPI.NewModerateModerateRequestPoliciePromotion, global::ModerationAPI.NewModerateModerateRequestPolicieExtremism, global::ModerationAPI.NewModerateModerateRequestPolicieCodeAbuse, global::ModerationAPI.NewModerateModerateRequestPolicieUnicodeSpoofing, global::ModerationAPI.NewModerateModerateRequestPoliciePiiMasking, global::ModerationAPI.NewModerateModerateRequestPolicieUrlMasking, global::ModerationAPI.NewModerateModerateRequestPolicieUrlRisk, global::ModerationAPI.NewModerateModerateRequestPolicieGuideline>?), TypeInfoPropertyName = "NewModerateModerateRequestPolicieGuideline_276ab216136ef869")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.OneOf<global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentText, global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentImage, global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentVideo, global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentAudio>?), TypeInfoPropertyName = "NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentAudio_2070a92914ebe6c9")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.OneOf<global::ModerationAPI.NewModerateModerateResponseInsightSentimentInsight, global::ModerationAPI.NewModerateModerateResponseInsightLanguageInsight, global::ModerationAPI.NewModerateModerateResponseInsightCuriosityInsight, global::ModerationAPI.NewModerateModerateResponseInsightRespectInsight, global::ModerationAPI.NewModerateModerateResponseInsightPersonalStoryInsight, global::ModerationAPI.NewModerateModerateResponseInsightCompassionInsight>?), TypeInfoPropertyName = "NewModerateModerateResponseInsightCompassionInsight_057944cfe90894fb")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.QueueItemLabel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.QueueItemLabelMatche>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.PublicQueueItemLabelsVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.PublicQueueItemLabelsVariant1ItemMatche>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.VoiceStartFrameTrack>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.AnyOf<string, double?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.ErrorIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.ActionsCreateRequestPossibleValue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.ActionsUpdateRequestPossibleValue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.WebhooksPublicCreateRequestEventType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.WebhooksPublicUpdateRequestEventType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.OneOf<global::ModerationAPI.NewModerateModerateRequestPolicieToxicity, global::ModerationAPI.NewModerateModerateRequestPoliciePersonalInformation, global::ModerationAPI.NewModerateModerateRequestPolicieHate, global::ModerationAPI.NewModerateModerateRequestPolicieIllicit, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitDrugs, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitAlcohol, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitFirearms, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitTobacco, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitGambling, global::ModerationAPI.NewModerateModerateRequestPolicieCannabis, global::ModerationAPI.NewModerateModerateRequestPolicieAdult, global::ModerationAPI.NewModerateModerateRequestPolicieCrypto, global::ModerationAPI.NewModerateModerateRequestPolicieSexual, global::ModerationAPI.NewModerateModerateRequestPolicieSexualMinors, global::ModerationAPI.NewModerateModerateRequestPolicieProfanity, global::ModerationAPI.NewModerateModerateRequestPolicieViolence, global::ModerationAPI.NewModerateModerateRequestPolicieSelfHarm, global::ModerationAPI.NewModerateModerateRequestPolicieSpam, global::ModerationAPI.NewModerateModerateRequestPolicieLowQualityContent, global::ModerationAPI.NewModerateModerateRequestPolicieFaceDetection, global::ModerationAPI.NewModerateModerateRequestPolicieSelfPromotion, global::ModerationAPI.NewModerateModerateRequestPoliciePolitical, global::ModerationAPI.NewModerateModerateRequestPolicieReligion, global::ModerationAPI.NewModerateModerateRequestPolicieThreat, global::ModerationAPI.NewModerateModerateRequestPolicieSexualSolicitation, global::ModerationAPI.NewModerateModerateRequestPolicieChannelCircumvention, global::ModerationAPI.NewModerateModerateRequestPolicieIllegalTrade, global::ModerationAPI.NewModerateModerateRequestPolicieAlcohol, global::ModerationAPI.NewModerateModerateRequestPolicieDrugs, global::ModerationAPI.NewModerateModerateRequestPolicieGambling, global::ModerationAPI.NewModerateModerateRequestPolicieTobacco, global::ModerationAPI.NewModerateModerateRequestPolicieWeapons, global::ModerationAPI.NewModerateModerateRequestPoliciePromotion, global::ModerationAPI.NewModerateModerateRequestPolicieExtremism, global::ModerationAPI.NewModerateModerateRequestPolicieCodeAbuse, global::ModerationAPI.NewModerateModerateRequestPolicieUnicodeSpoofing, global::ModerationAPI.NewModerateModerateRequestPoliciePiiMasking, global::ModerationAPI.NewModerateModerateRequestPolicieUrlMasking, global::ModerationAPI.NewModerateModerateRequestPolicieUrlRisk, global::ModerationAPI.NewModerateModerateRequestPolicieGuideline>>), TypeInfoPropertyName = "NewModerateModerateRequestPolicieGuideline_81e602994a082871")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.GetAnalyticsPoliciesResponsePolicie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.GetAnalyticsAuthorsResponseAuthor>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.GetAnalyticsChannelsResponseChannel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.GetAnalyticsVolumesResponseVolume>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.GetAnalyticsAutomationResponseRule>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.PublicAuthor>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.Queue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.QueueViewOpenGetStatsResponseTopReviewer>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.QueueViewOpenGetStatsResponseTrendsDailyReviewCount>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.QueueItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.ActionsListResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.ActionsListResponseDataItemPossibleValue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.ActionsCreateResponsePossibleValue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.ActionsGetResponsePossibleValue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.ActionsUpdateResponsePossibleValue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.WebhooksPublicListResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.WebhooksPublicListResponseDataItemEventType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.WebhooksPublicCreateResponseEventType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.WebhooksPublicGetResponseEventType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.WebhooksPublicUpdateResponseEventType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.WordlistListResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.AnyOf<global::ModerationAPI.NewModerateModerateResponseRecommendationReasonCode?, string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.NewModerateModerateResponseRecommendationMatchedRule>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.OneOf<global::ModerationAPI.NewModerateModerateResponsePolicieClassifierOutput, global::ModerationAPI.NewModerateModerateResponsePolicieEntityMatcherOutput>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.NewModerateModerateResponsePolicieClassifierOutputLabel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.NewModerateModerateResponsePolicieEntityMatcherOutputMatche>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.OneOf<global::ModerationAPI.NewModerateModerateResponseInsightSentimentInsight, global::ModerationAPI.NewModerateModerateResponseInsightLanguageInsight, global::ModerationAPI.NewModerateModerateResponseInsightCuriosityInsight, global::ModerationAPI.NewModerateModerateResponseInsightRespectInsight, global::ModerationAPI.NewModerateModerateResponseInsightPersonalStoryInsight, global::ModerationAPI.NewModerateModerateResponseInsightCompassionInsight>>), TypeInfoPropertyName = "NewModerateModerateResponseInsightCompassionInsight_25e4d46d685d828b")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.NewModerateModerateResponseError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.Project>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.Channel>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}