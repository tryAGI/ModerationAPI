
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class QueueViewOpenGetStatsResponseTopReviewer
    {
        /// <summary>
        /// ID of the reviewer
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

        /// <summary>
        /// Name of the reviewer
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Number of items reviewed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reviewCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ReviewCount { get; set; }

        /// <summary>
        /// Average review time in milliseconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("averageTimePerReview")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double AverageTimePerReview { get; set; }

        /// <summary>
        /// Optional accuracy score based on review quality metrics
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accuracyScore")]
        public double? AccuracyScore { get; set; }

        /// <summary>
        /// Most common actions taken by this reviewer
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("topActions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ModerationAPI.QueueViewOpenGetStatsResponseTopReviewerTopAction> TopActions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QueueViewOpenGetStatsResponseTopReviewer" /> class.
        /// </summary>
        /// <param name="userId">
        /// ID of the reviewer
        /// </param>
        /// <param name="name">
        /// Name of the reviewer
        /// </param>
        /// <param name="reviewCount">
        /// Number of items reviewed
        /// </param>
        /// <param name="averageTimePerReview">
        /// Average review time in milliseconds
        /// </param>
        /// <param name="topActions">
        /// Most common actions taken by this reviewer
        /// </param>
        /// <param name="accuracyScore">
        /// Optional accuracy score based on review quality metrics
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QueueViewOpenGetStatsResponseTopReviewer(
            string userId,
            string name,
            double reviewCount,
            double averageTimePerReview,
            global::System.Collections.Generic.IList<global::ModerationAPI.QueueViewOpenGetStatsResponseTopReviewerTopAction> topActions,
            double? accuracyScore)
        {
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.ReviewCount = reviewCount;
            this.AverageTimePerReview = averageTimePerReview;
            this.AccuracyScore = accuracyScore;
            this.TopActions = topActions ?? throw new global::System.ArgumentNullException(nameof(topActions));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueueViewOpenGetStatsResponseTopReviewer" /> class.
        /// </summary>
        public QueueViewOpenGetStatsResponseTopReviewer()
        {
        }
    }
}