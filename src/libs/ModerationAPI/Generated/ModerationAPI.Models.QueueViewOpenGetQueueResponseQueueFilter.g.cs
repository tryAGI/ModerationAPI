
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class QueueViewOpenGetQueueResponseQueueFilter
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isFlagged")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ModerationAPI.JsonConverters.QueueViewOpenGetQueueResponseQueueFilterIsFlaggedJsonConverter))]
        public global::ModerationAPI.QueueViewOpenGetQueueResponseQueueFilterIsFlagged? IsFlagged { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("casebookAnswer")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ModerationAPI.JsonConverters.QueueViewOpenGetQueueResponseQueueFilterCasebookAnswerJsonConverter))]
        public global::ModerationAPI.QueueViewOpenGetQueueResponseQueueFilterCasebookAnswer? CasebookAnswer { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("casebookAgreement")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ModerationAPI.JsonConverters.QueueViewOpenGetQueueResponseQueueFilterCasebookAgreementJsonConverter))]
        public global::ModerationAPI.QueueViewOpenGetQueueResponseQueueFilterCasebookAgreement? CasebookAgreement { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("labels")]
        public global::System.Collections.Generic.IList<string>? Labels { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filterLabels")]
        public global::System.Collections.Generic.IList<global::ModerationAPI.QueueViewOpenGetQueueResponseQueueFilterFilterLabel>? FilterLabels { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadataFilters")]
        public global::System.Collections.Generic.IList<global::ModerationAPI.QueueViewOpenGetQueueResponseQueueFilterMetadataFilter>? MetadataFilters { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filteredChannelIds")]
        public global::System.Collections.Generic.IList<string>? FilteredChannelIds { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filteredActionIds")]
        public global::System.Collections.Generic.IList<string>? FilteredActionIds { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("languages")]
        public global::System.Collections.Generic.IList<string>? Languages { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contentTypes")]
        public global::System.Collections.Generic.IList<global::ModerationAPI.QueueViewOpenGetQueueResponseQueueFilterContentType>? ContentTypes { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mediaTypes")]
        public global::System.Collections.Generic.IList<global::ModerationAPI.QueueViewOpenGetQueueResponseQueueFilterMediaType>? MediaTypes { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authorTrustLevels")]
        public global::System.Collections.Generic.IList<int>? AuthorTrustLevels { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recommendationActions")]
        public global::System.Collections.Generic.IList<global::ModerationAPI.QueueViewOpenGetQueueResponseQueueFilterRecommendationAction>? RecommendationActions { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("minSeverity")]
        public int? MinSeverity { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxSeverity")]
        public int? MaxSeverity { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("afterDate")]
        public string? AfterDate { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("beforeDate")]
        public string? BeforeDate { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("within")]
        public double? Within { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("withinUnit")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ModerationAPI.JsonConverters.QueueViewOpenGetQueueResponseQueueFilterWithinUnitJsonConverter))]
        public global::ModerationAPI.QueueViewOpenGetQueueResponseQueueFilterWithinUnit? WithinUnit { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clearDateWindow")]
        public bool? ClearDateWindow { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("checkStatus")]
        public global::ModerationAPI.QueueViewOpenGetQueueResponseQueueFilterCheckStatus? CheckStatus { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authorID")]
        public string? AuthorID { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contentID")]
        public string? ContentID { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversationIds")]
        public global::System.Collections.Generic.IList<string?>? ConversationIds { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("search")]
        public global::System.Collections.Generic.IList<string>? Search { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QueueViewOpenGetQueueResponseQueueFilter" /> class.
        /// </summary>
        /// <param name="isFlagged"></param>
        /// <param name="casebookAnswer"></param>
        /// <param name="casebookAgreement"></param>
        /// <param name="labels"></param>
        /// <param name="filterLabels"></param>
        /// <param name="metadataFilters"></param>
        /// <param name="filteredChannelIds"></param>
        /// <param name="filteredActionIds"></param>
        /// <param name="languages"></param>
        /// <param name="contentTypes"></param>
        /// <param name="mediaTypes"></param>
        /// <param name="authorTrustLevels"></param>
        /// <param name="recommendationActions"></param>
        /// <param name="minSeverity"></param>
        /// <param name="maxSeverity"></param>
        /// <param name="afterDate"></param>
        /// <param name="beforeDate"></param>
        /// <param name="within"></param>
        /// <param name="withinUnit"></param>
        /// <param name="clearDateWindow"></param>
        /// <param name="checkStatus"></param>
        /// <param name="authorID"></param>
        /// <param name="contentID"></param>
        /// <param name="conversationIds"></param>
        /// <param name="search"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QueueViewOpenGetQueueResponseQueueFilter(
            global::ModerationAPI.QueueViewOpenGetQueueResponseQueueFilterIsFlagged? isFlagged,
            global::ModerationAPI.QueueViewOpenGetQueueResponseQueueFilterCasebookAnswer? casebookAnswer,
            global::ModerationAPI.QueueViewOpenGetQueueResponseQueueFilterCasebookAgreement? casebookAgreement,
            global::System.Collections.Generic.IList<string>? labels,
            global::System.Collections.Generic.IList<global::ModerationAPI.QueueViewOpenGetQueueResponseQueueFilterFilterLabel>? filterLabels,
            global::System.Collections.Generic.IList<global::ModerationAPI.QueueViewOpenGetQueueResponseQueueFilterMetadataFilter>? metadataFilters,
            global::System.Collections.Generic.IList<string>? filteredChannelIds,
            global::System.Collections.Generic.IList<string>? filteredActionIds,
            global::System.Collections.Generic.IList<string>? languages,
            global::System.Collections.Generic.IList<global::ModerationAPI.QueueViewOpenGetQueueResponseQueueFilterContentType>? contentTypes,
            global::System.Collections.Generic.IList<global::ModerationAPI.QueueViewOpenGetQueueResponseQueueFilterMediaType>? mediaTypes,
            global::System.Collections.Generic.IList<int>? authorTrustLevels,
            global::System.Collections.Generic.IList<global::ModerationAPI.QueueViewOpenGetQueueResponseQueueFilterRecommendationAction>? recommendationActions,
            int? minSeverity,
            int? maxSeverity,
            string? afterDate,
            string? beforeDate,
            double? within,
            global::ModerationAPI.QueueViewOpenGetQueueResponseQueueFilterWithinUnit? withinUnit,
            bool? clearDateWindow,
            global::ModerationAPI.QueueViewOpenGetQueueResponseQueueFilterCheckStatus? checkStatus,
            string? authorID,
            string? contentID,
            global::System.Collections.Generic.IList<string?>? conversationIds,
            global::System.Collections.Generic.IList<string>? search)
        {
            this.IsFlagged = isFlagged;
            this.CasebookAnswer = casebookAnswer;
            this.CasebookAgreement = casebookAgreement;
            this.Labels = labels;
            this.FilterLabels = filterLabels;
            this.MetadataFilters = metadataFilters;
            this.FilteredChannelIds = filteredChannelIds;
            this.FilteredActionIds = filteredActionIds;
            this.Languages = languages;
            this.ContentTypes = contentTypes;
            this.MediaTypes = mediaTypes;
            this.AuthorTrustLevels = authorTrustLevels;
            this.RecommendationActions = recommendationActions;
            this.MinSeverity = minSeverity;
            this.MaxSeverity = maxSeverity;
            this.AfterDate = afterDate;
            this.BeforeDate = beforeDate;
            this.Within = within;
            this.WithinUnit = withinUnit;
            this.ClearDateWindow = clearDateWindow;
            this.CheckStatus = checkStatus;
            this.AuthorID = authorID;
            this.ContentID = contentID;
            this.ConversationIds = conversationIds;
            this.Search = search;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueueViewOpenGetQueueResponseQueueFilter" /> class.
        /// </summary>
        public QueueViewOpenGetQueueResponseQueueFilter()
        {
        }

    }
}