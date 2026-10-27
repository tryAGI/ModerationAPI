
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
        public global::ModerationAPI.WebhooksPublicCreateRequest? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.WebhooksPublicCreateRequestEventType>? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.WebhooksPublicCreateRequestEventType? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.WebhooksPublicUpdateRequest? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.WebhooksPublicUpdateRequestEventType>? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.WebhooksPublicUpdateRequestEventType? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.CreateWordlistRequest? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.WordlistUpdateRequest? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.WordlistAddWordsRequest? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequest? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestContentText? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestContentImage? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestContentVideo? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestContentAudio? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestContentObject? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestContentObjectDataText? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestContentObjectDataImage? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestContentObjectDataVideo? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestContentObjectDataAudio? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestMetaType? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestClientAction? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestClientActionAction? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestClientActionBehavior? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieToxicity? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPoliciePersonalInformation? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieHate? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieIllicit? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieIllicitDrugs? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieIllicitAlcohol? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieIllicitFirearms? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieIllicitTobacco? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieIllicitGambling? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieCannabis? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieAdult? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieCrypto? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieSexual? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieSexualMinors? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieProfanity? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieViolence? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieSelfHarm? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieSpam? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieLowQualityContent? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieFaceDetection? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieFaceDetectionComparator? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieSelfPromotion? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPoliciePolitical? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieReligion? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieThreat? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieSexualSolicitation? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieChannelCircumvention? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieIllegalTrade? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieAlcohol? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieDrugs? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieGambling? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieTobacco? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieWeapons? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPoliciePromotion? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieExtremism? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieCodeAbuse? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieUnicodeSpoofing? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ModerationAPI.NewModerateModerateRequestPolicieUnicodeSpoofingSignals2>? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieUnicodeSpoofingSignals2? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPoliciePiiMasking? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ModerationAPI.NewModerateModerateRequestPoliciePiiMaskingEntities2>? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPoliciePiiMaskingEntities2? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieUrlMasking? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ModerationAPI.NewModerateModerateRequestPolicieUrlMaskingEntities2>? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieUrlMaskingEntities2? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieUrlRisk? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieGuideline? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ManagementProjectsCreateRequest? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ManagementProjectsUpdateRequest? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ManagementProjectsUpdateRequestGlobalFlaggingMode? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ManagementProjectsDuplicateRequest? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.CreateProjectApiKeyRequest? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ManagementChannelsCreateRequest? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ManagementChannelsCreateRequestContentType? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ManagementChannelsUpdateRequest? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ManagementChannelsUpdateRequestContentType? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ManagementChannelsUpdateRequestFlaggingMode? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ManagementChannelsUpdateRequestTranscriptionQuality? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ManagementChannelsDuplicateRequest? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.GetAnalyticsSummaryRange? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.GetAnalyticsPoliciesRange? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.GetAnalyticsAuthorsRange? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.GetAnalyticsChannelsRange? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.GetAnalyticsVolumesRange? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.GetAnalyticsAutomationRange? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.AuthorOpenListAuthorsSortBy? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.AuthorOpenListAuthorsSortDirection? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueViewOpenGetItemsSort? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.GetAnalyticsSummaryResponse? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.GetAnalyticsSummaryResponseRange? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.GetAnalyticsSummaryResponseTotals? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.GetAnalyticsSummaryResponsePreviousPeriod? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.GetAnalyticsSummaryResponseFlagRateSpike? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.GetAnalyticsPoliciesResponse? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.GetAnalyticsPoliciesResponseRange? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.GetAnalyticsPoliciesResponsePolicie>? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.GetAnalyticsPoliciesResponsePolicie? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.GetAnalyticsAuthorsResponse? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.GetAnalyticsAuthorsResponseRange? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.GetAnalyticsAuthorsResponseAuthor>? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.GetAnalyticsAuthorsResponseAuthor? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.GetAnalyticsChannelsResponse? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.GetAnalyticsChannelsResponseRange? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.GetAnalyticsChannelsResponseChannel>? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.GetAnalyticsChannelsResponseChannel? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.GetAnalyticsVolumesResponse? Type267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.GetAnalyticsVolumesResponseRange? Type268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.GetAnalyticsVolumesResponseBucket? Type269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.GetAnalyticsVolumesResponseVolume>? Type270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.GetAnalyticsVolumesResponseVolume? Type271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.GetAnalyticsAutomationResponse? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.GetAnalyticsAutomationResponseRange? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.GetAnalyticsAutomationResponseRule>? Type274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.GetAnalyticsAutomationResponseRule? Type275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.AuthorOpenListAuthorsResponse? Type276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.PublicAuthor>? Type277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.AuthorDeleteResponse? Type278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.CreateFeedbackResponse? Type279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ListQueuesResponse? Type280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.Queue>? Type281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueViewOpenGetQueueResponse? Type282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueViewOpenGetStatsResponse? Type283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueViewOpenGetStatsResponseReviewStats? Type284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.QueueViewOpenGetStatsResponseTopReviewer>? Type285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueViewOpenGetStatsResponseTopReviewer? Type286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueViewOpenGetStatsResponseTrends? Type287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.QueueViewOpenGetStatsResponseTrendsDailyReviewCount>? Type288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueViewOpenGetStatsResponseTrendsDailyReviewCount? Type289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueViewOpenGetItemsResponse? Type290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.QueueItem>? Type291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueViewOpenResolveItemResponse? Type292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ResolveQueueItemsResponse? Type293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueViewOpenUnresolveItemResponse? Type294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueViewOpenUnresolveItemResponseStatus? Type295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsListResponse? Type296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.ActionsListResponseDataItem>? Type297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsListResponseDataItem? Type298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsListResponseDataItemType? Type299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsListResponseDataItemQueueBehaviour? Type300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsListResponseDataItemPosition? Type301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.ActionsListResponseDataItemPossibleValue>? Type302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsListResponseDataItemPossibleValue? Type303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsCreateResponse? Type304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsCreateResponseType? Type305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsCreateResponseQueueBehaviour? Type306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsCreateResponsePosition? Type307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.ActionsCreateResponsePossibleValue>? Type308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsCreateResponsePossibleValue? Type309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsGetResponse? Type310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsGetResponseType? Type311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsGetResponseQueueBehaviour? Type312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsGetResponsePosition? Type313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.ActionsGetResponsePossibleValue>? Type314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsGetResponsePossibleValue? Type315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsUpdateResponse? Type316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsUpdateResponseType? Type317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsUpdateResponseQueueBehaviour? Type318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsUpdateResponsePosition? Type319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.ActionsUpdateResponsePossibleValue>? Type320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsUpdateResponsePossibleValue? Type321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsDeleteResponse? Type322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsExecuteResponse? Type323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.WebhooksPublicListResponse? Type324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.WebhooksPublicListResponseDataItem>? Type325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.WebhooksPublicListResponseDataItem? Type326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.WebhooksPublicListResponseDataItemEventType>? Type327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.WebhooksPublicListResponseDataItemEventType? Type328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.WebhooksPublicListResponseDataItemPayloadVersion? Type329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.WebhooksPublicCreateResponse? Type330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.WebhooksPublicCreateResponseEventType>? Type331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.WebhooksPublicCreateResponseEventType? Type332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.WebhooksPublicCreateResponsePayloadVersion? Type333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.WebhooksPublicGetResponse? Type334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.WebhooksPublicGetResponseEventType>? Type335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.WebhooksPublicGetResponseEventType? Type336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.WebhooksPublicGetResponsePayloadVersion? Type337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.WebhooksPublicUpdateResponse? Type338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.WebhooksPublicUpdateResponseEventType>? Type339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.WebhooksPublicUpdateResponseEventType? Type340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.WebhooksPublicUpdateResponsePayloadVersion? Type341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.WebhooksPublicDeleteResponse? Type342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.WebhooksPublicGetSecretResponse? Type343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.AccountGetResponse? Type344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.AccountGetResponseCurrentProject? Type345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.WordlistListResponse? Type346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.WordlistListResponseDataItem>? Type347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.WordlistListResponseDataItem? Type348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.CreateWordlistResponse? Type349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.WordlistGetWordlistPublicResponse? Type350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.WordlistUpdateResponse? Type351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.WordlistWordlistEmbeddingStatusResponse? Type352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.WordlistAddWordsResponse? Type353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.WordlistRemoveWordsResponse? Type354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponse? Type355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponseContent? Type356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentText? Type357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentImage? Type358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentVideo? Type359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentAudio? Type360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponseAuthor? Type361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponseAuthorBlock? Type362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponseAuthorStatus? Type363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponseAuthorTrustLevel? Type364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponseEvaluation? Type365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponseRecommendation? Type366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponseRecommendationAction? Type367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.AnyOf<global::ModerationAPI.NewModerateModerateResponseRecommendationReasonCode?, string>>? Type368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.AnyOf<global::ModerationAPI.NewModerateModerateResponseRecommendationReasonCode?, string>? Type369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponseRecommendationReasonCode? Type370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.NewModerateModerateResponseRecommendationMatchedRule>? Type371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponseRecommendationMatchedRule? Type372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponseCasebook? Type373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponseCasebookVerdict? Type374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponseCasebookTopic? Type375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.OneOf<global::ModerationAPI.NewModerateModerateResponsePolicieClassifierOutput, global::ModerationAPI.NewModerateModerateResponsePolicieEntityMatcherOutput>? Type376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponsePolicieClassifierOutput? Type377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.NewModerateModerateResponsePolicieClassifierOutputLabel>? Type378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponsePolicieClassifierOutputLabel? Type379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponsePolicieEntityMatcherOutput? Type380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.NewModerateModerateResponsePolicieEntityMatcherOutputMatche>? Type381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponsePolicieEntityMatcherOutputMatche? Type382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<int>? Type383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponsePolicieEntityMatcherOutputMatcheSignals? Type384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponsePolicieEntityMatcherOutputMatcheSignalsBrandImpersonation? Type385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponsePolicieEntityMatcherOutputMatcheSignalsBrandImpersonationMethod? Type386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponseInsightSentimentInsight? Type387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponseInsightSentimentInsightValue? Type388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponseInsightSentimentInsightScores? Type389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponseInsightLanguageInsight? Type390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponseInsightCuriosityInsight? Type391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponseInsightRespectInsight? Type392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponseInsightPersonalStoryInsight? Type393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponseInsightCompassionInsight? Type394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponseMeta? Type395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponseMetaStatus? Type396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.NewModerateModerateResponseError>? Type397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponseError? Type398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ManagementProjectsListResponse? Type399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.Project>? Type400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ManagementProjectsDeleteResponse? Type401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ManagementChannelsListResponse? Type402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.Channel>? Type403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ManagementChannelsDeleteResponse? Type404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.AuthorBlockedWebhookVersion? Type405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.AuthorUnblockedWebhookVersion? Type406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.AuthorSuspendedWebhookVersion? Type407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.AuthorUpdatedWebhookVersion? Type408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.AuthorTrustLevelChangedWebhookVersion? Type409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.AuthorActionWebhookVersion? Type410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueItemResolvedWebhookVersion? Type411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueItemActionWebhookVersion? Type412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueItemRejectedWebhookVersion? Type413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueItemAllowedWebhookVersion? Type414 { get; set; }

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