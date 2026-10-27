
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class QueueViewOpenGetStatsResponseReviewStats
    {
        /// <summary>
        /// Number of items resolved in this queue in the period.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalReviewed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalReviewed { get; set; }

        /// <summary>
        /// Number of items submitted in the period that wait for review now.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalPending")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalPending { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QueueViewOpenGetStatsResponseReviewStats" /> class.
        /// </summary>
        /// <param name="totalReviewed">
        /// Number of items resolved in this queue in the period.
        /// </param>
        /// <param name="totalPending">
        /// Number of items submitted in the period that wait for review now.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QueueViewOpenGetStatsResponseReviewStats(
            int totalReviewed,
            int totalPending)
        {
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