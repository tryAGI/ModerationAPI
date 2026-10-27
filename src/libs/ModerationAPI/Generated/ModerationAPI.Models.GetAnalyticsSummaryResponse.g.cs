
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetAnalyticsSummaryResponse
    {
        /// <summary>
        /// The time window of the numbers.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("range")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ModerationAPI.JsonConverters.GetAnalyticsSummaryResponseRangeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ModerationAPI.GetAnalyticsSummaryResponseRange Range { get; set; }

        /// <summary>
        /// The channel the numbers are for. Null when they are for all channels.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("channelId")]
        public string? ChannelId { get; set; }

        /// <summary>
        /// Request counts for the window. A flagged request has one recommendation: allow, reject or review.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totals")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ModerationAPI.GetAnalyticsSummaryResponseTotals Totals { get; set; }

        /// <summary>
        /// The same counts for the window of equal length just before this one. Compare with `totals` to see the trend.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previousPeriod")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ModerationAPI.GetAnalyticsSummaryResponsePreviousPeriod PreviousPeriod { get; set; }

        /// <summary>
        /// Items in the default review queue that nobody has reviewed yet, counted as the queue counts them (repeats count once). The queue looks back 30 days, so older items are not included. The range does not change it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pendingReview")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PendingReview { get; set; }

        /// <summary>
        /// Set when the flag rate of the last 2 days is at least 2 times the rate of the 30 days before, with at least 50 flagged requests. Null when there is no spike. Always for the full project: the range and channel do not change it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("flagRateSpike")]
        public global::ModerationAPI.GetAnalyticsSummaryResponseFlagRateSpike? FlagRateSpike { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnalyticsSummaryResponse" /> class.
        /// </summary>
        /// <param name="range">
        /// The time window of the numbers.
        /// </param>
        /// <param name="totals">
        /// Request counts for the window. A flagged request has one recommendation: allow, reject or review.
        /// </param>
        /// <param name="previousPeriod">
        /// The same counts for the window of equal length just before this one. Compare with `totals` to see the trend.
        /// </param>
        /// <param name="pendingReview">
        /// Items in the default review queue that nobody has reviewed yet, counted as the queue counts them (repeats count once). The queue looks back 30 days, so older items are not included. The range does not change it.
        /// </param>
        /// <param name="channelId">
        /// The channel the numbers are for. Null when they are for all channels.
        /// </param>
        /// <param name="flagRateSpike">
        /// Set when the flag rate of the last 2 days is at least 2 times the rate of the 30 days before, with at least 50 flagged requests. Null when there is no spike. Always for the full project: the range and channel do not change it.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAnalyticsSummaryResponse(
            global::ModerationAPI.GetAnalyticsSummaryResponseRange range,
            global::ModerationAPI.GetAnalyticsSummaryResponseTotals totals,
            global::ModerationAPI.GetAnalyticsSummaryResponsePreviousPeriod previousPeriod,
            int pendingReview,
            string? channelId,
            global::ModerationAPI.GetAnalyticsSummaryResponseFlagRateSpike? flagRateSpike)
        {
            this.Range = range;
            this.ChannelId = channelId;
            this.Totals = totals ?? throw new global::System.ArgumentNullException(nameof(totals));
            this.PreviousPeriod = previousPeriod ?? throw new global::System.ArgumentNullException(nameof(previousPeriod));
            this.PendingReview = pendingReview;
            this.FlagRateSpike = flagRateSpike;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnalyticsSummaryResponse" /> class.
        /// </summary>
        public GetAnalyticsSummaryResponse()
        {
        }

    }
}