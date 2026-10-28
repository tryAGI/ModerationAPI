
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
        public global::ModerationAPI.AuthorBlockedEvent? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTime? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.AuthorBlockedEventData? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.PublicActionPerformedAuthor? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.PublicActionPerformedAuthorQueue? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.AuthorUnblockedEvent? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.AuthorUnblockedEventData? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.AuthorSuspendedEvent? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.AuthorSuspendedEventData? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.AuthorUpdatedEvent? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.AuthorUpdatedEventData? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.AuthorTrustLevelChangedEvent? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.AuthorTrustLevelChangedEventData? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.AuthorActionEvent? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.AuthorActionEventData? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueItemCompletedEvent? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueItemCompletedEventData? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.PublicQueueItemEvent? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.PublicQueueItem? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.PublicQueueItemEventQueue? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.PublicQueueItemLabelsVariant1Item>? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.PublicQueueItemLabelsVariant1Item? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.PublicQueueItemLabelsVariant1ItemMatche>? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.PublicQueueItemLabelsVariant1ItemMatche? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.PublicQueueItemLabelsVariant1ItemMatcheSignals? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.PublicQueueItemLabelsVariant1ItemMatcheSignalsBrandImpersonation? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.PublicQueueItemContentText? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.PublicQueueItemContentImage? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.PublicQueueItemContentVideo? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.PublicQueueItemContentAudio? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.PublicQueueItemContentObject? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.PublicQueueItemContentObjectDataText? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.PublicQueueItemContentObjectDataImage? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.PublicQueueItemContentObjectDataVideo? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.PublicQueueItemContentObjectDataAudio? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.PublicQueueItemClientAction? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.PublicQueueItemClientActionAction? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.PublicQueueItemClientActionBehavior? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.PublicQueueItemMetaType? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueItemActionEvent? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueItemActionEventData? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.PublicActionPerformed? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.PublicActionPerformedQueue? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueItemRejectedEvent? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueItemRejectedEventData? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueItemAllowedEvent? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueItemAllowedEventData? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.WebhookEvent? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.WebhookEventDiscriminator? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.WebhookEventDiscriminatorType? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.VoiceStartFrame? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.VoiceStartFrameEvent? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.VoiceStartFrameMediaFormat? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.VoiceStartFrameTrack>? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.VoiceStartFrameTrack? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.VoiceStartFrameTrackName? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.VoiceMediaFrame? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.VoiceMediaFrameEvent? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.VoiceMediaFrameMedia? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.VoiceMediaFrameMediaTrack? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.VoiceStopFrame? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.VoiceStopFrameEvent? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.VoiceSessionStarted? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.VoiceSessionStartedEvent? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.VoiceUtteranceFinal? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.VoiceUtteranceFinalEvent? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.VoiceUtteranceFinalTrack? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.VoiceUtteranceFinalRecommendation? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.VoiceUtteranceFinalRecommendationAction? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<object>? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.VoiceSessionEnded? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.VoiceSessionEndedEvent? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.VoiceSessionEndedStats? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.VoiceSessionEndedStatsActions? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.Pagination? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ErrorIssue? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.AnyOf<string, double?>>? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.AnyOf<string, double?>? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.BadRequestError? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.BadRequestErrorCode? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.ErrorIssue>? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.AuthenticationError? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.AuthenticationErrorCode? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.PermissionDeniedError? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.PermissionDeniedErrorCode? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NotFoundError? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NotFoundErrorCode? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ConflictError? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ConflictErrorCode? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.UnprocessableEntityError? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.UnprocessableEntityErrorCode? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.RateLimitError? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.RateLimitErrorCode? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.InternalServerError? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.InternalServerErrorCode? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.AuthorOpenCreateRequest? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.AuthorOpenCreateRequestMetadata? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.AuthorOpenUpdateRequest? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.AuthorOpenUpdateRequestMetadata? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.CreateFeedbackRequest? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.CreateFeedbackRequestType? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.CreateFeedbackRequestSource? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ResolveQueueItemsRequest? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsCreateRequest? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsCreateRequestType? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsCreateRequestQueueBehaviour? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsCreateRequestPosition? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.ActionsCreateRequestPossibleValue>? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsCreateRequestPossibleValue? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsUpdateRequest? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsUpdateRequestType? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsUpdateRequestQueueBehaviour? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsUpdateRequestPosition? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.ActionsUpdateRequestPossibleValue>? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsUpdateRequestPossibleValue? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsExecuteRequest? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.RejectContentRequest? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.AllowContentRequest? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.BlockAuthorRequest? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.SuspendAuthorRequest? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.UnblockAuthorRequest? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.WebhooksPublicCreateRequest? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.WebhooksPublicCreateRequestEventType>? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.WebhooksPublicCreateRequestEventType? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.WebhooksPublicUpdateRequest? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.WebhooksPublicUpdateRequestEventType>? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.WebhooksPublicUpdateRequestEventType? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.CreateWordlistRequest? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.WordlistUpdateRequest? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.WordlistAddWordsRequest? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequest? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestContentText? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestContentImage? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestContentVideo? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestContentAudio? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestContentObject? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestContentObjectDataText? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestContentObjectDataImage? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestContentObjectDataVideo? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestContentObjectDataAudio? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestMetaType? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestClientAction? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestClientActionAction? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestClientActionBehavior? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieToxicity? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPoliciePersonalInformation? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieHate? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieIllicit? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieIllicitDrugs? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieIllicitAlcohol? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieIllicitFirearms? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieIllicitTobacco? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieIllicitGambling? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieCannabis? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieAdult? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieCrypto? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieSexual? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieSexualMinors? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieProfanity? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieViolence? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieSelfHarm? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieSpam? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieLowQualityContent? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieFaceDetection? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieFaceDetectionComparator? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieSelfPromotion? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPoliciePolitical? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieReligion? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieThreat? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieSexualSolicitation? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieChannelCircumvention? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieIllegalTrade? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieAlcohol? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieDrugs? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieGambling? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieTobacco? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieWeapons? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPoliciePromotion? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieExtremism? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieCodeAbuse? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieUnicodeSpoofing? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ModerationAPI.NewModerateModerateRequestPolicieUnicodeSpoofingSignals2>? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieUnicodeSpoofingSignals2? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPoliciePiiMasking? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ModerationAPI.NewModerateModerateRequestPoliciePiiMaskingEntities2>? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPoliciePiiMaskingEntities2? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieUrlMasking? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ModerationAPI.NewModerateModerateRequestPolicieUrlMaskingEntities2>? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieUrlMaskingEntities2? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieUrlRisk? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieGuideline? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ManagementProjectsCreateRequest? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ManagementProjectsUpdateRequest? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ManagementProjectsUpdateRequestGlobalFlaggingMode? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ManagementProjectsDuplicateRequest? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.CreateProjectApiKeyRequest? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ManagementChannelsCreateRequest? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ManagementChannelsCreateRequestContentType? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ManagementChannelsUpdateRequest? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ManagementChannelsUpdateRequestContentType? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ManagementChannelsUpdateRequestFlaggingMode? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ManagementChannelsUpdateRequestTranscriptionQuality? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ManagementChannelsDuplicateRequest? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.GetAnalyticsSummaryRange? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.GetAnalyticsPoliciesRange? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.GetAnalyticsAuthorsRange? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.GetAnalyticsChannelsRange? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.GetAnalyticsVolumesRange? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.GetAnalyticsAutomationRange? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.AuthorOpenListAuthorsSortBy? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.AuthorOpenListAuthorsSortDirection? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueViewOpenGetItemsSort? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.GetAnalyticsSummaryResponse? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.GetAnalyticsSummaryResponseRange? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.GetAnalyticsSummaryResponseTotals? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.GetAnalyticsSummaryResponsePreviousPeriod? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.GetAnalyticsSummaryResponseFlagRateSpike? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.GetAnalyticsPoliciesResponse? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.GetAnalyticsPoliciesResponseRange? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.GetAnalyticsPoliciesResponsePolicie>? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.GetAnalyticsPoliciesResponsePolicie? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.GetAnalyticsAuthorsResponse? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.GetAnalyticsAuthorsResponseRange? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.GetAnalyticsAuthorsResponseAuthor>? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.GetAnalyticsAuthorsResponseAuthor? Type267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.GetAnalyticsChannelsResponse? Type268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.GetAnalyticsChannelsResponseRange? Type269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.GetAnalyticsChannelsResponseChannel>? Type270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.GetAnalyticsChannelsResponseChannel? Type271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.GetAnalyticsVolumesResponse? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.GetAnalyticsVolumesResponseRange? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.GetAnalyticsVolumesResponseBucket? Type274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.GetAnalyticsVolumesResponseVolume>? Type275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.GetAnalyticsVolumesResponseVolume? Type276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.GetAnalyticsAutomationResponse? Type277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.GetAnalyticsAutomationResponseRange? Type278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.GetAnalyticsAutomationResponseRule>? Type279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.GetAnalyticsAutomationResponseRule? Type280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.AuthorOpenListAuthorsResponse? Type281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.PublicAuthor>? Type282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.AuthorDeleteResponse? Type283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.CreateFeedbackResponse? Type284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ListQueuesResponse? Type285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.Queue>? Type286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueViewOpenGetQueueResponse? Type287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueViewOpenGetStatsResponse? Type288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueViewOpenGetStatsResponseReviewStats? Type289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.QueueViewOpenGetStatsResponseTopReviewer>? Type290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueViewOpenGetStatsResponseTopReviewer? Type291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueViewOpenGetStatsResponseTrends? Type292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.QueueViewOpenGetStatsResponseTrendsDailyReviewCount>? Type293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueViewOpenGetStatsResponseTrendsDailyReviewCount? Type294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueViewOpenGetItemsResponse? Type295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.QueueItem>? Type296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueViewOpenResolveItemResponse? Type297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ResolveQueueItemsResponse? Type298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueViewOpenUnresolveItemResponse? Type299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueViewOpenUnresolveItemResponseStatus? Type300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsListResponse? Type301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.ActionsListResponseDataItem>? Type302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsListResponseDataItem? Type303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsListResponseDataItemType? Type304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsListResponseDataItemQueueBehaviour? Type305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsListResponseDataItemPosition? Type306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.ActionsListResponseDataItemPossibleValue>? Type307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsListResponseDataItemPossibleValue? Type308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsCreateResponse? Type309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsCreateResponseType? Type310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsCreateResponseQueueBehaviour? Type311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsCreateResponsePosition? Type312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.ActionsCreateResponsePossibleValue>? Type313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsCreateResponsePossibleValue? Type314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsGetResponse? Type315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsGetResponseType? Type316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsGetResponseQueueBehaviour? Type317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsGetResponsePosition? Type318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.ActionsGetResponsePossibleValue>? Type319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsGetResponsePossibleValue? Type320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsUpdateResponse? Type321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsUpdateResponseType? Type322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsUpdateResponseQueueBehaviour? Type323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsUpdateResponsePosition? Type324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.ActionsUpdateResponsePossibleValue>? Type325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsUpdateResponsePossibleValue? Type326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsDeleteResponse? Type327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsExecuteResponse? Type328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.RejectContentResponse? Type329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.AllowContentResponse? Type330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.BlockAuthorResponse? Type331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.SuspendAuthorResponse? Type332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.UnblockAuthorResponse? Type333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.WebhooksPublicListResponse? Type334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.WebhooksPublicListResponseDataItem>? Type335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.WebhooksPublicListResponseDataItem? Type336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.WebhooksPublicListResponseDataItemEventType>? Type337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.WebhooksPublicListResponseDataItemEventType? Type338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.WebhooksPublicListResponseDataItemPayloadVersion? Type339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.WebhooksPublicCreateResponse? Type340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.WebhooksPublicCreateResponseEventType>? Type341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.WebhooksPublicCreateResponseEventType? Type342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.WebhooksPublicCreateResponsePayloadVersion? Type343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.WebhooksPublicGetResponse? Type344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.WebhooksPublicGetResponseEventType>? Type345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.WebhooksPublicGetResponseEventType? Type346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.WebhooksPublicGetResponsePayloadVersion? Type347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.WebhooksPublicUpdateResponse? Type348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.WebhooksPublicUpdateResponseEventType>? Type349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.WebhooksPublicUpdateResponseEventType? Type350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.WebhooksPublicUpdateResponsePayloadVersion? Type351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.WebhooksPublicDeleteResponse? Type352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.WebhooksPublicGetSecretResponse? Type353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.AccountGetResponse? Type354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.AccountGetResponseCurrentProject? Type355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.WordlistListResponse? Type356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.WordlistListResponseDataItem>? Type357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.WordlistListResponseDataItem? Type358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.CreateWordlistResponse? Type359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.WordlistGetWordlistPublicResponse? Type360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.WordlistUpdateResponse? Type361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.WordlistWordlistEmbeddingStatusResponse? Type362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.WordlistAddWordsResponse? Type363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.WordlistRemoveWordsResponse? Type364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponse? Type365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponseContent? Type366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentText? Type367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentImage? Type368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentVideo? Type369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentAudio? Type370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponseAuthor? Type371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponseAuthorBlock? Type372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponseAuthorStatus? Type373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponseAuthorTrustLevel? Type374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponseEvaluation? Type375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponseRecommendation? Type376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponseRecommendationAction? Type377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.AnyOf<global::ModerationAPI.NewModerateModerateResponseRecommendationReasonCode?, string>>? Type378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.AnyOf<global::ModerationAPI.NewModerateModerateResponseRecommendationReasonCode?, string>? Type379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponseRecommendationReasonCode? Type380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.NewModerateModerateResponseRecommendationMatchedRule>? Type381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponseRecommendationMatchedRule? Type382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponseCasebook? Type383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponseCasebookVerdict? Type384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponseCasebookTopic? Type385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.OneOf<global::ModerationAPI.NewModerateModerateResponsePolicieClassifierOutput, global::ModerationAPI.NewModerateModerateResponsePolicieEntityMatcherOutput>? Type386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponsePolicieClassifierOutput? Type387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.NewModerateModerateResponsePolicieClassifierOutputLabel>? Type388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponsePolicieClassifierOutputLabel? Type389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponsePolicieEntityMatcherOutput? Type390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.NewModerateModerateResponsePolicieEntityMatcherOutputMatche>? Type391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponsePolicieEntityMatcherOutputMatche? Type392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<int>? Type393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponsePolicieEntityMatcherOutputMatcheSignals? Type394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponsePolicieEntityMatcherOutputMatcheSignalsBrandImpersonation? Type395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponsePolicieEntityMatcherOutputMatcheSignalsBrandImpersonationMethod? Type396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponseInsightSentimentInsight? Type397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponseInsightSentimentInsightValue? Type398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponseInsightSentimentInsightScores? Type399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponseInsightLanguageInsight? Type400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponseInsightCuriosityInsight? Type401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponseInsightRespectInsight? Type402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponseInsightPersonalStoryInsight? Type403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponseInsightCompassionInsight? Type404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponseMeta? Type405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponseMetaStatus? Type406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.NewModerateModerateResponseError>? Type407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponseError? Type408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ManagementProjectsListResponse? Type409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.Project>? Type410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ManagementProjectsDeleteResponse? Type411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ManagementChannelsListResponse? Type412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.Channel>? Type413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ManagementChannelsDeleteResponse? Type414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.AuthorBlockedWebhookVersion? Type415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.AuthorUnblockedWebhookVersion? Type416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.AuthorSuspendedWebhookVersion? Type417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.AuthorUpdatedWebhookVersion? Type418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.AuthorTrustLevelChangedWebhookVersion? Type419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.AuthorActionWebhookVersion? Type420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueItemResolvedWebhookVersion? Type421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueItemActionWebhookVersion? Type422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueItemRejectedWebhookVersion? Type423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueItemAllowedWebhookVersion? Type424 { get; set; }

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
        public global::System.Collections.Generic.List<global::ModerationAPI.GetAnalyticsPoliciesResponsePolicie>? ListType14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ModerationAPI.GetAnalyticsAuthorsResponseAuthor>? ListType15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ModerationAPI.GetAnalyticsChannelsResponseChannel>? ListType16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ModerationAPI.GetAnalyticsVolumesResponseVolume>? ListType17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ModerationAPI.GetAnalyticsAutomationResponseRule>? ListType18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ModerationAPI.PublicAuthor>? ListType19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ModerationAPI.Queue>? ListType20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ModerationAPI.QueueViewOpenGetStatsResponseTopReviewer>? ListType21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ModerationAPI.QueueViewOpenGetStatsResponseTrendsDailyReviewCount>? ListType22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ModerationAPI.QueueItem>? ListType23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ModerationAPI.ActionsListResponseDataItem>? ListType24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ModerationAPI.ActionsListResponseDataItemPossibleValue>? ListType25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ModerationAPI.ActionsCreateResponsePossibleValue>? ListType26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ModerationAPI.ActionsGetResponsePossibleValue>? ListType27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ModerationAPI.ActionsUpdateResponsePossibleValue>? ListType28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ModerationAPI.WebhooksPublicListResponseDataItem>? ListType29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ModerationAPI.WebhooksPublicListResponseDataItemEventType>? ListType30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ModerationAPI.WebhooksPublicCreateResponseEventType>? ListType31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ModerationAPI.WebhooksPublicGetResponseEventType>? ListType32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ModerationAPI.WebhooksPublicUpdateResponseEventType>? ListType33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ModerationAPI.WordlistListResponseDataItem>? ListType34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ModerationAPI.AnyOf<global::ModerationAPI.NewModerateModerateResponseRecommendationReasonCode?, string>>? ListType35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ModerationAPI.NewModerateModerateResponseRecommendationMatchedRule>? ListType36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ModerationAPI.OneOf<global::ModerationAPI.NewModerateModerateResponsePolicieClassifierOutput, global::ModerationAPI.NewModerateModerateResponsePolicieEntityMatcherOutput>>? ListType37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ModerationAPI.NewModerateModerateResponsePolicieClassifierOutputLabel>? ListType38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ModerationAPI.NewModerateModerateResponsePolicieEntityMatcherOutputMatche>? ListType39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<int>? ListType40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ModerationAPI.NewModerateModerateResponseError>? ListType41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ModerationAPI.Project>? ListType42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ModerationAPI.Channel>? ListType43 { get; set; }
    }
}