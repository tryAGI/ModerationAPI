
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// Request counts for the window. A flagged request has one recommendation: allow, reject or review.
    /// </summary>
    public sealed partial class GetAnalyticsSummaryResponseTotals
    {
        /// <summary>
        /// Requests received. Every request counts, also repeats and edits of the same content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requests")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Requests { get; set; }

        /// <summary>
        /// Requests that were flagged.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("flagged")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Flagged { get; set; }

        /// <summary>
        /// The share of requests that were flagged: flagged / requests. 0 when there were no requests.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("flagRate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double FlagRate { get; set; }

        /// <summary>
        /// Requests with the recommendation "allow". Includes content that was not flagged.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Allowed { get; set; }

        /// <summary>
        /// Requests with the recommendation "reject". All of them were flagged.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rejected")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Rejected { get; set; }

        /// <summary>
        /// Requests with the recommendation "review". This counts requests, not the deduplicated items in the review queue.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sentToReview")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SentToReview { get; set; }

        /// <summary>
        /// Flagged requests that were settled without human review: rejected plus flaggedButAllowed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("handledAutomatically")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int HandledAutomatically { get; set; }

        /// <summary>
        /// Flagged requests that were allowed without human review.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("flaggedButAllowed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int FlaggedButAllowed { get; set; }

        /// <summary>
        /// Distinct authors that sent content in the window. Approximate.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("distinctAuthors")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int DistinctAuthors { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnalyticsSummaryResponseTotals" /> class.
        /// </summary>
        /// <param name="requests">
        /// Requests received. Every request counts, also repeats and edits of the same content.
        /// </param>
        /// <param name="flagged">
        /// Requests that were flagged.
        /// </param>
        /// <param name="flagRate">
        /// The share of requests that were flagged: flagged / requests. 0 when there were no requests.
        /// </param>
        /// <param name="allowed">
        /// Requests with the recommendation "allow". Includes content that was not flagged.
        /// </param>
        /// <param name="rejected">
        /// Requests with the recommendation "reject". All of them were flagged.
        /// </param>
        /// <param name="sentToReview">
        /// Requests with the recommendation "review". This counts requests, not the deduplicated items in the review queue.
        /// </param>
        /// <param name="handledAutomatically">
        /// Flagged requests that were settled without human review: rejected plus flaggedButAllowed.
        /// </param>
        /// <param name="flaggedButAllowed">
        /// Flagged requests that were allowed without human review.
        /// </param>
        /// <param name="distinctAuthors">
        /// Distinct authors that sent content in the window. Approximate.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAnalyticsSummaryResponseTotals(
            int requests,
            int flagged,
            double flagRate,
            int allowed,
            int rejected,
            int sentToReview,
            int handledAutomatically,
            int flaggedButAllowed,
            int distinctAuthors)
        {
            this.Requests = requests;
            this.Flagged = flagged;
            this.FlagRate = flagRate;
            this.Allowed = allowed;
            this.Rejected = rejected;
            this.SentToReview = sentToReview;
            this.HandledAutomatically = handledAutomatically;
            this.FlaggedButAllowed = flaggedButAllowed;
            this.DistinctAuthors = distinctAuthors;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnalyticsSummaryResponseTotals" /> class.
        /// </summary>
        public GetAnalyticsSummaryResponseTotals()
        {
        }

    }
}