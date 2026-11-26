
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull
    )]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::ModerationAPI.OneOf<global::ModerationAPI.QueueItemContentObjectDataText, global::ModerationAPI.QueueItemContentObjectDataImage, global::ModerationAPI.QueueItemContentObjectDataVideo, global::ModerationAPI.QueueItemContentObjectDataAudio>>), TypeInfoPropertyName = "QueueItemContentObjectDataAudio_8553da6e2cecbbbb")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.OneOf<global::ModerationAPI.QueueItemContentObjectDataText, global::ModerationAPI.QueueItemContentObjectDataImage, global::ModerationAPI.QueueItemContentObjectDataVideo, global::ModerationAPI.QueueItemContentObjectDataAudio>), TypeInfoPropertyName = "QueueItemContentObjectDataAudio_aa3397d2851ed486")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.OneOf<global::ModerationAPI.PublicQueueItemContentText, global::ModerationAPI.PublicQueueItemContentImage, global::ModerationAPI.PublicQueueItemContentVideo, global::ModerationAPI.PublicQueueItemContentAudio, global::ModerationAPI.PublicQueueItemContentObject>), TypeInfoPropertyName = "PublicQueueItemContentObject_a5b10a16560a2a90")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::ModerationAPI.OneOf<global::ModerationAPI.PublicQueueItemContentObjectDataText, global::ModerationAPI.PublicQueueItemContentObjectDataImage, global::ModerationAPI.PublicQueueItemContentObjectDataVideo, global::ModerationAPI.PublicQueueItemContentObjectDataAudio>>), TypeInfoPropertyName = "PublicQueueItemContentObjectDataAudio_9fba358e4ede806b")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.OneOf<global::ModerationAPI.PublicQueueItemContentObjectDataText, global::ModerationAPI.PublicQueueItemContentObjectDataImage, global::ModerationAPI.PublicQueueItemContentObjectDataVideo, global::ModerationAPI.PublicQueueItemContentObjectDataAudio>), TypeInfoPropertyName = "PublicQueueItemContentObjectDataAudio_f4551668b35ad437")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.OneOf<global::ModerationAPI.NewModerateModerateRequestContentText, global::ModerationAPI.NewModerateModerateRequestContentImage, global::ModerationAPI.NewModerateModerateRequestContentVideo, global::ModerationAPI.NewModerateModerateRequestContentAudio, global::ModerationAPI.NewModerateModerateRequestContentObject>), TypeInfoPropertyName = "NewModerateModerateRequestContentObject_c77db83f9aa266b5")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::ModerationAPI.OneOf<global::ModerationAPI.NewModerateModerateRequestContentObjectDataText, global::ModerationAPI.NewModerateModerateRequestContentObjectDataImage, global::ModerationAPI.NewModerateModerateRequestContentObjectDataVideo, global::ModerationAPI.NewModerateModerateRequestContentObjectDataAudio>>), TypeInfoPropertyName = "NewModerateModerateRequestContentObjectDataAudio_3ecd4df47b6afadc")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.OneOf<global::ModerationAPI.NewModerateModerateRequestContentObjectDataText, global::ModerationAPI.NewModerateModerateRequestContentObjectDataImage, global::ModerationAPI.NewModerateModerateRequestContentObjectDataVideo, global::ModerationAPI.NewModerateModerateRequestContentObjectDataAudio>), TypeInfoPropertyName = "NewModerateModerateRequestContentObjectDataAudio_a7076b050589a568")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ModerationAPI.OneOf<global::ModerationAPI.NewModerateModerateRequestPolicieToxicity, global::ModerationAPI.NewModerateModerateRequestPoliciePersonalInformation, global::ModerationAPI.NewModerateModerateRequestPolicieHate, global::ModerationAPI.NewModerateModerateRequestPolicieIllicit, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitDrugs, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitAlcohol, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitFirearms, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitTobacco, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitGambling, global::ModerationAPI.NewModerateModerateRequestPolicieCannabis, global::ModerationAPI.NewModerateModerateRequestPolicieAdult, global::ModerationAPI.NewModerateModerateRequestPolicieCrypto, global::ModerationAPI.NewModerateModerateRequestPolicieSexual, global::ModerationAPI.NewModerateModerateRequestPolicieSexualMinors, global::ModerationAPI.NewModerateModerateRequestPolicieProfanity, global::ModerationAPI.NewModerateModerateRequestPolicieViolence, global::ModerationAPI.NewModerateModerateRequestPolicieSelfHarm, global::ModerationAPI.NewModerateModerateRequestPolicieSpam, global::ModerationAPI.NewModerateModerateRequestPolicieLowQualityContent, global::ModerationAPI.NewModerateModerateRequestPolicieFaceDetection, global::ModerationAPI.NewModerateModerateRequestPolicieSelfPromotion, global::ModerationAPI.NewModerateModerateRequestPoliciePolitical, global::ModerationAPI.NewModerateModerateRequestPolicieReligion, global::ModerationAPI.NewModerateModerateRequestPolicieThreat, global::ModerationAPI.NewModerateModerateRequestPolicieSexualSolicitation, global::ModerationAPI.NewModerateModerateRequestPolicieChannelCircumvention, global::ModerationAPI.NewModerateModerateRequestPolicieIllegalTrade, global::ModerationAPI.NewModerateModerateRequestPolicieAlcohol, global::ModerationAPI.NewModerateModerateRequestPolicieDrugs, global::ModerationAPI.NewModerateModerateRequestPolicieGambling, global::ModerationAPI.NewModerateModerateRequestPolicieTobacco, global::ModerationAPI.NewModerateModerateRequestPolicieWeapons, global::ModerationAPI.NewModerateModerateRequestPoliciePromotion, global::ModerationAPI.NewModerateModerateRequestPolicieExtremism, global::ModerationAPI.NewModerateModerateRequestPolicieCodeAbuse, global::ModerationAPI.NewModerateModerateRequestPolicieUnicodeSpoofing, global::ModerationAPI.NewModerateModerateRequestPoliciePiiMasking, global::ModerationAPI.NewModerateModerateRequestPolicieUrlMasking, global::ModerationAPI.NewModerateModerateRequestPolicieUrlRisk, global::ModerationAPI.NewModerateModerateRequestPolicieGuideline>>), TypeInfoPropertyName = "NewModerateModerateRequestPolicieGuideline_4f41f5791e0537bc")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.OneOf<global::ModerationAPI.NewModerateModerateRequestPolicieToxicity, global::ModerationAPI.NewModerateModerateRequestPoliciePersonalInformation, global::ModerationAPI.NewModerateModerateRequestPolicieHate, global::ModerationAPI.NewModerateModerateRequestPolicieIllicit, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitDrugs, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitAlcohol, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitFirearms, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitTobacco, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitGambling, global::ModerationAPI.NewModerateModerateRequestPolicieCannabis, global::ModerationAPI.NewModerateModerateRequestPolicieAdult, global::ModerationAPI.NewModerateModerateRequestPolicieCrypto, global::ModerationAPI.NewModerateModerateRequestPolicieSexual, global::ModerationAPI.NewModerateModerateRequestPolicieSexualMinors, global::ModerationAPI.NewModerateModerateRequestPolicieProfanity, global::ModerationAPI.NewModerateModerateRequestPolicieViolence, global::ModerationAPI.NewModerateModerateRequestPolicieSelfHarm, global::ModerationAPI.NewModerateModerateRequestPolicieSpam, global::ModerationAPI.NewModerateModerateRequestPolicieLowQualityContent, global::ModerationAPI.NewModerateModerateRequestPolicieFaceDetection, global::ModerationAPI.NewModerateModerateRequestPolicieSelfPromotion, global::ModerationAPI.NewModerateModerateRequestPoliciePolitical, global::ModerationAPI.NewModerateModerateRequestPolicieReligion, global::ModerationAPI.NewModerateModerateRequestPolicieThreat, global::ModerationAPI.NewModerateModerateRequestPolicieSexualSolicitation, global::ModerationAPI.NewModerateModerateRequestPolicieChannelCircumvention, global::ModerationAPI.NewModerateModerateRequestPolicieIllegalTrade, global::ModerationAPI.NewModerateModerateRequestPolicieAlcohol, global::ModerationAPI.NewModerateModerateRequestPolicieDrugs, global::ModerationAPI.NewModerateModerateRequestPolicieGambling, global::ModerationAPI.NewModerateModerateRequestPolicieTobacco, global::ModerationAPI.NewModerateModerateRequestPolicieWeapons, global::ModerationAPI.NewModerateModerateRequestPoliciePromotion, global::ModerationAPI.NewModerateModerateRequestPolicieExtremism, global::ModerationAPI.NewModerateModerateRequestPolicieCodeAbuse, global::ModerationAPI.NewModerateModerateRequestPolicieUnicodeSpoofing, global::ModerationAPI.NewModerateModerateRequestPoliciePiiMasking, global::ModerationAPI.NewModerateModerateRequestPolicieUrlMasking, global::ModerationAPI.NewModerateModerateRequestPolicieUrlRisk, global::ModerationAPI.NewModerateModerateRequestPolicieGuideline>), TypeInfoPropertyName = "NewModerateModerateRequestPolicieGuideline_54567719dd6a6b3a")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.AnyOf<string, object, global::System.Collections.Generic.Dictionary<string, global::ModerationAPI.OneOf<global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentText, global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentImage, global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentVideo, global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentAudio>>>), TypeInfoPropertyName = "NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentAudio_91a38b75dbf4ea1b")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::ModerationAPI.OneOf<global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentText, global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentImage, global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentVideo, global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentAudio>>), TypeInfoPropertyName = "NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentAudio_090383758cc97c36")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.OneOf<global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentText, global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentImage, global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentVideo, global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentAudio>), TypeInfoPropertyName = "NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentAudio_f8254bf745cf9a73")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ModerationAPI.OneOf<global::ModerationAPI.NewModerateModerateResponseInsightSentimentInsight, global::ModerationAPI.NewModerateModerateResponseInsightLanguageInsight, global::ModerationAPI.NewModerateModerateResponseInsightCuriosityInsight, global::ModerationAPI.NewModerateModerateResponseInsightRespectInsight, global::ModerationAPI.NewModerateModerateResponseInsightPersonalStoryInsight, global::ModerationAPI.NewModerateModerateResponseInsightCompassionInsight>>), TypeInfoPropertyName = "NewModerateModerateResponseInsightCompassionInsight_bbc8f2b751f130ff")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.OneOf<global::ModerationAPI.NewModerateModerateResponseInsightSentimentInsight, global::ModerationAPI.NewModerateModerateResponseInsightLanguageInsight, global::ModerationAPI.NewModerateModerateResponseInsightCuriosityInsight, global::ModerationAPI.NewModerateModerateResponseInsightRespectInsight, global::ModerationAPI.NewModerateModerateResponseInsightPersonalStoryInsight, global::ModerationAPI.NewModerateModerateResponseInsightCompassionInsight>), TypeInfoPropertyName = "NewModerateModerateResponseInsightCompassionInsight_b15949f21de9d079")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.OneOf<global::ModerationAPI.QueueItemContentObjectDataText, global::ModerationAPI.QueueItemContentObjectDataImage, global::ModerationAPI.QueueItemContentObjectDataVideo, global::ModerationAPI.QueueItemContentObjectDataAudio>?), TypeInfoPropertyName = "QueueItemContentObjectDataAudio_f7ddcff4010421f0")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.OneOf<global::ModerationAPI.PublicQueueItemContentText, global::ModerationAPI.PublicQueueItemContentImage, global::ModerationAPI.PublicQueueItemContentVideo, global::ModerationAPI.PublicQueueItemContentAudio, global::ModerationAPI.PublicQueueItemContentObject>?), TypeInfoPropertyName = "PublicQueueItemContentObject_0f6ae51d7c9aeddc")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.OneOf<global::ModerationAPI.PublicQueueItemContentObjectDataText, global::ModerationAPI.PublicQueueItemContentObjectDataImage, global::ModerationAPI.PublicQueueItemContentObjectDataVideo, global::ModerationAPI.PublicQueueItemContentObjectDataAudio>?), TypeInfoPropertyName = "PublicQueueItemContentObjectDataAudio_6d0dbf1252fb5aa2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.OneOf<global::ModerationAPI.NewModerateModerateRequestContentText, global::ModerationAPI.NewModerateModerateRequestContentImage, global::ModerationAPI.NewModerateModerateRequestContentVideo, global::ModerationAPI.NewModerateModerateRequestContentAudio, global::ModerationAPI.NewModerateModerateRequestContentObject>?), TypeInfoPropertyName = "NewModerateModerateRequestContentObject_1ce3d97371b2fe4b")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.OneOf<global::ModerationAPI.NewModerateModerateRequestContentObjectDataText, global::ModerationAPI.NewModerateModerateRequestContentObjectDataImage, global::ModerationAPI.NewModerateModerateRequestContentObjectDataVideo, global::ModerationAPI.NewModerateModerateRequestContentObjectDataAudio>?), TypeInfoPropertyName = "NewModerateModerateRequestContentObjectDataAudio_8997c1844e8527ae")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.OneOf<global::ModerationAPI.NewModerateModerateRequestPolicieToxicity, global::ModerationAPI.NewModerateModerateRequestPoliciePersonalInformation, global::ModerationAPI.NewModerateModerateRequestPolicieHate, global::ModerationAPI.NewModerateModerateRequestPolicieIllicit, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitDrugs, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitAlcohol, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitFirearms, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitTobacco, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitGambling, global::ModerationAPI.NewModerateModerateRequestPolicieCannabis, global::ModerationAPI.NewModerateModerateRequestPolicieAdult, global::ModerationAPI.NewModerateModerateRequestPolicieCrypto, global::ModerationAPI.NewModerateModerateRequestPolicieSexual, global::ModerationAPI.NewModerateModerateRequestPolicieSexualMinors, global::ModerationAPI.NewModerateModerateRequestPolicieProfanity, global::ModerationAPI.NewModerateModerateRequestPolicieViolence, global::ModerationAPI.NewModerateModerateRequestPolicieSelfHarm, global::ModerationAPI.NewModerateModerateRequestPolicieSpam, global::ModerationAPI.NewModerateModerateRequestPolicieLowQualityContent, global::ModerationAPI.NewModerateModerateRequestPolicieFaceDetection, global::ModerationAPI.NewModerateModerateRequestPolicieSelfPromotion, global::ModerationAPI.NewModerateModerateRequestPoliciePolitical, global::ModerationAPI.NewModerateModerateRequestPolicieReligion, global::ModerationAPI.NewModerateModerateRequestPolicieThreat, global::ModerationAPI.NewModerateModerateRequestPolicieSexualSolicitation, global::ModerationAPI.NewModerateModerateRequestPolicieChannelCircumvention, global::ModerationAPI.NewModerateModerateRequestPolicieIllegalTrade, global::ModerationAPI.NewModerateModerateRequestPolicieAlcohol, global::ModerationAPI.NewModerateModerateRequestPolicieDrugs, global::ModerationAPI.NewModerateModerateRequestPolicieGambling, global::ModerationAPI.NewModerateModerateRequestPolicieTobacco, global::ModerationAPI.NewModerateModerateRequestPolicieWeapons, global::ModerationAPI.NewModerateModerateRequestPoliciePromotion, global::ModerationAPI.NewModerateModerateRequestPolicieExtremism, global::ModerationAPI.NewModerateModerateRequestPolicieCodeAbuse, global::ModerationAPI.NewModerateModerateRequestPolicieUnicodeSpoofing, global::ModerationAPI.NewModerateModerateRequestPoliciePiiMasking, global::ModerationAPI.NewModerateModerateRequestPolicieUrlMasking, global::ModerationAPI.NewModerateModerateRequestPolicieUrlRisk, global::ModerationAPI.NewModerateModerateRequestPolicieGuideline>?), TypeInfoPropertyName = "NewModerateModerateRequestPolicieGuideline_276ab216136ef869")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.OneOf<global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentText, global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentImage, global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentVideo, global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentAudio>?), TypeInfoPropertyName = "NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentAudio_2070a92914ebe6c9")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.OneOf<global::ModerationAPI.NewModerateModerateResponseInsightSentimentInsight, global::ModerationAPI.NewModerateModerateResponseInsightLanguageInsight, global::ModerationAPI.NewModerateModerateResponseInsightCuriosityInsight, global::ModerationAPI.NewModerateModerateResponseInsightRespectInsight, global::ModerationAPI.NewModerateModerateResponseInsightPersonalStoryInsight, global::ModerationAPI.NewModerateModerateResponseInsightCompassionInsight>?), TypeInfoPropertyName = "NewModerateModerateResponseInsightCompassionInsight_057944cfe90894fb")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.OneOf<global::ModerationAPI.NewModerateModerateRequestPolicieToxicity, global::ModerationAPI.NewModerateModerateRequestPoliciePersonalInformation, global::ModerationAPI.NewModerateModerateRequestPolicieHate, global::ModerationAPI.NewModerateModerateRequestPolicieIllicit, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitDrugs, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitAlcohol, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitFirearms, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitTobacco, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitGambling, global::ModerationAPI.NewModerateModerateRequestPolicieCannabis, global::ModerationAPI.NewModerateModerateRequestPolicieAdult, global::ModerationAPI.NewModerateModerateRequestPolicieCrypto, global::ModerationAPI.NewModerateModerateRequestPolicieSexual, global::ModerationAPI.NewModerateModerateRequestPolicieSexualMinors, global::ModerationAPI.NewModerateModerateRequestPolicieProfanity, global::ModerationAPI.NewModerateModerateRequestPolicieViolence, global::ModerationAPI.NewModerateModerateRequestPolicieSelfHarm, global::ModerationAPI.NewModerateModerateRequestPolicieSpam, global::ModerationAPI.NewModerateModerateRequestPolicieLowQualityContent, global::ModerationAPI.NewModerateModerateRequestPolicieFaceDetection, global::ModerationAPI.NewModerateModerateRequestPolicieSelfPromotion, global::ModerationAPI.NewModerateModerateRequestPoliciePolitical, global::ModerationAPI.NewModerateModerateRequestPolicieReligion, global::ModerationAPI.NewModerateModerateRequestPolicieThreat, global::ModerationAPI.NewModerateModerateRequestPolicieSexualSolicitation, global::ModerationAPI.NewModerateModerateRequestPolicieChannelCircumvention, global::ModerationAPI.NewModerateModerateRequestPolicieIllegalTrade, global::ModerationAPI.NewModerateModerateRequestPolicieAlcohol, global::ModerationAPI.NewModerateModerateRequestPolicieDrugs, global::ModerationAPI.NewModerateModerateRequestPolicieGambling, global::ModerationAPI.NewModerateModerateRequestPolicieTobacco, global::ModerationAPI.NewModerateModerateRequestPolicieWeapons, global::ModerationAPI.NewModerateModerateRequestPoliciePromotion, global::ModerationAPI.NewModerateModerateRequestPolicieExtremism, global::ModerationAPI.NewModerateModerateRequestPolicieCodeAbuse, global::ModerationAPI.NewModerateModerateRequestPolicieUnicodeSpoofing, global::ModerationAPI.NewModerateModerateRequestPoliciePiiMasking, global::ModerationAPI.NewModerateModerateRequestPolicieUrlMasking, global::ModerationAPI.NewModerateModerateRequestPolicieUrlRisk, global::ModerationAPI.NewModerateModerateRequestPolicieGuideline>>), TypeInfoPropertyName = "NewModerateModerateRequestPolicieGuideline_81e602994a082871")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.OneOf<global::ModerationAPI.NewModerateModerateResponseInsightSentimentInsight, global::ModerationAPI.NewModerateModerateResponseInsightLanguageInsight, global::ModerationAPI.NewModerateModerateResponseInsightCuriosityInsight, global::ModerationAPI.NewModerateModerateResponseInsightRespectInsight, global::ModerationAPI.NewModerateModerateResponseInsightPersonalStoryInsight, global::ModerationAPI.NewModerateModerateResponseInsightCompassionInsight>>), TypeInfoPropertyName = "NewModerateModerateResponseInsightCompassionInsight_25e4d46d685d828b")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateRequestContentText))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateRequestContentImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateRequestContentVideo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateRequestContentAudio))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateRequestContentObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateRequestContentObjectDataText))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateRequestContentObjectDataImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateRequestContentObjectDataVideo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateRequestContentObjectDataAudio))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateRequestMetaType), TypeInfoPropertyName = "NewModerateModerateRequestMetaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateRequestCampaign))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateRequestClientAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateRequestClientActionAction), TypeInfoPropertyName = "NewModerateModerateRequestClientActionAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateRequestClientActionBehavior), TypeInfoPropertyName = "NewModerateModerateRequestClientActionBehavior2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateResponseCampaign))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateResponseCampaignStatus), TypeInfoPropertyName = "NewModerateModerateResponseCampaignStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateResponseCampaignBrandStatus), TypeInfoPropertyName = "NewModerateModerateResponseCampaignBrandStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateResponseCampaignDrift), TypeInfoPropertyName = "NewModerateModerateResponseCampaignDrift2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateResponseCampaignCluster))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateResponseCampaignClusterStatus), TypeInfoPropertyName = "NewModerateModerateResponseCampaignClusterStatus2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.PublicAuthorStatus?), TypeInfoPropertyName = "NullablePublicAuthorStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.QueueItemStatus?), TypeInfoPropertyName = "NullableQueueItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ProjectGlobalFlaggingMode?), TypeInfoPropertyName = "NullableProjectGlobalFlaggingMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ProjectWithKeyGlobalFlaggingMode?), TypeInfoPropertyName = "NullableProjectWithKeyGlobalFlaggingMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ChannelContentType?), TypeInfoPropertyName = "NullableChannelContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ChannelFlaggingMode?), TypeInfoPropertyName = "NullableChannelFlaggingMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ChannelTranscriptionQuality?), TypeInfoPropertyName = "NullableChannelTranscriptionQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.PublicQueueItemClientActionAction?), TypeInfoPropertyName = "NullablePublicQueueItemClientActionAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.PublicQueueItemClientActionBehavior?), TypeInfoPropertyName = "NullablePublicQueueItemClientActionBehavior2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.PublicQueueItemMetaType?), TypeInfoPropertyName = "NullablePublicQueueItemMetaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.WebhookEvent?), TypeInfoPropertyName = "NullableWebhookEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.WebhookEventDiscriminatorType?), TypeInfoPropertyName = "NullableWebhookEventDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.VoiceStartFrameEvent?), TypeInfoPropertyName = "NullableVoiceStartFrameEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.VoiceStartFrameTrackName?), TypeInfoPropertyName = "NullableVoiceStartFrameTrackName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.VoiceMediaFrameEvent?), TypeInfoPropertyName = "NullableVoiceMediaFrameEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.VoiceMediaFrameMediaTrack?), TypeInfoPropertyName = "NullableVoiceMediaFrameMediaTrack2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.VoiceStopFrameEvent?), TypeInfoPropertyName = "NullableVoiceStopFrameEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.VoiceSessionStartedEvent?), TypeInfoPropertyName = "NullableVoiceSessionStartedEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.VoiceUtteranceFinalEvent?), TypeInfoPropertyName = "NullableVoiceUtteranceFinalEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.VoiceUtteranceFinalTrack?), TypeInfoPropertyName = "NullableVoiceUtteranceFinalTrack2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.VoiceUtteranceFinalRecommendationAction?), TypeInfoPropertyName = "NullableVoiceUtteranceFinalRecommendationAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.VoiceSessionEndedEvent?), TypeInfoPropertyName = "NullableVoiceSessionEndedEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.AnyOf<string, double?>?), TypeInfoPropertyName = "NullableAnyOfStringDouble2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.BadRequestErrorCode?), TypeInfoPropertyName = "NullableBadRequestErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.AuthenticationErrorCode?), TypeInfoPropertyName = "NullableAuthenticationErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.PermissionDeniedErrorCode?), TypeInfoPropertyName = "NullablePermissionDeniedErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NotFoundErrorCode?), TypeInfoPropertyName = "NullableNotFoundErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ConflictErrorCode?), TypeInfoPropertyName = "NullableConflictErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.UnprocessableEntityErrorCode?), TypeInfoPropertyName = "NullableUnprocessableEntityErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.RateLimitErrorCode?), TypeInfoPropertyName = "NullableRateLimitErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.InternalServerErrorCode?), TypeInfoPropertyName = "NullableInternalServerErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.CreateFeedbackRequestType?), TypeInfoPropertyName = "NullableCreateFeedbackRequestType2")]
    internal sealed partial class SourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }

    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull
    )]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::ModerationAPI.OneOf<global::ModerationAPI.QueueItemContentObjectDataText, global::ModerationAPI.QueueItemContentObjectDataImage, global::ModerationAPI.QueueItemContentObjectDataVideo, global::ModerationAPI.QueueItemContentObjectDataAudio>>), TypeInfoPropertyName = "QueueItemContentObjectDataAudio_8553da6e2cecbbbb")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.OneOf<global::ModerationAPI.QueueItemContentObjectDataText, global::ModerationAPI.QueueItemContentObjectDataImage, global::ModerationAPI.QueueItemContentObjectDataVideo, global::ModerationAPI.QueueItemContentObjectDataAudio>), TypeInfoPropertyName = "QueueItemContentObjectDataAudio_aa3397d2851ed486")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.OneOf<global::ModerationAPI.PublicQueueItemContentText, global::ModerationAPI.PublicQueueItemContentImage, global::ModerationAPI.PublicQueueItemContentVideo, global::ModerationAPI.PublicQueueItemContentAudio, global::ModerationAPI.PublicQueueItemContentObject>), TypeInfoPropertyName = "PublicQueueItemContentObject_a5b10a16560a2a90")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::ModerationAPI.OneOf<global::ModerationAPI.PublicQueueItemContentObjectDataText, global::ModerationAPI.PublicQueueItemContentObjectDataImage, global::ModerationAPI.PublicQueueItemContentObjectDataVideo, global::ModerationAPI.PublicQueueItemContentObjectDataAudio>>), TypeInfoPropertyName = "PublicQueueItemContentObjectDataAudio_9fba358e4ede806b")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.OneOf<global::ModerationAPI.PublicQueueItemContentObjectDataText, global::ModerationAPI.PublicQueueItemContentObjectDataImage, global::ModerationAPI.PublicQueueItemContentObjectDataVideo, global::ModerationAPI.PublicQueueItemContentObjectDataAudio>), TypeInfoPropertyName = "PublicQueueItemContentObjectDataAudio_f4551668b35ad437")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.OneOf<global::ModerationAPI.NewModerateModerateRequestContentText, global::ModerationAPI.NewModerateModerateRequestContentImage, global::ModerationAPI.NewModerateModerateRequestContentVideo, global::ModerationAPI.NewModerateModerateRequestContentAudio, global::ModerationAPI.NewModerateModerateRequestContentObject>), TypeInfoPropertyName = "NewModerateModerateRequestContentObject_c77db83f9aa266b5")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::ModerationAPI.OneOf<global::ModerationAPI.NewModerateModerateRequestContentObjectDataText, global::ModerationAPI.NewModerateModerateRequestContentObjectDataImage, global::ModerationAPI.NewModerateModerateRequestContentObjectDataVideo, global::ModerationAPI.NewModerateModerateRequestContentObjectDataAudio>>), TypeInfoPropertyName = "NewModerateModerateRequestContentObjectDataAudio_3ecd4df47b6afadc")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.OneOf<global::ModerationAPI.NewModerateModerateRequestContentObjectDataText, global::ModerationAPI.NewModerateModerateRequestContentObjectDataImage, global::ModerationAPI.NewModerateModerateRequestContentObjectDataVideo, global::ModerationAPI.NewModerateModerateRequestContentObjectDataAudio>), TypeInfoPropertyName = "NewModerateModerateRequestContentObjectDataAudio_a7076b050589a568")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ModerationAPI.OneOf<global::ModerationAPI.NewModerateModerateRequestPolicieToxicity, global::ModerationAPI.NewModerateModerateRequestPoliciePersonalInformation, global::ModerationAPI.NewModerateModerateRequestPolicieHate, global::ModerationAPI.NewModerateModerateRequestPolicieIllicit, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitDrugs, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitAlcohol, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitFirearms, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitTobacco, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitGambling, global::ModerationAPI.NewModerateModerateRequestPolicieCannabis, global::ModerationAPI.NewModerateModerateRequestPolicieAdult, global::ModerationAPI.NewModerateModerateRequestPolicieCrypto, global::ModerationAPI.NewModerateModerateRequestPolicieSexual, global::ModerationAPI.NewModerateModerateRequestPolicieSexualMinors, global::ModerationAPI.NewModerateModerateRequestPolicieProfanity, global::ModerationAPI.NewModerateModerateRequestPolicieViolence, global::ModerationAPI.NewModerateModerateRequestPolicieSelfHarm, global::ModerationAPI.NewModerateModerateRequestPolicieSpam, global::ModerationAPI.NewModerateModerateRequestPolicieLowQualityContent, global::ModerationAPI.NewModerateModerateRequestPolicieFaceDetection, global::ModerationAPI.NewModerateModerateRequestPolicieSelfPromotion, global::ModerationAPI.NewModerateModerateRequestPoliciePolitical, global::ModerationAPI.NewModerateModerateRequestPolicieReligion, global::ModerationAPI.NewModerateModerateRequestPolicieThreat, global::ModerationAPI.NewModerateModerateRequestPolicieSexualSolicitation, global::ModerationAPI.NewModerateModerateRequestPolicieChannelCircumvention, global::ModerationAPI.NewModerateModerateRequestPolicieIllegalTrade, global::ModerationAPI.NewModerateModerateRequestPolicieAlcohol, global::ModerationAPI.NewModerateModerateRequestPolicieDrugs, global::ModerationAPI.NewModerateModerateRequestPolicieGambling, global::ModerationAPI.NewModerateModerateRequestPolicieTobacco, global::ModerationAPI.NewModerateModerateRequestPolicieWeapons, global::ModerationAPI.NewModerateModerateRequestPoliciePromotion, global::ModerationAPI.NewModerateModerateRequestPolicieExtremism, global::ModerationAPI.NewModerateModerateRequestPolicieCodeAbuse, global::ModerationAPI.NewModerateModerateRequestPolicieUnicodeSpoofing, global::ModerationAPI.NewModerateModerateRequestPoliciePiiMasking, global::ModerationAPI.NewModerateModerateRequestPolicieUrlMasking, global::ModerationAPI.NewModerateModerateRequestPolicieUrlRisk, global::ModerationAPI.NewModerateModerateRequestPolicieGuideline>>), TypeInfoPropertyName = "NewModerateModerateRequestPolicieGuideline_4f41f5791e0537bc")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.OneOf<global::ModerationAPI.NewModerateModerateRequestPolicieToxicity, global::ModerationAPI.NewModerateModerateRequestPoliciePersonalInformation, global::ModerationAPI.NewModerateModerateRequestPolicieHate, global::ModerationAPI.NewModerateModerateRequestPolicieIllicit, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitDrugs, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitAlcohol, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitFirearms, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitTobacco, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitGambling, global::ModerationAPI.NewModerateModerateRequestPolicieCannabis, global::ModerationAPI.NewModerateModerateRequestPolicieAdult, global::ModerationAPI.NewModerateModerateRequestPolicieCrypto, global::ModerationAPI.NewModerateModerateRequestPolicieSexual, global::ModerationAPI.NewModerateModerateRequestPolicieSexualMinors, global::ModerationAPI.NewModerateModerateRequestPolicieProfanity, global::ModerationAPI.NewModerateModerateRequestPolicieViolence, global::ModerationAPI.NewModerateModerateRequestPolicieSelfHarm, global::ModerationAPI.NewModerateModerateRequestPolicieSpam, global::ModerationAPI.NewModerateModerateRequestPolicieLowQualityContent, global::ModerationAPI.NewModerateModerateRequestPolicieFaceDetection, global::ModerationAPI.NewModerateModerateRequestPolicieSelfPromotion, global::ModerationAPI.NewModerateModerateRequestPoliciePolitical, global::ModerationAPI.NewModerateModerateRequestPolicieReligion, global::ModerationAPI.NewModerateModerateRequestPolicieThreat, global::ModerationAPI.NewModerateModerateRequestPolicieSexualSolicitation, global::ModerationAPI.NewModerateModerateRequestPolicieChannelCircumvention, global::ModerationAPI.NewModerateModerateRequestPolicieIllegalTrade, global::ModerationAPI.NewModerateModerateRequestPolicieAlcohol, global::ModerationAPI.NewModerateModerateRequestPolicieDrugs, global::ModerationAPI.NewModerateModerateRequestPolicieGambling, global::ModerationAPI.NewModerateModerateRequestPolicieTobacco, global::ModerationAPI.NewModerateModerateRequestPolicieWeapons, global::ModerationAPI.NewModerateModerateRequestPoliciePromotion, global::ModerationAPI.NewModerateModerateRequestPolicieExtremism, global::ModerationAPI.NewModerateModerateRequestPolicieCodeAbuse, global::ModerationAPI.NewModerateModerateRequestPolicieUnicodeSpoofing, global::ModerationAPI.NewModerateModerateRequestPoliciePiiMasking, global::ModerationAPI.NewModerateModerateRequestPolicieUrlMasking, global::ModerationAPI.NewModerateModerateRequestPolicieUrlRisk, global::ModerationAPI.NewModerateModerateRequestPolicieGuideline>), TypeInfoPropertyName = "NewModerateModerateRequestPolicieGuideline_54567719dd6a6b3a")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.AnyOf<string, object, global::System.Collections.Generic.Dictionary<string, global::ModerationAPI.OneOf<global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentText, global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentImage, global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentVideo, global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentAudio>>>), TypeInfoPropertyName = "NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentAudio_91a38b75dbf4ea1b")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::ModerationAPI.OneOf<global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentText, global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentImage, global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentVideo, global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentAudio>>), TypeInfoPropertyName = "NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentAudio_090383758cc97c36")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.OneOf<global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentText, global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentImage, global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentVideo, global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentAudio>), TypeInfoPropertyName = "NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentAudio_f8254bf745cf9a73")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ModerationAPI.OneOf<global::ModerationAPI.NewModerateModerateResponseInsightSentimentInsight, global::ModerationAPI.NewModerateModerateResponseInsightLanguageInsight, global::ModerationAPI.NewModerateModerateResponseInsightCuriosityInsight, global::ModerationAPI.NewModerateModerateResponseInsightRespectInsight, global::ModerationAPI.NewModerateModerateResponseInsightPersonalStoryInsight, global::ModerationAPI.NewModerateModerateResponseInsightCompassionInsight>>), TypeInfoPropertyName = "NewModerateModerateResponseInsightCompassionInsight_bbc8f2b751f130ff")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.OneOf<global::ModerationAPI.NewModerateModerateResponseInsightSentimentInsight, global::ModerationAPI.NewModerateModerateResponseInsightLanguageInsight, global::ModerationAPI.NewModerateModerateResponseInsightCuriosityInsight, global::ModerationAPI.NewModerateModerateResponseInsightRespectInsight, global::ModerationAPI.NewModerateModerateResponseInsightPersonalStoryInsight, global::ModerationAPI.NewModerateModerateResponseInsightCompassionInsight>), TypeInfoPropertyName = "NewModerateModerateResponseInsightCompassionInsight_b15949f21de9d079")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.OneOf<global::ModerationAPI.QueueItemContentObjectDataText, global::ModerationAPI.QueueItemContentObjectDataImage, global::ModerationAPI.QueueItemContentObjectDataVideo, global::ModerationAPI.QueueItemContentObjectDataAudio>?), TypeInfoPropertyName = "QueueItemContentObjectDataAudio_f7ddcff4010421f0")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.OneOf<global::ModerationAPI.PublicQueueItemContentText, global::ModerationAPI.PublicQueueItemContentImage, global::ModerationAPI.PublicQueueItemContentVideo, global::ModerationAPI.PublicQueueItemContentAudio, global::ModerationAPI.PublicQueueItemContentObject>?), TypeInfoPropertyName = "PublicQueueItemContentObject_0f6ae51d7c9aeddc")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.OneOf<global::ModerationAPI.PublicQueueItemContentObjectDataText, global::ModerationAPI.PublicQueueItemContentObjectDataImage, global::ModerationAPI.PublicQueueItemContentObjectDataVideo, global::ModerationAPI.PublicQueueItemContentObjectDataAudio>?), TypeInfoPropertyName = "PublicQueueItemContentObjectDataAudio_6d0dbf1252fb5aa2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.OneOf<global::ModerationAPI.NewModerateModerateRequestContentText, global::ModerationAPI.NewModerateModerateRequestContentImage, global::ModerationAPI.NewModerateModerateRequestContentVideo, global::ModerationAPI.NewModerateModerateRequestContentAudio, global::ModerationAPI.NewModerateModerateRequestContentObject>?), TypeInfoPropertyName = "NewModerateModerateRequestContentObject_1ce3d97371b2fe4b")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.OneOf<global::ModerationAPI.NewModerateModerateRequestContentObjectDataText, global::ModerationAPI.NewModerateModerateRequestContentObjectDataImage, global::ModerationAPI.NewModerateModerateRequestContentObjectDataVideo, global::ModerationAPI.NewModerateModerateRequestContentObjectDataAudio>?), TypeInfoPropertyName = "NewModerateModerateRequestContentObjectDataAudio_8997c1844e8527ae")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.OneOf<global::ModerationAPI.NewModerateModerateRequestPolicieToxicity, global::ModerationAPI.NewModerateModerateRequestPoliciePersonalInformation, global::ModerationAPI.NewModerateModerateRequestPolicieHate, global::ModerationAPI.NewModerateModerateRequestPolicieIllicit, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitDrugs, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitAlcohol, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitFirearms, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitTobacco, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitGambling, global::ModerationAPI.NewModerateModerateRequestPolicieCannabis, global::ModerationAPI.NewModerateModerateRequestPolicieAdult, global::ModerationAPI.NewModerateModerateRequestPolicieCrypto, global::ModerationAPI.NewModerateModerateRequestPolicieSexual, global::ModerationAPI.NewModerateModerateRequestPolicieSexualMinors, global::ModerationAPI.NewModerateModerateRequestPolicieProfanity, global::ModerationAPI.NewModerateModerateRequestPolicieViolence, global::ModerationAPI.NewModerateModerateRequestPolicieSelfHarm, global::ModerationAPI.NewModerateModerateRequestPolicieSpam, global::ModerationAPI.NewModerateModerateRequestPolicieLowQualityContent, global::ModerationAPI.NewModerateModerateRequestPolicieFaceDetection, global::ModerationAPI.NewModerateModerateRequestPolicieSelfPromotion, global::ModerationAPI.NewModerateModerateRequestPoliciePolitical, global::ModerationAPI.NewModerateModerateRequestPolicieReligion, global::ModerationAPI.NewModerateModerateRequestPolicieThreat, global::ModerationAPI.NewModerateModerateRequestPolicieSexualSolicitation, global::ModerationAPI.NewModerateModerateRequestPolicieChannelCircumvention, global::ModerationAPI.NewModerateModerateRequestPolicieIllegalTrade, global::ModerationAPI.NewModerateModerateRequestPolicieAlcohol, global::ModerationAPI.NewModerateModerateRequestPolicieDrugs, global::ModerationAPI.NewModerateModerateRequestPolicieGambling, global::ModerationAPI.NewModerateModerateRequestPolicieTobacco, global::ModerationAPI.NewModerateModerateRequestPolicieWeapons, global::ModerationAPI.NewModerateModerateRequestPoliciePromotion, global::ModerationAPI.NewModerateModerateRequestPolicieExtremism, global::ModerationAPI.NewModerateModerateRequestPolicieCodeAbuse, global::ModerationAPI.NewModerateModerateRequestPolicieUnicodeSpoofing, global::ModerationAPI.NewModerateModerateRequestPoliciePiiMasking, global::ModerationAPI.NewModerateModerateRequestPolicieUrlMasking, global::ModerationAPI.NewModerateModerateRequestPolicieUrlRisk, global::ModerationAPI.NewModerateModerateRequestPolicieGuideline>?), TypeInfoPropertyName = "NewModerateModerateRequestPolicieGuideline_276ab216136ef869")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.OneOf<global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentText, global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentImage, global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentVideo, global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentAudio>?), TypeInfoPropertyName = "NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentAudio_2070a92914ebe6c9")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.OneOf<global::ModerationAPI.NewModerateModerateResponseInsightSentimentInsight, global::ModerationAPI.NewModerateModerateResponseInsightLanguageInsight, global::ModerationAPI.NewModerateModerateResponseInsightCuriosityInsight, global::ModerationAPI.NewModerateModerateResponseInsightRespectInsight, global::ModerationAPI.NewModerateModerateResponseInsightPersonalStoryInsight, global::ModerationAPI.NewModerateModerateResponseInsightCompassionInsight>?), TypeInfoPropertyName = "NewModerateModerateResponseInsightCompassionInsight_057944cfe90894fb")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.OneOf<global::ModerationAPI.NewModerateModerateRequestPolicieToxicity, global::ModerationAPI.NewModerateModerateRequestPoliciePersonalInformation, global::ModerationAPI.NewModerateModerateRequestPolicieHate, global::ModerationAPI.NewModerateModerateRequestPolicieIllicit, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitDrugs, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitAlcohol, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitFirearms, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitTobacco, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitGambling, global::ModerationAPI.NewModerateModerateRequestPolicieCannabis, global::ModerationAPI.NewModerateModerateRequestPolicieAdult, global::ModerationAPI.NewModerateModerateRequestPolicieCrypto, global::ModerationAPI.NewModerateModerateRequestPolicieSexual, global::ModerationAPI.NewModerateModerateRequestPolicieSexualMinors, global::ModerationAPI.NewModerateModerateRequestPolicieProfanity, global::ModerationAPI.NewModerateModerateRequestPolicieViolence, global::ModerationAPI.NewModerateModerateRequestPolicieSelfHarm, global::ModerationAPI.NewModerateModerateRequestPolicieSpam, global::ModerationAPI.NewModerateModerateRequestPolicieLowQualityContent, global::ModerationAPI.NewModerateModerateRequestPolicieFaceDetection, global::ModerationAPI.NewModerateModerateRequestPolicieSelfPromotion, global::ModerationAPI.NewModerateModerateRequestPoliciePolitical, global::ModerationAPI.NewModerateModerateRequestPolicieReligion, global::ModerationAPI.NewModerateModerateRequestPolicieThreat, global::ModerationAPI.NewModerateModerateRequestPolicieSexualSolicitation, global::ModerationAPI.NewModerateModerateRequestPolicieChannelCircumvention, global::ModerationAPI.NewModerateModerateRequestPolicieIllegalTrade, global::ModerationAPI.NewModerateModerateRequestPolicieAlcohol, global::ModerationAPI.NewModerateModerateRequestPolicieDrugs, global::ModerationAPI.NewModerateModerateRequestPolicieGambling, global::ModerationAPI.NewModerateModerateRequestPolicieTobacco, global::ModerationAPI.NewModerateModerateRequestPolicieWeapons, global::ModerationAPI.NewModerateModerateRequestPoliciePromotion, global::ModerationAPI.NewModerateModerateRequestPolicieExtremism, global::ModerationAPI.NewModerateModerateRequestPolicieCodeAbuse, global::ModerationAPI.NewModerateModerateRequestPolicieUnicodeSpoofing, global::ModerationAPI.NewModerateModerateRequestPoliciePiiMasking, global::ModerationAPI.NewModerateModerateRequestPolicieUrlMasking, global::ModerationAPI.NewModerateModerateRequestPolicieUrlRisk, global::ModerationAPI.NewModerateModerateRequestPolicieGuideline>>), TypeInfoPropertyName = "NewModerateModerateRequestPolicieGuideline_81e602994a082871")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.OneOf<global::ModerationAPI.NewModerateModerateResponseInsightSentimentInsight, global::ModerationAPI.NewModerateModerateResponseInsightLanguageInsight, global::ModerationAPI.NewModerateModerateResponseInsightCuriosityInsight, global::ModerationAPI.NewModerateModerateResponseInsightRespectInsight, global::ModerationAPI.NewModerateModerateResponseInsightPersonalStoryInsight, global::ModerationAPI.NewModerateModerateResponseInsightCompassionInsight>>), TypeInfoPropertyName = "NewModerateModerateResponseInsightCompassionInsight_25e4d46d685d828b")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.CreateFeedbackRequestSource?), TypeInfoPropertyName = "NullableCreateFeedbackRequestSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsCreateRequestType?), TypeInfoPropertyName = "NullableActionsCreateRequestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsCreateRequestQueueBehaviour?), TypeInfoPropertyName = "NullableActionsCreateRequestQueueBehaviour2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsCreateRequestPosition?), TypeInfoPropertyName = "NullableActionsCreateRequestPosition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsUpdateRequestType?), TypeInfoPropertyName = "NullableActionsUpdateRequestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsUpdateRequestQueueBehaviour?), TypeInfoPropertyName = "NullableActionsUpdateRequestQueueBehaviour2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsUpdateRequestPosition?), TypeInfoPropertyName = "NullableActionsUpdateRequestPosition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.WebhooksPublicCreateRequestEventType?), TypeInfoPropertyName = "NullableWebhooksPublicCreateRequestEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.WebhooksPublicUpdateRequestEventType?), TypeInfoPropertyName = "NullableWebhooksPublicUpdateRequestEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateRequestMetaType?), TypeInfoPropertyName = "NullableNewModerateModerateRequestMetaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateRequestClientActionAction?), TypeInfoPropertyName = "NullableNewModerateModerateRequestClientActionAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateRequestClientActionBehavior?), TypeInfoPropertyName = "NullableNewModerateModerateRequestClientActionBehavior2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateRequestPolicieFaceDetectionComparator?), TypeInfoPropertyName = "NullableNewModerateModerateRequestPolicieFaceDetectionComparator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ManagementProjectsUpdateRequestGlobalFlaggingMode?), TypeInfoPropertyName = "NullableManagementProjectsUpdateRequestGlobalFlaggingMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ManagementChannelsCreateRequestContentType?), TypeInfoPropertyName = "NullableManagementChannelsCreateRequestContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ManagementChannelsUpdateRequestContentType?), TypeInfoPropertyName = "NullableManagementChannelsUpdateRequestContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ManagementChannelsUpdateRequestFlaggingMode?), TypeInfoPropertyName = "NullableManagementChannelsUpdateRequestFlaggingMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ManagementChannelsUpdateRequestTranscriptionQuality?), TypeInfoPropertyName = "NullableManagementChannelsUpdateRequestTranscriptionQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.GetAnalyticsSummaryRange?), TypeInfoPropertyName = "NullableGetAnalyticsSummaryRange2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.GetAnalyticsPoliciesRange?), TypeInfoPropertyName = "NullableGetAnalyticsPoliciesRange2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.GetAnalyticsAuthorsRange?), TypeInfoPropertyName = "NullableGetAnalyticsAuthorsRange2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.GetAnalyticsChannelsRange?), TypeInfoPropertyName = "NullableGetAnalyticsChannelsRange2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.GetAnalyticsVolumesRange?), TypeInfoPropertyName = "NullableGetAnalyticsVolumesRange2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.GetAnalyticsAutomationRange?), TypeInfoPropertyName = "NullableGetAnalyticsAutomationRange2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.AuthorOpenListAuthorsSortBy?), TypeInfoPropertyName = "NullableAuthorOpenListAuthorsSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.AuthorOpenListAuthorsSortDirection?), TypeInfoPropertyName = "NullableAuthorOpenListAuthorsSortDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.QueueViewOpenGetItemsSort?), TypeInfoPropertyName = "NullableQueueViewOpenGetItemsSort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.GetAnalyticsSummaryResponseRange?), TypeInfoPropertyName = "NullableGetAnalyticsSummaryResponseRange2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.GetAnalyticsPoliciesResponseRange?), TypeInfoPropertyName = "NullableGetAnalyticsPoliciesResponseRange2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.GetAnalyticsAuthorsResponseRange?), TypeInfoPropertyName = "NullableGetAnalyticsAuthorsResponseRange2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.GetAnalyticsChannelsResponseRange?), TypeInfoPropertyName = "NullableGetAnalyticsChannelsResponseRange2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.GetAnalyticsVolumesResponseRange?), TypeInfoPropertyName = "NullableGetAnalyticsVolumesResponseRange2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.GetAnalyticsVolumesResponseBucket?), TypeInfoPropertyName = "NullableGetAnalyticsVolumesResponseBucket2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.GetAnalyticsAutomationResponseRange?), TypeInfoPropertyName = "NullableGetAnalyticsAutomationResponseRange2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.QueueViewOpenUnresolveItemResponseStatus?), TypeInfoPropertyName = "NullableQueueViewOpenUnresolveItemResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsListResponseDataItemType?), TypeInfoPropertyName = "NullableActionsListResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsListResponseDataItemQueueBehaviour?), TypeInfoPropertyName = "NullableActionsListResponseDataItemQueueBehaviour2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsListResponseDataItemPosition?), TypeInfoPropertyName = "NullableActionsListResponseDataItemPosition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsCreateResponseType?), TypeInfoPropertyName = "NullableActionsCreateResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsCreateResponseQueueBehaviour?), TypeInfoPropertyName = "NullableActionsCreateResponseQueueBehaviour2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsCreateResponsePosition?), TypeInfoPropertyName = "NullableActionsCreateResponsePosition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsGetResponseType?), TypeInfoPropertyName = "NullableActionsGetResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsGetResponseQueueBehaviour?), TypeInfoPropertyName = "NullableActionsGetResponseQueueBehaviour2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsGetResponsePosition?), TypeInfoPropertyName = "NullableActionsGetResponsePosition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsUpdateResponseType?), TypeInfoPropertyName = "NullableActionsUpdateResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsUpdateResponseQueueBehaviour?), TypeInfoPropertyName = "NullableActionsUpdateResponseQueueBehaviour2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsUpdateResponsePosition?), TypeInfoPropertyName = "NullableActionsUpdateResponsePosition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.WebhooksPublicListResponseDataItemEventType?), TypeInfoPropertyName = "NullableWebhooksPublicListResponseDataItemEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.WebhooksPublicListResponseDataItemPayloadVersion?), TypeInfoPropertyName = "NullableWebhooksPublicListResponseDataItemPayloadVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.WebhooksPublicCreateResponseEventType?), TypeInfoPropertyName = "NullableWebhooksPublicCreateResponseEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.WebhooksPublicCreateResponsePayloadVersion?), TypeInfoPropertyName = "NullableWebhooksPublicCreateResponsePayloadVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.WebhooksPublicGetResponseEventType?), TypeInfoPropertyName = "NullableWebhooksPublicGetResponseEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.WebhooksPublicGetResponsePayloadVersion?), TypeInfoPropertyName = "NullableWebhooksPublicGetResponsePayloadVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.WebhooksPublicUpdateResponseEventType?), TypeInfoPropertyName = "NullableWebhooksPublicUpdateResponseEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.WebhooksPublicUpdateResponsePayloadVersion?), TypeInfoPropertyName = "NullableWebhooksPublicUpdateResponsePayloadVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateResponseAuthorStatus?), TypeInfoPropertyName = "NullableNewModerateModerateResponseAuthorStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateResponseRecommendationAction?), TypeInfoPropertyName = "NullableNewModerateModerateResponseRecommendationAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.AnyOf<global::ModerationAPI.NewModerateModerateResponseRecommendationReasonCode?, string>?), TypeInfoPropertyName = "NullableAnyOfNewModerateModerateResponseRecommendationReasonCodeString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateResponseRecommendationReasonCode?), TypeInfoPropertyName = "NullableNewModerateModerateResponseRecommendationReasonCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateResponseCasebookVerdict?), TypeInfoPropertyName = "NullableNewModerateModerateResponseCasebookVerdict2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateResponseCampaignStatus?), TypeInfoPropertyName = "NullableNewModerateModerateResponseCampaignStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateResponseCampaignBrandStatus?), TypeInfoPropertyName = "NullableNewModerateModerateResponseCampaignBrandStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateResponseCampaignDrift?), TypeInfoPropertyName = "NullableNewModerateModerateResponseCampaignDrift2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateResponseCampaignClusterStatus?), TypeInfoPropertyName = "NullableNewModerateModerateResponseCampaignClusterStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.OneOf<global::ModerationAPI.NewModerateModerateResponsePolicieClassifierOutput, global::ModerationAPI.NewModerateModerateResponsePolicieEntityMatcherOutput>?), TypeInfoPropertyName = "NullableOneOfNewModerateModerateResponsePolicieClassifierOutputNewModerateModerateResponsePolicieEntityMatcherOutput2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateResponsePolicieEntityMatcherOutputMatcheSignalsBrandImpersonationMethod?), TypeInfoPropertyName = "NullableNewModerateModerateResponsePolicieEntityMatcherOutputMatcheSignalsBrandImpersonationMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateResponseInsightSentimentInsightValue?), TypeInfoPropertyName = "NullableNewModerateModerateResponseInsightSentimentInsightValue2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NewModerateModerateResponseMetaStatus?), TypeInfoPropertyName = "NullableNewModerateModerateResponseMetaStatus2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.NewModerateModerateResponseError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.Project>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.Channel>))]
    internal sealed partial class SourceGenerationContextChunk1 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContext Default { get; } = new(DefaultOptions);

        private SourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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

                internal static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::ModerationAPI.JsonConverters.WebhookEventJsonConverter());
            options.Converters.Add(new global::ModerationAPI.JsonConverters.OneOfJsonConverter<global::ModerationAPI.QueueItemContentText, global::ModerationAPI.QueueItemContentImage, global::ModerationAPI.QueueItemContentVideo, global::ModerationAPI.QueueItemContentAudio, global::ModerationAPI.QueueItemContentObject>());
            options.Converters.Add(new global::ModerationAPI.JsonConverters.OneOfJsonConverter<global::ModerationAPI.QueueItemContentObjectDataText, global::ModerationAPI.QueueItemContentObjectDataImage, global::ModerationAPI.QueueItemContentObjectDataVideo, global::ModerationAPI.QueueItemContentObjectDataAudio>());
            options.Converters.Add(new global::ModerationAPI.JsonConverters.OneOfJsonConverter<global::ModerationAPI.PublicQueueItemContentText, global::ModerationAPI.PublicQueueItemContentImage, global::ModerationAPI.PublicQueueItemContentVideo, global::ModerationAPI.PublicQueueItemContentAudio, global::ModerationAPI.PublicQueueItemContentObject>());
            options.Converters.Add(new global::ModerationAPI.JsonConverters.OneOfJsonConverter<global::ModerationAPI.PublicQueueItemContentObjectDataText, global::ModerationAPI.PublicQueueItemContentObjectDataImage, global::ModerationAPI.PublicQueueItemContentObjectDataVideo, global::ModerationAPI.PublicQueueItemContentObjectDataAudio>());
            options.Converters.Add(new global::ModerationAPI.JsonConverters.AnyOfJsonConverter<string, double?>());
            options.Converters.Add(new global::ModerationAPI.JsonConverters.OneOfJsonConverter<global::ModerationAPI.NewModerateModerateRequestContentText, global::ModerationAPI.NewModerateModerateRequestContentImage, global::ModerationAPI.NewModerateModerateRequestContentVideo, global::ModerationAPI.NewModerateModerateRequestContentAudio, global::ModerationAPI.NewModerateModerateRequestContentObject>());
            options.Converters.Add(new global::ModerationAPI.JsonConverters.OneOfJsonConverter<global::ModerationAPI.NewModerateModerateRequestContentObjectDataText, global::ModerationAPI.NewModerateModerateRequestContentObjectDataImage, global::ModerationAPI.NewModerateModerateRequestContentObjectDataVideo, global::ModerationAPI.NewModerateModerateRequestContentObjectDataAudio>());
            options.Converters.Add(new global::ModerationAPI.JsonConverters.OneOfJsonConverter<global::ModerationAPI.NewModerateModerateRequestPolicieToxicity, global::ModerationAPI.NewModerateModerateRequestPoliciePersonalInformation, global::ModerationAPI.NewModerateModerateRequestPolicieHate, global::ModerationAPI.NewModerateModerateRequestPolicieIllicit, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitDrugs, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitAlcohol, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitFirearms, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitTobacco, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitGambling, global::ModerationAPI.NewModerateModerateRequestPolicieCannabis, global::ModerationAPI.NewModerateModerateRequestPolicieAdult, global::ModerationAPI.NewModerateModerateRequestPolicieCrypto, global::ModerationAPI.NewModerateModerateRequestPolicieSexual, global::ModerationAPI.NewModerateModerateRequestPolicieSexualMinors, global::ModerationAPI.NewModerateModerateRequestPolicieProfanity, global::ModerationAPI.NewModerateModerateRequestPolicieViolence, global::ModerationAPI.NewModerateModerateRequestPolicieSelfHarm, global::ModerationAPI.NewModerateModerateRequestPolicieSpam, global::ModerationAPI.NewModerateModerateRequestPolicieLowQualityContent, global::ModerationAPI.NewModerateModerateRequestPolicieFaceDetection, global::ModerationAPI.NewModerateModerateRequestPolicieSelfPromotion, global::ModerationAPI.NewModerateModerateRequestPoliciePolitical, global::ModerationAPI.NewModerateModerateRequestPolicieReligion, global::ModerationAPI.NewModerateModerateRequestPolicieThreat, global::ModerationAPI.NewModerateModerateRequestPolicieSexualSolicitation, global::ModerationAPI.NewModerateModerateRequestPolicieChannelCircumvention, global::ModerationAPI.NewModerateModerateRequestPolicieIllegalTrade, global::ModerationAPI.NewModerateModerateRequestPolicieAlcohol, global::ModerationAPI.NewModerateModerateRequestPolicieDrugs, global::ModerationAPI.NewModerateModerateRequestPolicieGambling, global::ModerationAPI.NewModerateModerateRequestPolicieTobacco, global::ModerationAPI.NewModerateModerateRequestPolicieWeapons, global::ModerationAPI.NewModerateModerateRequestPoliciePromotion, global::ModerationAPI.NewModerateModerateRequestPolicieExtremism, global::ModerationAPI.NewModerateModerateRequestPolicieCodeAbuse, global::ModerationAPI.NewModerateModerateRequestPolicieUnicodeSpoofing, global::ModerationAPI.NewModerateModerateRequestPoliciePiiMasking, global::ModerationAPI.NewModerateModerateRequestPolicieUrlMasking, global::ModerationAPI.NewModerateModerateRequestPolicieUrlRisk, global::ModerationAPI.NewModerateModerateRequestPolicieGuideline>());
            options.Converters.Add(new global::ModerationAPI.JsonConverters.AnyOfJsonConverter<string, object, global::System.Collections.Generic.Dictionary<string, global::ModerationAPI.OneOf<global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentText, global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentImage, global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentVideo, global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentAudio>>>());
            options.Converters.Add(new global::ModerationAPI.JsonConverters.OneOfJsonConverter<global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentText, global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentImage, global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentVideo, global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentAudio>());
            options.Converters.Add(new global::ModerationAPI.JsonConverters.AnyOfJsonConverter<global::ModerationAPI.NewModerateModerateResponseRecommendationReasonCode?, string>());
            options.Converters.Add(new global::ModerationAPI.JsonConverters.OneOfJsonConverter<global::ModerationAPI.NewModerateModerateResponsePolicieClassifierOutput, global::ModerationAPI.NewModerateModerateResponsePolicieEntityMatcherOutput>());
            options.Converters.Add(new global::ModerationAPI.JsonConverters.OneOfJsonConverter<global::ModerationAPI.NewModerateModerateResponseInsightSentimentInsight, global::ModerationAPI.NewModerateModerateResponseInsightLanguageInsight, global::ModerationAPI.NewModerateModerateResponseInsightCuriosityInsight, global::ModerationAPI.NewModerateModerateResponseInsightRespectInsight, global::ModerationAPI.NewModerateModerateResponseInsightPersonalStoryInsight, global::ModerationAPI.NewModerateModerateResponseInsightCompassionInsight>());
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

                    || typeToConvert == typeof(global::ModerationAPI.QueueItemStatus)

                    || typeToConvert == typeof(global::ModerationAPI.QueueItemStatus?)

                    || typeToConvert == typeof(global::ModerationAPI.ProjectGlobalFlaggingMode)

                    || typeToConvert == typeof(global::ModerationAPI.ProjectGlobalFlaggingMode?)

                    || typeToConvert == typeof(global::ModerationAPI.ProjectWithKeyGlobalFlaggingMode)

                    || typeToConvert == typeof(global::ModerationAPI.ProjectWithKeyGlobalFlaggingMode?)

                    || typeToConvert == typeof(global::ModerationAPI.ChannelContentType)

                    || typeToConvert == typeof(global::ModerationAPI.ChannelContentType?)

                    || typeToConvert == typeof(global::ModerationAPI.ChannelFlaggingMode)

                    || typeToConvert == typeof(global::ModerationAPI.ChannelFlaggingMode?)

                    || typeToConvert == typeof(global::ModerationAPI.ChannelTranscriptionQuality)

                    || typeToConvert == typeof(global::ModerationAPI.ChannelTranscriptionQuality?)

                    || typeToConvert == typeof(global::ModerationAPI.PublicQueueItemClientActionAction)

                    || typeToConvert == typeof(global::ModerationAPI.PublicQueueItemClientActionAction?)

                    || typeToConvert == typeof(global::ModerationAPI.PublicQueueItemClientActionBehavior)

                    || typeToConvert == typeof(global::ModerationAPI.PublicQueueItemClientActionBehavior?)

                    || typeToConvert == typeof(global::ModerationAPI.PublicQueueItemMetaType)

                    || typeToConvert == typeof(global::ModerationAPI.PublicQueueItemMetaType?)

                    || typeToConvert == typeof(global::ModerationAPI.WebhookEventDiscriminatorType)

                    || typeToConvert == typeof(global::ModerationAPI.WebhookEventDiscriminatorType?)

                    || typeToConvert == typeof(global::ModerationAPI.VoiceStartFrameEvent)

                    || typeToConvert == typeof(global::ModerationAPI.VoiceStartFrameEvent?)

                    || typeToConvert == typeof(global::ModerationAPI.VoiceStartFrameTrackName)

                    || typeToConvert == typeof(global::ModerationAPI.VoiceStartFrameTrackName?)

                    || typeToConvert == typeof(global::ModerationAPI.VoiceMediaFrameEvent)

                    || typeToConvert == typeof(global::ModerationAPI.VoiceMediaFrameEvent?)

                    || typeToConvert == typeof(global::ModerationAPI.VoiceMediaFrameMediaTrack)

                    || typeToConvert == typeof(global::ModerationAPI.VoiceMediaFrameMediaTrack?)

                    || typeToConvert == typeof(global::ModerationAPI.VoiceStopFrameEvent)

                    || typeToConvert == typeof(global::ModerationAPI.VoiceStopFrameEvent?)

                    || typeToConvert == typeof(global::ModerationAPI.VoiceSessionStartedEvent)

                    || typeToConvert == typeof(global::ModerationAPI.VoiceSessionStartedEvent?)

                    || typeToConvert == typeof(global::ModerationAPI.VoiceUtteranceFinalEvent)

                    || typeToConvert == typeof(global::ModerationAPI.VoiceUtteranceFinalEvent?)

                    || typeToConvert == typeof(global::ModerationAPI.VoiceUtteranceFinalTrack)

                    || typeToConvert == typeof(global::ModerationAPI.VoiceUtteranceFinalTrack?)

                    || typeToConvert == typeof(global::ModerationAPI.VoiceUtteranceFinalRecommendationAction)

                    || typeToConvert == typeof(global::ModerationAPI.VoiceUtteranceFinalRecommendationAction?)

                    || typeToConvert == typeof(global::ModerationAPI.VoiceSessionEndedEvent)

                    || typeToConvert == typeof(global::ModerationAPI.VoiceSessionEndedEvent?)

                    || typeToConvert == typeof(global::ModerationAPI.BadRequestErrorCode)

                    || typeToConvert == typeof(global::ModerationAPI.BadRequestErrorCode?)

                    || typeToConvert == typeof(global::ModerationAPI.AuthenticationErrorCode)

                    || typeToConvert == typeof(global::ModerationAPI.AuthenticationErrorCode?)

                    || typeToConvert == typeof(global::ModerationAPI.PermissionDeniedErrorCode)

                    || typeToConvert == typeof(global::ModerationAPI.PermissionDeniedErrorCode?)

                    || typeToConvert == typeof(global::ModerationAPI.NotFoundErrorCode)

                    || typeToConvert == typeof(global::ModerationAPI.NotFoundErrorCode?)

                    || typeToConvert == typeof(global::ModerationAPI.ConflictErrorCode)

                    || typeToConvert == typeof(global::ModerationAPI.ConflictErrorCode?)

                    || typeToConvert == typeof(global::ModerationAPI.UnprocessableEntityErrorCode)

                    || typeToConvert == typeof(global::ModerationAPI.UnprocessableEntityErrorCode?)

                    || typeToConvert == typeof(global::ModerationAPI.RateLimitErrorCode)

                    || typeToConvert == typeof(global::ModerationAPI.RateLimitErrorCode?)

                    || typeToConvert == typeof(global::ModerationAPI.InternalServerErrorCode)

                    || typeToConvert == typeof(global::ModerationAPI.InternalServerErrorCode?)

                    || typeToConvert == typeof(global::ModerationAPI.CreateFeedbackRequestType)

                    || typeToConvert == typeof(global::ModerationAPI.CreateFeedbackRequestType?)

                    || typeToConvert == typeof(global::ModerationAPI.CreateFeedbackRequestSource)

                    || typeToConvert == typeof(global::ModerationAPI.CreateFeedbackRequestSource?)

                    || typeToConvert == typeof(global::ModerationAPI.ActionsCreateRequestType)

                    || typeToConvert == typeof(global::ModerationAPI.ActionsCreateRequestType?)

                    || typeToConvert == typeof(global::ModerationAPI.ActionsCreateRequestQueueBehaviour)

                    || typeToConvert == typeof(global::ModerationAPI.ActionsCreateRequestQueueBehaviour?)

                    || typeToConvert == typeof(global::ModerationAPI.ActionsCreateRequestPosition)

                    || typeToConvert == typeof(global::ModerationAPI.ActionsCreateRequestPosition?)

                    || typeToConvert == typeof(global::ModerationAPI.ActionsUpdateRequestType)

                    || typeToConvert == typeof(global::ModerationAPI.ActionsUpdateRequestType?)

                    || typeToConvert == typeof(global::ModerationAPI.ActionsUpdateRequestQueueBehaviour)

                    || typeToConvert == typeof(global::ModerationAPI.ActionsUpdateRequestQueueBehaviour?)

                    || typeToConvert == typeof(global::ModerationAPI.ActionsUpdateRequestPosition)

                    || typeToConvert == typeof(global::ModerationAPI.ActionsUpdateRequestPosition?)

                    || typeToConvert == typeof(global::ModerationAPI.WebhooksPublicCreateRequestEventType)

                    || typeToConvert == typeof(global::ModerationAPI.WebhooksPublicCreateRequestEventType?)

                    || typeToConvert == typeof(global::ModerationAPI.WebhooksPublicUpdateRequestEventType)

                    || typeToConvert == typeof(global::ModerationAPI.WebhooksPublicUpdateRequestEventType?)

                    || typeToConvert == typeof(global::ModerationAPI.NewModerateModerateRequestMetaType)

                    || typeToConvert == typeof(global::ModerationAPI.NewModerateModerateRequestMetaType?)

                    || typeToConvert == typeof(global::ModerationAPI.NewModerateModerateRequestClientActionAction)

                    || typeToConvert == typeof(global::ModerationAPI.NewModerateModerateRequestClientActionAction?)

                    || typeToConvert == typeof(global::ModerationAPI.NewModerateModerateRequestClientActionBehavior)

                    || typeToConvert == typeof(global::ModerationAPI.NewModerateModerateRequestClientActionBehavior?)

                    || typeToConvert == typeof(global::ModerationAPI.NewModerateModerateRequestPolicieFaceDetectionComparator)

                    || typeToConvert == typeof(global::ModerationAPI.NewModerateModerateRequestPolicieFaceDetectionComparator?)

                    || typeToConvert == typeof(global::ModerationAPI.ManagementProjectsUpdateRequestGlobalFlaggingMode)

                    || typeToConvert == typeof(global::ModerationAPI.ManagementProjectsUpdateRequestGlobalFlaggingMode?)

                    || typeToConvert == typeof(global::ModerationAPI.ManagementChannelsCreateRequestContentType)

                    || typeToConvert == typeof(global::ModerationAPI.ManagementChannelsCreateRequestContentType?)

                    || typeToConvert == typeof(global::ModerationAPI.ManagementChannelsUpdateRequestContentType)

                    || typeToConvert == typeof(global::ModerationAPI.ManagementChannelsUpdateRequestContentType?)

                    || typeToConvert == typeof(global::ModerationAPI.ManagementChannelsUpdateRequestFlaggingMode)

                    || typeToConvert == typeof(global::ModerationAPI.ManagementChannelsUpdateRequestFlaggingMode?)

                    || typeToConvert == typeof(global::ModerationAPI.ManagementChannelsUpdateRequestTranscriptionQuality)

                    || typeToConvert == typeof(global::ModerationAPI.ManagementChannelsUpdateRequestTranscriptionQuality?)

                    || typeToConvert == typeof(global::ModerationAPI.GetAnalyticsSummaryRange)

                    || typeToConvert == typeof(global::ModerationAPI.GetAnalyticsSummaryRange?)

                    || typeToConvert == typeof(global::ModerationAPI.GetAnalyticsPoliciesRange)

                    || typeToConvert == typeof(global::ModerationAPI.GetAnalyticsPoliciesRange?)

                    || typeToConvert == typeof(global::ModerationAPI.GetAnalyticsAuthorsRange)

                    || typeToConvert == typeof(global::ModerationAPI.GetAnalyticsAuthorsRange?)

                    || typeToConvert == typeof(global::ModerationAPI.GetAnalyticsChannelsRange)

                    || typeToConvert == typeof(global::ModerationAPI.GetAnalyticsChannelsRange?)

                    || typeToConvert == typeof(global::ModerationAPI.GetAnalyticsVolumesRange)

                    || typeToConvert == typeof(global::ModerationAPI.GetAnalyticsVolumesRange?)

                    || typeToConvert == typeof(global::ModerationAPI.GetAnalyticsAutomationRange)

                    || typeToConvert == typeof(global::ModerationAPI.GetAnalyticsAutomationRange?)

                    || typeToConvert == typeof(global::ModerationAPI.AuthorOpenListAuthorsSortBy)

                    || typeToConvert == typeof(global::ModerationAPI.AuthorOpenListAuthorsSortBy?)

                    || typeToConvert == typeof(global::ModerationAPI.AuthorOpenListAuthorsSortDirection)

                    || typeToConvert == typeof(global::ModerationAPI.AuthorOpenListAuthorsSortDirection?)

                    || typeToConvert == typeof(global::ModerationAPI.QueueViewOpenGetItemsSort)

                    || typeToConvert == typeof(global::ModerationAPI.QueueViewOpenGetItemsSort?)

                    || typeToConvert == typeof(global::ModerationAPI.GetAnalyticsSummaryResponseRange)

                    || typeToConvert == typeof(global::ModerationAPI.GetAnalyticsSummaryResponseRange?)

                    || typeToConvert == typeof(global::ModerationAPI.GetAnalyticsPoliciesResponseRange)

                    || typeToConvert == typeof(global::ModerationAPI.GetAnalyticsPoliciesResponseRange?)

                    || typeToConvert == typeof(global::ModerationAPI.GetAnalyticsAuthorsResponseRange)

                    || typeToConvert == typeof(global::ModerationAPI.GetAnalyticsAuthorsResponseRange?)

                    || typeToConvert == typeof(global::ModerationAPI.GetAnalyticsChannelsResponseRange)

                    || typeToConvert == typeof(global::ModerationAPI.GetAnalyticsChannelsResponseRange?)

                    || typeToConvert == typeof(global::ModerationAPI.GetAnalyticsVolumesResponseRange)

                    || typeToConvert == typeof(global::ModerationAPI.GetAnalyticsVolumesResponseRange?)

                    || typeToConvert == typeof(global::ModerationAPI.GetAnalyticsVolumesResponseBucket)

                    || typeToConvert == typeof(global::ModerationAPI.GetAnalyticsVolumesResponseBucket?)

                    || typeToConvert == typeof(global::ModerationAPI.GetAnalyticsAutomationResponseRange)

                    || typeToConvert == typeof(global::ModerationAPI.GetAnalyticsAutomationResponseRange?)

                    || typeToConvert == typeof(global::ModerationAPI.QueueViewOpenUnresolveItemResponseStatus)

                    || typeToConvert == typeof(global::ModerationAPI.QueueViewOpenUnresolveItemResponseStatus?)

                    || typeToConvert == typeof(global::ModerationAPI.ActionsListResponseDataItemType)

                    || typeToConvert == typeof(global::ModerationAPI.ActionsListResponseDataItemType?)

                    || typeToConvert == typeof(global::ModerationAPI.ActionsListResponseDataItemQueueBehaviour)

                    || typeToConvert == typeof(global::ModerationAPI.ActionsListResponseDataItemQueueBehaviour?)

                    || typeToConvert == typeof(global::ModerationAPI.ActionsListResponseDataItemPosition)

                    || typeToConvert == typeof(global::ModerationAPI.ActionsListResponseDataItemPosition?)

                    || typeToConvert == typeof(global::ModerationAPI.ActionsCreateResponseType)

                    || typeToConvert == typeof(global::ModerationAPI.ActionsCreateResponseType?)

                    || typeToConvert == typeof(global::ModerationAPI.ActionsCreateResponseQueueBehaviour)

                    || typeToConvert == typeof(global::ModerationAPI.ActionsCreateResponseQueueBehaviour?)

                    || typeToConvert == typeof(global::ModerationAPI.ActionsCreateResponsePosition)

                    || typeToConvert == typeof(global::ModerationAPI.ActionsCreateResponsePosition?)

                    || typeToConvert == typeof(global::ModerationAPI.ActionsGetResponseType)

                    || typeToConvert == typeof(global::ModerationAPI.ActionsGetResponseType?)

                    || typeToConvert == typeof(global::ModerationAPI.ActionsGetResponseQueueBehaviour)

                    || typeToConvert == typeof(global::ModerationAPI.ActionsGetResponseQueueBehaviour?)

                    || typeToConvert == typeof(global::ModerationAPI.ActionsGetResponsePosition)

                    || typeToConvert == typeof(global::ModerationAPI.ActionsGetResponsePosition?)

                    || typeToConvert == typeof(global::ModerationAPI.ActionsUpdateResponseType)

                    || typeToConvert == typeof(global::ModerationAPI.ActionsUpdateResponseType?)

                    || typeToConvert == typeof(global::ModerationAPI.ActionsUpdateResponseQueueBehaviour)

                    || typeToConvert == typeof(global::ModerationAPI.ActionsUpdateResponseQueueBehaviour?)

                    || typeToConvert == typeof(global::ModerationAPI.ActionsUpdateResponsePosition)

                    || typeToConvert == typeof(global::ModerationAPI.ActionsUpdateResponsePosition?)

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

                    || typeToConvert == typeof(global::ModerationAPI.NewModerateModerateResponseAuthorStatus)

                    || typeToConvert == typeof(global::ModerationAPI.NewModerateModerateResponseAuthorStatus?)

                    || typeToConvert == typeof(global::ModerationAPI.NewModerateModerateResponseRecommendationAction)

                    || typeToConvert == typeof(global::ModerationAPI.NewModerateModerateResponseRecommendationAction?)

                    || typeToConvert == typeof(global::ModerationAPI.NewModerateModerateResponseRecommendationReasonCode)

                    || typeToConvert == typeof(global::ModerationAPI.NewModerateModerateResponseRecommendationReasonCode?)

                    || typeToConvert == typeof(global::ModerationAPI.NewModerateModerateResponseCasebookVerdict)

                    || typeToConvert == typeof(global::ModerationAPI.NewModerateModerateResponseCasebookVerdict?)

                    || typeToConvert == typeof(global::ModerationAPI.NewModerateModerateResponseCampaignStatus)

                    || typeToConvert == typeof(global::ModerationAPI.NewModerateModerateResponseCampaignStatus?)

                    || typeToConvert == typeof(global::ModerationAPI.NewModerateModerateResponseCampaignBrandStatus)

                    || typeToConvert == typeof(global::ModerationAPI.NewModerateModerateResponseCampaignBrandStatus?)

                    || typeToConvert == typeof(global::ModerationAPI.NewModerateModerateResponseCampaignDrift)

                    || typeToConvert == typeof(global::ModerationAPI.NewModerateModerateResponseCampaignDrift?)

                    || typeToConvert == typeof(global::ModerationAPI.NewModerateModerateResponseCampaignClusterStatus)

                    || typeToConvert == typeof(global::ModerationAPI.NewModerateModerateResponseCampaignClusterStatus?)

                    || typeToConvert == typeof(global::ModerationAPI.NewModerateModerateResponsePolicieEntityMatcherOutputMatcheSignalsBrandImpersonationMethod)

                    || typeToConvert == typeof(global::ModerationAPI.NewModerateModerateResponsePolicieEntityMatcherOutputMatcheSignalsBrandImpersonationMethod?)

                    || typeToConvert == typeof(global::ModerationAPI.NewModerateModerateResponseInsightSentimentInsightValue)

                    || typeToConvert == typeof(global::ModerationAPI.NewModerateModerateResponseInsightSentimentInsightValue?)

                    || typeToConvert == typeof(global::ModerationAPI.NewModerateModerateResponseMetaStatus)

                    || typeToConvert == typeof(global::ModerationAPI.NewModerateModerateResponseMetaStatus?)

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

                if (typeToConvert == typeof(global::ModerationAPI.QueueItemStatus))
                {
                    return new global::ModerationAPI.JsonConverters.QueueItemStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.QueueItemStatus?))
                {
                    return new global::ModerationAPI.JsonConverters.QueueItemStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.ProjectGlobalFlaggingMode))
                {
                    return new global::ModerationAPI.JsonConverters.ProjectGlobalFlaggingModeJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.ProjectGlobalFlaggingMode?))
                {
                    return new global::ModerationAPI.JsonConverters.ProjectGlobalFlaggingModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.ProjectWithKeyGlobalFlaggingMode))
                {
                    return new global::ModerationAPI.JsonConverters.ProjectWithKeyGlobalFlaggingModeJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.ProjectWithKeyGlobalFlaggingMode?))
                {
                    return new global::ModerationAPI.JsonConverters.ProjectWithKeyGlobalFlaggingModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.ChannelContentType))
                {
                    return new global::ModerationAPI.JsonConverters.ChannelContentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.ChannelContentType?))
                {
                    return new global::ModerationAPI.JsonConverters.ChannelContentTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.ChannelFlaggingMode))
                {
                    return new global::ModerationAPI.JsonConverters.ChannelFlaggingModeJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.ChannelFlaggingMode?))
                {
                    return new global::ModerationAPI.JsonConverters.ChannelFlaggingModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.ChannelTranscriptionQuality))
                {
                    return new global::ModerationAPI.JsonConverters.ChannelTranscriptionQualityJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.ChannelTranscriptionQuality?))
                {
                    return new global::ModerationAPI.JsonConverters.ChannelTranscriptionQualityNullableJsonConverter();
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

                if (typeToConvert == typeof(global::ModerationAPI.WebhookEventDiscriminatorType))
                {
                    return new global::ModerationAPI.JsonConverters.WebhookEventDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.WebhookEventDiscriminatorType?))
                {
                    return new global::ModerationAPI.JsonConverters.WebhookEventDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.VoiceStartFrameEvent))
                {
                    return new global::ModerationAPI.JsonConverters.VoiceStartFrameEventJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.VoiceStartFrameEvent?))
                {
                    return new global::ModerationAPI.JsonConverters.VoiceStartFrameEventNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.VoiceStartFrameTrackName))
                {
                    return new global::ModerationAPI.JsonConverters.VoiceStartFrameTrackNameJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.VoiceStartFrameTrackName?))
                {
                    return new global::ModerationAPI.JsonConverters.VoiceStartFrameTrackNameNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.VoiceMediaFrameEvent))
                {
                    return new global::ModerationAPI.JsonConverters.VoiceMediaFrameEventJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.VoiceMediaFrameEvent?))
                {
                    return new global::ModerationAPI.JsonConverters.VoiceMediaFrameEventNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.VoiceMediaFrameMediaTrack))
                {
                    return new global::ModerationAPI.JsonConverters.VoiceMediaFrameMediaTrackJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.VoiceMediaFrameMediaTrack?))
                {
                    return new global::ModerationAPI.JsonConverters.VoiceMediaFrameMediaTrackNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.VoiceStopFrameEvent))
                {
                    return new global::ModerationAPI.JsonConverters.VoiceStopFrameEventJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.VoiceStopFrameEvent?))
                {
                    return new global::ModerationAPI.JsonConverters.VoiceStopFrameEventNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.VoiceSessionStartedEvent))
                {
                    return new global::ModerationAPI.JsonConverters.VoiceSessionStartedEventJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.VoiceSessionStartedEvent?))
                {
                    return new global::ModerationAPI.JsonConverters.VoiceSessionStartedEventNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.VoiceUtteranceFinalEvent))
                {
                    return new global::ModerationAPI.JsonConverters.VoiceUtteranceFinalEventJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.VoiceUtteranceFinalEvent?))
                {
                    return new global::ModerationAPI.JsonConverters.VoiceUtteranceFinalEventNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.VoiceUtteranceFinalTrack))
                {
                    return new global::ModerationAPI.JsonConverters.VoiceUtteranceFinalTrackJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.VoiceUtteranceFinalTrack?))
                {
                    return new global::ModerationAPI.JsonConverters.VoiceUtteranceFinalTrackNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.VoiceUtteranceFinalRecommendationAction))
                {
                    return new global::ModerationAPI.JsonConverters.VoiceUtteranceFinalRecommendationActionJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.VoiceUtteranceFinalRecommendationAction?))
                {
                    return new global::ModerationAPI.JsonConverters.VoiceUtteranceFinalRecommendationActionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.VoiceSessionEndedEvent))
                {
                    return new global::ModerationAPI.JsonConverters.VoiceSessionEndedEventJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.VoiceSessionEndedEvent?))
                {
                    return new global::ModerationAPI.JsonConverters.VoiceSessionEndedEventNullableJsonConverter();
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

                if (typeToConvert == typeof(global::ModerationAPI.PermissionDeniedErrorCode))
                {
                    return new global::ModerationAPI.JsonConverters.PermissionDeniedErrorCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.PermissionDeniedErrorCode?))
                {
                    return new global::ModerationAPI.JsonConverters.PermissionDeniedErrorCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.NotFoundErrorCode))
                {
                    return new global::ModerationAPI.JsonConverters.NotFoundErrorCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.NotFoundErrorCode?))
                {
                    return new global::ModerationAPI.JsonConverters.NotFoundErrorCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.ConflictErrorCode))
                {
                    return new global::ModerationAPI.JsonConverters.ConflictErrorCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.ConflictErrorCode?))
                {
                    return new global::ModerationAPI.JsonConverters.ConflictErrorCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.UnprocessableEntityErrorCode))
                {
                    return new global::ModerationAPI.JsonConverters.UnprocessableEntityErrorCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.UnprocessableEntityErrorCode?))
                {
                    return new global::ModerationAPI.JsonConverters.UnprocessableEntityErrorCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.RateLimitErrorCode))
                {
                    return new global::ModerationAPI.JsonConverters.RateLimitErrorCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.RateLimitErrorCode?))
                {
                    return new global::ModerationAPI.JsonConverters.RateLimitErrorCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.InternalServerErrorCode))
                {
                    return new global::ModerationAPI.JsonConverters.InternalServerErrorCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.InternalServerErrorCode?))
                {
                    return new global::ModerationAPI.JsonConverters.InternalServerErrorCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.CreateFeedbackRequestType))
                {
                    return new global::ModerationAPI.JsonConverters.CreateFeedbackRequestTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.CreateFeedbackRequestType?))
                {
                    return new global::ModerationAPI.JsonConverters.CreateFeedbackRequestTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.CreateFeedbackRequestSource))
                {
                    return new global::ModerationAPI.JsonConverters.CreateFeedbackRequestSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.CreateFeedbackRequestSource?))
                {
                    return new global::ModerationAPI.JsonConverters.CreateFeedbackRequestSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.ActionsCreateRequestType))
                {
                    return new global::ModerationAPI.JsonConverters.ActionsCreateRequestTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.ActionsCreateRequestType?))
                {
                    return new global::ModerationAPI.JsonConverters.ActionsCreateRequestTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.ActionsCreateRequestQueueBehaviour))
                {
                    return new global::ModerationAPI.JsonConverters.ActionsCreateRequestQueueBehaviourJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.ActionsCreateRequestQueueBehaviour?))
                {
                    return new global::ModerationAPI.JsonConverters.ActionsCreateRequestQueueBehaviourNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.ActionsCreateRequestPosition))
                {
                    return new global::ModerationAPI.JsonConverters.ActionsCreateRequestPositionJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.ActionsCreateRequestPosition?))
                {
                    return new global::ModerationAPI.JsonConverters.ActionsCreateRequestPositionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.ActionsUpdateRequestType))
                {
                    return new global::ModerationAPI.JsonConverters.ActionsUpdateRequestTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.ActionsUpdateRequestType?))
                {
                    return new global::ModerationAPI.JsonConverters.ActionsUpdateRequestTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.ActionsUpdateRequestQueueBehaviour))
                {
                    return new global::ModerationAPI.JsonConverters.ActionsUpdateRequestQueueBehaviourJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.ActionsUpdateRequestQueueBehaviour?))
                {
                    return new global::ModerationAPI.JsonConverters.ActionsUpdateRequestQueueBehaviourNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.ActionsUpdateRequestPosition))
                {
                    return new global::ModerationAPI.JsonConverters.ActionsUpdateRequestPositionJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.ActionsUpdateRequestPosition?))
                {
                    return new global::ModerationAPI.JsonConverters.ActionsUpdateRequestPositionNullableJsonConverter();
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

                if (typeToConvert == typeof(global::ModerationAPI.NewModerateModerateRequestMetaType))
                {
                    return new global::ModerationAPI.JsonConverters.NewModerateModerateRequestMetaTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.NewModerateModerateRequestMetaType?))
                {
                    return new global::ModerationAPI.JsonConverters.NewModerateModerateRequestMetaTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.NewModerateModerateRequestClientActionAction))
                {
                    return new global::ModerationAPI.JsonConverters.NewModerateModerateRequestClientActionActionJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.NewModerateModerateRequestClientActionAction?))
                {
                    return new global::ModerationAPI.JsonConverters.NewModerateModerateRequestClientActionActionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.NewModerateModerateRequestClientActionBehavior))
                {
                    return new global::ModerationAPI.JsonConverters.NewModerateModerateRequestClientActionBehaviorJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.NewModerateModerateRequestClientActionBehavior?))
                {
                    return new global::ModerationAPI.JsonConverters.NewModerateModerateRequestClientActionBehaviorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.NewModerateModerateRequestPolicieFaceDetectionComparator))
                {
                    return new global::ModerationAPI.JsonConverters.NewModerateModerateRequestPolicieFaceDetectionComparatorJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.NewModerateModerateRequestPolicieFaceDetectionComparator?))
                {
                    return new global::ModerationAPI.JsonConverters.NewModerateModerateRequestPolicieFaceDetectionComparatorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.ManagementProjectsUpdateRequestGlobalFlaggingMode))
                {
                    return new global::ModerationAPI.JsonConverters.ManagementProjectsUpdateRequestGlobalFlaggingModeJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.ManagementProjectsUpdateRequestGlobalFlaggingMode?))
                {
                    return new global::ModerationAPI.JsonConverters.ManagementProjectsUpdateRequestGlobalFlaggingModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.ManagementChannelsCreateRequestContentType))
                {
                    return new global::ModerationAPI.JsonConverters.ManagementChannelsCreateRequestContentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.ManagementChannelsCreateRequestContentType?))
                {
                    return new global::ModerationAPI.JsonConverters.ManagementChannelsCreateRequestContentTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.ManagementChannelsUpdateRequestContentType))
                {
                    return new global::ModerationAPI.JsonConverters.ManagementChannelsUpdateRequestContentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.ManagementChannelsUpdateRequestContentType?))
                {
                    return new global::ModerationAPI.JsonConverters.ManagementChannelsUpdateRequestContentTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.ManagementChannelsUpdateRequestFlaggingMode))
                {
                    return new global::ModerationAPI.JsonConverters.ManagementChannelsUpdateRequestFlaggingModeJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.ManagementChannelsUpdateRequestFlaggingMode?))
                {
                    return new global::ModerationAPI.JsonConverters.ManagementChannelsUpdateRequestFlaggingModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.ManagementChannelsUpdateRequestTranscriptionQuality))
                {
                    return new global::ModerationAPI.JsonConverters.ManagementChannelsUpdateRequestTranscriptionQualityJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.ManagementChannelsUpdateRequestTranscriptionQuality?))
                {
                    return new global::ModerationAPI.JsonConverters.ManagementChannelsUpdateRequestTranscriptionQualityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.GetAnalyticsSummaryRange))
                {
                    return new global::ModerationAPI.JsonConverters.GetAnalyticsSummaryRangeJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.GetAnalyticsSummaryRange?))
                {
                    return new global::ModerationAPI.JsonConverters.GetAnalyticsSummaryRangeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.GetAnalyticsPoliciesRange))
                {
                    return new global::ModerationAPI.JsonConverters.GetAnalyticsPoliciesRangeJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.GetAnalyticsPoliciesRange?))
                {
                    return new global::ModerationAPI.JsonConverters.GetAnalyticsPoliciesRangeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.GetAnalyticsAuthorsRange))
                {
                    return new global::ModerationAPI.JsonConverters.GetAnalyticsAuthorsRangeJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.GetAnalyticsAuthorsRange?))
                {
                    return new global::ModerationAPI.JsonConverters.GetAnalyticsAuthorsRangeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.GetAnalyticsChannelsRange))
                {
                    return new global::ModerationAPI.JsonConverters.GetAnalyticsChannelsRangeJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.GetAnalyticsChannelsRange?))
                {
                    return new global::ModerationAPI.JsonConverters.GetAnalyticsChannelsRangeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.GetAnalyticsVolumesRange))
                {
                    return new global::ModerationAPI.JsonConverters.GetAnalyticsVolumesRangeJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.GetAnalyticsVolumesRange?))
                {
                    return new global::ModerationAPI.JsonConverters.GetAnalyticsVolumesRangeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.GetAnalyticsAutomationRange))
                {
                    return new global::ModerationAPI.JsonConverters.GetAnalyticsAutomationRangeJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.GetAnalyticsAutomationRange?))
                {
                    return new global::ModerationAPI.JsonConverters.GetAnalyticsAutomationRangeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.AuthorOpenListAuthorsSortBy))
                {
                    return new global::ModerationAPI.JsonConverters.AuthorOpenListAuthorsSortByJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.AuthorOpenListAuthorsSortBy?))
                {
                    return new global::ModerationAPI.JsonConverters.AuthorOpenListAuthorsSortByNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.AuthorOpenListAuthorsSortDirection))
                {
                    return new global::ModerationAPI.JsonConverters.AuthorOpenListAuthorsSortDirectionJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.AuthorOpenListAuthorsSortDirection?))
                {
                    return new global::ModerationAPI.JsonConverters.AuthorOpenListAuthorsSortDirectionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.QueueViewOpenGetItemsSort))
                {
                    return new global::ModerationAPI.JsonConverters.QueueViewOpenGetItemsSortJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.QueueViewOpenGetItemsSort?))
                {
                    return new global::ModerationAPI.JsonConverters.QueueViewOpenGetItemsSortNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.GetAnalyticsSummaryResponseRange))
                {
                    return new global::ModerationAPI.JsonConverters.GetAnalyticsSummaryResponseRangeJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.GetAnalyticsSummaryResponseRange?))
                {
                    return new global::ModerationAPI.JsonConverters.GetAnalyticsSummaryResponseRangeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.GetAnalyticsPoliciesResponseRange))
                {
                    return new global::ModerationAPI.JsonConverters.GetAnalyticsPoliciesResponseRangeJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.GetAnalyticsPoliciesResponseRange?))
                {
                    return new global::ModerationAPI.JsonConverters.GetAnalyticsPoliciesResponseRangeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.GetAnalyticsAuthorsResponseRange))
                {
                    return new global::ModerationAPI.JsonConverters.GetAnalyticsAuthorsResponseRangeJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.GetAnalyticsAuthorsResponseRange?))
                {
                    return new global::ModerationAPI.JsonConverters.GetAnalyticsAuthorsResponseRangeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.GetAnalyticsChannelsResponseRange))
                {
                    return new global::ModerationAPI.JsonConverters.GetAnalyticsChannelsResponseRangeJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.GetAnalyticsChannelsResponseRange?))
                {
                    return new global::ModerationAPI.JsonConverters.GetAnalyticsChannelsResponseRangeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.GetAnalyticsVolumesResponseRange))
                {
                    return new global::ModerationAPI.JsonConverters.GetAnalyticsVolumesResponseRangeJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.GetAnalyticsVolumesResponseRange?))
                {
                    return new global::ModerationAPI.JsonConverters.GetAnalyticsVolumesResponseRangeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.GetAnalyticsVolumesResponseBucket))
                {
                    return new global::ModerationAPI.JsonConverters.GetAnalyticsVolumesResponseBucketJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.GetAnalyticsVolumesResponseBucket?))
                {
                    return new global::ModerationAPI.JsonConverters.GetAnalyticsVolumesResponseBucketNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.GetAnalyticsAutomationResponseRange))
                {
                    return new global::ModerationAPI.JsonConverters.GetAnalyticsAutomationResponseRangeJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.GetAnalyticsAutomationResponseRange?))
                {
                    return new global::ModerationAPI.JsonConverters.GetAnalyticsAutomationResponseRangeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.QueueViewOpenUnresolveItemResponseStatus))
                {
                    return new global::ModerationAPI.JsonConverters.QueueViewOpenUnresolveItemResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.QueueViewOpenUnresolveItemResponseStatus?))
                {
                    return new global::ModerationAPI.JsonConverters.QueueViewOpenUnresolveItemResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.ActionsListResponseDataItemType))
                {
                    return new global::ModerationAPI.JsonConverters.ActionsListResponseDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.ActionsListResponseDataItemType?))
                {
                    return new global::ModerationAPI.JsonConverters.ActionsListResponseDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.ActionsListResponseDataItemQueueBehaviour))
                {
                    return new global::ModerationAPI.JsonConverters.ActionsListResponseDataItemQueueBehaviourJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.ActionsListResponseDataItemQueueBehaviour?))
                {
                    return new global::ModerationAPI.JsonConverters.ActionsListResponseDataItemQueueBehaviourNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.ActionsListResponseDataItemPosition))
                {
                    return new global::ModerationAPI.JsonConverters.ActionsListResponseDataItemPositionJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.ActionsListResponseDataItemPosition?))
                {
                    return new global::ModerationAPI.JsonConverters.ActionsListResponseDataItemPositionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.ActionsCreateResponseType))
                {
                    return new global::ModerationAPI.JsonConverters.ActionsCreateResponseTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.ActionsCreateResponseType?))
                {
                    return new global::ModerationAPI.JsonConverters.ActionsCreateResponseTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.ActionsCreateResponseQueueBehaviour))
                {
                    return new global::ModerationAPI.JsonConverters.ActionsCreateResponseQueueBehaviourJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.ActionsCreateResponseQueueBehaviour?))
                {
                    return new global::ModerationAPI.JsonConverters.ActionsCreateResponseQueueBehaviourNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.ActionsCreateResponsePosition))
                {
                    return new global::ModerationAPI.JsonConverters.ActionsCreateResponsePositionJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.ActionsCreateResponsePosition?))
                {
                    return new global::ModerationAPI.JsonConverters.ActionsCreateResponsePositionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.ActionsGetResponseType))
                {
                    return new global::ModerationAPI.JsonConverters.ActionsGetResponseTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.ActionsGetResponseType?))
                {
                    return new global::ModerationAPI.JsonConverters.ActionsGetResponseTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.ActionsGetResponseQueueBehaviour))
                {
                    return new global::ModerationAPI.JsonConverters.ActionsGetResponseQueueBehaviourJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.ActionsGetResponseQueueBehaviour?))
                {
                    return new global::ModerationAPI.JsonConverters.ActionsGetResponseQueueBehaviourNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.ActionsGetResponsePosition))
                {
                    return new global::ModerationAPI.JsonConverters.ActionsGetResponsePositionJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.ActionsGetResponsePosition?))
                {
                    return new global::ModerationAPI.JsonConverters.ActionsGetResponsePositionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.ActionsUpdateResponseType))
                {
                    return new global::ModerationAPI.JsonConverters.ActionsUpdateResponseTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.ActionsUpdateResponseType?))
                {
                    return new global::ModerationAPI.JsonConverters.ActionsUpdateResponseTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.ActionsUpdateResponseQueueBehaviour))
                {
                    return new global::ModerationAPI.JsonConverters.ActionsUpdateResponseQueueBehaviourJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.ActionsUpdateResponseQueueBehaviour?))
                {
                    return new global::ModerationAPI.JsonConverters.ActionsUpdateResponseQueueBehaviourNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.ActionsUpdateResponsePosition))
                {
                    return new global::ModerationAPI.JsonConverters.ActionsUpdateResponsePositionJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.ActionsUpdateResponsePosition?))
                {
                    return new global::ModerationAPI.JsonConverters.ActionsUpdateResponsePositionNullableJsonConverter();
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

                if (typeToConvert == typeof(global::ModerationAPI.NewModerateModerateResponseAuthorStatus))
                {
                    return new global::ModerationAPI.JsonConverters.NewModerateModerateResponseAuthorStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.NewModerateModerateResponseAuthorStatus?))
                {
                    return new global::ModerationAPI.JsonConverters.NewModerateModerateResponseAuthorStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.NewModerateModerateResponseRecommendationAction))
                {
                    return new global::ModerationAPI.JsonConverters.NewModerateModerateResponseRecommendationActionJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.NewModerateModerateResponseRecommendationAction?))
                {
                    return new global::ModerationAPI.JsonConverters.NewModerateModerateResponseRecommendationActionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.NewModerateModerateResponseRecommendationReasonCode))
                {
                    return new global::ModerationAPI.JsonConverters.NewModerateModerateResponseRecommendationReasonCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.NewModerateModerateResponseRecommendationReasonCode?))
                {
                    return new global::ModerationAPI.JsonConverters.NewModerateModerateResponseRecommendationReasonCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.NewModerateModerateResponseCasebookVerdict))
                {
                    return new global::ModerationAPI.JsonConverters.NewModerateModerateResponseCasebookVerdictJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.NewModerateModerateResponseCasebookVerdict?))
                {
                    return new global::ModerationAPI.JsonConverters.NewModerateModerateResponseCasebookVerdictNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.NewModerateModerateResponseCampaignStatus))
                {
                    return new global::ModerationAPI.JsonConverters.NewModerateModerateResponseCampaignStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.NewModerateModerateResponseCampaignStatus?))
                {
                    return new global::ModerationAPI.JsonConverters.NewModerateModerateResponseCampaignStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.NewModerateModerateResponseCampaignBrandStatus))
                {
                    return new global::ModerationAPI.JsonConverters.NewModerateModerateResponseCampaignBrandStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.NewModerateModerateResponseCampaignBrandStatus?))
                {
                    return new global::ModerationAPI.JsonConverters.NewModerateModerateResponseCampaignBrandStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.NewModerateModerateResponseCampaignDrift))
                {
                    return new global::ModerationAPI.JsonConverters.NewModerateModerateResponseCampaignDriftJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.NewModerateModerateResponseCampaignDrift?))
                {
                    return new global::ModerationAPI.JsonConverters.NewModerateModerateResponseCampaignDriftNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.NewModerateModerateResponseCampaignClusterStatus))
                {
                    return new global::ModerationAPI.JsonConverters.NewModerateModerateResponseCampaignClusterStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.NewModerateModerateResponseCampaignClusterStatus?))
                {
                    return new global::ModerationAPI.JsonConverters.NewModerateModerateResponseCampaignClusterStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.NewModerateModerateResponsePolicieEntityMatcherOutputMatcheSignalsBrandImpersonationMethod))
                {
                    return new global::ModerationAPI.JsonConverters.NewModerateModerateResponsePolicieEntityMatcherOutputMatcheSignalsBrandImpersonationMethodJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.NewModerateModerateResponsePolicieEntityMatcherOutputMatcheSignalsBrandImpersonationMethod?))
                {
                    return new global::ModerationAPI.JsonConverters.NewModerateModerateResponsePolicieEntityMatcherOutputMatcheSignalsBrandImpersonationMethodNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.NewModerateModerateResponseInsightSentimentInsightValue))
                {
                    return new global::ModerationAPI.JsonConverters.NewModerateModerateResponseInsightSentimentInsightValueJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.NewModerateModerateResponseInsightSentimentInsightValue?))
                {
                    return new global::ModerationAPI.JsonConverters.NewModerateModerateResponseInsightSentimentInsightValueNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.NewModerateModerateResponseMetaStatus))
                {
                    return new global::ModerationAPI.JsonConverters.NewModerateModerateResponseMetaStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.NewModerateModerateResponseMetaStatus?))
                {
                    return new global::ModerationAPI.JsonConverters.NewModerateModerateResponseMetaStatusNullableJsonConverter();
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
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[2];

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
                    0 => new SourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),

                    1 => new SourceGenerationContextChunk1(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}