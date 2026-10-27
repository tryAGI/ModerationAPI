
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class QueueViewOpenGetStatsResponseTrends
    {
        /// <summary>
        /// Resolved items per day. Days with no reviews are left out.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dailyReviewCounts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ModerationAPI.QueueViewOpenGetStatsResponseTrendsDailyReviewCount> DailyReviewCounts { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QueueViewOpenGetStatsResponseTrends" /> class.
        /// </summary>
        /// <param name="dailyReviewCounts">
        /// Resolved items per day. Days with no reviews are left out.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QueueViewOpenGetStatsResponseTrends(
            global::System.Collections.Generic.IList<global::ModerationAPI.QueueViewOpenGetStatsResponseTrendsDailyReviewCount> dailyReviewCounts)
        {
            this.DailyReviewCounts = dailyReviewCounts ?? throw new global::System.ArgumentNullException(nameof(dailyReviewCounts));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueueViewOpenGetStatsResponseTrends" /> class.
        /// </summary>
        public QueueViewOpenGetStatsResponseTrends()
        {
        }

    }
}