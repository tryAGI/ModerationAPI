
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class QueueViewOpenGetStatsResponseTrendsDailyReviewCount
    {
        /// <summary>
        /// Date in YYYY-MM-DD format
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("date")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Date { get; set; }

        /// <summary>
        /// Number of reviews on this date
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Count { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QueueViewOpenGetStatsResponseTrendsDailyReviewCount" /> class.
        /// </summary>
        /// <param name="date">
        /// Date in YYYY-MM-DD format
        /// </param>
        /// <param name="count">
        /// Number of reviews on this date
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QueueViewOpenGetStatsResponseTrendsDailyReviewCount(
            string date,
            double count)
        {
            this.Date = date ?? throw new global::System.ArgumentNullException(nameof(date));
            this.Count = count;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueueViewOpenGetStatsResponseTrendsDailyReviewCount" /> class.
        /// </summary>
        public QueueViewOpenGetStatsResponseTrendsDailyReviewCount()
        {
        }
    }
}