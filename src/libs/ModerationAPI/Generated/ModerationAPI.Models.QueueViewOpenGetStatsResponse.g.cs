
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class QueueViewOpenGetStatsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reviewStats")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ModerationAPI.QueueViewOpenGetStatsResponseReviewStats ReviewStats { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actionStats")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ModerationAPI.QueueViewOpenGetStatsResponseActionStat> ActionStats { get; set; }

        /// <summary>
        /// List of top reviewers and their statistics
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("topReviewers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ModerationAPI.QueueViewOpenGetStatsResponseTopReviewer> TopReviewers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trends")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ModerationAPI.QueueViewOpenGetStatsResponseTrends Trends { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QueueViewOpenGetStatsResponse" /> class.
        /// </summary>
        /// <param name="reviewStats"></param>
        /// <param name="actionStats"></param>
        /// <param name="topReviewers">
        /// List of top reviewers and their statistics
        /// </param>
        /// <param name="trends"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QueueViewOpenGetStatsResponse(
            global::ModerationAPI.QueueViewOpenGetStatsResponseReviewStats reviewStats,
            global::System.Collections.Generic.IList<global::ModerationAPI.QueueViewOpenGetStatsResponseActionStat> actionStats,
            global::System.Collections.Generic.IList<global::ModerationAPI.QueueViewOpenGetStatsResponseTopReviewer> topReviewers,
            global::ModerationAPI.QueueViewOpenGetStatsResponseTrends trends)
        {
            this.ReviewStats = reviewStats ?? throw new global::System.ArgumentNullException(nameof(reviewStats));
            this.ActionStats = actionStats ?? throw new global::System.ArgumentNullException(nameof(actionStats));
            this.TopReviewers = topReviewers ?? throw new global::System.ArgumentNullException(nameof(topReviewers));
            this.Trends = trends ?? throw new global::System.ArgumentNullException(nameof(trends));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueueViewOpenGetStatsResponse" /> class.
        /// </summary>
        public QueueViewOpenGetStatsResponse()
        {
        }
    }
}