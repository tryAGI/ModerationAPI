
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetAnalyticsAutomationResponse
    {
        /// <summary>
        /// The time window of the numbers.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("range")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ModerationAPI.JsonConverters.GetAnalyticsAutomationResponseRangeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ModerationAPI.GetAnalyticsAutomationResponseRange Range { get; set; }

        /// <summary>
        /// The channel the numbers are for. Null when they are for all channels.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("channelId")]
        public string? ChannelId { get; set; }

        /// <summary>
        /// Flagged requests in the window. Counted on a rolling window from the raw requests, so it can be a little different from the summary.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("flagged")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Flagged { get; set; }

        /// <summary>
        /// Flagged requests that a rule allowed or rejected without human review.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("handledByRules")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int HandledByRules { get; set; }

        /// <summary>
        /// Flagged requests that the casebook settled without human review.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("handledByCasebook")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int HandledByCasebook { get; set; }

        /// <summary>
        /// Distinct content items sent to the review queue. Repeats of the same content count once, as in the queue.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sentToReview")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SentToReview { get; set; }

        /// <summary>
        /// Flagged requests that the review queue merged into an item it already shows: repeats, edits and content that was settled later.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mergedDuplicates")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MergedDuplicates { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("automationRate")]
        public double? AutomationRate { get; set; }

        /// <summary>
        /// Review queue items from this window that a moderator allowed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reviewsAllowed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ReviewsAllowed { get; set; }

        /// <summary>
        /// Review queue items from this window that a moderator rejected.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reviewsRejected")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ReviewsRejected { get; set; }

        /// <summary>
        /// Review queue items from this window that a moderator marked as done without allow or reject.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reviewsResolvedWithoutDecision")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ReviewsResolvedWithoutDecision { get; set; }

        /// <summary>
        /// Review queue items from this window that are still open.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reviewsUnresolved")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ReviewsUnresolved { get; set; }

        /// <summary>
        /// Requests where the casebook decision was different from the decision based on severity.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("casebookOverrulings")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CasebookOverrulings { get; set; }

        /// <summary>
        /// The rules that settled flagged requests without review, largest first. The 5 largest have their own entry. The casebook is one of the rules.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rules")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ModerationAPI.GetAnalyticsAutomationResponseRule> Rules { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnalyticsAutomationResponse" /> class.
        /// </summary>
        /// <param name="range">
        /// The time window of the numbers.
        /// </param>
        /// <param name="flagged">
        /// Flagged requests in the window. Counted on a rolling window from the raw requests, so it can be a little different from the summary.
        /// </param>
        /// <param name="handledByRules">
        /// Flagged requests that a rule allowed or rejected without human review.
        /// </param>
        /// <param name="handledByCasebook">
        /// Flagged requests that the casebook settled without human review.
        /// </param>
        /// <param name="sentToReview">
        /// Distinct content items sent to the review queue. Repeats of the same content count once, as in the queue.
        /// </param>
        /// <param name="mergedDuplicates">
        /// Flagged requests that the review queue merged into an item it already shows: repeats, edits and content that was settled later.
        /// </param>
        /// <param name="reviewsAllowed">
        /// Review queue items from this window that a moderator allowed.
        /// </param>
        /// <param name="reviewsRejected">
        /// Review queue items from this window that a moderator rejected.
        /// </param>
        /// <param name="reviewsResolvedWithoutDecision">
        /// Review queue items from this window that a moderator marked as done without allow or reject.
        /// </param>
        /// <param name="reviewsUnresolved">
        /// Review queue items from this window that are still open.
        /// </param>
        /// <param name="casebookOverrulings">
        /// Requests where the casebook decision was different from the decision based on severity.
        /// </param>
        /// <param name="rules">
        /// The rules that settled flagged requests without review, largest first. The 5 largest have their own entry. The casebook is one of the rules.
        /// </param>
        /// <param name="channelId">
        /// The channel the numbers are for. Null when they are for all channels.
        /// </param>
        /// <param name="automationRate"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAnalyticsAutomationResponse(
            global::ModerationAPI.GetAnalyticsAutomationResponseRange range,
            int flagged,
            int handledByRules,
            int handledByCasebook,
            int sentToReview,
            int mergedDuplicates,
            int reviewsAllowed,
            int reviewsRejected,
            int reviewsResolvedWithoutDecision,
            int reviewsUnresolved,
            int casebookOverrulings,
            global::System.Collections.Generic.IList<global::ModerationAPI.GetAnalyticsAutomationResponseRule> rules,
            string? channelId,
            double? automationRate)
        {
            this.Range = range;
            this.ChannelId = channelId;
            this.Flagged = flagged;
            this.HandledByRules = handledByRules;
            this.HandledByCasebook = handledByCasebook;
            this.SentToReview = sentToReview;
            this.MergedDuplicates = mergedDuplicates;
            this.AutomationRate = automationRate;
            this.ReviewsAllowed = reviewsAllowed;
            this.ReviewsRejected = reviewsRejected;
            this.ReviewsResolvedWithoutDecision = reviewsResolvedWithoutDecision;
            this.ReviewsUnresolved = reviewsUnresolved;
            this.CasebookOverrulings = casebookOverrulings;
            this.Rules = rules ?? throw new global::System.ArgumentNullException(nameof(rules));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnalyticsAutomationResponse" /> class.
        /// </summary>
        public GetAnalyticsAutomationResponse()
        {
        }

    }
}