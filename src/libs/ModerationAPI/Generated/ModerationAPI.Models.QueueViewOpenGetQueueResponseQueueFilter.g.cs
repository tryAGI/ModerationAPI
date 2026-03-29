
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
        [global::System.Text.Json.Serialization.JsonPropertyName("conversationIds")]
        public global::System.Collections.Generic.IList<string>? ConversationIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filterLabels")]
        public global::System.Collections.Generic.IList<global::ModerationAPI.QueueViewOpenGetQueueResponseQueueFilterFilterLabel>? FilterLabels { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("labels")]
        public global::System.Collections.Generic.IList<string>? Labels { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("showChecked")]
        public bool? ShowChecked { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authorID")]
        public string? AuthorID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filteredActionIds")]
        public global::System.Collections.Generic.IList<string>? FilteredActionIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filteredChannelIds")]
        public global::System.Collections.Generic.IList<string>? FilteredChannelIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recommendationActions")]
        public global::System.Collections.Generic.IList<global::ModerationAPI.QueueViewOpenGetQueueResponseQueueFilterRecommendationAction>? RecommendationActions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QueueViewOpenGetQueueResponseQueueFilter" /> class.
        /// </summary>
        /// <param name="conversationIds"></param>
        /// <param name="filterLabels"></param>
        /// <param name="labels"></param>
        /// <param name="afterDate"></param>
        /// <param name="beforeDate"></param>
        /// <param name="showChecked"></param>
        /// <param name="authorID"></param>
        /// <param name="filteredActionIds"></param>
        /// <param name="filteredChannelIds"></param>
        /// <param name="recommendationActions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QueueViewOpenGetQueueResponseQueueFilter(
            global::System.Collections.Generic.IList<string>? conversationIds,
            global::System.Collections.Generic.IList<global::ModerationAPI.QueueViewOpenGetQueueResponseQueueFilterFilterLabel>? filterLabels,
            global::System.Collections.Generic.IList<string>? labels,
            string? afterDate,
            string? beforeDate,
            bool? showChecked,
            string? authorID,
            global::System.Collections.Generic.IList<string>? filteredActionIds,
            global::System.Collections.Generic.IList<string>? filteredChannelIds,
            global::System.Collections.Generic.IList<global::ModerationAPI.QueueViewOpenGetQueueResponseQueueFilterRecommendationAction>? recommendationActions)
        {
            this.ConversationIds = conversationIds;
            this.FilterLabels = filterLabels;
            this.Labels = labels;
            this.AfterDate = afterDate;
            this.BeforeDate = beforeDate;
            this.ShowChecked = showChecked;
            this.AuthorID = authorID;
            this.FilteredActionIds = filteredActionIds;
            this.FilteredChannelIds = filteredChannelIds;
            this.RecommendationActions = recommendationActions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueueViewOpenGetQueueResponseQueueFilter" /> class.
        /// </summary>
        public QueueViewOpenGetQueueResponseQueueFilter()
        {
        }
    }
}