
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull
    )]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.OneOf<global::ModerationAPI.PublicQueueItemContentText, global::ModerationAPI.PublicQueueItemContentImage, global::ModerationAPI.PublicQueueItemContentVideo, global::ModerationAPI.PublicQueueItemContentAudio, global::ModerationAPI.PublicQueueItemContentObject>), TypeInfoPropertyName = "PublicQueueItemContentObject_a5b10a16560a2a90")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::ModerationAPI.OneOf<global::ModerationAPI.PublicQueueItemContentObjectDataText, global::ModerationAPI.PublicQueueItemContentObjectDataImage, global::ModerationAPI.PublicQueueItemContentObjectDataVideo, global::ModerationAPI.PublicQueueItemContentObjectDataAudio>>), TypeInfoPropertyName = "PublicQueueItemContentObjectDataAudio_9fba358e4ede806b")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.OneOf<global::ModerationAPI.PublicQueueItemContentObjectDataText, global::ModerationAPI.PublicQueueItemContentObjectDataImage, global::ModerationAPI.PublicQueueItemContentObjectDataVideo, global::ModerationAPI.PublicQueueItemContentObjectDataAudio>), TypeInfoPropertyName = "PublicQueueItemContentObjectDataAudio_f4551668b35ad437")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.OneOf<global::ModerationAPI.PublicQueueItemContentText, global::ModerationAPI.PublicQueueItemContentImage, global::ModerationAPI.PublicQueueItemContentVideo, global::ModerationAPI.PublicQueueItemContentAudio, global::ModerationAPI.PublicQueueItemContentObject>?), TypeInfoPropertyName = "PublicQueueItemContentObject_0f6ae51d7c9aeddc")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.OneOf<global::ModerationAPI.PublicQueueItemContentObjectDataText, global::ModerationAPI.PublicQueueItemContentObjectDataImage, global::ModerationAPI.PublicQueueItemContentObjectDataVideo, global::ModerationAPI.PublicQueueItemContentObjectDataAudio>?), TypeInfoPropertyName = "PublicQueueItemContentObjectDataAudio_6d0dbf1252fb5aa2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.PublicQueueItemContentText))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.PublicQueueItemContentImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.PublicQueueItemContentVideo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.PublicQueueItemContentAudio))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.PublicQueueItemContentObject))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.Pagination))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ErrorIssue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ModerationAPI.AnyOf<string, double?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.AnyOf<string, double?>), TypeInfoPropertyName = "AnyOfStringDouble2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.BadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.BadRequestErrorCode), TypeInfoPropertyName = "BadRequestErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ModerationAPI.ErrorIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.AuthenticationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.AuthenticationErrorCode), TypeInfoPropertyName = "AuthenticationErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NotFoundError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NotFoundErrorCode), TypeInfoPropertyName = "NotFoundErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.RateLimitError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.RateLimitErrorCode), TypeInfoPropertyName = "RateLimitErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.WebhooksPublicCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ModerationAPI.WebhooksPublicCreateRequestEventType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.WebhooksPublicCreateRequestEventType), TypeInfoPropertyName = "WebhooksPublicCreateRequestEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.WebhooksPublicUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ModerationAPI.WebhooksPublicUpdateRequestEventType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.WebhooksPublicUpdateRequestEventType), TypeInfoPropertyName = "WebhooksPublicUpdateRequestEventType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.PublicAuthorStatus?), TypeInfoPropertyName = "NullablePublicAuthorStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.PublicQueueItemClientActionAction?), TypeInfoPropertyName = "NullablePublicQueueItemClientActionAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.PublicQueueItemClientActionBehavior?), TypeInfoPropertyName = "NullablePublicQueueItemClientActionBehavior2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.PublicQueueItemMetaType?), TypeInfoPropertyName = "NullablePublicQueueItemMetaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.WebhookEvent?), TypeInfoPropertyName = "NullableWebhookEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.AnyOf<string, double?>?), TypeInfoPropertyName = "NullableAnyOfStringDouble2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.BadRequestErrorCode?), TypeInfoPropertyName = "NullableBadRequestErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.AuthenticationErrorCode?), TypeInfoPropertyName = "NullableAuthenticationErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NotFoundErrorCode?), TypeInfoPropertyName = "NullableNotFoundErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.RateLimitErrorCode?), TypeInfoPropertyName = "NullableRateLimitErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.WebhooksPublicCreateRequestEventType?), TypeInfoPropertyName = "NullableWebhooksPublicCreateRequestEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.WebhooksPublicUpdateRequestEventType?), TypeInfoPropertyName = "NullableWebhooksPublicUpdateRequestEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.WebhooksPublicListResponseDataItemEventType?), TypeInfoPropertyName = "NullableWebhooksPublicListResponseDataItemEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.WebhooksPublicListResponseDataItemPayloadVersion?), TypeInfoPropertyName = "NullableWebhooksPublicListResponseDataItemPayloadVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.WebhooksPublicCreateResponseEventType?), TypeInfoPropertyName = "NullableWebhooksPublicCreateResponseEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.WebhooksPublicCreateResponsePayloadVersion?), TypeInfoPropertyName = "NullableWebhooksPublicCreateResponsePayloadVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.WebhooksPublicGetResponseEventType?), TypeInfoPropertyName = "NullableWebhooksPublicGetResponseEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.WebhooksPublicGetResponsePayloadVersion?), TypeInfoPropertyName = "NullableWebhooksPublicGetResponsePayloadVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.WebhooksPublicUpdateResponseEventType?), TypeInfoPropertyName = "NullableWebhooksPublicUpdateResponseEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.WebhooksPublicUpdateResponsePayloadVersion?), TypeInfoPropertyName = "NullableWebhooksPublicUpdateResponsePayloadVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.AuthorBlockedWebhookVersion?), TypeInfoPropertyName = "NullableAuthorBlockedWebhookVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.AuthorUnblockedWebhookVersion?), TypeInfoPropertyName = "NullableAuthorUnblockedWebhookVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.AuthorSuspendedWebhookVersion?), TypeInfoPropertyName = "NullableAuthorSuspendedWebhookVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.AuthorUpdatedWebhookVersion?), TypeInfoPropertyName = "NullableAuthorUpdatedWebhookVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.AuthorTrustLevelChangedWebhookVersion?), TypeInfoPropertyName = "NullableAuthorTrustLevelChangedWebhookVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.AuthorActionWebhookVersion?), TypeInfoPropertyName = "NullableAuthorActionWebhookVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.QueueItemResolvedWebhookVersion?), TypeInfoPropertyName = "NullableQueueItemResolvedWebhookVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.QueueItemActionWebhookVersion?), TypeInfoPropertyName = "NullableQueueItemActionWebhookVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.QueueItemRejectedWebhookVersion?), TypeInfoPropertyName = "NullableQueueItemRejectedWebhookVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.QueueItemAllowedWebhookVersion?), TypeInfoPropertyName = "NullableQueueItemAllowedWebhookVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.PublicQueueItemLabelsVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.PublicQueueItemLabelsVariant1ItemMatche>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.AnyOf<string, double?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.ErrorIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.WebhooksPublicCreateRequestEventType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.WebhooksPublicUpdateRequestEventType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.WebhooksPublicListResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.WebhooksPublicListResponseDataItemEventType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.WebhooksPublicCreateResponseEventType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.WebhooksPublicGetResponseEventType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.WebhooksPublicUpdateResponseEventType>))]
    internal sealed partial class WebhooksSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class WebhooksSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static WebhooksSourceGenerationContext Default { get; } = new(DefaultOptions);

        private WebhooksSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::ModerationAPI.JsonConverters.WebhookEventJsonConverter());
            options.Converters.Add(new global::ModerationAPI.JsonConverters.OneOfJsonConverter<global::ModerationAPI.PublicQueueItemContentText, global::ModerationAPI.PublicQueueItemContentImage, global::ModerationAPI.PublicQueueItemContentVideo, global::ModerationAPI.PublicQueueItemContentAudio, global::ModerationAPI.PublicQueueItemContentObject>());
            options.Converters.Add(new global::ModerationAPI.JsonConverters.OneOfJsonConverter<global::ModerationAPI.PublicQueueItemContentObjectDataText, global::ModerationAPI.PublicQueueItemContentObjectDataImage, global::ModerationAPI.PublicQueueItemContentObjectDataVideo, global::ModerationAPI.PublicQueueItemContentObjectDataAudio>());
            options.Converters.Add(new global::ModerationAPI.JsonConverters.AnyOfJsonConverter<string, double?>());
            options.Converters.Add(new global::ModerationAPI.JsonConverters.UnixTimestampJsonConverter());
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::ModerationAPI.PublicAuthorStatus)

                    || typeToConvert == typeof(global::ModerationAPI.PublicAuthorStatus?)

                    || typeToConvert == typeof(global::ModerationAPI.PublicQueueItemClientActionAction)

                    || typeToConvert == typeof(global::ModerationAPI.PublicQueueItemClientActionAction?)

                    || typeToConvert == typeof(global::ModerationAPI.PublicQueueItemClientActionBehavior)

                    || typeToConvert == typeof(global::ModerationAPI.PublicQueueItemClientActionBehavior?)

                    || typeToConvert == typeof(global::ModerationAPI.PublicQueueItemMetaType)

                    || typeToConvert == typeof(global::ModerationAPI.PublicQueueItemMetaType?)

                    || typeToConvert == typeof(global::ModerationAPI.BadRequestErrorCode)

                    || typeToConvert == typeof(global::ModerationAPI.BadRequestErrorCode?)

                    || typeToConvert == typeof(global::ModerationAPI.AuthenticationErrorCode)

                    || typeToConvert == typeof(global::ModerationAPI.AuthenticationErrorCode?)

                    || typeToConvert == typeof(global::ModerationAPI.NotFoundErrorCode)

                    || typeToConvert == typeof(global::ModerationAPI.NotFoundErrorCode?)

                    || typeToConvert == typeof(global::ModerationAPI.RateLimitErrorCode)

                    || typeToConvert == typeof(global::ModerationAPI.RateLimitErrorCode?)

                    || typeToConvert == typeof(global::ModerationAPI.WebhooksPublicCreateRequestEventType)

                    || typeToConvert == typeof(global::ModerationAPI.WebhooksPublicCreateRequestEventType?)

                    || typeToConvert == typeof(global::ModerationAPI.WebhooksPublicUpdateRequestEventType)

                    || typeToConvert == typeof(global::ModerationAPI.WebhooksPublicUpdateRequestEventType?)

                    || typeToConvert == typeof(global::ModerationAPI.WebhooksPublicListResponseDataItemEventType)

                    || typeToConvert == typeof(global::ModerationAPI.WebhooksPublicListResponseDataItemEventType?)

                    || typeToConvert == typeof(global::ModerationAPI.WebhooksPublicListResponseDataItemPayloadVersion)

                    || typeToConvert == typeof(global::ModerationAPI.WebhooksPublicListResponseDataItemPayloadVersion?)

                    || typeToConvert == typeof(global::ModerationAPI.WebhooksPublicCreateResponseEventType)

                    || typeToConvert == typeof(global::ModerationAPI.WebhooksPublicCreateResponseEventType?)

                    || typeToConvert == typeof(global::ModerationAPI.WebhooksPublicCreateResponsePayloadVersion)

                    || typeToConvert == typeof(global::ModerationAPI.WebhooksPublicCreateResponsePayloadVersion?)

                    || typeToConvert == typeof(global::ModerationAPI.WebhooksPublicGetResponseEventType)

                    || typeToConvert == typeof(global::ModerationAPI.WebhooksPublicGetResponseEventType?)

                    || typeToConvert == typeof(global::ModerationAPI.WebhooksPublicGetResponsePayloadVersion)

                    || typeToConvert == typeof(global::ModerationAPI.WebhooksPublicGetResponsePayloadVersion?)

                    || typeToConvert == typeof(global::ModerationAPI.WebhooksPublicUpdateResponseEventType)

                    || typeToConvert == typeof(global::ModerationAPI.WebhooksPublicUpdateResponseEventType?)

                    || typeToConvert == typeof(global::ModerationAPI.WebhooksPublicUpdateResponsePayloadVersion)

                    || typeToConvert == typeof(global::ModerationAPI.WebhooksPublicUpdateResponsePayloadVersion?)

                    || typeToConvert == typeof(global::ModerationAPI.AuthorBlockedWebhookVersion)

                    || typeToConvert == typeof(global::ModerationAPI.AuthorBlockedWebhookVersion?)

                    || typeToConvert == typeof(global::ModerationAPI.AuthorUnblockedWebhookVersion)

                    || typeToConvert == typeof(global::ModerationAPI.AuthorUnblockedWebhookVersion?)

                    || typeToConvert == typeof(global::ModerationAPI.AuthorSuspendedWebhookVersion)

                    || typeToConvert == typeof(global::ModerationAPI.AuthorSuspendedWebhookVersion?)

                    || typeToConvert == typeof(global::ModerationAPI.AuthorUpdatedWebhookVersion)

                    || typeToConvert == typeof(global::ModerationAPI.AuthorUpdatedWebhookVersion?)

                    || typeToConvert == typeof(global::ModerationAPI.AuthorTrustLevelChangedWebhookVersion)

                    || typeToConvert == typeof(global::ModerationAPI.AuthorTrustLevelChangedWebhookVersion?)

                    || typeToConvert == typeof(global::ModerationAPI.AuthorActionWebhookVersion)

                    || typeToConvert == typeof(global::ModerationAPI.AuthorActionWebhookVersion?)

                    || typeToConvert == typeof(global::ModerationAPI.QueueItemResolvedWebhookVersion)

                    || typeToConvert == typeof(global::ModerationAPI.QueueItemResolvedWebhookVersion?)

                    || typeToConvert == typeof(global::ModerationAPI.QueueItemActionWebhookVersion)

                    || typeToConvert == typeof(global::ModerationAPI.QueueItemActionWebhookVersion?)

                    || typeToConvert == typeof(global::ModerationAPI.QueueItemRejectedWebhookVersion)

                    || typeToConvert == typeof(global::ModerationAPI.QueueItemRejectedWebhookVersion?)

                    || typeToConvert == typeof(global::ModerationAPI.QueueItemAllowedWebhookVersion)

                    || typeToConvert == typeof(global::ModerationAPI.QueueItemAllowedWebhookVersion?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::ModerationAPI.PublicAuthorStatus))
                {
                    return new global::ModerationAPI.JsonConverters.PublicAuthorStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.PublicAuthorStatus?))
                {
                    return new global::ModerationAPI.JsonConverters.PublicAuthorStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.PublicQueueItemClientActionAction))
                {
                    return new global::ModerationAPI.JsonConverters.PublicQueueItemClientActionActionJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.PublicQueueItemClientActionAction?))
                {
                    return new global::ModerationAPI.JsonConverters.PublicQueueItemClientActionActionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.PublicQueueItemClientActionBehavior))
                {
                    return new global::ModerationAPI.JsonConverters.PublicQueueItemClientActionBehaviorJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.PublicQueueItemClientActionBehavior?))
                {
                    return new global::ModerationAPI.JsonConverters.PublicQueueItemClientActionBehaviorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.PublicQueueItemMetaType))
                {
                    return new global::ModerationAPI.JsonConverters.PublicQueueItemMetaTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.PublicQueueItemMetaType?))
                {
                    return new global::ModerationAPI.JsonConverters.PublicQueueItemMetaTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.BadRequestErrorCode))
                {
                    return new global::ModerationAPI.JsonConverters.BadRequestErrorCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.BadRequestErrorCode?))
                {
                    return new global::ModerationAPI.JsonConverters.BadRequestErrorCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.AuthenticationErrorCode))
                {
                    return new global::ModerationAPI.JsonConverters.AuthenticationErrorCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.AuthenticationErrorCode?))
                {
                    return new global::ModerationAPI.JsonConverters.AuthenticationErrorCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.NotFoundErrorCode))
                {
                    return new global::ModerationAPI.JsonConverters.NotFoundErrorCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.NotFoundErrorCode?))
                {
                    return new global::ModerationAPI.JsonConverters.NotFoundErrorCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.RateLimitErrorCode))
                {
                    return new global::ModerationAPI.JsonConverters.RateLimitErrorCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.RateLimitErrorCode?))
                {
                    return new global::ModerationAPI.JsonConverters.RateLimitErrorCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.WebhooksPublicCreateRequestEventType))
                {
                    return new global::ModerationAPI.JsonConverters.WebhooksPublicCreateRequestEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.WebhooksPublicCreateRequestEventType?))
                {
                    return new global::ModerationAPI.JsonConverters.WebhooksPublicCreateRequestEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.WebhooksPublicUpdateRequestEventType))
                {
                    return new global::ModerationAPI.JsonConverters.WebhooksPublicUpdateRequestEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.WebhooksPublicUpdateRequestEventType?))
                {
                    return new global::ModerationAPI.JsonConverters.WebhooksPublicUpdateRequestEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.WebhooksPublicListResponseDataItemEventType))
                {
                    return new global::ModerationAPI.JsonConverters.WebhooksPublicListResponseDataItemEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.WebhooksPublicListResponseDataItemEventType?))
                {
                    return new global::ModerationAPI.JsonConverters.WebhooksPublicListResponseDataItemEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.WebhooksPublicListResponseDataItemPayloadVersion))
                {
                    return new global::ModerationAPI.JsonConverters.WebhooksPublicListResponseDataItemPayloadVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.WebhooksPublicListResponseDataItemPayloadVersion?))
                {
                    return new global::ModerationAPI.JsonConverters.WebhooksPublicListResponseDataItemPayloadVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.WebhooksPublicCreateResponseEventType))
                {
                    return new global::ModerationAPI.JsonConverters.WebhooksPublicCreateResponseEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.WebhooksPublicCreateResponseEventType?))
                {
                    return new global::ModerationAPI.JsonConverters.WebhooksPublicCreateResponseEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.WebhooksPublicCreateResponsePayloadVersion))
                {
                    return new global::ModerationAPI.JsonConverters.WebhooksPublicCreateResponsePayloadVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.WebhooksPublicCreateResponsePayloadVersion?))
                {
                    return new global::ModerationAPI.JsonConverters.WebhooksPublicCreateResponsePayloadVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.WebhooksPublicGetResponseEventType))
                {
                    return new global::ModerationAPI.JsonConverters.WebhooksPublicGetResponseEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.WebhooksPublicGetResponseEventType?))
                {
                    return new global::ModerationAPI.JsonConverters.WebhooksPublicGetResponseEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.WebhooksPublicGetResponsePayloadVersion))
                {
                    return new global::ModerationAPI.JsonConverters.WebhooksPublicGetResponsePayloadVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.WebhooksPublicGetResponsePayloadVersion?))
                {
                    return new global::ModerationAPI.JsonConverters.WebhooksPublicGetResponsePayloadVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.WebhooksPublicUpdateResponseEventType))
                {
                    return new global::ModerationAPI.JsonConverters.WebhooksPublicUpdateResponseEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.WebhooksPublicUpdateResponseEventType?))
                {
                    return new global::ModerationAPI.JsonConverters.WebhooksPublicUpdateResponseEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.WebhooksPublicUpdateResponsePayloadVersion))
                {
                    return new global::ModerationAPI.JsonConverters.WebhooksPublicUpdateResponsePayloadVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.WebhooksPublicUpdateResponsePayloadVersion?))
                {
                    return new global::ModerationAPI.JsonConverters.WebhooksPublicUpdateResponsePayloadVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.AuthorBlockedWebhookVersion))
                {
                    return new global::ModerationAPI.JsonConverters.AuthorBlockedWebhookVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.AuthorBlockedWebhookVersion?))
                {
                    return new global::ModerationAPI.JsonConverters.AuthorBlockedWebhookVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.AuthorUnblockedWebhookVersion))
                {
                    return new global::ModerationAPI.JsonConverters.AuthorUnblockedWebhookVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.AuthorUnblockedWebhookVersion?))
                {
                    return new global::ModerationAPI.JsonConverters.AuthorUnblockedWebhookVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.AuthorSuspendedWebhookVersion))
                {
                    return new global::ModerationAPI.JsonConverters.AuthorSuspendedWebhookVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.AuthorSuspendedWebhookVersion?))
                {
                    return new global::ModerationAPI.JsonConverters.AuthorSuspendedWebhookVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.AuthorUpdatedWebhookVersion))
                {
                    return new global::ModerationAPI.JsonConverters.AuthorUpdatedWebhookVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.AuthorUpdatedWebhookVersion?))
                {
                    return new global::ModerationAPI.JsonConverters.AuthorUpdatedWebhookVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.AuthorTrustLevelChangedWebhookVersion))
                {
                    return new global::ModerationAPI.JsonConverters.AuthorTrustLevelChangedWebhookVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.AuthorTrustLevelChangedWebhookVersion?))
                {
                    return new global::ModerationAPI.JsonConverters.AuthorTrustLevelChangedWebhookVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.AuthorActionWebhookVersion))
                {
                    return new global::ModerationAPI.JsonConverters.AuthorActionWebhookVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.AuthorActionWebhookVersion?))
                {
                    return new global::ModerationAPI.JsonConverters.AuthorActionWebhookVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.QueueItemResolvedWebhookVersion))
                {
                    return new global::ModerationAPI.JsonConverters.QueueItemResolvedWebhookVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.QueueItemResolvedWebhookVersion?))
                {
                    return new global::ModerationAPI.JsonConverters.QueueItemResolvedWebhookVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.QueueItemActionWebhookVersion))
                {
                    return new global::ModerationAPI.JsonConverters.QueueItemActionWebhookVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.QueueItemActionWebhookVersion?))
                {
                    return new global::ModerationAPI.JsonConverters.QueueItemActionWebhookVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.QueueItemRejectedWebhookVersion))
                {
                    return new global::ModerationAPI.JsonConverters.QueueItemRejectedWebhookVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.QueueItemRejectedWebhookVersion?))
                {
                    return new global::ModerationAPI.JsonConverters.QueueItemRejectedWebhookVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.QueueItemAllowedWebhookVersion))
                {
                    return new global::ModerationAPI.JsonConverters.QueueItemAllowedWebhookVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.QueueItemAllowedWebhookVersion?))
                {
                    return new global::ModerationAPI.JsonConverters.QueueItemAllowedWebhookVersionNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[1];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new WebhooksSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}