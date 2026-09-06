
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
        public global::ModerationAPI.AuthorBlockedEvent? Type29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTime? Type30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.AuthorBlockedEventData? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.PublicActionPerformedAuthor? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.PublicActionPerformedAuthorQueue? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.AuthorUnblockedEvent? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.AuthorUnblockedEventData? Type35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.AuthorSuspendedEvent? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.AuthorSuspendedEventData? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.AuthorUpdatedEvent? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.AuthorUpdatedEventData? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.AuthorTrustLevelChangedEvent? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.AuthorTrustLevelChangedEventData? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.AuthorActionEvent? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.AuthorActionEventData? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueItemCompletedEvent? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueItemCompletedEventData? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.PublicQueueItemEvent? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.PublicQueueItem? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.PublicQueueItemEventQueue? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.PublicQueueItemLabelsVariant1Item>? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.PublicQueueItemLabelsVariant1Item? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.PublicQueueItemLabelsVariant1ItemMatche>? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.PublicQueueItemLabelsVariant1ItemMatche? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public byte[]? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.PublicQueueItemLabelsVariant1ItemMatcheSignals? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.PublicQueueItemLabelsVariant1ItemMatcheSignalsBrandImpersonation? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.PublicQueueItemContentText? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.PublicQueueItemContentImage? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.PublicQueueItemContentVideo? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.PublicQueueItemContentAudio? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.PublicQueueItemContentObject? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.PublicQueueItemContentObjectDataText? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.PublicQueueItemContentObjectDataImage? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.PublicQueueItemContentObjectDataVideo? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.PublicQueueItemContentObjectDataAudio? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.PublicQueueItemClientAction? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.PublicQueueItemClientActionAction? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.PublicQueueItemClientActionBehavior? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.PublicQueueItemMetaType? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueItemActionEvent? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueItemActionEventData? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.PublicActionPerformed? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.PublicActionPerformedQueue? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueItemRejectedEvent? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueItemRejectedEventData? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueItemAllowedEvent? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueItemAllowedEventData? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.WebhookEvent? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.WebhookEventDiscriminator? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.WebhookEventDiscriminatorType? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.VoiceStartFrame? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.VoiceStartFrameEvent? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.VoiceStartFrameMediaFormat? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.VoiceStartFrameTrack>? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.VoiceStartFrameTrack? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.VoiceStartFrameTrackName? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.VoiceMediaFrame? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.VoiceMediaFrameEvent? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.VoiceMediaFrameMedia? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.VoiceMediaFrameMediaTrack? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.VoiceStopFrame? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.VoiceStopFrameEvent? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.VoiceSessionStarted? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.VoiceSessionStartedEvent? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.VoiceUtteranceFinal? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.VoiceUtteranceFinalEvent? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.VoiceUtteranceFinalTrack? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.VoiceUtteranceFinalRecommendation? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.VoiceUtteranceFinalRecommendationAction? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<object>? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.VoiceSessionEnded? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.VoiceSessionEndedEvent? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.VoiceSessionEndedStats? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.VoiceSessionEndedStatsActions? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.AuthorOpenCreateRequest? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.AuthorOpenCreateRequestMetadata? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.AuthorOpenUpdateRequest? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.AuthorOpenUpdateRequestMetadata? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueViewOpenResolveItemRequest? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueViewOpenUnresolveItemRequest? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsCreateRequest? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsCreateRequestType? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsCreateRequestQueueBehaviour? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsCreateRequestPosition? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.ActionsCreateRequestPossibleValue>? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsCreateRequestPossibleValue? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsUpdateRequest? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsUpdateRequestType? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsUpdateRequestQueueBehaviour? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsUpdateRequestPosition? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.ActionsUpdateRequestPossibleValue>? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsUpdateRequestPossibleValue? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsExecuteRequest? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsExecuteDeprecatedRequest? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ModerationTextRequest? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ModerationObjectRequest? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ModerationObjectRequestValue? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ModerationObjectRequestValueType? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ModerationAPI.ModerationObjectRequestValueData2>? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ModerationObjectRequestValueData2? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ModerationObjectRequestValueDataType? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ModerationImageRequest? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ModerationVideoRequest? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ModerationAudioRequest? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.WordlistUpdateRequest? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.WordlistAddWordsRequest? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequest? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestContentText? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestContentImage? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestContentVideo? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestContentAudio? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestContentObject? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestContentObjectDataText? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestContentObjectDataImage? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestContentObjectDataVideo? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestContentObjectDataAudio? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestMetaType? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestClientAction? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestClientActionAction? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestClientActionBehavior? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieToxicity? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPoliciePersonalInformation? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieToxicitySevere? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieHate? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieIllicit? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieIllicitDrugs? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieIllicitAlcohol? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieIllicitFirearms? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieIllicitTobacco? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieIllicitGambling? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieCannabis? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieAdult? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieCrypto? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieSexual? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieFlirtation? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieProfanity? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieViolence? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieSelfHarm? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieSpam? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieLowQualityContent? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieFaceDetection? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieFaceDetectionComparator? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieSelfPromotion? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPoliciePolitical? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieReligion? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieCodeAbuse? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPoliciePiiMasking? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ModerationAPI.NewModerateModerateRequestPoliciePiiMaskingEntities2>? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPoliciePiiMaskingEntities2? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieUrlMasking? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::ModerationAPI.NewModerateModerateRequestPolicieUrlMaskingEntities2>? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieUrlMaskingEntities2? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieUrlRisk? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateRequestPolicieGuideline? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.GetStreamRequest? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.GetStreamRequestDiscriminator? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.GetStreamRequestDiscriminatorEvent? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.AuthorOpenListAuthorsSortBy? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.AuthorOpenListAuthorsSortDirection? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueViewOpenGetItemsSortField? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueViewOpenGetItemsSortDirection? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.GetStreamSecWebSocketProtocol? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.AuthorOpenListAuthorsResponse? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.PublicAuthor>? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.AuthorOpenListAuthorsResponsePagination? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.AuthorDeleteResponse? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueViewOpenGetQueueResponse? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueViewOpenGetQueueResponseQueue? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueViewOpenGetQueueResponseQueueFilter? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.QueueViewOpenGetQueueResponseQueueFilterFilterLabel>? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueViewOpenGetQueueResponseQueueFilterFilterLabel? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueViewOpenGetQueueResponseQueueFilterFilterLabelType? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.QueueViewOpenGetQueueResponseQueueFilterRecommendationAction>? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueViewOpenGetQueueResponseQueueFilterRecommendationAction? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueViewOpenGetStatsResponse? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueViewOpenGetStatsResponseReviewStats? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.QueueViewOpenGetStatsResponseActionStat>? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueViewOpenGetStatsResponseActionStat? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.QueueViewOpenGetStatsResponseTopReviewer>? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueViewOpenGetStatsResponseTopReviewer? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.QueueViewOpenGetStatsResponseTopReviewerTopAction>? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueViewOpenGetStatsResponseTopReviewerTopAction? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueViewOpenGetStatsResponseTrends? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.QueueViewOpenGetStatsResponseTrendsDailyReviewCount>? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueViewOpenGetStatsResponseTrendsDailyReviewCount? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.QueueViewOpenGetStatsResponseTrendsFlaggedContentTrend>? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueViewOpenGetStatsResponseTrendsFlaggedContentTrend? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueViewOpenGetItemsResponse? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.QueueViewOpenGetItemsResponseItem>? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueViewOpenGetItemsResponseItem? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.QueueViewOpenGetItemsResponseItemLabel>? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueViewOpenGetItemsResponseItemLabel? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.QueueViewOpenGetItemsResponseItemAction>? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueViewOpenGetItemsResponseItemAction? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueViewOpenGetItemsResponseItemStatus? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueViewOpenGetItemsResponsePagination? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueViewOpenResolveItemResponse? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.QueueViewOpenUnresolveItemResponse? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.ActionsListResponseItem>? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsListResponseItem? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsListResponseItemType? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsListResponseItemQueueBehaviour? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsListResponseItemPosition? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.ActionsListResponseItemPossibleValue>? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsListResponseItemPossibleValue? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsCreateResponse? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsCreateResponseType? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsCreateResponseQueueBehaviour? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsCreateResponsePosition? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.ActionsCreateResponsePossibleValue>? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsCreateResponsePossibleValue? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsGetResponse? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsGetResponseType? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsGetResponseQueueBehaviour? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsGetResponsePosition? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.ActionsGetResponsePossibleValue>? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsGetResponsePossibleValue? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsUpdateResponse? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsUpdateResponseType? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsUpdateResponseQueueBehaviour? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsUpdateResponsePosition? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.ActionsUpdateResponsePossibleValue>? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsUpdateResponsePossibleValue? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsDeleteResponse? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsExecuteResponse? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ActionsExecuteDeprecatedResponse? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.AllOf<global::ModerationAPI.ModerationTextResponseVariant1, object>? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ModerationTextResponseVariant1? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ModerationTextResponseVariant1Request? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ModerationTextResponseVariant1Author? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ModerationTextResponseVariant1AuthorBlock? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ModerationTextResponseVariant1AuthorStatus? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ModerationTextResponseVariant1AuthorTrustLevel? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ModerationTextResponseVariant1Nsfw? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ModerationTextResponseVariant1NsfwLabelScores? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ModerationTextResponseVariant1Toxicity? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ModerationTextResponseVariant1ToxicityLabelScores? Type267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ModerationTextResponseVariant1Quality? Type268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ModerationTextResponseVariant1QualityLabelScores? Type269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ModerationTextResponseVariant1Sentiment? Type270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ModerationTextResponseVariant1SentimentLabelScores? Type271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ModerationTextResponseVariant1Propriety? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ModerationTextResponseVariant1ProprietyLabelScores? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ModerationTextResponseVariant1Email? Type274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ModerationTextResponseVariant1EmailMode? Type275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ModerationTextResponseVariant1Phone? Type276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ModerationTextResponseVariant1PhoneMode? Type277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ModerationTextResponseVariant1Url? Type278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ModerationTextResponseVariant1UrlMode? Type279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ModerationTextResponseVariant1Address? Type280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ModerationTextResponseVariant1AddressMode? Type281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ModerationTextResponseVariant1Name? Type282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ModerationTextResponseVariant1NameMode? Type283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ModerationTextResponseVariant1Username? Type284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ModerationTextResponseVariant1UsernameMode? Type285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ModerationTextResponseVariant1Profanity? Type286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ModerationTextResponseVariant1ProfanityMode? Type287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ModerationTextResponseVariant1Sensitive? Type288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ModerationTextResponseVariant1SensitiveMode? Type289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ModerationTextResponseVariant1Wordlist? Type290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ModerationTextResponseVariant1WordlistMode? Type291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.ModerationTextResponseVariant1Wordlist2>? Type292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ModerationTextResponseVariant1Wordlist2? Type293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ModerationTextResponseVariant1WordlistMode2? Type294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.AllOf<global::ModerationAPI.ModerationObjectResponseVariant1, object>? Type295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ModerationObjectResponseVariant1? Type296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ModerationObjectResponseVariant1Request? Type297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ModerationObjectResponseVariant1Author? Type298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ModerationObjectResponseVariant1AuthorBlock? Type299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ModerationObjectResponseVariant1AuthorStatus? Type300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ModerationObjectResponseVariant1AuthorTrustLevel? Type301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.ModerationObjectResponseVariant1Label>? Type302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ModerationObjectResponseVariant1Label? Type303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.ModerationObjectResponseVariant1Entitie>? Type304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ModerationObjectResponseVariant1Entitie? Type305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.ModerationObjectResponseVariant1Wordlist>? Type306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ModerationObjectResponseVariant1Wordlist? Type307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ModerationObjectResponseVariant1WordlistMode? Type308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.ModerationObjectResponseVariant1Field>? Type309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ModerationObjectResponseVariant1Field? Type310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ModerationImageResponse? Type311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ModerationImageResponseRequest? Type312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ModerationImageResponseAuthor? Type313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ModerationImageResponseAuthorBlock? Type314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ModerationImageResponseAuthorStatus? Type315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ModerationImageResponseAuthorTrustLevel? Type316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.ModerationImageResponseLabel>? Type317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ModerationImageResponseLabel? Type318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ModerationImageResponseLabelLabel? Type319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.AllOf<global::ModerationAPI.ModerationVideoResponseVariant1, object>? Type320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ModerationVideoResponseVariant1? Type321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ModerationVideoResponseVariant1Request? Type322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ModerationVideoResponseVariant1Author? Type323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ModerationVideoResponseVariant1AuthorBlock? Type324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ModerationVideoResponseVariant1AuthorStatus? Type325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ModerationVideoResponseVariant1AuthorTrustLevel? Type326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ModerationAudioResponse? Type327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ModerationAudioResponseRequest? Type328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ModerationAudioResponseAuthor? Type329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ModerationAudioResponseAuthorBlock? Type330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ModerationAudioResponseAuthorStatus? Type331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.ModerationAudioResponseAuthorTrustLevel? Type332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.AccountGetResponse? Type333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.AccountGetResponseCurrentProject? Type334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.AccountLegacyAuthGetResponse? Type335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.AccountLegacyAuthPostResponse? Type336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.WordlistListResponseItem>? Type337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.WordlistListResponseItem? Type338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.WordlistGetWordlistPublicResponse? Type339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.WordlistUpdateResponse? Type340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.WordlistWordlistEmbeddingStatusResponse? Type341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.WordlistAddWordsResponse? Type342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.WordlistRemoveWordsResponse? Type343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponse? Type344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponseContent? Type345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentText? Type346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentImage? Type347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentVideo? Type348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentAudio? Type349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponseAuthor? Type350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponseAuthorBlock? Type351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponseAuthorStatus? Type352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponseAuthorTrustLevel? Type353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponseEvaluation? Type354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponseRecommendation? Type355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponseRecommendationAction? Type356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.NewModerateModerateResponseRecommendationReasonCode>? Type357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponseRecommendationReasonCode? Type358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.NewModerateModerateResponseRecommendationMatchedRule>? Type359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponseRecommendationMatchedRule? Type360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.OneOf<global::ModerationAPI.NewModerateModerateResponsePolicieClassifierOutput, global::ModerationAPI.NewModerateModerateResponsePolicieEntityMatcherOutput>? Type361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponsePolicieClassifierOutput? Type362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.NewModerateModerateResponsePolicieClassifierOutputLabel>? Type363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponsePolicieClassifierOutputLabel? Type364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponsePolicieEntityMatcherOutput? Type365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.NewModerateModerateResponsePolicieEntityMatcherOutputMatche>? Type366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponsePolicieEntityMatcherOutputMatche? Type367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<int>? Type368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponsePolicieEntityMatcherOutputMatcheSignals? Type369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponsePolicieEntityMatcherOutputMatcheSignalsBrandImpersonation? Type370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponsePolicieEntityMatcherOutputMatcheSignalsBrandImpersonationMethod? Type371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.OneOf<global::ModerationAPI.NewModerateModerateResponseInsightSentimentInsight, global::ModerationAPI.NewModerateModerateResponseInsightLanguageInsight>>? Type372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.OneOf<global::ModerationAPI.NewModerateModerateResponseInsightSentimentInsight, global::ModerationAPI.NewModerateModerateResponseInsightLanguageInsight>? Type373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponseInsightSentimentInsight? Type374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponseInsightSentimentInsightValue? Type375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponseInsightLanguageInsight? Type376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponseMeta? Type377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponseMetaStatus? Type378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ModerationAPI.NewModerateModerateResponseError>? Type379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.NewModerateModerateResponseError? Type380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.GetStreamResponse? Type381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.GetStreamResponseDiscriminator? Type382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.GetStreamResponseDiscriminatorEvent? Type383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.CreateAuthorBlockedWebhookVersion? Type384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.CreateAuthorUnblockedWebhookVersion? Type385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.CreateAuthorSuspendedWebhookVersion? Type386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.CreateAuthorUpdatedWebhookVersion? Type387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.CreateAuthorTrustLevelChangedWebhookVersion? Type388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.CreateAuthorActionWebhookVersion? Type389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.CreateQueueItemResolvedWebhookVersion? Type390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.CreateQueueItemActionWebhookVersion? Type391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.CreateQueueItemRejectedWebhookVersion? Type392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ModerationAPI.CreateQueueItemAllowedWebhookVersion? Type393 { get; set; }

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
        public global::System.Collections.Generic.List<global::ModerationAPI.VoiceStartFrameTrack>? ListType8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<object>? ListType9 { get; set; }
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
        public global::System.Collections.Generic.List<global::ModerationAPI.PublicAuthor>? ListType12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ModerationAPI.QueueViewOpenGetQueueResponseQueueFilterFilterLabel>? ListType13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ModerationAPI.QueueViewOpenGetQueueResponseQueueFilterRecommendationAction>? ListType14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ModerationAPI.QueueViewOpenGetStatsResponseActionStat>? ListType15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ModerationAPI.QueueViewOpenGetStatsResponseTopReviewer>? ListType16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ModerationAPI.QueueViewOpenGetStatsResponseTopReviewerTopAction>? ListType17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ModerationAPI.QueueViewOpenGetStatsResponseTrendsDailyReviewCount>? ListType18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ModerationAPI.QueueViewOpenGetStatsResponseTrendsFlaggedContentTrend>? ListType19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ModerationAPI.QueueViewOpenGetItemsResponseItem>? ListType20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ModerationAPI.QueueViewOpenGetItemsResponseItemLabel>? ListType21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ModerationAPI.QueueViewOpenGetItemsResponseItemAction>? ListType22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ModerationAPI.ActionsListResponseItem>? ListType23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ModerationAPI.ActionsListResponseItemPossibleValue>? ListType24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ModerationAPI.ActionsCreateResponsePossibleValue>? ListType25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ModerationAPI.ActionsGetResponsePossibleValue>? ListType26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ModerationAPI.ActionsUpdateResponsePossibleValue>? ListType27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ModerationAPI.ModerationTextResponseVariant1Wordlist2>? ListType28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ModerationAPI.ModerationObjectResponseVariant1Label>? ListType29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ModerationAPI.ModerationObjectResponseVariant1Entitie>? ListType30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ModerationAPI.ModerationObjectResponseVariant1Wordlist>? ListType31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ModerationAPI.ModerationObjectResponseVariant1Field>? ListType32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ModerationAPI.ModerationImageResponseLabel>? ListType33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ModerationAPI.WordlistListResponseItem>? ListType34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ModerationAPI.NewModerateModerateResponseRecommendationReasonCode>? ListType35 { get; set; }
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
        public global::System.Collections.Generic.List<global::ModerationAPI.OneOf<global::ModerationAPI.NewModerateModerateResponseInsightSentimentInsight, global::ModerationAPI.NewModerateModerateResponseInsightLanguageInsight>>? ListType41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ModerationAPI.NewModerateModerateResponseError>? ListType42 { get; set; }
    }
}