
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
        public global::ModerationAPI.ErrorBadRequest? Type11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.ErrorBadRequestIssue>? Type12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ErrorBadRequestIssue? Type13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ErrorUnauthorized? Type14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.ErrorUnauthorizedIssue>? Type15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ErrorUnauthorizedIssue? Type16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ErrorForbidden? Type17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.ErrorForbiddenIssue>? Type18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ErrorForbiddenIssue? Type19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ErrorNotFound? Type20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.ErrorNotFoundIssue>? Type21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ErrorNotFoundIssue? Type22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ErrorInternalServerError? Type23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.ErrorInternalServerErrorIssue>? Type24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ErrorInternalServerErrorIssue? Type25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ErrorConflict? Type26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.ErrorConflictIssue>? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ErrorConflictIssue? Type28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.Project? Type29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ProjectGlobalFlaggingMode? Type30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ProjectWithKey? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ProjectWithKeyGlobalFlaggingMode? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.Channel? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ChannelContentType? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ChannelFlaggingMode? Type35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ChannelTranscriptionQuality? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.AuthorBlockedEvent? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTime? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.AuthorBlockedEventData? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.PublicActionPerformedAuthor? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.PublicActionPerformedAuthorQueue? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.AuthorUnblockedEvent? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.AuthorUnblockedEventData? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.AuthorSuspendedEvent? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.AuthorSuspendedEventData? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.AuthorUpdatedEvent? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.AuthorUpdatedEventData? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.AuthorTrustLevelChangedEvent? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.AuthorTrustLevelChangedEventData? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.AuthorActionEvent? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.AuthorActionEventData? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueItemCompletedEvent? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueItemCompletedEventData? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.PublicQueueItemEvent? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.PublicQueueItem? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.PublicQueueItemEventQueue? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.PublicQueueItemLabelsVariant1Item>? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.PublicQueueItemLabelsVariant1Item? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.PublicQueueItemLabelsVariant1ItemMatche>? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.PublicQueueItemLabelsVariant1ItemMatche? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<double>? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.PublicQueueItemLabelsVariant1ItemMatcheSignals? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.PublicQueueItemLabelsVariant1ItemMatcheSignalsBrandImpersonation? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.PublicQueueItemContentText? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.PublicQueueItemContentImage? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.PublicQueueItemContentVideo? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.PublicQueueItemContentAudio? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.PublicQueueItemContentObject? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.PublicQueueItemContentObjectDataText? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.PublicQueueItemContentObjectDataImage? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.PublicQueueItemContentObjectDataVideo? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.PublicQueueItemContentObjectDataAudio? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.PublicQueueItemClientAction? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.PublicQueueItemClientActionAction? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.PublicQueueItemClientActionBehavior? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.PublicQueueItemMetaType? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueItemActionEvent? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueItemActionEventData? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.PublicActionPerformed? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.PublicActionPerformedQueue? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueItemRejectedEvent? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueItemRejectedEventData? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueItemAllowedEvent? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueItemAllowedEventData? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.WebhookEvent? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.WebhookEventDiscriminator? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.WebhookEventDiscriminatorType? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.VoiceStartFrame? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.VoiceStartFrameEvent? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.VoiceStartFrameMediaFormat? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.VoiceStartFrameTrack>? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.VoiceStartFrameTrack? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.VoiceStartFrameTrackName? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.VoiceMediaFrame? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.VoiceMediaFrameEvent? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.VoiceMediaFrameMedia? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.VoiceMediaFrameMediaTrack? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.VoiceStopFrame? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.VoiceStopFrameEvent? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.VoiceSessionStarted? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.VoiceSessionStartedEvent? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.VoiceUtteranceFinal? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.VoiceUtteranceFinalEvent? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.VoiceUtteranceFinalTrack? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.VoiceUtteranceFinalRecommendation? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.VoiceUtteranceFinalRecommendationAction? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<object>? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.VoiceSessionEnded? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.VoiceSessionEndedEvent? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.VoiceSessionEndedStats? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.VoiceSessionEndedStatsActions? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.AuthorOpenCreateRequest? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.AuthorOpenCreateRequestMetadata? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.AuthorOpenUpdateRequest? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.AuthorOpenUpdateRequestMetadata? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueViewOpenResolveItemRequest? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueViewOpenUnresolveItemRequest? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsCreateRequest? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsCreateRequestType? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsCreateRequestQueueBehaviour? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsCreateRequestPosition? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.ActionsCreateRequestPossibleValue>? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsCreateRequestPossibleValue? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsUpdateRequest? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsUpdateRequestType? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsUpdateRequestQueueBehaviour? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsUpdateRequestPosition? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.ActionsUpdateRequestPossibleValue>? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsUpdateRequestPossibleValue? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsExecuteRequest? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsExecuteDeprecatedRequest? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.WebhooksPublicCreateRequest? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.WebhooksPublicCreateRequestEventType>? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.WebhooksPublicCreateRequestEventType? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.WebhooksPublicUpdateRequest? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.WebhooksPublicUpdateRequestEventType>? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.WebhooksPublicUpdateRequestEventType? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ModerationTextRequest? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ModerationImageRequest? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.WordlistUpdateRequest? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.WordlistAddWordsRequest? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequest? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestContentText? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestContentImage? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestContentVideo? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestContentAudio? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestContentObject? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestContentObjectDataText? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestContentObjectDataImage? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestContentObjectDataVideo? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestContentObjectDataAudio? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestMetaType? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestClientAction? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestClientActionAction? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestClientActionBehavior? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieToxicity? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPoliciePersonalInformation? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieToxicitySevere? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieHate? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieIllicit? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieIllicitDrugs? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieIllicitAlcohol? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieIllicitFirearms? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieIllicitTobacco? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieIllicitGambling? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieCannabis? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieAdult? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieCrypto? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieSexual? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieSexualMinors? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieFlirtation? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieProfanity? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieViolence? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieSelfHarm? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieSpam? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieLowQualityContent? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieFaceDetection? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieFaceDetectionComparator? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieSelfPromotion? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPoliciePolitical? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieReligion? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieCodeAbuse? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieUnicodeSpoofing? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ModerationAPI.NewModerateModerateRequestPolicieUnicodeSpoofingSignals2>? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieUnicodeSpoofingSignals2? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPoliciePiiMasking? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ModerationAPI.NewModerateModerateRequestPoliciePiiMaskingEntities2>? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPoliciePiiMaskingEntities2? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieUrlMasking? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ModerationAPI.NewModerateModerateRequestPolicieUrlMaskingEntities2>? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieUrlMaskingEntities2? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieUrlRisk? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieGuideline? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ManagementProjectsCreateRequest? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ManagementProjectsUpdateRequest? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ManagementProjectsUpdateRequestGlobalFlaggingMode? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ManagementProjectsDuplicateRequest? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ManagementChannelsCreateRequest? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ManagementChannelsCreateRequestContentType? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ManagementChannelsUpdateRequest? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ManagementChannelsUpdateRequestContentType? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ManagementChannelsUpdateRequestFlaggingMode? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ManagementChannelsUpdateRequestTranscriptionQuality? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ManagementChannelsDuplicateRequest? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.GetStreamRequest? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.GetStreamRequestDiscriminator? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.GetStreamRequestDiscriminatorEvent? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.AuthorOpenListAuthorsSortBy? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.AuthorOpenListAuthorsSortDirection? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueViewOpenGetItemsSortField? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueViewOpenGetItemsSortDirection? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.GetStreamSecWebSocketProtocol? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.AuthorOpenListAuthorsResponse? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.PublicAuthor>? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.AuthorOpenListAuthorsResponsePagination? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.AuthorDeleteResponse? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueViewOpenGetQueueResponse? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueViewOpenGetQueueResponseQueue? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueViewOpenGetQueueResponseQueueFilter? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueViewOpenGetQueueResponseQueueFilterIsFlagged? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueViewOpenGetQueueResponseQueueFilterCasebookAnswer? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueViewOpenGetQueueResponseQueueFilterCasebookAgreement? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.QueueViewOpenGetQueueResponseQueueFilterFilterLabel>? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueViewOpenGetQueueResponseQueueFilterFilterLabel? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueViewOpenGetQueueResponseQueueFilterFilterLabelType? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.QueueViewOpenGetQueueResponseQueueFilterMetadataFilter>? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueViewOpenGetQueueResponseQueueFilterMetadataFilter? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.QueueViewOpenGetQueueResponseQueueFilterContentType>? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueViewOpenGetQueueResponseQueueFilterContentType? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.QueueViewOpenGetQueueResponseQueueFilterMediaType>? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueViewOpenGetQueueResponseQueueFilterMediaType? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<int>? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.QueueViewOpenGetQueueResponseQueueFilterRecommendationAction>? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueViewOpenGetQueueResponseQueueFilterRecommendationAction? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueViewOpenGetQueueResponseQueueFilterWithinUnit? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueViewOpenGetQueueResponseQueueFilterCheckStatus? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueViewOpenGetStatsResponse? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueViewOpenGetStatsResponseReviewStats? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.QueueViewOpenGetStatsResponseActionStat>? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueViewOpenGetStatsResponseActionStat? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.QueueViewOpenGetStatsResponseTopReviewer>? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueViewOpenGetStatsResponseTopReviewer? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.QueueViewOpenGetStatsResponseTopReviewerTopAction>? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueViewOpenGetStatsResponseTopReviewerTopAction? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueViewOpenGetStatsResponseTrends? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.QueueViewOpenGetStatsResponseTrendsDailyReviewCount>? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueViewOpenGetStatsResponseTrendsDailyReviewCount? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.QueueViewOpenGetStatsResponseTrendsFlaggedContentTrend>? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueViewOpenGetStatsResponseTrendsFlaggedContentTrend? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueViewOpenGetItemsResponse? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.QueueViewOpenGetItemsResponseItem>? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueViewOpenGetItemsResponseItem? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.QueueViewOpenGetItemsResponseItemLabel>? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueViewOpenGetItemsResponseItemLabel? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.QueueViewOpenGetItemsResponseItemAction>? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueViewOpenGetItemsResponseItemAction? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueViewOpenGetItemsResponseItemStatus? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueViewOpenGetItemsResponsePagination? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueViewOpenResolveItemResponse? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueViewOpenUnresolveItemResponse? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.ActionsListResponseItem>? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsListResponseItem? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsListResponseItemType? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsListResponseItemQueueBehaviour? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsListResponseItemPosition? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.ActionsListResponseItemPossibleValue>? Type267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsListResponseItemPossibleValue? Type268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsCreateResponse? Type269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsCreateResponseType? Type270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsCreateResponseQueueBehaviour? Type271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsCreateResponsePosition? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.ActionsCreateResponsePossibleValue>? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsCreateResponsePossibleValue? Type274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsGetResponse? Type275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsGetResponseType? Type276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsGetResponseQueueBehaviour? Type277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsGetResponsePosition? Type278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.ActionsGetResponsePossibleValue>? Type279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsGetResponsePossibleValue? Type280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsUpdateResponse? Type281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsUpdateResponseType? Type282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsUpdateResponseQueueBehaviour? Type283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsUpdateResponsePosition? Type284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.ActionsUpdateResponsePossibleValue>? Type285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsUpdateResponsePossibleValue? Type286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsDeleteResponse? Type287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsExecuteResponse? Type288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsExecuteDeprecatedResponse? Type289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.WebhooksPublicListResponseItem>? Type290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.WebhooksPublicListResponseItem? Type291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.WebhooksPublicListResponseItemEventType>? Type292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.WebhooksPublicListResponseItemEventType? Type293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.WebhooksPublicListResponseItemPayloadVersion? Type294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.WebhooksPublicCreateResponse? Type295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.WebhooksPublicCreateResponseEventType>? Type296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.WebhooksPublicCreateResponseEventType? Type297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.WebhooksPublicCreateResponsePayloadVersion? Type298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.WebhooksPublicGetResponse? Type299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.WebhooksPublicGetResponseEventType>? Type300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.WebhooksPublicGetResponseEventType? Type301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.WebhooksPublicGetResponsePayloadVersion? Type302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.WebhooksPublicUpdateResponse? Type303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.WebhooksPublicUpdateResponseEventType>? Type304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.WebhooksPublicUpdateResponseEventType? Type305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.WebhooksPublicUpdateResponsePayloadVersion? Type306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.WebhooksPublicDeleteResponse? Type307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.WebhooksPublicGetSecretResponse? Type308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.AllOf<global::ModerationAPI.ModerationTextResponseVariant1, object>? Type309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ModerationTextResponseVariant1? Type310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ModerationTextResponseVariant1Request? Type311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ModerationTextResponseVariant1Author? Type312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ModerationTextResponseVariant1AuthorBlock? Type313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ModerationTextResponseVariant1AuthorStatus? Type314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ModerationTextResponseVariant1AuthorTrustLevel? Type315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.AllOf<global::ModerationAPI.ModerationImageResponseVariant1, object>? Type316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ModerationImageResponseVariant1? Type317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ModerationImageResponseVariant1Request? Type318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ModerationImageResponseVariant1Author? Type319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ModerationImageResponseVariant1AuthorBlock? Type320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ModerationImageResponseVariant1AuthorStatus? Type321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ModerationImageResponseVariant1AuthorTrustLevel? Type322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.ModerationImageResponseVariant1Label>? Type323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ModerationImageResponseVariant1Label? Type324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.AccountGetResponse? Type325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.AccountGetResponseCurrentProject? Type326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.AccountLegacyAuthGetResponse? Type327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.AccountLegacyAuthPostResponse? Type328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.WordlistListResponseItem>? Type329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.WordlistListResponseItem? Type330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.WordlistGetWordlistPublicResponse? Type331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.WordlistUpdateResponse? Type332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.WordlistWordlistEmbeddingStatusResponse? Type333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.WordlistAddWordsResponse? Type334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.WordlistRemoveWordsResponse? Type335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponse? Type336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponseContent? Type337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentText? Type338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentImage? Type339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentVideo? Type340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentAudio? Type341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponseAuthor? Type342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponseAuthorBlock? Type343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponseAuthorStatus? Type344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponseAuthorTrustLevel? Type345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponseEvaluation? Type346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponseRecommendation? Type347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponseRecommendationAction? Type348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.AnyOf<global::ModerationAPI.NewModerateModerateResponseRecommendationReasonCode?, string>>? Type349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.AnyOf<global::ModerationAPI.NewModerateModerateResponseRecommendationReasonCode?, string>? Type350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponseRecommendationReasonCode? Type351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.NewModerateModerateResponseRecommendationMatchedRule>? Type352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponseRecommendationMatchedRule? Type353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponseCasebook? Type354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponseCasebookVerdict? Type355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponseCasebookTopic? Type356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.OneOf<global::ModerationAPI.NewModerateModerateResponsePolicieClassifierOutput, global::ModerationAPI.NewModerateModerateResponsePolicieEntityMatcherOutput>? Type357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponsePolicieClassifierOutput? Type358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.NewModerateModerateResponsePolicieClassifierOutputLabel>? Type359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponsePolicieClassifierOutputLabel? Type360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponsePolicieEntityMatcherOutput? Type361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.NewModerateModerateResponsePolicieEntityMatcherOutputMatche>? Type362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponsePolicieEntityMatcherOutputMatche? Type363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponsePolicieEntityMatcherOutputMatcheSignals? Type364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponsePolicieEntityMatcherOutputMatcheSignalsBrandImpersonation? Type365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponsePolicieEntityMatcherOutputMatcheSignalsBrandImpersonationMethod? Type366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.OneOf<global::ModerationAPI.NewModerateModerateResponseInsightSentimentInsight, global::ModerationAPI.NewModerateModerateResponseInsightLanguageInsight>>? Type367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.OneOf<global::ModerationAPI.NewModerateModerateResponseInsightSentimentInsight, global::ModerationAPI.NewModerateModerateResponseInsightLanguageInsight>? Type368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponseInsightSentimentInsight? Type369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponseInsightSentimentInsightValue? Type370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponseInsightLanguageInsight? Type371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponseMeta? Type372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponseMetaStatus? Type373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.NewModerateModerateResponseError>? Type374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponseError? Type375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.Project>? Type376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ManagementProjectsDeleteResponse? Type377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.Channel>? Type378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ManagementChannelsDeleteResponse? Type379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.GetStreamResponse? Type380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.GetStreamResponseDiscriminator? Type381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.GetStreamResponseDiscriminatorEvent? Type382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.CreateAuthorBlockedWebhookVersion? Type383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.CreateAuthorUnblockedWebhookVersion? Type384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.CreateAuthorSuspendedWebhookVersion? Type385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.CreateAuthorUpdatedWebhookVersion? Type386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.CreateAuthorTrustLevelChangedWebhookVersion? Type387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.CreateAuthorActionWebhookVersion? Type388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.CreateQueueItemResolvedWebhookVersion? Type389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.CreateQueueItemActionWebhookVersion? Type390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.CreateQueueItemRejectedWebhookVersion? Type391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.CreateQueueItemAllowedWebhookVersion? Type392 { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ModerationAPI.ErrorBadRequestIssue>? ListType0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ModerationAPI.ErrorUnauthorizedIssue>? ListType1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ModerationAPI.ErrorForbiddenIssue>? ListType2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ModerationAPI.ErrorNotFoundIssue>? ListType3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ModerationAPI.ErrorInternalServerErrorIssue>? ListType4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ModerationAPI.ErrorConflictIssue>? ListType5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ModerationAPI.PublicQueueItemLabelsVariant1Item>? ListType6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ModerationAPI.PublicQueueItemLabelsVariant1ItemMatche>? ListType7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<double>? ListType8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ModerationAPI.VoiceStartFrameTrack>? ListType9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<object>? ListType10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ModerationAPI.ActionsCreateRequestPossibleValue>? ListType11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ModerationAPI.ActionsUpdateRequestPossibleValue>? ListType12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ModerationAPI.WebhooksPublicCreateRequestEventType>? ListType13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ModerationAPI.WebhooksPublicUpdateRequestEventType>? ListType14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ModerationAPI.PublicAuthor>? ListType15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ModerationAPI.QueueViewOpenGetQueueResponseQueueFilterFilterLabel>? ListType16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ModerationAPI.QueueViewOpenGetQueueResponseQueueFilterMetadataFilter>? ListType17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ModerationAPI.QueueViewOpenGetQueueResponseQueueFilterContentType>? ListType18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ModerationAPI.QueueViewOpenGetQueueResponseQueueFilterMediaType>? ListType19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<int>? ListType20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ModerationAPI.QueueViewOpenGetQueueResponseQueueFilterRecommendationAction>? ListType21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ModerationAPI.QueueViewOpenGetStatsResponseActionStat>? ListType22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ModerationAPI.QueueViewOpenGetStatsResponseTopReviewer>? ListType23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ModerationAPI.QueueViewOpenGetStatsResponseTopReviewerTopAction>? ListType24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ModerationAPI.QueueViewOpenGetStatsResponseTrendsDailyReviewCount>? ListType25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ModerationAPI.QueueViewOpenGetStatsResponseTrendsFlaggedContentTrend>? ListType26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ModerationAPI.QueueViewOpenGetItemsResponseItem>? ListType27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ModerationAPI.QueueViewOpenGetItemsResponseItemLabel>? ListType28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ModerationAPI.QueueViewOpenGetItemsResponseItemAction>? ListType29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ModerationAPI.ActionsListResponseItem>? ListType30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ModerationAPI.ActionsListResponseItemPossibleValue>? ListType31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ModerationAPI.ActionsCreateResponsePossibleValue>? ListType32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ModerationAPI.ActionsGetResponsePossibleValue>? ListType33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ModerationAPI.ActionsUpdateResponsePossibleValue>? ListType34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ModerationAPI.WebhooksPublicListResponseItem>? ListType35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ModerationAPI.WebhooksPublicListResponseItemEventType>? ListType36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ModerationAPI.WebhooksPublicCreateResponseEventType>? ListType37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ModerationAPI.WebhooksPublicGetResponseEventType>? ListType38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ModerationAPI.WebhooksPublicUpdateResponseEventType>? ListType39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ModerationAPI.ModerationImageResponseVariant1Label>? ListType40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ModerationAPI.WordlistListResponseItem>? ListType41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ModerationAPI.AnyOf<global::ModerationAPI.NewModerateModerateResponseRecommendationReasonCode?, string>>? ListType42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ModerationAPI.NewModerateModerateResponseRecommendationMatchedRule>? ListType43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ModerationAPI.OneOf<global::ModerationAPI.NewModerateModerateResponsePolicieClassifierOutput, global::ModerationAPI.NewModerateModerateResponsePolicieEntityMatcherOutput>>? ListType44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ModerationAPI.NewModerateModerateResponsePolicieClassifierOutputLabel>? ListType45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ModerationAPI.NewModerateModerateResponsePolicieEntityMatcherOutputMatche>? ListType46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ModerationAPI.OneOf<global::ModerationAPI.NewModerateModerateResponseInsightSentimentInsight, global::ModerationAPI.NewModerateModerateResponseInsightLanguageInsight>>? ListType47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ModerationAPI.NewModerateModerateResponseError>? ListType48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ModerationAPI.Project>? ListType49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ModerationAPI.Channel>? ListType50 { get; set; }
    }
}