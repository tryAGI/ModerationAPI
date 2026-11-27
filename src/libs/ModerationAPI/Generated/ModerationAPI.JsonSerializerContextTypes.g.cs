
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace ModerationAPI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class JsonSerializerContextTypes
    {
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? StringStringDictionary { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? StringObjectDictionary { get; set; }

        /// <summary>
        /// Runtime object lists used by dynamic JSON payloads such as tool arguments.
        /// </summary>
        public global::System.Collections.Generic.List<object>? ObjectList { get; set; }

        /// <summary>
        /// String arrays used by dynamic JSON option values.
        /// </summary>
        public string[]? StringArray { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Text.Json.JsonElement? JsonElement { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.PublicAuthor? Type0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public string? Type1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public object? Type2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double? Type3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.PublicAuthorStatus? Type4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.PublicAuthorTrustLevel? Type5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public bool? Type6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.PublicAuthorBlock? Type7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.PublicAuthorRiskEvaluation? Type8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.PublicAuthorMetrics? Type9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.PublicAuthorMetadata? Type10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.Queue? Type11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueWithCounts? Type12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueItem? Type14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.OneOf<global::ModerationAPI.QueueItemContentText, global::ModerationAPI.QueueItemContentImage, global::ModerationAPI.QueueItemContentVideo, global::ModerationAPI.QueueItemContentAudio, global::ModerationAPI.QueueItemContentObject>? Type15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueItemContentText? Type16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueItemContentImage? Type17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueItemContentVideo? Type18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueItemContentAudio? Type19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueItemContentObject? Type20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueItemContentObjectDataText? Type21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueItemContentObjectDataImage? Type22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueItemContentObjectDataVideo? Type23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueItemContentObjectDataAudio? Type24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.QueueItemLabel>? Type25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueItemLabel? Type26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.QueueItemLabelMatche>? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueItemLabelMatche? Type28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<double>? Type29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueItemLabelMatcheSignals? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueItemLabelMatcheSignalsBrandImpersonation? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueItemStatus? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.Project? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ProjectGlobalFlaggingMode? Type35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ProjectWithKey? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ProjectWithKeyGlobalFlaggingMode? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ProjectApiKey? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.Channel? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ChannelContentType? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ChannelFlaggingMode? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ChannelTranscriptionQuality? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ChannelPolicy? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ChannelPolicyType? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ChannelGuideline? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ChannelWordlist? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ChannelWordlistType? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.AuthorBlockedEvent? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTime? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.AuthorBlockedEventData? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.PublicActionPerformedAuthor? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.PublicActionPerformedAuthorQueue? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.AuthorUnblockedEvent? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.AuthorUnblockedEventData? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.AuthorSuspendedEvent? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.AuthorSuspendedEventData? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.AuthorUpdatedEvent? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.AuthorUpdatedEventData? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.AuthorTrustLevelChangedEvent? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.AuthorTrustLevelChangedEventData? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.AuthorActionEvent? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.AuthorActionEventData? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueItemCompletedEvent? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueItemCompletedEventData? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.PublicQueueItemEvent? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.PublicQueueItem? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.PublicQueueItemEventQueue? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.PublicQueueItemLabelsVariant1Item>? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.PublicQueueItemLabelsVariant1Item? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.PublicQueueItemLabelsVariant1ItemMatche>? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.PublicQueueItemLabelsVariant1ItemMatche? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.PublicQueueItemLabelsVariant1ItemMatcheSignals? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.PublicQueueItemLabelsVariant1ItemMatcheSignalsBrandImpersonation? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.PublicQueueItemContentText? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.PublicQueueItemContentImage? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.PublicQueueItemContentVideo? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.PublicQueueItemContentAudio? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.PublicQueueItemContentObject? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.PublicQueueItemContentObjectDataText? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.PublicQueueItemContentObjectDataImage? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.PublicQueueItemContentObjectDataVideo? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.PublicQueueItemContentObjectDataAudio? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.PublicQueueItemClientAction? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.PublicQueueItemClientActionAction? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.PublicQueueItemClientActionBehavior? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.PublicQueueItemMetaType? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueItemActionEvent? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueItemActionEventData? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.PublicActionPerformed? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.PublicActionPerformedQueue? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueItemRejectedEvent? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueItemRejectedEventData? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueItemAllowedEvent? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueItemAllowedEventData? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.WebhookEvent? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.WebhookEventDiscriminator? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.WebhookEventDiscriminatorType? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.VoiceStartFrame? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.VoiceStartFrameEvent? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.VoiceStartFrameMediaFormat? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.VoiceStartFrameTrack>? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.VoiceStartFrameTrack? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.VoiceStartFrameTrackName? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.VoiceMediaFrame? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.VoiceMediaFrameEvent? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.VoiceMediaFrameMedia? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.VoiceMediaFrameMediaTrack? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.VoiceStopFrame? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.VoiceStopFrameEvent? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.VoiceSessionStarted? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.VoiceSessionStartedEvent? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.VoiceUtteranceFinal? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.VoiceUtteranceFinalEvent? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.VoiceUtteranceFinalTrack? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.VoiceUtteranceFinalRecommendation? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.VoiceUtteranceFinalRecommendationAction? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<object>? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.VoiceSessionEnded? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.VoiceSessionEndedEvent? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.VoiceSessionEndedStats? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.VoiceSessionEndedStatsActions? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.Pagination? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ErrorIssue? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.AnyOf<string, double?>>? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.AnyOf<string, double?>? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.BadRequestError? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.BadRequestErrorCode? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.ErrorIssue>? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.AuthenticationError? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.AuthenticationErrorCode? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.PermissionDeniedError? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.PermissionDeniedErrorCode? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NotFoundError? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NotFoundErrorCode? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ConflictError? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ConflictErrorCode? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.UnprocessableEntityError? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.UnprocessableEntityErrorCode? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.RateLimitError? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.RateLimitErrorCode? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.InternalServerError? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.InternalServerErrorCode? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.AuthorOpenCreateRequest? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.AuthorOpenCreateRequestMetadata? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.AuthorOpenUpdateRequest? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.AuthorOpenUpdateRequestMetadata? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.CreateFeedbackRequest? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.CreateFeedbackRequestType? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.CreateFeedbackRequestSource? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ResolveQueueItemsRequest? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsCreateRequest? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsCreateRequestType? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsCreateRequestQueueBehaviour? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsCreateRequestPosition? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.ActionsCreateRequestPossibleValue>? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsCreateRequestPossibleValue? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsUpdateRequest? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsUpdateRequestType? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsUpdateRequestQueueBehaviour? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsUpdateRequestPosition? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.ActionsUpdateRequestPossibleValue>? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsUpdateRequestPossibleValue? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsExecuteRequest? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.RejectContentRequest? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.AllowContentRequest? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.BlockAuthorRequest? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.SuspendAuthorRequest? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.UnblockAuthorRequest? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.WebhooksPublicCreateRequest? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.WebhooksPublicCreateRequestEventType>? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.WebhooksPublicCreateRequestEventType? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.WebhooksPublicUpdateRequest? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.WebhooksPublicUpdateRequestEventType>? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.WebhooksPublicUpdateRequestEventType? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.CreateWordlistRequest? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.WordlistUpdateRequest? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.WordlistAddWordsRequest? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequest? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestContentText? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestContentImage? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestContentVideo? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestContentAudio? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestContentObject? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestContentObjectDataText? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestContentObjectDataImage? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestContentObjectDataVideo? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestContentObjectDataAudio? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestMetaType? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestCampaign? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestClientAction? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestClientActionAction? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestClientActionBehavior? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieToxicity? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPoliciePersonalInformation? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieHate? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieIllicit? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieIllicitDrugs? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieIllicitAlcohol? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieIllicitFirearms? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieIllicitTobacco? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieIllicitGambling? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieCannabis? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieAdult? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieCrypto? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieSexual? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieSexualMinors? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieProfanity? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieViolence? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieSelfHarm? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieSpam? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieLowQualityContent? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieFaceDetection? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieFaceDetectionComparator? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieSelfPromotion? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPoliciePolitical? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieReligion? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieThreat? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieSexualSolicitation? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieChannelCircumvention? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieIllegalTrade? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieAlcohol? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieDrugs? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieGambling? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieTobacco? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieWeapons? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPoliciePromotion? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieExtremism? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieCodeAbuse? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieUnicodeSpoofing? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ModerationAPI.NewModerateModerateRequestPolicieUnicodeSpoofingSignals2>? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieUnicodeSpoofingSignals2? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPoliciePiiMasking? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ModerationAPI.NewModerateModerateRequestPoliciePiiMaskingEntities2>? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPoliciePiiMaskingEntities2? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieUrlMasking? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ModerationAPI.NewModerateModerateRequestPolicieUrlMaskingEntities2>? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieUrlMaskingEntities2? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieUrlRisk? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieGuideline? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ManagementProjectsCreateRequest? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ManagementProjectsUpdateRequest? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ManagementProjectsUpdateRequestGlobalFlaggingMode? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ManagementProjectsDuplicateRequest? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.CreateProjectApiKeyRequest? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ManagementChannelsCreateRequest? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ManagementChannelsCreateRequestContentType? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ManagementChannelsUpdateRequest? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ManagementChannelsUpdateRequestContentType? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ManagementChannelsUpdateRequestFlaggingMode? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ManagementChannelsUpdateRequestTranscriptionQuality? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ManagementChannelsDuplicateRequest? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.UpdateChannelPoliciesRequest? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.UpdateChannelPoliciesRequestPolicie>? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.UpdateChannelPoliciesRequestPolicie? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.UpdateChannelGuidelinesRequest? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.UpdateChannelGuidelinesRequestGuideline>? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.UpdateChannelGuidelinesRequestGuideline? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.UpdateChannelWordlistsRequest? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.UpdateChannelWordlistsRequestWordlist>? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.UpdateChannelWordlistsRequestWordlist? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.UpdateChannelWordlistsRequestWordlistType? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.GetAnalyticsSummaryRange? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.GetAnalyticsPoliciesRange? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.GetAnalyticsAuthorsRange? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.GetAnalyticsChannelsRange? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.GetAnalyticsVolumesRange? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.GetAnalyticsAutomationRange? Type267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.AuthorOpenListAuthorsSortBy? Type268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.AuthorOpenListAuthorsSortDirection? Type269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueViewOpenGetItemsSort? Type270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.UpgradeChannelPolicyPolicyId? Type271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.GetAnalyticsSummaryResponse? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.GetAnalyticsSummaryResponseRange? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.GetAnalyticsSummaryResponseTotals? Type274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.GetAnalyticsSummaryResponsePreviousPeriod? Type275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.GetAnalyticsSummaryResponseFlagRateSpike? Type276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.GetAnalyticsPoliciesResponse? Type277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.GetAnalyticsPoliciesResponseRange? Type278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.GetAnalyticsPoliciesResponsePolicie>? Type279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.GetAnalyticsPoliciesResponsePolicie? Type280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.GetAnalyticsAuthorsResponse? Type281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.GetAnalyticsAuthorsResponseRange? Type282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.GetAnalyticsAuthorsResponseAuthor>? Type283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.GetAnalyticsAuthorsResponseAuthor? Type284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.GetAnalyticsChannelsResponse? Type285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.GetAnalyticsChannelsResponseRange? Type286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.GetAnalyticsChannelsResponseChannel>? Type287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.GetAnalyticsChannelsResponseChannel? Type288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.GetAnalyticsVolumesResponse? Type289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.GetAnalyticsVolumesResponseRange? Type290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.GetAnalyticsVolumesResponseBucket? Type291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.GetAnalyticsVolumesResponseVolume>? Type292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.GetAnalyticsVolumesResponseVolume? Type293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.GetAnalyticsAutomationResponse? Type294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.GetAnalyticsAutomationResponseRange? Type295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.GetAnalyticsAutomationResponseRule>? Type296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.GetAnalyticsAutomationResponseRule? Type297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.AuthorOpenListAuthorsResponse? Type298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.PublicAuthor>? Type299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.AuthorDeleteResponse? Type300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.CreateFeedbackResponse? Type301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ListQueuesResponse? Type302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.Queue>? Type303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueViewOpenGetQueueResponse? Type304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueViewOpenGetStatsResponse? Type305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueViewOpenGetStatsResponseReviewStats? Type306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.QueueViewOpenGetStatsResponseTopReviewer>? Type307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueViewOpenGetStatsResponseTopReviewer? Type308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueViewOpenGetStatsResponseTrends? Type309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.QueueViewOpenGetStatsResponseTrendsDailyReviewCount>? Type310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueViewOpenGetStatsResponseTrendsDailyReviewCount? Type311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueViewOpenGetItemsResponse? Type312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.QueueItem>? Type313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueViewOpenResolveItemResponse? Type314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ResolveQueueItemsResponse? Type315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueViewOpenUnresolveItemResponse? Type316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueViewOpenUnresolveItemResponseStatus? Type317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsListResponse? Type318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.ActionsListResponseDataItem>? Type319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsListResponseDataItem? Type320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsListResponseDataItemType? Type321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsListResponseDataItemQueueBehaviour? Type322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsListResponseDataItemPosition? Type323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.ActionsListResponseDataItemPossibleValue>? Type324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsListResponseDataItemPossibleValue? Type325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsCreateResponse? Type326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsCreateResponseType? Type327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsCreateResponseQueueBehaviour? Type328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsCreateResponsePosition? Type329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.ActionsCreateResponsePossibleValue>? Type330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsCreateResponsePossibleValue? Type331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsGetResponse? Type332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsGetResponseType? Type333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsGetResponseQueueBehaviour? Type334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsGetResponsePosition? Type335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.ActionsGetResponsePossibleValue>? Type336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsGetResponsePossibleValue? Type337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsUpdateResponse? Type338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsUpdateResponseType? Type339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsUpdateResponseQueueBehaviour? Type340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsUpdateResponsePosition? Type341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.ActionsUpdateResponsePossibleValue>? Type342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsUpdateResponsePossibleValue? Type343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsDeleteResponse? Type344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsExecuteResponse? Type345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.RejectContentResponse? Type346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.AllowContentResponse? Type347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.BlockAuthorResponse? Type348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.SuspendAuthorResponse? Type349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.UnblockAuthorResponse? Type350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.WebhooksPublicListResponse? Type351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.WebhooksPublicListResponseDataItem>? Type352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.WebhooksPublicListResponseDataItem? Type353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.WebhooksPublicListResponseDataItemEventType>? Type354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.WebhooksPublicListResponseDataItemEventType? Type355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.WebhooksPublicListResponseDataItemPayloadVersion? Type356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.WebhooksPublicCreateResponse? Type357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.WebhooksPublicCreateResponseEventType>? Type358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.WebhooksPublicCreateResponseEventType? Type359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.WebhooksPublicCreateResponsePayloadVersion? Type360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.WebhooksPublicGetResponse? Type361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.WebhooksPublicGetResponseEventType>? Type362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.WebhooksPublicGetResponseEventType? Type363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.WebhooksPublicGetResponsePayloadVersion? Type364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.WebhooksPublicUpdateResponse? Type365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.WebhooksPublicUpdateResponseEventType>? Type366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.WebhooksPublicUpdateResponseEventType? Type367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.WebhooksPublicUpdateResponsePayloadVersion? Type368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.WebhooksPublicDeleteResponse? Type369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.WebhooksPublicGetSecretResponse? Type370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.AccountGetResponse? Type371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.AccountGetResponseCurrentProject? Type372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.WordlistListResponse? Type373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.WordlistListResponseDataItem>? Type374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.WordlistListResponseDataItem? Type375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.CreateWordlistResponse? Type376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.WordlistGetWordlistPublicResponse? Type377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.WordlistUpdateResponse? Type378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.DeleteWordlistResponse? Type379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.WordlistWordlistEmbeddingStatusResponse? Type380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.WordlistAddWordsResponse? Type381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.WordlistRemoveWordsResponse? Type382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponse? Type383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponseContent? Type384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentText? Type385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentImage? Type386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentVideo? Type387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentAudio? Type388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponseAuthor? Type389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponseAuthorBlock? Type390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponseAuthorStatus? Type391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponseAuthorTrustLevel? Type392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponseEvaluation? Type393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponseRecommendation? Type394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponseRecommendationAction? Type395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.AnyOf<global::ModerationAPI.NewModerateModerateResponseRecommendationReasonCode?, string>>? Type396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.AnyOf<global::ModerationAPI.NewModerateModerateResponseRecommendationReasonCode?, string>? Type397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponseRecommendationReasonCode? Type398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.NewModerateModerateResponseRecommendationMatchedRule>? Type399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponseRecommendationMatchedRule? Type400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponseCasebook? Type401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponseCasebookVerdict? Type402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponseCasebookTopic? Type403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponseCampaign? Type404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponseCampaignStatus? Type405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponseCampaignBrandStatus? Type406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.NewModerateModerateResponseCampaignSignal>? Type407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponseCampaignSignal? Type408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponseCampaignCluster? Type409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponseCampaignClusterStatus? Type410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.OneOf<global::ModerationAPI.NewModerateModerateResponsePolicieClassifierOutput, global::ModerationAPI.NewModerateModerateResponsePolicieEntityMatcherOutput>? Type411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponsePolicieClassifierOutput? Type412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.NewModerateModerateResponsePolicieClassifierOutputLabel>? Type413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponsePolicieClassifierOutputLabel? Type414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponsePolicieEntityMatcherOutput? Type415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.NewModerateModerateResponsePolicieEntityMatcherOutputMatche>? Type416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponsePolicieEntityMatcherOutputMatche? Type417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<int>? Type418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponsePolicieEntityMatcherOutputMatcheSignals? Type419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponsePolicieEntityMatcherOutputMatcheSignalsBrandImpersonation? Type420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponsePolicieEntityMatcherOutputMatcheSignalsBrandImpersonationMethod? Type421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponseInsightSentimentInsight? Type422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponseInsightSentimentInsightValue? Type423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponseInsightSentimentInsightScores? Type424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponseInsightLanguageInsight? Type425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponseInsightCuriosityInsight? Type426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponseInsightRespectInsight? Type427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponseInsightPersonalStoryInsight? Type428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponseInsightCompassionInsight? Type429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponseMeta? Type430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponseMetaStatus? Type431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.NewModerateModerateResponseError>? Type432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponseError? Type433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ManagementProjectsListResponse? Type434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.Project>? Type435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ManagementProjectsDeleteResponse? Type436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ManagementChannelsListResponse? Type437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.Channel>? Type438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ManagementChannelsDeleteResponse? Type439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.GetChannelPoliciesResponse? Type440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.ChannelPolicy>? Type441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.UpdateChannelPoliciesResponse? Type442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.UpgradeChannelPolicyResponse? Type443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.GetChannelGuidelinesResponse? Type444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.ChannelGuideline>? Type445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.UpdateChannelGuidelinesResponse? Type446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.GetChannelWordlistsResponse? Type447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.ChannelWordlist>? Type448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.UpdateChannelWordlistsResponse? Type449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.AuthorBlockedWebhookVersion? Type450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.AuthorUnblockedWebhookVersion? Type451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.AuthorSuspendedWebhookVersion? Type452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.AuthorUpdatedWebhookVersion? Type453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.AuthorTrustLevelChangedWebhookVersion? Type454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.AuthorActionWebhookVersion? Type455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueItemResolvedWebhookVersion? Type456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueItemActionWebhookVersion? Type457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueItemRejectedWebhookVersion? Type458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueItemAllowedWebhookVersion? Type459 { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ModerationAPI.QueueItemLabel>? ListType0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ModerationAPI.QueueItemLabelMatche>? ListType1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<double>? ListType2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<string>? ListType3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ModerationAPI.PublicQueueItemLabelsVariant1Item>? ListType4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ModerationAPI.PublicQueueItemLabelsVariant1ItemMatche>? ListType5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ModerationAPI.VoiceStartFrameTrack>? ListType6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<object>? ListType7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ModerationAPI.AnyOf<string, double?>>? ListType8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ModerationAPI.ErrorIssue>? ListType9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ModerationAPI.ActionsCreateRequestPossibleValue>? ListType10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ModerationAPI.ActionsUpdateRequestPossibleValue>? ListType11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ModerationAPI.WebhooksPublicCreateRequestEventType>? ListType12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ModerationAPI.WebhooksPublicUpdateRequestEventType>? ListType13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ModerationAPI.UpdateChannelPoliciesRequestPolicie>? ListType14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ModerationAPI.UpdateChannelGuidelinesRequestGuideline>? ListType15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ModerationAPI.UpdateChannelWordlistsRequestWordlist>? ListType16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ModerationAPI.GetAnalyticsPoliciesResponsePolicie>? ListType17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ModerationAPI.GetAnalyticsAuthorsResponseAuthor>? ListType18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ModerationAPI.GetAnalyticsChannelsResponseChannel>? ListType19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ModerationAPI.GetAnalyticsVolumesResponseVolume>? ListType20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ModerationAPI.GetAnalyticsAutomationResponseRule>? ListType21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ModerationAPI.PublicAuthor>? ListType22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ModerationAPI.Queue>? ListType23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ModerationAPI.QueueViewOpenGetStatsResponseTopReviewer>? ListType24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ModerationAPI.QueueViewOpenGetStatsResponseTrendsDailyReviewCount>? ListType25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ModerationAPI.QueueItem>? ListType26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ModerationAPI.ActionsListResponseDataItem>? ListType27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ModerationAPI.ActionsListResponseDataItemPossibleValue>? ListType28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ModerationAPI.ActionsCreateResponsePossibleValue>? ListType29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ModerationAPI.ActionsGetResponsePossibleValue>? ListType30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ModerationAPI.ActionsUpdateResponsePossibleValue>? ListType31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ModerationAPI.WebhooksPublicListResponseDataItem>? ListType32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ModerationAPI.WebhooksPublicListResponseDataItemEventType>? ListType33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ModerationAPI.WebhooksPublicCreateResponseEventType>? ListType34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ModerationAPI.WebhooksPublicGetResponseEventType>? ListType35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ModerationAPI.WebhooksPublicUpdateResponseEventType>? ListType36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ModerationAPI.WordlistListResponseDataItem>? ListType37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ModerationAPI.AnyOf<global::ModerationAPI.NewModerateModerateResponseRecommendationReasonCode?, string>>? ListType38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ModerationAPI.NewModerateModerateResponseRecommendationMatchedRule>? ListType39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ModerationAPI.NewModerateModerateResponseCampaignSignal>? ListType40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ModerationAPI.OneOf<global::ModerationAPI.NewModerateModerateResponsePolicieClassifierOutput, global::ModerationAPI.NewModerateModerateResponsePolicieEntityMatcherOutput>>? ListType41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ModerationAPI.NewModerateModerateResponsePolicieClassifierOutputLabel>? ListType42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ModerationAPI.NewModerateModerateResponsePolicieEntityMatcherOutputMatche>? ListType43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<int>? ListType44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ModerationAPI.NewModerateModerateResponseError>? ListType45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ModerationAPI.Project>? ListType46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ModerationAPI.Channel>? ListType47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ModerationAPI.ChannelPolicy>? ListType48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ModerationAPI.ChannelGuideline>? ListType49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ModerationAPI.ChannelWordlist>? ListType50 { get; set; }
    }
}