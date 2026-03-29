
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class QueueViewOpenGetStatsResponseReviewStats
    {
        /// <summary>
        /// Average time in milliseconds to review an item
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("averageTimeToReview")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double AverageTimeToReview { get; set; }

        /// <summary>
        /// Total number of items reviewed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalReviewed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TotalReviewed { get; set; }

        /// <summary>
        /// Total number of items pending review
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalPending")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TotalPending { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QueueViewOpenGetStatsResponseReviewStats" /> class.
        /// </summary>
        /// <param name="averageTimeToReview">
        /// Average time in milliseconds to review an item
        /// </param>
        /// <param name="totalReviewed">
        /// Total number of items reviewed
        /// </param>
        /// <param name="totalPending">
        /// Total number of items pending review
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QueueViewOpenGetStatsResponseReviewStats(
            double averageTimeToReview,
            double totalReviewed,
            double totalPending)
        {
            this.AverageTimeToReview = averageTimeToReview;
            this.TotalReviewed = totalReviewed;
            this.TotalPending = totalPending;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueueViewOpenGetStatsResponseReviewStats" /> class.
        /// </summary>
        public QueueViewOpenGetStatsResponseReviewStats()
        {
        }
    }
}